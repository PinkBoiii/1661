using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1661.Models
{
    public class SubMyStorege
    {
        public int IDMS { get; set; }

        public int Dimensions { get; set; }

        public DateTime DAT { get; set; }

        public double MEP { get; set; }

        public string Notes { get; set; }

       public string NameST { get; set; }
       public string NameSF { get; set; }
        public string NameOfRP { get; set; }

        public int? IDst { get; set; }

        public int? IDsf { get; set; }
    }
}