using System;

public static class LogLine
{
    public static string Message(string logLine)
    {
        return logLine.Substring(logLine.IndexOf(":")).Replace(":","").Trim();
    }

    public static string LogLevel(string logLine)
    {
        if (logLine.Contains("ERROR"))
            return "error";
        else if (logLine.Contains("WARNING"))
            return "warning";
        else if (logLine.Contains("INFO"))
            return "info";
        else return "";
    }

    public static string Reformat(string logLine)
    {
        return Message(logLine) + " (" + LogLevel(logLine) + ")";
    }
}
