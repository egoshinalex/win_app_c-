﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Genius_stuped
{
   
    class Program
    {

        private static int getRandomNumber(List<int> numbers)
        {
            Random rnd = new Random();
            return  rnd.Next(numbers.Count);

        }
          private static int getCounter(int currentAnswer, int numberOfQuestion, int[] rigthAnswers, int counter)
        {
          
             if (currentAnswer == rigthAnswers[numberOfQuestion]){
                  counter++;
              }
           return counter;
        }
              static void Main(string[] args)
        {
           string[] questions = new string[5];
            questions[0] = "Сколько будет два плюс два  умноженное на два?";
            questions[1] = "Бревно нужно распилить на 10  частей, сколько надо сделать  распилов?";
            questions[2] = "На двух руках 10 пальцев. Сколько пальцев на 5 руках?";
            questions[3] = "Укол делают каждые полчаса,  сколько нужно минут для трех  уколов?";
            questions[4] = "Пять свечей горело, две  потухли. Сколько свечей  осталось?";

            int[] rigthAnswers = new int[5];
            rigthAnswers[0] = 6;
            rigthAnswers[1] = 9;
            rigthAnswers[2] = 25;
            rigthAnswers[3] = 60;
            rigthAnswers[4] = 2;

            string[] grade = new string[6];
            grade[0] = "Идиот";
            grade[1] = "Кретин";
            grade[2] = "Дурак";
            grade[3] = "Нормальный";
            grade[4] = "Талант";
            grade[5] = "Гений";

            int counter = 0;
            var  numbers = Enumerable.Range(0, 5).ToList();

            for (int i = 0; i < 5; i++)
            {
                int number = getRandomNumber(numbers);
                int numberOfQuestion = numbers[number];
                numbers.RemoveAt(number);
                Console.WriteLine(numberOfQuestion + 1 + "." + " " + questions[numberOfQuestion]);               
                int currentAnswer =  Convert.ToInt32(Console.ReadLine());
                counter = getCounter(currentAnswer, numberOfQuestion, rigthAnswers, counter);
            }
            Console.WriteLine(grade[counter]);            
        }

      
    }      
}

