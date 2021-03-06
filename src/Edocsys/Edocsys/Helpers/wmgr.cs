﻿using System;
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
            f.WindowState = FormWindowState.Maximized;
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
                f = new T();
            AssignFormToMDI(f);
        }

        //use generics to get form object
        private static Form GetForm<T>() where T : Form, new()
        {
            //try to find form
            Form f = FindForm(typeof(T));

            //if exists
            if (f == null)
                            //create form and add it to MDI list
                AssignFormToMDI(new T());

            f = FindForm(typeof(T));

            return f;
        }

        //use generics to create common ShowFormModal method
        private static void ShowDialogForm<T>() where T : Form, new()
        {
            //create new form
            Form f = new T();

            //activate form
            f.ShowDialog();
        }


        //use generics to create common ShowForm method
        private static T GetOrCreateForm<T>() where T : Form, new()
        {
            //try to find form
            Form f = FindForm(typeof(T));

            //if exists
            if (f == null)
                //create form and add it to MDI list
                f = new T();
            AssignFormToMDI(f);
            return (T)f;
        }

        public static void ShowLoginForm(string login)
        {
            LoginForm l = new LoginForm();

            l.selectedLogin = login;

            l.ShowDialog();
        }

        public static void ShowDeleteContractForm(int contract_id)
        {
            DeleteContractForm l = new DeleteContractForm();

            l.contract_id = contract_id;

            l.ShowDialog();
        }


        public static void ShowHelpForm()
        {
            HelpForm l = new HelpForm();

            l.ShowDialog();
        }

        public static void CloseAllOpendWindows()
        {
            foreach (Form f in MDIParent.MdiChildren)
            {
                f.Close();
            }
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

        public static void ShowProporsalForm(int agents_id)
        {
            ProposalForm f = GetOrCreateForm<ProposalForm>();

            f.AddNewProposalWithAgent(agents_id);

            ShowForm<ProposalForm>();
        }
        public static void ShowConfigForm()
        {
            ShowForm<ConfigForm>();
        }
        public static void ShowWorksForContractForm()
        {
            ShowForm<WorkForContractsForm>();
        }
        public static void ShowInspectionControlForm()
        {
            ShowForm<InspectionControlForm>();
        }
        public static void ShowContractStatsForm()
        {
            ShowForm<ContractStatsForm>();
        }
        public static void ShowContractPaymentsForm()
        {
            ShowForm<ContractPaymentsForm>();
        }
        public static void ShowAgentTypesForm()
        {
            ShowForm<AgentTypesForm>();
        }
        public static void ShowAboutForm()
        {
            AboutForm f = new AboutForm();

            f.ShowDialog();
        }
    }
}
