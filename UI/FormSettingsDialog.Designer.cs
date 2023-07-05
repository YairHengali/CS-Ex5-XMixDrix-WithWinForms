
namespace UI
{
    partial class FormSettingsDialog
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
            this.playersTitleLabel = new System.Windows.Forms.Label();
            this.player1Label = new System.Windows.Forms.Label();
            this.checkBoxPlayer2 = new System.Windows.Forms.CheckBox();
            this.textBoxPlayer1 = new System.Windows.Forms.TextBox();
            this.textBoxPlayer2 = new System.Windows.Forms.TextBox();
            this.boardSizeLabel = new System.Windows.Forms.Label();
            this.numericUpDownRows = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCols = new System.Windows.Forms.NumericUpDown();
            this.rowsLabel = new System.Windows.Forms.Label();
            this.colsLabel = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCols)).BeginInit();
            this.SuspendLayout();
            // 
            // playersTitleLabel
            // 
            this.playersTitleLabel.AutoSize = true;
            this.playersTitleLabel.Location = new System.Drawing.Point(24, 29);
            this.playersTitleLabel.Name = "playersTitleLabel";
            this.playersTitleLabel.Size = new System.Drawing.Size(64, 20);
            this.playersTitleLabel.TabIndex = 0;
            this.playersTitleLabel.Text = "Players:";
            // 
            // player1Label
            // 
            this.player1Label.AutoSize = true;
            this.player1Label.Location = new System.Drawing.Point(44, 85);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(69, 20);
            this.player1Label.TabIndex = 1;
            this.player1Label.Text = "Player 1:";
            // 
            // checkBoxPlayer2
            // 
            this.checkBoxPlayer2.AutoSize = true;
            this.checkBoxPlayer2.Location = new System.Drawing.Point(48, 134);
            this.checkBoxPlayer2.Name = "checkBoxPlayer2";
            this.checkBoxPlayer2.Size = new System.Drawing.Size(95, 24);
            this.checkBoxPlayer2.TabIndex = 3;
            this.checkBoxPlayer2.Text = "Player 2:";
            this.checkBoxPlayer2.UseVisualStyleBackColor = true;
            this.checkBoxPlayer2.CheckedChanged += new System.EventHandler(this.checkBoxPlayer2_CheckedChanged);
            // 
            // textBoxPlayer1
            // 
            this.textBoxPlayer1.Location = new System.Drawing.Point(172, 80);
            this.textBoxPlayer1.Name = "textBoxPlayer1";
            this.textBoxPlayer1.Size = new System.Drawing.Size(168, 26);
            this.textBoxPlayer1.TabIndex = 2;
            // 
            // textBoxPlayer2
            // 
            this.textBoxPlayer2.Enabled = false;
            this.textBoxPlayer2.Location = new System.Drawing.Point(172, 131);
            this.textBoxPlayer2.Name = "textBoxPlayer2";
            this.textBoxPlayer2.Size = new System.Drawing.Size(168, 26);
            this.textBoxPlayer2.TabIndex = 4;
            this.textBoxPlayer2.Text = "[Computer]";
            this.textBoxPlayer2.EnabledChanged += new System.EventHandler(this.textBoxPlayer2_EnabledChanged);
            // 
            // boardSizeLabel
            // 
            this.boardSizeLabel.AutoSize = true;
            this.boardSizeLabel.Location = new System.Drawing.Point(24, 206);
            this.boardSizeLabel.Name = "boardSizeLabel";
            this.boardSizeLabel.Size = new System.Drawing.Size(91, 20);
            this.boardSizeLabel.TabIndex = 0;
            this.boardSizeLabel.Text = "Board Size:";
            // 
            // numericUpDownRows
            // 
            this.numericUpDownRows.Location = new System.Drawing.Point(105, 254);
            this.numericUpDownRows.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownRows.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownRows.Name = "numericUpDownRows";
            this.numericUpDownRows.Size = new System.Drawing.Size(60, 26);
            this.numericUpDownRows.TabIndex = 6;
            this.numericUpDownRows.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownRows.ValueChanged += new System.EventHandler(this.numericUpDownRows_ValueChanged);
            // 
            // numericUpDownCols
            // 
            this.numericUpDownCols.Location = new System.Drawing.Point(282, 254);
            this.numericUpDownCols.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCols.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownCols.Name = "numericUpDownCols";
            this.numericUpDownCols.Size = new System.Drawing.Size(60, 26);
            this.numericUpDownCols.TabIndex = 8;
            this.numericUpDownCols.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownCols.ValueChanged += new System.EventHandler(this.numericUpDownCols_ValueChanged);
            // 
            // rowsLabel
            // 
            this.rowsLabel.AutoSize = true;
            this.rowsLabel.Location = new System.Drawing.Point(44, 257);
            this.rowsLabel.Name = "rowsLabel";
            this.rowsLabel.Size = new System.Drawing.Size(53, 20);
            this.rowsLabel.TabIndex = 5;
            this.rowsLabel.Text = "Rows:";
            // 
            // colsLabel
            // 
            this.colsLabel.AutoSize = true;
            this.colsLabel.Location = new System.Drawing.Point(231, 257);
            this.colsLabel.Name = "colsLabel";
            this.colsLabel.Size = new System.Drawing.Size(44, 20);
            this.colsLabel.TabIndex = 7;
            this.colsLabel.Text = "Cols:";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(78, 312);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(232, 43);
            this.buttonStart.TabIndex = 9;
            this.buttonStart.Text = "Start!";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // FormSettingsDialog
            // 
            this.AcceptButton = this.buttonStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 394);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.numericUpDownCols);
            this.Controls.Add(this.numericUpDownRows);
            this.Controls.Add(this.textBoxPlayer2);
            this.Controls.Add(this.textBoxPlayer1);
            this.Controls.Add(this.checkBoxPlayer2);
            this.Controls.Add(this.colsLabel);
            this.Controls.Add(this.rowsLabel);
            this.Controls.Add(this.boardSizeLabel);
            this.Controls.Add(this.player1Label);
            this.Controls.Add(this.playersTitleLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettingsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Settings";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCols)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playersTitleLabel;
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.CheckBox checkBoxPlayer2;
        private System.Windows.Forms.TextBox textBoxPlayer1;
        private System.Windows.Forms.TextBox textBoxPlayer2;
        private System.Windows.Forms.Label boardSizeLabel;
        private System.Windows.Forms.NumericUpDown numericUpDownRows;
        private System.Windows.Forms.NumericUpDown numericUpDownCols;
        private System.Windows.Forms.Label rowsLabel;
        private System.Windows.Forms.Label colsLabel;
        private System.Windows.Forms.Button buttonStart;
    }
}