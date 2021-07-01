using System;
using System.Collections.Generic;

namespace BalancedBracketsNS
{
    public class BalancedBrackets
    {
        /**
         * The function BalancedBrackets should return true if and only if
         * the input string has a set of "balanced" brackets.
         *
         * That is, whether it consists entirely of pairs of opening/closing
         * brackets (in that order), none of which mis-nest. We consider a bracket
         * to be square-brackets: [ or ].
         *
         * The string may contain non-bracket characters as well.
         *
         * These strings have balanced brackets:
         *  "[LaunchCode]", "Launch[Code]", "[]LaunchCode", "", "[]"
         *
         * While these do not:
         *   "[LaunchCode", "Launch]Code[", "[", "]["
         *
         * parameter str - to be validated
         * returns true if balanced, false otherwise
        */
        public static bool HasBalancedBrackets(String str)
        {
            List<char> bracketsList = new List<char>();
            int brackets = 0;
            int openBracket = 0;
            int closedBracket = 0;
            
            foreach (char ch in str.ToCharArray())
            {
                
                if (ch == '[')
                {
                    brackets++;
                    openBracket++;
                    bracketsList.Add(ch);
                }
                else if (ch == ']')
                {
                    brackets--;
                    closedBracket++;
                    bracketsList.Add(ch);
                }
                
            }

            if (bracketsList.Count == 0)
                return true;
            else return brackets == 0 && openBracket == closedBracket && bracketsList[0] != ']' && bracketsList[^1] != '[';
        }
    }
}
