using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_game.Models
{
    public class GameState
    {
        public int OverheatCount { get; set; } = 0;
        public int TotalWin { get; set; } = 0;
        public int TotalLoss { get; set; } = 0;
        public int LaunchCount { get; set; } = 0;

        public int BonusFlat { get; set; } = 0;

        public int Balance { get; set; } = 100;
        public int Temperature { get; set; } = 0;
        public double BonusMultiplier { get; set; } = 1.0;
        public bool OverheatProtection { get; set; } = false;
        public string ActiveEvent { get; set; } = "";

        // Новые свойства для статистики
        public int TotalLaunches { get; set; } = 0;
        public int TotalOverheats { get; set; } = 0;
        public int WinLoss { get; set; } = 0;
        public int CurrentEnergy { get; set; }
        // ✅ Новые свойства для механики "3 победы подряд"
        public int ConsecutiveWins { get; set; } = 0;              // Победы подряд
        public bool DoubleWinNextLaunch { get; set; } = false;     // Активирован ли бонус
        public bool PassiveCoolingActive { get; set; } = false;


    }
}