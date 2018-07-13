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
    public partial class fSales : Form
    {
        public User userInfo = new User();
        private Negocio controller = new Negocio();

        public fSales()
        {
            InitializeComponent();
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            loadForm();
        }

        private void fSales_Load(object sender, EventArgs e)
        {
            loadForm();
        }
        public void loadForm()
        {
            //Sales
            
            dgvSales.DataSource = controller.getSales(0);
            tId.Text = "0";
            tDesc.Clear();
            dgvSales.Columns[0].Width = 30;
            dgvSales.Columns[1].Width = 150;

            //produc gb
            dgvProd.DataSource = controller.getProductFilter();
            dgvProd.Columns[0].Width = 30;
            dgvProd.Columns[1].Width = 150;


            gbProd.Visible = false;
            tFilter.Clear();

            //Sales
            gbData.Visible = false;
            bClose.Enabled = false;
            bEnd.Enabled = false;
            bAdd.Enabled = false;
            tItems.Clear();
            tTotal.Clear();
            quitarMenu.Enabled = false;
        }

        public void loadSale()
        {
            //produc gb
            dgvProd.DataSource = controller.getProductFilter();
            dgvProd.Columns[0].Width = 30;
            dgvProd.Columns[1].Width = 150;
            gbProd.Visible = true;
            tFilter.Clear();

            //Sales
            gbData.Visible = true;
            bClose.Enabled = true;
            bEnd.Enabled = true;
//bAdd.Enabled = true;
            tCant.Text = "1";

            //Details
            dgvCon.DataSource = controller.getSalesDetails(Convert.ToInt32(tId.Text));
            dgvCon.Columns[0].Visible = false;
            dgvCon.Columns[1].Width = 130;
            dgvCon.Columns[2].Width = 50;
            loadTotals();



        }

        public void loadTotals()
        {
            double Totals = 0;
            int items = 0;
            for (int row = 0; row < dgvCon.RowCount; row++)
            {
                int idProduct = Convert.ToInt32(dgvCon.Rows[row].Cells[0].Value);
                int tItem = Convert.ToInt32(dgvCon.Rows[row].Cells[2].Value);
                items += tItem;
                Totals += (controller.getProductCost(idProduct) * tItem);

            }
            tItems.Text = items.ToString();
            tTotal.Text = Totals.ToString();
        }

        private void dgvSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSales.Rows.Count > 0)
            {
                tId.Text = dgvSales.SelectedRows[0].Cells[0].Value.ToString();
                tDesc.Text = dgvSales.SelectedRows[0].Cells[1].Value.ToString();
                loadSale();
            }
        }

        private void tFilter_KeyUp(object sender, KeyEventArgs e)
        {
            dgvProd.DataSource = tFilter.Text.Length > 0 ?
                controller.getProductFilter(tFilter.Text) :
                controller.getProductFilter();
            dgvProd.Columns[0].Width = 30;
            dgvProd.Columns[1].Width = 150;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if ( tDesc.Text != "")
            {
                try
                {
                    Sale sal = new Sale();
                    sal.Id = Convert.ToInt32(tId.Text);
                    sal.Notes = tDesc.Text;
                    sal.User = userInfo.Login;
                    controller.initSale(sal);
                    loadForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar la info, Error: {ex.Message}", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else
                MessageBox.Show($"Es necesario llenar el campo de descripcion de la mesa", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void tDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (tCant.Text != "" & dgvProd.SelectedRows.Count > 0)
            {
                try
                {
                    SalesDetails det = new SalesDetails();
                    det.IdSale = Convert.ToInt32(tId.Text);
                    det.IdProdct = Convert.ToInt32(
                        dgvProd.SelectedRows[0].Cells[0].Value.ToString()
                        );
                    det.Total = Convert.ToInt32(tCant.Text);
                    controller.addProduct(det);
                    loadSale();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar la info, Error: {ex.Message}", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else
                MessageBox.Show($"Selecciona un producto", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void dgvProd_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bEnd_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Estas seguro de cancelar la venta ?","Info",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (tId.Text != "" || tId.Text != "0")
                    {
                        controller.cancelSale(Convert.ToInt32(tId.Text));
                        loadForm();
                        MessageBox.Show("Se cancelo la mesa exitosamente!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar la info, Error: {ex.Message}", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvProd_Click(object sender, EventArgs e)
        {
            bAdd.Enabled = true;
        }

        private void dgvCon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCon.Rows.Count > 0)
            {
                quitarMenu.Enabled = true;
                quitarMenu.Text = $"Quitar {dgvCon.SelectedRows[0].Cells[1].Value}" +
                    $" de los productos";
            }
        }

        private void quitarMenu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de quitar el producto ?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int idprod = Convert.ToInt32(dgvCon.SelectedRows[0].Cells[0].Value);
                    int idsale =  Convert.ToInt32(tId.Text);
                    controller.removeProduct(idsale, idprod);
                    loadSale();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar la info, Error: {ex.Message}", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de cerrar la cuenta ?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (tId.Text != "" || tId.Text != "0")
                    {
                        decreaseInventory();
                        Sale sal = new Sale();
                        sal.Id = Convert.ToInt32(tId.Text);
                        sal.Total = Convert.ToInt32(tItems.Text);
                        sal.Mount = Convert.ToDouble(tTotal.Text);
                        controller.closeSale(sal);
                        loadForm();
                        MessageBox.Show("Se cerro la mesa exitosamente!","Informacion", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar la info, Error: {ex.Message}", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void decreaseInventory()
        {
            for (int row = 0; row < dgvCon.RowCount; row++)
            {
                try
                {
                    int idProduct = Convert.ToInt32(dgvCon.Rows[row].Cells[0].Value);
                    int tItem = Convert.ToInt32(dgvCon.Rows[row].Cells[2].Value);
                    controller.updateInventory(idProduct, tItem);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar la info, Error: {ex.Message}", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
