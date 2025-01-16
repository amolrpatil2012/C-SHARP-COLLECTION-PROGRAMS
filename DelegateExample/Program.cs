
// MathOperation is delegate

// Can create variable of MathOperation and store any function with same signature

public delegate int MathOperation ( int x , int y );

internal class Program
{
    static int Add ( int x , int y )
    {
        return x + y;
    }
    static int Multiply ( int x , int y )
    {
        return x * y;
    }

    // Passing delegate as Argument to another method
    static void ExecuteDelegate ( MathOperation operation , int x , int y)
    {
        Console.WriteLine ( " Result : " + operation(x,y));
    }


    private static void Main(string[] args)
    {
        //MathOperation operation = Add;

        //Console.WriteLine( " Add = " + operation(10,20));

        //operation = Multiply;

        //Console.WriteLine( " Multiply = " + operation(10,20));

        ExecuteDelegate ( Add , 10 , 20 );      // passing function as argument to another function
      
        ExecuteDelegate ( Multiply , 10 , 20 );

        ExecuteDelegate( (x,y) => x-y , 10 , 20 );      // Lambda Expression

        
    }

}

