using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraGUI
{
    public partial class JakGrac : Form
    {
        public JakGrac()
        {
            InitializeComponent();

            labelTytul.Text = "Jak Grać ?";
            labelOpis1.Text = "1. Aby zagrać wybierz zakres liczb i kliknij wylosuj";
            labelOpis2.Text = "2. Komputer wylosuje liczbę z zadanego zakresu";
            labelOpis3.Text = "3. Spróbuj odgadnąć i ciesz się zabawą ! :)";
        }
    }
}
