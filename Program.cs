//egoshin_lesson_1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Genius_stuped
{
    public class QuestionAnswer
    {
       public string Question;
        public int Answer;

        public QuestionAnswer(string question, int answer)
        {
            Question = question;
            Answer = answer;
        }
    }
    public class ClassDiagnosis
    {
        public string Diagnosis;
        public ClassDiagnosis(string diagnosis)
        {
            Diagnosis = diagnosis;           
        }
    }

    public class Test
    {
        public string Name;
        public List<QuestionAnswer> QuestionsAnswers;
        public List<ClassDiagnosis> Diagnoses;

        public Test()
        {
            QuestionsAnswers = new List<QuestionAnswer>
            {
                new QuestionAnswer("Сколько будет два плюс два  умноженное на два?", 6),
                new QuestionAnswer("Бревно нужно распилить на 10  частей, сколько надо сделать  распилов?", 9),
                new QuestionAnswer("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25),
                new QuestionAnswer("Укол делают каждые полчаса,  сколько нужно минут для трех  уколов?", 60),
                new QuestionAnswer("Пять свечей горело, две  потухли. Сколько свечей  осталось?", 2)
            };

            Diagnoses = new List<ClassDiagnosis>
            {
                new ClassDiagnosis("Идиот!"),
                new ClassDiagnosis("Кретин!"),
                new ClassDiagnosis("Дурак!"),
                new ClassDiagnosis("Нормальный!"),
                new ClassDiagnosis("Талант!"),
                new ClassDiagnosis("Гений!"),
            };

        }
    }
    public class User
    {
        public string FirstName;
        public string LastName;
        public string MiddleName;

        public User(string firstname, string lastname, string middlename)
        {
            FirstName = firstname;
            LastName = lastname;
            MiddleName = middlename;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Test test_1 = new Test();
            int counter = 0; 
            var numbers = test_1.QuestionsAnswers;
            int forCount = numbers.Count;

            Console.WriteLine("Введите пожалуйста свое имя, фамилию, отчество, чтобы мы знали как к вам обращаться.");  
            string firstname = Console.ReadLine();
            string lastname = Console.ReadLine();
            string middlename = Console.ReadLine();
            User user1 = new User(firstname, lastname, middlename);
    
            for (int i = 0; i < forCount; i++)
            {
                QuestionAnswer CurrentQuestion = GetQuestion(numbers);
                Console.WriteLine(i + 1 + "." + " " + CurrentQuestion.Question);  
                int currentAnswer = GetUserAnswer(user1.FirstName);             
                if (currentAnswer == CurrentQuestion.Answer)
                  {
                        counter++;
                  }
            }
            var diagnoses = test_1.Diagnoses;
            int v = counter / forCount * 100;
            double counterOfDiagnosis = v;
            string CurrentDiagnosis = "Empty";
            if(counterOfDiagnosis == 0){CurrentDiagnosis = diagnoses[0].Diagnosis;}else
            if(counterOfDiagnosis > 0 && counterOfDiagnosis <= 20 ){CurrentDiagnosis = diagnoses[1].Diagnosis;}else
            if(counterOfDiagnosis > 20 && counterOfDiagnosis <= 40){CurrentDiagnosis = diagnoses[2].Diagnosis;}else
            if(counterOfDiagnosis > 40 && counterOfDiagnosis <= 60){CurrentDiagnosis = diagnoses[4].Diagnosis;}else
            if(counterOfDiagnosis > 60 && counterOfDiagnosis <= 80){CurrentDiagnosis = diagnoses[5].Diagnosis;}else
            if(counterOfDiagnosis > 80 && counterOfDiagnosis <= 100){CurrentDiagnosis = diagnoses[6].Diagnosis;}
            CurrentDiagnosis = diagnoses[counter].Diagnosis;
            Console.WriteLine($"Уважаемый {user1.FirstName}  {user1.LastName}  {user1.MiddleName}, поздравляем, вы {CurrentDiagnosis}.");            
        }

        public static int GetUserAnswer(string firstName)
        {
            int checkedNumber = 0;
          
            bool result = false;
            result = int.TryParse(Console.ReadLine(), out checkedNumber);
            while(!result) 
            {
                Console.WriteLine($"Уважаемый {firstName}, вы ввели некорректный параметр. Введите число.");
                result = int.TryParse(Console.ReadLine(), out checkedNumber);
            }
            return checkedNumber;
        }
        public static QuestionAnswer GetQuestion(List<QuestionAnswer> numbers)
        {
             Random rnd = new Random();
             int number = rnd.Next(numbers.Count);
             QuestionAnswer result = numbers[number];
             numbers.RemoveAt(number);
             return result;
        } 
    }     
}


