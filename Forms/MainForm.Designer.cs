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
            this.lblUrgencyFlash = new System.Windows.Forms.Label();
            this.btnRecharge = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericStake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackEnergy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVoltage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCoolDown
            // 
            this.btnCoolDown.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoolDown.Location = new System.Drawing.Point(350, 304);
            this.btnCoolDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCoolDown.Name = "btnCoolDown";
            this.btnCoolDown.Size = new System.Drawing.Size(136, 38);
            this.btnCoolDown.TabIndex = 3;
            this.btnCoolDown.Text = "Охладить реактор";
            this.btnCoolDown.UseVisualStyleBackColor = true;
            this.btnCoolDown.Click += new System.EventHandler(this.btnCoolDown_Click);
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Location = new System.Drawing.Point(39, 63);
            this.labelBalance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(93, 13);
            this.labelBalance.TabIndex = 5;
            this.labelBalance.Text = "Баланс: 0 фишек";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(436, 145);
            this.labelResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 13);
            this.labelResult.TabIndex = 6;
            // 
            // labelTemperature
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Location = new System.Drawing.Point(350, 194);
            this.labelTemperature.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(86, 13);
            this.labelTemperature.TabIndex = 7;
            this.labelTemperature.Text = "Температура: 0";
            // 
            // numericStake
            // 
            this.numericStake.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericStake.Location = new System.Drawing.Point(73, 224);
            this.numericStake.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericStake.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericStake.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericStake.Name = "numericStake";
            this.numericStake.Size = new System.Drawing.Size(90, 27);
            this.numericStake.TabIndex = 8;
            this.numericStake.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericStake.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // trackEnergy
            // 
            this.trackEnergy.Location = new System.Drawing.Point(367, 95);
            this.trackEnergy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackEnergy.Name = "trackEnergy";
            this.trackEnergy.Size = new System.Drawing.Size(78, 45);
            this.trackEnergy.TabIndex = 9;
            this.trackEnergy.Scroll += new System.EventHandler(this.trackEnergy_Scroll);
            // 
            // trackSpeed
            // 
            this.trackSpeed.Location = new System.Drawing.Point(501, 95);
            this.trackSpeed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackSpeed.Name = "trackSpeed";
            this.trackSpeed.Size = new System.Drawing.Size(78, 45);
            this.trackSpeed.TabIndex = 10;
            this.trackSpeed.Scroll += new System.EventHandler(this.trackSpeed_Scroll);
            // 
            // trackVoltage
            // 
            this.trackVoltage.Location = new System.Drawing.Point(616, 95);
            this.trackVoltage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackVoltage.Name = "trackVoltage";
            this.trackVoltage.Size = new System.Drawing.Size(126, 45);
            this.trackVoltage.TabIndex = 11;
            this.trackVoltage.Scroll += new System.EventHandler(this.trackVoltage_Scroll);
            // 
            // progressTemperature
            // 
            this.progressTemperature.Location = new System.Drawing.Point(488, 194);
            this.progressTemperature.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressTemperature.Name = "progressTemperature";
            this.progressTemperature.Size = new System.Drawing.Size(92, 18);
            this.progressTemperature.TabIndex = 12;
            // 
            // listActiveEffects
            // 
            this.listActiveEffects.BackColor = System.Drawing.Color.Black;
            this.listActiveEffects.ForeColor = System.Drawing.Color.Gold;
            this.listActiveEffects.FormattingEnabled = true;
            this.listActiveEffects.Location = new System.Drawing.Point(971, 199);
            this.listActiveEffects.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listActiveEffects.Name = "listActiveEffects";
            this.listActiveEffects.Size = new System.Drawing.Size(151, 82);
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
            this.btnLaunch.Location = new System.Drawing.Point(502, 389);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(221, 39);
            this.btnLaunch.TabIndex = 16;
            this.btnLaunch.TabStop = false;
            this.btnLaunch.Text = "\"ЗАПУСК РЕАКТОРА\"";
            this.btnLaunch.UseVisualStyleBackColor = false;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // lblConsecutiveWins
            // 
            this.lblConsecutiveWins.AutoSize = true;
            this.lblConsecutiveWins.Location = new System.Drawing.Point(715, 241);
            this.lblConsecutiveWins.Name = "lblConsecutiveWins";
            this.lblConsecutiveWins.Size = new System.Drawing.Size(109, 13);
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
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(376, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Энергия";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(507, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Скорость";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(636, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Напряжение";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(346, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(558, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "Цель: заработать как можно больше фишек за 5 минут!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(70, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Сумма ставки:";
            // 
            // lstLog
            // 
            this.lstLog.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstLog.FormattingEnabled = true;
            this.lstLog.ItemHeight = 15;
            this.lstLog.Location = new System.Drawing.Point(620, 281);
            this.lstLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(301, 49);
            this.lstLog.TabIndex = 23;
            // 
            // lblUrgencyFlash
            // 
            this.lblUrgencyFlash.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUrgencyFlash.ForeColor = System.Drawing.Color.Red;
            this.lblUrgencyFlash.Location = new System.Drawing.Point(468, 32);
            this.lblUrgencyFlash.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUrgencyFlash.Name = "lblUrgencyFlash";
            this.lblUrgencyFlash.Size = new System.Drawing.Size(201, 24);
            this.lblUrgencyFlash.TabIndex = 24;
            this.lblUrgencyFlash.Text = "⏰ Осталось мало времени!";
            this.lblUrgencyFlash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUrgencyFlash.Visible = false;
            // 
            // btnRecharge
            // 
            this.btnRecharge.Location = new System.Drawing.Point(350, 241);
            this.btnRecharge.Name = "btnRecharge";
            this.btnRecharge.Size = new System.Drawing.Size(104, 35);
            this.btnRecharge.TabIndex = 25;
            this.btnRecharge.Text = "Подзарядка";
            this.btnRecharge.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 544);
            this.Controls.Add(this.btnRecharge);
            this.Controls.Add(this.lblUrgencyFlash);
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
            this.Name = "MainForm";
            this.Text = "Ё";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericStake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackEnergy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVoltage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.btnRecharge.Click += new System.EventHandler(this.btnRecharge_Click);


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
        private System.Windows.Forms.Label lblUrgencyFlash;
        private System.Windows.Forms.Button btnRecharge;
    }
}

