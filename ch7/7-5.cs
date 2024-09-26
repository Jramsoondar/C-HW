namespace ch7_3;

public class 7-5
{
    static void Main()
    {
        // Array of fortune-telling phrases
        string[] fortunes = {
            "I see a tall, dark stranger in your future.",
            "You will find a hidden treasure soon.",
            "A great opportunity will come your way.",
            "Beware of unexpected challenges.",
            "Love is just around the corner.",
            "You will make a new friend very soon.",
            "An exciting adventure awaits you.",
            "A surprise gift is in your future."
        };

        // Randomly select two different fortunes
        Random random = new Random();
        int firstIndex = random.Next(fortunes.Length);
        int secondIndex;

        // Ensure the second index is different from the first
        do
        {
            secondIndex = random.Next(fortunes.Length);
        } while (secondIndex == firstIndex);

        // Display the selected fortunes
        DisplayFortunes(fortunes[firstIndex], fortunes[secondIndex]);
    }

    static void DisplayFortunes(string fortune1, string fortune2)
    {
        Console.WriteLine("Your fortunes are:");
        Console.WriteLine(fortune1);
        Console.WriteLine(fortune2);
    }
}
