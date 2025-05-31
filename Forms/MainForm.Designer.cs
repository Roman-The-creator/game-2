namespace my_game.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCoolDown = new System.Windows.Forms.Button();
            this.labelBalance = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.numericStake = new System.Windows.Forms.NumericUpDown();
            this.trackEnergy = new System.Windows.Forms.TrackBar();
            this.trackSpeed = new System.Windows.Forms.TrackBar();
            this.trackVoltage = new System.Windows.Forms.TrackBar();
            this.progressTemperature = new System.Windows.Forms.ProgressBar();
            this.btnRunReaction = new System.Windows.Forms.Button();
            this.eventTimer = new System.Windows.Forms.Timer(this.components);
            this.cooldownDisableTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericStake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackEnergy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVoltage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCoolDown
            // 
            this.btnCoolDown.Location = new System.Drawing.Point(153, 54);
            this.btnCoolDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCoolDown.Name = "btnCoolDown";
            this.btnCoolDown.Size = new System.Drawing.Size(136, 19);
            this.btnCoolDown.TabIndex = 3;
            this.btnCoolDown.Text = "Охладить реактор";
            this.btnCoolDown.UseVisualStyleBackColor = true;
            this.btnCoolDown.Click += new System.EventHandler(this.btnCoolDown_Click);
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Location = new System.Drawing.Point(475, 150);
            this.labelBalance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(35, 13);
            this.labelBalance.TabIndex = 5;
            this.labelBalance.Text = "label5";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(581, 179);
            this.labelResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(35, 13);
            this.labelResult.TabIndex = 6;
            this.labelResult.Text = "label5";
            // 
            // numericStake
            // 
            this.numericStake.Location = new System.Drawing.Point(422, 242);
            this.numericStake.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericStake.Name = "numericStake";
            this.numericStake.Size = new System.Drawing.Size(90, 20);
            this.numericStake.TabIndex = 7;
            // 
            // trackEnergy
            // 
            this.trackEnergy.Location = new System.Drawing.Point(404, 85);
            this.trackEnergy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackEnergy.Name = "trackEnergy";
            this.trackEnergy.Size = new System.Drawing.Size(78, 45);
            this.trackEnergy.TabIndex = 8;
            // 
            // trackSpeed
            // 
            this.trackSpeed.Location = new System.Drawing.Point(741, 134);
            this.trackSpeed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackSpeed.Name = "trackSpeed";
            this.trackSpeed.Size = new System.Drawing.Size(78, 45);
            this.trackSpeed.TabIndex = 9;
            // 
            // trackVoltage
            // 
            this.trackVoltage.Location = new System.Drawing.Point(714, 225);
            this.trackVoltage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackVoltage.Name = "trackVoltage";
            this.trackVoltage.Size = new System.Drawing.Size(126, 45);
            this.trackVoltage.TabIndex = 10;
            // 
            // progressTemperature
            // 
            this.progressTemperature.Location = new System.Drawing.Point(331, 321);
            this.progressTemperature.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressTemperature.Name = "progressTemperature";
            this.progressTemperature.Size = new System.Drawing.Size(92, 18);
            this.progressTemperature.TabIndex = 11;
            // 
            // btnRunReaction
            // 
            this.btnRunReaction.Location = new System.Drawing.Point(281, 146);
            this.btnRunReaction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRunReaction.Name = "btnRunReaction";
            this.btnRunReaction.Size = new System.Drawing.Size(56, 19);
            this.btnRunReaction.TabIndex = 12;
            this.btnRunReaction.Text = "button1";
            this.btnRunReaction.UseVisualStyleBackColor = true;
            // 
            // eventTimer
            // 
            this.eventTimer.Enabled = true;
            this.eventTimer.Interval = 1000;
            this.eventTimer.Tick += new System.EventHandler(this.eventTimer_Tick);
            // 
            // cooldownDisableTimer
            // 
            this.cooldownDisableTimer.Interval = 30000;
            this.cooldownDisableTimer.Tick += new System.EventHandler(this.cooldownDisableTimer_Tick_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 544);
            this.Controls.Add(this.btnRunReaction);
            this.Controls.Add(this.progressTemperature);
            this.Controls.Add(this.trackVoltage);
            this.Controls.Add(this.trackSpeed);
            this.Controls.Add(this.trackEnergy);
            this.Controls.Add(this.numericStake);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.btnCoolDown);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.NumericUpDown numericStake;
        private System.Windows.Forms.TrackBar trackEnergy;
        private System.Windows.Forms.TrackBar trackSpeed;
        private System.Windows.Forms.TrackBar trackVoltage;
        private System.Windows.Forms.ProgressBar progressTemperature;
        private System.Windows.Forms.Button btnRunReaction;
        private System.Windows.Forms.Timer eventTimer;
        private System.Windows.Forms.Timer cooldownDisableTimer;
    }
}