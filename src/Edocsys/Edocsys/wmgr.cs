using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Edocsys
{
   public static class wmgr
   {
      private static Form MDIParent;

      public static void SetMDIParent(Form MDIParent)
      {
         wmgr.MDIParent = MDIParent;
      }

      public static void ShowClientsForm()
      {
         foreach (Form f in MDIParent.MdiChildren)
         {
            //detect form's class
            if (f is ClientsForm)
            {
               //if exists => activate form
               f.BringToFront();
               f.Activate();
               break;
            }
         }
         //for not created
         if (MDIParent.ActiveMdiChild == null || (MDIParent.ActiveMdiChild.Name != "ClientsForm"))
         {
            //make new one
            ClientsForm MDIClientsForm = new ClientsForm();
            MDIClientsForm.MdiParent = MDIParent;
            MDIClientsForm.Show();
         }
      }
   }
}
