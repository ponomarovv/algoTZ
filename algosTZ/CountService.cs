namespace algosTZ;

public class CountService
{

 

    public static int CountLine(char c, int minCount, int maxCount, string input, ref int counter)
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

            if (item == c) currentFoundChars++;
            
            if (currentFoundChars > maxCount)
            {
                return counter;
            }
        }

        if (currentFoundChars >= minCount && currentFoundChars <= maxCount)
        {
            counter++;
        }

        return counter;
    }

}
