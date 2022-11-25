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

            graphics.FillEllipse(Brushes.Aqua, 20, 50, 100, 100);
            graphics.FillPie(Brushes.Gray, 40, 40, 40, 40, 45, -180);

            graphics.Dispose();
        }
    }
}