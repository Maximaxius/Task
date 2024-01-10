//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ДЗ_2._Структуры__классы__методы
//{
//    //    Создать класс, описывающий Комнату.
//    //    Характеристики: размеры по осям x, y, z (ширина, высота, длина), площадь пола, площадь стен, объём помещения.
//    //Методы, которые необх.реализовать внутри класса: 
//    //+set’еры; get’еры для всех свойств;
//    //    Усложнение* аксессоры get и мутаторы set
//    //+для подсчёта  площади пола;
//    //+для подсчёта площади стен; 
//    //+для подсчёта объёма помещения;
//    //+для отображения ВСЕХ свойств объекта.
//    //•	Создать объект данного класса с помощью конструктора по умолчанию.
//    //•	Зарандомить значения x,y,z и назначить их с помощью set’еров.
//    //•	Вызвать методы для подсчётов площади пола, площади стен, объёма помещения.
//    //•	Вызвать метод для отображения данных на экран.

//    class Room
//    {
//        private int _width = 0;
//        private int _height = 0;
//        private int _length = 0;
//        private int _floorArea = 0;
//        private int _wallArea = 0;
//        private int _roomVolume = 0;

//        public int Width { get { return _width; } set { _width = value; } }
//        public int Height { get { return _height; } set { _height = value; } }
//        public int Length { get { return _length; } set { _length = value; } }
//        public int FloorArea { get { return _floorArea; } }
//        public int RoomVolume { get { return _roomVolume; } }

//        public Room() : this(13, 13, 13)
//        {
//            Console.WriteLine("I defalt constructor 13");
//        }

//        public Room(int w, int h, int l)
//        {
//            _width = w;
//            _height = h;
//            _length = l;
//            CalkFloorArea();
//            CalkWallArea();
//            CalkRoomVolume();
//        }

//        public void CalkFloorArea()
//        {
//            _floorArea = _width * _length;
//        }

//        public void CalkWallArea()
//        {
//            _wallArea = 2 * (_width + _length) * _height;                   // площадь стен= 2*(длина+ширина)*высоту
//        }

//        public void CalkRoomVolume()
//        {
//            _roomVolume = _width * _length * _height;
//        }
//        public override string ToString()
//        {
//            return $"width = {_width}m  height = {_height}m  length = {_length}m  floorArea = {_floorArea}m2  wallArea = {_wallArea}m2  roomVolume = {_roomVolume}m3";
//        }

//    }


//    class Program
//    {
//        static Random rand = new Random();
//        static void Main()
//        {
//            Room userRoom = new Room();
//            Console.WriteLine($"Room default constructor {userRoom} \n");

//            userRoom.Width = rand.Next(1, 13 + 1);
//            userRoom.Height = rand.Next(1, 13 + 1);
//            userRoom.Length = rand.Next(1, 13 + 1);
//            userRoom.CalkFloorArea();
//            userRoom.CalkWallArea();
//            userRoom.CalkRoomVolume();
//            Console.WriteLine($"Room using rand (set) {userRoom}\n");


//            //Усложнение 0:
//            //Создать в Main() массив Комнат. Кол - во комнат определяем случайным образом в диапазоне от 5 до 13.
//            //Для всех элементов зарандомить значения ширины, высоты и длины, после чего вызвать методы для подсчёта площади и объёма.
//            //Реализовать в Main() подсчёт суммарной площади пола для ВСЕХ комнат ранее созданного массива.
//            //Усложнение 1:
//            //Реализовать в Main() подсчёт суммарного объёма помещений для ВСЕХ комнат ранее созданного массива.
//            //Реализовать в Main() нахождения комнаты с самой большой площадью и отображение всей информации о ней.           
//            int sumAllFloorArea = 0;
//            int sumAllRoomVolume = 0;
//            Room[] userRooms = new Room[rand.Next(5, 13 + 1)];
//            for (int i = 0; i < userRooms.Length; i++)
//            {
//                userRooms[i] = new Room(rand.Next(1, 13 + 1), rand.Next(1, 13 + 1), rand.Next(1, 13 + 1));
//                Console.WriteLine($"Room {i}  {userRooms[i]}");
//                sumAllFloorArea += userRooms[i].FloorArea;
//                sumAllRoomVolume += userRooms[i].RoomVolume;
//            }
//            Console.WriteLine($"\ntotal floor area for ALL rooms {sumAllFloorArea}");
//            Console.WriteLine($"total room volume for ALL rooms {sumAllRoomVolume}\n");

//            int numberRoomWithBiggerArea = 0;
//            int nfloorArea = userRooms[0].FloorArea;
//            for (int i = 0; i < userRooms.Length; i++)
//            {
//                if (nfloorArea < userRooms[i].FloorArea)
//                {
//                    nfloorArea = userRooms[i].FloorArea;
//                    numberRoomWithBiggerArea = i;
//                }
//            }
//            Console.WriteLine($"the room with bigger floor area {numberRoomWithBiggerArea}   {userRooms[numberRoomWithBiggerArea]}");
//        }
//    }
//}
