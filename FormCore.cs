using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Drawing;
using System.Text;
using System.Windows.Forms;
using iTunesLib;

namespace JamesRSkemp.iTunes.RatingsSync {
	public partial class FormCore : Form {
		public FormCore() {
			InitializeComponent();
		}

		iTunesApp iTunes;
		IITSourceCollection sources;

		private void connectToolStripMenuItem_Click(object sender, EventArgs e) {
			toolStripStatusLabelCore.Text = "Attempting to connect to iTunes.";
			try {
				iTunes = new iTunesAppClass();
				toolStripStatusLabelCore.Text = "Connected to iTunes.";
				populateSources();
				toolStripStatusLabelCore.Text = "Sources populated.";
				sourcesToolStripMenuItem.Visible = true;
				groupBoxMain.Visible = true;
			} catch (Exception ex) {
				MessageBox.Show("There was an error while connecting to iTunes." + System.Environment.NewLine
					+ "Message: " + ex.Message);
				toolStripStatusLabelCore.Text = "Failed to connect to iTunes.";
				sourcesToolStripMenuItem.Visible = false;
				groupBoxMain.Visible = false;
				iTunes = null;
			}
		}

		private void linkLabelContact_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			// TODO: Automatically pull in the correct version information.
			System.Diagnostics.Process.Start("http://jamesrskemp.com/apps/iTunesRatingsSync/?0.3");
		}

		private void populateSources() {
			try {
				// Clear the sources, if there are any.
				sourceListing1.Items.Clear();
				sourceListing2.Items.Clear();
				sources = iTunes.Sources;

				// Populate the source listings with libraries and iPods.
				foreach (IITSource source in sources) {
					if (source.Kind == ITSourceKind.ITSourceKindLibrary || source.Kind == ITSourceKind.ITSourceKindIPod) {
						sourceListing1.Items.Add(source.Name);
						sourceListing2.Items.Add(source.Name);
					}
				}
				if (sourceListing1.Items.Count == 1) {
					MessageBox.Show("Only one available source was detected. Please add another source (such as an iPod) and refresh the sources from the menu to continue.");
					buttonPreview.Visible = false;
				} else {
					buttonPreview.Visible = true;
				}
			} catch (Exception ex) {
				MessageBox.Show("There was a problem getting the listing of sources." + System.Environment.NewLine
					+ "Message: " + ex.Message);
			}
		}

		private void buttonPreview_Click(object sender, EventArgs e) {
			labelDetails1.Text = String.Empty;
			labelDetails2.Text = String.Empty;
			try {
				dataGridView1.Rows.Clear();
				dataGridView2.Rows.Clear();
			} catch (Exception ex) {
				// TODO: Resolve this issue and remove for production.
				MessageBox.Show(ex.Message);
			}

			if (sourceListing1.SelectedIndex < 0 || sourceListing2.SelectedIndex < 0) {
				MessageBox.Show("You must select both a source to copy from, as well as one to copy to.");
				return;
			} else if (sourceListing1.SelectedIndex == sourceListing2.SelectedIndex) {
				MessageBox.Show("You must select a different source for either the copy from or to to continue.");
				return;
			}

			DataTable sourceTracks1 = CreateTracksTable();

			DataTable sourceTracks2 = CreateTracksTable();

			try {
				IITSource source1 = sources.get_ItemByName(sourceListing1.SelectedItem.ToString());
				IITSource source2 = sources.get_ItemByName(sourceListing2.SelectedItem.ToString());
				IITPlaylist sourceMusic1 = source1.Playlists.get_ItemByName("Music");
				IITPlaylist sourceMusic2 = source2.Playlists.get_ItemByName("Music");

				toolStripProgressBarCore.Value = 0;
				toolStripProgressBarCore.Visible = true;

				toolStripStatusLabelCore.Text = "Getting tracks from " + sourceListing1.SelectedItem.ToString() + ".";
				toolStripProgressBarCore.Maximum = sourceMusic1.Tracks.Count;

				sourceTracks1 = GetSourceTracks(sourceMusic1);

				labelDetails1.Text = sourceTracks1.Rows.Count.ToString();
				toolStripStatusLabelCore.Text = "Sorting ...";
				sourceTracks1.DefaultView.Sort = "Album, Disc, Track, Name";
				dataGridView1.DataSource = sourceTracks1;

				toolStripStatusLabelCore.Text = "Getting tracks from " + sourceListing2.SelectedItem.ToString() + ".";
				toolStripProgressBarCore.Maximum = sourceMusic2.Tracks.Count;

				sourceTracks2 = GetSourceTracks(sourceMusic2);

				labelDetails2.Text = sourceTracks2.Rows.Count.ToString();
				toolStripStatusLabelCore.Text = "Sorting ...";
				sourceTracks2.DefaultView.Sort = "Album, Disc, Track, Name";
				dataGridView2.DataSource = sourceTracks2;

				toolStripStatusLabelCore.Text = "Sources read.";
				toolStripProgressBarCore.Visible = false;

				sourceTracks1 = null;
				sourceTracks2 = null;
				sourceMusic1 = null;
				sourceMusic2 = null;
				source1 = null;
				source2 = null;

			} catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private DataTable GetSourceTracks(IITPlaylist sourcePlaylist) {
			DataTable sourceTracks = CreateTracksTable();

			DataRow trackDetails;
			toolStripProgressBarCore.Maximum = sourcePlaylist.Tracks.Count;
			int currentTrackNumber = 0;
			foreach (IITTrack track in sourcePlaylist.Tracks) {
				//foreach (IITTrack track in sourceMusic1.Search("chorale vii", ITPlaylistSearchField.ITPlaylistSearchFieldSongNames)) {
				if (track.KindAsString != "PDF document" && track.DiscNumber != 0 && track.TrackNumber != 0) {
					currentTrackNumber++;
					trackDetails = sourceTracks.NewRow();
					trackDetails["Name"] = track.Name;
					trackDetails["Album"] = track.Album;
					trackDetails["Artist"] = track.Artist;
					trackDetails["Disc"] = track.DiscNumber;
					trackDetails["Track"] = track.TrackNumber;
					trackDetails["Size"] = track.Size;
					trackDetails["Rating"] = track.Rating;
					trackDetails["Count"] = track.PlayedCount;
					trackDetails["Date"] = track.PlayedDate;
					trackDetails["Type"] = track.KindAsString;
					trackDetails["TrackId"] = track.trackID;
					trackDetails["DatabaseId"] = track.TrackDatabaseID;
					sourceTracks.Rows.Add(trackDetails);
					toolStripProgressBarCore.Value = currentTrackNumber;
				}
			}
			return sourceTracks;
		}

		private void refreshToolStripMenuItem_Click(object sender, EventArgs e) {
			populateSources();
		}

		private void buttonSyncData_Click(object sender, EventArgs e) {
			if (dataGridView1.RowCount > 0 && dataGridView2.RowCount > 0) {
				int rowNumber = 0;

				if (dataGridView1.RowCount <= dataGridView2.RowCount) {
					toolStripProgressBarCore.Maximum = dataGridView1.RowCount;
				} else {
					toolStripProgressBarCore.Maximum = dataGridView2.RowCount;
				}
				toolStripProgressBarCore.Value = rowNumber;
				toolStripProgressBarCore.Visible = true;

				while (rowNumber < dataGridView1.RowCount && rowNumber < dataGridView2.RowCount) {
					if (dataGridView1.Rows[rowNumber].Cells["Name"].Value.ToString() == dataGridView2.Rows[rowNumber].Cells["Name"].Value.ToString()
					&& dataGridView1.Rows[rowNumber].Cells["Album"].Value.ToString() == dataGridView2.Rows[rowNumber].Cells["Album"].Value.ToString()
					&& dataGridView1.Rows[rowNumber].Cells["Artist"].Value.ToString() == dataGridView2.Rows[rowNumber].Cells["Artist"].Value.ToString()
					&& dataGridView1.Rows[rowNumber].Cells["Disc"].Value.ToString() == dataGridView2.Rows[rowNumber].Cells["Disc"].Value.ToString()
					&& dataGridView1.Rows[rowNumber].Cells["Track"].Value.ToString() == dataGridView2.Rows[rowNumber].Cells["Track"].Value.ToString()
					) {
						//MessageBox.Show("The first rows are a match.");
						IITSource source1 = sources.get_ItemByName(sourceListing1.SelectedItem.ToString());
						IITSource source2 = sources.get_ItemByName(sourceListing2.SelectedItem.ToString());
						IITPlaylist sourceMusic1 = source1.Playlists.get_ItemByName("Music");
						IITPlaylist sourceMusic2 = source2.Playlists.get_ItemByName("Music");

						try {
							IITTrackCollection matchingTracks = sourceMusic2.Search(dataGridView2.Rows[rowNumber].Cells["Name"].Value.ToString(), ITPlaylistSearchField.ITPlaylistSearchFieldSongNames);
							toolStripStatusLabelCore.Text = "Found " + matchingTracks.Count.ToString() + " matching tracks.";
							foreach (IITTrack track in matchingTracks) {
								if (track.trackID.ToString() == dataGridView2.Rows[rowNumber].Cells["TrackId"].Value.ToString()) {
									textBoxUpdates.Text += "Updating trackid " + track.trackID.ToString() + " with rating "
										+ dataGridView1.Rows[rowNumber].Cells["Rating"].Value.ToString() + " from "
										+ track.Rating.ToString() + " and count to "
										+ dataGridView1.Rows[rowNumber].Cells["Count"].Value.ToString() + " from "
										+ track.PlayedCount.ToString() + "."
										+ Environment.NewLine;
									track.Rating = int.Parse(dataGridView1.Rows[rowNumber].Cells["Rating"].Value.ToString());
									track.PlayedCount = int.Parse(dataGridView1.Rows[rowNumber].Cells["Count"].Value.ToString());
									track.PlayedDate = (DateTime)dataGridView1.Rows[rowNumber].Cells["Date"].Value;
									//MessageBox.Show("Rating and count updated.");
									break;
								}
							}

							//IITObject iObject = iTunes.GetITObjectByID(source2.sourceID, sourceMusic2.playlistID, int.Parse(dataGridView2.Rows[0].Cells["TrackId"].Value.ToString()), int.Parse(dataGridView2.Rows[0].Cells["DatabaseId"].Value.ToString()));
						} catch (Exception ex) {
							MessageBox.Show(ex.Message);
						}
					} else {
						MessageBox.Show("Items do not match. Stopping.");
						break;
					}
					rowNumber++;
					toolStripProgressBarCore.Value = rowNumber;
				}
				toolStripProgressBarCore.Visible = false;
			} else {
				MessageBox.Show("You must preview the sources to continue.");
			}
		}

		private DataTable CreateTracksTable() {
			DataTable sourceTracks = new DataTable();

			sourceTracks.Columns.Add("Name");
			sourceTracks.Columns.Add("Album");
			sourceTracks.Columns.Add("Artist");
			sourceTracks.Columns.Add("Disc", Type.GetType("System.Int32"));
			sourceTracks.Columns.Add("Track", Type.GetType("System.Int32"));
			sourceTracks.Columns.Add("Size", Type.GetType("System.Int32"));
			sourceTracks.Columns.Add("Rating", Type.GetType("System.Int32"));
			sourceTracks.Columns.Add("Count", Type.GetType("System.Int32"));
			sourceTracks.Columns.Add("Date", Type.GetType("System.DateTime"));
			sourceTracks.Columns.Add("Type");
			sourceTracks.Columns.Add("TrackId", Type.GetType("System.Int32"));
			sourceTracks.Columns.Add("DatabaseId", Type.GetType("System.Int32"));

			return sourceTracks;
		}
	}
}
