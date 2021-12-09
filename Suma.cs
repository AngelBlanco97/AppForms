using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppForms
{
    public partial class Suma : Form
    {
        public Suma()
        {
            InitializeComponent();
        }


        private void escape_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(nv1.Value);
            int num2 = Convert.ToInt32(nv2.Value);
            int res = num1 + num2;

            lbl_res.Text = res.ToString();

        }
    }
}
