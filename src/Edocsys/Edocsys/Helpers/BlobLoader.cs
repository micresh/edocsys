using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.IO;

namespace Edocsys
{
    class BlobLoader
    {
        private const string extension = "docx";

        public static DataRow GetRow(string tablename, int type)
        {
            return null;
        }

        public static string SaveToTemporaryFile(byte[] data)
        {
            //make temporary file
            string filename = System.IO.Path.GetTempFileName() + "." + extension;
            
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);

            fs.Write(data, 0, data.Length);
            
            fs.Close();

            return filename;
        }

        public static void SaveToFile(string filename, byte[] data)
        {
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);

            fs.Write(data, 0, data.Length);

            fs.Close();
        }

        public static byte[] LoadFormFile(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);

            byte[] data = new byte[fs.Length];

            fs.Read(data, 0, Convert.ToInt32(fs.Length));

            fs.Close();

            return data;
        }

    }
}
