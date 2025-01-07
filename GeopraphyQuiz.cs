using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_me
{
    
    public class GeopraphyQuiz
    {

        class Question
        {
            public string QuestionText { get; set; }
            public string[] Answers { get; set; }
            public int CorrectAnswerIndex { get; set; }

            public Question(string questionText, string[] answers, int correctAnswerIndex)
            {
                QuestionText = questionText;
                Answers = answers;
                CorrectAnswerIndex = correctAnswerIndex;
            }
        }

        private List<Question> questions;


        public GeopraphyQuiz()
        {
            questions = new List<Question>();

            // Add 20 questions here
            questions.Add(new Question("What is the capital of France?", new string[] { "Berlin", "Madrid", "Paris", "Rome" }, 2));
            questions.Add(new Question("Which country has the largest population?", new string[] { "USA", "India", "China", "Russia" }, 2));
            questions.Add(new Question("What is the longest river in the world?", new string[] { "Amazon", "Nile", "Yangtze", "Mississippi" }, 1));
            questions.Add(new Question("Which continent is the Sahara Desert located on?", new string[] { "Asia", "Africa", "North America", "Australia" }, 1));
            questions.Add(new Question("Which ocean is the largest?", new string[] { "Atlantic", "Pacific", "Indian", "Arctic" }, 1));
            questions.Add(new Question("Which country is the Eiffel Tower located in?", new string[] { "France", "Italy", "Germany", "Spain" }, 0));
            questions.Add(new Question("Which mountain is the highest in the world?", new string[] { "K2", "Mount Everest", "Kangchenjunga", "Mount Kilimanjaro" }, 1));
            questions.Add(new Question("What is the capital of Japan?", new string[] { "Beijing", "Seoul", "Tokyo", "Osaka" }, 2));
            questions.Add(new Question("Which country is known as the Land of the Rising Sun?", new string[] { "China", "Japan", "India", "Thailand" }, 1));
            questions.Add(new Question("Which continent is Australia part of?", new string[] { "Asia", "Australia", "Oceania", "Antarctica" }, 2));
            questions.Add(new Question("What is the largest desert in the world?", new string[] { "Sahara", "Gobi", "Kalahari", "Antarctic Desert" }, 3));
            questions.Add(new Question("Which river flows through Egypt?", new string[] { "Amazon", "Yangtze", "Nile", "Danube" }, 2));
            questions.Add(new Question("Which country has the most time zones?", new string[] { "USA", "Russia", "Canada", "Australia" }, 1));
            questions.Add(new Question("What is the capital of Canada?", new string[] { "Vancouver", "Ottawa", "Toronto", "Montreal" }, 1));
            questions.Add(new Question("Which is the largest island in the world?", new string[] { "Greenland", "New Guinea", "Borneo", "Madagascar" }, 0));
            questions.Add(new Question("Which country is home to the Great Barrier Reef?", new string[] { "Australia", "New Zealand", "Fiji", "Indonesia" }, 0));
            questions.Add(new Question("What is the smallest country in the world?", new string[] { "Monaco", "Vatican City", "San Marino", "Liechtenstein" }, 1));
            questions.Add(new Question("Which mountain range is Mount Everest part of?", new string[] { "Andes", "Alps", "Himalayas", "Rockies" }, 2));
            questions.Add(new Question("Which continent is known as the Dark Continent?", new string[] { "Asia", "Africa", "South America", "North America" }, 1));
            questions.Add(new Question("Which is the longest river in South America?", new string[] { "Amazon", "Orinoco", "Parana", "Magdalena" }, 0));
            questions.Add(new Question("What is the capital of Germany?", new string[] { "Berlin", "Munich", "Hamburg", "Frankfurt" }, 0));
        }

        public void S_StartQuiz()
        {
            int score = 0;

            foreach (var question in questions)
            {
                Console.WriteLine(question.QuestionText);
                for (int i = 0; i < question.Answers.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {question.Answers[i]}");
                }

                Console.Write("Enter your answer (1-4): ");
                int answer;
                if (int.TryParse(Console.ReadLine(), out answer) && answer >= 1 && answer <= 4)
                {
                    if (answer - 1 == question.CorrectAnswerIndex)
                    {
                        score++;
                        Console.WriteLine("Correct!\n");
                    }
                    else
                    {
                        Console.WriteLine($"Wrong! The correct answer was: {question.Answers[question.CorrectAnswerIndex]}\n");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 4.\n");
                }
            }

            Console.WriteLine($"Quiz finished! Your score is: {score}/{questions.Count}");
        }


    }

}
