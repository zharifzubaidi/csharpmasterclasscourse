using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOopExample
{
    internal class Quiz
    {
        private Question[] questions;
        private int score;

        public Quiz(Question[] questions)
        {
            // "this" keyword in C# refers to the current instance of the class it is used in.
            // it is used to access members (like properties and methods) of the same object
            // left "questions" is referring to the class quiz private field not the
            // parameter "questions" above
            this.questions = questions;
        }

        public void StartQuiz()
        {

        }

        public void DisplayQuestion(Question question)
        {
            Console.Write(question.QuestionText);
        }

        private void DisplayResults()
        {

        }

        private void GetUserChoice()
        {

        }        
    }
}
