class Student : IComparable<Student>
{
    public int Age { get; set; }
    public string Name { get; set; }

    // compare two student objects  -- this , other

    /*
     *      Student s1 = new Student ( 23 , "Suresh");
     *      Student s2 = new Student ( 25 , "Ramesh");
     *      
     *      int x = s1.CompareTo(s2);
     *      
     *      x > 0        s1 > s2
     *      x < 0        s2 > s1
     *      x == 0       s1 == s2
     */
    public int CompareTo( Student? other )        // ? meaning ?
    {
       // return this.Age.CompareTo(other.Age);
         return this.Name.CompareTo(other.Name); 
    }

    public override string ToString()
    {
        return " Name : " + Name + " Age : " + Age;
    }
}

/*
 *  Problems with Comparable Interface
 *  
 *  1.  Can make comparison based on only single property
 *  2.  Need to make changes in Entity class to change comparison property
 * 
 */

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return " Name : " + Name + " Age : " + Age;
    }

}

class AgeComparator : IComparer<Person>
{
    public int Compare(Person? x, Person? y)
    {
        return x.Age.CompareTo(y.Age);
    }
}
class NameComparator : IComparer<Person>
{
    public int Compare(Person? x, Person? y)
    {
        return x.Name.CompareTo(y.Name);
    }
}


internal class Program
{
    private static void Main(string[] args)
    {
        //List<Student> students = new List<Student>() { 

        //    new Student() { Age = 4 , Name = "Suresh"} ,
        //    new Student() { Age = 2 , Name = "Virat"} ,
        //    new Student() { Age = 3 , Name = "Rohit"} ,
        //    new Student() { Age = 1 , Name = "Prakash"} ,

        //};

        //Console.WriteLine("Before Sorting : ");
        //foreach (Student student in students)
        //{
        //    Console.WriteLine(student);
        //}

        //students.Sort();          // Natural Sorting

        //Console.WriteLine("After Sorting : ");
        //foreach (Student student in students)
        //{
        //    Console.WriteLine(student);
        //}

        List<Person> persons = new List<Person>() {

            new Person() { Age = 4 , Name = "Suresh"} ,
            new Person() { Age = 2 , Name = "Virat"} ,
            new Person() { Age = 3 , Name = "Rohit"} ,
            new Person() { Age = 1 , Name = "Prakash"} ,

        };

        Console.WriteLine("Before Sorting : ");
        foreach (Person person in persons)
        {            
                Console.WriteLine(person);
            
        }
        persons.Sort(new AgeComparator());

        Console.WriteLine("After Sorting On Basis of Age: ");
        foreach (Person person in persons)
        {
            Console.WriteLine(person);

        }

        persons.Sort(new NameComparator());

        Console.WriteLine("After Sorting On Basis of Name: ");
        foreach (Person person in persons)
        {
            Console.WriteLine(person);

        }
    }

    
}