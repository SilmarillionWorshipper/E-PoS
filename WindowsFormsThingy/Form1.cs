namespace WindowsFormsThingy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button=sender as Button;
            button.Text = "Hello" + button.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}