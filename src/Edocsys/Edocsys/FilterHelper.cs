using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Edocsys
{
    class FilterHelper
    {
        public FilterHelper(BindingSource source, string fieldName)
        {
            this.FieldName = fieldName;
            this.Source = source;
        }

        public void ApplyFilter(string value)
        {
            if (value != String.Empty)
                Source.Filter = FieldName + " LIKE '%" + value + "%'";
            else
                ResetFilter();
        }

        public void ResetFilter()
        {
            Source.Filter = "";
        }

        public BindingSource Source
        {
            get;
            set;
        }
        public string FieldName
        {
            get;
            set;
        }
    }
}
