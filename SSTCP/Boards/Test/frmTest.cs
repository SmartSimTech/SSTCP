// System Libraries
using System;
using System.Windows.Forms;
using System.Collections;
using System.CodeDom.Compiler;
using System.IO;
using System.Text;
using System.Xml;
using System.Threading;
using System.Xml.Serialization;
// DevExpress Libraries
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
// USB Library
using HIDLibrary;
// Smart Sim Tech Libraries
using SSTCP.Forms;
using SSTCP.Classes;
using SSTCP.Database;
using SSTCP.XMLConfiguration;

namespace SSTCP.Boards.Test
{
    public partial class frmTest : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private frmMain _parent;
        public frmTest()
        {
            InitializeComponent();
        }

        public frmMain ParentFrm
        {
            set
            {
                _parent = value;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int mintr = trackBar1.Minimum;
            int maxtr = trackBar1.Maximum;
            int trper = ((trackBar1.Value - mintr) * (maxtr - mintr)) / (maxtr - mintr);


            int percent = ((trackBar1.Value - mintr) * 100) / (maxtr - mintr);

            label1.Text = percent.ToString() + "% < Slider Percent\n" + trackBar1.Value.ToString() + " < Trackbar Value (raw value)\n" + trper.ToString() + " < TBPer";


            int max = Convert.ToInt32(textBox2.Text);
            int min = Convert.ToInt32(textBox1.Text);
            int value = (percent * (max - min)) / 100 + min;
            long value2 = (trper * (max - min)) / (maxtr - mintr) + min;
            label4.Text = value.ToString() + " < Value 1 (From Percent)\n" + value2.ToString() + " < Value 2 (From TBPer)";

            bool result = false;
            int dwOffset = Int32.Parse(textBox5.Text, System.Globalization.NumberStyles.HexNumber);
            result = _parent.FSUIPC_SendBytes(dwOffset, value2, Convert.ToInt32(textBox6.Text));

            bool readresult = false;
            long read = 0;
            readresult = _parent.FSUIPC_GetBytes(dwOffset, Convert.ToInt32(textBox6.Text), ref read);

            label9.Text = result.ToString() + " < FSUIPC Send Result\n" + readresult.ToString() + " < FSUIPC Read Result\n" + read.ToString() + " < FSUIPC Read Value";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            trackBar1.Minimum = Convert.ToInt32(textBox3.Text);
            trackBar1.Maximum = Convert.ToInt32(textBox4.Text);
            trackBar1.Value = trackBar1.Minimum;

            trackBar1_Scroll(sender, e);
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "65536";

            textBox3.Text = trackBar1.Minimum.ToString();
            textBox4.Text = trackBar1.Maximum.ToString();

            textBox5.Text = "0BB2";
            textBox6.Text = "2";

            trackBar1_Scroll(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}