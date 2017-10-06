using System;

namespace StackIllustrated
{
    class Program
    {
        static void One()
        {
            int a = 1, b;
            OneSub(a);
        }

        static void Two()
        {
            int a;
        }

        static void OneSub(int n)
        {
            int x;
            OneSubSub(n);
        }

        static void OneSubSub(int x) { int m, p; }

        static void Main(string[] args)
        {
            int input = 10;
            int[] data = { 1, 2, 3 };
            One();
            Two();
        }
    }
}
