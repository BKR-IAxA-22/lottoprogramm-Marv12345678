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
            int[] RndArray = new int[5];
            int[] RndArray2 = new int[5];

            for (int i = 0; i < RndArray.Length; i++)
            {   
                RndArray[i] = rnd.Next(1,49);
            }
            for (int i = 0; i < RndArray2.Length; i++)
            {
                RndArray2[i] = rnd.Next(1, 49);
            }
            Number1.Text = RndArray[0].ToString();
            Number2.Text = RndArray[1].ToString();
            Number3.Text = RndArray[2].ToString();
            Number4.Text = RndArray[3].ToString();
            Number5.Text = RndArray[4].ToString();

            if (RndArray[0] == RndArray2[0])
            {
                Number1.BackColor = Color.Green;
            }

            else
            {
                Number1.BackColor = Color.White;
            }

            if (RndArray[1] == RndArray2[1])
            {
                Number2.BackColor = Color.Green;
            }

            else
            {
                Number2.BackColor = Color.White;
            }

            if(RndArray[2] == RndArray2[2])
            {
                Number3.BackColor = Color.Green;
            }

            else
            {
                Number3.BackColor = Color.White;
            }

            if (RndArray[3] == RndArray2[3])
            {
                Number4.BackColor = Color.Green;
            }

            else
            {
                Number4.BackColor = Color.White;
            }

            if (RndArray[4] == RndArray2[4])
            {
                Number5.BackColor = Color.Green;
            }

            else
            {
                Number5.BackColor = Color.White;
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
    }
}
