using System;
using System.Collections.Generic;

class Program
{
    // Create a Question class to store the question text, options, and the correct answer
    public class Question
    {
        public string Text { get; set; }
        public List<string> Options { get; set; }
        public int CorrectAnswerIndex { get; set; }

        public Question(string text, List<string> options, int correctAnswerIndex)
        {
            Text = text;
            Options = options;
            CorrectAnswerIndex = correctAnswerIndex;
        }

        public bool CheckAnswer(int answerIndex)
        {
            return answerIndex == CorrectAnswerIndex;
        }
    }

    static void Main()
    {
        // List of questions to ask
        List<Question> quizQuestions = new List<Question>
        {
            new Question("What is the capital of France?",
                new List<string> { "Berlin", "Madrid", "Paris", "Rome" }, 2),
            new Question("Which planet is known as the Red Planet?",
                new List<string> { "Earth", "Mars", "Jupiter", "Saturn" }, 1),
            new Question("Which programming language is primarily used in Unity?",
                new List<string> { "C#", "C++", "Python", "Java" }, 0)
        };

        int score = 0;
        Console.WriteLine("Welcome to the Quiz!");

        // Iterate over each question
        foreach (var question in quizQuestions)
        {
            Console.WriteLine("\n" + question.Text);

            // Display options
            for (int i = 0; i < question.Options.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {question.Options[i]}");
            }

            // Get the user's answer
            int userAnswer = 0;
            while (true)
            {
                Console.Write("Please enter the number of your answer: ");
                bool isValidInput = int.TryParse(Console.ReadLine(), out userAnswer);

                if (isValidInput && userAnswer >= 1 && userAnswer <= question.Options.Count)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice, please select a number between 1 and " + question.Options.Count);
                }
            }

            // Check if the answer is correct
            if (question.CheckAnswer(userAnswer - 1))
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect!");
            }
        }

        // Final score
        Console.WriteLine($"\nQuiz Finished! Your final score is {score} out of {quizQuestions.Count}.");
    }
}
