using System;
using System.Collections.Generic;
using System.Text;

using System.Security.Cryptography;


namespace Edocsys
{
    public class User
    {
        public static bool VerifyHash(string source, string pass)
        {
            bool t;
            using (MD5 md5hash = MD5.Create())
            {
                t = VerifyMd5Hash(md5hash, source, pass);
            }
            return t;
        }

        private static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Hash the input.
            string hashOfInput = GetMD5hash(md5Hash, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            return (comparer.Compare(hashOfInput, hash) == 0);

        }

        // копипаста с msdn+
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

        public int UserID
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public int UserType
        {
            get;
            set;
        }

        public bool HasAccess(string menuItem)
        {
            switch (UserType)
            {
                case (int)Constants.UserTypes.Admin:
                    if (AccessItems.ContainsKey(menuItem))
                        return ((UserTypeAccess)AccessItems[menuItem]).Admin;
                    break;
                case (int)Constants.UserTypes.Director:
                    if (AccessItems.ContainsKey(menuItem))
                        return ((UserTypeAccess)AccessItems[menuItem]).Director;
                        break;
                case (int)Constants.UserTypes.Expert:
                    if (AccessItems.ContainsKey(menuItem))
                        return ((UserTypeAccess)AccessItems[menuItem]).Expert;
                        break;
                default:
                    if (AccessItems.ContainsKey(menuItem))
                        return ((UserTypeAccess)AccessItems[menuItem]).Default;
                        break;
            }

            return false;
        }

        internal class UserTypeAccess
        {
            private UserTypeAccess()
            { }
            public UserTypeAccess(bool deflt, bool admin, bool director, bool expert)
            {
                this.Default = deflt;
                this.Admin = admin;
                this.Director = director;
                this.Expert = expert;
            }
            public bool Default { get; set; }
            public bool Admin { get; set; }
            public bool Director { get; set; }
            public bool Expert { get; set; }
        }


        private Dictionary<string, UserTypeAccess> AccessItems = new Dictionary<string, UserTypeAccess>()
            {
                //TOP                                          DEFLT  ADM  DIRCT EXPERT
                {"FileMenu",                new UserTypeAccess(true,  true, true, true)},
                {"WorkMenu",                new UserTypeAccess(false, true, true, true)},
                {"AdminMenu",               new UserTypeAccess(false, true, true, false)},
                //WindowToolStripMenuItem
                {"dowToolStripMenuItem",    new UserTypeAccess(true,  true, true, true)},
                {"Help",                    new UserTypeAccess(true,  true, true, true)},

                //FileMenu
                {"Config",              new UserTypeAccess(true,  true,  true,  true)},
                {"Login",               new UserTypeAccess(true,  false, false, false)},
                {"Logout",              new UserTypeAccess(false, true,  true,  true)},
                {"Exit",                new UserTypeAccess(true,  true,  true,  true)},

                //WorkMenu
                {"Agents",              new UserTypeAccess(false, true, true, true)},
                {"Proposals",           new UserTypeAccess(false, true, true, true)},
                {"AssignExpert",        new UserTypeAccess(false, true, true, false)},
                {"Contracts",           new UserTypeAccess(false, true, true, false)},
                {"WorkForContracts",    new UserTypeAccess(false, true, true, true)},
                {"ContractPayments",    new UserTypeAccess(false, true, true, false)},
                {"InspectionControl",   new UserTypeAccess(false, true, true, true)},
                {"ContractStats",       new UserTypeAccess(false, true, true, false)},

                //AdminMenu
                {"UserAdmin",           new UserTypeAccess(false, true, false, false)},
                {"Experts",             new UserTypeAccess(false, true, true, false)},
                {"DocTemplates",        new UserTypeAccess(false, true, true, false)},
                {"Production",          new UserTypeAccess(false, true, true, false)},

                //Toolstrip
                {"FillUsers",           new UserTypeAccess(true, true, true, true)},
                {"UsersCBox",           new UserTypeAccess(true, true, true, true)},
            };
    }
}
