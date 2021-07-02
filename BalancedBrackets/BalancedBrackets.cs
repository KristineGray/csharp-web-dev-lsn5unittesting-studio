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
            int listLength = bracketsList.Count;
            char[] firstAndLast = new char[2] { '[', ']' };
            if (listLength >= 2)
            {
                firstAndLast.SetValue(bracketsList[0], 0);
                firstAndLast.SetValue(bracketsList[listLength - 1], 1);
            }
            List<bool> pairChecks = new List<bool>();
            if (openBracket == closedBracket && openBracket > 2)
            {
                for (int i = 0; i < closedBracket; i++)
                {
                    int closeIndex = bracketsList.IndexOf(']');
                    int openIndex = bracketsList.LastIndexOf('[', closeIndex);
                    if (closeIndex == -1 || openIndex == -1)
                    {
                        pairChecks.Add(false);
                    }
                    else
                    {
                        
                        if (closeIndex < openIndex) pairChecks.Add(false);
                        else pairChecks.Add(true);
                        bracketsList.RemoveAt(closeIndex);
                        bracketsList.RemoveAt(openIndex);
                    }
                        
                }
            }

            if (listLength == 0)
                return true;
            else
            {
                return brackets == 0 && openBracket == closedBracket && firstAndLast[0] != ']' && firstAndLast[1] != '[' && !pairChecks.Contains(false);
            }
        }
    }
}
