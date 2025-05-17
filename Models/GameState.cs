using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_game.Models
{
    public class GameState
    {
        public int Balance { get; set; } = 100;
        public int Temperature { get; set; } = 0;
        public double BonusMultiplier { get; set; } = 1.0;
        public bool OverheatProtection { get; set; } = false;
        public string ActiveEvent { get; set; } = "";
    }

}
