#define ValidCase1
using System;
namespace PreprocessorDirective
{
    public class Preprocessor
    {
        public static void Main()
        {
#if ValidCase1
            Console.WriteLine("ValidCase1");
#elif ValidCase2
            Console.WriteLine("ValidCase2");
#else
            Console..WriteLine("InvalidCase");
#endif

        }
    }
}
