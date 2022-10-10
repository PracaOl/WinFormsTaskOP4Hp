using Microsoft.VisualBasic;

namespace WinFormsTaskOP4Hp
{
    public partial class Form1 : Form
    {
        string AdresIP;
        string[] IPNumbers;
        int[] IPNumbersInt;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdresIP = textBox1.Text;
            IPNumbers = AdresIP.Split('.');
            IPNumbersInt = Array.ConvertAll(IPNumbers, int.Parse);
            for (int i = 0; i < IPNumbersInt.Length; i++)
            {
                if (IPNumbersInt[i] > 0 && 256 > IPNumbersInt[i])
                {
                    label3.Text = "Czy Poprawny Adres IP: " + "TAK" + IPNumbersInt;
                }
                else
                {
                    label3.Text = "Czy Poprawny Adres IP: " + "NIE" + IPNumbersInt;
                }
            }
        }
    }
}