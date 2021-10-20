using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room_Coordinates
{
    public class CheckCords
    {
        public bool IsItClose(List<Coordinate> listOfCords)
        {
            foreach (Coordinate c in listOfCords)
            {
                for (int i = 0; i < listOfCords.Count; i++)
                {
                    if (c.x == listOfCords[i].x || c.x + 1 == listOfCords[i].x || c.x - 1 == listOfCords[i].x || c.y == listOfCords[i].x || c.y + 1 == listOfCords[i].y || c.y - 1 == listOfCords[i].y)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
