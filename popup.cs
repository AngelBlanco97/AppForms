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
    public partial class popup : Form
    {
        public popup(String name)
        {
            String nombre = name;
            Console.WriteLine(name);

            InitializeComponent();
            label1.Text = String.Format("Hola!!! Gracias por usarme " + nombre);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Suma sum= new Suma();
            sum.Show();
        }
    }

}
