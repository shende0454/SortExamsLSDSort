using StringLib;

namespace UnitTestProject1
{
    class ExamGrade : ICharKey
    {
        public ExamGrade(char grade)
        {
            Grade = grade;
        }

        public Student theStudent;
        public char Grade { get; set; }

        public char GetCharKey()
        {
            return Grade;
        }
    }
}
