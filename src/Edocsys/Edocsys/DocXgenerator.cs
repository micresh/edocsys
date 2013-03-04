using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using System.Data;
using System.Diagnostics;
using Novacode;


namespace Edocsys
{
    class DocXGenerator
    {
        private const string SubstitutionFilename = "subs.txt";

        public static void RepalceKeyValuesInDocX(string filename, Dictionary<string, string> substitutions)
        {
                        //replace items
                DocX doc = DocX.Load(filename);

                foreach (KeyValuePair<string, string> item in substitutions)
                {
                    
                    if ((item.Key == "{_TOTAL_COST_}") | (item.Key == "{_COST_}"))
                    {
                        string key = item.Key;
                        string val = item.Value;
                        double summ = 0.0;
                        if (val != "")
                            summ = Convert.ToDouble(item.Value);
                        val = RuDateAndMoneyConverter.CurrencyToTxtFull_SBR(summ, true);
                        key = key.Substring(0, key.Length - 1) + "_STR_}";
                        doc.ReplaceText(item.Key, val);
                    }

                    doc.ReplaceText(item.Key, item.Value);
                    
                }

                doc.Save();
        }

        public static Dictionary<string, string> GetReplacementKeyValues(DataRow currentContact)
        {
            Dictionary<string, string> substitutions = new Dictionary<string,string>();

            StreamReader subsfile = new StreamReader(SubstitutionFilename);

            char[] charSeparators = new char[] { ' ', '\t' };

            string line;
            do
            {
                //читаем строку из файла и выводим на экран
                line = subsfile.ReadLine();

                string[] vals = line.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);

                string k = (string)vals[0];
                string f = (string)vals[1];
                string v = "___VALUE_NOT_FOUND__";
                try
                {
                    v = Convert.ToString(currentContact[f]);
                }
                catch (Exception ex)
                {
                    Trace.TraceWarning(String.Format("DocXGenerator: Ошибка извлечения данных: k: {0} => v: {1} [{2}]",  k, v, ex.Message));
                }

                substitutions.Add(k, v);
                
            }
            //продолжаем пока не достигнем конца файла
            while (!subsfile.EndOfStream);
            return substitutions;
        }
    }
}
