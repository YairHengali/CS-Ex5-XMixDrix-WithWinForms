using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI
{
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
    }
}
