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

      private static Form FindForm(Type FormType)
      {
         foreach (Form f in MDIParent.MdiChildren)
         {
            //detect form's class
            if (f.GetType() == FormType)
               //if exists => return form
               return f;
         }
         return null;
      }

      private static void ActivateForm(Form f)
      {
         f.BringToFront();
         f.Activate();
      }

      private static void AssignFormToMDI(Form f)
      {
         f.MdiParent = MDIParent;
         f.Show();
      }

      public static void ShowLoginForm()
      {
         Form f = FindForm(typeof(LoginForm));

         if (f != null)
            //activate form
            ActivateForm(f);
         else
         {
            LoginForm newForm = new LoginForm();
            AssignFormToMDI(newForm);
         }
      }

      public static void ShowClientsForm()
      {
         Form f = FindForm(typeof(ClientsForm));

         if (f != null)
            //activate form
            ActivateForm(f);
         else
         {
            ClientsForm newForm = new ClientsForm();
            AssignFormToMDI(newForm);
         }
      }
   }
}
