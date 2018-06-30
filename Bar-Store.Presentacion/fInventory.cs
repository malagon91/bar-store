using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bar_Store.Negocios;
using Bar_Store.Clases;

namespace Bar_Store.Presentacion
{
    public partial class fInventory : Form
    {
        public User userInfo = new User();

        private Negocio controller = new Negocio();

        public fInventory()
        {
            InitializeComponent();
        }

        private void tCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

        private void fInventory_Load(object sender, EventArgs e)
        {
            clear();
        }
        public void clear()
        {
            cProd.DataSource = controller.getProducts();
            cProd.ValueMember = "Id";
            cProd.DisplayMember = "Name";
            cProd.SelectedIndex = -1;
            tCant.Clear();
            bSave.Enabled = false;
            dgv.DataSource = controller.getPurchases();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (cProd.SelectedIndex != -1 & tCant.Text != "")
            {
                try
                {
                    Purchase pur = new Purchase();
                    pur.IdProd = Convert.ToInt32(cProd.SelectedValue.ToString());
                    pur.Total = Convert.ToInt32(tCant.Text);
                    pur.UserLogin = userInfo.Login;
                    controller.savePurchase(pur);
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar la info, Error: {ex.Message}", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cProd.SelectedIndex != -1 & tCant.Text != "")
            {
                bSave.Enabled = true;
            }
        }

        private void tCant_KeyUp(object sender, KeyEventArgs e)
        {
            if (cProd.SelectedIndex != -1 & tCant.Text != "")
            {
                bSave.Enabled = true;
            }
        }
    }
}
