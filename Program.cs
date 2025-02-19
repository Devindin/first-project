using System;

namespace first_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("ok...........");

            Console.WriteLine("Variables");
            int x = 10;
            Console.WriteLine(x);
            x = 40;
            Console.WriteLine(x);
            const int y = 20;
            Console.WriteLine(y);

            Console.WriteLine("Casting");

            int a = 80;
            double b = 4.88;

            double c = a;
            Console.WriteLine(c);

            int d = (int)b;
            Console.WriteLine(d);


            Console.WriteLine("Operators");

            int r = 30;

            r = r + 3;
            Console.WriteLine(r);

            r = r - 3;
            Console.WriteLine(r);

            r = r * 3;
            Console.WriteLine(r);

            r = r / 3;
            Console.WriteLine(r);

            r = r % 3;
            Console.WriteLine(r);

            Console.WriteLine("Increment");

            int s = 60;
            Console.WriteLine(s++);
            Console.WriteLine(s);
            int t = 70;
            Console.WriteLine(++t);

            Console.WriteLine("Decrement");

            int u = 60;
            Console.WriteLine(u--);
            Console.WriteLine(u);
            int v = 70;
            Console.WriteLine(++v);

            Console.WriteLine("Comperisions");

            int w = 10;
            int z = 20;
            Console.WriteLine(w > z);
            Console.WriteLine(w >= z);
            Console.WriteLine(w < z);
            Console.WriteLine(w <= z);
            Console.WriteLine(w == z);
            Console.WriteLine(w != z);


            Console.WriteLine("Logical operators");

            int e = 10;
            int f = 20;

            Console.WriteLine(e > f && e >= f);
            Console.WriteLine(e < f && e >= f);
            Console.WriteLine(e > f && e <= f);
            Console.WriteLine(e < f && e != f);


            Console.WriteLine(e > f || e >= f);
            Console.WriteLine(e < f || e >= f);
            Console.WriteLine(e > f || e <= f);
            Console.WriteLine(e < f || e != f);

            Console.WriteLine(!(a > b));


            Console.WriteLine("String");

            string name = "Good Morning";
            Console.WriteLine(name);
            Console.WriteLine(name.Length);
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name[0]);
            Console.WriteLine(name[11]);
            Console.WriteLine(name[7]);

            Console.WriteLine(name.IndexOf("M"));
            Console.WriteLine(name.IndexOf("0"));

            Console.WriteLine(name.Substring(5));

        }
    }
}
