using System.Drawing.Text;

namespace G24W07WFCOUNTER
{

    public partial class Form1 : Form
    {
        private  int count = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OnAdd(object sender, EventArgs e)
        {

            labelCount.Text = $"{++count}";
        }

        private void OnSub(object sender, EventArgs e)
        {
            if (count > 0)
                labelCount.Text = $"{--count}";

        }

        private void On_init(object sender, EventArgs e)
        {
            labelCount.Text = $"{count = 0}";
        }
    }
}
