class Part4
{
    static void Runner4()
    {
        Stack<string> stack = new Stack<string>();

        stack.Push("The Lord of The Rings");
        stack.Push("Dune");
        stack.Push("Hyperion");
        stack.Push("Game of Thrones");
        stack.Push("Foundation");


        Console.WriteLine("Book Stack");
        foreach (string books in stack)
        {
            Console.WriteLine(books);
        }
        Console.WriteLine("");
            
        stack.Pop();
        stack.Pop();


        Console.WriteLine("Updated Book Stack");
        foreach (string books in stack)
        {
            Console.WriteLine(books);
        }
    }
}