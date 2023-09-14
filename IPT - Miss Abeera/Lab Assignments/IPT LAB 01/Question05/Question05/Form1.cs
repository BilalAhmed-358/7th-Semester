namespace Question05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Results.Text = "";
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            int x1Val = Convert.ToInt32(x1.Text);
            int x2Val = Convert.ToInt32(x2.Text);
            int y1Val = Convert.ToInt32(y1.Text);
            int y2Val = Convert.ToInt32(y2.Text);
            double distance = Math.Sqrt(((x2Val - x1Val) * (x2Val - x1Val)) + ((y2Val - y1Val) * (y2Val - y1Val)));
            double diagonal = 2 * distance;
            double circumference = 2 * Math.PI * distance;
            double Area = 2 * Math.PI * distance * distance;
            string finalString = "Distance between the two points is " + distance + ".\n" + "The radius of the circle is " + distance + ".\n" + "The value of diagonal is " + diagonal + ".\n" + "The value of circumference is " + circumference + ".\n" + "The vlaue of Area is " + Area + ".\n";
            Results.Text = finalString;
        }
    }
}