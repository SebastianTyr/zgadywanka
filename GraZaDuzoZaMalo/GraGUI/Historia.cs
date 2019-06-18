using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelGry;
using static ModelGry.Gra;
using static ModelGry.Gra.Ruch;

namespace GraGUI
{
    public partial class Historia : Form
    {
        public Historia()
        {
            InitializeComponent();
            List<Ruch> historia = new List<Ruch>();
        }
    }
}
