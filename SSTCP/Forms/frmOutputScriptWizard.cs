using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace SSTCP.Forms
{
    public partial class frmOutputScriptWizard : DevExpress.XtraEditors.XtraForm
    {
        private string _CardRevision;
        private Int32 _CardSerialNumber;
        private string _CardModel;
        private bool _Canceled = true;

        Database.AnalogOutputScripts db = new Database.AnalogOutputScripts();

        private string _ByteSample = @"'Byte Sample
'if (offsetvalue = 0) then          'Offset is off
'   Host.SetOutput(1, false)        'Turn output #1 off
'else                               'if offset is anything other than 0
'   Host.SetOutput(1, true)         'Turn output #1 on
'end if
'''' This is just a quick sample, check the support pages on http://www.smartsimtech.com for more examples";

        private string _BitSample = @"'Bit Sample
'if (offsetvalue = 0) then          'Offset is off (0 = off, 1 = on)
'   Host.SetOutput(1, false)        'Turn output #1 off
'else                               'if offset bit is on
'   Host.SetOutput(1, true)         'Turn output #1 on
'end if
'''' This is just a quick sample, check the support pages on http://www.smartsimtech.com for more examples";
                                     
        public string CardRevision
        {
            set
            {
                _CardRevision = value;
            }
        }

        public string CardModel
        {
            set
            {
                _CardModel = value;
            }
        }

        public Int32 CardSerialNumber
        {
            set
            {
                _CardSerialNumber = value;
            }
        }

        public bool Canceled
        {
            get
            {
                return _Canceled;
            }
        }

        public frmOutputScriptWizard()
        {
            InitializeComponent();
        }

        private void frmOutputScriptWizard_Load(object sender, EventArgs e)
        {
            cbOffsetType.Properties.Items.Add("Byte");
            cbOffsetType.Properties.Items.Add("Bit");
            cbOffsetType.SelectedIndex = 0;

            tbBit.Enabled = false;
        }

        private void cbOffsetType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOffsetType.Text == "Bit")
            {
                tbBit.Enabled = true;
                tbBit.Text = "";
            }
            else
            {
                tbBit.Enabled = false;
                tbBit.Text = "";
            }
        }

        private void wizardControl1_SelectedPageChanging(object sender, DevExpress.XtraWizard.WizardPageChangingEventArgs e)
        {
            if (e.PrevPage == welcomeWizardPage1 && e.Direction == DevExpress.XtraWizard.Direction.Forward)
            {
                lblError.Text = "";
                // Verify all fields are filled in
                if (tbOffset.Text == "")
                {
                    lblError.Text = "Offset is a required field";
                    e.Page = welcomeWizardPage1;
                    return;
                }

                if (tbLength.Text == "")
                {
                    lblError.Text = "The offset length is a required field";
                    e.Page = welcomeWizardPage1;
                    return;
                }

                if (cbOffsetType.Text == "Bit")
                {
                    if (tbBit.Text == "")
                    {
                        lblError.Text = "You must specify the bit in which you wish to watch";
                        e.Page = welcomeWizardPage1;
                        return;
                    }
                }

                try
                {
                    int offsettest = Int32.Parse(tbOffset.Text, System.Globalization.NumberStyles.HexNumber);
                }
                catch (Exception)
                {
                    lblError.Text = "Offset needs to be just the offset number, for example 0x0D0C would be just 0D0C";
                    e.Page = welcomeWizardPage1;
                    return;
                }

                try
                {
                    int lengthtest = Convert.ToInt32(tbLength.Text);
                }
                catch (Exception)
                {
                    lblError.Text = "Offset length needs to be a number";
                    e.Page = welcomeWizardPage1;
                    return;
                }

                if (cbOffsetType.Text == "Bit")
                {
                    try
                    {
                        int bittest = Convert.ToInt32(tbBit.Text);
                    }
                    catch (Exception)
                    {
                        lblError.Text = "Bit needs to be a number";
                        e.Page = welcomeWizardPage1;
                        return;
                    }
                }

                if (Convert.ToInt32(tbLength.Text) > 8)
                {
                    lblError.Text = "Offset length needs to be between 1 and 8";
                    e.Page = welcomeWizardPage1;
                    return;
                }

                if (Convert.ToInt32(tbLength.Text) < 1)
                {
                    lblError.Text = "Offset length needs to be between 1 and 8";
                    e.Page = welcomeWizardPage1;
                    return;
                }

                if (cbOffsetType.Text == "Bit")
                {
                    if (Convert.ToInt32(tbBit.Text) < 0)
                    {
                        lblError.Text = "Bit cannot be a negative number";
                        e.Page = welcomeWizardPage1;
                        return;
                    }
                }

                if (cbOffsetType.Text == "Byte")
                {
                    XPCollection collection = new XPCollection(typeof(Database.AnalogOutputScripts), CriteriaOperator.Parse(String.Format("CardModel == '{0}' AND CardRevision == '{1}' AND CardSerial == {2} AND Offset == '{3}'", _CardModel, _CardRevision, _CardSerialNumber, tbOffset.Text)));
                    if (collection.Count > 0)
                    {
                        lblError.Text = "Offset already added";
                        e.Page = welcomeWizardPage1;
                        return;
                    }
                    collection.Dispose();
                }

                if (cbOffsetType.Text == "Bit")
                {
                    XPCollection collection = new XPCollection(typeof(Database.AnalogOutputScripts), CriteriaOperator.Parse(String.Format("CardModel == '{0}' AND CardRevision == '{1}' AND CardSerial == {2} AND Offset == '{3}' AND Bit == {4}", _CardModel, _CardRevision, _CardSerialNumber, tbOffset.Text, tbBit.Text)));
                    if (collection.Count > 0)
                    {
                        lblError.Text = "Offset and Bit already added";
                        e.Page = welcomeWizardPage1;
                        return;
                    }
                    collection.Dispose();
                }

                // validation complete
                db.CardModel = _CardModel;
                db.CardRevision = _CardRevision;
                db.CardSerial = _CardSerialNumber;

                if (cbOffsetType.Text == "Bit")
                    db.Bit = Convert.ToInt32(tbBit.Text);
                else
                    db.Bit = -1;

                db.Length = Convert.ToInt32(tbLength.Text);
                db.Offset = tbOffset.Text;

                if (cbOffsetType.Text == "Bit")
                    db.OutputCode = _BitSample;
                else
                    db.OutputCode = _ByteSample;

                db.Save();

                labelControl6.Text = "Script for offset " + tbOffset.Text + " has been added to the database and a sample script has been generated for the offset type that you have selected.  Click on Finish to complete this wizard.";
            }
        }
    }
}