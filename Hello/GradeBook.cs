﻿using System;
using System.Collections.Generic;
using System.IO;

namespace Hello
{
    public class GradeBook
    {
        public GradeBook()
        {
            _name = "Empty";
            grades = new List<float>();
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();
            float sum = 0;
            foreach (float grade in grades)
            {
                stats.MaximumGrade = Math.Max(grade, stats.MaximumGrade);
                stats.MinimumGrade = Math.Min(grade, stats.MinimumGrade);
                sum += grade;
            }
            stats.AverageGrade = sum / grades.Count;
            return stats;
        }

        public void WriteGrades(TextWriter destination)
        {
            for (int i = 0; i < grades.Count; i++)
            {
                destination.WriteLine(grades[i]);
            }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    if (_name != value)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.ExistingName = _name;
                        args.NewName = value;
                        NameChanged(this, args);
                    }
                    _name = value;
                }
            }
        }

        public event NameChangedDelegate NameChanged;

        private List<float> grades;
    }
}