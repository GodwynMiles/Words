namespace Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = {
                "home",
                "programming",
                "victory",
                "C#",
                "football",
                "sport",
                "book",
                "learn",
                "dream",
                "fun"
            };

            string letter = Console.ReadLine();

            int count = 0;

            bool found = false;

            foreach (string word in words)
            {
                if (word.Contains(letter))
                {
                    Console.WriteLine(word);
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No match");
            }
        }
    }
}
