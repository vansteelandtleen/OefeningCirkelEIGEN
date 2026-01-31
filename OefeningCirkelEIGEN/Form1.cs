using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OefeningCirkelEIGEN
{
    public partial class FrmCirkel : Form
    {
        public FrmCirkel()
        {
            InitializeComponent();
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            //declaratie van variabelen en objecten ( lokaal achter deze knop)
            Cirkel mijnCirkel = new Cirkel(5);
            double dblstraal;
            string strRes;
            //opvragen van waarde cirkel
            dblstraal = Convert.ToDouble(txtStraal.Text);
            //veranderen met setter
            mijnCirkel.setStraal(dblstraal);
            //resultaten weergeven op label
            strRes = "Resultaten van Cirkel";
            strRes += Environment.NewLine;
            strRes += "____________________";
            strRes += Environment.NewLine;
            strRes += "Straal :" + mijnCirkel.getStraal();
            strRes += Environment.NewLine;
            strRes += "opp :" + mijnCirkel.berekenOpp();
            strRes += Environment.NewLine;
            strRes += "omtrek :" + mijnCirkel.berekenOmtrek();
            //in label plaatsen
            lblRes.Text = strRes;
        }
    }
}
