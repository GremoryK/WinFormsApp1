namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();

            graphics.FillEllipse(Brushes.Gray, 20, 50, 100, 100);
            
            graphics.Dispose();
        }
    }
}