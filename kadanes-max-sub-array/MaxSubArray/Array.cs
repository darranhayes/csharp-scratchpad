namespace MaxSubArray;

public class Array
{
    public static int MaxSubArraySum(int[] values)
    {
        if (values is null || values.Length == 0)
            return 0;

        int best = values[0];
        int sum = best;

        foreach (var x in values[1..])
        {
            sum = Math.Max(x, sum + x);
            best = Math.Max(best, sum);
        }

        return best;
    }
}
