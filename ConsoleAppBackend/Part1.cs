class Part1
{
    static void Runner1()
    {
        List<int> numberList = new List<int>();
        Random randValue = new Random();

        for (int i = 0; i < 10; i++)
        {
            numberList.Add(randValue.Next(1,100));
        }

        Console.WriteLine("List elements");
        foreach (int numbers in numberList)
        {
            Console.WriteLine(numbers + " ");
        }
        Console.WriteLine();

        //Removing the first element
        numberList.First();

        //Removing the last element
        numberList.Last();

        //Updated list

        Console.WriteLine("Updated List");
        foreach(int numbers in numberList)
        {
            Console.WriteLine(numbers + " ");
        }
        Console.WriteLine();
    }
}