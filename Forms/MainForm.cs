using System;
using System.Windows.Forms;
using my_game.Models;
using my_game.Engine;
using my_game; 

namespace my_game.Forms
{
    public partial class MainForm : Form
    {
        private Timer passiveCoolingTimer;
        private Timer coolingEffectTimer;
        private int secondsWithoutOverheat = 0;
        private bool passiveCoolingActive = false;

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            int energy = trackEnergy.Value;
            int voltage = trackVoltage.Value;

            int heatGenerated = (energy + voltage) / 2;
            temperature += heatGenerated;

            if (temperature > 100)
            {
                _state.OverheatCount++;
                winStreak = 0;
                

                MessageBox.Show("🔥 Перегрев! Реактор отключён.");
                UpdateUI();
                secondsWithoutOverheat = 0;
                passiveCoolingActive = false;
                coolingEffectTimer.Stop();

                return;
            }

            // Вычисляем выигрыш
            int reward = (energy * voltage) / 10;

            if (doubleWinNextLaunch)
            {
                reward *= 2;
                doubleWinNextLaunch = false;
            }

            reward += _state.BonusFlat;
            _state.BonusFlat = 0;

            _state.Balance += reward;
            _state.TotalWin += reward;
            _state.LaunchCount++;
            winStreak++;

            if (winStreak == 3)
            {
                MessageBox.Show("🏆 Достижение: 3 победы подряд! Следующий выигрыш +1 фишка");
                _state.BonusFlat += 1;
            }

            UpdateUI();
        }

        

        int winStreak = 0;
        int launchesWithoutOverheat = 0;
        bool passiveCoolingUnlocked = false;

        Random _random = new Random();
        int temperature = 0; // Температура реактора, от 0 до 100
        bool doubleWinNextLaunch = false;
        int secondsUntilNextEvent = 0;
        private GameState _state;
        private ReactorEngine _engine;

        private Timer _blinkTimer;
        private bool _isBlinkVisible = true;

        private Timer _gameTimer;
        private TimeSpan _remainingTime = TimeSpan.FromMinutes(5);

        public MainForm()
        {
            InitializeComponent();
            passiveCoolingTimer = new Timer();
            passiveCoolingTimer.Interval = 1000;
            passiveCoolingTimer.Tick += PassiveCoolingTimer_Tick;
            passiveCoolingTimer.Start();

            coolingEffectTimer = new Timer();
            coolingEffectTimer.Interval = 3000;
            coolingEffectTimer.Tick += CoolingEffectTimer_Tick;

            secondsUntilNextEvent = _random.Next(30, 61); // от 30 до 60 секунд
            _state = new GameState();
            _engine = new ReactorEngine();

            _blinkTimer = new Timer();
            _blinkTimer.Interval = 500;
            _blinkTimer.Tick += BlinkTimer_Tick;
            _blinkTimer.Start();

            _gameTimer = new Timer();
            _gameTimer.Interval = 1000;
            _gameTimer.Tick += GameTimer_Tick;
            _gameTimer.Start();
        }
        private void DisableCoolingTemporarily()
        {
            btnCoolDown.Enabled = false;
            cooldownDisableTimer.Start();
        }

        private void cooldownDisableTimer_Tick(object sender, EventArgs e)
        {
            btnCoolDown.Enabled = true;
            cooldownDisableTimer.Stop();
        }
        private void TriggerRandomEvent()
        {
            int eventType = _random.Next(0, 4);

            switch (eventType)
            {
                case 0:
                    temperature += 20;
                    MessageBox.Show("⚠️ Внезапный перегрев! Температура +20%", "Событие");
                    break;
                case 1:
                    temperature = Math.Max(0, temperature - 20);
                    MessageBox.Show("❄️ Система охладилась автоматически! -20% температуры", "Событие");
                    break;
                case 2:
                    doubleWinNextLaunch = true;
                    MessageBox.Show("🎁 Следующий запуск принесёт удвоенный выигрыш!", "Событие");
                    break;
                case 3:
                    btnCoolDown.Enabled = false;
                    MessageBox.Show("🧊 Кнопка охлаждения отключена на 30 секунд!", "Событие");

                    Timer cooldownTimer = new Timer();
                    cooldownTimer.Interval = 30000;
                    cooldownTimer.Tick += (s, e) =>
                    {
                        btnCoolDown.Enabled = true;
                        cooldownTimer.Stop();
                        cooldownTimer.Dispose();
                    };
                    cooldownTimer.Start();
                    break;
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            trackEnergy.Minimum = 0;
            trackEnergy.Maximum = 100;
            trackEnergy.Value = 50;

            trackSpeed.Minimum = 0;
            trackSpeed.Maximum = 100;
            trackSpeed.Value = 50;

            trackVoltage.Minimum = 0;
            trackVoltage.Maximum = 100;
            trackVoltage.Value = 50;

            numericStake.Minimum = 1;
            numericStake.Maximum = 10;
            numericStake.Value = 5;

            progressTemperature.Minimum = 0;
            progressTemperature.Maximum = 100;

            UpdateUI();
        }

        private void UpdateUI()
        {
            labelBalance.Text = $"Баланс: {_state.Balance} фишек";
            progressTemperature.Value = Math.Min(progressTemperature.Maximum, temperature);
            labelTemperature.Text = $"Температура: {temperature}";

            if (temperature >= 90)
            {
                labelResult.Text = "⚠️ Реактор перегревается!";
                labelResult.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                labelResult.Text = "";
                labelResult.ForeColor = System.Drawing.Color.Black;
            }

            // Цветовая индикация температуры
            if (temperature < 40)
                progressTemperature.ForeColor = System.Drawing.Color.Green;
            else if (temperature < 80)
                progressTemperature.ForeColor = System.Drawing.Color.Orange;
            else
                progressTemperature.ForeColor = System.Drawing.Color.Red;
            listActiveEffects.Items.Clear();

            if (doubleWinNextLaunch)
                listActiveEffects.Items.Add("×2 следующий выигрыш");

            if (passiveCoolingActive)
                listActiveEffects.Items.Add("Пассивное охлаждение");

        }


        private void btnRunReaction_Click(object sender, EventArgs e)
        {
            int stake = (int)numericStake.Value;
            int energy = trackEnergy.Value;
            int speed = trackSpeed.Value;
            int voltage = trackVoltage.Value;

            var result = _engine.RunReaction(_state, stake, energy, speed, voltage);

            if (result.IsWin)
            {
                winStreak++;
                launchesWithoutOverheat++;

                if (winStreak == 3)
                {
                    MessageBox.Show("🏆 Достижение: 3 победы подряд! Следующий выигрыш +1 фишка");
                    _state.BonusFlat += 1; 
                }

                if (launchesWithoutOverheat == 5 && !passiveCoolingUnlocked)
                {
                    MessageBox.Show("❄ Достижение: 5 запусков без перегрева! Активировано пассивное охлаждение.");
                    passiveCoolingUnlocked = true;
                }
            }
            else
            {
                winStreak = 0;
            }

            if (result.IsOverheat)
            {
                launchesWithoutOverheat = 0;
            }

            labelResult.Text = result.Message;
            UpdateUI();
        }

        private void btnCoolDown_Click(object sender, EventArgs e)
        {
            if (_state.Balance >= 2)
            {
                _state.Balance -= 2;
                _state.Temperature = Math.Max(0, _state.Temperature - 25);
                labelResult.Text = "Реактор охлаждён!";
            }
            else
            {
                labelResult.Text = "Недостаточно фишек для охлаждения!";
            }

            UpdateUI();
        }

        private void BlinkTimer_Tick(object sender, EventArgs e)
        {
            if (_state.Temperature >= 90)
            {
                _isBlinkVisible = !_isBlinkVisible;
                labelResult.ForeColor = _isBlinkVisible ? System.Drawing.Color.Red : System.Drawing.Color.Black;
            }
            else
            {
                labelResult.ForeColor = System.Drawing.Color.Black;
                _isBlinkVisible = true;
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            _remainingTime = _remainingTime.Subtract(TimeSpan.FromSeconds(1));
            this.Text = $"Fortune Reactor — осталось: {_remainingTime:mm\\:ss}";

            if (_remainingTime <= TimeSpan.Zero)
            {
                _gameTimer.Stop();
                _blinkTimer.Stop();

                MessageBox.Show("Время вышло! Игра завершена.", "Итоги", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnRunReaction.Enabled = false;
                btnCoolDown.Enabled = false;

                ShowResult(); 
            }
        }

        private void ShowResult()
        {
            int balance = _state.Balance;
            int launches = _state.TotalLaunches;
            int overheats = _state.TotalOverheats;
            int winLoss = _state.WinLoss;

            ResultForm resultForm = new ResultForm(balance, launches, overheats, winLoss);
            resultForm.ShowDialog();
        }

        private void eventTimer_Tick(object sender, EventArgs e)
        {
            secondsUntilNextEvent--;

            if (secondsUntilNextEvent <= 0)
            {
                TriggerRandomEvent();
                secondsUntilNextEvent = _random.Next(30, 61);
            }

            if (passiveCoolingUnlocked && temperature > 0)
            {
                temperature = Math.Max(0, temperature - 1);
            }

        }

        private void cooldownDisableTimer_Tick_1(object sender, EventArgs e)
        {
            btnCoolDown.Enabled = true;               
            cooldownDisableTimer.Stop();
        }

        private void PassiveCoolingTimer_Tick(object sender, EventArgs e)
        {
            if (!passiveCoolingActive)
            {
                secondsWithoutOverheat++;
                if (secondsWithoutOverheat >= 120)
                {
                    passiveCoolingActive = true;
                    coolingEffectTimer.Start();
                    MessageBox.Show("❄️ Бонус: Пассивное охлаждение активировано!");
                }
            }
        }

        private void CoolingEffectTimer_Tick(object sender, EventArgs e)
        {
            if (temperature > 0)
            {
                temperature--;
                UpdateUI();
            }
        }

    }
}

