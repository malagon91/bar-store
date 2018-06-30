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

        }

        private void fSales_Load(object sender, EventArgs e)
        {
            loadForm();
        }
        public void loadForm()
        {
            //Sales
            
            dgvSales.DataSource = controller.getSales(0);
            tId.Clear();
            tDesc.Clear();

            //produc gb
            dgvProd.DataSource = controller.getProductFilter();
            gbProd.Visible = false;
            tFilter.Clear();

            //Sales
            gbData.Visible = false;
            bClose.Enabled = false;
            bEnd.Enabled = false;
            bAdd.Enabled = false;
            tItems.Clear();
            tTotal.Clear();
        }
    }
}
