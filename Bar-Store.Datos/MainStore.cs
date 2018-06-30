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
        public List<Product> filterProducts(string filter ="")
        {
            SqlConnection oCon = new SqlConnection(ConectionString);
            SqlCommand oCmd = 
                new SqlCommand($"select idProduct,product from Products where product like'%{filter}%' order by product asc", oCon);
            oCmd.CommandType = CommandType.Text;

            oCon.Open();
            SqlDataReader dr = oCmd.ExecuteReader();
            List<Product> products = new List<Product>();
            while (dr.Read())
            {
                Product prod = new Product();
                prod.Id = Convert.ToInt32(dr["idProduct"].ToString());
                prod.Name = dr["product"].ToString();
                products.Add(prod);
            }
            oCon.Close();
            oCon.Dispose();
            return products;
        }

        public List<Sale> GetSalesByStatus(int status)
        {
            SqlConnection oCon = new SqlConnection(ConectionString);
            SqlCommand oCmd =
                new SqlCommand($"select idSale,Notes from Sales where saleStatus ={status} order by idSale", oCon);
            oCmd.CommandType = CommandType.Text;

            oCon.Open();
            SqlDataReader dr = oCmd.ExecuteReader();
            List<Sale> sales = new List<Sale>();
            while (dr.Read())
            {
                Sale sal = new Sale();
                sal.Id = Convert.ToInt32(dr["idSale"].ToString());
                sal.Notes = dr["Notes"].ToString();
                sales.Add(sal);
            }
            oCon.Close();
            oCon.Dispose();
            return sales;
        }

        public List<Sale> getSalesDatilsById(int idSale)
        {
            string q = $"select p.product, d.total from SalesDetails d inner join Products p on (d.idProduct = p.idProduct) where d.idSale = {idSale} order by p.product";
            SqlConnection oCon = new SqlConnection(ConectionString);
            SqlCommand oCmd =
                new SqlCommand(q, oCon);
            oCmd.CommandType = CommandType.Text;

            oCon.Open();
            SqlDataReader dr = oCmd.ExecuteReader();
            List<Sale> sales = new List<Sale>();
            while (dr.Read())
            {
                Sale sal = new Sale();
                sal.Id = Convert.ToInt32(dr["idSale"].ToString());
                sal.Notes = dr["Notes"].ToString();
                sales.Add(sal);
            }
            oCon.Close();
            oCon.Dispose();
            return sales;
        }
        #endregion
    }
}
