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
    public partial class fRep : Form
    {
        public User userInfo = new User();
        private Negocio controller = new Negocio();
        public fRep()
        {
            InitializeComponent();
        }

        private void fRep_Load(object sender, EventArgs e)
        {
            loadForm();
        }
        private void loadForm()
        {
            rbini.Checked = true;
            cProd.DataSource = controller.getProducts();
            cProd.ValueMember = "Id";
            cProd.DisplayMember = "Name";
            cProd.SelectedIndex = -1;
        }
        private int getStatus()
        {
            int status = 0;
            if (rbClose.Checked)
                status = 1;
            if (rbCancel.Checked)
                status = 2;
            return status;
        }
        private void bReportD_Click(object sender, EventArgs e)
        {
            Date d = new Date();
            d.Y = dtpd.Value.Year;
            d.M = dtpd.Value.Month;
            d.D = dtpd.Value.Day;
            dgvdaily.DataSource = controller.getDailyReport(d, getStatus());
            dgvdaily.Columns[0].Width = 200;
            dgvdaily.Columns[3].Width = 200;
            dgvdaily.Columns[4].Width = 50;
            totals();
        }

        public void totals()
        {
            int items = 0;
            double total = 0;
            for (int row = 0; row < dgvdaily.RowCount; row++)
            {
                
                //items  2   total 3
                    items += Convert.ToInt32(dgvdaily.Rows[row].Cells[1].Value);
                    total += Convert.ToInt32(dgvdaily.Rows[row].Cells[2].Value);
            }
            tItem.Text = items.ToString();
            ttotal.Text = total.ToString();

        }

        private void bFilterProd_Click(object sender, EventArgs e)
        {
            if (cProd.SelectedIndex != -1)
            {

            }
            else
                MessageBox.Show($"Selecciona un producto", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
