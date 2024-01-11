namespace Tasks_0
{
    class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            //просто фигуры
            Square square = new Square(10);
            Console.WriteLine(square);

            Triangle triangle = new Triangle(10,10,5);
            Console.WriteLine(triangle);

            Rectangle rectangle = new Rectangle(10, 5);
            Console.WriteLine(rectangle);

            Circle circle = new Circle(10);
            Console.WriteLine(circle);


            // составная
            Console.WriteLine();
            GeometricFigure[] arrFigure = new GeometricFigure[5];
            for (int i = 0; i < arrFigure.Length; i++)
            {
                int randGen = rand.Next(4);
                switch (randGen)
                {
                    case 0:
                        arrFigure[i] = new Circle(rand.Next(5, 10));
                        break;
                    case 1:
                        arrFigure[i] = new Rectangle(rand.Next(3, 20), rand.Next(3, 20));
                        break;
                    case 2:
                        arrFigure[i] = new Square(rand.Next(3, 20));
                        break;
                    case 3:
                        arrFigure[i] = new Triangle(rand.Next(3, 20), rand.Next(3, 20), rand.Next(3, 20));
                        break;
                    default:
                        break;
                }
            }

            CompositeFigure compositeFigure = new CompositeFigure();
            compositeFigure.ArrFigure = arrFigure;
            Console.WriteLine(compositeFigure);

        }
    }
}