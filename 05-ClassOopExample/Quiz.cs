using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOopExample
{
    internal class Quiz
    {
        private Question[] _questions;
        private int _score;

        public Quiz(Question[] questions)
        {
            // "this" keyword in C# refers to the current instance of the class it is used in.
            // it is used to access members (like properties and methods) of the same object
            // left "questions" is referring to the class quiz private field not the
            // parameter "questions" above
            this._questions = questions;
            _score = 0;
        }

        public void StartQuiz()
        {
            Console.WriteLine("Welcome to the Quiz!");
            int questionNumber = 1;

            foreach (Question question in _questions)
            {
                Console.WriteLine($"Question {questionNumber++}: ");
                DisplayQuestion(question);
                int userChoice = GetUserChoice();
                if (question.IsCorrectAnswer(userChoice))
                {
                    Console.WriteLine("Correct");
                    _score++;
                }
                else
                {
                    Console.WriteLine($"Wrong. The correct answer was: {question.Answer[question.CorrectAnswerIndex]}");
                }
            }

            DisplayResults();
        }

        private void DisplayQuestion(Question question)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*****************************");
            Console.WriteLine("\tQuestion");
            Console.WriteLine("*****************************");
            Console.ResetColor();
            Console.WriteLine(question.QuestionText);

            for(int i = 0; i < question.Answer.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("    ");
                Console.Write(i + 1);
                Console.ResetColor();
                Console.WriteLine($". {question.Answer[i]}");
                
            }
        }

        private void DisplayResults()
        {
            // Get percentage of correct answer
            Console.WriteLine("*****************************");
            Console.WriteLine("\tResult");
            Console.WriteLine("*****************************");

            Console.WriteLine($"Your score is: {_score} out of {_questions.Length}");

            double percentage = (double)_score / _questions.Length;

            if (percentage > 0.8)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Excellent work");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Try again");
            }
            Console.ResetColor();
        }

        private int GetUserChoice()
        {
            Console.Write("Your answer (number): ");
            string input = Console.ReadLine();
            int choice = 0;
            while (!int.TryParse(input, out choice)|| choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4");
                input = Console.ReadLine();
            }
            return choice - 1; // adjust to 0-indexing array
        }        
    }
}
