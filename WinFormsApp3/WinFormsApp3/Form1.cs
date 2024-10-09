namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        Random r;
        int punkty;
        public Form1()
        {
            InitializeComponent();
            r = new Random();
            timer1.Start();
            punkty = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            punkty++;
            label1.Text = "punkty:  " + punkty.ToString();
            int maxX = this.Size.Width - button1.Size.Width - 50;
            int maxY = this.Size.Height - button1.Size.Height - 50;
            Point p = new Point();
            p.X = r.Next(12, maxX);
            p.Y = r.Next(12, maxY);
            button1.Location = p;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

        }

    }
}
