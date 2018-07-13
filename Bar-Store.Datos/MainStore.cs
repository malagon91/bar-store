using Bar_Store.Clases;
using System.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;


namespace Bar_Store.Datos
{
    public class MainStore
    {
        private string ConectionString = Properties.Resources.cad;

        public void runQuery(string q)
        {
            SqlConnection oCon = new SqlConnection(ConectionString);
            SqlCommand oCmd = new SqlCommand(q, oCon);
            oCmd.CommandType = CommandType.Text;
            oCon.Open();
            oCmd.ExecuteNonQuery();
            oCon.Close();
            oCon.Dispose();
        }
        #region login
        public User UserLogin(string login, string pass)
        {
            SqlConnection oCon = new SqlConnection(ConectionString);
            SqlCommand oCmd = 
                new SqlCommand
                ($"select userLogin,pass, userName, CASE WHEN role = 1 THEN 'ADMIN' ELSE 'NORMAL' END AS isAdmin from users where userLogin = '{login}' and pass = '{pass}'", oCon);
            oCmd.CommandType = CommandType.Text;
            oCon.Open();
            SqlDataReader dr = oCmd.ExecuteReader();
            dr.Read();
            User user = new User();
            if (dr.HasRows)
            {
                user.Login = dr["userLogin"].ToString();
                user.Pass = dr["pass"].ToString();
                user.Name = dr["userName"].ToString();
                user.Role = dr["isAdmin"].ToString();
            }
            oCon.Close();
            oCon.Dispose();
            return user;
        }

        public User getUser(string login)
        {
            SqlConnection oCon = new SqlConnection(ConectionString);
            SqlCommand oCmd =
                new SqlCommand
                ($"select userLogin,pass, userName, CASE WHEN role = 1 THEN 'ADMIN' ELSE 'NORMAL' END AS isAdmin from users where userLogin = '{login}'", oCon);
            oCmd.CommandType = CommandType.Text;
            oCon.Open();
            SqlDataReader dr = oCmd.ExecuteReader();
            dr.Read();
            User user = new User();
            if (dr.HasRows)
            {
                user.Login = dr["userLogin"].ToString();
                user.Pass = dr["pass"].ToString();
                user.Name = dr["userName"].ToString();
                user.Role = dr["isAdmin"].ToString();
            }
            oCon.Close();
            oCon.Dispose();
            return user;
        }
        #endregion
        #region getters
        public List<User> getUsers()
        {
            SqlConnection oCon = new SqlConnection(ConectionString);
            SqlCommand oCmd = new SqlCommand("select userLogin,pass, userName, CASE WHEN role = 1 THEN 'ADMIN' ELSE 'NORMAL' END AS isAdmin from users ", oCon);
            oCmd.CommandType = CommandType.Text;

            oCon.Open();
            SqlDataReader dr = oCmd.ExecuteReader();
            List<User> users = new List<User>();
            while (dr.Read())
            {
                User vUser = new User();
                vUser.Login = dr["userLogin"].ToString();
                vUser.Pass = dr["pass"].ToString();
                vUser.Name = dr["userName"].ToString();
                vUser.Role = dr["isAdmin"].ToString();
                users.Add(vUser);
            }
            oCon.Close();
            oCon.Dispose();
            return users;
        }

        public List<Product> getProducts()
        {
            SqlConnection oCon = new SqlConnection(ConectionString);
            SqlCommand oCmd = new SqlCommand("select idProduct,product,cost,productDesc, inventory from Products order by product asc", oCon);
            oCmd.CommandType = CommandType.Text;

            oCon.Open();
            SqlDataReader dr = oCmd.ExecuteReader();
            List<Product> products = new List<Product>();
            while (dr.Read())
            {
                Product prod = new Product();
                prod.Id = Convert.ToInt32(dr["idProduct"].ToString());
                prod.Name = dr["product"].ToString();
                prod.Cost = Convert.ToDouble(dr["cost"].ToString());
                prod.Desc = dr["productDesc"].ToString();
                prod.Inventory = Convert.ToInt32(dr["inventory"].ToString());
                products.Add(prod);
            }
            oCon.Close();
            oCon.Dispose();
            return products;
        }
        #endregion
        #region  purchases 
        public List<PurchaseDTO> getPurchases()
        {
            string q = "select p.idPurchase,q.product , p.total,u.userName ,p.dop as 'Date' from Purchases p inner join users u on (p.userLogin = u.userLogin) inner join Products q on (p.idProduct = q.idProduct)";
            SqlConnection oCon = new SqlConnection(ConectionString);
            SqlCommand oCmd = new SqlCommand(q, oCon);
            oCmd.CommandType = CommandType.Text;

            oCon.Open();
            SqlDataReader dr = oCmd.ExecuteReader();
            List<PurchaseDTO> Purchases = new List<PurchaseDTO>();
            while (dr.Read())
            {
                PurchaseDTO pur = new PurchaseDTO();
                pur.Id = Convert.ToInt32(dr["idPurchase"].ToString());
                pur.Product = dr["product"].ToString();
                pur.Total = Convert.ToInt32(dr["total"].ToString());
                pur.Name = dr["userName"].ToString();
                pur.Date = dr["Date"].ToString();
                Purchases.Add(pur);
            }
            oCon.Close();
            oCon.Dispose();
            return Purchases;
        }
        #endregion

        #region sales
        public List<ProductDto> filterProducts(string filter ="")
        {
            SqlConnection oCon = new SqlConnection(ConectionString);
            SqlCommand oCmd = 
                new SqlCommand($"select idProduct,product from Products where product like'%{filter}%' order by product asc", oCon);
            oCmd.CommandType = CommandType.Text;

            oCon.Open();
            SqlDataReader dr = oCmd.ExecuteReader();
            List<ProductDto> products = new List<ProductDto>();
            while (dr.Read())
            {
                ProductDto prod = new ProductDto();
                prod.Id = Convert.ToInt32(dr["idProduct"].ToString());
                prod.Name = dr["product"].ToString();
                products.Add(prod);
            }
            oCon.Close();
            oCon.Dispose();
            return products;
        }

        public List<SaleDto> GetSalesByStatus(int status)
        {
            SqlConnection oCon = new SqlConnection(ConectionString);
            SqlCommand oCmd =
                new SqlCommand($"select idSale,Notes from Sales where saleStatus ={status} order by idSale", oCon);
            oCmd.CommandType = CommandType.Text;

            oCon.Open();
            SqlDataReader dr = oCmd.ExecuteReader();
            List<SaleDto> sales = new List<SaleDto>();
            while (dr.Read())
            {
                SaleDto sal = new SaleDto();
                sal.Id = Convert.ToInt32(dr["idSale"].ToString());
                sal.Notes = dr["Notes"].ToString();
                sales.Add(sal);
            }
            oCon.Close();
            oCon.Dispose();
            return sales;
        }

        public List<SalesDetailsDto> getSalesDatilsById(int idSale)
        {
            string q = $"select d.idProduct, p.product, d.total from SalesDetails d inner join Products p on (d.idProduct = p.idProduct) where d.idSale = {idSale} order by p.product";
            SqlConnection oCon = new SqlConnection(ConectionString);
            SqlCommand oCmd =
                new SqlCommand(q, oCon);
            oCmd.CommandType = CommandType.Text;

            oCon.Open();
            SqlDataReader dr = oCmd.ExecuteReader();
            List<SalesDetailsDto> sales = new List<SalesDetailsDto>();
            while (dr.Read())
            {
                SalesDetailsDto sal = new SalesDetailsDto();
                sal.IdProdct = Convert.ToInt32(dr["idProduct"].ToString());
                sal.Product = dr["product"].ToString();
                sal.Total = Convert.ToInt32(dr["total"].ToString());
                sales.Add(sal);
            }
            oCon.Close();
            oCon.Dispose();
            return sales;
        }

        public double getCostById(int idProduct)
        {
            string q = $"select cost from Products where idProduct = {idProduct}";
            SqlConnection oCon = new SqlConnection(ConectionString);
            SqlCommand oCmd =
                new SqlCommand(q, oCon);
            oCmd.CommandType = CommandType.Text;

            oCon.Open();
            SqlDataReader dr = oCmd.ExecuteReader();
            TotalsDto totals = new TotalsDto();
            dr.Read();
            double cost = 0;
            if (dr.HasRows)
                cost = Convert.ToDouble(dr["cost"].ToString());
            oCon.Close();
            oCon.Dispose();
            return cost;
        }
        public int getProductInCar(int idSale,int idProd)
        {
            string q = $" select count(*) as 'count' from SalesDetails where idSale = {idSale} and idProduct = {idProd}";
            SqlConnection oCon = new SqlConnection(ConectionString);
            SqlCommand oCmd =
                new SqlCommand(q, oCon);
            oCmd.CommandType = CommandType.Text;

            oCon.Open();
            SqlDataReader dr = oCmd.ExecuteReader();
            int result = 0;
            dr.Read();

            if (dr.HasRows)
               result = Convert.ToInt32(dr["count"].ToString());
            oCon.Close();
            oCon.Dispose();
            return result;
        }
        #endregion

        #region reports
        public List<Report> getDailyReport(Date da , int status)
        {        //select idSale, Notes,totalProducts , total, u.userName
            string q = "select idSale, Notes,isnull(totalProducts,0) as 'totalProducts' , isnull(total,0) as 'total', u.userName from Sales s inner join users u on (s.userLogin = u.userLogin) " +
                $"where s.saleStatus = {status} and year(dateSale)= {da.Y} and MONTH(dateSale) = {da.M} and DAY(dateSale) = {da.D}";
            SqlConnection oCon = new SqlConnection(ConectionString);
            SqlCommand oCmd = new SqlCommand(q, oCon);
            oCmd.CommandType = CommandType.Text;

            oCon.Open();
            SqlDataReader dr = oCmd.ExecuteReader();
            List<Report> reportes = new List<Report>();
            while (dr.Read())
            {
                Report rep = new Report();
                rep.Id = Convert.ToInt32(dr["idSale"].ToString());
                rep.Notes = dr["Notes"].ToString();
                rep.Items = Convert.ToInt32(dr["totalProducts"].ToString());
                rep.Total = Convert.ToDouble(dr["total"].ToString());
                rep.User = dr["userName"].ToString();
                reportes.Add(rep);
            }
            oCon.Close();
            oCon.Dispose();
            return reportes;
        }

        public List<Report> getProductsReport(string desde,string hasta, int idProduct)
        { 
            string q = "select p.product, d.total, 'Venta' as 'Tipo' from SalesDetails d inner join Sales s on (d.idSale = d.idSale) inner join Products p on(d.idSale = p.idProduct) " +
                            $"where s.dateSale between '{desde}' and '{hasta}' and p.idProduct = {idProduct} " +
                            " union all " +
                            "select t.product, p.total, 'Compra' as 'Tipo' from Purchases p inner join Products t on (p.idProduct = t.idProduct) " +
                            $"where p.dop between '{desde}' and '{hasta}' and p.idProduct = {idProduct}";
            SqlConnection oCon = new SqlConnection(ConectionString);
            SqlCommand oCmd = new SqlCommand(q, oCon);
            oCmd.CommandType = CommandType.Text;

            oCon.Open();
            SqlDataReader dr = oCmd.ExecuteReader();
            List<Report> reportes = new List<Report>();
            while (dr.Read())
            {
                Report rep = new Report();
                rep.Id = Convert.ToInt32(dr["idSale"].ToString());
                rep.Notes = dr["Notes"].ToString();
                rep.Items = Convert.ToInt32(dr["totalProducts"].ToString());
                rep.Total = Convert.ToDouble(dr["total"].ToString());
                rep.User = dr["userName"].ToString();
                reportes.Add(rep);
            }
            oCon.Close();
            oCon.Dispose();
            return reportes;
        }
        #endregion
    }
}
