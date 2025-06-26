using System;

class marks
{
    static void Main(String[] args)
    {
        Console.Write("Enter the name : ");
        string name = Console.ReadLine();
        Console.Write("Enter the number of Subs :");
        int subjects=Convert.ToInt32(Console.ReadLine());
        int total = 0;
        for(int i = 0; i < subjects; i++)
        {
            Console.Write($"Enter the Subject {i+1} marks : ");
            int marks=Convert.ToInt32(Console.ReadLine());
            total += marks;
        }

        Console.WriteLine($"{name} has gained {total} marks.");

    }
}
