using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DumpMVC.Models {
    public class Product {
        private double _Price;
               
        public double Price {
            get { return _Price; }
            set { _Price = value; }
        }

    }
}