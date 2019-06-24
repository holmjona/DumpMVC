using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DumpMVC.Models {
    public class ChickenSandwich:Sandwich {
        private bool _IsFried;

        public bool IsFried {
            get { return _IsFried; }
            set { _IsFried = value; }
        }
    }
}