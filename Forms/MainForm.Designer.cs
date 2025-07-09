using System;

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

        DateTime lastEventTime = DateTime.MinValue;
        TimeSpan minEventInterval = TimeSpan.FromSeconds(5); // Не чаще 1 события в 5 сек


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
            this.listActiveEffects = new System.Windows.Forms.ListBox();
            this.eventTimer = new System.Windows.Forms.Timer(this.components);
            this.cooldownDisableTimer = new System.Windows.Forms.Timer(this.components);
            this.btnLaunch = new System.Windows.Forms.Button();
            this.lblConsecutiveWins = new System.Windows.Forms.Label();
            this.passiveCoolingTimer = new System.Windows.Forms.Timer(this.components);
            this.coolingEffectTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstLog = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericStake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackEnergy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVoltage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCoolDown
            // 
            this.btnCoolDown.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoolDown.Location = new System.Drawing.Point(467, 374);
            this.btnCoolDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCoolDown.Name = "btnCoolDown";
            this.btnCoolDown.Size = new System.Drawing.Size(181, 47);
            this.btnCoolDown.TabIndex = 3;
            this.btnCoolDown.Text = "Охладить реактор";
            this.btnCoolDown.UseVisualStyleBackColor = true;
            this.btnCoolDown.Click += new System.EventHandler(this.btnCoolDown_Click);
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Location = new System.Drawing.Point(52, 78);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(114, 16);
            this.labelBalance.TabIndex = 5;
            this.labelBalance.Text = "Баланс: 0 фишек";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(581, 178);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 16);
            this.labelResult.TabIndex = 6;
            // 
            // labelTemperature
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Location = new System.Drawing.Point(467, 239);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(109, 16);
            this.labelTemperature.TabIndex = 7;
            this.labelTemperature.Text = "Температура: 0";
            // 
            // numericStake
            // 
            this.numericStake.Location = new System.Drawing.Point(97, 276);
            this.numericStake.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericStake.Name = "numericStake";
            this.numericStake.Size = new System.Drawing.Size(120, 22);
            this.numericStake.TabIndex = 8;
            // 
            // trackEnergy
            // 
            this.trackEnergy.Location = new System.Drawing.Point(377, 117);
            this.trackEnergy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackEnergy.Name = "trackEnergy";
            this.trackEnergy.Size = new System.Drawing.Size(104, 56);
            this.trackEnergy.TabIndex = 9;
            // 
            // trackSpeed
            // 
            this.trackSpeed.Location = new System.Drawing.Point(669, 117);
            this.trackSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackSpeed.Name = "trackSpeed";
            this.trackSpeed.Size = new System.Drawing.Size(104, 56);
            this.trackSpeed.TabIndex = 10;
            // 
            // trackVoltage
            // 
            this.trackVoltage.Location = new System.Drawing.Point(1001, 117);
            this.trackVoltage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackVoltage.Name = "trackVoltage";
            this.trackVoltage.Size = new System.Drawing.Size(168, 56);
            this.trackVoltage.TabIndex = 11;
            this.trackVoltage.Scroll += new System.EventHandler(this.trackVoltage_Scroll);
            // 
            // progressTemperature
            // 
            this.progressTemperature.Location = new System.Drawing.Point(651, 239);
            this.progressTemperature.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressTemperature.Name = "progressTemperature";
            this.progressTemperature.Size = new System.Drawing.Size(123, 22);
            this.progressTemperature.TabIndex = 12;
            // 
            // listActiveEffects
            // 
            this.listActiveEffects.BackColor = System.Drawing.Color.Black;
            this.listActiveEffects.ForeColor = System.Drawing.Color.Gold;
            this.listActiveEffects.FormattingEnabled = true;
            this.listActiveEffects.ItemHeight = 16;
            this.listActiveEffects.Location = new System.Drawing.Point(1295, 245);
            this.listActiveEffects.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listActiveEffects.Name = "listActiveEffects";
            this.listActiveEffects.Size = new System.Drawing.Size(200, 100);
            this.listActiveEffects.TabIndex = 15;
            // 
            // eventTimer
            // 
            this.eventTimer.Enabled = true;
            this.eventTimer.Interval = 1000;
            this.eventTimer.Tick += new System.EventHandler(this.EventTimer_Tick);
            // 
            // cooldownDisableTimer
            // 
            this.cooldownDisableTimer.Interval = 30000;
            this.cooldownDisableTimer.Tick += new System.EventHandler(this.CooldownDisableTimer_Tick);
            // 
            // btnLaunch
            // 
            this.btnLaunch.BackColor = System.Drawing.Color.LightGreen;
            this.btnLaunch.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnLaunch.Location = new System.Drawing.Point(669, 479);
            this.btnLaunch.Margin = new System.Windows.Forms.Padding(4);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(295, 48);
            this.btnLaunch.TabIndex = 16;
            this.btnLaunch.TabStop = false;
            this.btnLaunch.Text = "\"ЗАПУСК РЕАКТОРА\"";
            this.btnLaunch.UseVisualStyleBackColor = false;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // lblConsecutiveWins
            // 
            this.lblConsecutiveWins.AutoSize = true;
            this.lblConsecutiveWins.Location = new System.Drawing.Point(953, 297);
            this.lblConsecutiveWins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConsecutiveWins.Name = "lblConsecutiveWins";
            this.lblConsecutiveWins.Size = new System.Drawing.Size(132, 16);
            this.lblConsecutiveWins.TabIndex = 17;
            this.lblConsecutiveWins.Text = "Победы подряд: 0/3";
            // 
            // passiveCoolingTimer
            // 
            this.passiveCoolingTimer.Interval = 1000;
            this.passiveCoolingTimer.Tick += new System.EventHandler(this.PassiveCoolingTimer_Tick);
            // 
            // coolingEffectTimer
            // 
            this.coolingEffectTimer.Interval = 3000;
            this.coolingEffectTimer.Tick += new System.EventHandler(this.CoolingEffectTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Энергия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(684, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Скорость";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1041, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Напряжение";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(461, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(709, 29);
            this.label4.TabIndex = 21;
            this.label4.Text = "Цель: заработать как можно больше фишек за 5 минут!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 239);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Сумма ставки:";
            // 
            // lstLog
            // 
            this.lstLog.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstLog.FormattingEnabled = true;
            this.lstLog.ItemHeight = 20;
            this.lstLog.Location = new System.Drawing.Point(827, 346);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(400, 64);
            this.lstLog.TabIndex = 23;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 670);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblConsecutiveWins);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.listActiveEffects);
            this.Controls.Add(this.labelTemperature);
            this.Controls.Add(this.progressTemperature);
            this.Controls.Add(this.trackVoltage);
            this.Controls.Add(this.trackSpeed);
            this.Controls.Add(this.trackEnergy);
            this.Controls.Add(this.numericStake);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.btnCoolDown);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericStake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackEnergy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVoltage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Timer eventTimer;
        private System.Windows.Forms.Timer cooldownDisableTimer;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.Label lblConsecutiveWins;
        private System.Windows.Forms.Timer passiveCoolingTimer;
        private System.Windows.Forms.Timer coolingEffectTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstLog;
    }
}

