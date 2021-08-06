using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RodMVC.Models
{
    public class Moto : BaseModel
    {
        
        public string Nome { get; set; }
        public string Modelo { get; set; }
        public decimal Valor { get; set; }
    }
}