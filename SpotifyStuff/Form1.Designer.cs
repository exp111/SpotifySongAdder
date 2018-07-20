namespace SpotifyStuff
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.playlistListbox = new System.Windows.Forms.ListBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusInfoLabel = new System.Windows.Forms.Label();
            this.refreshPlaylistsButton = new System.Windows.Forms.Button();
            this.addSongButton = new System.Windows.Forms.Button();
            this.addSongCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchView = new System.Windows.Forms.ListView();
            this.searchName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchArtist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchAlbum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchLength = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.addSongCount)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_ClickAsync);
            // 
            // playlistListbox
            // 
            this.playlistListbox.DisplayMember = "Name";
            this.playlistListbox.FormattingEnabled = true;
            this.playlistListbox.Location = new System.Drawing.Point(33, 403);
            this.playlistListbox.Name = "playlistListbox";
            this.playlistListbox.Size = new System.Drawing.Size(677, 147);
            this.playlistListbox.TabIndex = 3;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(140, 17);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(80, 13);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "Current Status: ";
            // 
            // statusInfoLabel
            // 
            this.statusInfoLabel.AutoSize = true;
            this.statusInfoLabel.ForeColor = System.Drawing.Color.Red;
            this.statusInfoLabel.Location = new System.Drawing.Point(226, 17);
            this.statusInfoLabel.Name = "statusInfoLabel";
            this.statusInfoLabel.Size = new System.Drawing.Size(79, 13);
            this.statusInfoLabel.TabIndex = 5;
            this.statusInfoLabel.Text = "Not Connected";
            // 
            // refreshPlaylistsButton
            // 
            this.refreshPlaylistsButton.Location = new System.Drawing.Point(33, 556);
            this.refreshPlaylistsButton.Name = "refreshPlaylistsButton";
            this.refreshPlaylistsButton.Size = new System.Drawing.Size(75, 28);
            this.refreshPlaylistsButton.TabIndex = 6;
            this.refreshPlaylistsButton.Text = "Refresh";
            this.refreshPlaylistsButton.UseVisualStyleBackColor = true;
            this.refreshPlaylistsButton.Click += new System.EventHandler(this.refreshPlaylistsButton_Click);
            // 
            // addSongButton
            // 
            this.addSongButton.Location = new System.Drawing.Point(560, 556);
            this.addSongButton.Name = "addSongButton";
            this.addSongButton.Size = new System.Drawing.Size(150, 28);
            this.addSongButton.TabIndex = 7;
            this.addSongButton.Text = "Add Song";
            this.addSongButton.UseVisualStyleBackColor = true;
            this.addSongButton.Click += new System.EventHandler(this.addSongButton_Click);
            // 
            // addSongCount
            // 
            this.addSongCount.Location = new System.Drawing.Point(481, 562);
            this.addSongCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.addSongCount.Name = "addSongCount";
            this.addSongCount.Size = new System.Drawing.Size(73, 20);
            this.addSongCount.TabIndex = 8;
            this.addSongCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Playlists:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 564);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Count:";
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(33, 42);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(587, 20);
            this.searchInput.TabIndex = 12;
            this.searchInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchInput_KeyPress);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(635, 41);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 22);
            this.searchButton.TabIndex = 13;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchView
            // 
            this.searchView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.searchName,
            this.searchArtist,
            this.searchAlbum,
            this.searchLength});
            this.searchView.FullRowSelect = true;
            this.searchView.HideSelection = false;
            this.searchView.Location = new System.Drawing.Point(33, 69);
            this.searchView.MultiSelect = false;
            this.searchView.Name = "searchView";
            this.searchView.Size = new System.Drawing.Size(677, 306);
            this.searchView.TabIndex = 14;
            this.searchView.UseCompatibleStateImageBehavior = false;
            this.searchView.View = System.Windows.Forms.View.Details;
            // 
            // searchName
            // 
            this.searchName.Text = "Name";
            this.searchName.Width = 182;
            // 
            // searchArtist
            // 
            this.searchArtist.Text = "Artist";
            this.searchArtist.Width = 201;
            // 
            // searchAlbum
            // 
            this.searchAlbum.Text = "Album";
            this.searchAlbum.Width = 209;
            // 
            // searchLength
            // 
            this.searchLength.Text = "Length";
            this.searchLength.Width = 81;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 601);
            this.Controls.Add(this.searchView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addSongCount);
            this.Controls.Add(this.addSongButton);
            this.Controls.Add(this.refreshPlaylistsButton);
            this.Controls.Add(this.statusInfoLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.playlistListbox);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Spotify Song Adder";
            ((System.ComponentModel.ISupportInitialize)(this.addSongCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ListBox playlistListbox;
		private System.Windows.Forms.Label statusLabel;
		private System.Windows.Forms.Label statusInfoLabel;
		private System.Windows.Forms.Button refreshPlaylistsButton;
		private System.Windows.Forms.Button addSongButton;
		private System.Windows.Forms.NumericUpDown addSongCount;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox searchInput;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.ListView searchView;
		private System.Windows.Forms.ColumnHeader searchName;
		private System.Windows.Forms.ColumnHeader searchArtist;
		private System.Windows.Forms.ColumnHeader searchAlbum;
		private System.Windows.Forms.ColumnHeader searchLength;
	}
}

