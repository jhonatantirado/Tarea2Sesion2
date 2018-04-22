using System;
using System.Threading;
using System.Diagnostics;

namespace NotacionBigO
{
    class Fibonacci
    {
        private static long N = 100000;
	    private static long [] f = new long [ N + 1];
        public static void Main(string[] args)
        {

                //Ejercicio de DataStructures
                NotacionBigO.DS.DataStructures test = new NotacionBigO.DS.DataStructures();
                test.execute(args);

                //Ejercicio de Fibonacci

                // Stopwatch stopWatch = new Stopwatch();
                // stopWatch.Start();

                // Console.WriteLine("fibonacciProgDinamica: " + N);

                // for (int i = 1; i <= N; i++) {
                //     try {
                //         long fibonacci = NotacionBigO.Fibonacci.fibonacciProgDinamica(i);
                //         //Console.WriteLine(i + " => " + fibonacci);
                //     } catch (Exception e) {
                //         Console.WriteLine(e.InnerException);
                //     }
                // }

                // long ts = stopWatch.ElapsedMilliseconds;
                
                // Console.WriteLine("Time elapsed in milliseconds: " + ts);

        }

        //Complejidad Exponencial O(2^N)
	    public static long fibonacciExponencial(int n)  {
            if (n < 0) {
                throw new Exception("N can not be less than zero");
            }
            if (n <= 2) {
                return 1;
            }
            return fibonacciExponencial(n - 1) + fibonacciExponencial(n - 2);
	    }

        //Complejidad Lineal O(N)
	    public static long fibonacciLineal(int n) {
            int a = 0;
            int b = 1;
            int c = 0;
            for (int k = 0; k < n; k++) {
                c = a + b;
                a = b;
                b = c;
            }
            return a;
	    }

        //Complejidad Logarítmica O(log N base 2)
        //Programación Dinámica
        //Bottom-up Fibonacci: Resolver y almacenar el resultado de todos los subproblemas, del más simple al más complejo
        public static long fibonacciProgDinamica(int n) {
            if (n < 0) {
                throw new Exception("N can not be less than zero");
            }
            if (n <= 1) {
                return n;
            }

            long[] res = new long[n + 1];

            res[0] = 0;
            res[1] = 1;

            for (int k = 2; k <= n; k++) {
                res[k] = res[(k - 2)] + res[(k - 1)];
            }
            return res[n];
        }

        //Complejidad Logarítmica O(log N base 2)
        //Programación Dinámica
        //TopDown Fibonnaci: Almacenar cada subproblema resuelto para reutilizarlo la próxima vez que sea requerido
        //https://introcs.cs.princeton.edu/java/23recursion/
        public static long TopDownFibonnaci(int n)
        {
            if (n < 0) {
                throw new Exception("N can not be less than zero");
            }
            if (n <= 1) {
                return n;
            }
            f[0]=0;
            f[1]=1;
            if (f[n]>0) return f[n];
            f[n]=f[n-1] + f[n-2];
            return f[n];
        }

    }
}
