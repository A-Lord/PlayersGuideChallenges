using PlayersGuideChallenges.The_Old_Robot;


Console.WriteLine("hey");

Robot robot = new Robot();

for (int i = 0; i < robot.Commands.Length; i++)
{

    string playerCommand = Console.ReadLine();
    robot.Commands[i] = playerCommand switch
    {
        "on" => new OnCommand(),
        "off" => new OffCommand(), //changed my normal  switch to this sexy shorten one. 
        "north" => new NorthCommand(),
        "south" => new SouthCommand(),
        "east" => new EastCommand(),
        "west" => new WestCommand(),
    };

}
robot.Run();





