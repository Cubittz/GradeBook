namespace Hello
{
    public class GradeStatistics
    {
        public GradeStatistics()
        {
            MaximumGrade = 0;
            MinimumGrade = float.MaxValue;
        }
        public string LetterGrade
        {
            get
            {
                string result;
                if (AverageGrade >= 90)
                {
                    result = "A";
                }
                else if (AverageGrade >= 80)
                {
                    result = "B";
                }
                else if (AverageGrade >= 70)
                {
                    result = "C";
                }
                else if (AverageGrade >= 60)
                {
                    result = "D";
                }
                else
                {
                    result = "F";
                }
                return result;
            }
        }
        public string LetterDescription
        {
            get
            {
                string description;
                switch (LetterGrade)
                {
                    case "A":
                        description = "Excellent";
                        break;
                    case "B":
                        description = "Very good";
                        break;
                    case "C":
                        description = "Average";
                        break;
                    case "D":
                        description = "Poor";
                        break;
                    default:
                        description = "Failing";
                        break;
                }
                return description;
            }

        }


        public float AverageGrade;
        public float MaximumGrade;
        public float MinimumGrade;
    }
}
