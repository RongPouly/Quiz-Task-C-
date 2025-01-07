using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Testing_me
{
    public class App : MenuLogin
    {
        public void Run()
        {
            MathQuiz mathQuiz = new MathQuiz();
            MenuLogin menuLogin = new MenuLogin();
            HistoryQuiz historyQuiz = new HistoryQuiz();
            BiologyQuiz biologyQuiz = new BiologyQuiz();
            GeopraphyQuiz geopraphyQuiz = new GeopraphyQuiz();
            MixedQuiz mixedQuiz = new MixedQuiz();
            menuLogin.LoginInfo();

            Console.WriteLine("\nWelcom to quiz menu....");
            
            while (true)
            {
                Console.Write("\n1. Math\n2. History\n3. Geography\n4. Biology\n5. Mixed quizs\n6. Change info\n7. Exit...\nPlease enter a number between 1-7 : ");
                Number = Console.ReadLine();
                if (Number == "1")
                {
                    mathQuiz.Main();               
                }

                else if (Number == "2")
                {
                    historyQuiz.StartQuiz ();
                }

                else if (Number == "3")
                {
                    geopraphyQuiz.S_StartQuiz();
                }

                else if (Number == "4")
                {
                    
                    biologyQuiz.StartBiologyQuiz();
                }

                else if (Number == "5")
                {
                    mixedQuiz.StartQuiz();
                }

                
                else if (Number == "6")
                {
                    menuLogin.ChangeInfo();

                }
                else if (Number == "7")
                {
                    break;
                }

                else
                {
                    Console.WriteLine("\nInvalid input. Please enter a number between 1-6.");
                }

            }
            
        }
    }
}
