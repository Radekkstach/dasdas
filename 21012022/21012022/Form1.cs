using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21012022
{
    public partial class Form1 : Form
    {
        int kliknuti;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double pocet = 0;
            double soucet = 0;
            for(int i = 0; i< textBox1.Lines.Length ;i++)
            {
                pocet++;
                soucet += int.Parse(textBox1.Lines[i]);
            }
            MessageBox.Show(string.Format("Vysledny prumer je {0}!", soucet / pocet));
        }
        
    }
}
