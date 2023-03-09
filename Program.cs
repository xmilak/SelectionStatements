namespace SelectionStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exercise 1
            //Console.WriteLine("What is my favorite number?");

            //var favNumber = 69;
            //var userInput = int.Parse(Console.ReadLine());

            //while (userInput != favNumber)
            //{
            //    if (userInput > favNumber)
            //    {
            //        Console.WriteLine("Less than that");
            //    }
            //    else if (userInput < favNumber)
            //    {
            //        Console.WriteLine("More than that");
            //    }

            //    Console.WriteLine("What is my favorite number?");
            //    userInput = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("You guessed it right! My favorite number is 69!");

            Console.WriteLine("What is your favorite subject?");
            var subject = Console.ReadLine();
            
            var response = FavoriteClassSubject(subject);
            Console.WriteLine(response);
        }

        //exercise 2
        public static string FavoriteClassSubject(string p) => p.ToLower() switch
       
        {
            "math" => "ufff i dont really like math",
            "science" => "science can be very cool",
            "computers" => "love it",
            "history" => "how can someone not love history",
            _ => "hmm intresting"
        };
    }
}
