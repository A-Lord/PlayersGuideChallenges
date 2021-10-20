using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersGuideChallenges.The_Old_Robot
{
    public  class OffCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            robot.IsPowered = false;
        }
    }
}
