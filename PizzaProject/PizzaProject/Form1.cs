using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Conditions need to be added. Lines 23 - 25 switch load Form2 and vise versa.
            Hide();
            Form2 mainMenu = new Form2();
            mainMenu.ShowDialog();
        }
    }
}
