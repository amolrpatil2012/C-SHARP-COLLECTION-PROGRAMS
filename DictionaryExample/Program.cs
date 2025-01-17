internal class Program
{
    private static void Main(string[] args)
    {
       Dictionary<int,string> map = new Dictionary<int,string>();

        // Adding elements to Dictionary
        map.Add(1, "Sachin");
        map.Add(2, "Rahul");
        map.Add(3, "Prakash");
        
        // Traversing Dictionary
        foreach( var entry in map )         // entry is combination of key and value
        {
            Console.WriteLine( "Key : " + entry.Key  + "Value : " + entry.Value);
        }

        foreach (KeyValuePair<int,string> entry in map)         
        {
            Console.WriteLine("Key : " + entry.Key + "Value : " + entry.Value);
        }

        // Search Operation

        Console.WriteLine( " If Key 1 Exists : " + map.ContainsKey(1));
        Console.WriteLine( " If Value Rahul Exists : " + map.ContainsValue("Rahul"));

        // Remove Operation
        map.Remove(1);          // remove entry where key is 1
        map.Clear();            // remove all elements of map


        // Get All Keys

        ICollection<int> keys = map.Keys;
        Console.WriteLine("All Keys");
        foreach (int key in keys ) 
            Console.WriteLine(key);

        // Get All Values
        ICollection<string> values = map.Values;
        foreach (var entry in values)
            Console.WriteLine(entry);










    }
}