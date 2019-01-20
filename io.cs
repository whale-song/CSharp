class inputAndOutput
{
    static void Main()
    {
        string line1 = System.Console.ReadLine();
        int line2 = System.Console.Read();
        System.ConsoleKeyInfo line3 = System.Console.ReadKey();    
        
        System.Console.WriteLine("line1 = " + line1);
        System.Console.WriteLine("line2 = " + line2);
        System.Console.WriteLine("line3 = " + line3);

        /* string yourName; 

        System.Console.Write("Your Name:");
        yourName = System.Console.ReadLine();
        System.Console.WriteLine("Result:{0}", yourName);
        */
    }
}