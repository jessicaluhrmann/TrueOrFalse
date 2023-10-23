using System;

namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do not edit these lines
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            var entry = Console.ReadLine();
            //Tools.SetUpInputStream(entry);

            // Type your code below
            string[] questions = { "Are cats the world's greatest murder machines?", "Are cats so angry because they are perfect murder machines stuck in a tiny body?", "Are dogs the same?" };
            bool[] answers = { true, true, false };
            bool[] responses = new bool[questions.Length];

            if (questions.Length != answers.Length)
                Console.WriteLine("Warning! Arrays don't have the same length.");

            var askingIndex = 0;

            foreach (var question in questions)
            {
                string input;
                bool isBool;
                bool inputBool;

                Console.WriteLine(question);
                Console.WriteLine("True or False?");
                input = Console.ReadLine();

                isBool = Boolean.TryParse(input, out inputBool);

                while (isBool == false)
                {
                    Console.WriteLine("Please respond with 'true' or 'false'.");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }

                responses[askingIndex] = inputBool;
                askingIndex++;
            }

            var scoringIndex = 0;
            var score = 0;

            foreach (var answer in answers)
            {
                var responseInput = responses[scoringIndex];
                Console.WriteLine($"{scoringIndex + 1}. Input: {responses[scoringIndex]} | Answer: {answer}");

                if (responses[scoringIndex] == answers[scoringIndex])
                {
                    score++;
                }

                scoringIndex++;
            }

            Console.WriteLine($"You got {score} out of {responses.Length} correct!");
        }
    }
}