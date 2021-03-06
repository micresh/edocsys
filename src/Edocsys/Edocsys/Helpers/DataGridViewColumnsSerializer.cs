﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Configuration;
using System.Windows.Forms;
using System.Reflection;
using System.Xml.Serialization;
using System.IO;

namespace Edocsys.Helpers
{
    public class DataGridViewColumnsSerializer
    {
        [Serializable()]
        public sealed class GridColumnItem
        {
            public int DisplayIndex { get; set; }
            public int Width { get; set; }
            public bool Visible { get; set; }
            public int ColumnIndex { get; set; }
            public string Name { get; set; }
            public string DataPropertyName { get; set; }
        }

        [Serializable()]
        public sealed class GridColumnsList
        {
            public string ItemName { get; set; }
            public List<GridColumnItem> Items;
        }

        private DataGridViewColumnsSerializer()
        { }

        private Form form;
        private DataGridView grid;

        public string Key { get; set; }


        private static string MakeItemKeyName(Form form, DataGridView grid)
        {
            return form.Name + "_x_" + grid.Name;
        }

        public DataGridViewColumnsSerializer(Form form, DataGridView grid)
        {
            DataGridViewColumnsSerializer.InitDataGridViewColumnsSerializer();

            this.form = form;
            this.grid = grid;

            this.Key = MakeItemKeyName(form, grid);

            SetUpGridColumns();

            form.FormClosed += FormClosedHandler;
            grid.ColumnWidthChanged += ColumnWidthChangedHandler;
        }

        public void FormClosedHandler(object sender, FormClosedEventArgs e)
        {
            SerializeItems();
        }

        private void ColumnWidthChangedHandler(object sender, DataGridViewColumnEventArgs e)
        {
            SaveColumnsData();
        }

        public void SetUpGridColumns()
        {
            ReloadItems();

            if (!DataGridViewColumnsSerializer.Grids.ContainsKey(this.Key))
            {
                // Set Columns defaults
                GridColumnsList cl = GetColumnsDefaults(this.Key);

                //Quit if there is no config
                if (cl == null)
                    return;

                DataGridViewColumnsSerializer.Grids[this.Key] = cl;
            }

            GridColumnsList columnOrder = DataGridViewColumnsSerializer.Grids[this.Key];

            if (columnOrder != null)
            {
                foreach (GridColumnItem item in columnOrder.Items)
                {
                    this.grid.Columns[item.ColumnIndex].DisplayIndex = item.DisplayIndex;
                    this.grid.Columns[item.ColumnIndex].Visible = item.Visible;
                    this.grid.Columns[item.ColumnIndex].Width = item.Width;
                }

                DataGridViewColumnsSerializer.Grids[this.Key] = columnOrder;
            }
        }

        private GridColumnsList GetColumnsDefaults(string key)
        {
            GridColumnsList list = null;
            foreach (GridColumnsList item in DataGridViewColumnsSerializer.ColumnsListDefaults)
            {
                if (item.ItemName == key)
                {
                    list = item;
                    break;
                }
            }
            return list;
        }

        public void SaveColumnsData()
        {
            List<GridColumnItem> columnOrder = new List<GridColumnItem>();

            DataGridViewColumnCollection columns = grid.Columns;

            for (int i = 0; i < columns.Count; i++)
            {
                columnOrder.Add(new GridColumnItem
                {
                    ColumnIndex = i,
                    DisplayIndex = columns[i].DisplayIndex,
                    Visible = columns[i].Visible,
                    Width = columns[i].Width,
                    Name = columns[i].Name,
                    DataPropertyName = columns[i].DataPropertyName
                });
            }

            GridColumnsList cl = new GridColumnsList();
            cl.Items = columnOrder;
            cl.ItemName = this.Key;

            DataGridViewColumnsSerializer.Grids[this.Key] = cl;
        }



        // Static part
        private static Dictionary<string, GridColumnsList> Grids { get; set; }

        private static List<GridColumnsList> ColumnsListDefaults { get; set; }
        private static string ConfigVersion = "0.00.001";

        public static void InitDataGridViewColumnsSerializer()
        {
            if (DataGridViewColumnsSerializer.Grids == null)
                DataGridViewColumnsSerializer.Grids = new Dictionary<string, GridColumnsList>();

            if (DataGridViewColumnsSerializer.ColumnsListDefaults == null)
                DataGridViewColumnsSerializer.LoadGridColumnsDefaults();

            ReloadItems();
        }

        public static void ReloadItems()
        {
            DataGridViewSettings.Default.Reload();

            foreach (GridColumnsList item in DataGridViewSettings.Default.ColumnsList)
            {
                DataGridViewColumnsSerializer.Grids[item.ItemName] = item;
            }
        }

        public static void SerializeItems()
        {
            DataGridViewSettings.Default.ColumnsList.Clear();

            foreach (KeyValuePair<string, GridColumnsList> item in  DataGridViewColumnsSerializer.Grids)
            {
                GridColumnsList cl = new GridColumnsList();
                cl.ItemName = item.Key;
                cl.Items = item.Value.Items;

                DataGridViewSettings.Default.ColumnsList.Add(cl);
            }

            DataGridViewSettings.Default.Save();

            // Uncomment to create/update new default Columns.config
            //SaveGridColumnsDefaults();
        }

        public static void SaveGridColumnsDefaults()
        {
            FileStream fileStream = new FileStream(@"Columns.config", FileMode.Create);

            XmlSerializer serializer = new XmlSerializer(typeof(List<GridColumnsList>));
            serializer.Serialize(fileStream, DataGridViewSettings.Default.ColumnsList);

            fileStream.Close();
        }

        public static void LoadGridColumnsDefaults()
        {
            FileStream fileStream = new FileStream(@"Columns.config", FileMode.Open);

            if (fileStream.Length == 0)
                return;

            XmlSerializer serializer = new XmlSerializer(typeof(List<GridColumnsList>));
            DataGridViewColumnsSerializer.ColumnsListDefaults = (List<GridColumnsList>)serializer.Deserialize(fileStream);

            fileStream.Close();
        }

        public static void UpdateConfigVersion()
        {
            if (DataGridViewColumnsSerializer.ConfigVersion != DataGridViewSettings.Default.ConfigVersion)
            {
                // Clear current settings
                DataGridViewSettings.Default.ColumnsList.Clear();
                DataGridViewSettings.Default.ConfigVersion = DataGridViewColumnsSerializer.ConfigVersion;
                DataGridViewColumnsSerializer.Grids.Clear();
            }
        }



        //Serializer class
        internal sealed class DataGridViewSettings : ApplicationSettingsBase
        {
            private static DataGridViewSettings _defaultInstace =
                (DataGridViewSettings)ApplicationSettingsBase.Synchronized(new DataGridViewSettings());

            public static DataGridViewSettings Default
            {
                get { return _defaultInstace; }
            }

            [UserScopedSetting]
            [SettingsSerializeAs(SettingsSerializeAs.Xml)]
            [DefaultSettingValue("")]
            public List<GridColumnsList> ColumnsList
            {
                get
                {
                    return this["ColumnsList"] as List<GridColumnsList>;
                }
                set
                {
                    this["ColumnsList"] = (List<GridColumnsList>)value;
                }
            }
            [UserScopedSetting]
            [SettingsSerializeAs(SettingsSerializeAs.Xml)]
            [DefaultSettingValue("0.00.001")]
            public string ConfigVersion
            {
                get
                {
                    return this["ConfigVersion"] as string;
                }
                set
                {
                    this["ConfigVersion"] = value;
                }
            }

        }
    }
}
