using System;
using System.Windows.Forms;
using my_game.Models;
using my_game.Engine;

namespace my_game.Forms
{
    public partial class MainForm : Form
    {
        private GameState _state;
        private ReactorEngine _engine;

        private Timer _blinkTimer;
        private bool _isBlinkVisible = true;

        private Timer _gameTimer;
        private TimeSpan _remainingTime = TimeSpan.FromMinutes(5);

        public MainForm()
        {
            InitializeComponent();

            _state = new GameState();
            _engine = new ReactorEngine();

            // Таймер мигания при перегреве
            _blinkTimer = new Timer();
            _blinkTimer.Interval = 500;
            _blinkTimer.Tick += BlinkTimer_Tick;
            _blinkTimer.Start();

            // Таймер обратного отсчета игры
            _gameTimer = new Timer();
            _gameTimer.Interval = 1000;
            _gameTimer.Tick += GameTimer_Tick;
            _gameTimer.Start();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Настройка параметров элементов управления
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
            progressTemperature.Value = Math.Min(progressTemperature.Maximum, _state.Temperature);

            if (_state.Temperature >= 90)
            {
                labelResult.Text = "⚠ Реактор перегревается!";
            }
            else
            {
                labelResult.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void btnRunReaction_Click(object sender, EventArgs e)
        {
            int stake = (int)numericStake.Value;
            int energy = trackEnergy.Value;
            int speed = trackSpeed.Value;
            int voltage = trackVoltage.Value;

            var result = _engine.RunReaction(_state, stake, energy, speed, voltage);

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
            }
        }
    }
}

