using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader(@"..\..\matematika.txt");
            while (!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine();
                listBox1.Items.Add(line);
                char aritoperator;
                char[] sep = { ' ' };
                string[] priklad = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                int cislo1 = int.Parse(priklad[0]);
                aritoperator = char.Parse(priklad[1]);
                int cislo2 = int.Parse(priklad[2]);

                double vysledek=0;

                if(aritoperator=='+')
                {
                    vysledek = cislo1 + cislo2;
                }
                else if (aritoperator == '-')
                {
                    vysledek = cislo1 - cislo2;
                }
                else if (aritoperator == '/')
                {
                    vysledek = cislo1 / cislo2;
                }
                else if (aritoperator == '*')
                {
                    vysledek = cislo1 * cislo2;
                }
                string opravenyRadek = cislo1.ToString() + ' ' + aritoperator + ' ' + cislo2 + ' ' + '=' + vysledek;
            }
        }
    }
}
