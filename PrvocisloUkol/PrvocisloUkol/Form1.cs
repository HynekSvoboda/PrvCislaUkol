using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrvocisloUkol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("V textBox1 je celé kladné číslo n. Do listBox1 vypište všechna prvočísla menší nebo\r\nrovna n. Vyřešte pomocí Eratoshenova síta.\r\n(Jeden z možných způsobů – vytvořte si pole bool o velikosti n. Indexy představují\r\nzkoumanou posloupnost čísel, index nula neberte v úvahu. Na začátku inicializujte všechny\r\nprvky pole na false, začněte od indexu 2, vyškrtávání násobků prvočísel realizujte zápisem\r\nhodnoty true na příslušném indexu.","INFO");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
