using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquareString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text.Length > 0)
            {
            RepeatString repeatString = new RepeatString();
            int result = repeatString.minimalModify(inputTextBox.Text);
                MessageBox.Show("Rezultati: " + result);
            }
            else
            {
                MessageBox.Show("Shenoni tekstin!");
            }
        }
    }
}
