using Hello;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Grades.Test.Types
{
    [TestClass]
    public class ReferenceTypeTests
    {
        [TestMethod]
        public void UsingArrays()
        {
            float[] grades;
            grades = new float[3];

            AddGrades(grades);

            Assert.AreEqual(89.1f, grades[1]);
        }

        private void AddGrades(float[] grades)
        {
            grades[1] = 89.1f;
        }

        [TestMethod]
        public void AddDaysToDateTime()
        {
            DateTime today = new DateTime(2017, 02, 01);
            DateTime tomorrow = today.AddDays(1);
            Assert.AreEqual(tomorrow, new DateTime(2017, 02, 02));
        }
        [TestMethod]
        public void ValueTypesPassByValue()
        {
            int x = 46;
            IncrementNumber(ref x);
            Assert.AreEqual(47, x);
        }

        private void IncrementNumber(ref int number)
        {
            int x = number;
            number += 1;
        }

        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;
            GiveBookAName(book2);
            Assert.AreEqual(book2.Name, "This is my book");
        }
        private void GiveBookAName(GradeBook book)
        {
            book.Name = "This is my book";
        }
        [TestMethod]
        public void StringComparisons()
        {
            string name1 = "Paul";
            string name2 = "paul";

            bool result = String.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 += 100;

            Assert.AreNotEqual(x1, x2);
        }


        [TestMethod]
        public void GradeBookVariablesHoldAReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1 = new GradeBook();
            g1.Name = "Paul's Grade Book";
            Assert.AreNotEqual(g1.Name, g2.Name);
        }
    }
}
