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
         //assign parent
         f.MdiParent = MDIParent;
         f.Show();
      }

      //use generics to create common ShowForm method
      private static void ShowForm<T>() where T : Form, new()
      {
         //try to find form
         Form f = FindForm(typeof(T));

         //if exists
         if (f != null)
            //activate form
            ActivateForm(f);
         else
            //create form and add it to MDI list
            AssignFormToMDI(new T());
      }

      public static void ShowLoginForm()
      {
         ShowForm<LoginForm>();
      }

      public static void ShowClientsForm()
      {
         ShowForm<ClientsForm>();
      }
      public static void ShowUseradmForm()
      {
          ShowForm<UseradmForm>();
      }
      public static void ShowAssignexpertForm()
      {
          ShowForm<AssignExpertForm>();
      }
      public static void ShowContractsForm()
      {
          ShowForm<ContractsForm>();
      }
      public static void ShowDocTemplatesForm()
      {
          ShowForm<DocTemplatesForm>();
      }
      public static void ShowExpertsForm()
      {
          ShowForm<ExpertsForm>();
      }
      public static void ShowProductionForm()
      {
          ShowForm<ProductionForm>();
      }
      public static void ShowProporsalForm()
      {
          ShowForm<ProposalForm>();
      }
      public static void ShowReportClientForm()
      {
          ShowForm<ReportClientForm>();
      }
   }
}
