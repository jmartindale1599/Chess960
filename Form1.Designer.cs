namespace ChessKing
{
	partial class frmChessKing
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
			//
			// Initial creation of interactive components
			//
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChessKing));
			this.btn2Player = new System.Windows.Forms.Button();
			this.bnt1Player = new System.Windows.Forms.Button();
			this.bntQuit = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.switch960 = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.depthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.onlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.offlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn2Player
			// 
			this.btn2Player.BackColor = System.Drawing.Color.Maroon;
			this.btn2Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn2Player.FlatAppearance.BorderColor = System.Drawing.Color.LightYellow;
			this.btn2Player.FlatAppearance.BorderSize = 2;
			this.btn2Player.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn2Player.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn2Player.ForeColor = System.Drawing.SystemColors.Control;
			this.btn2Player.Location = new System.Drawing.Point(683, 271);
			this.btn2Player.Name = "btn2Player";
			this.btn2Player.Size = new System.Drawing.Size(75, 25);
			this.btn2Player.TabIndex = 0;
			this.btn2Player.Text = "2 Player";
			this.btn2Player.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
			this.btn2Player.UseVisualStyleBackColor = false;
			this.btn2Player.Click += new System.EventHandler(this.btn2Player_Click);
			// 
			// bnt1Player
			// 
			this.bnt1Player.BackColor = System.Drawing.Color.Orange;
			this.bnt1Player.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.bnt1Player.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bnt1Player.ForeColor = System.Drawing.Color.Black;
			this.bnt1Player.Location = new System.Drawing.Point(683, 311);
			this.bnt1Player.Name = "bnt1Player";
			this.bnt1Player.Size = new System.Drawing.Size(75, 23);
			this.bnt1Player.TabIndex = 1;
			this.bnt1Player.Text = "1 Player";
			this.bnt1Player.UseVisualStyleBackColor = false;
			this.bnt1Player.Click += new System.EventHandler(this.bnt1Player_Click);
            // 
            // switch960
            // 
            this.switch960.BackColor = System.Drawing.Color.MintCream;
            this.switch960.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2Player.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btn2Player.FlatAppearance.BorderSize = 2;
            this.switch960.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switch960.ForeColor = System.Drawing.Color.Black;
            this.switch960.Location = new System.Drawing.Point(683, 351);
            this.switch960.Name = "switch960";
            this.switch960.Size = new System.Drawing.Size(75, 23);
            this.switch960.TabIndex = 4;
            this.switch960.Text = "960?";
            this.switch960.UseVisualStyleBackColor = false;
            this.switch960.Click += new System.EventHandler(this.cheSwitch_Mode);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DarkGreen;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2Player.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btn2Player.FlatAppearance.BorderSize = 2;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Lime;
            this.btnReset.Location = new System.Drawing.Point(683, 391);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.resetGame);
            // 
            // bntQuit
            // 
            this.bntQuit.BackColor = System.Drawing.Color.OliveDrab;
			this.bntQuit.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.bntQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.bntQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bntQuit.ForeColor = System.Drawing.Color.LavenderBlush;
			this.bntQuit.Location = new System.Drawing.Point(683, 431);
			this.bntQuit.Name = "bntQuit";
			this.bntQuit.Size = new System.Drawing.Size(75, 23);
			this.bntQuit.TabIndex = 2;
			this.bntQuit.Text = "Quit";
			this.bntQuit.UseVisualStyleBackColor = false;
			this.bntQuit.Click += new System.EventHandler(this.bntQuit_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem,
            this.helpToolStripMenuItem1,
            this.aboutToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 28);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
			this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depthToolStripMenuItem});
			this.optionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.optionToolStripMenuItem.ForeColor = System.Drawing.Color.Honeydew;
			this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
			this.optionToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
			this.optionToolStripMenuItem.Text = "Option";
			// 
			// depthToolStripMenuItem
			// 
			this.depthToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
			this.depthToolStripMenuItem.Name = "depthToolStripMenuItem";
			this.depthToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
			this.depthToolStripMenuItem.Text = "Depth";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(87, 24);
			this.toolStripMenuItem2.Text = "1";
			this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(87, 24);
			this.toolStripMenuItem3.Text = "2";
			this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(87, 24);
			this.toolStripMenuItem4.Text = "3";
			this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(87, 24);
			this.toolStripMenuItem5.Text = "4";
			this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
			// 
			// toolStripMenuItem6
			// 
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new System.Drawing.Size(87, 24);
			this.toolStripMenuItem6.Text = "5";
			this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
			// 
			// helpToolStripMenuItem1
			// 
			this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onlineToolStripMenuItem,
            this.offlineToolStripMenuItem});
			this.helpToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.helpToolStripMenuItem1.ForeColor = System.Drawing.Color.Honeydew;
			this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
			this.helpToolStripMenuItem1.Size = new System.Drawing.Size(57, 24);
			this.helpToolStripMenuItem1.Text = "Help";
			// 
			// onlineToolStripMenuItem
			// 
			this.onlineToolStripMenuItem.Name = "onlineToolStripMenuItem";
			this.onlineToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
			this.onlineToolStripMenuItem.Text = "Online";
			this.onlineToolStripMenuItem.Click += new System.EventHandler(this.onlineToolStripMenuItem_Click);
			// 
			// offlineToolStripMenuItem
			// 
			this.offlineToolStripMenuItem.Name = "offlineToolStripMenuItem";
			this.offlineToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
			this.offlineToolStripMenuItem.Text = "Offline";
			this.offlineToolStripMenuItem.Click += new System.EventHandler(this.offlineToolStripMenuItem_Click);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.Honeydew;
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// frmChessKing
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.BackgroundImage = global::ChessKing.Properties.Resources.B1;
			this.ClientSize = new System.Drawing.Size(800, 610);
			this.Controls.Add(this.bntQuit);
			this.Controls.Add(this.bnt1Player);
			this.Controls.Add(this.btn2Player);
			this.Controls.Add(this.switch960);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.menuStrip1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmChessKing";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Chess King";
			this.Load += new System.EventHandler(this.frmChessKing_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn2Player;
		private System.Windows.Forms.Button bnt1Player;
		private System.Windows.Forms.Button bntQuit;
		private System.Windows.Forms.Button switch960;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem depthToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem onlineToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem offlineToolStripMenuItem;
	}
}

