namespace WindowsFormsThingy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void penButton_Click(object sender, EventArgs e)
        {
            
        }

        private void pencilButton_Click(object sender, EventArgs e)
        {
            AddToCart("Pencil");
        }

        private void rulerButton_Click(object sender, EventArgs e)
        {

        }

        private void pencilCaseButton_Click(object sender, EventArgs e)
        {
            AddToCart("Pencil Case");
        }

        private void highlighterButton_Click(object sender, EventArgs e)
        {

        }

        private void rubberButton_Click(object sender, EventArgs e)
        {
            AddToCart("Rubber");
        }

        private void pencilSharpenerButton_Click(object sender, EventArgs e)
        {
            AddToCart("Pencil Sharpener");
        }

        private void teacherAccessButton_Click(object sender, EventArgs e)
        {

        }

        private void buyButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }

        private void AddToCart(string stockName)
        {
            shoppingListTxt.Text += stockName;
        }
    }
}