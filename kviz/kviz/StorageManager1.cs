using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kviz
{
    internal class StorageManager
    {
        private string filePath;

        public QuestionManager(string filePath)
        {
            this.filePath = "###$$$$";
        }
        public List<string> LoadQuestions()
        {
            List<Question> questions = new List<Question>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                if (parts.Length == 7)
                {
                    Question question = new Question(
                                id: int.Parse(parts[0].Trim()),
                                text: parts[1].Trim(),
                                answers: new List<string>
                                {
                                    parts[2].Trim(),
                                    parts[3].Trim(),
                                    parts[4].Trim(),
                                    parts[5].Trim()
                                },
                                correctIndex: int.Parse(parts[6].Trim()),
                                pointValue: int.Parse(parts[7].Trim())
                            );

                    questions.Add(question);
                }
            }


            return questions;

        }
        public void SaveQuestions(List<Question> questions)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (Question question in questions)
                {
                    string line = $"{question.ID}," +
                                  $"{question.Text}," +
                                  $"{string.Join(",", question.Answers)}," +
                                  $"{question.CorrectIndex}," +
                                  $"{question.PointValue}";
                    writer.WriteLine(line);
                }
            }


        }
    }
}
