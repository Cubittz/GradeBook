using Hello;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grades.Test
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void CheckAverage()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();

            Assert.AreEqual(85.16f, stats.AverageGrade, 0.01);
        }
        [TestMethod]
        public void ComputesHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();

            Assert.AreEqual(91, stats.MaximumGrade);
        }

        [TestMethod]
        public void CheckGrades()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(34);
            book.AddGrade(49);
            GradeStatistics results = book.ComputeStatistics();
            Assert.AreEqual(results.LetterGrade, "F");
        }
        [TestMethod]
        public void ComputesLowestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();

            Assert.AreEqual(75, stats.MinimumGrade);
        }
    }
}
