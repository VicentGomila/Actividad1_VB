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
        private DataTable vmDataTable;
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

            DataGrid();
            ListVM();

            datagrid_Sumarry.DataSource = vmDataTable;
        }

        private void DataGrid()
        {
            vmDataTable = new DataTable();
            vmDataTable.Columns.Add("VM Name");
            vmDataTable.Columns.Add("OS Type");
            vmDataTable.Columns.Add("OS Version");
            vmDataTable.Columns.Add("VM Location");
            vmDataTable.Columns.Add("RAM");
            vmDataTable.Columns.Add("Video");
            vmDataTable.Columns.Add("Graphic Controller");
            vmDataTable.Columns.Add("Disk GB");
            vmDataTable.Columns.Add("Disk Format");
            vmDataTable.Columns.Add("Network Adapter");
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

        //ACTIVIDAD 2
        
        private void cb_os_type_Click(object sender, EventArgs e)
        {
            OS_TYPE_CB();
        }
        private void OS_TYPE_CB()
        {
            cb_os_type.Items.Clear();
            cb_os_type.Items.Add("Microsoft Windows");
            cb_os_type.Items.Add("Linux");
            cb_os_type.Items.Add("Solaris");
            cb_os_type.Items.Add("BSD");
            cb_os_type.Items.Add("IBM OS/2");
            cb_os_type.Items.Add("MAC OS X");
            cb_os_type.Items.Add("Other");
        }
        private void OS_VERSION_CB()
        {
            string os_version = cb_os_type.SelectedItem.ToString();

            if (os_version.Equals("Microsoft Windows"))
            {
                WindowsOptionsCB();
            }
            if (os_version.Equals("Linux"))
            {
                LinuxOptionsCB();
            }
        }
        private void cb_os_version_Click(object sender, EventArgs e)
        {
            OS_VERSION_CB();
        }
        string savepath;
        private void OS_Location_CB()
        {
            cb_vm_location.Items.Clear();
            cb_vm_location.Items.Add("Select new Location");
            if (savepath != null)
            {
                cb_vm_location.Text = savepath;
            }


        }
        private void cb_vm_location_Click(object sender, EventArgs e)
        {
            OS_Location_CB();
        }

        private void cb_vm_location_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Prepare a dummy string, thos would appear in the dialog
            if (savepath == null)
            {
                using (FolderBrowserDialog sf = new FolderBrowserDialog())
                {

                    if (sf.ShowDialog() == DialogResult.OK)
                    {
                        // Now here's our save folder
                        savepath = sf.SelectedPath;
                        cb_vm_location.Items.Clear();
                        cb_vm_location.Items.Add(savepath);
                        cb_vm_location.Text = savepath;

                        // Do whatever
                    }
                }
            }

            // Feed the dummy name to the save dialog

        }

        private void WindowsOptionsCB()
        {
            cb_os_version.Items.Clear();
            cb_os_version.Items.Add("Windows 10 (64-bit)");
            cb_os_version.Items.Add("Windows 11 (64-bit)");
            cb_os_version.Items.Add("Windows 2022 (64-bit)");
        }
        private void LinuxOptionsCB()
        {
            cb_os_version.Items.Clear();
            cb_os_version.Items.Add("Ubuntu (64-bit)");
            cb_os_version.Items.Add("Antix (64-bit)");
        }
        private void btn_create_only_Click(object sender, EventArgs e)
        {
            // Variables Name and Operating System
            string VMsname = tb_vm_name.Text;
            string OSType = cb_os_type.Text;
            string OSVersion = cb_os_version.Text;
            string VMLocation = cb_vm_location.Text;
            string RAM_label = cb_HARD_ram.Text;
            string video = cb_HARD_video.Text;
            string graphic_Serial = cb_HARD_graphic_controller.Text;
            string donwloaded_medium = "antiX-22-net_386-net.iso";
            //
            string VM_GB = textbox_specify_disk_GB.Text;
            string VM_Format = cb_Specifiy_Disk.Text;
            //
            string network_adapter = cb_HARD_network_1stnic.Text;
            //
            //
            string strCmdText1 = "/C" + "\"C:\\Program Files\\Oracle\\virtualbox\\VBoxManage.exe\" createvm --name " + VMsname + " --ostype Ubuntu_64 --register --basefolder " + VMLocation;

            DataRow newRow = vmDataTable.NewRow();
            newRow["VM Name"] = VMsname;
            newRow["OS Type"] = OSType;
            newRow["OS Version"] = OSVersion;
            newRow["VM Location"] = VMLocation;
            newRow["RAM"] = RAM_label;
            newRow["Video"] = video;
            newRow["Graphic Controller"] = graphic_Serial;
            newRow["Disk GB"] = VM_GB;
            newRow["Disk Format"] = VM_Format;
            newRow["Network Adapter"] = network_adapter;
            vmDataTable.Rows.Add(newRow);

            Process process1 = new Process();
            process1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process1.StartInfo.FileName = "cmd.exe";
            process1.StartInfo.Arguments = strCmdText1;
            process1.StartInfo.UseShellExecute = false;
            process1.StartInfo.RedirectStandardOutput = true;
            process1.Start();

            string VBox_Version1 = "";
            while (!process1.HasExited)
            {
                VBox_Version1 = VBox_Version1 + process1.StandardOutput.ReadToEnd();
            }
            //
            process1.Dispose();
            //
            if (OSVersion.Equals("Antix (64-bit)"))
            {
                //Process process = new Process();

                //process.StartInfo.FileName = @"C:\Program Files\Oracle\VirtualBox\VBoxManage.exe";
                //process.StartInfo.Arguments = @"storagectl ANTIX --name ""SATA Controller"" --add sata --controller IntelAhci";
                //process.StartInfo.UseShellExecute = false;
                //process.StartInfo.RedirectStandardOutput = true;
                //process.StartInfo.RedirectStandardError = true;
                //process.Start();

                //string output = process.StandardOutput.ReadToEnd();
                //string errors = process.StandardError.ReadToEnd();

                //process.WaitForExit();
                //

                //
                string strCmdText3 = "/C" + "\"C:\\Program Files\\Oracle\\virtualbox\\VBoxManage.exe\"  modifyvm " + VMsname + " --ioapic on";
                //
                string strCmdText4 = "/C" + "\"C:\\Program Files\\Oracle\\virtualbox\\VBoxManage.exe\"  modifyvm " + VMsname + " --memory " + RAM_label + " --vram " + video;
                //
                string strCmdText5 = "/C" + "\"C:\\Program Files\\Oracle\\virtualbox\\VBoxManage.exe\"  modifyvm " + VMsname + " --nic1 " + network_adapter.ToLower();
                //
                string strCmdText6 = "/C" + "\"C:\\Program Files\\Oracle\\virtualbox\\VBoxManage.exe\"  modifyvm " + VMsname + " --graphicscontroller " + graphic_Serial;
                //
                string strCmdText7 = "/C" + "\"C:\\Program Files\\Oracle\\virtualbox\\VBoxManage.exe\"  createmedium disk --filename " + VMLocation + "/" + VMsname + "/" + VMsname + "_DISK." + VM_Format.ToLower() + " --size " + VM_GB + " --format " + VM_Format;
                //
                string strCmdTextAntix = "/C" + " cd " + VMLocation + " && curl.exe --url https://ftp.caliu.cat/pub/distribucions/mxlinux/MX-ISOs/ANTIX/Final/antiX-22/antiX-22-net_386-net.iso --output " + donwloaded_medium;
                //
                string Full_Location = VMLocation + "/" + VMsname + "/" + VMsname + "_DISK." + VM_Format.ToLower();
                //
                string[] array_commands = new string[] {
                    strCmdText3,
                    strCmdText4,
                    strCmdText5,
                    strCmdText6,
                    strCmdText7,
                    strCmdTextAntix,
                };
                foreach (string CMD_Arguments in array_commands)
                {
                    Process process2 = new Process();
                    process2.StartInfo.FileName = "cmd.exe";
                    process2.StartInfo.Arguments = CMD_Arguments;
                    process2.StartInfo.UseShellExecute = false;
                    process2.StartInfo.RedirectStandardOutput = true;
                    process2.Start();
                    process2.WaitForExit();
                }

                //
                //
                //Process process = new Process();

                //process.StartInfo.FileName = @"C:\Program Files\Oracle\VirtualBox\VBoxManage.exe";
                //process.StartInfo.Arguments = $"storagectl {VMsname} --name \"SATA Controller\" --add sata --controller IntelAhci";
                //process.StartInfo.UseShellExecute = false;
                //process.StartInfo.RedirectStandardOutput = true;
                //process.StartInfo.RedirectStandardError = true;
                //process.Start();
                //process.Dispose();
                ////
                //Process process3 = new Process();
                ////
                //process3.StartInfo.FileName = @"C:\Program Files\Oracle\VirtualBox\VBoxManage.exe";
                //process3.StartInfo.Arguments = $"storageattach {VMsname} --storagectl " + "\"SATA Controller\" --port 0 --device 0 --type hdd --medium " + Full_Location;
                //process3.StartInfo.UseShellExecute = false;
                //process3.StartInfo.RedirectStandardOutput = true;
                //process3.StartInfo.RedirectStandardError = true;
                //process3.Start();
                //process3.Dispose();
                ////
                Process process4 = new Process();
                //

                process4.StartInfo.FileName = @"C:\Program Files\Oracle\VirtualBox\VBoxManage.exe";
                process4.StartInfo.Arguments = $"storagectl {VMsname} --name " + "\"IDE Controller\" --add ide --controller PIIX4";
                process4.StartInfo.UseShellExecute = false;
                process4.StartInfo.RedirectStandardOutput = true;
                process4.Start();
                process4.Dispose();
                //
                Process process5 = new Process();
                //
                process5.StartInfo.FileName = @"C:\Program Files\Oracle\VirtualBox\VBoxManage.exe";
                process5.StartInfo.Arguments = $"storageattach {VMsname} --storagectl " + "\"IDE Controller\" --port 1 --device 0 --type dvddrive --medium " + VMLocation + "\\" + donwloaded_medium;
                process5.StartInfo.UseShellExecute = false;
                process5.StartInfo.RedirectStandardOutput = true;
                process5.Start();
                process5.Dispose();
                ////
                //Process process6 = new Process();
                ////
                //process6.StartInfo.FileName = @"C:\Program Files\Oracle\VirtualBox\VBoxManage.exe";
                //process6.StartInfo.Arguments = $"modifyvm {VMsname} --boot1 dvd --boot2 disk --boot3 none --boot4 none";
                //process6.StartInfo.UseShellExecute = false;
                //process6.StartInfo.RedirectStandardOutput = true;
                //process6.StartInfo.RedirectStandardError = true;
                //process6.Start();
                //process6.Dispose();
                ////
                if (checkBox1.Checked)
                {
                    string strCmdText13 = "/C" + "\"C:\\Program Files\\Oracle\\virtualbox\\VBoxManage.exe\" startvm " + VMsname;
                    Process process10 = new Process();
                    process10.StartInfo.FileName = "cmd.exe";
                    process10.StartInfo.Arguments = strCmdText13;
                    process10.StartInfo.UseShellExecute = false;
                    process10.StartInfo.RedirectStandardOutput = true;
                    process10.Start();
                    process10.Dispose();
                }
                // @"storagectl ANTIX --name ""SATA Controller"" --add sata --controller IntelAhci";
                //
                //string strCmdText8 = "/C" + @"C:\Program Files\Oracle\virtualbox\VBoxManage.exe" + $"storagectl {VMsname} --name \"SATA Controller\" --add sata --controller IntelAhci";
                ////
                //string strCmdText9 = "/C" + @"C:\Program Files\Oracle\virtualbox\VBoxManage.exe" + $"storageattach {VMsname} --storagectl " + "\"SATA Controller\" --port 0 --device 0 --type hdd --medium " + Full_Location;
                ////
                //string strCmdText10 = "/C" + @"C:\Program Files\Oracle\virtualbox\VBoxManage.exe" + $"storagectl {VMsname} --name " + "\"IDE Controller\" --add ide --controller PIIX4";
                ////
                //string strCmdText11 = "/C" + @"C:\Program Files\Oracle\virtualbox\VBoxManage.exe" + $"storageattach {VMsname} --storagectl " + "\"IDE Controller\" --port 1 --device 0 --type dvddrive --medium " + VMLocation + "\\" +donwloaded_medium;
                ////
                //string strCmdText12 = "/C" + @"C:\Program Files\Oracle\virtualbox\VBoxManage.exe" + $"modifyvm {VMsname} --boot1 dvd --boot2 disk --boot3 none --boot4 none";
                ////

            }



        }
        private void radiobtn_VHD_Location_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radiobtn_ISO_Download_and_Install_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_Specifiy_Disk_Click(object sender, EventArgs e)
        {
            cb_Specifiy_Disk.Items.Clear();
            cb_Specifiy_Disk.Items.Add("VDI");
            cb_Specifiy_Disk.Items.Add("VHD");
            cb_Specifiy_Disk.Items.Add("VMDK");
            cb_Specifiy_Disk.Items.Add("HDD");
            cb_Specifiy_Disk.Items.Add("QCOW");
            cb_Specifiy_Disk.Items.Add("QED");
        }

        private void cb_HARD_graphic_controller_Click(object sender, EventArgs e)
        {
            cb_HARD_graphic_controller.Items.Clear();
            cb_HARD_graphic_controller.Items.Add("VMSVGA");

        }

        private void cb_HARD_network_1stnic_Click(object sender, EventArgs e)
        {
            cb_HARD_network_1stnic.Items.Clear();
            cb_HARD_network_1stnic.Items.Add("NAT");
            cb_HARD_network_1stnic.Items.Add("NAT Network");
            cb_HARD_network_1stnic.Items.Add("Bridge Adapter");
            cb_HARD_network_1stnic.Items.Add("Internal Network");
            cb_HARD_network_1stnic.Items.Add("Host-Only Adapter");
            cb_HARD_network_1stnic.Items.Add("Not Connected");
        }

        private void ListVM()
        {
            string listVMlbl = "/C" + "\"C:\\Program Files\\Oracle\\virtualbox\\VBoxManage.exe\" list vms";

            lbl_VMList.Text = "";

            System.Diagnostics.Process VMList = new System.Diagnostics.Process();
            VMList.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            VMList.StartInfo.FileName = "cmd.exe";
            VMList.StartInfo.Arguments = listVMlbl;
            VMList.StartInfo.UseShellExecute = false;
            VMList.StartInfo.RedirectStandardOutput = true;
            VMList.Start();

            string VM_List = "";

            while(!VMList.HasExited)
            {
                VM_List = VM_List + VMList.StandardOutput.ReadToEnd();
            }

            lbl_VMList.Text = VM_List;
        }
    }
}
