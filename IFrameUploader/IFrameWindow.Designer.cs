using System.Drawing;
using System.Windows.Forms;

namespace IFrameUploader
{
    partial class IFrameWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            MetroFramework.Controls.MetroLabel metroLabel3;
            MetroFramework.Controls.MetroLabel metroLabel2;
            MetroFramework.Controls.MetroLabel metroLabel1;
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.tabController = new MetroFramework.Controls.MetroTabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.txtAzureFolder = new System.Windows.Forms.TextBox();
            this.lblReset = new MetroFramework.Controls.MetroLink();
            this.btnUpload = new MetroFramework.Controls.MetroTile();
            this.chkOpenWebsite = new MetroFramework.Controls.MetroCheckBox();
            this.lblFilesFound = new MetroFramework.Controls.MetroLabel();
            this.txtAzurePath = new System.Windows.Forms.TextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnSelectFolder = new MetroFramework.Controls.MetroButton();
            this.txtBuildFolderPath = new System.Windows.Forms.TextBox();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.pnlStatus = new MetroFramework.Controls.MetroPanel();
            this.progressSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.lblStatus = new MetroFramework.Controls.MetroLabel();
            this.comboBlobEnvs = new MetroFramework.Controls.MetroComboBox();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.infoPanel = new IFrameUploader.InfoControl(this);
            this.metroStyleManager2 = new MetroFramework.Components.MetroStyleManager(this.components);
            metroLabel3 = new MetroFramework.Controls.MetroLabel();
            metroLabel2 = new MetroFramework.Controls.MetroLabel();
            metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.tabController.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.tabSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager2)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel3
            // 
            metroLabel3.AutoSize = true;
            metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            metroLabel3.Location = new System.Drawing.Point(6, 92);
            metroLabel3.Name = "metroLabel3";
            metroLabel3.Size = new System.Drawing.Size(100, 25);
            metroLabel3.TabIndex = 5;
            metroLabel3.Text = "Azure Path:";
            metroLabel3.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            metroLabel2.AutoSize = true;
            metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            metroLabel2.Location = new System.Drawing.Point(6, 9);
            metroLabel2.Name = "metroLabel2";
            metroLabel2.Size = new System.Drawing.Size(125, 25);
            metroLabel2.TabIndex = 2;
            metroLabel2.Text = "IFrame Folder:";
            metroLabel2.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            metroLabel1.AutoSize = true;
            metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            metroLabel1.Location = new System.Drawing.Point(0, 9);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new System.Drawing.Size(116, 25);
            metroLabel1.TabIndex = 1;
            metroLabel1.Text = "Environment:";
            metroLabel1.UseStyleColors = true;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // tabController
            // 
            this.tabController.Controls.Add(this.tabHome);
            this.tabController.Controls.Add(this.tabSettings);
            this.tabController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabController.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabController.Location = new System.Drawing.Point(20, 60);
            this.tabController.Name = "tabController";
            this.tabController.Padding = new System.Drawing.Point(6, 8);
            this.tabController.SelectedIndex = 0;
            this.tabController.Size = new System.Drawing.Size(551, 336);
            this.tabController.TabIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.metroPanel2);
            this.tabHome.Controls.Add(this.metroPanel3);
            this.tabHome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabHome.Location = new System.Drawing.Point(4, 35);
            this.tabHome.Name = "tabHome";
            this.tabHome.Size = new System.Drawing.Size(543, 297);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Uploader";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.txtAzureFolder);
            this.metroPanel2.Controls.Add(this.lblReset);
            this.metroPanel2.Controls.Add(this.btnUpload);
            this.metroPanel2.Controls.Add(this.chkOpenWebsite);
            this.metroPanel2.Controls.Add(this.lblFilesFound);
            this.metroPanel2.Controls.Add(this.txtAzurePath);
            this.metroPanel2.Controls.Add(this.metroLabel4);
            this.metroPanel2.Controls.Add(metroLabel3);
            this.metroPanel2.Controls.Add(this.btnSelectFolder);
            this.metroPanel2.Controls.Add(this.txtBuildFolderPath);
            this.metroPanel2.Controls.Add(metroLabel2);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(210, 0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(333, 297);
            this.metroPanel2.TabIndex = 5;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // txtAzureFolder
            // 
            this.txtAzureFolder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAzureFolder.Location = new System.Drawing.Point(185, 120);
            this.txtAzureFolder.MaxLength = 200;
            this.txtAzureFolder.Name = "txtAzureFolder";
            this.txtAzureFolder.Size = new System.Drawing.Size(145, 29);
            this.txtAzureFolder.TabIndex = 8;
            this.txtAzureFolder.Text = "<folder>";
            this.txtAzureFolder.TextChanged += new System.EventHandler(this.UpdateAzurePath);
            // 
            // lblReset
            // 
            this.lblReset.AutoSize = true;
            this.lblReset.Location = new System.Drawing.Point(270, 96);
            this.lblReset.Name = "lblReset";
            this.lblReset.Size = new System.Drawing.Size(60, 30);
            this.lblReset.TabIndex = 12;
            this.lblReset.Text = "Reset";
            this.lblReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(6, 255);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(324, 39);
            this.btnUpload.TabIndex = 11;
            this.btnUpload.Text = "Upload IFrame";
            this.btnUpload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpload.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnUpload.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // chkOpenWebsite
            // 
            this.chkOpenWebsite.AutoSize = true;
            this.chkOpenWebsite.Location = new System.Drawing.Point(6, 234);
            this.chkOpenWebsite.Name = "chkOpenWebsite";
            this.chkOpenWebsite.Size = new System.Drawing.Size(186, 15);
            this.chkOpenWebsite.TabIndex = 10;
            this.chkOpenWebsite.Text = "Open website after completion";
            this.chkOpenWebsite.UseVisualStyleBackColor = true;
            // 
            // lblFilesFound
            // 
            this.lblFilesFound.AutoSize = true;
            this.lblFilesFound.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblFilesFound.Location = new System.Drawing.Point(6, 66);
            this.lblFilesFound.Name = "lblFilesFound";
            this.lblFilesFound.Size = new System.Drawing.Size(78, 15);
            this.lblFilesFound.TabIndex = 9;
            this.lblFilesFound.Text = "Found {0} files.";
            this.lblFilesFound.Visible = false;
            // 
            // txtAzurePath
            // 
            this.txtAzurePath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAzurePath.Location = new System.Drawing.Point(6, 120);
            this.txtAzurePath.MaxLength = 200;
            this.txtAzurePath.Name = "txtAzurePath";
            this.txtAzurePath.Size = new System.Drawing.Size(163, 29);
            this.txtAzurePath.TabIndex = 6;
            this.txtAzurePath.Text = "$web";
            this.txtAzurePath.TextChanged += new System.EventHandler(this.UpdateAzurePath);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(168, 121);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(19, 25);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "/";
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSelectFolder.Highlight = true;
            this.btnSelectFolder.Location = new System.Drawing.Point(261, 36);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(69, 31);
            this.btnSelectFolder.TabIndex = 4;
            this.btnSelectFolder.Text = "Locate";
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // txtBuildFolderPath
            // 
            this.txtBuildFolderPath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBuildFolderPath.Location = new System.Drawing.Point(6, 37);
            this.txtBuildFolderPath.MaxLength = 200;
            this.txtBuildFolderPath.Name = "txtBuildFolderPath";
            this.txtBuildFolderPath.Size = new System.Drawing.Size(252, 29);
            this.txtBuildFolderPath.TabIndex = 3;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.pnlStatus);
            this.metroPanel3.Controls.Add(metroLabel1);
            this.metroPanel3.Controls.Add(this.comboBlobEnvs);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(0, 0);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(210, 297);
            this.metroPanel3.TabIndex = 6;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // pnlStatus
            // 
            this.pnlStatus.Controls.Add(this.progressSpinner);
            this.pnlStatus.Controls.Add(this.lblStatus);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStatus.HorizontalScrollbarBarColor = true;
            this.pnlStatus.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlStatus.HorizontalScrollbarSize = 10;
            this.pnlStatus.Location = new System.Drawing.Point(0, 180);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(210, 117);
            this.pnlStatus.TabIndex = 2;
            this.pnlStatus.VerticalScrollbarBarColor = true;
            this.pnlStatus.VerticalScrollbarHighlightOnWheel = false;
            this.pnlStatus.VerticalScrollbarSize = 10;
            this.pnlStatus.Visible = false;
            // 
            // progressSpinner
            // 
            this.progressSpinner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressSpinner.Location = new System.Drawing.Point(74, 42);
            this.progressSpinner.Maximum = 100;
            this.progressSpinner.Name = "progressSpinner";
            this.progressSpinner.Size = new System.Drawing.Size(52, 52);
            this.progressSpinner.Spinning = false;
            this.progressSpinner.TabIndex = 3;
            this.progressSpinner.Text = "metroProgressSpinner1";
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStatus.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblStatus.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblStatus.Location = new System.Drawing.Point(0, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(210, 39);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Uploading...";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBlobEnvs
            // 
            this.comboBlobEnvs.FormattingEnabled = true;
            this.comboBlobEnvs.ItemHeight = 23;
            this.comboBlobEnvs.Location = new System.Drawing.Point(0, 37);
            this.comboBlobEnvs.Name = "comboBlobEnvs";
            this.comboBlobEnvs.Size = new System.Drawing.Size(201, 29);
            this.comboBlobEnvs.TabIndex = 0;
            this.comboBlobEnvs.SelectionChangeCommitted += new System.EventHandler(this.comboBlobEnvs_SelectionChangeCommitted);
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.infoPanel);
            this.tabSettings.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabSettings.Location = new System.Drawing.Point(4, 35);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(192, 61);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
            // 
            // infoPanel
            // 
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoPanel.Location = new System.Drawing.Point(0, 0);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(192, 61);
            this.infoPanel.TabIndex = 0;
            // 
            // metroStyleManager2
            // 
            this.metroStyleManager2.Owner = null;
            // 
            // IFrameWindow
            // 
            this.ClientSize = new System.Drawing.Size(591, 416);
            this.Controls.Add(this.tabController);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(591, 416);
            this.MinimumSize = new System.Drawing.Size(591, 416);
            this.Name = "IFrameWindow";
            this.Text = "IFrame Uploader";
            this.Load += new System.EventHandler(this.Initialize);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.tabController.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroTabControl tabController;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabSettings;
        private IFrameUploader.InfoControl infoPanel;
        private MetroFramework.Components.MetroStyleManager metroStyleManager2;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private TextBox txtBuildFolderPath;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox comboBlobEnvs;
        private MetroFramework.Controls.MetroButton btnSelectFolder;
        private TextBox txtAzureFolder;
        private TextBox txtAzurePath;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lblFilesFound;
        private MetroFramework.Controls.MetroTile btnUpload;
        private MetroFramework.Controls.MetroCheckBox chkOpenWebsite;
        private MetroFramework.Controls.MetroPanel pnlStatus;
        private MetroFramework.Controls.MetroProgressSpinner progressSpinner;
        private MetroFramework.Controls.MetroLabel lblStatus;
        private MetroFramework.Controls.MetroLink lblReset;
    }
}