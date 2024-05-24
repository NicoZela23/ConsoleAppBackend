using System.Text;

class TextProcessor
{
    public event EventHandler ProcessingCompleted;

    public void ProcessText(string filePath)
    {
        try
        {
            string text = File.ReadAllText(filePath);

            Console.WriteLine("Text Content:");
            Console.WriteLine(text);

            int wordCount = CountWords(text);
            Console.WriteLine($"Word Count: {wordCount}");

            var charFrequency = CalculateCharFrequency(text);
            Console.WriteLine("Character Frequency:");
            foreach (var entry in charFrequency)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }

            string longestWord = FindLongestWord(text);
            Console.WriteLine($"Longest Word: {longestWord}");

            OnProcessingCompleted(EventArgs.Empty);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    private int CountWords(string text)
    {
        return text.Split(" ").Length;
    }

    private Dictionary<char, int> CalculateCharFrequency(string text)
    {
        return text.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
    }
    private string FindLongestWord(string text)
    {
        return text.Split(new[] { ' ', '\t', '\n', '\r', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
           .OrderByDescending(word => word.Length)
           .FirstOrDefault();
    }
    protected virtual void OnProcessingCompleted(EventArgs e)
    {
        ProcessingCompleted?.Invoke(this, e);
    }
}
