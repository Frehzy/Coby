﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FaceRecognition;

internal static class SemaphoreAsync
{
    public static async Task<Tout[]> RunSemaphoreAsync<Tin, Tout>(IEnumerable<Tin> items, Func<Tin, Task<Tout>> func, int degree)
    {
        using SemaphoreSlim semaphore = new(degree);
        return await Task.WhenAll(items.Select(async item =>
        {
            await semaphore.WaitAsync();
            try
            {
                return await func(item);
            }
            finally
            {
                semaphore.Release();
            }
        }));
    }
}