namespace my_game
{
    partial class ResultForm
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
            this.labelFinalBalance = new System.Windows.Forms.Label();
            this.labelFinalBalanceValue = new System.Windows.Forms.Label();
            this.labelTotalLaunches = new System.Windows.Forms.Label();
            this.labelTotalLaunchesValue = new System.Windows.Forms.Label();
            this.labelOverheats = new System.Windows.Forms.Label();
            this.labelOverheatsValue = new System.Windows.Forms.Label();
            this.labelWinLoss = new System.Windows.Forms.Label();
            this.labelWinLossValue = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFinalBalance
            // 
            this.labelFinalBalance.AutoSize = true;
            this.labelFinalBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFinalBalance.Location = new System.Drawing.Point(186, 95);
            this.labelFinalBalance.Name = "labelFinalBalance";
            this.labelFinalBalance.Size = new System.Drawing.Size(132, 16);
            this.labelFinalBalance.TabIndex = 0;
            this.labelFinalBalance.Text = "Финальный баланс";
            // 
            // labelFinalBalanceValue
            // 
            this.labelFinalBalanceValue.AutoSize = true;
            this.labelFinalBalanceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFinalBalanceValue.Location = new System.Drawing.Point(334, 95);
            this.labelFinalBalanceValue.Name = "labelFinalBalanceValue";
            this.labelFinalBalanceValue.Size = new System.Drawing.Size(20, 16);
            this.labelFinalBalanceValue.TabIndex = 1;
            this.labelFinalBalanceValue.Text = "\" \"";
            // 
            // labelTotalLaunches
            // 
            this.labelTotalLaunches.AutoSize = true;
            this.labelTotalLaunches.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalLaunches.Location = new System.Drawing.Point(190, 162);
            this.labelTotalLaunches.Name = "labelTotalLaunches";
            this.labelTotalLaunches.Size = new System.Drawing.Size(153, 16);
            this.labelTotalLaunches.TabIndex = 2;
            this.labelTotalLaunches.Text = "Количество запусков:";
            // 
            // labelTotalLaunchesValue
            // 
            this.labelTotalLaunchesValue.AutoSize = true;
            this.labelTotalLaunchesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalLaunchesValue.Location = new System.Drawing.Point(359, 162);
            this.labelTotalLaunchesValue.Name = "labelTotalLaunchesValue";
            this.labelTotalLaunchesValue.Size = new System.Drawing.Size(23, 16);
            this.labelTotalLaunchesValue.TabIndex = 3;
            this.labelTotalLaunchesValue.Text = "\"  \"";
            // 
            // labelOverheats
            // 
            this.labelOverheats.AutoSize = true;
            this.labelOverheats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOverheats.Location = new System.Drawing.Point(190, 230);
            this.labelOverheats.Name = "labelOverheats";
            this.labelOverheats.Size = new System.Drawing.Size(169, 16);
            this.labelOverheats.TabIndex = 4;
            this.labelOverheats.Text = "Количество перегревов:";
            // 
            // labelOverheatsValue
            // 
            this.labelOverheatsValue.AutoSize = true;
            this.labelOverheatsValue.Location = new System.Drawing.Point(365, 233);
            this.labelOverheatsValue.Name = "labelOverheatsValue";
            this.labelOverheatsValue.Size = new System.Drawing.Size(17, 13);
            this.labelOverheatsValue.TabIndex = 5;
            this.labelOverheatsValue.Text = "\"\"";
            // 
            // labelWinLoss
            // 
            this.labelWinLoss.AutoSize = true;
            this.labelWinLoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWinLoss.Location = new System.Drawing.Point(190, 281);
            this.labelWinLoss.Name = "labelWinLoss";
            this.labelWinLoss.Size = new System.Drawing.Size(85, 16);
            this.labelWinLoss.TabIndex = 6;
            this.labelWinLoss.Text = "Общий итог:";
            // 
            // labelWinLossValue
            // 
            this.labelWinLossValue.AutoSize = true;
            this.labelWinLossValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWinLossValue.Location = new System.Drawing.Point(301, 281);
            this.labelWinLossValue.Name = "labelWinLossValue";
            this.labelWinLossValue.Size = new System.Drawing.Size(17, 16);
            this.labelWinLossValue.TabIndex = 7;
            this.labelWinLossValue.Text = "\"\"";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(304, 351);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(121, 32);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelWinLossValue);
            this.Controls.Add(this.labelWinLoss);
            this.Controls.Add(this.labelOverheatsValue);
            this.Controls.Add(this.labelOverheats);
            this.Controls.Add(this.labelTotalLaunchesValue);
            this.Controls.Add(this.labelTotalLaunches);
            this.Controls.Add(this.labelFinalBalanceValue);
            this.Controls.Add(this.labelFinalBalance);
            this.Name = "ResultForm";
            this.Text = "ResultForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFinalBalance;
        private System.Windows.Forms.Label labelFinalBalanceValue;
        private System.Windows.Forms.Label labelTotalLaunches;
        private System.Windows.Forms.Label labelTotalLaunchesValue;
        private System.Windows.Forms.Label labelOverheats;
        private System.Windows.Forms.Label labelOverheatsValue;
        private System.Windows.Forms.Label labelWinLoss;
        private System.Windows.Forms.Label labelWinLossValue;
        private System.Windows.Forms.Button buttonClose;
    }
}