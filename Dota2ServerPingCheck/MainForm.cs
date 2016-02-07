using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dota2ServerPingCheck
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private SortableBindingList<Dota2Server> _servers;
        private bool _refreshing = false;
        private const int Timeout = 15000;
        private int _packetCount = 5;
        private int _detailPacketCount = 100;

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Initialize Servers
            _servers = new SortableBindingList<Dota2Server>();
            _servers.Add(new Dota2Server("syd.valve.net", "Australia (Sydney)"));
            _servers.Add(new Dota2Server("200.73.67.1", "Chile (Santiago)"));
            _servers.Add(new Dota2Server("dxb.valve.net", "Dubai (UAE)"));
            _servers.Add(new Dota2Server("vie.valve.net", "Europe East 1 (Vienna, Austria)"));
            _servers.Add(new Dota2Server("185.25.182.1", "Europe East 2 (Vienna, Austria)"));
            _servers.Add(new Dota2Server("lux.valve.net", "Europe West 1 (Luxembourg)"));
            _servers.Add(new Dota2Server("146.66.158.1", "Europe West 2 (Luxembourg)"));
            _servers.Add(new Dota2Server("116.202.224.146", "India (Kolkata)"));
            _servers.Add(new Dota2Server("191.98.144.1", "Peru (Lima)"));
            _servers.Add(new Dota2Server("sto.valve.net", "Russia 1 (Stockholm, Sweden"));
            _servers.Add(new Dota2Server("185.25.180.1", "Russia 2 (Stockholm, Sweden)"));
            _servers.Add(new Dota2Server("sgp-1.valve.net", "SE Asia 1 (Singapore)"));
            _servers.Add(new Dota2Server("sgp-2.valve.net", "SE Asia 2 (Singapore)"));
            _servers.Add(new Dota2Server("cpt-1.valve.net", "South Africa 1 (Cape Town)"));
            _servers.Add(new Dota2Server("197.80.200.1", "South Africa 2 (Cape Town)"));
            _servers.Add(new Dota2Server("197.84.209.1", "South Africa 3 (Cape Town)"));
            _servers.Add(new Dota2Server("196.38.180.1", "South Africa 4 (Johannesburg)"));
            _servers.Add(new Dota2Server("gru.valve.net", "South America 1 (Sao Paulo)"));
            _servers.Add(new Dota2Server("209.197.25.1", "South America 2 (Sao Paulo)"));
            _servers.Add(new Dota2Server("209.197.29.1", "South America 3 (Sao Paulo)"));
            _servers.Add(new Dota2Server("iad.valve.net", "US East (Sterling, VA)"));
            _servers.Add(new Dota2Server("eat.valve.net", "US West (Seattle, WA)"));
            #endregion

            BindingSource bs = new BindingSource();
            bs.DataSource = _servers;
            dataGrid.DataSource = bs;
            ReloadAllData();

            ConsoleWrite("Program started successfully.", Color.Lime);
        }

        private void btnRefreshAllPings_Click(object sender, EventArgs e)
        {
        }

        private void CheckPing(Dota2Server server)
        {
            Ping pinger = new Ping();
            pinger.PingCompleted += pinger_PingCompleted;
            server.TotalPacketsSent++;
            pinger.SendAsync(server.Address, Timeout, server);
            ConsoleWrite("Requesting ping " + server.Name, Color.Lime);
        }

        void pinger_PingCompleted(object sender, PingCompletedEventArgs e)
        {
            Dota2Server server = e.UserState as Dota2Server;
            if (e.Error == null)
            {
                if (e.Reply.Status == IPStatus.Success)
                {
                    server.TotalRoundTripTime += e.Reply.RoundtripTime;
                    server.TotalPacketReceived++;
                    if (server.TotalPacketsSent < _packetCount)
                    {
                        CheckPing(server);
                    }
                    else
                    {
                        server._ping = (server.TotalRoundTripTime/server.TotalPacketsSent);
                        server._packetLoss = 100-((server.TotalPacketsSent/server.TotalPacketReceived)*100);
                        server.TotalPacketsSent = 0;
                        server.TotalRoundTripTime = 0;
                        server.TotalPacketReceived = 0;
                    }
                }
                else
                {
                    ConsoleWrite("Error occured while requesting ping " + server.Name + " " + e.Reply.Status, Color.Red);
                    server._ping = int.MaxValue;
                }
            }
            else
            {
                if (ConfigurationSettings.AppSettings["IsErrorEnabled"]=="true")
                    ConsoleWrite("Error occured while requesting ping " + server.Name + " " + e.Error, Color.Red);
                else
                    ConsoleWrite("Error occured while requesting ping " + server.Name + " " + e.Error.Message, Color.Red);
                server._ping = int.MaxValue;
            }
            ReloadAllData();
        }

        private void ReloadAllData()
        {
            dataGrid.Update();
            dataGrid.Refresh();
        }

        private void ConsoleWrite(string text, Color color)
        {
            tbConsole.SelectionColor = color;
            tbConsole.AppendText("> " + text + "\r\n");
        }

        private void tbConsole_TextChanged(object sender, EventArgs e)
        {
            tbConsole.SelectionStart = tbConsole.TextLength;
            tbConsole.ScrollToCaret();
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dataGrid.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow >= 0)
                {
                    Dota2Server server = (Dota2Server)dataGrid.Rows[currentMouseOverRow].DataBoundItem;

                    ContextMenu m = new ContextMenu();

                    MenuItem itemRefresh = new MenuItem(string.Format("Refresh ping"));
                    itemRefresh.Click += (sender2, e2) => ItemRefresh(server);
                    m.MenuItems.Add(itemRefresh);
                    MenuItem itemDetail = new MenuItem(string.Format("Detail Refresh ping"));
                    itemDetail.Click += (sender2, e2) => ItemDetailRefresh(server);
                    m.MenuItems.Add(itemDetail);
                    m.Show(dataGrid, new Point(e.X, e.Y));
                }
            }
        }

        private void ItemRefresh(Dota2Server server)
        {
            CheckPing(server);
        }

        private void ItemDetailRefresh(Dota2Server server)
        {
            CheckPing(server);
        }

        private void dataGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void refreshAllPingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_refreshing)
            {
                ConsoleWrite("A refresh is in progress can not refresh again.", Color.Red);
            }
            else
            {
                _refreshing = true;
                ConsoleWrite("Refresh Started...", Color.Lime);
                lock (_servers)
                {
                    foreach (Dota2Server server in _servers)
                    {
                        CheckPing(server);
                    }
                }
            }
            _refreshing = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string info = "Step1:\r\n" +
                          "\tGo to file and click \"Refresh All pings\" to get the updated ping information."
                          +"Note that this method uses a small amout of packets therefore if your internet "
                          +"fluctuates it might give in-accurate result.\r\n"
                          +"Step2:\r\n";
            MessageBox.Show(info, "How to Guide.", MessageBoxButtons.OK);
        }

        private void aboutDota2ServerPingCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutApp aboutForm= new AboutApp();
            aboutForm.Show();
        }

    }
}
