public static class TaskExtensions
{
    public static async Task<T2> Select<T, T2>(this Task<T> source, Func<T, T2> selector)
    {
        var ts = await source.ConfigureAwait(false);
        return selector(ts);
    }

    public static async Task<T3> SelectMany<T, T2, T3>(this Task<T> source, Func<T, Task<T2>> selector, Func<T, T2, T3> projection)
    {
        var ts = await source.ConfigureAwait(false);
        var t1 = await selector(ts).ConfigureAwait(false);
        return projection(ts, t1);
    }
}
