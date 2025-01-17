
class Emp
{
    public int Id { get; set; }
    public string Name { get; set; }
}
class Dept
{
    public string Id { get; set; }
    public string Name { get; set; }
   
}

internal class Program
{
    private static void Main(string[] args)
    {
        Emp emp1 = new Emp() { Id = 1, Name = "Suresh" };
        Emp emp2 = new Emp() { Id = 2, Name = "Sachin" };
        Emp emp3 = new Emp() { Id = 3, Name = "Rahul" };
        Emp emp4 = new Emp() { Id = 4, Name = "Rohit" };

        Dept dept1 = new Dept() { Id = "IT", Name = "IT Dept" };
        Dept dept2 = new Dept() { Id = "ACC", Name = "ACCOUNTS Dept" };

        Dictionary<Emp,Dept> d = new Dictionary<Emp,Dept>();    
        d.Add(emp1, dept1);         // emp1 [ 1, Suresh ] --- dept1 [ IT ]
        d.Add(emp2 , dept2);        // emp2 [ 2 , Sachin ] --- dept2 [ ACC ]
        d.Add(emp3, dept1);         // emp3 [ 3 , Rahul ] --- dept1 [ IT ]
        d.Add(emp4 , dept2);        // emp4 [ 4 , Rohit ] --- dept2 [ ACC ]
       
        Console.WriteLine("Enter Id of Emp");
        int Eid = int.Parse(Console.ReadLine());

        foreach (var entry in d) 
        {
            Emp emp = entry.Key;
            Dept dept = entry.Value;

            if ( emp.Id == Eid)
            {
                Console.WriteLine( dept.Name );
            }
        }


    }
}