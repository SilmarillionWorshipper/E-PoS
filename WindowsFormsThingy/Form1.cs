using System.Diagnostics.Metrics;

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
            LoadFile();
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

        // Procedure to load the data stored on Stock.txt into a 2D array
        private void LoadFile()
        {
            // Declares 2D array and a counter for putting items into the array
            string[,] StockData = new string[11,4];
            int Counter = 0;

            try
            {
                TextReader TextFile = new StreamReader("Stock.txt");
                string Data = TextFile.ReadLine();
                while (Data != null)
                {
                    Data = TextFile.ReadLine();
                    // Searches through string to find the first comma, then use that as reference to know what data is stored where
                    for (int Index = 0; Index < Data.Length; Index++)
                    {
                        string Item = Convert.ToString(Data[Index]);
                        if (Item == ",")
                        {
                            StockData[Counter, 0] = Data.Substring(0, Index + 1);
                            StockData[Counter, 1] = Data.Substring(Index + 2, 2);
                            StockData[Counter, 2] = Data.Substring(Index + 6, 2);
                            StockData[Counter, 3] = Data.Substring(Index + 10, 1);
                        }
                    }
                    Counter++;
                }
                TextFile.Close();
            }
            catch
            {
                MessageBox.Show("File error", "Error");
            }
        }   

        private void TextBoxLoader()
        {

        }

        private void AddToCart(string stockName)
        {
            shoppingListTxt.Text += stockName;
        }
    }
}