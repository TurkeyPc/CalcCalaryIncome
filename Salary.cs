using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcCalaryIncome
{
    public class Salary
    {
        private readonly int earning;

        public Salary(int earning) {
            this.earning = earning;
        }

        public int income { 
            get {
                if (earning < 1)
                    throw new ArgumentException("Earning must Great Equal 1 Yen");

                if (earning < 551000)
                    return 0;
                if (earning < 1619000)
                    return earning - 550000;
                if (earning < 1620000)
                    return (int)Math.Floor(earning * 0.6m) + 97600;
                if (earning < 1622000)
                    return (int)Math.Floor(earning * 0.6m) + 98000;
                if (earning < 1624000)
                    return (int)Math.Floor(earning * 0.6m) + 98800;
                if (earning < 1628000)
                    return (int)Math.Floor(earning * 0.6m) + 99600;
                if (earning < 1800000)
                    return (int)Math.Floor(earning * 0.6m) + 100000;
                if (earning < 3600000)
                    return (int)Math.Floor(earning * 0.7m) - 80000;
                if (earning < 6600000)
                    return (int)Math.Floor(earning * 0.8m) - 440000;
                if (earning < 8500000)
                    return (int)Math.Floor(earning * 0.9m) - 1100000;
                if (earning <= 20000000)
                    return earning - 1950000;

                throw new ArgumentException("Earning must Less Equal 20,000,000 Yen");
            }
        }
    }
}
