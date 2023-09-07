namespace LorentzModelAll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int size = 1000;
            double[] x = new double[size];
            double[] y = new double[size];
            double[] z = new double[size];
            double[] t = new double[size];

            double r = double.Parse(textBox1.Text);
            double sigma = 10.0, b = 8.0 / 3.0, dt = 0.01;

            x[0] = 1;
            y[0] = 1;
            z[0] = 1;

            for (int i = 0; i < size - 1; i++)
            {
                x[i + 1] = x[i] + (sigma * (y[i] - x[i])) * dt;
                y[i + 1] = y[i] - (x[i] * z[i] - r * x[i] + y[i]) * dt;
                z[i + 1] = z[i] + (x[i] * y[i] - b * z[i]) * dt;
                t[i + 1] = t[i] + dt;
            }

            Graphics gg = CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.Green);

            for (int i = 0; i < size; i++)
            {
                gg.FillEllipse(sb, 100 + (float)t[i] * 13, 500 - (float)z[i] * 5, 5, 5);
            }
        
        }
    }
}