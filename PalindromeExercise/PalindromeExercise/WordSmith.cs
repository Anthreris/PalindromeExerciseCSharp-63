using System;

namespace PalindromeExercise;

public class WordSmith
{
    public bool IsAPalindrome(string text)
    {
        var reverseText = "";

        for (var i = text.Length - 1; i >= 0; i--)
        {
            reverseText += text[i];
        }
        
        if (reverseText == text)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}