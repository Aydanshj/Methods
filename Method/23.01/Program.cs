using System;

namespace Method2301
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 45, 10, 25, 40, 10 };

            var index = Array.LastIndexOf(numbers, 10);

            Array.Sort(numbers);
            Array.Reverse(numbers);
            Array.Clear(numbers, 0, 2);


            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }


            Console.WriteLine(index);

            string str = " Aylin";

            str = str.ToUpper();
            Console.WriteLine(str);

            Console.WriteLine(str.Contains("Lin"));

            str = "  Amazing, World";
            var word = str.Substring(0, 6);
            Console.WriteLine(word);
            Console.WriteLine(str.IndexOf("a"));
            Console.WriteLine(str.LastIndexOf("d"));
            Console.WriteLine(str.Substring(str.IndexOf(' ') + 1));

            //str = str.Replace('l', 'L');
            str = str.Replace("Hi", "Bye");


            str = "Hard  Work!";
            str = str.Trim();

            str.StartsWith("Hard");
            str.EndsWith("rk!");


            Console.WriteLine(str);

            Console.WriteLine(char.IsDigit('a'));
            Console.WriteLine(char.IsDigit('1'));
            Console.WriteLine(char.IsLetterOrDigit('h'));

            Console.WriteLine(char.IsLower('2'));
            Console.WriteLine(char.IsUpper('4'));
            Console.WriteLine(char.ToUpper('y'));



            string sentence = "Hello Lady Mira";
            var wordsArr = sentence.Split(" ");

            var newSentence = String.Join(" + ", wordsArr);

            Console.WriteLine(newSentence);




            string name;
            do
            {
                Console.WriteLine("Ad daxil edin:");
                name = Console.ReadLine();

            } while (!char.IsUpper(name[0]));

        }
    }
    
}
