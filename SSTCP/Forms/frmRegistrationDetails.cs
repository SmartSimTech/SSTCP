using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SSTCP.Classes;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace SSTCP.Forms
{
    public partial class frmRegistrationDetails : DevExpress.XtraEditors.XtraForm
    {
        public frmRegistrationDetails()
        {
            InitializeComponent();
        }

        private void bbtnRegister_Click(object sender, EventArgs e)
        {
            clsBase64 base64 = new clsBase64();
            string regKey = "";
            try
            {
                regKey = base64.base64Decode(tbKey.Text);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Unable to decode the key, please check the key and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (regKey != "")
            {
                string[] regDetails = regKey.Split('|');
                string regName = regDetails[0];
                string regCompany = regDetails[1];

                if (regName == tbName.Text && regCompany == tbCompany.Text)
                {
                    // Registration Details Match, Save Key...
                    XPCollection collection = new XPCollection(typeof(Database.Registration));
                    if (collection.Count > 0)
                    {
                        Session.DefaultSession.Delete(collection);
                        Session.DefaultSession.Save(collection);
                    }
                    collection.Dispose();

                    Database.Registration dbRegistration = new Database.Registration();
                    dbRegistration.Name = regName;
                    dbRegistration.Company = regCompany;
                    dbRegistration.Key = tbKey.Text;
                    dbRegistration.Save();

                    Close();
                }
                else
                {
                    XtraMessageBox.Show("The details you entered do not match the key, please check the details and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                XtraMessageBox.Show("Registration Key cannot be blank, please enter a key and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmRegistrationDetails_Load(object sender, EventArgs e)
        {
            tbName.Focus();
        }

        private void frmRegistrationDetails_Activated(object sender, EventArgs e)
        {
        
        }

        private void hyperLinkEdit1_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.smartsimtech.com/index.php?id=44");
        }

        private void bbtnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}