namespace my_game.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listActiveEffects;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCoolDown = new System.Windows.Forms.Button();
            this.labelBalance = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.numericStake = new System.Windows.Forms.NumericUpDown();
            this.trackEnergy = new System.Windows.Forms.TrackBar();
            this.trackSpeed = new System.Windows.Forms.TrackBar();
            this.trackVoltage = new System.Windows.Forms.TrackBar();
            this.progressTemperature = new System.Windows.Forms.ProgressBar();
            this.btnRunReaction = new System.Windows.Forms.Button();
            this.listActiveEffects = new System.Windows.Forms.ListBox();
            this.eventTimer = new System.Windows.Forms.Timer(this.components);
            this.cooldownDisableTimer = new System.Windows.Forms.Timer(this.components);
            this.btnLaunch = new System.Windows.Forms.Button();
            this.lblConsecutiveWins = new System.Windows.Forms.Label();
            this.passiveCoolingTimer = new System.Windows.Forms.Timer(this.components);
            this.coolingEffectTimer = new System.Windows.Forms.Timer(this.components);

            ((System.ComponentModel.ISupportInitialize)(this.numericStake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackEnergy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVoltage)).BeginInit();
            this.SuspendLayout();

            // 
            // listActiveEffects
            // 
            this.listActiveEffects.FormattingEnabled = true;
            this.listActiveEffects.Location = new System.Drawing.Point(475, 210); // Можешь поправить по дизайну
            this.listActiveEffects.Name = "listActiveEffects";
            this.listActiveEffects.Size = new System.Drawing.Size(200, 95);
            this.listActiveEffects.TabIndex = 20;

            // btnCoolDown
            this.btnCoolDown.Location = new System.Drawing.Point(153, 54);
            this.btnCoolDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnCoolDown.Name = "btnCoolDown";
            this.btnCoolDown.Size = new System.Drawing.Size(136, 19);
            this.btnCoolDown.TabIndex = 3;
            this.btnCoolDown.Text = "Охладить реактор";
            this.btnCoolDown.UseVisualStyleBackColor = true;
            this.btnCoolDown.Click += new System.EventHandler(this.btnCoolDown_Click);

            // labelBalance
            this.labelBalance.AutoSize = true;
            this.labelBalance.Location = new System.Drawing.Point(475, 150);
            this.labelBalance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(93, 13);
            this.labelBalance.TabIndex = 5;
            this.labelBalance.Text = "Баланс: 0 фишек";

            // labelResult
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(436, 145);
            this.labelResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 13);
            this.labelResult.TabIndex = 6;

            // labelTemperature
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Location = new System.Drawing.Point(475, 179);
            this.labelTemperature.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(86, 13);
            this.labelTemperature.TabIndex = 7;
            this.labelTemperature.Text = "Температура: 0";

            // numericStake
            this.numericStake.Location = new System.Drawing.Point(422, 242);
            this.numericStake.Margin = new System.Windows.Forms.Padding(2);
            this.numericStake.Name = "numericStake";
            this.numericStake.Size = new System.Drawing.Size(90, 20);
            this.numericStake.TabIndex = 8;

            // trackEnergy
            this.trackEnergy.Location = new System.Drawing.Point(404, 85);
            this.trackEnergy.Margin = new System.Windows.Forms.Padding(2);
            this.trackEnergy.Name = "trackEnergy";
            this.trackEnergy.Size = new System.Drawing.Size(78, 45);
            this.trackEnergy.TabIndex = 9;

            // trackSpeed
            this.trackSpeed.Location = new System.Drawing.Point(741, 134);
            this.trackSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.trackSpeed.Name = "trackSpeed";
            this.trackSpeed.Size = new System.Drawing.Size(78, 45);
            this.trackSpeed.TabIndex = 10;

            // trackVoltage
            this.trackVoltage.Location = new System.Drawing.Point(714, 225);
            this.trackVoltage.Margin = new System.Windows.Forms.Padding(2);
            this.trackVoltage.Name = "trackVoltage";
            this.trackVoltage.Size = new System.Drawing.Size(126, 45);
            this.trackVoltage.TabIndex = 11;

            // progressTemperature
            this.progressTemperature.Location = new System.Drawing.Point(331, 321);
            this.progressTemperature.Margin = new System.Windows.Forms.Padding(2);
            this.progressTemperature.Name = "progressTemperature";
            this.progressTemperature.Size = new System.Drawing.Size(92, 18);
            this.progressTemperature.TabIndex = 12;

            // btnRunReaction
            this.btnRunReaction.Location = new System.Drawing.Point(281, 146);
            this.btnRunReaction.Margin = new System.Windows.Forms.Padding(2);
            this.btnRunReaction.Name = "btnRunReaction";
            this.btnRunReaction.Size = new System.Drawing.Size(56, 19);
            this.btnRunReaction.TabIndex = 13;
            this.btnRunReaction.Text = "button1";
            this.btnRunReaction.UseVisualStyleBackColor = true;

            // listActiveEffects
            this.listActiveEffects.FormattingEnabled = true;
            this.listActiveEffects.Location = new System.Drawing.Point(638, 325);
            this.listActiveEffects.Margin = new System.Windows.Forms.Padding(2);
            this.listActiveEffects.Name = "listActiveEffects";
            this.listActiveEffects.Size = new System.Drawing.Size(151, 82);
            this.listActiveEffects.TabIndex = 15;

            // eventTimer
            this.eventTimer.Enabled = true;
            this.eventTimer.Interval = 1000;
            this.eventTimer.Tick += new System.EventHandler(this.EventTimer_Tick);

            // cooldownDisableTimer
            this.cooldownDisableTimer.Interval = 30000;
            this.cooldownDisableTimer.Tick += new System.EventHandler(this.CooldownDisableTimer_Tick);

            // btnLaunch
            this.btnLaunch.BackColor = System.Drawing.Color.Transparent;
            this.btnLaunch.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnLaunch.Location = new System.Drawing.Point(347, 493);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(221, 39);
            this.btnLaunch.TabIndex = 16;
            this.btnLaunch.TabStop = false;
            this.btnLaunch.Text = "\"ЗАПУСК РЕАКТОРА\"";
            this.btnLaunch.UseVisualStyleBackColor = false;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);

            // lblConsecutiveWins
            this.lblConsecutiveWins.AutoSize = true;
            this.lblConsecutiveWins.Location = new System.Drawing.Point(360, 394);
            this.lblConsecutiveWins.Name = "lblConsecutiveWins";
            this.lblConsecutiveWins.Size = new System.Drawing.Size(109, 13);
            this.lblConsecutiveWins.TabIndex = 17;
            this.lblConsecutiveWins.Text = "Победы подряд: 0/3";

            // passiveCoolingTimer
            this.passiveCoolingTimer.Interval = 1000;
            this.passiveCoolingTimer.Tick += new System.EventHandler(this.PassiveCoolingTimer_Tick);

            // coolingEffectTimer
            this.coolingEffectTimer.Interval = 3000;
            this.coolingEffectTimer.Tick += new System.EventHandler(this.CoolingEffectTimer_Tick);

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 544);
            this.Controls.Add(this.lblConsecutiveWins);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.listActiveEffects);
            this.Controls.Add(this.labelTemperature);
            this.Controls.Add(this.btnRunReaction);
            this.Controls.Add(this.progressTemperature);
            this.Controls.Add(this.trackVoltage);
            this.Controls.Add(this.trackSpeed);
            this.Controls.Add(this.trackEnergy);
            this.Controls.Add(this.numericStake);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.btnCoolDown);
            this.Controls.Add(this.listActiveEffects);

            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);

            ((System.ComponentModel.ISupportInitialize)(this.numericStake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackEnergy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVoltage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            this.listActiveEffects = new System.Windows.Forms.ListBox();

        }

        #endregion

        private System.Windows.Forms.Button btnCoolDown;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.NumericUpDown numericStake;
        private System.Windows.Forms.TrackBar trackEnergy;
        private System.Windows.Forms.TrackBar trackSpeed;
        private System.Windows.Forms.TrackBar trackVoltage;
        private System.Windows.Forms.ProgressBar progressTemperature;
        private System.Windows.Forms.Button btnRunReaction;
        private System.Windows.Forms.Timer eventTimer;
        private System.Windows.Forms.Timer cooldownDisableTimer;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.Label lblConsecutiveWins;
        private System.Windows.Forms.Timer passiveCoolingTimer;
        private System.Windows.Forms.Timer coolingEffectTimer;
    }
}

