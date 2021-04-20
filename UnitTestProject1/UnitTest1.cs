using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using StringLib;

namespace UnitTestProject1
{
    [TestClass]
    public class KeyedIndexTests
    {

        //[TestMethod]
        //public void T001_sortExams()
        //{
        //    Alphabet alphabet = new Alphabet("ABCDF");
        //    List<ExamGrade> grades = new List<ExamGrade>();
        //    char[] gradesToAssign = "BBCADACFADBCBC".ToCharArray();

        //    foreach (char grade in gradesToAssign)
        //    {
        //        grades.Add(new ExamGrade(grade));
        //    }

        //    KeyedIndexSort sort = new KeyedIndexSort(grades, alphabet);
        //    Array.Sort(gradesToAssign);

        //    int countedSorted = 0;
        //    foreach (ICharKey result in sort.GetSorted())
        //    {
        //        Assert.AreEqual(gradesToAssign[countedSorted], result.GetCharKey());
        //        ++countedSorted;
        //    }
        //    Assert.AreEqual(gradesToAssign.Length, countedSorted);
        //}
        //// end T001_sortExams()


        //[TestMethod]
        //public void T002_alphaTest()
        //{
        //    string alphaString = "abcdfABCDF";
        //    Alphabet gradeAlphabet = new Alphabet(alphaString);

        //    Assert.AreEqual(10, gradeAlphabet.Radix);
        //    Assert.AreEqual(4, gradeAlphabet.NBitsToRepresent);
        //    Assert.AreEqual(0, gradeAlphabet.ToIndex('a'));
        //    Assert.AreEqual(9, gradeAlphabet.ToIndex('F'));
        //    Assert.AreEqual(alphaString[0], gradeAlphabet.ToChar(0));
        //    Assert.AreEqual(alphaString[9], gradeAlphabet.ToChar(9));
        //    Assert.IsTrue(gradeAlphabet.Contains('F'));
        //    Assert.IsFalse(gradeAlphabet.Contains('E'));
        //    int[] indices = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        //    Assert.AreEqual(alphaString, gradeAlphabet.ToChars(indices));
        //}
        //// end T002_alphaTest()

        //[TestMethod]
        //public void T003_sortStudent()
        //{
        //    List<Student> students = new List<Student>();
        //    students.Add(new Student("Fred", "2453"));
        //    students.Add(new Student("Fred", "2342"));
        //    students.Add(new Student("Fred", "3421"));
        //    students.Add(new Student("Fred", "3241"));
        //    students.Add(new Student("Fred", "2542"));
        //    students.Add(new Student("Fred", "2342"));


        //    Alphabet alphabet = new Alphabet("0123456789");
        //    LSDSort<Student> lsdSort = new LSDSort<Student>(students, alphabet, 4);

        //    List<Student> sortedStudents = new List<Student>();
        //    foreach (IIndexedCharKey key in lsdSort.GetSorted())
        //    {
        //        sortedStudents.Add((Student)key);
        //    }


        //    List<string> expected = new List<string>() { "2453", "2342", "3421", "3241", "2542", "2342" };
        //    expected.Sort();

        //    int i = 0;
        //    foreach (Student student in sortedStudents)
        //    {
        //        Assert.AreEqual(expected[i++], student.SSN);
        //    }
        //    Assert.AreEqual(i, expected.Count);
        //}

        //[TestMethod]
        //public void T004_LSDBigTest()
        //{
        //    int nTestSize = 1024 * 1024;
        //    Random random = new Random();

        //    List<Student> lsdStudents = new List<Student>();
        //    for (int i = 0; i < nTestSize; i++)
        //    {
        //        string nextRandom = random.Next(0, 10000).ToString("D4");
        //        lsdStudents.Add(new Student("Fred", nextRandom));
        //    }

        //    Alphabet alphabet = new Alphabet("0123456789");
        //    LSDSort<Student> lsdSort = new LSDSort<Student>(lsdStudents, alphabet, 4);

        //    List<Student> sortedStudents = new List<Student>();
        //    foreach (IIndexedCharKey key in lsdSort.GetSorted())
        //    {
        //        sortedStudents.Add((Student)key);
        //    }
        //}

        //[TestMethod]
        //public void T005_LIBBigTest()
        //{
        //    int nTestSize = 1024 * 1024;
        //    Random random = new Random();

        //    List<Student> lsdStudents = new List<Student>();
        //    for (int i = 0; i < nTestSize; i++)
        //    {
        //        string nextRandom = random.Next(0, 10000).ToString("D4");
        //        lsdStudents.Add(new Student("Fred", nextRandom));
        //    }

        //    lsdStudents.Sort();
        //}
    }
}
