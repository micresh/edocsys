using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;

namespace Edocsys
{
    public class User
    {
        internal class UserTypeAccess
        {
            private UserTypeAccess()
            {}
            public UserTypeAccess(bool deflt, bool admin, bool director, bool expert)
            {
                this.Default = deflt;
                this.Admin = admin;
                this.Director = director;
                this.Expert = expert;
            }
            public bool Default {get; set;}
            public bool Admin { get; set; }
            public bool Director {get;set;}
            public bool Expert {get;set;}
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
        private Dictionary<string, UserTypeAccess> AccessItems = new Dictionary<string, UserTypeAccess>()
            {
                //TOP
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
                {"Contracts",           new UserTypeAccess(false, true, true, true)},
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
