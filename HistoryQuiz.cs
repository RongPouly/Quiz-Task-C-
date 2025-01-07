using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_me
{
    public class Question
    {
        public string Text { get; }
        public string[] Options { get; }
        public int CorrectAnswer { get; }
        public int CorrectOption { get; }

        public Question(string text, string[] options, int correctAnswer)
        {
            Text = text;
            Options = options;
            CorrectAnswer = correctAnswer;
            CorrectOption = correctAnswer;
        }
    }

    public class HistoryQuiz
    {
        private List<Question> Questions { get; set; }
        private int Score { get; set; }

        public HistoryQuiz()
        {
            Questions = CreateQuiz();
            Score = 0;
        }

        public void StartQuiz()
        {
            Console.WriteLine("Welcome to the History Quiz!");
            Console.WriteLine("Answer the following questions:");

            for (int i = 0; i < Questions.Count; i++)
            {
                Console.WriteLine($"\nQuestion {i + 1}: {Questions[i].Text}");
                for (int j = 0; j < Questions[i].Options.Length; j++)
                {
                    Console.WriteLine($"{j + 1}. {Questions[i].Options[j]}");
                }

                Console.Write("Your answer (1-4): ");
                if (int.TryParse(Console.ReadLine(), out int answer) && answer == Questions[i].CorrectAnswer)
                {
                    Console.WriteLine("Correct!");
                    Score++;
                }
                else
                {
                    Console.WriteLine($"Wrong! The correct answer was {Questions[i].CorrectAnswer}. {Questions[i].Options[Questions[i].CorrectAnswer - 1]}");
                }
            }

            Console.WriteLine($"\nQuiz Over! Your score: {Score}/{Questions.Count}");
        }

        private List<Question> CreateQuiz()
        {
            return new List<Question>
        {
            new Question("Who was the first President of the United States?",
                new string[] { "George Washington", "Thomas Jefferson", "Abraham Lincoln", "John Adams" }, 1),
            new Question("In what year did World War II end?",
                new string[] { "1945", "1939", "1942", "1948" }, 1),
            new Question("Which empire was ruled by Julius Caesar?",
                new string[] { "Roman Empire", "Ottoman Empire", "Byzantine Empire", "British Empire" }, 1),
            new Question("What was the name of the ship that brought the Pilgrims to America?",
                new string[] { "Santa Maria", "Mayflower", "Endeavour", "Titanic" }, 2),
            new Question("What was the first man-made satellite launched into space?",
                new string[] { "Sputnik", "Explorer 1", "Apollo 11", "Hubble" }, 1),
            new Question("Who was the famous leader of the Soviet Union during World War II?",
                new string[] { "Vladimir Lenin", "Joseph Stalin", "Leon Trotsky", "Nikita Khrushchev" }, 2),
            new Question("What year did the Berlin Wall fall?",
                new string[] { "1987", "1989", "1991", "1993" }, 2),
            new Question("Who was the famous queen of Ancient Egypt?",
                new string[] { "Nefertiti", "Cleopatra", "Hatshepsut", "Isis" }, 2),
            new Question("What was the name of the document signed in 1215 limiting the power of the English king?",
                new string[] { "The Magna Carta", "The Bill of Rights", "The Declaration of Independence", "The Treaty of Versailles" }, 1),
            new Question("Who discovered America in 1492?",
                new string[] { "Christopher Columbus", "Leif Erikson", "Marco Polo", "Vasco da Gama" }, 1),
            new Question("What was the main cause of the American Civil War?",
                new string[] { "Slavery", "Economic differences", "Territorial disputes", "Religion" }, 1),
            new Question("Who painted the ceiling of the Sistine Chapel?",
                new string[] { "Leonardo da Vinci", "Michelangelo", "Raphael", "Donatello" }, 2),
            new Question("Who was the first man to walk on the moon?",
                new string[] { "Neil Armstrong", "Buzz Aldrin", "Yuri Gagarin", "Michael Collins" }, 1),
            new Question("What was the name of the ship used by Charles Darwin on his scientific voyage?",
                new string[] { "HMS Endeavour", "HMS Beagle", "HMS Victory", "HMS Discovery" }, 2),
            new Question("Who was the British Prime Minister during most of World War II?",
                new string[] { "Neville Chamberlain", "Winston Churchill", "Clement Attlee", "Harold Macmillan" }, 2),
            new Question("What was the largest contiguous empire in history?",
                new string[] { "Mongol Empire", "Roman Empire", "British Empire", "Ottoman Empire" }, 1),
            new Question("Who wrote the Communist Manifesto?",
                new string[] { "Karl Marx and Friedrich Engels", "Vladimir Lenin", "Joseph Stalin", "Leon Trotsky" }, 1),
            new Question("Which U.S. state was the last to join the union?",
                new string[] { "Alaska", "Hawaii", "Arizona", "New Mexico" }, 2),
            new Question("What event started World War I?",
                new string[] { "The assassination of Archduke Franz Ferdinand", "The invasion of Poland", "The sinking of the Lusitania", "The Zimmermann Telegram" }, 1),
            new Question("Who was the first woman to win a Nobel Prize?",
                new string[] { "Marie Curie", "Florence Nightingale", "Rosalind Franklin", "Ada Lovelace" }, 1),
        };
        }
    }

}

