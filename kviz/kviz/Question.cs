using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kviz
{
    class Question
    {
        public string Text { get; private set; }
        public List<string> Answers { get; private set; }
        public int CorrectIndex { get; private set; }
        public int PointValue { get; private set; }
        public int ID {get; private set;}

        private static QuestionBank _questionBank;

        public string Display(int n)
        {
            List<char> ABCD = new List<char> {'a', 'b', 'c', 'd'};
            int NumberOfAnswers = Answers.Count();
            string WholeText = "Pitanje broj :" + n + "\n" + Text + "\n";
            for (int i = 0; i < NumberOfAnswers; i++)
            {
                WholeText += ABCD[i];
                WholeText += Answers[i];
                WholeText += "\n";
            }
            return WholeText;
        
         public override string ToString()
    {
        string answersString = string.Join(",", Answers);
        return $"{Text}|{answersString}|{CorrectIndex}|{PointValue}";

        public Question {string Text<string> Answers, int CorrectIndex, int PointValue, int ID}
    }
        var random = new Random();
        int newId;
      while (questionBank.QuestionExists(newId));  
        {
            newId = random.Next(1, int.MaxValue);
        }
        ID = newId;
        Text = text;
        Answers = answers;
        CorrectAnswer = correctAnswer;
         PointValue=pointvalue;
    }

    public Question(string questionString)
    {
        var parts = questionString.Split(',');
        if (parts.Length > 1)
        {
            ID = int.Parse(parts[0]);
            Text = parts[1];
            Answers = new List<string>(); 
            CorrectAnswer = "";
        }
    }
        

        }





    }
