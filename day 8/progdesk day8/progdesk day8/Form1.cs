using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progdesk_day8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

           



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkedListBox2.Text == "")
            {
                throw new Exception("Plase , Enter your Index ...! ");

            }
            else
            {
               checkedListBox1.Items.Add(checkedListBox2.Text);
            }

            
           




            /*
            if (button1.Text == checkedListBox2.Items.ToString())
            {
                checkedListBox2.Items.Add(checkedListBox1.Items.ToString());
            }
            else
            {
                checkedListBox1.Items.Add(checkedListBox2.Items.ToString());

            }
            */




            /*
            foreach (string item in checkedListBox2.Items)
            {
                checkedListBox2.Items.Add(checkedListBox1);


            }
            */




        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            checkedListBox1.SelectedItems.Add(checkedListBox2.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            foreach (var item in checkedListBox2.Items)
            {
                // item.Equals(checkedListBox2.Text);
              this.checkedListBox1.Items.Add(checkedListBox2.Items);
             
              //  this.checkedListBox2.Text += checkedListBox1.Text;
              

            }






            /*
            
            if(checkedListBox1.Text=="")
            {
                checkedListBox1.Items.Add(checkedListBox2.Text);
                checkedListBox2.Items.Clear();
                




            }
            else
            {

            }
            */
            //checkedListBox2.Items.Add(checkedListBox1.Text);

            // checkedListBox1.Items.Add(checkedListBox2.Text);

             // checkedListBox2.Items.Clear();

            //checkedListBox2.Items.Add(checkedListBox1.Text);



            //checkedListBox1.Items.Add(checkedListBox2.Text);


            /*
            if(button2.Text == checkedListBox2.Items.ToString())
            {


                checkedListBox2 .Items.Add (checkedListBox1.Items.ToString());


            }
            else
            {
                checkedListBox2.Text = checkedListBox1.Items.ToString( );
            }
            */
        }

        private void button3_Click(object sender, EventArgs e)
        {

            checkedListBox2.Items.Add(checkedListBox1.Text);

        }

        private void Lab_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if(checkedListBox1.Items.Contains(ToString()))
            {
                comboBox1.Items.Add(comboBox1.Items);
                
            }
            else
            {
                checkedListBox1.Items.Clear();
                //comboBox1.Items.Add(checkedListBox1.Items);
            }
        }
    }
}
