using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Player
    {

        Dictionary<string, string> moves = new Dictionary<string, string>()
            {
                {"r", "rock" },
                {"p", "paper" },
                {"s", "scissors" }
            };
    }
}
