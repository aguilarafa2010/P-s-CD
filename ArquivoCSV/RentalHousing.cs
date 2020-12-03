using System;
using System.Collections.Generic;
using System.Text;

namespace ArquivoCSV
{
    public class RentalHousing
    {
        public string HeatingSystem { get; set; }
        public string YearHS { get; set; }
        public string Boiler { get; set; }
        public string YearB { get; set; }
        public bool E { get; set; }
        public bool P { get; set; }
        public bool B { get; set; }
        public bool? Classe { get; set; }

    }
}
