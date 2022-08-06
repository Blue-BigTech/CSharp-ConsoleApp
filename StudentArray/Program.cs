using System;
using StudentArray.SRC;
public class Example
{
    public static void Main()
    {
        bool bExit = false; // 
        StudentArrayList allStudent = new StudentArrayList();   // this is storage variable that keeps all student data
        while (!bExit)
        {
            Console.WriteLine("Select Function : [1 : Add Student], [2 : Search(ID, Major)] , [3 : Show All Student], [4 : Exit]");
            int nCmd = Convert.ToInt32(Console.ReadLine());
            switch (nCmd)
            {
                case 1: //When you input 1, you can input new Student data
                    {
                        Console.Write("Enter your studentID: ");
                        int sudentID = Convert.ToInt32(Console.ReadLine()); // input student ID

                        Console.Write("Enter your firstName: ");
                        string firstName = Console.ReadLine();  // input firstName

                        Console.Write("Enter your lastName: ");
                        string lastName = Console.ReadLine();   // input lastname

                        Console.Write("Enter your major: ");
                        string major = Console.ReadLine();  // input major

                        Console.Write("Enter your gpa: ");
                        double gpa = Convert.ToDouble(Console.ReadLine());  //input gpa

                        Console.Write("Enter your dob: ");
                        string dob = Console.ReadLine();    // input dob

                        allStudent.add(sudentID, firstName, lastName, major, gpa, dob); // add is StudentArrayList class' member function
                    }
                    break;
                case 2:
                    Console.Write("no function yet");
                    break;
                case 3:
                    allStudent.showAll(); // showAll is StudentArrayList class' member function
                    break;
                case 4:
                    bExit = true; // app would be closed
                    break;
                default:
                    break;
            }

        }

    }
}