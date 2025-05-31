using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_game.Models
{
    public class ReactionResult
    {
        public string Outcome { get; set; }
        public double Winnings { get; set; }
        public int NewTemperature { get; set; }
        public string Message { get; set; }
        public bool IsWin { get; set; }
        public bool IsOverheat { get; set; }


        public ReactionResult(string outcome, double winnings, int newTemp, string message)
        {
            Outcome = outcome;
            Winnings = winnings;
            NewTemperature = newTemp;
            Message = message;
        }
    }

}