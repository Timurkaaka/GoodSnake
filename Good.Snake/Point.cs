using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Good.Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sim;

        public Point( int _x, int _y, char _sim )
        {
            x = _x;
            y = _y;
            sim = _sim;
        }
        public Point( Point p )
        {
            x = p.x;
            y = p.y;
            sim = p.sim;
        }
        public void Move( int offset, Direction direction )
        {
            if( direction == Direction.RIGHT )
            {
                x = x + offset;
            }
             else if( direction == Direction.LEFT )
            {
                x = x - offset;
            }
            else if( direction == Direction.UP )
            {
                y = y - offset;
            }
            else if( direction == Direction.DOWN )
            {
                y = y + offset;
            }
        }
        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sim);
            Console.CursorVisible = false;
        }
        public void Clear()
        {
            sim = ' ';
            Draw();
        }
        public override string ToString()
        {
            return x + ", " + y + ", " + sim;
        }
    }
}
