using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "studentdata.txt";

        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);

            if (lines.Length > 0)
            {
                Console.WriteLine("Student Data:");
                Console.WriteLine("ID\tFirst Name\tLast Name\tGrade");

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] studentInfo = lines[i].Split(',');

                    if (studentInfo.Length >= 4) 
                    {
                        string studentID = studentInfo[0];
                        string firstName = studentInfo[1];
                        string lastName = studentInfo[2];
                        string grade = studentInfo[3];

                        Console.WriteLine($"{studentID}\t{firstName}\t{lastName}\t{grade}");
                    }
                    else
                    {
                        Console.WriteLine($"Error in line {i + 1}: Invalid data format");
                    }
                }
            }
            else
            {
                Console.WriteLine("The file is empty.");
            }
        }
        else
        {
            Console.WriteLine("File not found. Please make sure the file 'student_data.txt' is in the project directory.");
        }

        Console.ReadLine();
    }
}
