using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logic;


namespace UI
{
    public partial class SettingsDialog : Form
    {
        public SettingsDialog()
        {
            InitializeComponent();
        }
        public string Player1Name
        {
            get
            {
                return textBoxPlayer1.Text;
            }
        }
        public string Player2Name
        {
            get
            {
                return textBoxPlayer2.Text;
            }
        }

        public ePlayerType PlayerType
        {
            get
            {
                ePlayerType resultType;
                if (checkBoxPlayer2.Checked)
                    resultType = ePlayerType.Human;
                else
                    resultType = ePlayerType.Computer;

                return resultType;
            }
        }
        public int BoardSize
        {
            get
            {
                return int.Parse(numericUpDownCols.Value.ToString());
            }
        }
        private void checkBoxPlayer2_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPlayer2.Enabled = checkBoxPlayer2.Checked;
        }
        private void textBoxPlayer2_EnabledChanged(object sender, EventArgs e)
        {
            if (textBoxPlayer2.Enabled == true)
            {
                textBoxPlayer2.Text = "";
            }
            else
            {
                textBoxPlayer2.Text = "[Computer]";
            }
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void numericUpDownRows_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownCols.Value = numericUpDownRows.Value;
        }
        private void numericUpDownCols_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownRows.Value = numericUpDownCols.Value;
        }
    }
}
