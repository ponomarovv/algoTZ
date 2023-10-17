using algosTZ;

int counter = 0;


using (StreamReader f = new StreamReader("NewFile1.txt"))
{
    while (f.ReadLine() is { } s)
    {
        if (string.IsNullOrEmpty(s)) continue;
        string[] split = s.Split(new Char[] { ' ' });

        // c is first char in a line. target symbol
        var c = split[0][0];

        // min and max count of target char.    
        string range = split[1];
        range = range.Substring(0, range.Length - 1);
        var minMaxCount = range.Split(new Char[] { '-' });

        bool minCountCheck = int.TryParse(minMaxCount[0], out int minCount);
        bool maxCountCheck = int.TryParse(minMaxCount[1], out int maxCount);

        if (minCount < 0 || maxCount < 0 ||
            !minCountCheck || !maxCountCheck) continue;

        // input string where we have to find target char 
        var input = split[2];

        CountService.CountLine(c, minCount, maxCount, input, ref counter);
    }
}

Console.WriteLine(counter);
