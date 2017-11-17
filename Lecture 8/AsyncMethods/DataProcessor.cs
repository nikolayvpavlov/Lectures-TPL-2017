using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncMethods
{
    class DataProcessor
    {
        private int[] data;
        const int Size = 50_000;

        public DataProcessor()
        {
            Random rand = new Random();
            data = Enumerable
                .Range(0, Size)
                .Select(i => rand.Next(1000))
                .ToArray();
        }

        public Task<int[]> GetSortedData()
        {
            return Task.Factory.StartNew(() => 
            {
                for (int i = 0; i < Size; i++)
                {
                    for (int j = 1; j < Size; j++)
                    {
                        if (data[i] > data[j])
                        {
                            int temp = data[i];
                            data[i] = data[j];
                            data[j] = temp;
                        }
                    }
                }
                return data;
            },
            TaskCreationOptions.LongRunning);
        }
    }
}
