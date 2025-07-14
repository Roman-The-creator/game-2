using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_game
{
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }
        
        public ResultForm(int balance, int launches, int overheats, int winLoss)
        {
            InitializeComponent();

            labelFinalBalanceValue.Text = $"{balance} фишек";
            labelTotalLaunchesValue.Text = launches.ToString();
            labelOverheatsValue.Text = overheats.ToString();

            if (winLoss >= 0)
                labelWinLossValue.Text = $"+{winLoss} фишек";
            else
                labelWinLossValue.Text = $"{winLoss} фишек";
        }
    }
}
