using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_Vettori
{
    struct Vector
    {
        private readonly double _x;
        private readonly double _y;

        public double X { get { return _x; } }
        public double Y { get { return _y; } }

        public Vector(double x, double y)
        {
            _x = x; 
            _y = y;
        }

        public static Vector Versore(Vector v)
        {
            double m = Modulo(v);
            return v / m;
        }

        public static double Modulo(Vector v)
        {
            return (double)Math.Sqrt(v.X * v.X + v.Y * v.Y);
        }

        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a.X + b.X, a.Y + b.Y);
        }

        public static Vector operator +(Vector a)
        {
            return a;
        }
        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector(a.X - b.X, a.Y - b.Y);
        }
        public static Vector operator -(Vector a)
        {
            return new Vector(-a.X, -a.Y);
        }
        public static double operator *(Vector a, Vector b)
        {
            return a.X * b.X + a.Y * b.Y;
        }
        public static Vector operator *(int a, Vector b)
        {
            return new Vector(a * b.X, a * b.Y);
        }
        public static Vector operator *(Vector a, int b)
        {
            return new Vector(a.X * b, a.Y * b);
        }
        public static Vector operator /(Vector a, double b)
        {
            return new Vector(a.X / b, a.Y / b);
        }
        public override string ToString()
        {
            return $"{X}, {Y}";
        }
        public static Vector Parse(string s)
        {
            string[] parts = s.Split(',', ' ');
            return new Vector(int.Parse(parts[0]), int.Parse(parts[2]));
        }
        public static bool TryParse(string s, out Vector v)
        {
            String[] parts = s.Split(',', ' ');
            if (parts.Length != 2)
            {
                v = Vector.Parse("0; 0");
                return false;
            }

            int n;
            if (int.TryParse(parts[0], out n))
            {
                v = Vector.Parse("0; 0");
                return false;
            }

            int d;
            if (int.TryParse(parts[2], out d))
            {
                v = Vector.Parse("0; 0");
                return false;
            }

            v = new Vector(n, d);
            return true;
        }

        public static bool operator ==(Vector v1, Vector v2)
        {
            if (object.ReferenceEquals(v1, null))
            {
                if (object.ReferenceEquals(v2, null))
                    return true;
                return false;
            }
            if (object.ReferenceEquals(v2, null))
            {
                return false;
            }
            return v1.X == v2.X && v1.Y == v2.Y;
        }
        public static bool operator !=(Vector v1, Vector v2)

        {
            return !(v1 == v2);
        }

    }
}
