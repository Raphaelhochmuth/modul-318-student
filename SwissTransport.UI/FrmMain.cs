using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissTransport
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        //Controls the action if btnsearch is clicked
        private void Btnsearch_Click(object sender, EventArgs e)
        {
            //The Object transport is getting created
            //The Items in the Listview are beeing removed
            //The Column Headers of the Listview are beeing renamed
            Transport transport = new Transport();
            liview.Items.Clear();
            clmankunft.Text = "Ankunft";
            clmdauer.Text = "Dauer";
            clmgleis.Text =  "Gleis";

            try
            {
                //Change the Cursor to WaitCursor
                //Gets the next 4 Connections from Connectionlist and insert them into Listview
                Cursor.Current = Cursors.WaitCursor;
                foreach (Connection conn in transport.GetConnections(cboxfrom.Text, cboxto.Text).ConnectionList)
                {
                
                    DateTime abfahrt = DateTime.Parse(conn.From.Departure);
                    DateTime ankunft = DateTime.Parse(conn.To.Arrival);
                    String[] item = { abfahrt.ToString(), ankunft.ToString(), conn.Duration, conn.From.Platform};
                    ListViewItem lview = new ListViewItem(item);
                    liview.Items.Add(lview);
                }
                Cursor.Current = Cursors.Default;
            }
            //Catches WebException for too many Requests
            catch (WebException ex)
            {
                MessageBox.Show($"Zu viele Anfragen an den Server\nBitte kurz warten befor sie fortfahren\n\n{ex}");
            }
        }

        //Changes the Content of cboxfrom and cboxto
        private void btnchange_Click(object sender, EventArgs e)
        {
            string von = "";
            von = cboxfrom.Text;

            cboxfrom.Text = cboxto.Text;
            cboxto.Text = von;
            return;
        }
        //When using the Dropdown event the Stations are getting Loaded in the Dropdown$
        private void cboxload_DropDown(object sender, EventArgs e)
        {
            ComboBox cboxload = (ComboBox)sender;
            SwissTransport.Transport transport = new SwissTransport.Transport();
            var foundStations = transport.GetStations(cboxload.Text);
            try
            {
                foreach (var station in foundStations.StationList)
                {
                    cboxload.Items.Add(station.Name);
                }
            }
            catch(WebException ex)
            {
                MessageBox.Show($"Zu viele Anfragen an den Server\nBitte kurz warten befor sie fortfahren\n\n{ex}");
            }
        }

        //Clears all Items from the Listview
        //Changes the name of the Columnheaders
        //Gets the StationBoard from the cboxfrom station and fills it into the Listview
        //Sets the Cursor to Waitcursor until all Data is loaded into Listview
        private void btnshowtable_Click(object sender, EventArgs e)
        {
            Transport transport = new Transport();
            liview.Items.Clear();
            if (cboxfrom.Text != "")
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    clmankunft.Text = "Nach";
                    clmdauer.Text = "Typ";
                    clmgleis.Text = "Anbieter";

                    string id = transport.GetStations(cboxfrom.Text).StationList[0].Id;
                    StationBoardRoot sbr = transport.GetStationBoard(cboxfrom.Text, id);
                    foreach (StationBoard stb in sbr.Entries)
                    {
                        String[] item = { stb.Stop.Departure.ToString(), stb.To, stb.Name, stb.Operator };
                        ListViewItem lview = new ListViewItem(item);
                        liview.Items.Add(lview);
                    }
                    Cursor.Current = Cursors.Default;
                }
                catch (WebException ex)
                {
                    MessageBox.Show($"Zu viele Anfragen an den Server\nBitte kurz warten befor sie fortfahren\n\n{ex}");
                }
            }
        }

        //If text is filled in cboxto the btnsearch will be enabled
        //If there is no Text in cboxto the btnsearch will be disabled
        //If there is no Text in cboxto && There is Text in cboxfrom then btnshowtable will be enabled
        private void cbox_TextChanged(object sender, EventArgs e)
        {
            ComboBox cbox = (ComboBox)sender;
            if(cboxfrom.Text != "")
            {
                if (cboxto.Text != "")
                {
                    btnsearch.Enabled = true;
                    btnshowtable.Enabled = false;
                    btnshowmapsfrom.Enabled = true;
                    btnshowmapsto.Enabled = true;
                }
                else
                {
                    btnsearch.Enabled = false;
                    btnshowtable.Enabled = true;
                    btnshowmapsfrom.Enabled = true;
                    btnshowmapsto.Enabled = false;
                }
            }
            else
            {
                btnsearch.Enabled = false;
                btnshowtable.Enabled = false;
                btnshowmapsfrom.Enabled = false;
                if (cboxto.Text != "")
                {
                    btnshowmapsto.Enabled = true;
                }
                else
                {
                    btnshowmapsto.Enabled = false;
                }
            }
        }

        //Checks if Text is in cboxfrom and && Opens the Webbrowser with the Location which is in cboxfrom
        private void btnshowmapsfrom_Click(object sender, EventArgs e)
        {
            if(cboxfrom.Text != "")
            {
                System.Diagnostics.Process.Start("https://www.google.ch/maps/search/" + cboxfrom.Text + " Haltestelle");
            }
            else
            {
                MessageBox.Show("Bitte Zuerst den Abfahrtsort eingeben bevor Sie diesen Knopf drücken");
            }
        }
        //Checks if Text is in cboxto and && Opens the Webbrowser with the Location which is in cboxto
        private void btnshowmapsto_Click(object sender, EventArgs e)
        {
            if(cboxto.Text != "")
            {
                System.Diagnostics.Process.Start("https://www.google.ch/maps/search/" + cboxto.Text + " Haltestelle");
            }
        }

        //Shows your Location on Google Maps
        private void btnmylocation_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.ch/maps/search/" + "Mein Standort");
        }

    }
}
