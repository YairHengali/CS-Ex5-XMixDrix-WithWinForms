using System;
using System.Drawing;
using System.Windows.Forms;
using Logic;

namespace UI
{
    public partial class FormXMixDrix : Form
    {
        private readonly FormSettingsDialog r_SettingsForm;
        private readonly GameManagement r_Game = new GameManagement();

        public FormXMixDrix()
        {
            InitializeComponent();
            r_SettingsForm = new FormSettingsDialog();
            r_SettingsForm.FormClosing += r_SettingsForm_FormClosing;
            Application.Run(r_SettingsForm);
        }

        private void r_SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (r_SettingsForm.DialogResult == DialogResult.OK)
            {
                r_Game.SetBoardBySize(r_SettingsForm.BoardSize);
                if (r_SettingsForm.PlayerType == ePlayerType.Computer)
                {
                    r_Game.InitPlayers(r_SettingsForm.PlayerType, r_SettingsForm.Player1Name);
                }
                else
                {
                    r_Game.InitPlayers(r_SettingsForm.PlayerType, r_SettingsForm.Player1Name, r_SettingsForm.Player2Name);
                }
            }
            else
            {
                this.Close();
            }
        }

        private void xMixDrix_Load(object sender, EventArgs e)
        {
            r_Game.CurrentPlayerChanged += m_Game_CurrentPlayerChanged;
            r_Game.CurrentStateChangedFromRunning += m_Game_CurrentStateChangedFromRunning;
            createBoardButtons();
            setPlayersLabels();
            r_Game.SetupNewRound();
        }

        private void m_Game_CurrentStateChangedFromRunning(eGameState i_NewCurrentState, string i_CurrentPlayerName, int i_Player1Score, int i_Player2Score)
        {
            DialogResult? dialogResult = null;

            if (i_NewCurrentState == eGameState.DecidedWinner)
            {
                dialogResult = MessageBox.Show($"The winner is {i_CurrentPlayerName}!{Environment.NewLine}Would you like to play another round?", "A Win!", MessageBoxButtons.YesNo);
            }
            else if (i_NewCurrentState == eGameState.DecidedTie)
            {
                dialogResult = MessageBox.Show($"Tie!{Environment.NewLine}Would you like to play another round?", "A Tie!", MessageBoxButtons.YesNo);
            }

            if (dialogResult == DialogResult.Yes)
            {
                player1ScoreLabel.Text = i_Player1Score.ToString();
                player2ScoreLabel.Text = i_Player2Score.ToString();
                r_Game.SetupNewRound();
            }
            else
            {
                this.Close();
            }
        }

        private void createBoardButtons()
        {
            tableLayoutPanelOfButtons.RowCount = r_Game.Board.Size;
            tableLayoutPanelOfButtons.ColumnCount = r_Game.Board.Size;

            for (int i = 1; i <= r_Game.Board.Size; i++)
            {
                for (int j = 1; j <= r_Game.Board.Size; j++)
                {
                    IndexedButton cellButton = new IndexedButton(i, j);
                    cellButton.Name = string.Format($"{i},{j}");
                    cellButton.Size = new Size(40, 40);
                    cellButton.MouseClick += cellButton_MouseClick;
                    r_Game.Board.CellContentChanged += board_CellContentChanged;
                    this.tableLayoutPanelOfButtons.Controls.Add(cellButton);
                }
            }
        }

        private void board_CellContentChanged(int i_Row, int i_Col, eGameComponent i_NewCellContent)
        {
            foreach (IndexedButton cellButton in tableLayoutPanelOfButtons.Controls)
            {
                if (cellButton.Row == i_Row && cellButton.Col == i_Col)
                {
                    cellButton.Text = (i_NewCellContent == eGameComponent.Empty) ? " " : i_NewCellContent.ToString();
                    cellButton.Enabled = i_NewCellContent == eGameComponent.Empty;
                }
            }
        }

        private void setPlayersLabels()
        {
            player1NameLabel.Text = string.Format($"{r_Game.Players[0].PlayerName}: ");
            player2NameLabel.Text = string.Format($"{r_Game.Players[1].PlayerName}: ");
            player1NameLabel.Top = tableLayoutPanelOfButtons.Height + 10;
            player1NameLabel.Left = ClientSize.Width / 2 - ((player1NameLabel.Width + player1ScoreLabel.Width + player2NameLabel.Width + player2ScoreLabel.Width + 20) / 2);
            player1NameLabel.Left = (player1NameLabel.Left < 0) ? 0 : player1NameLabel.Left;
            player1ScoreLabel.Top = player1NameLabel.Top;
            player1ScoreLabel.Left = player1NameLabel.Left + player1NameLabel.Width;
            player2NameLabel.Top = player1NameLabel.Top;
            player2NameLabel.Left = player1ScoreLabel.Left + player1ScoreLabel.Width + 20;
            player2ScoreLabel.Top = player1NameLabel.Top;
            player2ScoreLabel.Left = player2NameLabel.Left + player2NameLabel.Width;
        }

        private void m_Game_CurrentPlayerChanged(int i_NewCurrentPlayerIndex)
        {
            if (i_NewCurrentPlayerIndex == 0)
            {
                player1NameLabel.Font = new Font(player1NameLabel.Font, FontStyle.Bold);
                player1ScoreLabel.Font = new Font(player1ScoreLabel.Font, FontStyle.Bold);
                player2NameLabel.Font = new Font(player2NameLabel.Font, FontStyle.Regular);
                player2ScoreLabel.Font = new Font(player2ScoreLabel.Font, FontStyle.Regular);
            }
            else
            {
                player1NameLabel.Font = new Font(player1NameLabel.Font, FontStyle.Regular);
                player1ScoreLabel.Font = new Font(player1ScoreLabel.Font, FontStyle.Regular);
                player2NameLabel.Font = new Font(player2NameLabel.Font, FontStyle.Bold);
                player2ScoreLabel.Font = new Font(player2ScoreLabel.Font, FontStyle.Bold);
            }
        }

        private void cellButton_MouseClick(object sender, MouseEventArgs e)
        {
            int row = (sender as IndexedButton).Row;
            int col = (sender as IndexedButton).Col;

            r_Game.MakeMove(row, col);
            r_Game.CheckCurrentState(row, col);
            if (r_Game.GetCurrentPlayerType() == ePlayerType.Computer)
            {
                r_Game.GetComputerMove(out row, out col);
                r_Game.MakeMove(row, col);
                r_Game.CheckCurrentState(row, col);
            }
        }
    }
}
