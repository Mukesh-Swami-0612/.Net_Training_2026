using System.Collections.Generic;

public class ParenthesesChecker
{
    // Summary: Checks whether brackets in an expression are correctly balanced.
    public static bool IsBalanced(string expression)
    {
        // Create a stack to store opening brackets.
        Stack<char> stack = new Stack<char>();

        // Check every character in the expression.
        foreach (char character in expression)
        {
            // Add opening brackets to the stack.
            if (character == '(' ||
                character == '{' ||
                character == '[')
            {
                stack.Push(character);
            }

            // Process closing brackets.
            else if (character == ')' ||
                     character == '}' ||
                     character == ']')
            {
                // If there is no opening bracket, it is unbalanced.
                if (stack.Count == 0)
                {
                    return false;
                }

                // Get the most recently opened bracket.
                char openingBracket = stack.Pop();

                // Check whether the opening and closing brackets match.
                if (!IsMatchingPair(openingBracket, character))
                {
                    return false;
                }
            }
        }

        // The expression is balanced only when no brackets remain.
        return stack.Count == 0;
    }


    // Summary: Checks whether an opening bracket matches a closing bracket.
    private static bool IsMatchingPair(char opening, char closing)
    {
        // Check parentheses.
        if (opening == '(' && closing == ')')
        {
            return true;
        }

        // Check curly brackets.
        if (opening == '{' && closing == '}')
        {
            return true;
        }

        // Check square brackets.
        if (opening == '[' && closing == ']')
        {
            return true;
        }

        // Return false when the brackets do not match.
        return false;
    }
}