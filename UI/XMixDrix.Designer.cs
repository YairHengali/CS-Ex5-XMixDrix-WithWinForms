
namespace UI
{
    partial class XMixDrix
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Player1NameLabel = new System.Windows.Forms.Label();
            this.Player2NameLabel = new System.Windows.Forms.Label();
            this.Player1ScoreLabel = new System.Windows.Forms.Label();
            this.Player2ScoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 15);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Player1NameLabel
            // 
            this.Player1NameLabel.AutoSize = true;
            this.Player1NameLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Player1NameLabel.Location = new System.Drawing.Point(74, 529);
            this.Player1NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Player1NameLabel.Name = "Player1NameLabel";
            this.Player1NameLabel.Size = new System.Drawing.Size(73, 20);
            this.Player1NameLabel.TabIndex = 1;
            this.Player1NameLabel.Text = "Player 1: ";
            this.Player1NameLabel.Click += new System.EventHandler(this.Player1Label_Click);
            // 
            // Player2NameLabel
            // 
            this.Player2NameLabel.AutoSize = true;
            this.Player2NameLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Player2NameLabel.Location = new System.Drawing.Point(237, 529);
            this.Player2NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Player2NameLabel.Name = "Player2NameLabel";
            this.Player2NameLabel.Size = new System.Drawing.Size(87, 20);
            this.Player2NameLabel.TabIndex = 2;
            this.Player2NameLabel.Text = "Computer: ";
            this.Player2NameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Player1ScoreLabel
            // 
            this.Player1ScoreLabel.AutoSize = true;
            this.Player1ScoreLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Player1ScoreLabel.Location = new System.Drawing.Point(159, 529);
            this.Player1ScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Player1ScoreLabel.Name = "Player1ScoreLabel";
            this.Player1ScoreLabel.Size = new System.Drawing.Size(18, 20);
            this.Player1ScoreLabel.TabIndex = 3;
            this.Player1ScoreLabel.Text = "0";
            this.Player1ScoreLabel.Click += new System.EventHandler(this.Player1ScoreLabel_Click);
            // 
            // Player2ScoreLabel
            // 
            this.Player2ScoreLabel.AutoSize = true;
            this.Player2ScoreLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Player2ScoreLabel.Location = new System.Drawing.Point(333, 529);
            this.Player2ScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Player2ScoreLabel.Name = "Player2ScoreLabel";
            this.Player2ScoreLabel.Size = new System.Drawing.Size(18, 20);
            this.Player2ScoreLabel.TabIndex = 4;
            this.Player2ScoreLabel.Text = "0";
            this.Player2ScoreLabel.Click += new System.EventHandler(this.Player2ScoreLabel_Click);
            // 
            // XMixDrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(900, 563);
            this.Controls.Add(this.Player2ScoreLabel);
            this.Controls.Add(this.Player1ScoreLabel);
            this.Controls.Add(this.Player2NameLabel);
            this.Controls.Add(this.Player1NameLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XMixDrix";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XMixDrix";
            this.Load += new System.EventHandler(this.XMixDrix_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Player1NameLabel;
        private System.Windows.Forms.Label Player2NameLabel;
        private System.Windows.Forms.Label Player1ScoreLabel;
        private System.Windows.Forms.Label Player2ScoreLabel;
    }
}