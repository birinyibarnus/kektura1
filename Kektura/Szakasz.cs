using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kektura
{
    public class Szakasz
    {
        public Szakasz(string[] szakasz)
        {
            this.StartPoint = szakasz[0];
            this.EndPoint = szakasz[1];
            this.Lenght = Convert.ToDouble(szakasz[2]);
            this.SumOfRise = Convert.ToInt32(szakasz[3]);
            this.SumOfSlopes = Convert.ToInt32(szakasz[4]);
            this.Seal = szakasz[5] == "n" ? false : true;
        }

        public string StartPoint;
        public string EndPoint;
        public double Lenght;
        public int SumOfRise;
        public int SumOfSlopes;
        public bool Seal;
    }

}
