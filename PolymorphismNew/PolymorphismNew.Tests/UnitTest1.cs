using Microsoft.VisualStudio.TestTools.UnitTesting;
using PolymorphismNew.Lib;
using System;
using System.Collections.Generic;

namespace PolymorphismNew.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPersonConstructor()
        {
            Person p1 = new Person("Aranrhod", "Nader", "1987-08-13");
            Person p2 = new Person("Kuzman", "Marina", "1967-02-09");

            Assert.AreEqual(33, p1.Age);
            Assert.AreEqual(54, p2.Age);

            Assert.AreEqual("AranrhodN813", p1.ScreenName);
        }

        [TestMethod]
        public void TestStudent()
        {
            Student s1 = new Student("Nathan", "Go", "2004-05-22", 12);
            Student s2 = new Student("Lily", "Go", "2003-06-13");

            Assert.AreEqual("NathanG522Y12", s1.ScreenName);
            Assert.AreEqual("LilyG613Y13", s2.ScreenName);
            Assert.AreEqual(16, s1.Age);
        }

        [TestMethod]
        public void TestTeacher()
        {
            Teacher t1 = new Teacher("Lulian", "Cycus", "1976-09-10", "History");

            Assert.AreEqual("LulianC910TeachHistory", t1.ScreenName);

        }

        [TestMethod]
        public void TestLists()
        {
            Person p1 = new Person("Aranrhod", "Nader", "1987-08-13");
            Student s1 = new Student("Nathan", "Go", "2004-05-22", 12);
            Teacher t1 = new Teacher("Lulian", "Cycus", "1976-09-10", "History");
            Person studentAsPerson = new Student("Lily", "Go", "2003-06-13");

            List<Person> persons = new List<Person> { p1, s1, t1, studentAsPerson };
            List<Student> students = new List<Student> { s1, (Student)studentAsPerson };

            Assert.AreEqual("LilyG613Y13", studentAsPerson.ScreenName);
            Assert.AreEqual("student", s1.Job);
            Assert.AreEqual("unknown", p1.Job);
            Assert.AreEqual("unknown", studentAsPerson.Job);
        }
    }
}
