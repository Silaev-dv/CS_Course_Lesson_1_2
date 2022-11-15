using System.Diagnostics;
using System.Numerics;

namespace Solution1
{
    internal class Program
    {
        /*static bool game_end = false;

        static void GameCycle()
        {
            while (!game_end)
            {
                gameStep();
            }
        }

        static void gameStep()
        {
            game_end = true;
        } */


        static void Main(string[] args)
        {
            // дробные 
            float a; // 00 00000000 000
            double b; // 00 0000000000000000 000
            b = 14.5; // 01 0000000001001001 E010
            b =  0.145E2; // 0.145 * 10 ^ 2


            Console.WriteLine(1 - 0.9); // -0,09999999999999998
            
            Console.WriteLine((0.9 * 10 - 1 * 10) / 10);

            // целые числа
            int c; // 0 0000000000000000  
            long l; // 0 00000000 00000000 00000000 00000000
            
            Int16 i1; 
            Int32 i2;
            Int64 i3;

            UInt16 i4; // 0000000000000000
            UInt32 i5;
            UInt64 i6; // unsigned int 

            // символ
            char ch; // '0' = Unicode [~65000] 2^16 [00000000 00000000]
            Char ch1;

            // strings
            string s; // s = ch1 + ch2 + ch3 ... = "слово"
            s = "привет";

            // bool
            bool bl = true; // false; [0]

            // void - []
            // void anonVar; - так делать нельзя!
        }




/*        
        static double sum(double a, double b)
        {
            return (a * 10E18 + b * 10E18) / 10E18;
        }

        static void Diagnostics() // функция замера времени
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            f();
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }

        static void f()
        {
            // исследуемая функция
        }*/
    }
}