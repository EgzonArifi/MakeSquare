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
            RepeatString repeatString = new RepeatString();
            int result = repeatString.minimalModify(inputTextBox.Text);
            if (!string.IsNullOrEmpty(result.ToString()))
            {
                MessageBox.Show("Rezultati: " + result);
            }
        }
    }
}
