using Microsoft.VisualBasic;

namespace WinFormsTaskOP4Hp
{
    public partial class Form1 : Form
    {
        string AdresIP;
        string[] IPNumbers;
        int[] IPNumbersInt;
        string AdresIPClass;
        int AdresIPClassInt;
        int abc = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdresIP = textBox1.Text;
            if (AdresIP.Contains("."))
            {
                AdresIPClass = AdresIP.Substring(0, AdresIP.IndexOf("."));
            }
            AdresIPClassInt = Int32.Parse(AdresIPClass);
            IPNumbers = AdresIP.Split(".");
            IPNumbersInt = Array.ConvertAll(IPNumbers, int.Parse);
            for (int i = 0; i < IPNumbersInt.Length; i++)
            {
                if (IPNumbersInt[i] > 0 && 256 > IPNumbersInt[i])
                {
                    abc++;
                }
                if (abc == 4)
                {
                    label3.Text = "Czy Poprawny Adres IP: " + "TAK" + AdresIPClass + abc;
                }
                if (abc != 4)
                {
                    label3.Text = "Czy Poprawny Adres IP: " + "NIE" + AdresIPClass + abc;
                }
            }
            abc = 0;
            if (AdresIPClassInt >= 1 && 127 >= AdresIPClassInt)
            {
                label4.Text = "Klasa Sieci: A";
            }
            if (AdresIPClassInt >= 128 && 191 >= AdresIPClassInt)
            {
                label4.Text = "Klasa Sieci: B";
            }
            if (AdresIPClassInt >= 192 && 223 >= AdresIPClassInt)
            {
                label4.Text = "Klasa Sieci: C";
            }
            if (AdresIPClassInt >= 224 && 239 >= AdresIPClassInt)
            {
                label4.Text = "Klasa Sieci: D";
            }
            if (AdresIPClassInt >= 240 && 255 >= AdresIPClassInt)
            {
                label4.Text = "Klasa Sieci: E";
            }
            // Dodaj Label podnazwa "label4". Add Label under a name "label4". Windows Forms!!
        }
    }
}
