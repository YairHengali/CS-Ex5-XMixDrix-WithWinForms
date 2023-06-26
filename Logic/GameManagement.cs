namespace Logic
{
    public delegate void CurrentPlayerChangedDelegate(int i_NewCurrentPlayerIndex);

    public class GameManagement
    {
        private Player[] m_Players = new Player[2];
        private Player m_CurrentPlayer = null;
        private GameBoard m_Board = null;
        private eGameState m_CurrentState = eGameState.Running;
        public event CurrentPlayerChangedDelegate AlterCurrentPlayer;

        public Player[] Players
        {
            get
            {
                return m_Players;
            }
        }

        public eGameState CurrentState
        {
            get
            {
                return m_CurrentState;
            }
        }

        public GameBoard Board
        {
            get
            {
                return m_Board;
            }
        }

        public eGameComponent GetCurrentPlayerSign()
        {
            return m_CurrentPlayer.PlayerSign;
        }

        public void SetBoardBySize(int i_Size)
        {
            m_Board = new GameBoard(i_Size);
        }

        public void InitPlayers(ePlayerType i_GameStyle, string i_Player1Name, string i_Player2Name = "Computer")
        {
            m_Players[0] = new Player(ePlayerType.Human, eGameComponent.X, i_Player1Name);
            m_Players[1] = new Player(i_GameStyle, eGameComponent.O, i_Player2Name);
        }

        public bool IsValidMove(int i_Row, int i_Col)
        {
            return m_Board.IsValidCell(i_Row, i_Col) && (m_Board.GetCellValue(i_Row, i_Col) == eGameComponent.Empty);
        }

        public void MakeMove(int i_Row, int i_Col)
        {
            m_Board.SetCellValue(i_Row, i_Col, m_CurrentPlayer.PlayerSign);
            alterCurrentPlayer();
        }

        private void alterCurrentPlayer()
        {
            if (m_CurrentPlayer == m_Players[0])
            {
                m_CurrentPlayer = m_Players[1];
                OnCurrentPlayerChanged(1);
            }
            else
            {
                m_CurrentPlayer = m_Players[0];
                OnCurrentPlayerChanged(0);
            }
        }

        protected virtual void OnCurrentPlayerChanged(int i_NewCurrentPlayerIndex)
        {
            if (AlterCurrentPlayer != null)
            {
                AlterCurrentPlayer.Invoke(i_NewCurrentPlayerIndex);
            }
        }

        public void CheckCurrentState(int i_Row, int i_Col)
        {
            if (m_Board.IsThereSequance(i_Row, i_Col))
            {
                m_CurrentState = eGameState.DecidedWinner;
                m_CurrentPlayer.Score++;
            }
            else if (m_Board.IsFilled())
            {
                m_CurrentState = eGameState.DecidedTie;
            }
        }

        public ePlayerType GetCurrentPlayerType()
        {
            return m_CurrentPlayer.PlayerType;
        }

        public void GetComputerMove(out int o_Row, out int o_Col)
        {
            m_Board.GenerateEmptyCell(out o_Row, out o_Col);
        }

        public void SetupNewRound()
        {
            m_Board.MakeEmpty();
            m_CurrentPlayer = m_Players[0];
            OnCurrentPlayerChanged(0);
            m_CurrentState = eGameState.Running;
        }
    }
}
