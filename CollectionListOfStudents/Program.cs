using CollectionListOfStudents;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Student> list = new List<Student>(10);

        list.Add(new Student(1, "Suresh"));
        list.Add(new Student(3, "Ramesh"));
        list.Add(new Student(4, "Rohit"));
        list.Add(new Student(2, "Prakash"));

        foreach (Student student in list)
        {
            Console.WriteLine(student);
        }

        // Changing Name of Student whose Id is 2

        list[3].Name = "Rohit";
        Console.WriteLine(" After Changing Name of  Student Id : 2 ");
        foreach (Student student in list)
        {
            Console.WriteLine(student);
        }


        // Removing student based on Roll		
        Console.WriteLine("Enter ID Of Student to Delete : ");
        int id = int.Parse(Console.ReadLine());

        Student temp = null;
        foreach (Student student in list)
        {
            if (student.Id == id)
            {
                temp = student;
                break;
            }
        }

        if (temp == null)   
            Console.WriteLine( " Student Not Found");
        else
            list.Remove(temp);

        Console.WriteLine(" After Removing Element of Given ID ");
        foreach (Student student in list)
        {
            Console.WriteLine(student);
        }


    }
}