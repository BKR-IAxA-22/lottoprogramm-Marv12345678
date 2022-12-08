using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int[] RndArray = new int[6];
            int[] RndArray2 = new int[6];

            for (int i = 0; i < RndArray.Length; i++)
            {   
                RndArray[i] = rnd.Next(1,49);
            }
            for (int i = 0; i < RndArray2.Length; i++)
            {
                RndArray2[i] = rnd.Next(1, 49);
            }
            label1.Text = RndArray[0].ToString();
            label2.Text = RndArray[1].ToString();
            label3.Text = RndArray[2].ToString();
            label4.Text = RndArray[3].ToString();
            label5.Text = RndArray[4].ToString();
            label6.Text = RndArray[5].ToString();

            if (RndArray[0] == RndArray2[0])
            {
                Number1.BackColor = Color.Green;
            }

            else
            {
                label1.BackColor = Color.White;
            }

            if (RndArray[1] == RndArray2[1])
            {
                label2.BackColor = Color.Green;
            }

            else
            {
                label2.BackColor = Color.White;
            }

            if(RndArray[2] == RndArray2[2])
            {
                label3.BackColor = Color.Green;
            }

            else
            {
                label3.BackColor = Color.White;
            }

            if (RndArray[3] == RndArray2[3])
            {
                label4.BackColor = Color.Green;
            }

            else
            {
                label4.BackColor = Color.White;
            }

            if (RndArray[4] == RndArray2[4])
            {
                label5.BackColor = Color.Green;
            }

            else
            {
                Number5.BackColor = Color.White;
            }

            if (RndArray[5] == RndArray2[5])
            {
                label6.BackColor = Color.Green;
            }

            else
            {
                label6.BackColor = Color.White;   
            }



        }

        private void Number1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Number2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Number3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Number4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Number5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
