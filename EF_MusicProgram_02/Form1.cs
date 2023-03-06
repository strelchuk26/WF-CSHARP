using EF_MusicProgram.Entities;
using Microsoft.EntityFrameworkCore;

namespace EF_MusicProgram
{

	// Трішки переробив структуру об'єктів, мені так зручніше.

	public partial class Form1 : Form
	{
		MusicDbContext db = new MusicDbContext();
		List<Playlist> playlists = new List<Playlist>();
		List<Track> tracks = new List<Track>();

		public Form1()
		{
			InitializeComponent();
			FillPlaylistList();
			UpdatePlaylistList();
		}

		private void FillPlaylistList()
		{
			foreach (var p in db.Playlists)
			{
				playlists.Add
				(
					// Переробити копіювання треків з бази
					new Playlist()
					{
						Name = p.Name,
						Tracks = p.Tracks
					}
				);
			}
		}

		private void UpdatePlaylistList()
		{
			playlistListBox.DataSource = null;
			playlistListBox.DataSource = playlists;
		}

		private void createPlaylistButton_Click(object sender, EventArgs e)
		{
			CreatePlaylistForm form = new CreatePlaylistForm();
			if (form.ShowDialog() == DialogResult.OK)
			{
				playlists.Add(form.Playlist);
				UpdatePlaylistList();
			}
		}

		private void playlistListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			var playlist = playlistListBox.SelectedItem as Playlist;
			if (playlist == null || playlist.Tracks.Count == 0)
			{
				return;
			}

			playlistName.Text = playlist.Name;

			tracklistBox.DataSource = null;
			tracks.Clear();

			foreach (var t in playlist.Tracks)
			{
				tracks.Add(t);
			}

			tracklistBox.DataSource = tracks;
		}


		// TODO
		private void removeTrackButton_Click(object sender, EventArgs e)
		{
			var track = tracklistBox.SelectedItem as Track;
			if (track == null)
			{
				MessageBox.Show("Select track to delete!");
				return;
			}

			var playlist = track.Playlist;

			playlist.Tracks.Remove(track);

			tracklistBox.DataSource = null;
			tracks.Clear();

			foreach (var t in playlist.Tracks)
			{
				tracks.Add(t);
			}

			tracklistBox.DataSource = tracks;
		}
	}
}