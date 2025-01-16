/*
 *  Initial Capacity            0
 *  
 *  After Adding First element      capacity        4
 *  
 *  Every after 4 elements capacity will be doubled
 * 
 */

internal class Program
{
    private static void Main(string[] args)
    {

        // Create List

        List<int> list1 = new List<int>();                                // Empty List -- Default Capacity -- 4
        
        List<int> list2 = new List<int>(100);                            // 100 --> Capacity of List

        List<int> list3 = new List<int>() { 10, 20, 30, 50 , 60 };       // List with initial elements

        //Console.WriteLine( list3.Capacity);



        // Add Elements in List

        list1.Add(15);
        list1.Add(25);
        list1.Add(35);                           // list1 --> 15 , 25 ,35
        
        // Adding one list into another List

        list3.AddRange(list1);                  //  list3 -->10, 20, 30, 50 , 60 , 15 , 25 ,35


        Console.WriteLine(" Printing List Using Normal for Loop");

        // 1. Printing List Using Normal For Loop
        for ( int i = 0; i < list3.Count; i++ )
            Console.WriteLine(list3[i]);
        

        // Inserting Element -- Inefficient

        list3.Insert(2, 65);            // 2 is index and 65 is element to insert        

        Console.WriteLine(" Printing List Using For Each Loop");
        // 2. Printing List Using foreach loop
        foreach (int n in list3)
            Console.WriteLine(n);


        // Modify List

        list3[2] = 55;

        // Remove Element

        list3.Remove(30);                // Removes given element

        //    list3.RemoveRange(5, 3);          // Remove 3 elements starting from 5th        5th , 6th , 7th
        //    list3.RemoveAll();                // Remove All elements of List
        //    list3.RemoveAt(2);                // Remove element at Index 2

        // Adding Duplicate Elements
        list3.Add(25);

        Console.WriteLine(" Printing List After Modifing 2nd Element and Removing 30 ");        
        foreach (int n in list3)
            Console.WriteLine(n);

        
        // Searching Operation

        Console.WriteLine( " Is 25 Available ? " + list3.Contains(25));
        Console.WriteLine( " Is 30 Available ? " + list3.Contains(30));

        Console.WriteLine(" Index Of 25  First :  " + list3.IndexOf(25));
        Console.WriteLine(" Index Of 25  Last  :  " + list3.LastIndexOf(25));

        Console.WriteLine(" Index Of 30 :  " + list3.IndexOf(30));      // returns -1 cause 30 is not available

        // Sorting Elements

        list3.Sort();
        Console.WriteLine(" Sorted Output ");
        foreach (int n in list3)
            Console.WriteLine(n);

        // Reversing List

        list3.Reverse();
        Console.WriteLine("Reverse Output ");
        foreach (int n in list3)
            Console.WriteLine(n);

        // Converting List to an Array

        int[]arr = list3.ToArray();





    }
}