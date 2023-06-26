class Example
{
    public static void Main()
    {
        var s = new Acme.Collections.Stack<int>();
        s.Push(2); 
        s.Push(20); 
        s.Push(200); 
        Console.WriteLine(s.Pop());  
        Console.WriteLine(s.Pop()); 
        Console.WriteLine(s.Pop()); 
    }
}