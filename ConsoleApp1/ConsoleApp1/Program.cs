using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Square");
            Console.WriteLine("2.Rectangular");
            Console.WriteLine("0.Quit");
            int Choise;
            Choise = Convert.ToInt32(Console.ReadLine());
            if (Choise == 1)
            {
                Console.Write("input side:");
                float Side = Convert.ToSingle(Console.ReadLine());
                Square s = new Square(Side);
                Console.WriteLine($"Area:{s.CalcArea()}");
            }
            else if (Choise==2)
            {

                Console.Write("input Width:");
                float Width = Convert.ToSingle(Console.ReadLine());
                Console.Write("input Length:");
                float Length = Convert.ToSingle(Console.ReadLine());
                Rectangular r = new Rectangular(Width,Length);
                Console.WriteLine($"Area:{r.CalcArea()}");
            }
            else if (Choise==0)
            {
                Console.WriteLine("Quit");
            }

           
        }
        abstract class Figure
        {
            public abstract float CalcArea();
        }
        class Square : Figure
        {
           
            public Square(float side)
            {
                Side = side;
            }
            private float _side;
            public float Side {
                get
                {
                    return _side;
                }
                set
                {
                    if (value>=0)
                    {
                        _side = value;
                    }
                }
             }


            public override float CalcArea()
            {
                float area = 0;
                area = Side * Side; 
                return area;
            }

        }
        class Rectangular : Figure
        {
            private float _width;
            private float _length;

            public Rectangular(float width,float length)
            {
                Width = width;
                Length = length;

            }
            public float Width {
                get
                {
                    return _width;
                }
                set
                {
                    if (value>=0)
                    {
                        _width = value;
                    }
                }
             }
            public float Length {
                get
                {
                    return _length;
                }
                set
                {
                    if (value>=0)
                    {
                        _length = value;
                    }
                }
            }


            public override float CalcArea()
            {
                float area = 0;
                area = Width * Length;
                return area;
            }
        }
        

            
    }
}
