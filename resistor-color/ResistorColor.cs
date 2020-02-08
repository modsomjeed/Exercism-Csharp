using System;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        color = color.ToLower();
        var listColor = Colors();
        var results = Array.FindIndex(listColor, s => s.Equals(color));
        return results;
    }

    public static string[] Colors()
    {
        string[] Colors = { "black", "brown", "red", "orange",
                                   "yellow", "green", "blue", "violet",
                                   "grey", "white" };
        return Colors;
    }
}