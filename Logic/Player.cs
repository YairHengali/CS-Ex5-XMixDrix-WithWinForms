namespace Logic
{
    public class Player
    {
        private readonly ePlayerType r_PlayerType;
        private readonly eGameComponent r_PlayerSign;
        private int m_Score = 0;
        private readonly string r_PlayerName;

        public Player(ePlayerType i_PlayerType, eGameComponent i_PlayerSign, string i_PlayerName)
        {
            r_PlayerType = i_PlayerType;
            r_PlayerSign = i_PlayerSign;
            r_PlayerName = i_PlayerName;
        }

        public ePlayerType PlayerType
        {
            get
            {
                return r_PlayerType;
            }
        }

        public eGameComponent PlayerSign
        {
            get
            {
                return r_PlayerSign;
            }
        }

        public int Score
        {
            get
            {
                return m_Score;
            }

            set
            {
                if (value > 0)
                {
                    m_Score = value;
                }
            }
        }

        public string PlayerName
        {
            get
            {
                return r_PlayerName;
            }
        }
    }
}