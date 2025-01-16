/*
 * 
 * Generics allow us to create a single class or method that can be
 * used with different data types
 * 
 * 
 *      class Stydent<T>
 *      {
 *      }
 *      
 *      Student<int> s = new Student<int>();
 *      
 *      Student<double> d =
 *  
 */

public class Demo<T>        // Generic class
{
    public T data;

    public Demo()
    {

    }

    public Demo(T data)
    {
        this.data = data;
    }

    public override string ToString()
    {
        return data.ToString();
    }

 
}

public class Demo1<T1,T2>
{

}

class Demo2<T>
{
    public T Display ( T data)
    {
        Console.WriteLine(data);
        return data;
    }


}

internal class Program
{
    private static void Main(string[] args)
    {

        Demo<int> d = new Demo<int>(100);
        Console.WriteLine(d);


        Demo<string> s = new Demo<string>("HELLO");
        Console.WriteLine(s);


        Demo1<int,string> d1 = new Demo1<int,string>();






    }
}