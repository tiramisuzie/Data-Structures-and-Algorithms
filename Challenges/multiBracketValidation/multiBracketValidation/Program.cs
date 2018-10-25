using multiBracketValidation.Classes;
using System;

namespace multiBracketValidation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MultiBracketValidation("([])"));
        }

        public static bool MultiBracketValidation(string input)
        {
            Stack stack = new Stack();
            char[] characters = input.ToCharArray();
            for(int i = 0; i < characters.Length; i++)
            {
                if (ValidateOpenBracket(characters[i]))
                {
                    stack.Push(new Node(characters[i]));
                }
                else if (ValidateCloseBracket(characters[i]))
                {
                    try
                    {
                        var openBracket = stack.Pop();
                    
                        if (!(ValidateCompleteSquareBracket((char)openBracket.Value, characters[i]) ||
                            ValidateCompleteCurlyBracket((char)openBracket.Value, characters[i]) ||
                            ValidateCompleteRoundBracket((char)openBracket.Value, characters[i])))
                        {
                            return false;
                        }
                    } catch (InvalidOperationException)
                    {
                        return false;
                    }
                }
            }
            return stack.size == 0;
        }

        public static bool ValidateOpenBracket(char c)
        {
            return c == '[' || c == '{' || c == '(';
        }

        public static bool ValidateCloseBracket(char c)
        {
            return c == ')' || c == ']' || c == '}';
        }

        static bool ValidateCompleteSquareBracket(char openBracket, char closeBracket)
        {
            return openBracket == '[' && closeBracket == ']';
        }

        static bool ValidateCompleteRoundBracket(char openBracket, char closeBracket)
        {
            return openBracket == '(' && closeBracket == ')';
        }

        static bool ValidateCompleteCurlyBracket(char openBracket, char closeBracket)
        {
            return openBracket == '{' && closeBracket == '}';
        }
    }
}
