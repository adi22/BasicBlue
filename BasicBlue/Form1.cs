using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicBlue.SzachyBasicBlue;

namespace BasicBlue
{
    public partial class Form1 : Form
    {
        private Color bialy = Color.White;
        private Color czarny = Color.Black;


        public Form1()
        {
            InitializeComponent();

            RysujSiatke(bialy, czarny);
        }

        private void WyczyscPanele()
        {
            foreach (Control c in tableLayoutPanel1.Controls)
            {
                if (c is Panel) c.BackColor = Color.Transparent;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            TableLayoutPanelCellPosition pos = Tools.GetCellPosotion(tableLayoutPanel1);
            label1.Text = pos.Row + ":" + pos.Column;


            RysujSiatke(bialy, czarny);

            Panel p = tableLayoutPanel1.GetControlFromPosition(pos.Column, pos.Row) as Panel;
            if (p != null)
            {
                p.BackColor = Color.Red;
            }
        }
        

        private void RysujSiatke(Color biale, Color czarne)
        {
            foreach (Control c in tableLayoutPanel1.Controls)
            {
                if (c is Panel)
                {
                    int numer = int.Parse(c.Name.Replace("panel", string.Empty));
                    if (numer % 2 == 0) c.BackColor = biale;
                    else c.BackColor = czarne;
                }
            }
        }

        private void radioColor_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNiebieska.Checked) czarny = Color.Blue;
            else czarny = Color.Black;

            RysujSiatke(bialy, czarny);
        }

     }
}
