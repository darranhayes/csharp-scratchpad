public static class Steps
{
    private const int Delay = 250;

    public static Task<int> EchoV1Async(int a)
    {
        var tcs = new TaskCompletionSource<int>();
        tcs.SetResult(a);
        return tcs.Task;
    }

    public static async Task<int> EchoV2Async(int a)
    {
        await Task.Delay(Delay);
        return a;
    }

    public static Task<int> EchoV3Async(int a) => 
        Task.FromResult<int>(a);
}
