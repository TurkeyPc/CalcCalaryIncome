using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalcCalaryIncome.Tests {
    [TestClass()]
    public class SalaryTests {

        [TestMethod()]
        public void SalaryTestEarinigIsZero() {
            Salary target = new Salary(0);

            try {
                var result = target.income;
            }
            catch (ArgumentException ae) {
                Assert.AreEqual("Earning must Great Equal 1 Yen", ae.Message);
            }
        }
        [TestMethod()]
        public void SalaryTestEarningIs550999() {
            Salary target = new Salary(550999);
            Assert.AreEqual(0, target.income);
        }
        [TestMethod()]
        public void SalaryTestEarningIs551000() {
            Salary target = new Salary(551000);
            Assert.AreEqual(1000, target.income);
        }
        [TestMethod()]
        public void SalaryTestEarningIs1618999() {
            Salary target = new Salary(1618999);
            Assert.AreEqual(1068999, target.income);
        }
        [TestMethod()]
        public void SalaryTestEarningIs1619000() {
            Salary target = new Salary(1619000);
            Assert.AreEqual(1069000, target.income);
        }
        [TestMethod()]
        public void SalaryTestEarningIs1619999() {
            Salary target = new Salary(1619999);
            Assert.AreEqual(1069599, target.income);
        }
        [TestMethod()]
        public void SalaryTestEarningIs1620000() {
            Salary target = new Salary(1620000);
            Assert.AreEqual(1070000, target.income);
        }
        [TestMethod()]
        public void SalaryTestEarningIs1621999() {
            Salary target = new Salary(1621999);
            Assert.AreEqual(1071199, target.income);
        }
        [TestMethod()]
        public void SalaryTestEarningIs1622000() {
            Salary target = new Salary(1622000);
            Assert.AreEqual(1072000, target.income);
        }
        [TestMethod()]
        public void SalaryTestEarningIs1623999() {
            Salary target = new Salary(1623999);
            Assert.AreEqual(1073199, target.income);
        }
        [TestMethod()]
        public void SalaryTestEarningIs1624000() {
            Salary target = new Salary(1624000);
            Assert.AreEqual(1074000, target.income);
        }
        [TestMethod()]
        public void SalaryTestEarningIs1627999() {
            Salary target = new Salary(1627999);
            Assert.AreEqual(1076399, target.income);
        }
        [TestMethod()]
        public void SalaryTestEarningIs1628000() {
            Salary target = new Salary(1628000);
            Assert.AreEqual(1076800, target.income);
        }
        [TestMethod()]
        public void SalaryTestEarningIs1799999() {
            Salary target = new Salary(1799999);
            Assert.AreEqual(1179999, target.income);
        }
        [TestMethod()]
        public void SalaryTestEarningIs1800000() {
            Salary target = new Salary(1800000);
            Assert.AreEqual(1180000, target.income);
        }
        [TestMethod()]
        public void SalaryTestEarningIs3599999() {
            Salary target = new Salary(3599999);
            Assert.AreEqual(2439999, target.income);
        }
        [TestMethod()]
        public void SalaryTestEarningIs3600000() {
            Salary target = new Salary(3600000);
            Assert.AreEqual(2440000, target.income);
        }
        [TestMethod()]
        public void SalaryTestEarningIs6599999() {
            Salary target = new Salary(6599999);
            Assert.AreEqual(4839999, target.income);
        }
        [TestMethod()]
        public void SalaryTestEarningIs6600000() {
            Salary target = new Salary(6600000);
            Assert.AreEqual(4840000, target.income);
        }
        [TestMethod()]
        public void SalaryTestEarningIs8499999() {
            Salary target = new Salary(8499999);
            Assert.AreEqual(6549999, target.income);
        }
        [TestMethod()]
        public void SalaryTestEarningIs8500000() {
            Salary target = new Salary(8500000);
            Assert.AreEqual(6550000, target.income);
        }
        [TestMethod()]
        public void SalaryTestEarningIs20000000() {
            Salary target = new Salary(20000000);
            Assert.AreEqual(18050000, target.income);
        }
        [TestMethod()]
        public void SalaryTestEarinigIsOverTwentyMillion() {
            Salary target = new Salary(20_000_001);

            try {
                var result = target.income;
            }
            catch (ArgumentException ae) {
                Assert.AreEqual("Earning must Less Equal 20,000,000 Yen", ae.Message);
            }
        }
    }
}