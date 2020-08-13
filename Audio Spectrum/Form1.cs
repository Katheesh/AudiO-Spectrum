using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO.Ports;
using Un4seen.Bass;
using Un4seen.BassWasapi;

namespace Audio_Spectrum
{
    public partial class Form1 : Form
    {

        private Analyzer analyzer;

        public Form1()
        {
            InitializeComponent();

            analyzer = new Analyzer(progressBar1, progressBar2, spectrum1, comboBox1, chart1);
            //timer1.Enabled = true;

            timer2.Enabled = true;

            analyzer.Enable = true;
            analyzer.DisplayEnable = true;
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            label3.Visible = false;
            timer3.Enabled = true;
            timer2.Enabled = false;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (label3.Visible == false)
            {
                label3.Visible = true;
                timer2.Enabled = true;
                timer3.Enabled = false;
            }
        }

        private void Btn_Enable_Click(object sender, EventArgs e)
        {
            if (Btn_Enable.Text == "Enable")
            {
                analyzer.Enable = true;
                analyzer.DisplayEnable = true;
                Btn_Enable.Text = "Disable";
            }
            else
            {
                analyzer.Enable = false;
                analyzer.DisplayEnable = false;
                Btn_Enable.Text = "Enable";
            }


        }
    }
}
