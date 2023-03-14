using System;
using System.Net;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Drawing.Text;
using HtmlAgilityPack;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Xml;

namespace Actividad1_VB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetHostIP();
            GetGatewayIP();
            GetUser();
            GetHostname();
            GetSSID();
            GetMACAddress();
            CheckInternetConnection();

            string version = "";

            CheckVBInstall(ref version);
            CheckVBVersion(ref version);
        }

        private void GetHostIP()
        {
            NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

            // Iteramos cada NetworkInterface
            foreach (NetworkInterface networkInterface in networkInterfaces)
            {
                // Comprobamos si la network interface está activa y tiene una dirección IP asignada
                if (networkInterface.OperationalStatus == OperationalStatus.Up && networkInterface.GetIPProperties().UnicastAddresses.Count > 0)
                {
                    // Iteramos cada dirección IP asignada a la Network Interface
                    foreach (UnicastIPAddressInformation ipAddress in networkInterface.GetIPProperties().UnicastAddresses)
                    {
                        // Comprobamos si la dirección IP es IPv4
                        if (ipAddress.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork && !IPAddress.IsLoopback(ipAddress.Address))
                        {
                            // Mostramos por pantalla el resultado
                            lbl_hostText.Text = ipAddress.Address.ToString();
                        }
                    }
                }
                else
                {
                    lbl_hostNameText.Text = "IP address not found";
                }
            }
        }

        private void GetGatewayIP()
        {
            NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface networkInterface in networkInterfaces)
            {
                if (networkInterface.OperationalStatus == OperationalStatus.Up && networkInterface.GetIPProperties().GatewayAddresses.Count > 0)
                {
                    // Obtenemos la gateway 
                    GatewayIPAddressInformation gateway = networkInterface.GetIPProperties().GatewayAddresses[0];

                    // Comprobamos si la gateway es nula
                    if (gateway.Address != null)
                    {
                        // Mostramos por pantalla el valor
                        lbl_gatewayText.Text = gateway.Address.ToString();
                        return;
                    }
                }
            }
        }

        private void GetUser()
        {
            String userName = Environment.UserName;
            lbl_userNameText.Text = userName;
        }

        private void GetHostname()
        {
            string hostName = Dns.GetHostName();
            lbl_hostNameText.Text = hostName;
        }

        private void GetSSID()
        {
            var networks = NetworkListManager.GetNetworks(NetworkConnectivityLevels.Connected);
            foreach (var network in networks)
            {

                if (network.IsConnected)
                {
                    lbl_ssidStatusText.Text = "Connected";
                    lbl_ssidStatusText.ForeColor = Color.Green;

                }
                else if (!network.IsConnected)
                {
                    lbl_ssidStatusText.Text = "Disconnected";
                    lbl_ssidStatusText.ForeColor = Color.Red;
                }
                lbl_ssidText.Text = network.Name;
            }
        }

        private void GetMACAddress()
        {
            NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface networkInterface in networkInterfaces)
            {
                if (networkInterface.OperationalStatus == OperationalStatus.Up && networkInterface.GetIPProperties().GatewayAddresses.Count > 0)
                {
                    PhysicalAddress macAddress = networkInterface.GetPhysicalAddress();

                    // Convertimos la dirección MAC en un String
                    string macAddressString = BitConverter.ToString(macAddress.GetAddressBytes());

                    lbl_MACText.Text = macAddressString;
                    return;
                }
                else
                {
                    lbl_MACText.Text = "MAC address not found";
                }
            }
        }

        private void CheckInternetConnection()
        {
            // Creamos un objeto Ping
            Ping ping = new Ping();

            // Mandamos cuatro pings a cloudflare.com
            PingReply reply = ping.Send("cloudflare.com", 4000, new byte[32], new PingOptions(64, true));

            // Comprobamos la respuesta
            if (reply.Status == IPStatus.Success)
            {
                // Mostramos la respuesta por pantalla (Conexión establecida)
                lbl_InternetText.Text = "Established";
                lbl_InternetText.ForeColor = Color.Green;
            }
            else if (reply.Status == IPStatus.TimedOut || reply.Status == IPStatus.TtlExpired)
            {
                // Mostramos la respuesta por pantalla (Conexión inestable)
                lbl_InternetText.Text = "Unstable";
                lbl_InternetText.ForeColor = Color.Orange;
            }
            else
            {
                // Mostramos la respuesta por pantalla (Desconectado, no hay conexión)
                lbl_InternetText.Text = "Disconnected";
                lbl_InternetText.ForeColor = Color.Red;
            }
        }

        private void CheckVBInstall(ref string version)
        {
            string query = "SELECT * FROM Win32_Product WHERE Name LIKE '%VirtualBox%'";
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(query))
            {
                foreach (ManagementObject product in searcher.Get())
                {
                    if (product["Name"].ToString().Contains("VirtualBox"))
                    {
                        version = product["Version"].ToString();
                        lbl_installedVBText.Text = "YES";
                        lbl_installedVBText.ForeColor = Color.Green;
                        return;
                    }
                }
            }
            lbl_installedVBText.Text = "NO";
            lbl_installedVBText.ForeColor = Color.Red  ;
        }

        private void CheckVBVersion(ref string version)
        {
            string url = "https://www.virtualbox.org/wiki/Downloads";
            string lastVersion = "";

            using (WebClient client = new WebClient())
            {
                string html = client.DownloadString(url);

                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(html);

                HtmlNode versionNode = doc.DocumentNode.SelectSingleNode("//table[contains(@class, 'downloadTable')]/tbody/tr[1]/td[1]");
                string latestVersion = versionNode?.InnerText.Trim();

                lastVersion = latestVersion;
            }

            if(version == lastVersion)
            {
                lbl_versionVBText.Text = version + " " + "(Last Version)";
                lbl_versionVBText.ForeColor = Color.Green;
            }
            else
            {
                lbl_versionVBText.Text = version + " " + "(Outdated)";
                lbl_versionVBText.ForeColor = Color.Orange;
            }


        }
    }
}
