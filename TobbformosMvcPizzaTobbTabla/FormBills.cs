using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TobbformosMvcPizzaTobbTabla
{
    public partial class FormPizzaFutarKft : Form
    {
        private void tabPageSzamlak_Click(object sender, EventArgs e)
        {
            
        }

        private void tabControlPizzaFutarKFT_Selected(object sender, TabControlEventArgs e)
        {
            beallitSzamlakTabPageIndulaskor();
        }

        private void beallitSzamlakTabPageIndulaskor()
        {
            listViewRendelesek.Visible = false;
            labelVevoRendeles.Visible = false;
            dataGridViewTetelek.Visible = false;
            labelRendeloTetelei.Visible = false;
        }


    }
}
