using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void Change()
        {
            string von = "";

            //Text von Combobox in string speichern
            von = cboxvon.Text;


            //Den in String gespeicherten Text in die Combobox einfügen
            cboxvon.Text = cboxnach.Text;
            cboxnach.Text = von;
            return;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void Btnsuchen_Click(object sender, EventArgs e)
        {
            Transport transport = new Transport();
            liview.Items.Clear();
            clmankunft.Text = "Ankunft";
            foreach (Connection conn in transport.GetConnections(cboxvon.Text, cboxnach.Text).ConnectionList)
            {
                
                DateTime abfahrt = DateTime.Parse(conn.From.Departure);
                DateTime ankunft = DateTime.Parse(conn.To.Arrival);
                String[] item = { abfahrt.ToString(), ankunft.ToString(), conn.Duration, conn.From.Platform};
                ListViewItem lview = new ListViewItem(item);
                liview.Items.Add(lview);
            }
        }



        private void btnchange_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void cboxload_DropDown(object sender, EventArgs e)
        {
            ComboBox cboxload = (ComboBox)sender;
            SwissTransport.Transport transport = new SwissTransport.Transport();
            var foundStations = transport.GetStations(cboxload.Text);

            foreach(var station in foundStations.StationList)
            {
                cboxload.Items.Add(station.Name);
            }
        }

        private void btnplananzeigen_Click(object sender, EventArgs e)
        {
            Transport transport = new Transport();
            liview.Items.Clear();
            if (cboxvon.Text != "")
            {
                try
                {
                    clmankunft.Text = "Nach";
                    clmdauer.Text = "Typ";

                    string id = transport.GetStations(cboxvon.Text).StationList[0].Id;
                    StationBoardRoot sbr = transport.GetStationBoard(cboxvon.Text, id);
                    foreach (StationBoard stb in sbr.Entries)
                    {
                        String[] item = { stb.Stop.Departure.ToString(), stb.To, stb.Name, stb.Stop.Departure.ToString(), stb.Operator };
                        ListViewItem lview = new ListViewItem(item);
                        liview.Items.Add(lview);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Zu viele Anfragen an den Server\nBitte kurz warten befor sie fortfahren\n\n{ex}");
                }
            }
        }

    }
}
