using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;
using SpotifyAPI.Web.Enums;
using SpotifyAPI.Web.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotifyStuff
{
	public partial class Form1 : Form
	{
		private SpotifyWebAPI _spotifyWebAPI;
		private PrivateProfile _profile;
		private List<SimplePlaylist> _playlists;
		public Form1()
		{
			InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Making the Window a fixed size
            // Removing the Maximize and Minimize Buttons, because the shit is not scaled...
            this.MaximizeBox = false;
            this.MinimizeBox = false;
		}

		private async void button1_ClickAsync(object sender, EventArgs e)
		{

			WebAPIFactory webApiFactory = new WebAPIFactory(
										   "http://localhost",
										   8000,
										   "47c0cc6d128c4eb587f7a85a398d0a96",
										   Scope.PlaylistReadCollaborative | Scope.PlaylistReadPrivate |
										   Scope.UserReadPrivate |
										   Scope.PlaylistModifyPrivate | Scope.PlaylistModifyPublic,
										   TimeSpan.FromSeconds(20));

			try
			{
				//This will open the user's browser and returns once
				//the user is authorized.
				_spotifyWebAPI = await webApiFactory.GetWebApi();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			if (_spotifyWebAPI == null)
				return;

			//Change Status Label
			statusInfoLabel.Text = "Connected";
			statusInfoLabel.ForeColor = Color.Green;

			//Get Profile & Playlists
			_profile = _spotifyWebAPI.GetPrivateProfile();
			GetPlaylists();
		}

		private void GetPlaylists()
		{
			if (_spotifyWebAPI == null || _profile == null)
				return;

			Paging<SimplePlaylist> playlists = _spotifyWebAPI.GetUserPlaylists(_profile.Id);
			List<SimplePlaylist> list = playlists.Items.ToList();

			while (playlists.Next != null)
			{
				playlists = _spotifyWebAPI.GetUserPlaylists(_profile.Id, 20, playlists.Offset + playlists.Limit);
				list.AddRange(playlists.Items);
			}

			_playlists = list;
			playlistListbox.DataSource = _playlists;
		}

		private void refreshPlaylistsButton_Click(object sender, EventArgs e)
		{
			GetPlaylists();
		}

		private void addSongButton_Click(object sender, EventArgs e)
		{
			if (_spotifyWebAPI == null || _profile == null)
				return;

			if (searchView.SelectedItems.Count == 0)
				return;
			ListViewItem selectedSong = searchView.SelectedItems[0];
			if (selectedSong == null)
				return;
			string songURL = selectedSong.Tag as string;
			if (songURL == "")
				return;

			SimplePlaylist selectedPlaylist = (SimplePlaylist)playlistListbox.SelectedItem;
			List<string> tracks = new List<string>();
			for (int i = 0; i < addSongCount.Value; i++)
				tracks.Add(songURL);
			ErrorResponse error = _spotifyWebAPI.AddPlaylistTracks(_profile.Id, selectedPlaylist.Id, tracks);
		}

		private void searchButton_Click(object sender, EventArgs e)
		{
			if (_spotifyWebAPI == null)
				return;

			string searchText = searchInput.Text;
			if (searchText == "")
				return;

            // Clearing the list on new Searches 
            foreach (ListViewItem item in searchView.Items)
            {
                searchView.Items.Remove(item);
            }

			SearchItem searchResult = _spotifyWebAPI.SearchItems(searchText, SearchType.All);
			var result = searchResult.Tracks.Items.ToList();
			foreach (var song in result)
			{
				ListViewItem item = new ListViewItem(new[] { song.Name, song.Artists.FirstOrDefault().Name, song.Album.Name, MsToM(song.DurationMs) });
				item.Tag = song.Uri;
				searchView.Items.Add(item);
			}
		}

		public static String MsToM(double miliseconds)
		{
			StringBuilder message = new StringBuilder();

			int years = (int)(miliseconds / 1000 / 60 / 60 / 24 / 365);
			int days = (int)(miliseconds / 1000 / 60 / 60 / 24 % 365);
			int hours = (int)(miliseconds / 1000 / 60 / 60 % 24);
			int minutes = (int)(miliseconds / 1000 / 60 % 60);
			int seconds = (int)(miliseconds / 1000 % 60);

			message.Append(years > 0 ? years + "a " : "");
			message.Append(days > 0 ? days + "d " : "");
			message.Append(hours > 0 ? hours + "h " : "");
			message.Append(minutes > 0 ? minutes + "m " : "");
			message.Append(seconds + "s");

			return message.ToString();
		}
	}
}
