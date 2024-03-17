var result = await (
    from x in Steps.EchoV1Async(1)
    from y in Steps.EchoV2Async(2)
    from z in Steps.EchoV3Async(3)
    select x + y + z
    );

Console.WriteLine($"Expected: 6, Actual: {result}");
