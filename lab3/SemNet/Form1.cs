using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace setee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lm = new LM();
            Generator Generator;
            IReadOnlyList<Entity> eneties;
            IReadOnlyList<Connection> connections;
            Generator = new Generator();
            connections = Generator.connection;
            eneties = Generator.entity;
          //  for (int i = 3; i<8;i++)
          //  {
          //      comboBox1.Items.Add(eneties[i].Name);
          //  }
          //  for (int i = 20; i < 22; i++)
          //  {
          //      comboBox2.Items.Add(eneties[i].Name);
          //  }
           // for (int i = 14; i < 16; i++)
           // {
           //     comboBox2.Items.Add(eneties[i].Name);
           // }
            for (int i = 3; i < 13; i++)
            {
                comboBox3.Items.Add(eneties[i].Name);
            }
            for (int i = 14; i < 16; i++)
            {
                comboBox3.Items.Add(eneties[i].Name);
            }
	    for (int i = 17; i < 19; i++)
            {
                comboBox3.Items.Add(eneties[i].Name);
            }
            for (int i = 20; i < 22; i++)
            {
                comboBox3.Items.Add(eneties[i].Name);
            }
 	    for (int i = 23; i < 25; i++)
            {
                comboBox3.Items.Add(eneties[i].Name);
            }
	    for (int i = 26; i < 28; i++)
            {
                comboBox3.Items.Add(eneties[i].Name);
            }
	    for (int i = 29; i < eneties.Count; i++)
            {
                comboBox3.Items.Add(eneties[i].Name);
            }

            for (int i = 0; i < 3; i++)
                {
                comboBox4.Items.Add(eneties[i].Name);
            }
            for (int i = 13; i < 14; i++)
            {
                comboBox4.Items.Add(eneties[i].Name);
            }
	    for (int i = 16; i < 17; i++)
            {
                comboBox4.Items.Add(eneties[i].Name);
            }
	    for (int i = 19; i < 20; i++)
            {
                comboBox4.Items.Add(eneties[i].Name);
            }
	    for (int i = 22; i < 23; i++)
            {
                comboBox4.Items.Add(eneties[i].Name);
            }
	    for (int i = 25; i < 26; i++)
            {
                comboBox4.Items.Add(eneties[i].Name);
            }
	    for (int i = 28; i < 29; i++)
            {
                comboBox4.Items.Add(eneties[i].Name);
            }

            for (int i = 3; i < 8; i++)
            {
                comboBox5.Items.Add(eneties[i].Name);
            }


            for(int i = 3; i < 8; i++)
            {
                comboBox6.Items.Add(eneties[i].Name);
            }
            for (int i = 29; i < 31; i++)
            {
                comboBox7.Items.Add(eneties[i].Name);
            }
        }

        LM lm;

       // private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
       // {
       //     if (comboBox2.Text != "")
       //     {
       //         label5.Text = lm.question1(comboBox1.Text.ToString(), comboBox2.Text.ToString()).ToString();
       //     }
       // }

      //  private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
      //  {
      //      if (comboBox1.Text != "")
      //      {
            
       //         label5.Text = lm.question1(comboBox1.Text.ToString(), comboBox2.Text.ToString()).ToString();
       //     }
       // }
       
        private void comboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox4.Text != "")
            {
                label5.Text = lm.question1(comboBox3.Text.ToString(), comboBox4.Text.ToString()).ToString();
               
            }
        }

        private void comboBox4_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox3.Text != "")
            {
               
                label5.Text = lm.question1(comboBox3.Text.ToString(), comboBox4.Text.ToString()).ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {}

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            label5.Text = lm.questionresponse(comboBox5.Text.ToString()).ToString();

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox7.Text != "")
            {
                label5.Text = lm.question2(comboBox6.Text.ToString(), comboBox7.Text.ToString()).ToString();
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox6.Text != "")
            {
                
                label5.Text = lm.question2(comboBox6.Text.ToString(), comboBox7.Text.ToString()).ToString();

            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
