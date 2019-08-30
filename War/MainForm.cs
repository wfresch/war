using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace War
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Game _game;
        const string LBLMOVE = "You'll find out...";
        const string LBLSTATUS = "Time to play!";

        private void Form1_Load(object sender, EventArgs e)
        {
            _game = new Game("Liam");
            ResetLabels();
            ResetButtons();
            EvaluateCommandButtons(_game.GetPlayer(1));
        }

        #region Button Click events

        private void btnLoad_Click(object sender, EventArgs e)
        {
            btnLoad.BackColor = Color.LightBlue;
            SendMove(War.Move.Load);
        }

        private void btnShoot_Click(object sender, EventArgs e)
        {
            btnShoot.BackColor = Color.LightBlue;
            SendMove(War.Move.Shoot);
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            btnBlock.BackColor = Color.LightBlue;
            SendMove(War.Move.Block);
        }
        private void btnReflect_Click(object sender, EventArgs e)
        {
            btnReflect.BackColor = Color.LightBlue;
            SendMove(War.Move.Reflect);
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        #endregion

        #region Display logic
        private void ResetButtons()
        {
            btnLoad.Enabled = true;
            btnShoot.Enabled = true;
            btnBlock.Enabled = true;
            btnReflect.Enabled = true;
            btnPlayAgain.Enabled = false;

            btnLoad.BackColor = DefaultBackColor;
            btnShoot.BackColor = DefaultBackColor;
            btnBlock.BackColor = DefaultBackColor;
            btnReflect.BackColor = DefaultBackColor;
        }

        private void DisableCommandButtons()
        {
            btnLoad.Enabled = false;
            btnShoot.Enabled = false;
            btnBlock.Enabled = false;
            btnReflect.Enabled = false;
        }

        private void ResetLabels()
        {
            lblComputerMove.Text = LBLMOVE;
            lblStatus.Text = LBLSTATUS;
        }

        private void EvaluateCommandButtons(Player player)
        {
            if (player.HasAmmo)
            {
                btnLoad.Enabled = false;
            }
            else
            {
                btnShoot.Enabled = false;
            }

            if (!player.OpponentHasAmmo || player.BlockStreak >= 5)
            {
                btnBlock.Enabled = false;
            }

            if (!player.OpponentHasAmmo || player.ReflectStreak >= 3)
            {
                btnReflect.Enabled = false;
            }
        }
        #endregion

        #region Game logic
        private void SendMove(Move move)
        {
            var player0 = _game.GetPlayer(0);
            var player1 = _game.GetPlayer(1);

            Move move2 = player1.ChooseMove();
            lblComputerMove.Text = $"{move2}";

            player0.RecordMove(move, move2);
            player1.RecordMove(move2, move);

            ResetButtons();
            EvaluateCommandButtons(player0);

            var outcome = _game.CompareMoves(move, move2);
            HandleOutcome(outcome);
        }

        private void HandleOutcome(int outcome)
        {
            btnPlayAgain.Enabled = true;

            switch (outcome)
            {
                case 0:
                    lblStatus.Text = "No winner.\r\nKeep playing!";
                    btnPlayAgain.Enabled = false;
                    break;
                case 1:
                    lblStatus.Text = "You win!\r\nPlay again?";
                    DisableCommandButtons();
                    break;
                case 2:
                    lblStatus.Text = "Computer won.\r\nPlay again?";
                    DisableCommandButtons();
                    break;
            }
        }
        #endregion

    }
}
