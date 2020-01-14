/* Lab 1 
 * Written by Patrick Bobyn
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

class Lab1
{
    private List<string> words = new List<string>();

    public static void Main()
    {
        // User input 
        char choice;
        Lab1 lab = new Lab1();
        
        do
        {
            // Print menu
            Console.WriteLine("Hello World!! My First C# App");
            Console.WriteLine("Options\n-----------------------------");
            Console.WriteLine("1 - Import Words From File");
            Console.WriteLine("2 - Bubble Sort words");
            Console.WriteLine("3 - LINQ/Lambda Sort words");
            Console.WriteLine("4 - Count the Distinct Words");
            Console.WriteLine("5 - Take the First 10 Words");
            Console.WriteLine("6 - Get the number of words that start with 'j' and display count");
            Console.WriteLine("7 - Get and display words that end with 'd' and display the count");
            Console.WriteLine("8 - Get and display words that are greater than 4 characters long and display the count");
            Console.WriteLine("9 - Get and display words that are less than 3 characters long and start with the letter 'a' and display the count");
            Console.WriteLine("x - Exit");
            Console.Write("\nMake a Selection: ");

            // Get user input 
            choice = Console.ReadLine().ToLower()[0];
            Console.Clear();

            // Do what user wanted
            switch (choice)
            {
                case '1':                   // Option 1 - Input words from file - DONE
                    lab.ReadFile();
                    Console.WriteLine();
                    break;
                case '2':                   // Option 2 - Bubble Sort words - DONE
                    Console.WriteLine(BubbleSort(lab.words));
                    Console.WriteLine();
                    break;
                case '3':                   // Option 3 - Lambda Sort
                    lab.LambdaSort();
                    Console.WriteLine();
                    break;
                case '4':                   // Option 4 - Count distinct words - DONE
                    lab.Distinct();
                    Console.WriteLine();
                    break;
                case '5':                   // Option 5 - First 10 words - DONE
                    lab.Display();
                    Console.WriteLine();
                    break;
                case '6':                   // Option 6 - start with 'j' - DONE
                    lab.StartJ();
                    Console.WriteLine();
                    break;
                case '7':                   // Option 7 - end with 'd' - DONE
                    lab.EndD();
                    Console.WriteLine();
                    break;
                case '8':                   // Option 8 - greater than 4 characters long - DONE
                    lab.GreaterThan4();
                    Console.WriteLine();
                    break;
                case '9':                   // Option 9 - Less than 3 characters long and starts with 'a' - DONE
                    lab.LessThan3();
                    Console.WriteLine();
                    break;
                case 'x':                   // Option x - quit
                    break;
                default:                    // Default Option
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Option!");
                    Console.WriteLine();
                    Console.ResetColor();
                    break;
            }
        } while (choice != 'x');
    } 

    public void ReadFile()
    {
        words.Clear();
        try             // Read the text file
        {

            using (StreamReader reader = new StreamReader("Words.txt"))
            {
                Console.WriteLine("Reading Words");

                string text;
                while ((text = reader.ReadLine()) != null)    // Read each line of the file 
                {
                    words.Add(text);
                }
            }

            Console.WriteLine("Reading Words complete\nNumber of words found: {0}", words.Count);

        } catch (Exception)     // Error reading the file
        {
            Console.WriteLine("Error reading file!");

        }
    }

    public static string BubbleSort(List<string> words)
    { 
        string temp;
        string time;
        Stopwatch stopwatch = Stopwatch.StartNew();

        for (int j = 0; j <= words.Count - 2; j++)
        {
            for (int i = 0; i <= words.Count - 2; i++)
            {
                if (words[i].CompareTo(words[i + 1]) > 0)
                {
                    temp = words[i + 1];
                    words[i + 1] = words[i];
                    words[i] = temp;
                }
            }
        }

        stopwatch.Stop();
        time = "Time elapse: " + stopwatch.ElapsedMilliseconds + "ms";

        return time;
    }

    public void LambdaSort()
    {
        Stopwatch stopwatch = Stopwatch.StartNew();

        words.Sort();

        stopwatch.Stop();
        Console.WriteLine("Time elapse: {0}ms", stopwatch.ElapsedMilliseconds);
    }

    public void Distinct()
    {
        // display the distinct words
        IEnumerable<string> query = words.Distinct();

        Console.WriteLine("The number of distinct words: {0}", query.Count());
    }

    public void Display()
    {
        // display the first 10 words
        if (words.Count == 0)
            return;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(words[i]);
        }
    }

    public void StartJ()
    {
        // get and display words that start with j
        IEnumerable<string> query = from word in words
                                    where word.StartsWith('j')
                                    select word;

        foreach (var word in query)
            Console.WriteLine(word);

        Console.WriteLine("Number of words that start with 'j': {0}", query.Count());
    }

    public void EndD()
    {
        // get and display words that end with d
        IEnumerable<string> query = from word in words
                                    where word.EndsWith('d')
                                    select word;

        foreach (var word in query)
            Console.WriteLine(word);

        Console.WriteLine("Number of words that end with 'd': {0}", query.Count());
    }

    public void GreaterThan4()
    {
        // Display words with more than 4 characters
        IEnumerable<string> query = from word in words
                    where word.Length > 4
                    select word;

        foreach (var word in query)
        {
            Console.WriteLine(word);
        }
        Console.WriteLine("Number of words longer than 4 characters: {0}", query.Count());
    }

    public void LessThan3()
    {
        // Display words with less than 3 characters and that start with 'a'

        IEnumerable<string> query = from word in words
                                    where word.Length < 3 && word.StartsWith('a')
                                    select word;

        foreach (var word in query)
        {
            Console.WriteLine(word);
        }

        Console.WriteLine("Number of words longer less than 3 characters and start with 'a': {0}", query.Count());
    }
}
