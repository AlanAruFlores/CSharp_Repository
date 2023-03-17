using System;
using System.Collections.Generic;
using System.Text;
using DataLayer;
namespace Controller
{
    public class ControllerVentas
    {
        static VentasDAO dao = new VentasDAO();

        public static bool RegisterNewVenta(int iu, int ip)
        {
            if (ControllerProduct.GetProduct(ip) == null) return false;

            return dao.insertNewVenta(iu, ip);
        }

        public static string ShowVentas()
        {
            return dao.ShowAll();
        }
    }

}
