using System;

namespace Writing_some_of_the_strings_internal_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] targetUpperCaseLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] targetLowerCaseLetters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            while (true)
            {
                string[] commands = { "/Convert to uppercase letters", "/Convert to lowercase letters", "/Determine the existence of a letter" };

                Console.WriteLine("/Convert to uppercase letters");
                Console.WriteLine("/Convert to lowercase letters");
                Console.WriteLine("/Determine the existence of a letter");

                Console.WriteLine("Please choose a command from above : ");

                string choosenCommand = Console.ReadLine();
                if (choosenCommand == "/Convert to uppercase letters")
                {
                    Console.WriteLine("Please enter your text with lowercase letters : ");
                    string requiredText = Console.ReadLine();
                    string finalResult = changeToUpper(requiredText, targetUpperCaseLetters, targetLowerCaseLetters);
                    Console.WriteLine($"Your new text is : {finalResult}");
                }

                else if (choosenCommand == "/Convert to lowercase letters")
                {
                    Console.WriteLine("Please enter your text with uppercase letters : ");
                    string targetText = Console.ReadLine();
                    string finalResult = changeToLower(targetText, targetLowerCaseLetters, targetUpperCaseLetters);
                    Console.WriteLine($"Your next new text is : {finalResult}");
                }

                else if (choosenCommand == "/Determine the existence of a letter")
                {
                    Console.WriteLine("If you want to continue with default mode, please choose 'yes', else 'no' : ");

                    string choosenMode = Console.ReadLine();
                    bool isItSensitiveCase = false;

                    if (choosenMode == "yes")
                    {
                        isItSensitiveCase = true;
                    }

                    else if (choosenMode == "no")
                    {
                        isItSensitiveCase = false;

                        Console.WriteLine("Command not found");
                        break;
                    }

                    Console.WriteLine("Please enter your desired text : ");
                    string requiredText = Console.ReadLine();

                    Console.WriteLine("Please enter your letter : ");
                    string insertedLetter = Console.ReadLine();

                    bool finalResult = isLetterExists(requiredText, insertedLetter, isItSensitiveCase);
                    Console.WriteLine(finalResult);
                    Console.WriteLine();
                }

                static string changeToUpper(string requiredText, char[] targetUpperCaseLetters, char[] targetLowerCaseLetters)
                {
                    for (int i = 0; i < targetLowerCaseLetters.Length; i++)
                    {
                        requiredText = requiredText.Replace(targetLowerCaseLetters[i], targetUpperCaseLetters[i]);
                    }

                    return requiredText;
                }

                static string changeToLower(string requiredText, char[] targetLowerCaseLetters, char[] targetUpperCaseLetters)
                {
                    for (int i = 0; i < targetLowerCaseLetters.Length; i++)
                    {
                        requiredText = requiredText.Replace(targetUpperCaseLetters[i], targetLowerCaseLetters[i]);
                    }

                    return requiredText;
                }

                static bool isLetterExists(string requiredText, string insertedLetter, bool isItSensitiveCase)
                {
                    for (int i = 0; i < requiredText.Length; i++)
                    {
                        if (isItSensitiveCase == false)
                        {
                            requiredText = requiredText.ToLower();
                            insertedLetter = insertedLetter.ToLower();

                            if (requiredText[i] == insertedLetter[0])
                            {
                                return true;
                            }
                        }

                        else if (isItSensitiveCase == true)
                        {
                            if (requiredText[i] == insertedLetter[0])
                            {
                                return true;
                            }
                        }
                    }
                    return false;
                }
            }
        }
    }
}
