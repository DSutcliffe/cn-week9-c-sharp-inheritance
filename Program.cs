using System;

namespace cn_week9_c_sharp_inheritance
{
    class ObjectWeWillMessAroundWithTodayInTheClass
    {
        public void theWidth(int myWidth)
        {
            width = myWidth;
        }
        public void theHeight(int myHeight)
        {
            height = myHeight;
        }

        protected int width;
        protected int height;
    }

    class Square : ObjectWeWillMessAroundWithTodayInTheClass
    // subclass created here.
    {
        public int area() {
            // void not required as now returning something
            return (width * height);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // creating a new instance of square
            Square mySquare = new Square();
            mySquare.theHeight(10);
            mySquare.theWidth(10);
            Console.WriteLine("My square has a value of: {0}", mySquare.area());
            Console.ReadKey();

            // Console.WriteLine("Hello World!");
        }
    }
}
