class Part3
{
    static void Runner3()
    {
        Queue<string> queue = new Queue<string>();

        queue.Enqueue("Francisco");
        queue.Enqueue("Miguel");
        queue.Enqueue("Diego");
        queue.Enqueue("Angel");
        queue.Enqueue("Monica");

        Console.WriteLine("Customers Queue");
        foreach (string customer in queue)
        {
            Console.WriteLine(customer);
        }
        Console.WriteLine("");

        queue.Dequeue();
        queue.Dequeue();

        Console.WriteLine("Customers Updated");
        foreach (string customer in queue)
        {
            Console.WriteLine(customer);
        }
    }
}