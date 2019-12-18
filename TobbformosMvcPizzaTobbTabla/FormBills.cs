using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TobbbformosPizzaAlkalmazasTobbTabla.Model;
using TobbbformosPizzaAlkalmazasTobbTabla.Repository;

namespace TobbformosMvcPizzaTobbTabla
{
    public partial class FormPizzaFutarKft : Form
    {
        private void tabControlPizzaFutarKFT_Selected(object sender, TabControlEventArgs e)
        {
            beallitSzamlakTabPagetIndulaskor();
            feltoltComboBoxotMegrendelokkel();
        }

        private void feltoltComboBoxotMegrendelokkel()
        {
            comboBoxMegrendelok.DataSource = repo.getCustumersName();
        }

        private void beallitSzamlakTabPagetIndulaskor()
        {
            listViewRendelesek.Visible = false;
            labelRendelesek.Visible = false;
            dataGridViewTelelek.Visible = false;
            labelTelelek.Visible = false;
        }
        private void comboBoxMegrendelok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMegrendelok.SelectedIndex < 0)
            {
                return;
            }
            listViewRendelesek.Visible = true;

            string megrendeloNev = comboBoxMegrendelok.Text;
            feltoltListViewAdatokkal(megrendeloNev);
        }

        private void feltoltListViewAdatokkal(string megrendeliNev)
        {
            List<Order> orders = repo.getMegrendelok(megrendeliNev);

            foreach (Order megrendelo in orders)
            {
                ListViewItem lvi = new ListViewItem();
            }
        }
    }
}
