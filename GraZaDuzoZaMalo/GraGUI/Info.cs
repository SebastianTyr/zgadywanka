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
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
            labelInfoGra.Text = "Informacje o Grze";

            string imie = "Sebastian";
            string nazwisko = "Tyralski";

            labelAutor.Text = $"Autor: {imie} {nazwisko}";

            labelOpis1.Text = "Realizowana w ramach projektu semestralnego";
            labelOpis2.Text = "przy wsparciu na ćwiczeniach";

            labelStopka1.Text = "Wersja 1.0";
            labelStopka2.Text = "Copyright (c) all rights reserved";
        }
    }
}
