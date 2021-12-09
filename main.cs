namespace AppForms
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String txt = Convert.ToString(textBox1.Text);
            
            popup popup = new popup(txt);
            popup.Show();
        }



       
    }
}