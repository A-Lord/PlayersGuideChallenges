using System.Text;
using Room_Coordinates;

List<Coordinate> listOfCords = new List<Coordinate>();
listOfCords.Add(new Coordinate(1, 1));
listOfCords.Add(new Coordinate(4, 7));
listOfCords.Add(new Coordinate(1, 2));

CheckCords test = new CheckCords();
if(test.IsItClose(listOfCords))
    Console.WriteLine("yeey");

public struct Coordinate
{
    public int x { get; }
    public int y { get; }

    public Coordinate(int X,int Y)
    {
        x = X;
        y = Y;  
    }
}