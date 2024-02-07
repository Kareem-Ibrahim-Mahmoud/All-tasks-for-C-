using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taskdesktopd8
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {




            if (textBox1.Text.Length < 0)
            {
                throw new Exception();
            }
            else
            {
                //listView1.Name= textBox1.Text;

                //textBox1.Text += listView1.Name = listView1(textBox1.Text);

                //textBox1.Text.Concat(listView1.Name);

                ////textBox1.Text = listView1.Items.Add();
                ///
               // textBox1.Text = 



            }

            //listView1.Items.Add(textBox1.Text);
           // listView1.Items.Add(textBox2.Text);

            ListViewItem item= new ListViewItem();
            

            if (textBox1.Text == "")
            {
                throw new Exception("Plase , Enter your Value...!");  

            }

            else if(textBox2.Text == "")
            {
                throw new Exception("Plase , Enter your Value...!");
            }


            else 
            {
               
                
       

                 item.BackColor = Color.CadetBlue;

                
                 item.SubItems.Add(textBox1.Text);
                 item.SubItems.Add(textBox2.Text);
                 item.SubItems.Add(dateTimePicker1.Text);
                 listView1.Items.Add(item);
                  
                


                
                
                   








            }








        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

           textBox2.Text = (int.Parse(textBox2.Text)).ToString();




           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            



        }

        private void button2_Click(object sender, EventArgs e)
        {
            




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
