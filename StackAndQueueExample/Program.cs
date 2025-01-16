internal class Program
{
    private static void Main(string[] args)
    {
        Stack<int>  stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        Console.WriteLine("Current Stack : ");
        foreach (var item in stack)
        {
            Console.Write(item + " ");
        }

        int p = stack.Pop();
        Console.WriteLine( " Popped Element : " + p );

        if (stack.Count > 0)                    // check is stack is empty
        {
            Console.WriteLine("Current Stack : ");
            foreach (var item in stack)
            {
                Console.Write(item + " ");
            }

        }

        int q = stack.Peek();
        Console.WriteLine(" Peeked Element : " + q);

        if (stack.Count > 0)                    // check is stack is empty
        {
            Console.WriteLine("Current Stack : ");
            foreach (var item in stack)
            {
                Console.Write(item + " ");
            }

        }


        Queue<string> queue = new Queue<string>();

        queue.Enqueue("A");
        queue.Enqueue("B");
        queue.Enqueue("C");
        queue.Enqueue("D");

        Console.WriteLine("\n Queue : ");
        foreach (var item in queue) Console.Write(item + " ");

        string s = queue.Dequeue();
        Console.WriteLine(" Element Removed : " + s );
        Console.WriteLine("\n Queue : ");
        foreach (var item in queue) Console.Write(item + " ");


        

    }
}