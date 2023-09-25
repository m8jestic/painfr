using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace painfr
{
    public class Test : AbstractionTest
    {
        public User user;
        public List<Question> question;
        public Test(User user) {

            this.question = new List<Question>();
            this.user = user;
            
        }
        public override void ChooseQuestionPack(int n) {
            uint res = 0;
            Console.WriteLine(question[n].text);
            var q = question[n];

            if (question[n].answers.Count > 1)
            {
                for (int i = 0; i < question[n].answers.Count; i++)
                {
                    Console.WriteLine($"{i+1}. {question[n].answers[i].text}");
                }
            }
            
            string ans = Console.ReadLine();
            for (int i = 0; i < q.answers.Count; i++)
            {
                if (ans == q.answers[i].text & q.answers[i].isCorrect == true)
                {
                    res += 1;
                }
                else
                {
                    res += 0;
                }
            }
            Console.WriteLine($"Вы получили {res} баллов");
            user.record += res;
            
        }
        public override void CreateTest(int f)
        {
            if (user.isAdmin == true)
            {
                if (f == 1)
                {
                    Console.WriteLine("Введите текст вопроса и один ответ");
                    string qtext = Console.ReadLine();
                    string qans = Console.ReadLine();
                    QuestionText q = new QuestionText(qtext, qans, true);
                    question.Add(q);

                }
                if (f == 2)
                {
                    Console.WriteLine("Введите текст вопроса и четыре ответа, так же укажите какой из них правильный");
                    string qtext = Console.ReadLine();
                    Console.WriteLine("Ответ");
                    string qans = Console.ReadLine();
                    Console.WriteLine("Правильность");
                    bool isT = bool.Parse(Console.ReadLine());
                    Console.WriteLine("Ответ");
                    string qans1 = Console.ReadLine();
                    Console.WriteLine("Правильность");
                    bool isT1 = bool.Parse(Console.ReadLine());
                    Console.WriteLine("Ответ");
                    string qans2 = Console.ReadLine();
                    Console.WriteLine("Правильность");
                    bool isT2 = bool.Parse(Console.ReadLine());
                    Console.WriteLine("Ответ");
                    string qans3 = Console.ReadLine();
                    Console.WriteLine("Правильность");
                    bool isT3 = bool.Parse(Console.ReadLine());
                    QuestionChoose q = new QuestionChoose(qtext, qans, qans1, qans2, qans3, isT,isT1, isT2,isT3);
                    question.Add(q);

                }
            }
        }


    }
}
