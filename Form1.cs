using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba4_2
{
    public partial class Form1 : Form
    {
        Triology tri;
        public Form1()
        {
            InitializeComponent();

            tri = new Triology();
            tri.TRIobservers += new EventHandler(this.UpdateFromModel);
        }



        private void UpdateFromModel(object sender, EventArgs e)
        {
            ATextBox.Text = tri.GetValue(Triology.Model_el.A).ToString();
            ATrackBar.Value = tri.GetValue(Triology.Model_el.A);
            AUpDown.Value = tri.GetValue(Triology.Model_el.A);

            BTextBox.Text = tri.GetValue(Triology.Model_el.B).ToString();
            BTrackBar.Value = tri.GetValue(Triology.Model_el.B);
            BUpDown.Value = tri.GetValue(Triology.Model_el.B);

            CTextBox.Text = tri.GetValue(Triology.Model_el.C).ToString();
            CTrackBar.Value = tri.GetValue(Triology.Model_el.C);
            CUpDown.Value = tri.GetValue(Triology.Model_el.C);
        }

        private void ATrackBar_ValueChanged(object sender, EventArgs e)
        {
            tri.setValue(Triology.Model_el.A, ATrackBar.Value);
        }

        private void BTrackBar_ValueChanged(object sender, EventArgs e)
        {
            tri.setValue(Triology.Model_el.B, BTrackBar.Value);
        }

        private void CTrackBar_ValueChanged(object sender, EventArgs e)
        {
            tri.setValue(Triology.Model_el.C, CTrackBar.Value);
        }

        private void AButton_Click(object sender, EventArgs e)
        {
            tri.setValue(Triology.Model_el.A, Int32.Parse(ATextBox.Text));
        }

        private void BButton_Click(object sender, EventArgs e)
        {
            tri.setValue(Triology.Model_el.B, Int32.Parse(BTextBox.Text));
        }

        private void CButton_Click(object sender, EventArgs e)
        {
            tri.setValue(Triology.Model_el.C, Int32.Parse(CTextBox.Text));
        }

        private void AUpDown_Changed(object sender, EventArgs e)
        {
            tri.setValue(Triology.Model_el.A, Convert.ToInt32(AUpDown.Value));
        }

        private void BUpDown_Changed(object sender, EventArgs e)
        {
            tri.setValue(Triology.Model_el.B, Convert.ToInt32(BUpDown.Value));
        }

        private void CUpDown_Changed(object sender, EventArgs e)
        {
            tri.setValue(Triology.Model_el.C, Convert.ToInt32(CUpDown.Value));
        }

  
    }
}
