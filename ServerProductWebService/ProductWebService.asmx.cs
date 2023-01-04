using System.Collections.Generic;
using System.Linq;
using System.Web.Services;

namespace ServerProductWebService
{
    /// <summary>
    /// Summary description for ProductWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.None)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ProductWebService : WebService
    {

        ProductConnDataContext db = new ProductConnDataContext();

        [WebMethod]
        public List<UrunSonuc> UrunleriGetir()
        {
            return db.Products.Select(x => new UrunSonuc
            {
                UrunID = x.ProductID,
                UrunAdi = x.ProductName,
                Fiyat = x.UnitPrice,
                Stok = x.UnitsInStock
            }).ToList();
        }

        public class UrunSonuc
        {
            public int UrunID { get; set; }
            public string UrunAdi { get; set; }
            public decimal? Fiyat { get; set; }
            public short? Stok { get; set; }
        }
    }
}