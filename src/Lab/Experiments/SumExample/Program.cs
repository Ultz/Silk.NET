using System;
using SumExample;

unsafe
{
    using var api = SumAPI.GetApi();

    int[] arr = {5, 3, 2};
    int sum;
    fixed (int* p = arr)
    {
        sum = api.Sum(arr.Length, p);
    }

    Console.WriteLine($"{string.Join(" + ", arr)} = {sum}");
}