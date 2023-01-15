using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Snake
{
	class Point
	{
		public int x;
		public int y;
		public char sym;

        
        public Point()
        {
            // это конструктор который писать не обязательно
            // он ничего не возвращает и возвращаемое
            // значение мы не указываем совсем
        }

        public Point(int _x, int _y, char _sym)
        {
            // заполнение конструктора, чтобы в программе уже написать
            // Point p1 = new Point(1,3,'*');
            x = _x;
            y = _y;
            sym = _sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}

