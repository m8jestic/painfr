using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace painfr
{
    public class QuestionText : Question
    {
        public override string text { get; set; }    
        public override List<Answer> answers { get; set; }
        public QuestionText(string text, string answerText, bool isCorrect)
        {
            this.answers = new List<Answer>();
            this.text = text;
            Answer answer = new Answer(answerText, isCorrect);
            answers.Add(answer);
        }
    }
}
