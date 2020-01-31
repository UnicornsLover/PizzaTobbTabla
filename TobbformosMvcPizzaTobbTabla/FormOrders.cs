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
            cbc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DataGridViewButtonColumn bcPlusz = new DataGridViewButtonColumn();
            bcPlusz.HeaderText = "Mennyiség növelés";
            bcPlusz.Name = "bcPlusz";
            bcPlusz.Text = "+";
            bcPlusz.UseColumnTextForButtonValue = true;
            bcPlusz.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DataGridViewButtonColumn bcMinus = new DataGridViewButtonColumn();
            bcMinus.HeaderText = "Mennyiség csökkentés";
            bcMinus.Name = "bcMinus";
            bcMinus.Text = "-";
            bcMinus.UseColumnTextForButtonValue = true;
            bcMinus.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DataGridViewButtonColumn tbcMennyiseg = new DataGridViewButtonColumn();
            bcMinus.HeaderText = "Mennyiség";
            bcMinus.Name = "mennyiseg";
            tbcMennyiseg.UseColumnTextForButtonValue = true;
            bcMinus.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DataGridViewButtonColumn tbcEgyseg = new DataGridViewButtonColumn();
            tbcEgyseg.HeaderText = "Egyslégár";
            tbcEgyseg.Name = "egysegar";
            tbcEgyseg.UseColumnTextForButtonValue = true;
            tbcEgyseg.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


            dgv.Width = 600;
            dgv.Columns.Add(cbc);
            dgv.Columns.Add(bcPlusz);
            dgv.Columns.Add(bcMinus);
            dgv.Columns.Add(tbcMennyiseg);
            dgv.Columns.Add(tbcEgyseg);


            dgv.Location = new Point(40, 55);

            //tabPageMegrendeles.SuspendLayout();
            tabPageMegrendeles.Controls.Add(dgv);
            //tabPageMegrendeles.Refresh();
        }


    }
}
