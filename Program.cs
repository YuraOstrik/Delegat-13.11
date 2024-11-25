using static System.Runtime.InteropServices.JavaScript.JSType;

namespace numbercheck
{

    class Program
    {
        struct Vector3
        {
            public int x { get; }
            public int y { get; }
            public int z { get; }

            public Vector3(int x, int y, int z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }
            public static Vector3 operator *(Vector3 a, int b)
            {
                return new Vector3(a.x * b, a.y * b, a.z * b);
            }
            public static Vector3 operator +(Vector3 a, Vector3 b)
            {
                return new Vector3(a.x + b.x, a.y + b.y, a.z + b.z);
            }

            public static Vector3 operator -(Vector3 a, Vector3 b)
            {
                return new Vector3(a.x - b.x, a.y - b.y, a.z - b.z);
            }

            public override string ToString()
            {
                return $"({x}, {y}, {z})";
            }
        }

        static void Main(string[] args)
        {
            Vector3 v1 = new Vector3(1, 2, 3);
            Vector3 v2 = new Vector3(-4, -2, 3);

            int num = 5;
            Vector3 sum = v1 - v2;
            Console.WriteLine($"Вектор разницы = {sum}");
            Console.WriteLine($"Вектор скалярного умножения = {v1 * num}");
        }

    }


    //class Program
    //{
    //    struct Ten
    //    {
    //        public int x { get; }

//        public Ten(int a)
//        {
//            x = a;
//        }


//        public string ToBin() 
//        {
//            return Convert.ToString(x, 2);
//        }

//        public string ToOct()
//        {
//            return Convert.ToString(x, 8);
//        }
//        public string ToHex()
//        {
//            return Convert.ToString(x, 16).ToUpper();
//        }

//        public override string ToString()
//        {
//            return x.ToString();
//        }

//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Твое число - ");
//        Ten c = new Ten(int.Parse(Console.ReadLine()));

//        Console.WriteLine($"Десятичное число: {c}");
//        Console.WriteLine($"Двоичная система: {c.ToBin()}");
//        Console.WriteLine($"Восьмеричная система: {c.ToOct()}");
//        Console.WriteLine($"Шестнадцатеричная система: {c.ToHex()}");

//    }

//}
//    class Program
//    {
//        struct Colour
//        {
//            public int R { get; }
//            public int G { get; }
//            public int B { get; }

//            public Colour(int r, int g, int b)
//            {
//                this.R = r;
//                this.G = g;
//                this.B = b;
//            }

//            public string ToH()
//            {
//                return $"#{R:X2}{G:X2}{B:X2}";
//            }
//            public (double H, double S, double L) ToHSL()
//            {
//                double r = R / 255.0;
//                double g = G / 255.0;
//                double b = B / 255.0;
//                double max = Math.Max(r, Math.Max(g, b));
//                double min = Math.Min(r, Math.Min(g, b));
//                double delta = max - min;

//                double h = 0; // Hue
//                if (delta > 0)
//                {
//                    if (max == r)
//                    {
//                        h = ((g - b) / delta) % 6;
//                    }
//                    else if (max == g)
//                    {
//                        h = (b - r) / delta + 2;
//                    }
//                    else if (max == b)
//                    {
//                        h = (r - g) / delta + 4;
//                    }
//                }
//                h *= 60;
//                if (h < 0) h += 360;

//                double l = (max + min) / 2; 
//                double s = delta == 0 ? 0 : delta / (1 - Math.Abs(2 * l - 1)); 

//                return (Math.Round(h, 2), Math.Round(s * 100, 2), Math.Round(l * 100, 2));
//            }
//            public (double C, double M, double Y, double K) ToCMYK()
//            {
//                if (R == 0 && G == 0 && B == 0)
//                {
//                    return (0, 0, 0, 1);
//                }

//                double r = R / 255.0;
//                double g = G / 255.0;
//                double b = B / 255.0;

//                double k = 1 - Math.Max(r, Math.Max(g, b));
//                double c = (1 - r - k) / (1 - k);
//                double m = (1 - g - k) / (1 - k);
//                double y = (1 - b - k) / (1 - k);

//                return (Math.Round(c * 100, 2), Math.Round(m * 100, 2), Math.Round(y * 100, 2), Math.Round(k * 100, 2));
//            }

//            public override string ToString()
//            {
//                return $"RGB({R}, {G}, {B})";
//            }



//        }

//        static void Main(string[] args)
//        {
//            Console.WriteLine("Введите значения RGB (0-255) через пробел:");
//            string[] inputs = Console.ReadLine()?.Split(' ');

//            if (inputs != null && inputs.Length == 3 &&
//                byte.TryParse(inputs[0], out int r) &&
//                byte.TryParse(inputs[1], out int g) &&
//                byte.TryParse(inputs[2], out int b))
//            {
//                Colour color = new Colour(r, g, b);

//                Console.WriteLine($"Цвет в RGB: {color}");
//                Console.WriteLine($"HEX: {color.ToH()}");

//                var (h, s, l) = color.ToHSL();
//                Console.WriteLine($"HSL: H={h}, S={s}%, L={l}%");

//                var (c, m, y, k) = color.ToCMYK();
//                Console.WriteLine($"CMYK: C={c}%, M={m}%, Y={y}%, K={k}%");
//            }
//            else
//            {
//                Console.WriteLine("Ошибка");
//            }

//        }

//    }

}
