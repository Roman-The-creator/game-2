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

        public MainForm()
        {
            InitializeComponent();
            _state = new GameState();
            _engine = new ReactorEngine();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Установка начальных значений
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
