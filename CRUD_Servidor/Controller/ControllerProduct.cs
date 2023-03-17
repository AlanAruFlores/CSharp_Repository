using System;
using System.Collections.Generic;
using System.Text;
using DataLayer;
namespace Controller
{
    public class ControllerProduct
    {
        static ProductDAO dao = new ProductDAO();
        

        public static string SeeProducts()
        {

            string contenido = "No hay productos";
            List<Product> list = dao.ShowProducts();


            if (list.Count > 0) {
                contenido = "";
                list.ForEach(element =>
                {
                    contenido += element + "\n";
                });
            }
            return contenido;
        }

        public static Product GetProduct(int id)
        {
            return dao.SelectProduct(id);
        }


    }
}
