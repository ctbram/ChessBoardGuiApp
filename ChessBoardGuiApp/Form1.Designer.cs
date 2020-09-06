namespace ChessBoardGuiApp
{
    partial class frmChessBoardGUI
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
            this.lblInst = new System.Windows.Forms.Label();
            this.cmbPieces = new System.Windows.Forms.ComboBox();
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblInst
            // 
            this.lblInst.AutoSize = true;
            this.lblInst.Location = new System.Drawing.Point(12, 9);
            this.lblInst.Name = "lblInst";
            this.lblInst.Size = new System.Drawing.Size(484, 13);
            this.lblInst.TabIndex = 0;
            this.lblInst.Text = "Select a piece from the dropdown box and click a square. I will show all valid mo" +
    "ves from that square.";
            // 
            // cmbPieces
            // 
            this.cmbPieces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPieces.FormattingEnabled = true;
            this.cmbPieces.Items.AddRange(new object[] {
            "King",
            "Queen",
            "Bishop",
            "Knight",
            "Rook"});
            this.cmbPieces.Location = new System.Drawing.Point(502, 6);
            this.cmbPieces.Name = "cmbPieces";
            this.cmbPieces.Size = new System.Drawing.Size(121, 21);
            this.cmbPieces.TabIndex = 1;
            // 
            // pnlBoard
            // 
            this.pnlBoard.Location = new System.Drawing.Point(15, 33);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(600, 600);
            this.pnlBoard.TabIndex = 2;
            // 
            // frmChessBoardGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 648);
            this.Controls.Add(this.pnlBoard);
            this.Controls.Add(this.cmbPieces);
            this.Controls.Add(this.lblInst);
            this.Name = "frmChessBoardGUI";
            this.Text = "Legal Chess Piece Moves";
            this.Load += new System.EventHandler(this.frmChessBoardGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInst;
        private System.Windows.Forms.ComboBox cmbPieces;
        private System.Windows.Forms.Panel pnlBoard;
    }
}

