using System;
using System.Drawing;
using System.Windows.Forms;
using my_game.Models;
using my_game.Engine;

namespace my_game.Forms
{
    public partial class MainForm : Form
    {
        // Game State
        private readonly GameState _state = new GameState();
        private readonly ReactorEngine _engine = new ReactorEngine();
        private readonly Random _random = new Random();

        // Timers
        private readonly Timer _passiveCoolingTimer;
        private readonly Timer _coolingEffectTimer;
        private readonly Timer _blinkTimer;
        private readonly Timer _gameTimer;
        private readonly Timer _cooldownDisableTimer;
        private readonly Timer _eventTimer;

        // Game Parameters
        private int _temperature = 0;
        private int _secondsWithoutOverheat = 0;
        private int _winStreak = 0;
        private int _launchesWithoutOverheat = 0;
        private int _secondsUntilNextEvent;
        private readonly TimeSpan _gameDuration = TimeSpan.FromMinutes(5);
        private TimeSpan _remainingTime;

        // Status Flags
        private bool _passiveCoolingActive = false;
        private bool _passiveCoolingUnlocked = false;
        private bool _isOverheated = false;
        private bool _doubleWinNextLaunch = false;
        private bool _isBlinkVisible = true;

        // UI Controls
        private ProgressBar _progressEnergy;
        private Label _lblEnergyStatus;
        private Label _lblBonusStatus;

        public MainForm()
        {
            InitializeComponent();

            // Инициализация таймеров (только здесь можно присвоить значения readonly полям)
            _passiveCoolingTimer = new Timer { Interval = 1000 };
            _coolingEffectTimer = new Timer { Interval = 3000 };
            _blinkTimer = new Timer { Interval = 500 };
            _gameTimer = new Timer { Interval = 1000 };
            _cooldownDisableTimer = new Timer();
            _eventTimer = new Timer { Interval = 1000 };

            // Подключаем события
            _passiveCoolingTimer.Tick += PassiveCoolingTimer_Tick;
            _coolingEffectTimer.Tick += CoolingEffectTimer_Tick;
            _blinkTimer.Tick += BlinkTimer_Tick;
            _gameTimer.Tick += GameTimer_Tick;
            _cooldownDisableTimer.Tick += CooldownDisableTimer_Tick;
            _eventTimer.Tick += EventTimer_Tick;

            // Запускаем нужные таймеры
            _passiveCoolingTimer.Start();
            _blinkTimer.Start();
            _gameTimer.Start();
            _eventTimer.Start();

            InitializeCustomComponents();
            InitializeGameSettings();
        }

        private void InitializeCustomComponents()
        {
            // Energy Progress Bar
            _progressEnergy = new ProgressBar
            {
                Minimum = 0,
                Maximum = 100,
                Value = 50,
                Size = new Size(200, 20),
                Location = new Point(20, 120),
                ForeColor = Color.Blue
            };
            Controls.Add(_progressEnergy);

            // Energy Status Label
            _lblEnergyStatus = new Label
            {
                Text = "Энергия: 50%",
                Location = new Point(230, 120),
                AutoSize = true
            };
            Controls.Add(_lblEnergyStatus);

            // Bonus Status Label
            _lblBonusStatus = new Label
            {
                Text = "",
                ForeColor = Color.Gold,
                BackColor = Color.Black,
                AutoSize = true,
                Visible = false,
                Location = new Point(20, 150)
            };
            Controls.Add(_lblBonusStatus);
        }

        private void InitializeGameSettings()
        {
            _secondsUntilNextEvent = _random.Next(30, 61);
            _state.CurrentEnergy = 50;
            _remainingTime = _gameDuration;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Initialize TrackBars
            trackEnergy.Minimum = 0;
            trackEnergy.Maximum = 100;
            trackEnergy.Value = 50;

            trackSpeed.Minimum = 0;
            trackSpeed.Maximum = 100;
            trackSpeed.Value = 50;

            trackVoltage.Minimum = 0;
            trackVoltage.Maximum = 100;
            trackVoltage.Value = 50;

            // Initialize NumericUpDown
            numericStake.Minimum = 1;
            numericStake.Maximum = 10;
            numericStake.Value = 5;

            // Initialize Temperature ProgressBar
            progressTemperature.Minimum = 0;
            progressTemperature.Maximum = 100;

            UpdateUI();
        }

        private void UpdateUI()
        {
            // Update Balance
            labelBalance.Text = $"Баланс: {_state.Balance} фишек";

            // Update Temperature
            progressTemperature.Value = Math.Min(progressTemperature.Maximum, _temperature);
            labelTemperature.Text = $"Температура: {_temperature}°C";

            // Update Energy
            _progressEnergy.Value = (int)_state.CurrentEnergy;
            _lblEnergyStatus.Text = $"Энергия: {(int)_state.CurrentEnergy}%";

            // Overheat Warning
            if (_temperature >= 90)
            {
                labelResult.Text = "⚠️ Реактор перегревается!";
                labelResult.ForeColor = Color.Red;
            }
            else
            {
                labelResult.Text = "";
                labelResult.ForeColor = Color.Black;
            }

            // Temperature Color Indicator
            if (_temperature < 40)
                progressTemperature.ForeColor = Color.Green;
            else if (_temperature < 80)
                progressTemperature.ForeColor = Color.Orange;
            else
                progressTemperature.ForeColor = Color.Red;


            // Active Effects List
            listActiveEffects.Items.Clear();
            if (_doubleWinNextLaunch)
                listActiveEffects.Items.Add("×2 следующий выигрыш");
            if (_passiveCoolingActive)
                listActiveEffects.Items.Add("Пассивное охлаждение");
        }

        private void btnRunReaction_Click(object sender, EventArgs e)
        {
            var result = _engine.RunReaction(
                _state,
                (int)numericStake.Value,
                trackEnergy.Value,
                trackSpeed.Value,
                trackVoltage.Value);

            if (result.IsWin)
            {
                _winStreak++;
                _launchesWithoutOverheat++;

                if (_winStreak == 3)
                {
                    MessageBox.Show("🏆 Достижение: 3 победы подряд! Следующий выигрыш +1 фишка");
                    _state.BonusFlat += 1;
                }

                if (_launchesWithoutOverheat == 5 && !_passiveCoolingUnlocked)
                {
                    MessageBox.Show("❄ Достижение: 5 запусков без перегрева! Активировано пассивное охлаждение.");
                    _passiveCoolingUnlocked = true;
                }
            }
            else
            {
                _winStreak = 0;
            }

            if (result.IsOverheat)
            {
                _launchesWithoutOverheat = 0;
            }

            labelResult.Text = result.Message;
            UpdateUI();
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            btnLaunch.Enabled = false;
            btnLaunch.Text = "ЗАПУСК...";

            try
            {
                LaunchReactorCore();
            }
            finally
            {
                btnLaunch.Enabled = true;
                btnLaunch.Text = "ЗАПУСК РЕАКТОРА";
            }
        }

        private void LaunchReactorCore()
        {
            try
            {
                // Energy Check
                if (_state.CurrentEnergy < 15)
                {
                    ShowWarning("Недостаточно энергии!");
                    return;
                }

                // Energy Consumption
                _state.CurrentEnergy -= 10;

                // Temperature Calculation
                double tempIncrease = CalculateTemperature();
                _temperature = (int)Math.Min(100, _temperature + tempIncrease);

                // Overheat Check
                if (_temperature > 100)
                {
                    HandleOverheat();
                    _isOverheated = true;
                }
                else
                {
                    HandleSuccess();
                    _isOverheated = false;
                }

                UpdateUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void HandleOverheat()
        {
            // Visual Effects
            FlashControl(progressTemperature, Color.Red, 3);

            // Game Logic
            _state.OverheatCount++;
            _state.Balance -= (int)numericStake.Value;
            _winStreak = 0;
            _launchesWithoutOverheat = 0;

            // Reset Passive Cooling
            _secondsWithoutOverheat = 0;
            _passiveCoolingActive = false;
            _coolingEffectTimer.Stop();

            ShowWarning($"ПЕРЕГРЕВ! -{numericStake.Value} фишек");
        }

        private void HandleSuccess()
        {
            // Calculate Winnings
            double winAmount = (int)numericStake.Value * (_doubleWinNextLaunch ? 2 : 1);
            _state.Balance += (int)winAmount;

            // Visual Effects
            FlashControl(progressTemperature, Color.Green, 1);

            // Update Stats
            _winStreak++;
            _launchesWithoutOverheat++;

            // Check Bonuses
            if (_winStreak >= 3)
            {
                _doubleWinNextLaunch = true;
                ShowBonus("Бонус: x2 на следующий запуск!");
            }

            ShowWarning($"УСПЕХ! +{winAmount} фишек");
        }

        private double CalculateTemperature()
        {
            double energyFactor = _state.CurrentEnergy / 100.0;
            double speedFactor = trackSpeed.Value / 100.0;
            double voltageFactor = trackVoltage.Value / 100.0;

            return (voltageFactor * 0.7 + speedFactor * 0.3) * (1.5 - energyFactor) * 50;
        }

        private void FlashControl(Control control, Color flashColor, int flashes)
        {
            Color original = control.BackColor;

            Timer flashTimer = new Timer { Interval = 200 };
            int count = 0;

            flashTimer.Tick += (s, e) => {
                control.BackColor = count % 2 == 0 ? flashColor : original;
                if (++count >= flashes * 2)
                {
                    control.BackColor = original;
                    flashTimer.Stop();
                }
            };

            flashTimer.Start();
        }

        private void ShowWarning(string message)
        {
            labelResult.Text = message;
            labelResult.ForeColor = Color.Red;

            Timer timer = new Timer { Interval = 2000 };
            timer.Tick += (s, e) => {
                labelResult.Text = "";
                labelResult.ForeColor = Color.Black;
                timer.Dispose();
            };
            timer.Start();
        }

        private void ShowBonus(string message)
        {
            _lblBonusStatus.Text = message;
            _lblBonusStatus.Visible = true;

            Timer timer = new Timer { Interval = 3000 };
            timer.Tick += (s, e) => {
                _lblBonusStatus.Visible = false;
                timer.Dispose();
            };
            timer.Start();
        }

        private void BlinkTimer_Tick(object sender, EventArgs e)
        {
            if (_temperature >= 90)
            {
                _isBlinkVisible = !_isBlinkVisible;
                labelResult.ForeColor = _isBlinkVisible ? Color.Red : Color.Black;
            }
            else
            {
                labelResult.ForeColor = Color.Black;
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

                MessageBox.Show("Время вышло! Игра завершена.", "Итоги",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnRunReaction.Enabled = false;
                btnCoolDown.Enabled = false;

                ShowResult();
            }
        }

        private void ShowResult()
        {
            ResultForm resultForm = new ResultForm(
                _state.Balance,
                _state.TotalLaunches,
                _state.TotalOverheats,
                _state.WinLoss);

            resultForm.ShowDialog();
        }

        private void EventTimer_Tick(object sender, EventArgs e)
        {
            if (_isOverheated) return;

            _secondsUntilNextEvent--;

            if (_secondsUntilNextEvent <= 0)
            {
                TriggerRandomEvent();
                _secondsUntilNextEvent = _random.Next(30, 61);
            }

            if (_passiveCoolingUnlocked && _temperature > 0)
            {
                _temperature = Math.Max(0, _temperature - 1);
            }
        }

        private void TriggerRandomEvent()
        {
            switch (_random.Next(0, 4))
            {
                case 0:
                    _temperature += 20;
                    MessageBox.Show("⚠️ Внезапный перегрев! Температура +20%", "Событие");
                    break;
                case 1:
                    _temperature = Math.Max(0, _temperature - 20);
                    MessageBox.Show("❄️ Система охладилась автоматически! -20% температуры", "Событие");
                    break;
                case 2:
                    _doubleWinNextLaunch = true;
                    MessageBox.Show("🎁 Следующий запуск принесёт удвоенный выигрыш!", "Событие");
                    break;
                case 3:
                    btnCoolDown.Enabled = false;
                    MessageBox.Show("🧊 Кнопка охлаждения отключена на 30 секунд!", "Событие");

                    Timer cooldownTimer = new Timer { Interval = 30000 };
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

        private void PassiveCoolingTimer_Tick(object sender, EventArgs e)
        {
            if (!_passiveCoolingActive)
            {
                _secondsWithoutOverheat++;
                if (_secondsWithoutOverheat >= 120)
                {
                    _passiveCoolingActive = true;
                    _coolingEffectTimer.Start();
                    MessageBox.Show("❄️ Бонус: Пассивное охлаждение активировано!");
                }
            }
        }

        private void CoolingEffectTimer_Tick(object sender, EventArgs e)
        {
            if (_temperature > 0)
            {
                _temperature--;
                UpdateUI();
            }
        }

        private void CooldownDisableTimer_Tick(object sender, EventArgs e)
        {
            btnCoolDown.Enabled = true;
            _cooldownDisableTimer.Stop();
        }

        private void btnCoolDown_Click(object sender, EventArgs e)
        {
            if (_state.Balance >= 2)
            {
                _state.Balance -= 2;
                _temperature = Math.Max(0, _temperature - 25);
                labelResult.Text = "Реактор охлаждён!";
            }
            else
            {
                labelResult.Text = "Недостаточно фишек для охлаждения!";
            }

            UpdateUI();
        }
    }
}