using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_me
{

    class Questions
    {
        public string Text { get; set; }
        public List<string> Options { get; set; }
        public int CorrectOption { get; set; } // Index of the correct answer (0-based)

        public Questions(string text, List<string> options, int correctOption)
        {
           
        }
    }

    public class MixedQuiz
    {
        private List<Questions> Question;

        public MixedQuiz()
        {
            Question = new List<Questions>
        {
            new Questions("What is 5 + 3?", new List<string> {"6", "7", "8", "9"}, 2),
            new Questions("Who was the first president of the United States?", new List<string> {"Thomas Jefferson", "George Washington", "Abraham Lincoln", "John Adams"}, 1),
            new Questions("What organ is responsible for pumping blood in the human body?", new List<string> {"Lungs", "Liver", "Heart", "Kidney"}, 2),
            new Questions("What is the capital of France?", new List<string> {"Paris", "London", "Berlin", "Rome"}, 0),
            new Questions("What is 12 x 12?", new List<string> {"120", "124", "144", "156"}, 2),
            new Questions("When did World War II end?", new List<string> {"1943", "1944", "1945", "1946"}, 2),
            new Questions("What is the powerhouse of the cell?", new List<string> {"Nucleus", "Mitochondria", "Ribosome", "Chloroplast"}, 1),
            new Questions("Which river is the longest in the world?", new List<string> {"Amazon", "Nile", "Yangtze", "Mississippi"}, 1),
            new Questions("What is 9 squared?", new List<string> {"18", "27", "81", "72"}, 2),
            new Questions("Who discovered gravity?", new List<string> {"Isaac Newton", "Albert Einstein", "Galileo Galilei", "Nikola Tesla"}, 0),
            new Questions("What is the chemical symbol for water?", new List<string> {"H2O", "O2", "CO2", "H2"}, 0),
            new Questions("What is the capital of Japan?", new List<string> {"Tokyo", "Kyoto", "Osaka", "Nagoya"}, 0),
            new Questions("What is 100 / 25?", new List<string> {"5", "4", "3", "2"}, 1),
            new Questions("When was the Declaration of Independence signed?", new List<string> {"1776", "1775", "1774", "1777"}, 0),
            new Questions("Which part of the plant is responsible for photosynthesis?", new List<string> {"Roots", "Stem", "Leaves", "Flowers"}, 2),
            new Questions("What is the largest continent?", new List<string> {"Africa", "Asia", "Europe", "Australia"}, 1),
            new Questions("What is the square root of 64?", new List<string> {"6", "7", "8", "9"}, 2),
            new Questions("Who was known as the Iron Lady?", new List<string> {"Angela Merkel", "Indira Gandhi", "Margaret Thatcher", "Hillary Clinton"}, 2),
            new Questions("What is the process by which plants make food?", new List<string> {"Respiration", "Photosynthesis", "Digestion", "Fermentation"}, 1),
            new Questions("Which ocean is the largest?", new List<string> {"Atlantic", "Indian", "Arctic", "Pacific"}, 3)
        };
        }

        public void StartQuiz()
        {
            int score = 0;
            Console.WriteLine("Welcome to the Mixed Quiz!\n");

            for (int i = 0; i < Question.Count; i++)
            {
                Console.WriteLine($"Q{i + 1}: {Question[i].Text}");
                for (int j = 0; j < Question[i].Options.Count; j++)
                {
                    Console.WriteLine($"{j + 1}. {Question[i].Options[j]}");
                }

                Console.Write("Your answer: ");
                int answer;
                while (!int.TryParse(Console.ReadLine(), out answer) || answer < 1 || answer > 4)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                }

                if (answer - 1 == Question[i].CorrectOption)
                {
                    Console.WriteLine("Correct!\n");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Wrong! The correct answer was: {Question[i].Options[Question[i].CorrectOption]}\n");
                }
            }

            Console.WriteLine($"Quiz finished! Your score: {score}/{Question.Count}");
        }
    }

}
