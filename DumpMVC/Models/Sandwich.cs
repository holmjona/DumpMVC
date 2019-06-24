using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DumpMVC.Models {
    public class Sandwich :Product {
        private Breads _Bread;
        private bool _HasPickles;
        private bool _HasMustard;
        private bool _HasLettuce;
        private bool _HasTomatos;
        private bool _HasCheese;
        private bool _HasMayo;

        public enum Breads {
            SourDough,
            White,
            Wheat,
            MultiGrain,
            Rye,
            Pumpernickel
        }


        public bool HasPickles {
            get { return _HasPickles; }
            set { _HasPickles = value; }
        }


        public bool HasMayo {
            get { return _HasMayo; }
            set { _HasMayo = value; }
        }


        public bool HasMustard {
            get { return _HasMustard; }
            set { _HasMustard = value; }
        }


        public bool HasLettuce {
            get { return _HasLettuce; }
            set { _HasLettuce = value; }
        }


        public bool HasTomatos {
            get { return _HasTomatos; }
            set { _HasTomatos = value; }
        }


        public bool HasCheese {
            get { return _HasCheese; }
            set { _HasCheese = value; }
        }

        public Breads Bread {
            get { return _Bread; }
            set { _Bread = value; }
        }

    }
}