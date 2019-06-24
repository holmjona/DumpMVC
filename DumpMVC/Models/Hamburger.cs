using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DumpMVC.Models {
    public class Hamburger: Sandwich {
        private int _NumberOfPatties;

        public int NumberOfPatties {
            get { return _NumberOfPatties; }
            set { _NumberOfPatties = value; }
        }

    }
}