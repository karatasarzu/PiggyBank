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

namespace PiggyBank
{
    public partial class ParalarForm : Form
    {
        public ParalarForm(BindingList<Para> kagit, BindingList<Para> bozuk,double biriken)
        {
            InitializeComponent();
            DataGuncelle(kagit,bozuk,biriken);
        }
        public void DataGuncelle(BindingList<Para> kagitlar, BindingList<Para> bozuklar,double birikmis)
        {
            lblMiktar.Text = "Biriken Miktar: " + birikmis.ToString() + "₺";
            dgvAtilanKagitParalar.DataSource = null;
            dgvAtilanKagitParalar.DataSource = kagitlar.ToList();
            dgvAtilanBozukParalar.DataSource = null;
            dgvAtilanBozukParalar.DataSource = bozuklar.ToList();
        }
    }
}
