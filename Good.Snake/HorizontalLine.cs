using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Good.Snake
{
    class HorizontalLine : Figure
    {
        public HorizontalLine( int xLeft, int xReight, int y, char sim )
        {
            pList = new List<Point>();
            for( int x = xLeft; x <= xReight; x++ )
            {
                Point p = new Point( x, y, sim );
                pList.Add( p );
            }
        
        }
        
    }
}
