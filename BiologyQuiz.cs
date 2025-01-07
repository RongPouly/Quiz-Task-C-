using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Testing_me
{
    

    public class BiologyQuiz
    {
        public void StartBiologyQuiz()
        {
           
            var quizQuestions = new List<Question>
        {
            new Question("What is the powerhouse of the cell?",
                new[] { "Nucleus", "Mitochondria", "Ribosome", "Chloroplast" }, 1),
            new Question("What is the basic unit of life?",
                new[] { "Atom", "Tissue", "Cell", "Organ" }, 2),
            new Question("Which biomolecule is the main source of energy for living things?",
                new[] { "Proteins", "Lipids", "Carbohydrates", "Nucleic Acids" }, 2),
            new Question("What process do plants use to make food?",
                new[] { "Respiration", "Photosynthesis", "Digestion", "Fermentation" }, 1),
            new Question("What is the main function of red blood cells?",
                new[] { "Transport oxygen", "Fight infections", "Produce hormones", "Clot blood" }, 0),
            new Question("Which organ is primarily responsible for filtering blood?",
                new[] { "Liver", "Kidney", "Heart", "Lungs" }, 1),
            new Question("What is the largest organ in the human body?",
                new[] { "Heart", "Liver", "Brain", "Skin" }, 3),
            new Question("Which type of RNA carries genetic information from DNA to the ribosome?",
                new[] { "tRNA", "mRNA", "rRNA", "sRNA" }, 1),
            new Question("What is the genetic material in most living organisms?",
                new[] { "DNA", "RNA", "Protein", "Lipids" }, 0),
            new Question("Which gas do plants absorb for photosynthesis?",
                new[] { "Oxygen", "Nitrogen", "Carbon Dioxide", "Hydrogen" }, 2),
            new Question("What is the main function of the liver?",
                new[] { "Produce bile", "Pump blood", "Filter air", "Store calcium" }, 0),
            new Question("What is the name of the process by which cells divide?",
                new[] { "Meiosis", "Mitosis", "Fission", "Budding" }, 1),
            new Question("What pigment gives plants their green color?",
                new[] { "Chlorophyll", "Carotene", "Xanthophyll", "Anthocyanin" }, 0),
            new Question("Which blood type is known as the universal donor?",
                new[] { "A", "B", "AB", "O" }, 3),
            new Question("Which part of the brain controls balance and coordination?",
                new[] { "Cerebrum", "Cerebellum", "Brainstem", "Thalamus" }, 1),
            new Question("What is the smallest bone in the human body?",
                new[] { "Stapes", "Femur", "Tibia", "Humerus" }, 0),
            new Question("Which organelle is responsible for protein synthesis?",
                new[] { "Ribosome", "Golgi Apparatus", "Endoplasmic Reticulum", "Lysosome" }, 0),
            new Question("What type of blood vessels carry blood away from the heart?",
                new[] { "Veins", "Arteries", "Capillaries", "Venules" }, 1),
            new Question("What is the function of the human immune system?",
                new[] { "Digest food", "Produce energy", "Fight infections", "Filter toxins" }, 2),
            new Question("What is the primary function of the stomata in plants?",
                new[] { "Absorb sunlight", "Exchange gases", "Store water", "Anchor the plant" }, 1)
        };

            int score = 0;

            
            Console.WriteLine("Welcome to the Biology Quiz!");
            Console.WriteLine("Answer the following questions by selecting the correct option (1-4):\n");

            foreach (var question in quizQuestions)
            {
                Console.WriteLine(question.Text);
                for (int i = 0; i < question.Options.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {question.Options[i]}");
                }

                int userAnswer = GetUserAnswer();
                if (userAnswer - 1 == question.CorrectOption)
                {
                    Console.WriteLine("Correct!\n");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Wrong! The correct answer is: {question.Options[question.CorrectOption]}\n");
                }
            }

            Console.WriteLine($"You completed the quiz! Your score: {score}/{quizQuestions.Count}");
        }

        static int GetUserAnswer()
        {
            int answer;
            while (true)
            {
                Console.Write("Your answer: ");
                if (int.TryParse(Console.ReadLine(), out answer) && answer >= 1 && answer <= 4)
                {
                    break;
                }
                Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
            }
            return answer;
        }
    }

}
