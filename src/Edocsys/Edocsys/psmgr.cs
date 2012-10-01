using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace Edocsys
{
   public static class psmgr
    {
       public static string GetHashString (string source)
       {
           string result;
           using (MD5 md5hash = MD5.Create())
           {
               string hash;
               hash = GetMD5hash(md5hash, source);
               result = hash;
           }
           return result;
       }

       public static bool VerifyHash (string source)
       {
           bool t;
           using (MD5 md5hash = MD5.Create())
           {
               string hash;
               hash = GetMD5hash(md5hash, source);
               t = VerifyMd5Hash(md5hash, source, hash);
           }
           return t;
       }

       private static string GetMD5hash(MD5 md5Hash, string input)
       {
           // Convert the input string to a byte array and compute the hash.
           byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

           // Create a new Stringbuilder to collect the bytes
           // and create a string.
           StringBuilder sBuilder = new StringBuilder();

           // Loop through each byte of the hashed data 
           // and format each one as a hexadecimal string.
           for (int i = 0; i < data.Length; i++)
           {
               sBuilder.Append(data[i].ToString("x2"));
           }

           // Return the hexadecimal string.
           return sBuilder.ToString();
       }
        private static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
       {
           // Hash the input.
           string hashOfInput = GetMD5hash (md5Hash, input);

           // Create a StringComparer an compare the hashes.
           StringComparer comparer = StringComparer.OrdinalIgnoreCase;

           if (0 == comparer.Compare(hashOfInput, hash))
           {
               return true;
           }
           else
           {
               return false;
           }
       }
    }
}
