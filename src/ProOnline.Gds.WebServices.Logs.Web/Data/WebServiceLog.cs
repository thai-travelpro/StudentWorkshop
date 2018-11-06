using System;
using System.ComponentModel.DataAnnotations;

namespace ProOnline.Gds.WebServices.Logs.Web.Data
{
    public class WebServiceLog
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public string Gds { get; set; }
        public string Host { get; set; }
        public string Pcc { get; set; }
        public string Username { get; set; }
        public string WebServiceName { get; set; }
        public string Version { get; set; }
        public bool SuccessedReq { get; set; }
        public bool SuccessedResp { get; set; }
        public double TotalMillieseconds { get; set; }
    }
}
