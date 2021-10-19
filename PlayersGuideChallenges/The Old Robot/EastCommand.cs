using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersGuideChallenges.The_Old_Robot
{
    public class EastCommand : RobotCommand
    {
        public override void Run(Robot robot)
        {
            if (robot.IsPowered)
                robot.X -= 1;
        }
    }
}
