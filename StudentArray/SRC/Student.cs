using System;
using System.Collections;
using System.Text;

namespace StudentArray.SRC
{
    public class StudentArrayList
    {
        public ArrayList mStudentList = new ArrayList();    // this is storage vairable in StudentArray
        public StudentArrayList() // this is constructor when 
        {
            this.mStudentList.Clear();  // all data will be deleted
        }
        public void add(int studentID=-1, string firstName="", string lastName="", string major="", double gpa=0.0f, string dob="") // every variable has initial value
        {
            var oneStudent = new Student(studentID, firstName, lastName, major, gpa, dob);
            mStudentList.Add(oneStudent);
        }

        public void showAll() // this method shows all students' data
        {
            for (int i=0; i<this.mStudentList.Count; i++)
            {
                ((Student)this.mStudentList[i]).showMe();
            }

        }
    }
    public class Student
    {
        public int studentID { get; }
        public string firstName { get; }
        public string lastName { get; }
        public string major { get; }
        public double gpa { get; }
        public string dob { get; }

        public Student()    // this is constructor
        {
            this.studentID = 0;
            this.firstName = "";
            this.lastName = "";
            this.major = "";
            this.gpa = 0.0f;
            this.dob = "";
        }

        public Student(int studentID, string firstName, string lastName, string major, double gpa, string dob)   // this is also constructor with 
        {
            this.studentID = studentID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.major = major;
            this.gpa = gpa;
            this.dob = dob;
        }

        public void showMe() // this method shows one student' data
        {
            Console.WriteLine("Student ID : " + this.studentID);
            Console.WriteLine("  FirstName : " + this.firstName);
            Console.WriteLine("  LastName : " + this.lastName);
            Console.WriteLine("  Major : " + this.major);
            Console.WriteLine("  GPA : " + this.gpa);
            Console.WriteLine("  Date of Birth : " + this.dob);
        }
    }
}
