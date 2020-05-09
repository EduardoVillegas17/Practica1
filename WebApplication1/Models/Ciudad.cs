using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Ciudad
    {
        public int Id { get; set; }
        public string CiudadName { get; set; }
        public string CiudadDescription { get; set; }
        public int PostalCode { get; set; }
    }
}