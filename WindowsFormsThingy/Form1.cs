using System.Diagnostics.Metrics;

namespace WindowsFormsThingy
{
    public partial class Form1 : Form
    {
        public static string[,] stockData = LoadFile();
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

        // Procedure to load the data stored on Stock.txt into a 2D array
        public static string[,] LoadFile()
        {
            // Declares 2D array and a counter for putting items into the array
            stockData = new string[11,4];
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
                            stockData[Counter, 0] = Data.Substring(0, Index + 1);
                            stockData[Counter, 1] = Data.Substring(Index + 2, 2);
                            stockData[Counter, 2] = Data.Substring(Index + 6, 2);
                            stockData[Counter, 3] = Data.Substring(Index + 10, 1);
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
            return stockData;
            // Update: I want to cry
        }   

        static void TextBoxLoader()
        {
            
        }

        public void AddToCart(string stockName)
        {
            shoppingListTxt.Text += stockName;
            for (int Index = 0; Index < 12; Index++)
            {
               
            }
        }
    }
}