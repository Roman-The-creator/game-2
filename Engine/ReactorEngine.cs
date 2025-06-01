using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_game.Engine
{
    using my_game.Models;
    using System;

    public class ReactorEngine
    {
        private readonly Random _rand = new Random();

        public ReactionResult RunReaction(GameState state, int stake, int energy, int speed, int voltage)
        {
            if (stake > state.Balance)
                return new ReactionResult("error", 0, state.Temperature, "Недостаточно фишек.");

            int tempIncrease = (int)(speed * 0.4 + energy * 0.2);
            int newTemp = state.Temperature + tempIncrease;
            bool overheat = newTemp > 100;

            double baseChance = 0.5 + (energy - speed) / 200.0 - voltage / 300.0;
            baseChance = Math.Max(0.05, Math.Min(0.9, baseChance));

            double rand = _rand.NextDouble();
            double multiplier = 1.0 + energy / 50.0 + (voltage / 100.0) * _rand.NextDouble();
            multiplier *= state.BonusMultiplier;

            double winnings = 0;
            string outcome;
            string msg;

            if (overheat)
            {
                winnings = state.OverheatProtection ? stake : stake * 0.5;
                newTemp = 50;
                outcome = "overheat";
                msg = state.OverheatProtection
                    ? "Предохранитель сработал! Перегрев предотвращён."
                    : "Перегрев! Потеряна часть ставки.";
            }
            else if (rand < baseChance)
            {
                winnings = Math.Round(stake * multiplier, 2);
                outcome = "success";
                msg = $"Успешная реакция! Выигрыш: {winnings}";
            }
            else
            {
                winnings = 0;
                outcome = "fail";
                msg = "Сбой реакции. Ставка проиграна.";
            }

            state.Balance += (int)(winnings - stake);
            state.Temperature = newTemp;

            return new ReactionResult(outcome, winnings, newTemp, msg);
        }

        public void CoolDown(GameState state, int amount)
        {
            state.Temperature = Math.Max(0, state.Temperature - amount);
        }

    }

}
