
namespace UI
{
    partial class FormXMixDrix
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
            this.tableLayoutPanelOfButtons = new System.Windows.Forms.TableLayoutPanel();
            this.player1NameLabel = new System.Windows.Forms.Label();
            this.player2NameLabel = new System.Windows.Forms.Label();
            this.player1ScoreLabel = new System.Windows.Forms.Label();
            this.player2ScoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tableLayoutPanelOfButtons
            // 
            this.tableLayoutPanelOfButtons.AutoSize = true;
            this.tableLayoutPanelOfButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelOfButtons.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelOfButtons.ColumnCount = 2;
            this.tableLayoutPanelOfButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelOfButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelOfButtons.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanelOfButtons.Location = new System.Drawing.Point(15, 15);
            this.tableLayoutPanelOfButtons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanelOfButtons.Name = "tableLayoutPanelOfButtons";
            this.tableLayoutPanelOfButtons.RowCount = 2;
            this.tableLayoutPanelOfButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelOfButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelOfButtons.Size = new System.Drawing.Size(0, 0);
            this.tableLayoutPanelOfButtons.TabIndex = 0;
            // 
            // player1NameLabel
            // 
            this.player1NameLabel.AutoSize = true;
            this.player1NameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.player1NameLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.player1NameLabel.Location = new System.Drawing.Point(74, 529);
            this.player1NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player1NameLabel.Name = "player1NameLabel";
            this.player1NameLabel.Size = new System.Drawing.Size(73, 20);
            this.player1NameLabel.TabIndex = 1;
            this.player1NameLabel.Text = "Player 1: ";
            // 
            // player2NameLabel
            // 
            this.player2NameLabel.AutoSize = true;
            this.player2NameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.player2NameLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.player2NameLabel.Location = new System.Drawing.Point(237, 529);
            this.player2NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player2NameLabel.Name = "player2NameLabel";
            this.player2NameLabel.Size = new System.Drawing.Size(87, 20);
            this.player2NameLabel.TabIndex = 2;
            this.player2NameLabel.Text = "Computer: ";
            // 
            // player1ScoreLabel
            // 
            this.player1ScoreLabel.AutoSize = true;
            this.player1ScoreLabel.BackColor = System.Drawing.SystemColors.Control;
            this.player1ScoreLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.player1ScoreLabel.Location = new System.Drawing.Point(159, 529);
            this.player1ScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player1ScoreLabel.Name = "player1ScoreLabel";
            this.player1ScoreLabel.Size = new System.Drawing.Size(18, 20);
            this.player1ScoreLabel.TabIndex = 3;
            this.player1ScoreLabel.Text = "0";
            // 
            // player2ScoreLabel
            // 
            this.player2ScoreLabel.AutoSize = true;
            this.player2ScoreLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.player2ScoreLabel.Location = new System.Drawing.Point(333, 529);
            this.player2ScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player2ScoreLabel.Name = "player2ScoreLabel";
            this.player2ScoreLabel.Size = new System.Drawing.Size(18, 20);
            this.player2ScoreLabel.TabIndex = 4;
            this.player2ScoreLabel.Text = "0";
            // 
            // FormXMixDrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(415, 560);
            this.Controls.Add(this.player2ScoreLabel);
            this.Controls.Add(this.player1ScoreLabel);
            this.Controls.Add(this.player2NameLabel);
            this.Controls.Add(this.player1NameLabel);
            this.Controls.Add(this.tableLayoutPanelOfButtons);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormXMixDrix";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XMixDrix";
            this.Load += new System.EventHandler(this.xMixDrix_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelOfButtons;
        private System.Windows.Forms.Label player1NameLabel;
        private System.Windows.Forms.Label player2NameLabel;
        private System.Windows.Forms.Label player1ScoreLabel;
        private System.Windows.Forms.Label player2ScoreLabel;
    }
}