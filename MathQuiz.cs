using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_me
{
    public class MathQuiz
    {
        class Question
        {
            public string Text { get; set; }
            public List<int> Options { get; set; }
            public int Answer { get; set; }
        }

        static List<Question> GenerateQuestions()
        {
            var questions = new List<Question>();
            var random = new Random();

            for (int i = 0; i < 20; i++)
            {
                int num1 = random.Next(1, 21);
                int num2 = random.Next(1, 21);
                int correctAnswer = num1 + num2;

                // Generate 3 wrong answers
                var wrongAnswers = new HashSet<int>();
                while (wrongAnswers.Count < 3)
                {
                    int wrong = random.Next(correctAnswer - 10, correctAnswer + 10);
                    if (wrong != correctAnswer)
                    {
                        wrongAnswers.Add(wrong);
                    }
                }

                // Combine correct answer with wrong ones and shuffle
                var options = new List<int>(wrongAnswers) { correctAnswer };
                options.Sort((a, b) => random.Next(-1, 2));

                questions.Add(new Question
                {
                    Text = $"What is {num1} + {num2}?",
                    Options = options,
                    Answer = correctAnswer
                });
            }

            return questions;
        }

        static void DisplayQuestion(Question question, int questionNumber)
        {
            Console.WriteLine($"Question {questionNumber}: {question.Text}");
            for (int i = 0; i < question.Options.Count; i++)
            {
                Console.WriteLine($"  {i + 1}. {question.Options[i]}");
            }
        }

        public void Main()
        {
            Console.WriteLine("Welcome to the Math Quiz!");
            var questions = GenerateQuestions();
            int score = 0;

            for (int i = 0; i < questions.Count; i++)
            {
                var question = questions[i];
                DisplayQuestion(question, i + 1);

                int choice;
                while (true)
                {
                    Console.Write("Choose your answer (1-4): ");
                    if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 4)
                    {
                        break;
                    }
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                }

                if (question.Options[choice - 1] == question.Answer)
                {
                    Console.WriteLine("Correct!\n");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Wrong! The correct answer was {question.Answer}\n");
                }
            }

            Console.WriteLine($"Quiz complete! Your final score is {score}/20.");
        }
    }

}
