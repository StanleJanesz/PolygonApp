using PolygonApp.Polygon;
namespace PolygonApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            RadioButton radioButton = new RadioButton();

            Polygon.Point point1 = new Polygon.Point(302, 12, radioButton);
            this.Controls.Add(radioButton);

            RadioButton radioButton1 = new RadioButton();
            radioButton1.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
            Polygon.Point point2 = new Polygon.Point(122, 80, radioButton1);
            this.Controls.Add(radioButton1);
            RadioButton radioButton2 = new RadioButton();

            Polygon.Point point3 = new Polygon.Point(542, 12, radioButton2);
            this.Controls.Add(radioButton2);
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //pictureBox1.Refresh();

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Cursor.Position.X

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ((RadioButton)sender).Location = new System.Drawing.Point(Cursor.Position.X, Cursor.Position.Y);
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
