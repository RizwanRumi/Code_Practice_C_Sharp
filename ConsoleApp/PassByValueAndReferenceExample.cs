internal class PassByValueAndReferenceExample
{
    private static void Main(string[] args)
    {
        int x = 15;
        int y = 20;

        Console.WriteLine("Pass by value output:"); 
        Console.WriteLine(x + " , "+ y);
        PassByValueExample(x,y);
        Console.WriteLine(x + " , " + y);

        // Pass by value output: 
        // 15 , 20
        // 15 , 20


        Console.WriteLine("\nPass by reference output:");
        Console.WriteLine(x + " , " + y);
        PassByReferenceExample(ref x, ref y);
        Console.WriteLine(x + " , " + y);

        // Pass by Reference Output;
        // 15 , 20
        // 100, 200
    }

    private static void PassByValueExample(int x, int y)
    {
        x = 100;
        y = 200;
    }

    private static void PassByReferenceExample(ref int x, ref int y)
    {
        x = 100;
        y = 200;
    }
}