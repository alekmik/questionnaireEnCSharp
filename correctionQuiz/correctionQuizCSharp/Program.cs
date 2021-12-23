﻿using System;
using System.Collections.Generic;


namespace quiz
{

    public class Questions
    {
        public string Ask { get; set; }
        public string Answer { get; set; }
        public string UserAnswer { get; set; }
        public List<string> UserAnswers { get; set; }

        public bool isMultiple { get; set; }


        public Questions(string question, string answered, bool mulipleChoice = false)
        {
            this.Ask = question;
            this.Answer = answered;
            this.isMultiple = mulipleChoice;
            if (mulipleChoice)
                this.UserAnswers = new List<string>();

        }
    }

    public class Quiz
    {
        public void init()
        {
            List<Questions> Questionlist = new List<Questions>()
            {
                new Questions("Quelle est la capitale de la france ?","paris"),
                new Questions("Quelle est la capitale de l'italie?","rome"),
                new Questions("Quelles villes sont situées en france? paris, madrid, tokyo, sydney, toulouse","paris,toulouse",true),
                new Questions("Quelles villes sont situées en hollande? paris, amsterdam, la haye, sydney, toulouse","paris,toulouse",true),
            };

            Start(Questionlist);
        }

        public void Start(List<Questions> questions)
        {
            Console.Clear();

            Console.WriteLine("Voulez vous lancer le questionnaire ?[oui][non]");
            string? choose = Console.ReadLine();

            choose = choose.ToLower().Trim();

            switch (choose)
            {
                case "oui":
                    Console.Clear();
                    Console.WriteLine("Vous allez commencer le Quiz");
                    StartQuiz(questions);
                    break;
                case "non":

                    Console.Clear();
                    Console.WriteLine("Vous avez decider de ne pas commencer le quiz");

                    break;
                default:

                    Console.Clear();
                    Console.WriteLine("Désolé je n'ai pas compris votre réponse, veuillez répondre correctement.");
                    init();
                    break;

            }


        }

        public void StartQuiz(List<Questions> questions)
        {
            foreach (Questions question in questions)
            {
                if (question.isMultiple)
                {
                    DisplayMultipleQuestion(question);
                    Console.Clear();
                    continue;

                }

                Console.WriteLine(question.Ask);
                question.UserAnswer = Console.ReadLine().ToLower().Trim();

                Console.Clear();
            }

            int score = quizResult(questions);
            Console.WriteLine($"Le resultat de votre quiz et de {score} sur {questions.Count()}");

        }

        public int quizResult(List<Questions> questions)
        {
            int result = 0;

            foreach (Questions question in questions)
            {
                if (question.isMultiple)
                {
                    if (question.Answer.Contains(question.UserAnswers[0]) && question.Answer.Contains(question.UserAnswers[1]))
                    {
                        result++;
                        DisplayGoodAnswer(question);
                        continue;
                    }

                }

                if (question.Answer == question.UserAnswer)
                {
                    DisplayGoodAnswer(question);
                    result++;
                    continue;
                }

                DisplayWrongAnswer(question);

            }

            return result;
        }

        public void DisplayWrongAnswer(Questions question)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Pour la question " + question.Ask + ", vous avez répondu ");

            if (question.isMultiple)
            {
                Console.Write(question.UserAnswers[0] + " et " + question.UserAnswers[1]);
                Console.Write(" tandis que les réponses était " + question.Answer + "\n");
            }
            else
            {
                Console.Write(question.UserAnswer);
                Console.Write(" tandis que la réponse était " + question.Answer + "\n");
            }

            Console.ResetColor();
        }

        public void DisplayGoodAnswer(Questions question)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Pour la question " + question.Ask + ", vous avez donné une bonne réponse ");
            Console.ResetColor();
        }

        public void DisplayMultipleQuestion(Questions question)
        {
            Console.WriteLine(question.Ask);

            for (int i = 1; i < 3; i++)
            {
                string answer = CheickAnswer(i);
                question.UserAnswers.Add(answer);
            }

        }

        public string CheickAnswer(int numQuestion)
        {
            string answer;

            do
            {
                Console.WriteLine("reponse " + numQuestion + " sur 2");
                answer = Console.ReadLine();

            } while (string.IsNullOrEmpty(answer));

            return answer;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Quiz q = new Quiz();
            q.init();
        }
    }
}
