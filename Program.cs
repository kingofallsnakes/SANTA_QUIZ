using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n\n\tWelcome to the Santa Quiz!\n\n");
        Console.WriteLine("\t1. Login");
        Console.WriteLine("\t2. Signup");
        Console.WriteLine("\nEnter your choice (1/2): ");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Login();
        }
        else if (choice == "2")
        {
            Signup();
        }
        else
        {
            Console.WriteLine("Invalid choice. Please restart the program.");
        }
    }

    static void Login()
    {
        Console.WriteLine("\nLogin Page");
        Console.Write("Enter Username: ");
        string username = Console.ReadLine();

        Console.Write("Enter Password: ");
        string password = Console.ReadLine();

        if (ValidateUser(username, password))
        {
            Console.WriteLine("\nLogin Successful!");
            QuizPanel(username);
        }
        else
        {
            Console.WriteLine("Invalid login credentials. Please restart the program.");
        }
    }

    static void Signup()
    {
        Console.WriteLine("\nSignup Page");
        Console.Write("Enter Username: ");
        string username = Console.ReadLine();

        Console.Write("Enter Password: ");
        string password = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password))
        {
            SaveUser(username, password);
            Console.WriteLine("Signup Successful! Please log in to continue.");
        }
        else
        {
            Console.WriteLine("Invalid signup details. Please restart the program.");
        }
    }

    static bool ValidateUser(string username, string password)
    {
        string[] lines = File.ReadAllLines("user_data.txt");
        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            if (parts[0] == username && parts[1] == password)
            {
                return true;
            }
        }
        return false;
    }

    static void SaveUser(string username, string password)
    {
        File.AppendAllText("user_data.txt", $"{username},{password}{Environment.NewLine}");
    }

    static void QuizPanel(string username)
    {
        Console.WriteLine($"\nWelcome to Santa Quiz Panel, {username}!\n");
        Console.Write("Enter the number of questions you want to attempt: ");
        int numQuestions;
        while (!int.TryParse(Console.ReadLine(), out numQuestions) || numQuestions <= 0)
        {
            Console.Write("Invalid input. Please enter a positive number: ");
        }

        StartQuiz(username, numQuestions);
    }

    static void StartQuiz(string username, int numQuestions)
    {
        var questionsData = Questions.GetQuestions();
        var random = new Random();
        int score = 0;

        for (int i = 0; i < numQuestions; i++)
        {
            int index = random.Next(questionsData.Count);
            var question = questionsData[index];

            Console.WriteLine($"\nQuestion {i + 1}: {question.QuestionText}");
            for (int j = 0; j < question.Options.Length; j++)
            {
                Console.WriteLine($"{(char)('A' + j)}. {question.Options[j]}");
            }

            Console.Write("Your Answer (A/B/C/D): ");
            string userAnswer = Console.ReadLine()?.ToLower();

            while (string.IsNullOrWhiteSpace(userAnswer) || !"abcd".Contains(userAnswer))
            {
                Console.Write("Invalid input. Please enter A, B, C, or D: ");
                userAnswer = Console.ReadLine()?.ToLower();
            }

            if (userAnswer == question.CorrectAnswer.ToLower())
            {
                Console.WriteLine("\t\t\tCorrect!\n");
                score++;
            }
            else
            {
                Console.WriteLine($"\n\n\tWrong! The correct answer is: {question.CorrectAnswer.ToUpper()}\n");
            }

            questionsData.RemoveAt(index); 
        }

        double percentage = (double)score / numQuestions * 100;

        Console.WriteLine($"\n{username}, your score is: {score}/{numQuestions} ({percentage:F2}%)");

        if (percentage == 100)
        {
            Console.WriteLine("\nExcellent! You are a quiz master!\n");
        }
        else if (percentage >= 75)
        {
            Console.WriteLine("\nGreat job! You did really well.\n");
        }
        else if (percentage >= 50)
        {
            Console.WriteLine("\nGood effort! Keep practicing.\n");
        }
        else
        {
            Console.WriteLine("\nBetter luck next time! Keep learning.\n");
        }

         if (score == 0)
        {
            Console.WriteLine("\n\nSanta Claus can't provide any gifts for this Christmas.");
        }
        else
        {
            Console.WriteLine($"{username} Santa Claus gives {score} gift(s) for Christmas!");
        }
    }
}
