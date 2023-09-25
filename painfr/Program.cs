using System;

namespace painfr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите логин и пароль");
            string username = Console.ReadLine();
            string password = Console.ReadLine();   
            User user = new User(username, password, true);
            Console.WriteLine(user.username);
            Test test = new Test(user);
            Console.WriteLine("Выберите количество вопросов, которое вы хотите создать");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("1 - Создать вопрос с одним вариантом ответа");
            Console.WriteLine("2 - Создать вопрос с четырьмя вариантами ответа");
            
            for(int i = 0; i < num;i++)
            {
                int variant = Int32.Parse(Console.ReadLine());
                test.CreateTest(variant);
               
            }
            Console.WriteLine($"Выберите вопрос, всего доступно {test.question.Count} вопросов");
            int cho = Int32.Parse(Console.ReadLine());
            test.ChooseQuestionPack(cho);
            user.ShowResults();

        }
    }
}