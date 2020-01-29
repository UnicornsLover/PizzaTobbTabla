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
        DataGridView dgv = new DataGridView();

        private void fillComboBoxCustomer()
        {
            //comboBox feltöteni adatokkal
            comboBoxCustomer.DataSource = null;
            comboBoxCustomer.DataSource = repo.getCustumersName();
        }

        private void createDinamicDataGridViewToOrders()
        {

            DataGridViewComboBoxColumn cbc = new DataGridViewComboBoxColumn();
            cbc.Name = "pizzaName";
            cbc.HeaderText = "Pizza név:";
            cbc.MaxDropDownItems = 5;
            cbc.DataSource = repo.getPizzasName();

            dgv.Location = new Point(40, 55);
            dgv.Columns.Add(cbc);

            //tabPageMegrendeles.SuspendLayout();
            tabPageMegrendeles.Controls.Add(dgv);
            tabPageMegrendeles.Refresh();
        }


    }
}
