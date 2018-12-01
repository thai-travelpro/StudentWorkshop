using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProOnline.Gds.WebServices.Logs.Web.Models
{
    public class SearchModel
    {
        // วันที่, Gds, Host, Pcc, WebServiceName
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string Gds { get; set; }
        public string Host { get; set; }
        public string Pcc { get; set; }
        public string WebServiceName { get; set; }
    }

}
