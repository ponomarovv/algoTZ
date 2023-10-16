int counter = 0;

string s;

char c;
int minCount;
int maxCount;

string input;

using (StreamReader f = new StreamReader("NewFile1.txt"))
{
    while ((s = f.ReadLine()) != null)
    {
        bool flagBegin = false;
        bool flagEnd = false;
        int foundTimes = 0;

        string[] split = s.Split(new Char[] { ' ' });

        // c is first char in a line. target symbol
        c = split[0][0];
        string range = split[1];
        range = range.Substring(0, range.Length - 1);
        var minMaxCount = range.Split(new Char[] { '-' });


        // min and max count of target char.          
        minCount = int.Parse(minMaxCount[0]);
        maxCount = int.Parse(minMaxCount[1]);

        // input string where we have to find target char 
        input = split[2];


        var result = CountLine(c, minCount, maxCount, input, ref counter);
    }
}

Console.WriteLine(counter);


int CountLine(char c, int minCount, int maxCount, string input, ref int counter)
{
    int currentFoundChars = 0;

    var inputCharArray = input.ToCharArray();

    var inputCharArrayLength = inputCharArray.Length;
    for (var index = 0; index < inputCharArrayLength; index++)
    {
        var item = inputCharArray[index];

        if (minCount > currentFoundChars + (inputCharArrayLength - index))
        {
            return counter;
        }

        if (currentFoundChars > maxCount)
        {
            return counter;
        }

        if (item == c) currentFoundChars++;
    }

    if (currentFoundChars >= minCount && currentFoundChars <= maxCount)
    {
        counter++;
    }

    return counter;
}
