// See https://aka.ms/new-console-template for more information
using Core.Generation;
using System;


Console.WriteLine("NAME GENERATOR v0.5");
Console.WriteLine("=========================");

Console.WriteLine(">> Do you wish to run the generator? y/n");
string answer;
answer = Console.ReadLine();

Repeat:
if (answer is "y" or "Y")
{
    Repeat1:
    Console.WriteLine(">> Which Algo? 1/2/3/4");
    string answer1;
    answer1 = Console.ReadLine();

    if (answer1 == "1")
    {
        // A - EQUAL RANDOM LETTERS
        // - - - - - - - - - - - - - - - - 

        // build the letter list
        Dictionary<int, string> LetterList = NameGenerator.BuildLetterList();

        Console.WriteLine(">> How many names?");
        string answer2;
        answer2 = Console.ReadLine();

        Console.WriteLine(">> How many words per name?");
        string answer3;
        answer3 = Console.ReadLine();

        Console.WriteLine(">> How many letters per word?");
        string answer4;
        answer4 = Console.ReadLine();

        // pass in values
        List<string> WordList = NameGenerator.WordAlgo1(int.Parse(answer2), int.Parse(answer3), int.Parse(answer4), LetterList);

        int i = 1;

        Console.WriteLine("");

        foreach (string s in WordList)
        {
            Console.WriteLine(i + ": " + s);
            i++;
        }
    }
    else if (answer1 == "2")
    {

        // B - LETTER FREQUENCIES 1
        // - - - - - - - - - - - - - - - - 

        // build the probabilistic letter list
        Dictionary<int, string> LetterList2 = NameGenerator.BuildLetterList2();

        Console.WriteLine(">> How many names?");
        string answer2;
        answer2 = Console.ReadLine();

        Console.WriteLine(">> How many words per name?");
        string answer3;
        answer3 = Console.ReadLine();

        Console.WriteLine(">> How many syllables per word?");
        string answer4;
        answer4 = Console.ReadLine();

        Console.WriteLine(">> How many letters per syllable?");
        string answer5;
        answer5 = Console.ReadLine();

        // function call
        List<string> WordList = NameGenerator.WordAlgo2(int.Parse(answer2), int.Parse(answer3), int.Parse(answer4), int.Parse(answer5), LetterList2);

        // print the list
        int i = 1;
        Console.WriteLine("");

        foreach (string s in WordList)
        {
            Console.WriteLine(i + ": " + s);
            i++;
        }

    }
    else if (answer1 == "3")
    {
        // C - LETTER FREQUENCIES 2
        // - - - - - - - - - - - - - - - - 

        // build the probabilistic letter list
        Dictionary<int, string> LetterList3 = NameGenerator.BuildLetterList2();

        Console.WriteLine(">> How many names?");
        string answer2;
        answer2 = Console.ReadLine();

        Console.WriteLine(">> How many words per name?");
        string answer3;
        answer3 = Console.ReadLine();

        Console.WriteLine(">> How many syllables per word, max?");
        string answer4;
        answer4 = Console.ReadLine();

        Console.WriteLine(">> How many letters per syllable, max?");
        string answer5;
        answer5 = Console.ReadLine();

        // function call
        List<string> WordList = NameGenerator.WordAlgo3(int.Parse(answer2), int.Parse(answer3), int.Parse(answer4), int.Parse(answer5), LetterList3);

        // print the list
        int i = 1;
        Console.WriteLine("");

        foreach (string s in WordList)
        {
            Console.WriteLine(i + ": " + s);
            i++;
        }
    }
    else if (answer1 == "4")
    {
        // D - LETTER FREQUENCIES + SYNACTIC RULES
        // - - - - - - - - - - - - - - - - 
        
        // build the consontant and vowels lists
        Dictionary<int, string> ConsonantList = NameGenerator.BuildConsonantsList();
        Dictionary<int, string> VowelList = NameGenerator.BuildVowelsList();

        Console.WriteLine(">> How many names?");
        string answer2;
        answer2 = Console.ReadLine();

        Console.WriteLine(">> How many words per name?");
        string answer3;
        answer3 = Console.ReadLine();

        Console.WriteLine(">> How many syllables per word, max?");
        string answer4;
        answer4 = Console.ReadLine();

        Console.WriteLine(">> How many letters per syllable, max?");
        string answer5;
        answer5 = Console.ReadLine();

        // function call
        List<string> WordList = NameGenerator.WordAlgo4(int.Parse(answer2), int.Parse(answer3), int.Parse(answer4), int.Parse(answer5), ConsonantList, VowelList);

        // print the list
        int i = 1;
        Console.WriteLine("");

        foreach (string s in WordList)
        {
            Console.WriteLine(i + ": " + s);
            i++;
        }
    }
    else
    {
        goto Repeat1;
    }

}
else if (answer is "n" or "N")
{
    Console.WriteLine("GOODBYE");
}
else
{
    Console.WriteLine("Do you wish to run the generator? y/n");
    answer = Console.ReadLine();

    goto Repeat;
}


