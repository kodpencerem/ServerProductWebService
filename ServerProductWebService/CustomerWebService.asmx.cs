using System.Collections.Generic;
using System.Linq;
using System.Web.Services;

namespace ServerProductWebService
{
    /// <summary>
    /// Summary description for CustomerWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CustomerWebService : System.Web.Services.WebService
    {
        MusteriConnDataContext db = new MusteriConnDataContext();

        [WebMethod]
        public List<MusteriSonuc> MusteriGetir()
        {
            return db.Customers.Select(x=> new MusteriSonuc
            {
                MusteriID = x.CustomerID,
                MusteriAdi= x.ContactName,
                SirketAdi = x.CompanyName,
                TelefonNo = x.Phone
            }).ToList();
        }


        public class MusteriSonuc
        {
            public string MusteriID { get; set; }
            public string MusteriAdi { get; set; }
            public string SirketAdi { get; set; }
            public string TelefonNo { get; set; }
        }
    }
}
