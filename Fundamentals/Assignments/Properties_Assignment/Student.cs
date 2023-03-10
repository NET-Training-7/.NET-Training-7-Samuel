using System;
namespace StudentDetail;
class Student
{
    string fullName;
    public string FullName // Full property
    {
        get
        {
            return fullName;
        }
        set
        {
            fullName = value;
        }
    }
    byte standard;
    public byte Standard // Read-only property
    {
        get
        {
            return standard;
        }
    }
    byte age;
    public byte Age // Write-only property
    {
        set
        {
            age = value;
        }
    }

    internal static void PrintResult(string grade)
    {
        switch (grade)
        {
            case "A":
                Console.WriteLine("Student has Passed in A grade");
                break;
            case "B":
                Console.WriteLine("Student has Passed in B grade");
                break;
            case "C":
                Console.WriteLine("Student has Passed in C grade");
                break;
            default:
                Console.WriteLine("Student failed.");
                break;
        }
    }
}
