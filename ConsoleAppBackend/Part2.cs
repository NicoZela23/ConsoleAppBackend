class Part2
{
    static void Runner2()
    {
        Dictionary<string, int> studentGrades = new Dictionary<string, int>();

        studentGrades.Add("Eduardo", 95);
        studentGrades.Add("Mauricio", 80);
        studentGrades.Add("Miguel", 53);
        studentGrades.Add("Salvador", 23);
        studentGrades.Add("Xavier", 25);

        Console.WriteLine("Printing all key Values:");

        foreach (var entry in studentGrades)
        {
            Console.WriteLine($"Student: {entry.Key}, Grade: {entry.Value}");
        }

        studentGrades["Salvador"] = 50;

        studentGrades.Remove("Xavier");

        Console.WriteLine("Updated Dictionary");

        foreach(var entry in studentGrades)
        {
            Console.WriteLine($"Student: {entry.Key}, Grade: {entry.Value}");
        }
    }
}
