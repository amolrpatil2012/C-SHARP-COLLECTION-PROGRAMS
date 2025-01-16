class Student
{
    public string Name { get; set; }
    public int Marks { get; set; }
}

internal class Program
{
    private static void Main(string[] args)
    {
        List<int> list = new List<int>() { 11, 15, 21, 25, 31, 35, 41, 45, 51 };

        // Traverse List Using ForEach Method

        list.ForEach( x => Console.WriteLine(x) );

        // Checks if any even no is available in list

        bool result = list.Exists(x => x % 2 == 0);
        Console.WriteLine(result);

        // Remove all nos which are divisible by 5 from list

        list.RemoveAll ( x => x % 5 == 0);
        list.ForEach(x => Console.WriteLine(x));

        List<Student> students = new List<Student>() {
            new Student() { Marks = 65 , Name = "Suresh" },
            new Student() { Marks = 55 , Name = "Rahul" },
            new Student() { Marks = 85 , Name = "Rohit" },
            new Student() { Marks = 95 , Name = "Virat" },
        };

        //Student? std = students.Find(s => s.Marks == 95);   // ? -- suggest nullable type
        //if ( std != null)
        //    Console.WriteLine(std.Name);

        // Print All Student Names Having Marks > 80

        students
            .FindAll( s => s.Marks > 80)
            .ForEach( s => Console.WriteLine(s.Name) );






    }
}