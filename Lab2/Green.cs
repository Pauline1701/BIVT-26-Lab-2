using System.Collections.Generic;

namespace Lab2
{
    public class Green
    {
        const double E = 0.0001;
        const double Da = 0.0000000001;
        public double Task1(int n)
        {
            double answer = 0;

            // code here
            for (int i = 2; i<= n; i += 2)
            {
                answer += (double)i / (i + 1);
            }
            // end
                return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            double term = 1;
            for (int i = 0; i <= n; i++)
            {
                answer += term;
                term /= x;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long factorial = 1;
            for (int i = 0; i <= n; i++)
            {
                if (i == 0)
                    factorial = 1;
                else
                    factorial = factorial * i;
                answer = answer + factorial;
            }
            Console.WriteLine(answer);
            return answer;
        }
            // end
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            double powerX = x;
            int n = 1;
            while (true)
            {
                double term = Math.Sin(n * powerX);
                if (Math.Abs(term) < E) break;
                answer += term;
                powerX *= x;
                n++;
            }
            Console.WriteLine(answer);
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            double prev = 1.0;
            double curr = 1.0;
            int n = 1;
            while (Math.Abs(curr - prev) >= E)
            {
                n++;
                prev = curr;
                curr = curr / x;
            }
            answer = n;
            // end

            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;

            // code here
            int elem = 1, i = 0;
            while (elem < limit)
            {
                elem *= 2;
                answer += elem;
                i++;
            }
            // end

            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0;

            // code here
            double current = L;
            while (current > Da)
            {
                current /= 2;
                answer++;
            }
            Console.WriteLine(answer);
            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            double x = a;
            double curS = 0;
            int i = 0;
            double term = x;
            double k = x * x;
            while (x <= b + h / 2)
            {
                double absTerm = term < 0 ? -term : term;
                if (absTerm < E)
                {
                    SS = SS + curS;
                    SY = SY + System.Math.Atan(x);
                    x = x + h;
                    curS = 0;
                    i = 0;
                    term = x;
                    k = x * x;
                }
                else
                {
                    curS = curS + term;
                    i = i + 1;
                    term = -term * k * (2 * i - 1) / (2 * i + 1);
                }
            }
            return (SS, SY);
        }
            // end
        }
    }
