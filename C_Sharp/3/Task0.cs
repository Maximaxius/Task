namespace ДЗ_2._Структуры__классы__методы
{
    //    В качестве первой таски разработайте класс для хранения информации о математическом примере с названием MathExample, который наполните полями(свойствами) :
    //      •a(первый операнд)
    //      •b(второй операнд)
    //      •result(результат операции -- подсчитывается только тогда, когда меняет один из операндов либо символ операции. Наподобие такого в примере из аудитории calcRating())
    //      •operation(символ операции -- может принимать значения + - / *)
    //Тип данных для каждого продумайте самостоятельно.
    //•	Кроме полей дополните класс необходимыми сэттерами и геттерами (Усложнение* аксессоры get и мутаторы set)
    //•	Методом ToString() для отображения всей информации на экран.
    //•	Добавьте в класс конструктор по умолчанию
    //•	Добавьте в класс конструктор с параметрами
    //После реализации всех либо части заданий продемонстрируйте их работу в главном методе Main()
    //за счёт вызова их для какого-либо из существующих объектов
    class MathExample
    {
        private int _a = 0;
        private int _b = 0;
        private char _operation = ' ';
        private int _result = 0;

        public int A
        {
            get { return _a; }
            set { _a = value; CalkResult(); }             //вроде считает результат при именении
        }

        public int B
        {
            get { return _b; }
            set { _b = value; CalkResult(); }
        }

        public char Operation
        {
            get { return _operation; }
            set { if (value == '+' || value == '-' || value == '*' || value == '/') _operation = value; CalkResult(); }
        }

        void CalkResult()
        {
            switch (_operation)
            {
                case '+':
                    _result = _a + _b; break;
                case '-':
                    _result = _a - _b; break;
                case '*':
                    _result = _a * _b; break;
                case '/':
                    _result = _a / _b; break;
                default:
                    break;
            }
        }
        public MathExample() : this(1, 2, '+')
        {
            Console.WriteLine("I TYT");
        }

        public MathExample(int a, int b, char operation)
        {
            this._a = a;
            this._b = b;
            if (operation == '+' || operation == '-' || operation == '*' || operation == '/')
                this._operation = operation;
            else this._operation = '+';
            CalkResult();
        }

        public override string ToString()
        {
            return $"{_a} {_operation} {_b} = {_result}";
        }

    }




    class Program
    {
        static Random rand = new Random();
        static void Main()
        {
            MathExample UserWords = new MathExample();
            Console.WriteLine(UserWords);

            Console.WriteLine("Enter first number");
            string? userStr = Console.ReadLine();
            bool isNum = int.TryParse(userStr, out int a);
            Console.WriteLine("Enter second number");
            userStr = Console.ReadLine();
            isNum = int.TryParse(userStr, out int b);

            Console.WriteLine("Enter operation(+ - / *)");
            userStr = Console.ReadLine();
            bool isChar = char.TryParse(userStr, out char operation);

            MathExample UserWords1 = new MathExample(a, b, operation);
            Console.WriteLine(UserWords1);


            while (true)
            {
                Console.WriteLine("Enter 1 for change first number\n\t2for change second number\n\t3 for change operation");
                userStr = Console.ReadLine();
                isNum = int.TryParse(userStr, out int userChores);
                switch (userChores)
                {
                    case 1:
                        Console.WriteLine("enter number");
                        userStr = Console.ReadLine();
                        isNum = int.TryParse(userStr, out a);
                        UserWords1.A = a;
                        Console.WriteLine(UserWords1);
                        break;
                    case 2:
                        Console.WriteLine("enter number");
                        userStr = Console.ReadLine();
                        isNum = int.TryParse(userStr, out b);
                        UserWords1.B = b;
                        Console.WriteLine(UserWords1);
                        break;
                    case 3:
                        Console.WriteLine("enter operation");
                        userStr = Console.ReadLine();
                        isChar = char.TryParse(userStr, out operation);
                        UserWords1.Operation = operation;
                        Console.WriteLine(UserWords1);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}