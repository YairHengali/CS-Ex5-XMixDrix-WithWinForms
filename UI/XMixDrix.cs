using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ex02.ConsoleUtils;
using Logic;

namespace UI
{
    public partial class XMixDrix : Form
    {
        private readonly SettingsDialog r_SettingsForm;
        private GameManagement m_Game = new GameManagement();

        public XMixDrix()
        {
            InitializeComponent();
            //r_IntroForm = new BaseForm(); 
            //Application.Run(r_IntroForm);

            r_SettingsForm = new SettingsDialog();
            //if (r_IntroForm.DialogResult == DialogResult.OK)
            //{
            r_SettingsForm.FormClosing += r_SettingsForm_FormClosing;
            Application.Run(r_SettingsForm); //WHAT IS THE DIFFERENCE BETWEEN THIS TO  r_SettingsForm.ShowDialog();  OK, PROBABLY THAT THIS WAY IT IS THE PARENT?????
            //}
            //else
            //{
            //    r_SettingsForm.DialogResult = DialogResult.None;
            //}

            //r_SettingsForm.ShowDialog();

            //if (r_SettingsForm.DialogResult == DialogResult.OK)
            //{
            //    //this.MaximizeBox = false;
            //    //this.MinimizeBox = false;
            //    //this.FormBorderStyle = FormBorderStyle.FixedSingle;

            //    m_Game.SetBoardBySize(r_SettingsForm.BoardSize);
            //    if (r_SettingsForm.PlayerType == ePlayerType.Computer)
            //    {
            //        m_Game.InitPlayers(r_SettingsForm.PlayerType, r_SettingsForm.Player1Name);
            //    }
            //    else
            //    {
            //        m_Game.InitPlayers(r_SettingsForm.PlayerType, r_SettingsForm.Player1Name, r_SettingsForm.Player2Name);
            //    }

            //    m_Game.SetupNewRound();

            //    //runGame();
            //}
            //else
            //{
            //    this.Close();
            //}
        }

        private void r_SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (r_SettingsForm.DialogResult == DialogResult.OK)
            {
                m_Game.SetBoardBySize(r_SettingsForm.BoardSize);
                if (r_SettingsForm.PlayerType == ePlayerType.Computer)
                {
                    m_Game.InitPlayers(r_SettingsForm.PlayerType, r_SettingsForm.Player1Name);
                }
                else
                {
                    m_Game.InitPlayers(r_SettingsForm.PlayerType, r_SettingsForm.Player1Name, r_SettingsForm.Player2Name);
                }
            }
            else
            {
                this.Close();
            }
        }

        //private void runGame()
        //{
        //    bool quitInput = false;

        //    do
        //    {
        //        m_Game.SetupNewRound();
        //        while (m_Game.CurrentState == eGameState.Running)
        //        {
        //                m_Game.MakeMove(row, col);
        //                m_Game.CheckCurrentState(row, col);

        //        }

        //        if (!quitInput)
        //        {
        //            showStateAndScore();
        //        }

        //        quitInput = askForAnotherRound();
        //    }

        //    while (!quitInput);
        //}

        private void XMixDrix_Load(object sender, EventArgs e)
        {
            m_Game.CurrentPlayerChanged += m_Game_CurrentPlayerChanged;
            m_Game.CurrentStateChangedFromRunning += M_Game_CurrentStateChangedFromRunning;
            initializeBoard();
            setPlayersLabels();
            m_Game.SetupNewRound();
        }

        private void M_Game_CurrentStateChangedFromRunning(eGameState i_NewCurrentState, string i_CurrentPlayerName, int i_Player1Score, int i_Player2Score)
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
                Player1ScoreLabel.Text = i_Player1Score.ToString();
                Player2ScoreLabel.Text = i_Player2Score.ToString();
                m_Game.SetupNewRound();
            }
            else
            {
                this.Close();
            }
        }

        private void initializeBoard()
        {
            tableLayoutPanel1.RowCount = m_Game.Board.Size;
            tableLayoutPanel1.ColumnCount = m_Game.Board.Size;
            this.Size = new Size(m_Game.Board.Size * 80 + 20, m_Game.Board.Size * 80 + 20);
            for (int i = 1; i <= m_Game.Board.Size; i++)
            {
                for (int j = 1; j <= m_Game.Board.Size; j++)
                {
                    IndexedButton currentButton = new IndexedButton(i, j);
                    //currentButton.Text = string.Format($"{i},{j}");
                    currentButton.Name = string.Format($"{i},{j}");
                    //Directly on Form:
                    currentButton.Size = new Size(40, 40);
                    currentButton.MouseClick += CurrentButton_MouseClick;
                    //currentButton.Top = i * 40 + 10;
                    //currentButton.Left = j * 40 + 10;
                    //this.Controls.Add(currentButton);
                    m_Game.Board.CellContentChanged += currentButton.Board_CellContentChanged;
                    //Maybe better using this?
                    this.tableLayoutPanel1.Controls.Add(currentButton);
                }
            }
        }

        private void setPlayersLabels()
        {
            Player1NameLabel.Top = tableLayoutPanel1.Height + 10;
            Player1NameLabel.Left = ClientSize.Width / 8;
            Player1NameLabel.Text = string.Format($"{m_Game.Players[0].PlayerName}:");
            Player1ScoreLabel.Top = Player1NameLabel.Top;
            Player1ScoreLabel.Left = Player1NameLabel.Left + Player1NameLabel.Width + 10;
            //m_Game.Players[0].ScoreChanged += Player1_ScoreChanged;
            Player2NameLabel.Top = Player1NameLabel.Top;
            Player2NameLabel.Left = Player1ScoreLabel.Left + Player1ScoreLabel.Width + 20;
            Player2NameLabel.Text = string.Format($"{m_Game.Players[1].PlayerName}:");
            Player2ScoreLabel.Top = Player1NameLabel.Top;
            Player2ScoreLabel.Left = Player2NameLabel.Left + Player2NameLabel.Width + 10;
            //m_Game.Players[1].ScoreChanged += Player2_ScoreChanged;

            //m_Game.CurrentPlayerChanged += m_Game_AlterCurrentPlayer;
        }

        private void m_Game_CurrentPlayerChanged(int i_NewCurrentPlayerIndex)
        {
            if (i_NewCurrentPlayerIndex == 0)
            {
                Player1NameLabel.Font = new Font(Player1NameLabel.Font, FontStyle.Bold);
                Player1ScoreLabel.Font = new Font(Player1ScoreLabel.Font, FontStyle.Bold);
                Player2NameLabel.Font = new Font(Player2NameLabel.Font, FontStyle.Regular);
                Player2ScoreLabel.Font = new Font(Player2ScoreLabel.Font, FontStyle.Regular);
            }
            else
            {
                Player1NameLabel.Font = new Font(Player1NameLabel.Font, FontStyle.Regular);
                Player1ScoreLabel.Font = new Font(Player1ScoreLabel.Font, FontStyle.Regular);
                Player2NameLabel.Font = new Font(Player2NameLabel.Font, FontStyle.Bold);
                Player2ScoreLabel.Font = new Font(Player2ScoreLabel.Font, FontStyle.Bold);
            }
        }

        //private void Player1_ScoreChanged(int i_Score)
        //{
        //    Player1ScoreLabel.Text = i_Score.ToString();
        //}
        //private void Player2_ScoreChanged(int i_Score)
        //{
        //    Player2ScoreLabel.Text = i_Score.ToString();
        //}

        private void CurrentButton_MouseClick(object sender, MouseEventArgs e)
        {
            int row = (sender as IndexedButton).Row;
            int col = (sender as IndexedButton).Col;
            m_Game.MakeMove(row, col);
            m_Game.CheckCurrentState(row, col);
            if (m_Game.GetCurrentPlayerType() == ePlayerType.Computer)
            {
                m_Game.GetComputerMove(out row, out col);
                m_Game.MakeMove(row, col);
                m_Game.CheckCurrentState(row, col);
            }
            //(sender as IndexedButton).Text = getGameComponentAsText(m_Game.Board.GetCellValue(row, col)); // or m_Game.GetCurrentPlayerSign
            //(sender as IndexedButton).Enabled = false;
        }

        private string getGameComponentAsText(eGameComponent i_Content)
        {
            ePlayerChar returnValue;

            if (i_Content == eGameComponent.O)
            {
                returnValue = ePlayerChar.O;
            }
            else if (i_Content == eGameComponent.X)
            {
                returnValue = ePlayerChar.X;
            }
            else
            {
                returnValue = ePlayerChar.Empty;
            }

            return ((char)returnValue).ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Player1Label_Click(object sender, EventArgs e)
        {

        }

        private void Player2ScoreLabel_Click(object sender, EventArgs e)
        {

        }

        private void Player1ScoreLabel_Click(object sender, EventArgs e)
        {

        }
    }

    public class IndexedButton : Button
    {
        private readonly int r_Row;
        private readonly int r_Col;

        public IndexedButton(int i_Row, int i_Col)
        {
            this.TabStop = false;
            r_Row = i_Row;
            r_Col = i_Col;
        }

        public int Row
        {
            get
            {
                return r_Row;
            }
        }

        public int Col
        {
            get
            {
                return r_Col;
            }
        }

        public void Board_CellContentChanged(int i_Row, int i_Col, eGameComponent i_CellContent)
        {
            if (r_Row == i_Row && r_Col == i_Col)
            {
                this.Text = (i_CellContent == eGameComponent.Empty) ? " " : i_CellContent.ToString();
                this.Enabled = i_CellContent == eGameComponent.Empty;
            }
        }
    }
}
