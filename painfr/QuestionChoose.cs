using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace painfr
{
    public class QuestionChoose : Question
    {
        public override string text { get; set; }
        public override List<Answer> answers { get; set; }
        public QuestionChoose(string text, string AnswerText, string AnswerText1, string AnswerText2, string AnswerText3, bool isCorrect,bool isCorrect1, bool isCorrect2, bool isCorrect3) 
        {
            this.answers = new List<Answer>();
            this.text = text;
            Answer answer = new Answer(AnswerText,isCorrect);
            Answer answer2 = new Answer(AnswerText1, isCorrect1);
            Answer answer3 = new Answer(AnswerText2, isCorrect2);
            Answer answer4 = new Answer(AnswerText3, isCorrect3);
            answers.Add(answer);
            answers.Add(answer2);
            answers.Add(answer3);
            answers.Add(answer4);
        }
    }
}
