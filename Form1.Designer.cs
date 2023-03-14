namespace Actividad1_VB
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.title = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_userNameText = new System.Windows.Forms.Label();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.lbl_ipGateway = new System.Windows.Forms.Label();
            this.lbl_ssidStatus = new System.Windows.Forms.Label();
            this.lbl_hostName = new System.Windows.Forms.Label();
            this.lbl_gatewayText = new System.Windows.Forms.Label();
            this.lbl_hostNameText = new System.Windows.Forms.Label();
            this.lbl_ssidStatusText = new System.Windows.Forms.Label();
            this.lbl_MAC = new System.Windows.Forms.Label();
            this.lbl_InternetCon = new System.Windows.Forms.Label();
            this.lbl_MACText = new System.Windows.Forms.Label();
            this.lbl_InternetText = new System.Windows.Forms.Label();
            this.lbl_installedVB = new System.Windows.Forms.Label();
            this.lbl_versionVB = new System.Windows.Forms.Label();
            this.lbl_installedVBText = new System.Windows.Forms.Label();
            this.lbl_versionVBText = new System.Windows.Forms.Label();
            this.lbl_ssidText = new System.Windows.Forms.Label();
            this.lbl_ssid = new System.Windows.Forms.Label();
            this.lbl_ipHost = new System.Windows.Forms.Label();
            this.lbl_hostText = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Source Code Pro Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(3, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(1127, 48);
            this.title.TabIndex = 1;
            this.title.Text = "Welcome To VirtualBox Management ";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.title, 0, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1133, 48);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 10;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.97285F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.02715F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel2.Controls.Add(this.lbl_userNameText, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_userName, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_ipGateway, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_ssidStatus, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_hostName, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_gatewayText, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_hostNameText, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_ssidStatusText, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_MAC, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_InternetCon, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_MACText, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_InternetText, 7, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_installedVB, 8, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_versionVB, 8, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_installedVBText, 9, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_versionVBText, 9, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_ssidText, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_ssid, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_ipHost, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_hostText, 1, 0);
            this.tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 87);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1130, 173);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lbl_userNameText
            // 
            this.lbl_userNameText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_userNameText.AutoSize = true;
            this.lbl_userNameText.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_userNameText.Font = new System.Drawing.Font("Source Code Pro", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userNameText.Location = new System.Drawing.Point(272, 1);
            this.lbl_userNameText.Name = "lbl_userNameText";
            this.lbl_userNameText.Size = new System.Drawing.Size(115, 87);
            this.lbl_userNameText.TabIndex = 8;
            this.lbl_userNameText.Text = "text";
            this.lbl_userNameText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_userName
            // 
            this.lbl_userName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_userName.Font = new System.Drawing.Font("Source Code Pro Semibold", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userName.Location = new System.Drawing.Point(184, 1);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(82, 87);
            this.lbl_userName.TabIndex = 6;
            this.lbl_userName.Text = "Username:";
            this.lbl_userName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ipGateway
            // 
            this.lbl_ipGateway.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ipGateway.AutoSize = true;
            this.lbl_ipGateway.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_ipGateway.Font = new System.Drawing.Font("Source Code Pro Semibold", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ipGateway.Location = new System.Drawing.Point(4, 88);
            this.lbl_ipGateway.Name = "lbl_ipGateway";
            this.lbl_ipGateway.Size = new System.Drawing.Size(86, 84);
            this.lbl_ipGateway.TabIndex = 4;
            this.lbl_ipGateway.Text = "IP Gateway:";
            this.lbl_ipGateway.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_ssidStatus
            // 
            this.lbl_ssidStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ssidStatus.AutoSize = true;
            this.lbl_ssidStatus.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_ssidStatus.Font = new System.Drawing.Font("Source Code Pro Semibold", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ssidStatus.Location = new System.Drawing.Point(393, 88);
            this.lbl_ssidStatus.Name = "lbl_ssidStatus";
            this.lbl_ssidStatus.Size = new System.Drawing.Size(150, 84);
            this.lbl_ssidStatus.TabIndex = 11;
            this.lbl_ssidStatus.Text = "SSID Status:";
            this.lbl_ssidStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_hostName
            // 
            this.lbl_hostName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_hostName.AutoSize = true;
            this.lbl_hostName.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_hostName.Font = new System.Drawing.Font("Source Code Pro Semibold", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hostName.Location = new System.Drawing.Point(184, 88);
            this.lbl_hostName.Name = "lbl_hostName";
            this.lbl_hostName.Size = new System.Drawing.Size(82, 84);
            this.lbl_hostName.TabIndex = 7;
            this.lbl_hostName.Text = "Hostname:";
            this.lbl_hostName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_gatewayText
            // 
            this.lbl_gatewayText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_gatewayText.AutoSize = true;
            this.lbl_gatewayText.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_gatewayText.Font = new System.Drawing.Font("Source Code Pro", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gatewayText.Location = new System.Drawing.Point(96, 88);
            this.lbl_gatewayText.Name = "lbl_gatewayText";
            this.lbl_gatewayText.Size = new System.Drawing.Size(82, 84);
            this.lbl_gatewayText.TabIndex = 5;
            this.lbl_gatewayText.Text = "text";
            this.lbl_gatewayText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_hostNameText
            // 
            this.lbl_hostNameText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_hostNameText.AutoSize = true;
            this.lbl_hostNameText.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_hostNameText.Font = new System.Drawing.Font("Source Code Pro", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hostNameText.Location = new System.Drawing.Point(272, 88);
            this.lbl_hostNameText.Name = "lbl_hostNameText";
            this.lbl_hostNameText.Size = new System.Drawing.Size(115, 84);
            this.lbl_hostNameText.TabIndex = 9;
            this.lbl_hostNameText.Text = "text";
            this.lbl_hostNameText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_ssidStatusText
            // 
            this.lbl_ssidStatusText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ssidStatusText.AutoSize = true;
            this.lbl_ssidStatusText.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_ssidStatusText.Font = new System.Drawing.Font("Source Code Pro", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ssidStatusText.Location = new System.Drawing.Point(549, 88);
            this.lbl_ssidStatusText.Name = "lbl_ssidStatusText";
            this.lbl_ssidStatusText.Size = new System.Drawing.Size(115, 84);
            this.lbl_ssidStatusText.TabIndex = 12;
            this.lbl_ssidStatusText.Text = "text";
            this.lbl_ssidStatusText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_MAC
            // 
            this.lbl_MAC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_MAC.AutoSize = true;
            this.lbl_MAC.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_MAC.Font = new System.Drawing.Font("Source Code Pro Semibold", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MAC.Location = new System.Drawing.Point(670, 1);
            this.lbl_MAC.Name = "lbl_MAC";
            this.lbl_MAC.Size = new System.Drawing.Size(109, 87);
            this.lbl_MAC.TabIndex = 14;
            this.lbl_MAC.Text = "MAC Adress:";
            this.lbl_MAC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_InternetCon
            // 
            this.lbl_InternetCon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_InternetCon.AutoSize = true;
            this.lbl_InternetCon.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_InternetCon.Font = new System.Drawing.Font("Source Code Pro Semibold", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InternetCon.Location = new System.Drawing.Point(670, 88);
            this.lbl_InternetCon.Name = "lbl_InternetCon";
            this.lbl_InternetCon.Size = new System.Drawing.Size(109, 84);
            this.lbl_InternetCon.TabIndex = 15;
            this.lbl_InternetCon.Text = "Internet Connection:";
            this.lbl_InternetCon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_MACText
            // 
            this.lbl_MACText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_MACText.AutoSize = true;
            this.lbl_MACText.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_MACText.Font = new System.Drawing.Font("Source Code Pro", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MACText.Location = new System.Drawing.Point(785, 1);
            this.lbl_MACText.Name = "lbl_MACText";
            this.lbl_MACText.Size = new System.Drawing.Size(128, 87);
            this.lbl_MACText.TabIndex = 16;
            this.lbl_MACText.Text = "text";
            this.lbl_MACText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_InternetText
            // 
            this.lbl_InternetText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_InternetText.AutoSize = true;
            this.lbl_InternetText.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_InternetText.Font = new System.Drawing.Font("Source Code Pro", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InternetText.Location = new System.Drawing.Point(785, 88);
            this.lbl_InternetText.Name = "lbl_InternetText";
            this.lbl_InternetText.Size = new System.Drawing.Size(128, 84);
            this.lbl_InternetText.TabIndex = 17;
            this.lbl_InternetText.Text = "text";
            this.lbl_InternetText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_installedVB
            // 
            this.lbl_installedVB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_installedVB.AutoSize = true;
            this.lbl_installedVB.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_installedVB.Font = new System.Drawing.Font("Source Code Pro Semibold", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_installedVB.Location = new System.Drawing.Point(919, 1);
            this.lbl_installedVB.Name = "lbl_installedVB";
            this.lbl_installedVB.Size = new System.Drawing.Size(111, 87);
            this.lbl_installedVB.TabIndex = 18;
            this.lbl_installedVB.Text = "Is VirtualBox Installed?";
            this.lbl_installedVB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_versionVB
            // 
            this.lbl_versionVB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_versionVB.AutoSize = true;
            this.lbl_versionVB.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_versionVB.Font = new System.Drawing.Font("Source Code Pro Semibold", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_versionVB.Location = new System.Drawing.Point(919, 88);
            this.lbl_versionVB.Name = "lbl_versionVB";
            this.lbl_versionVB.Size = new System.Drawing.Size(111, 84);
            this.lbl_versionVB.TabIndex = 19;
            this.lbl_versionVB.Text = "VirtualBox Version:";
            this.lbl_versionVB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_installedVBText
            // 
            this.lbl_installedVBText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_installedVBText.AutoSize = true;
            this.lbl_installedVBText.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_installedVBText.Font = new System.Drawing.Font("Source Code Pro", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_installedVBText.Location = new System.Drawing.Point(1036, 1);
            this.lbl_installedVBText.Name = "lbl_installedVBText";
            this.lbl_installedVBText.Size = new System.Drawing.Size(90, 87);
            this.lbl_installedVBText.TabIndex = 20;
            this.lbl_installedVBText.Text = "text";
            this.lbl_installedVBText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_versionVBText
            // 
            this.lbl_versionVBText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_versionVBText.AutoSize = true;
            this.lbl_versionVBText.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_versionVBText.Font = new System.Drawing.Font("Source Code Pro", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_versionVBText.Location = new System.Drawing.Point(1036, 88);
            this.lbl_versionVBText.Name = "lbl_versionVBText";
            this.lbl_versionVBText.Size = new System.Drawing.Size(90, 84);
            this.lbl_versionVBText.TabIndex = 21;
            this.lbl_versionVBText.Text = "text";
            this.lbl_versionVBText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_ssidText
            // 
            this.lbl_ssidText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ssidText.AutoSize = true;
            this.lbl_ssidText.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_ssidText.Font = new System.Drawing.Font("Source Code Pro", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ssidText.Location = new System.Drawing.Point(549, 1);
            this.lbl_ssidText.Name = "lbl_ssidText";
            this.lbl_ssidText.Size = new System.Drawing.Size(115, 87);
            this.lbl_ssidText.TabIndex = 13;
            this.lbl_ssidText.Text = "text";
            this.lbl_ssidText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_ssid
            // 
            this.lbl_ssid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ssid.AutoSize = true;
            this.lbl_ssid.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_ssid.Font = new System.Drawing.Font("Source Code Pro Semibold", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ssid.Location = new System.Drawing.Point(393, 1);
            this.lbl_ssid.Name = "lbl_ssid";
            this.lbl_ssid.Size = new System.Drawing.Size(150, 87);
            this.lbl_ssid.TabIndex = 10;
            this.lbl_ssid.Text = "SSID:";
            this.lbl_ssid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_ipHost
            // 
            this.lbl_ipHost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ipHost.AutoSize = true;
            this.lbl_ipHost.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_ipHost.Font = new System.Drawing.Font("Source Code Pro Semibold", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ipHost.Location = new System.Drawing.Point(4, 1);
            this.lbl_ipHost.Name = "lbl_ipHost";
            this.lbl_ipHost.Size = new System.Drawing.Size(86, 87);
            this.lbl_ipHost.TabIndex = 3;
            this.lbl_ipHost.Text = "IP Host:";
            this.lbl_ipHost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_hostText
            // 
            this.lbl_hostText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_hostText.AutoSize = true;
            this.lbl_hostText.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_hostText.Font = new System.Drawing.Font("Source Code Pro", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hostText.Location = new System.Drawing.Point(96, 1);
            this.lbl_hostText.Name = "lbl_hostText";
            this.lbl_hostText.Size = new System.Drawing.Size(82, 87);
            this.lbl_hostText.TabIndex = 2;
            this.lbl_hostText.Text = "text";
            this.lbl_hostText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1157, 272);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1175, 319);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1175, 319);
            this.Name = "Form1";
            this.Text = "VirtualBox ACT1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_hostText;
        private System.Windows.Forms.Label lbl_ipHost;
        private System.Windows.Forms.Label lbl_ipGateway;
        private System.Windows.Forms.Label lbl_hostNameText;
        private System.Windows.Forms.Label lbl_userNameText;
        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.Label lbl_gatewayText;
        private System.Windows.Forms.Label lbl_hostName;
        private System.Windows.Forms.Label lbl_ssid;
        private System.Windows.Forms.Label lbl_ssidStatus;
        private System.Windows.Forms.Label lbl_ssidStatusText;
        private System.Windows.Forms.Label lbl_ssidText;
        private System.Windows.Forms.Label lbl_MAC;
        private System.Windows.Forms.Label lbl_InternetCon;
        private System.Windows.Forms.Label lbl_MACText;
        private System.Windows.Forms.Label lbl_InternetText;
        private System.Windows.Forms.Label lbl_installedVB;
        private System.Windows.Forms.Label lbl_versionVB;
        private System.Windows.Forms.Label lbl_installedVBText;
        private System.Windows.Forms.Label lbl_versionVBText;
    }
}

