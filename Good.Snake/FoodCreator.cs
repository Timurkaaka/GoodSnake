using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Good.Snake
{
    class FoodCreator
    {
        int mapWidth;
        int mapHight;
        char sim;

        Random random = new Random();

        public FoodCreator(int mapWidth, int mapHight, char sim)
        {
            this.mapWidth = mapWidth;
            this.mapHight = mapHight;
            this.sim = sim;
        }
        public Point CreateFood()
        {
            int x = random.Next(2, mapWidth - 2);
            int y = random.Next(2, mapHight - 2);
            return new Point(x, y, sim);
        }
    }
}
