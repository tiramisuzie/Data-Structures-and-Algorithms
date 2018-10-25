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
            // create a stack for open brackets
            Stack stack = new Stack();
            // split them up to characters
            char[] characters = input.ToCharArray();
            for(int i = 0; i < characters.Length; i++)
            {
                // if character is an open bracket and push to stack
                if (ValidateOpenBracket(characters[i]))
                {
                    stack.Push(new Node(characters[i]));
                }
                else if (ValidateCloseBracket(characters[i]))
                {
                    // if character is an close bracket than pop the stack and compare if they are a complete bracket
                    // return false if not complete bracket
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
                    { // stack.Pop throw an exception when stack is empty
                        return false;
                    }
                }
            }
            return stack.size == 0; // when stack is empty means there isnt any incomplete brackets
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
