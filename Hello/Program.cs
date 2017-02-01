using System;

namespace Hello
{
    public class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            book.NameChanged += OnNameChanged;
            book.Name = "Paul's Grade Book";
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            book.WriteGrades(Console.Out);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(book.Name);
            WriteResult("Grade", stats.LetterGrade);
            WriteResult("Performance", stats.LetterDescription);
            WriteResult("Average Grade", stats.AverageGrade);
            WriteResult("High Grade", stats.MaximumGrade);
            WriteResult("Low Grade", stats.MinimumGrade);

        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine("{0}: {1:F2}", description, result);
        }

        static void WriteResult(string description, string result)
        {
            Console.WriteLine("{0}: {1}", description, result);
        }

        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Grade book changing name from {args.ExistingName} to {args.NewName}");
        }
    }
}
