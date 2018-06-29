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
    public partial class fProduct : Form
    {
       private Negocio controller = new Negocio();

        public fProduct()
        {
            InitializeComponent();
        }

        private void tCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void fProduct_Load(object sender, EventArgs e)
        {
            clear();
        }
        public void clear()
        {
            tID.Text = "0";
            tName.Clear();
            tCost.Clear();
            tDesc.Clear();
            bSave.Enabled = false;
            bDelete.Enabled = false;
            dgv.DataSource = controller.getProducts();
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dgv_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                bDelete.Enabled = true;
                bSave.Enabled = false;
                tID.Text = dgv.SelectedRows[0].Cells[0].Value.ToString();
                tName.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
                tCost.Text = dgv.SelectedRows[0].Cells[2].Value.ToString();
                tDesc.Text = dgv.SelectedRows[0].Cells[3].Value.ToString();
                
            }
        }

        private void tName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(tName.Text != "" & tCost.Text != "")
            {
                bSave.Enabled = true;
            }
        }

        private void tCost_KeyUp(object sender, KeyEventArgs e)
        {
            if (tName.Text != "" & tCost.Text != "")
            {
                bSave.Enabled = true;
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (tName.Text != "" & tCost.Text != "")
            {
                try
                {
                    Product prod = new Product();
                    prod.Id = Convert.ToInt32(tID.Text);
                    prod.Name = tName.Text;
                    prod.Cost = Convert.ToDouble(tCost.Text);
                    prod.Desc = tDesc.Text;
                    controller.saveProduct(prod);
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar la info, Error: {ex.Message}", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else
                MessageBox.Show($"llena todos los campos por favor", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (tID.Text != "0")
                {
                    controller.deleteProduct(Convert.ToInt32(tID.Text));
                    clear();
                }else
                    MessageBox.Show($"selecciona un producto", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la info, Error: {ex.Message}", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tName.Text != "" & tCost.Text != "")
            {
                bSave.Enabled = true;
            }
        }
    }
}
