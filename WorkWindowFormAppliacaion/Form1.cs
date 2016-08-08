using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WorkWindowFormAppliacaion
{

    public partial class Form1 : Form
    {

        LinkedList<Part> partList = new LinkedList<Part>();
        
        public Form1()
        {
           
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            if (textBox1.Text.Length > 0 && textBox1.Text == "add")
            {
                Form1 popUp = new Form1();
                popUp.Show();
                string name;
                int partNo;
                double price;

                Part newPart = new Part(name, partNo, price);

            }
            else
            {
                MessageBox.Show("Please enter text");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        bool IsString(object value)
        {
            return true;
        }
    }
}

   
