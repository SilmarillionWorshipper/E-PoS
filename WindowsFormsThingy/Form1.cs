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
                string? Data = "";

                while (true)
                {
                    Data = TextFile.ReadLine();

                    if (Data == null)
                        break;
                    // Splits data based on where the commas are
                    string[] dataInfo = Data.Split(",");
                    stockData[Counter, 0] = dataInfo[0].Trim();
                    stockData[Counter, 1] = dataInfo[1].Trim();
                    stockData[Counter, 2] = dataInfo[2].Trim();
                    stockData[Counter, 3] = dataInfo[3].Trim();
                    Counter++;
                }
                TextFile.Close();
            }
            catch
            {
                MessageBox.Show("File error", "Error");
            }
            return stockData;
        }   

        static void TextBoxLoader()
        {
            
        }
        public static int total = 0;
        public void AddToCart(string stockName)
        {
            /*int total = 0;

            string badumddddd = "";

            foreach(string item in stockData)
            {
                badumddddd += item + " [] ";
            }

            shoppingListTxt.Text = badumddddd;*/

            shoppingListTxt.Text += stockName + "\r\n";

            total = Convert.ToInt32(total);

            for (int index = 0; index < 11; index++)
            {
                if (stockData[index, 0] == stockName)
                {
                    total += Convert.ToInt32(stockData[index, 2]);
                }
            }

            float a = (float)total / 100;
            string magictext = String.Format("{0:C2}",a);
            totalPriceTxt.Text = magictext;
            
        }
    }
}