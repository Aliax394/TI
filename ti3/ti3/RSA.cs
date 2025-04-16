namespace ti3;
using System.Numerics;

public class RSA
{
    public static bool IsPrime(int number, int k = 20)
    {
        if (number < 2) return false;
        if (number == 2 || number == 3) return true;
        if (number % 2 == 0) return false;

        BigInteger d = number - 1;
        int s = 0;
        while (d % 2 == 0)
        {
            d /= 2;
            s++;
        }

        Random rand = new Random();
        for (int i = 0; i < k; i++)
        {
            BigInteger a = new BigInteger(rand.Next()) % (number - 3) + 2;
            BigInteger x = BigInteger.ModPow(a, d, number);
            if (x == 1 || x == number - 1) continue;

            bool composite = true;
            for (int r = 0; r < s - 1; r++)
            {
                x = BigInteger.ModPow(x, 2, number);
                if (x == number - 1)
                {
                    composite = false;
                    break;
                }
            }
            if (composite) return false;
        }
        return true;
    }
    
    public static (int gcd, int x, int y) ExteEuclid(int a, int b)
    {
        // Инициализация начальных значений
        int x0 = 1, y0 = 0, x1 = 0, y1 = 1;
        int d0 = a, d1 = b; //поменять a и b местами для алгоритма по таблице

        while (d1 != 0)
        {
            // Вычисление остатка и частного
            int q = d0 / d1;
            int d2 = d0 % d1;
            int x2 = x0 - q * x1;
            int y2 = y0 - q * y1;

            // Обновление значений
            d0 = d1;
            d1 = d2;
            x0 = x1;
            x1 = x2;
            y0 = y1;
            y1 = y2;
        }

        if (y0 < 0) //Для RSA, не для рабина
        {
            y0 += a;
        }

        // Возвращаем НОД и коэффициенты x и y
        return (d0, x0, y0);
    }
    
    public static int FindGcd(int a, int b) => b == 0 ? a : FindGcd(b, a % b);

    public static int EulerPhi(int n)
    {

        int result = n; // Изначально присваиваем результату значение n

        // Перебираем все простые числа, которые делят n
        for (int p = 2; p * p <= n; ++p)
        {
            if (n % p == 0)
            {
                // Если p делит n, уменьшаем result на result / p и на p - 1
                while (n % p == 0)
                {
                    n /= p;
                }
                result -= result / p;
            }
        }

        // Если n осталось простым, уменьшаем result на result / n
        if (n > 1)
        {
            result -= result / n;
        }

        return result;
    }

    public static int QPowMod(int num, int power, int mod)
    {
        if (mod == 1)
            return 0;
        
        if (power == 0)
            return 1;

        if (num == 0)
            return 0;

        int result = 1;
        int current = num % mod;
        int exponent = power;
        
        while (exponent > 0)
        {
            if (exponent % 2 == 1)
                result = (result * current) % mod;

            current = (current * current) % mod;
            exponent /= 2;
        }

        return result;
    }
}