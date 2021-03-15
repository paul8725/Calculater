using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        private calc myclc = new calc();
        public Form1()
        {
            InitializeComponent();
            LoadCombobox();

        }
        private void LoadCombobox()
        {
            //pass the array across to the combobox
            cbxOperation.Items.AddRange(myclc.LoadSymbols());
            //start at the first item
            cbxOperation.SelectedIndex = 0;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double result;
            //Check for numbers coming in
            if (double.TryParse(num1.Text, out result));
            {
                myclc.num1 = result;
            }
            if (double.TryParse(num2.Text, out result));
            {
                myclc.num2 = result;
            }
            //check selected operation
           myclc.SelectedSymbol = cbxOperation.SelectedItem.ToString();
            //output answer
            lbAnswer.Text = Convert.ToString(myclc.SelectOperation());
            lblAnswer.Items.Add(myclc.num1 + " " + myclc.SelectedSymbol + " " + myclc.num2 + " = " +
                lbAnswer.Text);
        }
        }
    }
