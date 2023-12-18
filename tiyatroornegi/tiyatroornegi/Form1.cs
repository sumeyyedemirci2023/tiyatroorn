using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tiyatroornegi.Resources;

namespace tiyatroornegi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Tiyatro tiyatro;
        List<Tiyatro> tiyatriListesi = new List<Tiyatro>();
        private void Form1_Load(object sender, EventArgs e)
        {
            tiyatriListesi.Add(new Tiyatro(4,"Şair Evlenmesi",new DateTime()))
        }
    }
}
