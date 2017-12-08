using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quasar_Again
{
    public partial class Form1 : Form
    {
        private Decimal bet;
        private Die die18;
        private Die die47;
        private int total;//the running total 
        private bool betPlaced;
        private bool turnOver;
        private decimal[] multipliers = new decimal[]{0, 0.25M, 0.5M, 1.0M, 1.25M, 1.50M, 2.0M}; 
 
        public Form1()
        {
            InitializeComponent();
            die18 = new Die(1,8);
            die47 = new Die(4, 7);
        }

        private void newTurn(){
            total = 0;
            bet = 0;
            b_stay.Visible = false;
            turnOver = false;
            betPlaced = false;
            nu_bet.Enabled = true;
        }


        private void b_die18_Click(object sender, EventArgs e)
        {
            if (!betPlaced)
            {
                betPlaced = true;
                nu_bet.Enabled = false;
            }
            total += die18.roll();
            l_total.Text = ""+total;
            //check the total and make the turn button appear
            turnOver = total> 20;
            b_stay.Visible = total > 14;
        }

        private void b_stay_Click(object sender, EventArgs e)
        {
            turnOver = true;
        }

        private void b_die47_Click(object sender, EventArgs e)
        {
            total += die47.roll();
            l_total.Text = "" + total;
            turnOver = total > 20;
            b_stay.Visible = total > 14;
        }

        private Decimal payOut(int amount)
        {
            Decimal payout = 0;

            switch (total)
            {
                case 15:
                    payout = bet*multipliers[1];
                    break;
            }

            return payout;
        }

        private void checkTurn()
        {
            if (turnOver)
            {
                payOut()
            }

        }

        
    }
}
