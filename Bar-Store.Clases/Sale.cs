using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Store.Clases
{
    public class Sale
    {
        private int id;
        private int total;
        private double mount;
        private string date;
        private int status;
        private string notes;
        private string user;

        public int Id { get => id; set => id = value; }
        public int Total { get => total; set => total = value; }
        public double Mount { get => mount; set => mount = value; }
        public string Date { get => date; set => date = value; }
        public int Status { get => status; set => status = value; }
        public string Notes { get => notes; set => notes = value; }
        public string User { get => user; set => user = value; }
    }

    public class SalesDetails
    {
        private int idSale;
        private int idProdct;
        private int total;
        private double mount;
        private string notes;

        public int IdSale { get => idSale; set => idSale = value; }
        public int IdProdct { get => idProdct; set => idProdct = value; }
        public int Total { get => total; set => total = value; }
        public double Mount { get => mount; set => mount = value; }
        public string Notes { get => notes; set => notes = value; }
    }
}
