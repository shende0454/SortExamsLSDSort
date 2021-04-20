using System;
using StringLib;

namespace UnitTestProject1
{
    class Student : IIndexedCharKey, IComparable<Student>
    {
        public Student(string name, string ssn)
        {
            Name = name;
            SSN = ssn;
        }
        string Name;
        public string SSN;

        public char GetKeyChar(int charIndex)
        {
            return SSN[charIndex];
        }

        public int CompareTo(Student other)
        {
            return SSN.CompareTo(other.SSN);
        }
    }
}
