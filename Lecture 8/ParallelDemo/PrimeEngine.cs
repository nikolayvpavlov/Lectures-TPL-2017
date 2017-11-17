using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelDemo
{
    class PrimeEngine
    {
        const int Boundary = 200_000;

        public bool IsPrime(int n)
        {
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        public int[] GetPrimeNumbers()
        {
            //var firstPrimes = new int[]{ 1, 2 };
            //var primes = Enumerable
            //    .Range(3, Boundary-3)
            //    .Where(n => IsPrime(n))
            //    .ToArray();
            //return firstPrimes.Union(primes).ToArray();
            List<int> result = new List<int>() { 1, 2 };
            for (int i = 3; i < Boundary; i++)
            {
                if (IsPrime(i)) result.Add(i);
            }
            return result.ToArray();
        }

        public int[] GetPrimeNumbers2()
        {
            List<int> result = new List<int>() { 1, 2 };
            List<Task<bool>> primeTasks = new List<Task<bool>>();

            for (int i = 3; i < Boundary; i++)
            {
                var n = i;
                primeTasks.Add(
                    Task.Run(() => IsPrime(n)));
            }
            var final = Task.WhenAll(primeTasks.ToArray());
            final.Wait();
            for (int i = 0; i < final.Result.Length; i++)
            {
                if (final.Result[i]) result.Add(i + 3);
            }
            return result.ToArray();
        }

        public int[] GetPrimeNumbersParallel()
        {
            List<int> result = new List<int>() { 1, 2 };
            Parallel.For(3, Boundary,
                (i) =>
                {
                    if (IsPrime(i)) lock (result) { result.Add(i); };
                });
            return result.ToArray();
        }

        public int[] GetPrimeNumbersParallelLockless()
        {
            ConcurrentBag<int> result = new ConcurrentBag<int>() { 1, 2 };
            Parallel.For(3, Boundary,
                (i) =>
                {
                    if (IsPrime(i)) result.Add(i);
                });
            return result.ToArray();
        }
    }
}
