using System;

namespace CalcCalaryIncome {
    public class Salary {
        private readonly int earning;

        public Salary(int earning) {
            this.earning = earning;
        }

        public int income {
            get {
                if (earning < 1)
                    throw new ArgumentException("Earning must Great Equal 1 Yen");

                if (earning <= 550999)
                    return 0;

                if (earning <= 1618999)
                    return earning - 550000;

                if (earning <= 1619999)
                    return (int)Math.Floor(earning * 0.6m) + 97600;

                if (earning <= 1621999)
                    return (int)Math.Floor(earning * 0.6m) + 98000;

                if (earning <= 1623999)
                    return (int)Math.Floor(earning * 0.6m) + 98800;

                if (earning <= 1627999)
                    return (int)Math.Floor(earning * 0.6m) + 99600;

                if (earning <= 1799999)
                    return (int)Math.Floor(earning * 0.6m) + 100000;

                if (earning <= 3599999)
                    return (int)Math.Floor(earning * 0.7m) - 80000;

                if (earning <= 6599999)
                    return (int)Math.Floor(earning * 0.8m) - 440000;

                if (earning <= 8499999)
                    return (int)Math.Floor(earning * 0.9m) - 1100000;

                if (earning <= 20000000)
                    return earning - 1950000;

                throw new ArgumentException("Earning must Less Equal 20,000,000 Yen");
            }
        }
    }
}
