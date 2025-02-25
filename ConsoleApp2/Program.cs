/*
I=1
V=5
X=10
L=50
C=100
D=500
M=1000

0 < num < 4000
*/
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            string rom= "LVIII";

            num = RomToInt(rom);

            Console.WriteLine(num + " = 58");

            rom = "MCMXCIV";

            num = RomToInt(rom);

            Console.WriteLine(num + " = 1994");

            rom = "MMMDCCXLIX";

            num = RomToInt(rom);

            Console.WriteLine(num + " = 3749");

        }
        static int RomToInt(string rn)
        {
            int n = 0;

            int l = rn.Length;

            for(int i=1; i<l; i++)
            {
                if (SingleDigitRoman(rn[i-1]) < SingleDigitRoman(rn[i]))
                {
                    n += SingleDigitRoman(rn[i]) - SingleDigitRoman(rn[i-1]);
                    i++;
                }
                else
                {
                    n += SingleDigitRoman(rn[i-1]);
                }
            }

            if (SingleDigitRoman(rn[l-1]) <= SingleDigitRoman(rn[l-2]))
            {
                n += SingleDigitRoman(rn[l-1]);
            }

            return n;
        }

        static int SingleDigitRoman(char x)
        {
            switch (x)
            {
                case 'I':
                    return 1;
                case 'V':
                    return 5;
                case 'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;
                case 'M':
                    return 1000;
                default:
                    return 0;
            }
        }
    }
}
