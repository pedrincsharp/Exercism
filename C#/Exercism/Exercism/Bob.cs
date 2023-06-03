using System;
using System.Text.RegularExpressions;

public static class Bob
{
    public static string Response(string statement)
    {
        statement = statement.Trim();

        if (string.IsNullOrWhiteSpace(statement))
            return "Fine. Be that way!";

        string verify = Regex.Replace(statement, "[^a-zA-Z]+", "");

        if (verify.ToUpper() == verify && !string.IsNullOrWhiteSpace(verify))
            if(statement[statement.Length - 1] != '?')
                return "Whoa, chill out!";
            else
                return "Calm down, I know what I'm doing!";

        if (statement[statement.Length - 1] == '?')
            return "Sure.";

        return "Whatever.";

    }
}