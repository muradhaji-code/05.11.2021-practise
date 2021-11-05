using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._11._2021_practise
{
    class Milk : Product
    {
        public double Volume { get; set; }
        public double FatRate { get; set; }
        public Milk(string Name, double Price, int Count, double Volume, double FatRate)
        {
            this.Name = Name;
            this.Price = Price;
            this.Count = Count;
            this.TotalIncome = 0;
            this.Volume = Volume;
            this.FatRate = FatRate;
        }
        public bool isValid()
        {
            if (this.Name == "") return false;
            return true;
        }
    }
}
