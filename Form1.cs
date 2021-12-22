using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace glückskeks_arbeitspacket_1
{
    public partial class Form1 : Form
    {


     
        Random randomnumber = new Random();
        int mycoins = 100;
        int answer;
        bool[] hütchen;
        public Form1()
        {
            InitializeComponent();
            answer = randomnumber.Next(3);
            hütchen = new bool[3];
            hütchen[0] = false;
            hütchen[1] = false;
            hütchen[2] = false;
            hütchen[answer] = true;
          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            button1.Visible = false;
            hut3.Visible = true;
            hut2.Visible = true;
            hut1.Visible = true;
            hütchen1.Visible = true;
            hütchen2.Visible = true;
            hütchen3.Visible = true;
        }

        private void hütchen3_Click(object sender, EventArgs e)
        {
            if(hütchen[2] == true)
            {
                hut3.Visible = false;
               
                mycoins = mycoins + 10;
                label3.Text = Convert.ToString(mycoins);
            }
            else if (hütchen[2] == false)
            {
                mycoins = mycoins - 10;
                label3.Text = Convert.ToString(mycoins);
            }
        }

        private void hütchen1_Click(object sender, EventArgs e)
        {
            if (hütchen[0] == true)
            {
                hut1.Visible = false;
              
                mycoins = mycoins + 10;
                label3.Text = Convert.ToString(mycoins);
            }
            else if (hütchen[0] == false)
            {
                mycoins = mycoins - 10;
                label3.Text = Convert.ToString(mycoins);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hütchen2_Click(object sender, EventArgs e)
        {
            if (hütchen[1] == true)
            {
                hut2.Visible = false;
             
                mycoins = mycoins + 10;
                label3.Text = Convert.ToString(mycoins);
               
            }
            else if (hütchen[1] == false)
            {
                mycoins = mycoins - 10;
                label3.Text = Convert.ToString(mycoins);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
