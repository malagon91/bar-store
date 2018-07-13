using Bar_Store.Clases;
using Bar_Store.Datos;
using System.Data;
using System;
using System.Collections.Generic;

namespace Bar_Store.Negocios
{
   public class Negocio
    {
        MainStore store = new MainStore();
        #region login
        public User login (string user, string pass)
        {
            return store.UserLogin(user, pass);
        }

        public User getUser(string login)
        {
            return store.getUser(login);
        }

        #endregion

        #region purchases
        public List<PurchaseDTO> getPurchases()
        {
            return store.getPurchases();
        }

        public void savePurchase(Purchase pur)
        {
            string q = $"insert into Purchases values ({pur.IdProd},{pur.Total},'{pur.UserLogin}',getdate())";
            store.runQuery(q);
        }
        #endregion

        #region users crud 
        public List<User> getUsers()
        {
            return store.getUsers();
        }

        public void saveUser(User vUser, bool isNew)
        {
            string q = isNew ?
               $"insert into users (userLogin,pass,userName,role) values ('{vUser.Login}','{vUser.Pass}','{vUser.Name}',{vUser.Role})" :
               $"update users set pass = '{vUser.Pass}',userName ='{vUser.Name}',role ={vUser.Role} where userLogin = '{vUser.Login}'";
            store.runQuery(q);
        }

        public void deleteUser(string vUser)
        {
            string q = $"delete from users where userLogin = '{vUser}'";
            store.runQuery(q);
        }
        #endregion

        #region products crud 
        public List<Product> getProducts()
        {
            return store.getProducts();
        }

        public void saveProduct(Product prod)
        {
            string q = prod.Id == 0 ?
               $"insert into Products (product,cost,productDesc, inventory) values ('{prod.Name}',{prod.Cost},'{prod.Desc}',0)" :
               $"update Products set product = '{prod.Name}', cost = {prod.Cost}, productDesc = '{prod.Desc}' where idProduct = {prod.Id}";
            store.runQuery(q);
        }

        public void deleteProduct(int id)
        {
            string q = $"delete from Products where idProduct = '{id}'";
            store.runQuery(q);
        }
        #endregion

        #region sales
        public List<SaleDto> getSales(int status)
        {
            return store.GetSalesByStatus(status);
        }
        public List<ProductDto> getProductFilter(string filter ="")
        {
            return store.filterProducts(filter);
        }
        public List<SalesDetailsDto> getSalesDetails(int idSales)
        {
            return store.getSalesDatilsById(idSales);
        }



        public void initSale(Sale sale)
        {
            string q = sale.Id  == 0 ?
                $"insert into Sales (Notes, userLogin,saleStatus,dateSale) values ('{sale.Notes}','{sale.User}',0,GETDATE())" :
                $"update Sales set Notes = '{sale.Notes}' where idSale ={sale.Id}";
            store.runQuery(q);
        }

        public void addProduct(SalesDetails det)
        {
            int result = store.getProductInCar(det.IdSale, det.IdProdct);
            string q = result == 0 ? $"insert into SalesDetails (idSale,idProduct,total) values ({det.IdSale},{det.IdProdct},{det.Total})"
                : $"update SalesDetails set total = total + {det.Total} where idSale = {det.IdSale} and idProduct = {det.IdProdct}";
            store.runQuery(q);
        }
        public void removeProduct(int idsale , int idprod )
        {
            string q = $"delete from SalesDetails where idSale = {idsale} and idProduct = {idprod}";
            store.runQuery(q);
        }

       public double getProductCost(int id)
        {
            return store.getCostById(id);
        }

        public void cancelSale(int idSale)
        {
            string q = $"update Sales set saleStatus = 2 where idSale = {idSale}";
            store.runQuery(q);
        }

        public void updateInventory(int idProd, int items)
        {
            string q = $"update Products set inventory = inventory - {items} where idProduct = {idProd}";
            store.runQuery(q);
        }

        public void closeSale(Sale sal)
        {
            string q = $"update Sales set totalProducts ={sal.Total}, total ={sal.Mount},saleStatus = 1 where idSale ={sal.Id}";
            store.runQuery(q);
        }
        #endregion

        #region reports
        public List<Report> getDailyReport(Date da , int status)
        {
            return store.getDailyReport(da, status);
        }


        #endregion
    }
}
