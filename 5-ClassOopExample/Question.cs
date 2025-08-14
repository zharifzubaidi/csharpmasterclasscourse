using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOopExample
{
    internal class Question
    {
        // Property
        public string? QuestionText { get; set; }
        public string[]? Answer { get; set; }
        public int CorrectAnswerIndex { get; set; }

        // Custom constructor
        public Question(string questionText, string[] answers, int correctAnswerIndex)
        {
            QuestionText = questionText;
            Answer = answers;
            CorrectAnswerIndex = correctAnswerIndex;
        }

        // Methods
        public bool IsCorrectAnswer(int choice)
        {
            return CorrectAnswerIndex == choice;
        }
    }
}
