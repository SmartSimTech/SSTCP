using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace SSTCP.Forms
{
    public partial class frmAddCardWizard : DevExpress.XtraEditors.XtraForm
    {
        Database.Cards cardDB = new Database.Cards();
        public frmAddCardWizard()
        {
            InitializeComponent();
        }

        private void frmAddCardWizard_Load(object sender, EventArgs e)
        {
            // Load Card Model Numbers
            cbModelNumber.Properties.Items.Add("Select Model Number");
            cbModelNumber.Properties.Items.Add("SST30I");

            cbModelNumber.SelectedIndex = 0;
        }

        private void cbModelNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbModelNumber.Text)
            {
                case "SST30I":
                    cbRevisionNumber.Properties.Items.Clear();
                    cbRevisionNumber.Properties.Items.Add("Select Revision Number");
                    cbRevisionNumber.SelectedIndex = 0;

                    cbRevisionNumber.Properties.Items.Add("Beta");
                    cbRevisionNumber.Properties.Items.Add("R1");
                    break;

                default:
                    cbRevisionNumber.Properties.Items.Clear();
                    cbRevisionNumber.Text = "";
                    tbSerialNumber.Text = "";
                    break;
            }
            CheckRequiredFields();
        }

        private void lnkHelp_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            
        }

        private void cbRevisionNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSerialNumber.Text = "";
            CheckRequiredFields();
        }

        private void CheckRequiredFields()
        {
            if (cbModelNumber.Text != "" && cbModelNumber.Text != "Select Model Number")
                if (cbRevisionNumber.Text != "" && cbRevisionNumber.Text != "Select Revision Number")
                    if (tbSerialNumber.Text != "")
                        welcomeWizardPage1.AllowNext = true;
                    else
                        welcomeWizardPage1.AllowNext = false;
        }

        private void tbSerialNumber_EditValueChanged(object sender, EventArgs e)
        {
            CheckRequiredFields();
        }

        private void wizardControl1_SelectedPageChanging(object sender, DevExpress.XtraWizard.WizardPageChangingEventArgs e)
        {
            if (e.PrevPage == welcomeWizardPage1 && e.Direction == DevExpress.XtraWizard.Direction.Forward)
            {
                meCardDetails.Text = String.Format("Please confirm that you wish to add a {0}{1} with a Serial Number of {2} to the system.  These details are not able to be edited once added to the system.  If anything is incorrect, please click the back button now to fix them.", cbModelNumber.Text, cbRevisionNumber.Text, tbSerialNumber.Text);
            }

            if (e.PrevPage == wizardPage1 && e.Direction == DevExpress.XtraWizard.Direction.Forward)
            {
                lblStep1Error.Text = "";    // Clear Error Box

                // Add Card Details to the Database
                cardDB.CardModel = cbModelNumber.Text;
                cardDB.CardRevision = cbRevisionNumber.Text;
                cardDB.CardSerialNumber = Convert.ToInt32(tbSerialNumber.Text);

                XPCollection collection = new XPCollection(typeof(Database.Cards), CriteriaOperator.Parse(String.Format("CardModel == '{0}' AND CardRevision == '{1}' AND CardSerialNumber = {2}", cbModelNumber.Text, cbRevisionNumber.Text, Convert.ToInt32(tbSerialNumber.Text))));
                if (collection.Count == 0)
                {
                    tbCardName.Text = String.Format("{0}{1} [{2}]", cbModelNumber.Text, cbRevisionNumber.Text, tbSerialNumber.Text);
                }
                else
                {
                    lblStep1Error.Text = "The card you are trying to add already exists in the system, please check the card and try again.";
                    e.Page = welcomeWizardPage1;
                }
                collection.Dispose();
            }

            if (e.PrevPage == wizardPage2 && e.Direction == DevExpress.XtraWizard.Direction.Forward)
            {
                if (tbCardName.Text == "")
                    tbCardName.Text = String.Format("{0}{1} [{2}]", cbModelNumber.Text, cbRevisionNumber.Text, tbSerialNumber.Text);

                cardDB.CardName = tbCardName.Text;
                cardDB.CardDescription = tbCardDescription.Text;

                cardDB.Save();
            }
        }
    }
}