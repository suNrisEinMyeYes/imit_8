using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YesXNo
{
    public partial class Form1 : Form
    {
        Random rnd;
        double p = 0.45;
        string[] phrases = { "Yes", "No", "Probably", "50/50" };
        List<double> values = new List<double>();
        public Form1()
        {
            InitializeComponent();
            rnd = new Random();
            values.Add(0.3);
            values.Add(0.2);
            values.Add(0.4);
            values.Add(0.1);

        }



        private void AnswerBtn_Click(object sender, EventArgs e)
        {
            
            double a = rnd.NextDouble();
            if (a<p)
            {
                YesTxt.Visible = true;
            }
            else
            {
                NoTxt.Visible = true;
            }
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            YesTxt.Visible = NoTxt.Visible = BallAswrLbl.Visible = false;
        }

        private void BallAnswerBtn_Click(object sender, EventArgs e)
        {
            BallAswrLbl.Visible = true;

            double A = rnd.NextDouble();
            int k = 0;
            foreach (var value in values)
            {

                A -= value;
                if (A<=0)
                {
                    BallAswrLbl.Text = phrases[k];
                    break;
                }
                k++;
            }

        }
    }
}
