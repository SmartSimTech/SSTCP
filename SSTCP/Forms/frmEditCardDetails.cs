using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using SSTCP.Database;
using SSTCP.Classes;

namespace SSTCP.Forms
{
    public partial class frmEditCardDetails : DevExpress.XtraEditors.XtraForm
    {
        private int _CardSerial;
        private int _Input;
        private string _CardRevision;
        private string _CardModel;
        private bool _Canceled = true;
        private AnalogInputConfiguration objSST30IC;
        private Cards objCards;
        private clsEditCardDetailsDialogType.DialogType _DialogType;

        public clsEditCardDetailsDialogType.DialogType DialogMode
        {
            set
            {
                _DialogType = value;
            }
        }

        public int CardSerial
        {
            set
            {
                _CardSerial = value;
            }
        }

        public int InputID
        {
            set
            {
                _Input = value;
            }
        }

        public string CardModel
        {
            set
            {
                _CardModel = value;
            }
        }

        public string CardRevision
        {
            set
            {
                _CardRevision = value;
            }
        }

        public bool Canceled
        {
            get
            {
                return _Canceled;
            }
        }

        public frmEditCardDetails()
        {
            InitializeComponent();
        }

        private void frmEditCardDetails_Load(object sender, EventArgs e)
        {
            switch (_DialogType)
            {
                case clsEditCardDetailsDialogType.DialogType.CardEdit:
                    objCards = Session.DefaultSession.FindObject<Cards>(CriteriaOperator.Parse("[CardSerialNumber] == ? AND [CardModel] == ? AND [CardRevision] == ?", _CardSerial, _CardModel, _CardRevision));
                    tbName.DataBindings.Add("Text", objCards, "CardName");
                    tbDescription.DataBindings.Add("Text", objCards, "CardDescription");
                    lblName.Text = "Card Name:";
                    lblDescription.Text = "Card Description:";
                    break;
                case clsEditCardDetailsDialogType.DialogType.InputEdit:
                    objSST30IC = Session.DefaultSession.FindObject<AnalogInputConfiguration>(CriteriaOperator.Parse("[CardSerial] == ? AND [CardRevision] == ? AND [Input] == ?", _CardSerial, _CardRevision, _Input));
                    tbName.DataBindings.Add("Text", objSST30IC, "InputName");
                    tbDescription.DataBindings.Add("Text", objSST30IC, "InputDescription");
                    lblName.Text = "Input Name:";
                    lblDescription.Text = "Input Description:";
                    break;
            }

            tbName.Select();
        }

        private void bbtnOk_Click(object sender, EventArgs e)
        {
            _Canceled = false;
            switch (_DialogType)
            {
                case clsEditCardDetailsDialogType.DialogType.CardEdit:
                    objCards.Save();
                    break;
                case clsEditCardDetailsDialogType.DialogType.InputEdit:
                    objSST30IC.Save();
                    break;
            }
            Close();
        }
    }
}