using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Product
{
    public enum TypesProduct
    {
        Food,
        Tech
    }
    public class Product
    {
        public string NameProduct { get; set; }
        public double CostProduct { get; set; }
        public TypesProduct TypeProduct { get; set; }
        //public int SourceImage { get; set; }        
    }
}
