using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LibraryTool
{
  partial class Main
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle103 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle106 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle107 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle104 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle105 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle108 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle109 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle110 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle111 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle112 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle113 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle114 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle115 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle116 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle117 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle118 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle119 = new System.Windows.Forms.DataGridViewCellStyle();
      this.panel1 = new System.Windows.Forms.Panel();
      this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
      this.lbl_Header = new System.Windows.Forms.Label();
      this.il_buttons = new System.Windows.Forms.ImageList(this.components);
      this.tab_sideBar = new ReaLTaiizor.Controls.TabPage();
      this.tab_Dashboard = new System.Windows.Forms.TabPage();
      this.pnl_DashboardNote = new System.Windows.Forms.Panel();
      this.pnl_DashboardNotePadding = new System.Windows.Forms.Panel();
      this.text_Note = new System.Windows.Forms.TextBox();
      this.pnl_DashboardNoteHeader = new System.Windows.Forms.Panel();
      this.lbl_DashboardNoteHeader = new ReaLTaiizor.Controls.SkyLabel();
      this.pnl_DashboardBackup = new System.Windows.Forms.Panel();
      this.img_DashboardBackup = new System.Windows.Forms.PictureBox();
      this.lbl_DashboardBackupDate = new ReaLTaiizor.Controls.SkyLabel();
      this.lbl_DashboardBackup = new ReaLTaiizor.Controls.SkyLabel();
      this.lbl_DashboardBackupState = new ReaLTaiizor.Controls.SkyLabel();
      this.pnl_DashboardKids = new System.Windows.Forms.Panel();
      this.img_DashboardKids = new System.Windows.Forms.PictureBox();
      this.lbl_DashboardKidsGroups = new ReaLTaiizor.Controls.SkyLabel();
      this.lbl_DashboardKids = new ReaLTaiizor.Controls.SkyLabel();
      this.lbl_DashboardKidsTotal = new ReaLTaiizor.Controls.SkyLabel();
      this.pnl_DashboardBooks = new System.Windows.Forms.Panel();
      this.img_DashboardBook = new System.Windows.Forms.PictureBox();
      this.lbl_DashboardBooksRented = new ReaLTaiizor.Controls.SkyLabel();
      this.lbl_DashboardBooks = new ReaLTaiizor.Controls.SkyLabel();
      this.lbl_DashboardBooksTotal = new ReaLTaiizor.Controls.SkyLabel();
      this.tab_Rental = new System.Windows.Forms.TabPage();
      this.pnl_RentalActions = new System.Windows.Forms.Panel();
      this.pnl_RentalActionsHeader = new System.Windows.Forms.Panel();
      this.lbl_RentalAction = new System.Windows.Forms.Label();
      this.text_RentalID = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
      this.text_RentalBarcode = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
      this.pnl_RentalBooks = new System.Windows.Forms.Panel();
      this.gr_RentalBooks = new System.Windows.Forms.DataGridView();
      this.gr_RentalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.gr_RentalBooksId = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.gr_RentalBooksName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.pnl_RentalBooksHeader = new System.Windows.Forms.Panel();
      this.lbl_RentalBooksHeader = new ReaLTaiizor.Controls.SkyLabel();
      this.pnl_RentalKids = new System.Windows.Forms.Panel();
      this.gr_RentalKids = new System.Windows.Forms.DataGridView();
      this.gr_RentalKidsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.gr_RentalKidsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.gr_KidsSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.gr_KidsGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.gr_KidsRentalCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.pnl_RentalKidsHeader = new System.Windows.Forms.Panel();
      this.cbb_RentalGroup = new ReaLTaiizor.Controls.ForeverComboBox();
      this.tab_Return = new System.Windows.Forms.TabPage();
      this.pnl_ReturnAction = new System.Windows.Forms.Panel();
      this.pnl_ReturnActionHeader = new System.Windows.Forms.Panel();
      this.lbl_ReturnActionHeader = new System.Windows.Forms.Label();
      this.text_ReturnActionID = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
      this.text_ReturnActionBarcode = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
      this.tab_Inventory = new System.Windows.Forms.TabPage();
      this.pnl_BooksInventory = new System.Windows.Forms.Panel();
      this.btn_BooksInventoryStart = new ReaLTaiizor.Controls.ForeverButton();
      this.btn_BooksInventoryContinue = new ReaLTaiizor.Controls.ForeverButton();
      this.panel3 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.btn_BooksInventoryPrintParentInfo = new ReaLTaiizor.Controls.ForeverButton();
      this.pnl_BooksNew = new System.Windows.Forms.Panel();
      this.pnl_BooksNewHeader = new System.Windows.Forms.Panel();
      this.lbl_BooksNewHeader = new System.Windows.Forms.Label();
      this.text_BooksNewName = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
      this.text_BooksNewBarcode = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
      this.text_BooksNewID = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
      this.btn_BooksSave = new ReaLTaiizor.Controls.ForeverButton();
      this.pnl_Books = new System.Windows.Forms.Panel();
      this.gr_Books = new System.Windows.Forms.DataGridView();
      this.gr_BooksID = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.gr_BooksExternalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.gr_BooksName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.gr_BooksBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.gr_BooksBarcodeScan = new System.Windows.Forms.DataGridViewButtonColumn();
      this.gr_BooksRented = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.gr_BooksDelete = new System.Windows.Forms.DataGridViewButtonColumn();
      this.gr_BooksInventoryCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.pnl_BooksHeader = new System.Windows.Forms.Panel();
      this.text_BooksFilter = new ReaLTaiizor.Controls.CrownTextBox();
      this.lbl_BooksHeader = new ReaLTaiizor.Controls.SkyLabel();
      this.tab_Kids = new System.Windows.Forms.TabPage();
      this.pnl_AllKidsAddContainer = new System.Windows.Forms.Panel();
      this.text_NewKidsFirstName = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
      this.text_NewKidsSurname = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.cbb_NewKidGroup = new ReaLTaiizor.Controls.MaterialComboBox();
      this.pnl_AllKidsAdd = new System.Windows.Forms.Panel();
      this.lbl_AllKidsAddHeader = new System.Windows.Forms.Label();
      this.btn_AllKidsAdd = new ReaLTaiizor.Controls.ForeverButton();
      this.pnl_AllKids = new System.Windows.Forms.Panel();
      this.gr_AllKids = new System.Windows.Forms.DataGridView();
      this.gr_AllKidsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.gr_AllKidsFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.gr_AllKidsSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.gr_AllKidsGroup = new System.Windows.Forms.DataGridViewComboBoxColumn();
      this.gr_AllKidsDelete = new System.Windows.Forms.DataGridViewButtonColumn();
      this.pnl_AllKidsHeader = new System.Windows.Forms.Panel();
      this.text_KidsFilter = new ReaLTaiizor.Controls.CrownTextBox();
      this.lbl_AllKidsHeader = new ReaLTaiizor.Controls.SkyLabel();
      this.tab_History = new System.Windows.Forms.TabPage();
      this.pnl_LastActions = new System.Windows.Forms.Panel();
      this.gr_LastActions = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.gr_LastActionsOperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.gr_LastActionsTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.gr_LastActionsValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.gr_LastActionsTimestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.pnl_LastActionsHeader = new System.Windows.Forms.Panel();
      this.text_HistoryFilter = new ReaLTaiizor.Controls.CrownTextBox();
      this.lbl_LastActionsHeader = new ReaLTaiizor.Controls.SkyLabel();
      this.tab_Settings = new System.Windows.Forms.TabPage();
      this.pnl_SettingsInfo = new System.Windows.Forms.Panel();
      this.text_InfoVersion = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
      this.text_InfoAuthor = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
      this.text_InfoPhone = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
      this.panel8 = new System.Windows.Forms.Panel();
      this.label2 = new System.Windows.Forms.Label();
      this.text_InfoEmail = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
      this.foreverButton1 = new ReaLTaiizor.Controls.ForeverButton();
      this.pnl_SettingsBackup = new System.Windows.Forms.Panel();
      this.pnl_SettingsBackupContent = new System.Windows.Forms.Panel();
      this.text_SettingsScanSensitivity = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
      this.toggle_SettingsBackupActive = new ReaLTaiizor.Controls.ForeverToggle();
      this.lbl_SettingsBackupActive = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
      this.text_SettingsBackupPath = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
      this.pnl_SettingsBackupHeader = new System.Windows.Forms.Panel();
      this.lbl_SettingsBackupHeader = new ReaLTaiizor.Controls.SkyLabel();
      this.il_smallButtons = new System.Windows.Forms.ImageList(this.components);
      this.il_books = new System.Windows.Forms.ImageList(this.components);
      this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
      this.text_Github = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
      this.panel1.SuspendLayout();
      this.tab_sideBar.SuspendLayout();
      this.tab_Dashboard.SuspendLayout();
      this.pnl_DashboardNote.SuspendLayout();
      this.pnl_DashboardNotePadding.SuspendLayout();
      this.pnl_DashboardNoteHeader.SuspendLayout();
      this.pnl_DashboardBackup.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.img_DashboardBackup)).BeginInit();
      this.pnl_DashboardKids.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.img_DashboardKids)).BeginInit();
      this.pnl_DashboardBooks.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.img_DashboardBook)).BeginInit();
      this.tab_Rental.SuspendLayout();
      this.pnl_RentalActions.SuspendLayout();
      this.pnl_RentalActionsHeader.SuspendLayout();
      this.pnl_RentalBooks.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gr_RentalBooks)).BeginInit();
      this.pnl_RentalBooksHeader.SuspendLayout();
      this.pnl_RentalKids.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gr_RentalKids)).BeginInit();
      this.pnl_RentalKidsHeader.SuspendLayout();
      this.tab_Return.SuspendLayout();
      this.pnl_ReturnAction.SuspendLayout();
      this.pnl_ReturnActionHeader.SuspendLayout();
      this.tab_Inventory.SuspendLayout();
      this.pnl_BooksInventory.SuspendLayout();
      this.panel3.SuspendLayout();
      this.pnl_BooksNew.SuspendLayout();
      this.pnl_BooksNewHeader.SuspendLayout();
      this.pnl_Books.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gr_Books)).BeginInit();
      this.pnl_BooksHeader.SuspendLayout();
      this.tab_Kids.SuspendLayout();
      this.pnl_AllKidsAddContainer.SuspendLayout();
      this.panel2.SuspendLayout();
      this.pnl_AllKidsAdd.SuspendLayout();
      this.pnl_AllKids.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gr_AllKids)).BeginInit();
      this.pnl_AllKidsHeader.SuspendLayout();
      this.tab_History.SuspendLayout();
      this.pnl_LastActions.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gr_LastActions)).BeginInit();
      this.pnl_LastActionsHeader.SuspendLayout();
      this.tab_Settings.SuspendLayout();
      this.pnl_SettingsInfo.SuspendLayout();
      this.panel8.SuspendLayout();
      this.pnl_SettingsBackup.SuspendLayout();
      this.pnl_SettingsBackupContent.SuspendLayout();
      this.pnl_SettingsBackupHeader.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
      this.panel1.Controls.Add(this.nightControlBox1);
      this.panel1.Controls.Add(this.lbl_Header);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1007, 40);
      this.panel1.TabIndex = 0;
      this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
      // 
      // nightControlBox1
      // 
      this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
      this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
      this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
      this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
      this.nightControlBox1.DefaultLocation = true;
      this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
      this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
      this.nightControlBox1.Dock = System.Windows.Forms.DockStyle.Right;
      this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
      this.nightControlBox1.EnableMaximizeButton = false;
      this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
      this.nightControlBox1.EnableMinimizeButton = true;
      this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
      this.nightControlBox1.Location = new System.Drawing.Point(868, 0);
      this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
      this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
      this.nightControlBox1.Name = "nightControlBox1";
      this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
      this.nightControlBox1.TabIndex = 1;
      // 
      // lbl_Header
      // 
      this.lbl_Header.AutoSize = true;
      this.lbl_Header.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
      this.lbl_Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      this.lbl_Header.Location = new System.Drawing.Point(12, 9);
      this.lbl_Header.Name = "lbl_Header";
      this.lbl_Header.Size = new System.Drawing.Size(89, 21);
      this.lbl_Header.TabIndex = 0;
      this.lbl_Header.Text = "Bibliothek";
      this.lbl_Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
      // 
      // il_buttons
      // 
      this.il_buttons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("il_buttons.ImageStream")));
      this.il_buttons.TransparentColor = System.Drawing.Color.Transparent;
      this.il_buttons.Images.SetKeyName(0, "home-icon-silhouette.png");
      this.il_buttons.Images.SetKeyName(1, "buch.png");
      this.il_buttons.Images.SetKeyName(2, "buchReturn.png");
      this.il_buttons.Images.SetKeyName(3, "checkliste.png");
      this.il_buttons.Images.SetKeyName(4, "silhouette-mehrerer-benutzer.png");
      this.il_buttons.Images.SetKeyName(5, "timer.png");
      this.il_buttons.Images.SetKeyName(6, "settings.png");
      this.il_buttons.Images.SetKeyName(7, "folder.png");
      // 
      // tab_sideBar
      // 
      this.tab_sideBar.ActiveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tab_sideBar.ActiveLineTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      this.tab_sideBar.ActiveTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
      this.tab_sideBar.Alignment = System.Windows.Forms.TabAlignment.Left;
      this.tab_sideBar.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
      this.tab_sideBar.CompositingType = System.Drawing.Drawing2D.CompositingMode.SourceOver;
      this.tab_sideBar.ControlBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      this.tab_sideBar.Controls.Add(this.tab_Dashboard);
      this.tab_sideBar.Controls.Add(this.tab_Rental);
      this.tab_sideBar.Controls.Add(this.tab_Return);
      this.tab_sideBar.Controls.Add(this.tab_Inventory);
      this.tab_sideBar.Controls.Add(this.tab_Kids);
      this.tab_sideBar.Controls.Add(this.tab_History);
      this.tab_sideBar.Controls.Add(this.tab_Settings);
      this.tab_sideBar.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tab_sideBar.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
      this.tab_sideBar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tab_sideBar.FrameColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
      this.tab_sideBar.ImageList = this.il_buttons;
      this.tab_sideBar.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
      this.tab_sideBar.ItemSize = new System.Drawing.Size(44, 160);
      this.tab_sideBar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      this.tab_sideBar.LineTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
      this.tab_sideBar.Location = new System.Drawing.Point(0, 40);
      this.tab_sideBar.Multiline = true;
      this.tab_sideBar.Name = "tab_sideBar";
      this.tab_sideBar.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
      this.tab_sideBar.PageColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      this.tab_sideBar.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
      this.tab_sideBar.SelectedIndex = 0;
      this.tab_sideBar.Size = new System.Drawing.Size(1007, 595);
      this.tab_sideBar.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
      this.tab_sideBar.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
      this.tab_sideBar.StringType = System.Drawing.StringAlignment.Near;
      this.tab_sideBar.TabColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      this.tab_sideBar.TabIndex = 1;
      this.tab_sideBar.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
      this.tab_sideBar.SelectedIndexChanged += new System.EventHandler(this.tab_sideBar_SelectedIndexChanged);
      // 
      // tab_Dashboard
      // 
      this.tab_Dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      this.tab_Dashboard.Controls.Add(this.pnl_DashboardNote);
      this.tab_Dashboard.Controls.Add(this.pnl_DashboardBackup);
      this.tab_Dashboard.Controls.Add(this.pnl_DashboardKids);
      this.tab_Dashboard.Controls.Add(this.pnl_DashboardBooks);
      this.tab_Dashboard.ImageIndex = 0;
      this.tab_Dashboard.Location = new System.Drawing.Point(164, 4);
      this.tab_Dashboard.Margin = new System.Windows.Forms.Padding(0);
      this.tab_Dashboard.Name = "tab_Dashboard";
      this.tab_Dashboard.Size = new System.Drawing.Size(839, 587);
      this.tab_Dashboard.TabIndex = 0;
      this.tab_Dashboard.Text = "Dashboard";
      // 
      // pnl_DashboardNote
      // 
      this.pnl_DashboardNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.pnl_DashboardNote.Controls.Add(this.pnl_DashboardNotePadding);
      this.pnl_DashboardNote.Controls.Add(this.pnl_DashboardNoteHeader);
      this.pnl_DashboardNote.Location = new System.Drawing.Point(32, 168);
      this.pnl_DashboardNote.Name = "pnl_DashboardNote";
      this.pnl_DashboardNote.Size = new System.Drawing.Size(452, 385);
      this.pnl_DashboardNote.TabIndex = 10;
      // 
      // pnl_DashboardNotePadding
      // 
      this.pnl_DashboardNotePadding.BackColor = System.Drawing.Color.White;
      this.pnl_DashboardNotePadding.Controls.Add(this.text_Note);
      this.pnl_DashboardNotePadding.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnl_DashboardNotePadding.Location = new System.Drawing.Point(0, 32);
      this.pnl_DashboardNotePadding.Name = "pnl_DashboardNotePadding";
      this.pnl_DashboardNotePadding.Padding = new System.Windows.Forms.Padding(8);
      this.pnl_DashboardNotePadding.Size = new System.Drawing.Size(452, 353);
      this.pnl_DashboardNotePadding.TabIndex = 11;
      // 
      // text_Note
      // 
      this.text_Note.BackColor = System.Drawing.Color.White;
      this.text_Note.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.text_Note.Dock = System.Windows.Forms.DockStyle.Fill;
      this.text_Note.Font = new System.Drawing.Font("Segoe UI", 11F);
      this.text_Note.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      this.text_Note.Location = new System.Drawing.Point(8, 8);
      this.text_Note.Margin = new System.Windows.Forms.Padding(0);
      this.text_Note.Multiline = true;
      this.text_Note.Name = "text_Note";
      this.text_Note.Size = new System.Drawing.Size(436, 337);
      this.text_Note.TabIndex = 12;
      this.text_Note.Text = resources.GetString("text_Note.Text");
      this.text_Note.Validated += new System.EventHandler(this.text_Note_Validated);
      // 
      // pnl_DashboardNoteHeader
      // 
      this.pnl_DashboardNoteHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      this.pnl_DashboardNoteHeader.Controls.Add(this.lbl_DashboardNoteHeader);
      this.pnl_DashboardNoteHeader.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnl_DashboardNoteHeader.Location = new System.Drawing.Point(0, 0);
      this.pnl_DashboardNoteHeader.Name = "pnl_DashboardNoteHeader";
      this.pnl_DashboardNoteHeader.Size = new System.Drawing.Size(452, 32);
      this.pnl_DashboardNoteHeader.TabIndex = 13;
      // 
      // lbl_DashboardNoteHeader
      // 
      this.lbl_DashboardNoteHeader.BackColor = System.Drawing.Color.Transparent;
      this.lbl_DashboardNoteHeader.Dock = System.Windows.Forms.DockStyle.Left;
      this.lbl_DashboardNoteHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.lbl_DashboardNoteHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
      this.lbl_DashboardNoteHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      this.lbl_DashboardNoteHeader.Location = new System.Drawing.Point(0, 0);
      this.lbl_DashboardNoteHeader.Name = "lbl_DashboardNoteHeader";
      this.lbl_DashboardNoteHeader.Size = new System.Drawing.Size(103, 32);
      this.lbl_DashboardNoteHeader.TabIndex = 13;
      this.lbl_DashboardNoteHeader.Text = "  Notiz";
      this.lbl_DashboardNoteHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // pnl_DashboardBackup
      // 
      this.pnl_DashboardBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
      this.pnl_DashboardBackup.Controls.Add(this.img_DashboardBackup);
      this.pnl_DashboardBackup.Controls.Add(this.lbl_DashboardBackupDate);
      this.pnl_DashboardBackup.Controls.Add(this.lbl_DashboardBackup);
      this.pnl_DashboardBackup.Controls.Add(this.lbl_DashboardBackupState);
      this.pnl_DashboardBackup.Location = new System.Drawing.Point(516, 32);
      this.pnl_DashboardBackup.Margin = new System.Windows.Forms.Padding(0);
      this.pnl_DashboardBackup.Name = "pnl_DashboardBackup";
      this.pnl_DashboardBackup.Size = new System.Drawing.Size(210, 104);
      this.pnl_DashboardBackup.TabIndex = 9;
      // 
      // img_DashboardBackup
      // 
      this.img_DashboardBackup.Image = ((System.Drawing.Image)(resources.GetObject("img_DashboardBackup.Image")));
      this.img_DashboardBackup.Location = new System.Drawing.Point(127, 12);
      this.img_DashboardBackup.Name = "img_DashboardBackup";
      this.img_DashboardBackup.Size = new System.Drawing.Size(64, 62);
      this.img_DashboardBackup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.img_DashboardBackup.TabIndex = 9;
      this.img_DashboardBackup.TabStop = false;
      // 
      // lbl_DashboardBackupDate
      // 
      this.lbl_DashboardBackupDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.lbl_DashboardBackupDate.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.lbl_DashboardBackupDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      this.lbl_DashboardBackupDate.Location = new System.Drawing.Point(18, 68);
      this.lbl_DashboardBackupDate.Name = "lbl_DashboardBackupDate";
      this.lbl_DashboardBackupDate.Size = new System.Drawing.Size(158, 22);
      this.lbl_DashboardBackupDate.TabIndex = 7;
      this.lbl_DashboardBackupDate.Text = "04.03.2024";
      // 
      // lbl_DashboardBackup
      // 
      this.lbl_DashboardBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.lbl_DashboardBackup.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.lbl_DashboardBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      this.lbl_DashboardBackup.Location = new System.Drawing.Point(18, 12);
      this.lbl_DashboardBackup.Name = "lbl_DashboardBackup";
      this.lbl_DashboardBackup.Size = new System.Drawing.Size(103, 22);
      this.lbl_DashboardBackup.TabIndex = 6;
      this.lbl_DashboardBackup.Text = "Sicherung";
      // 
      // lbl_DashboardBackupState
      // 
      this.lbl_DashboardBackupState.AutoSize = true;
      this.lbl_DashboardBackupState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.lbl_DashboardBackupState.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
      this.lbl_DashboardBackupState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      this.lbl_DashboardBackupState.Location = new System.Drawing.Point(15, 31);
      this.lbl_DashboardBackupState.Name = "lbl_DashboardBackupState";
      this.lbl_DashboardBackupState.Size = new System.Drawing.Size(85, 37);
      this.lbl_DashboardBackupState.TabIndex = 5;
      this.lbl_DashboardBackupState.Text = "Aktiv";
      // 
      // pnl_DashboardKids
      // 
      this.pnl_DashboardKids.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
      this.pnl_DashboardKids.Controls.Add(this.img_DashboardKids);
      this.pnl_DashboardKids.Controls.Add(this.lbl_DashboardKidsGroups);
      this.pnl_DashboardKids.Controls.Add(this.lbl_DashboardKids);
      this.pnl_DashboardKids.Controls.Add(this.lbl_DashboardKidsTotal);
      this.pnl_DashboardKids.Location = new System.Drawing.Point(274, 32);
      this.pnl_DashboardKids.Margin = new System.Windows.Forms.Padding(0);
      this.pnl_DashboardKids.Name = "pnl_DashboardKids";
      this.pnl_DashboardKids.Size = new System.Drawing.Size(210, 104);
      this.pnl_DashboardKids.TabIndex = 8;
      // 
      // img_DashboardKids
      // 
      this.img_DashboardKids.Image = ((System.Drawing.Image)(resources.GetObject("img_DashboardKids.Image")));
      this.img_DashboardKids.Location = new System.Drawing.Point(127, 12);
      this.img_DashboardKids.Name = "img_DashboardKids";
      this.img_DashboardKids.Size = new System.Drawing.Size(64, 62);
      this.img_DashboardKids.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.img_DashboardKids.TabIndex = 9;
      this.img_DashboardKids.TabStop = false;
      // 
      // lbl_DashboardKidsGroups
      // 
      this.lbl_DashboardKidsGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.lbl_DashboardKidsGroups.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.lbl_DashboardKidsGroups.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      this.lbl_DashboardKidsGroups.Location = new System.Drawing.Point(18, 68);
      this.lbl_DashboardKidsGroups.Name = "lbl_DashboardKidsGroups";
      this.lbl_DashboardKidsGroups.Size = new System.Drawing.Size(158, 22);
      this.lbl_DashboardKidsGroups.TabIndex = 7;
      this.lbl_DashboardKidsGroups.Text = "12/18/27";
      // 
      // lbl_DashboardKids
      // 
      this.lbl_DashboardKids.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.lbl_DashboardKids.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.lbl_DashboardKids.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      this.lbl_DashboardKids.Location = new System.Drawing.Point(18, 12);
      this.lbl_DashboardKids.Name = "lbl_DashboardKids";
      this.lbl_DashboardKids.Size = new System.Drawing.Size(103, 22);
      this.lbl_DashboardKids.TabIndex = 6;
      this.lbl_DashboardKids.Text = "Kinder";
      // 
      // lbl_DashboardKidsTotal
      // 
      this.lbl_DashboardKidsTotal.AutoSize = true;
      this.lbl_DashboardKidsTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.lbl_DashboardKidsTotal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
      this.lbl_DashboardKidsTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      this.lbl_DashboardKidsTotal.Location = new System.Drawing.Point(15, 31);
      this.lbl_DashboardKidsTotal.Name = "lbl_DashboardKidsTotal";
      this.lbl_DashboardKidsTotal.Size = new System.Drawing.Size(49, 37);
      this.lbl_DashboardKidsTotal.TabIndex = 5;
      this.lbl_DashboardKidsTotal.Text = "58";
      // 
      // pnl_DashboardBooks
      // 
      this.pnl_DashboardBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
      this.pnl_DashboardBooks.Controls.Add(this.img_DashboardBook);
      this.pnl_DashboardBooks.Controls.Add(this.lbl_DashboardBooksRented);
      this.pnl_DashboardBooks.Controls.Add(this.lbl_DashboardBooks);
      this.pnl_DashboardBooks.Controls.Add(this.lbl_DashboardBooksTotal);
      this.pnl_DashboardBooks.Location = new System.Drawing.Point(32, 32);
      this.pnl_DashboardBooks.Margin = new System.Windows.Forms.Padding(0);
      this.pnl_DashboardBooks.Name = "pnl_DashboardBooks";
      this.pnl_DashboardBooks.Size = new System.Drawing.Size(210, 104);
      this.pnl_DashboardBooks.TabIndex = 7;
      // 
      // img_DashboardBook
      // 
      this.img_DashboardBook.Image = ((System.Drawing.Image)(resources.GetObject("img_DashboardBook.Image")));
      this.img_DashboardBook.Location = new System.Drawing.Point(127, 12);
      this.img_DashboardBook.Name = "img_DashboardBook";
      this.img_DashboardBook.Size = new System.Drawing.Size(64, 62);
      this.img_DashboardBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.img_DashboardBook.TabIndex = 8;
      this.img_DashboardBook.TabStop = false;
      // 
      // lbl_DashboardBooksRented
      // 
      this.lbl_DashboardBooksRented.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.lbl_DashboardBooksRented.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.lbl_DashboardBooksRented.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      this.lbl_DashboardBooksRented.Location = new System.Drawing.Point(18, 68);
      this.lbl_DashboardBooksRented.Name = "lbl_DashboardBooksRented";
      this.lbl_DashboardBooksRented.Size = new System.Drawing.Size(116, 22);
      this.lbl_DashboardBooksRented.TabIndex = 7;
      this.lbl_DashboardBooksRented.Text = "72 verliehen";
      // 
      // lbl_DashboardBooks
      // 
      this.lbl_DashboardBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.lbl_DashboardBooks.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.lbl_DashboardBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      this.lbl_DashboardBooks.Location = new System.Drawing.Point(18, 12);
      this.lbl_DashboardBooks.Name = "lbl_DashboardBooks";
      this.lbl_DashboardBooks.Size = new System.Drawing.Size(103, 22);
      this.lbl_DashboardBooks.TabIndex = 6;
      this.lbl_DashboardBooks.Text = "Bücher";
      // 
      // lbl_DashboardBooksTotal
      // 
      this.lbl_DashboardBooksTotal.AutoSize = true;
      this.lbl_DashboardBooksTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.lbl_DashboardBooksTotal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
      this.lbl_DashboardBooksTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      this.lbl_DashboardBooksTotal.Location = new System.Drawing.Point(15, 31);
      this.lbl_DashboardBooksTotal.Name = "lbl_DashboardBooksTotal";
      this.lbl_DashboardBooksTotal.Size = new System.Drawing.Size(65, 37);
      this.lbl_DashboardBooksTotal.TabIndex = 5;
      this.lbl_DashboardBooksTotal.Text = "815";
      // 
      // tab_Rental
      // 
      this.tab_Rental.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      this.tab_Rental.Controls.Add(this.pnl_RentalActions);
      this.tab_Rental.Controls.Add(this.pnl_RentalBooks);
      this.tab_Rental.Controls.Add(this.pnl_RentalKids);
      this.tab_Rental.ImageIndex = 1;
      this.tab_Rental.Location = new System.Drawing.Point(164, 4);
      this.tab_Rental.Name = "tab_Rental";
      this.tab_Rental.Padding = new System.Windows.Forms.Padding(3);
      this.tab_Rental.Size = new System.Drawing.Size(839, 587);
      this.tab_Rental.TabIndex = 1;
      this.tab_Rental.Text = "Bücherverleih";
      // 
      // pnl_RentalActions
      // 
      this.pnl_RentalActions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.pnl_RentalActions.BackColor = System.Drawing.Color.White;
      this.pnl_RentalActions.Controls.Add(this.pnl_RentalActionsHeader);
      this.pnl_RentalActions.Controls.Add(this.text_RentalID);
      this.pnl_RentalActions.Controls.Add(this.text_RentalBarcode);
      this.pnl_RentalActions.Location = new System.Drawing.Point(544, 32);
      this.pnl_RentalActions.Name = "pnl_RentalActions";
      this.pnl_RentalActions.Size = new System.Drawing.Size(262, 132);
      this.pnl_RentalActions.TabIndex = 16;
      // 
      // pnl_RentalActionsHeader
      // 
      this.pnl_RentalActionsHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      this.pnl_RentalActionsHeader.Controls.Add(this.lbl_RentalAction);
      this.pnl_RentalActionsHeader.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnl_RentalActionsHeader.Location = new System.Drawing.Point(0, 0);
      this.pnl_RentalActionsHeader.Name = "pnl_RentalActionsHeader";
      this.pnl_RentalActionsHeader.Size = new System.Drawing.Size(262, 36);
      this.pnl_RentalActionsHeader.TabIndex = 20;
      // 
      // lbl_RentalAction
      // 
      this.lbl_RentalAction.AutoSize = true;
      this.lbl_RentalAction.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_RentalAction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      this.lbl_RentalAction.Location = new System.Drawing.Point(3, 7);
      this.lbl_RentalAction.Name = "lbl_RentalAction";
      this.lbl_RentalAction.Size = new System.Drawing.Size(251, 20);
      this.lbl_RentalAction.TabIndex = 18;
      this.lbl_RentalAction.Text = "Barcode scannen oder ID eingeben";
      // 
      // text_RentalID
      // 
      this.text_RentalID.AllowPromptAsInput = true;
      this.text_RentalID.AnimateReadOnly = false;
      this.text_RentalID.AsciiOnly = false;
      this.text_RentalID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.text_RentalID.BeepOnError = false;
      this.text_RentalID.CausesValidation = false;
      this.text_RentalID.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
      this.text_RentalID.Depth = 0;
      this.text_RentalID.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.text_RentalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.text_RentalID.HidePromptOnLeave = false;
      this.text_RentalID.HideSelection = true;
      this.text_RentalID.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
      this.text_RentalID.LeadingIcon = null;
      this.text_RentalID.Location = new System.Drawing.Point(0, 36);
      this.text_RentalID.Mask = "";
      this.text_RentalID.MaxLength = 32767;
      this.text_RentalID.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
      this.text_RentalID.Name = "text_RentalID";
      this.text_RentalID.PasswordChar = '\0';
      this.text_RentalID.PrefixSuffix = ReaLTaiizor.Controls.MaterialMaskedTextBox.PrefixSuffixTypes.Prefix;
      this.text_RentalID.PrefixSuffixText = "ID:                ";
      this.text_RentalID.PromptChar = '_';
      this.text_RentalID.ReadOnly = false;
      this.text_RentalID.RejectInputOnFirstFailure = false;
      this.text_RentalID.ResetOnPrompt = true;
      this.text_RentalID.ResetOnSpace = true;
      this.text_RentalID.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.text_RentalID.SelectedText = "";
      this.text_RentalID.SelectionLength = 0;
      this.text_RentalID.SelectionStart = 0;
      this.text_RentalID.ShortcutsEnabled = true;
      this.text_RentalID.Size = new System.Drawing.Size(262, 48);
      this.text_RentalID.SkipLiterals = true;
      this.text_RentalID.TabIndex = 2;
      this.text_RentalID.TabStop = false;
      this.text_RentalID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.text_RentalID.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
      this.text_RentalID.TrailingIcon = null;
      this.text_RentalID.UseSystemPasswordChar = false;
      this.text_RentalID.ValidatingType = null;
      this.text_RentalID.Enter += new System.EventHandler(this.text_Enter);
      this.text_RentalID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_RentalID_KeyDown);
      // 
      // text_RentalBarcode
      // 
      this.text_RentalBarcode.AllowPromptAsInput = true;
      this.text_RentalBarcode.AnimateReadOnly = true;
      this.text_RentalBarcode.AsciiOnly = false;
      this.text_RentalBarcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.text_RentalBarcode.BeepOnError = false;
      this.text_RentalBarcode.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
      this.text_RentalBarcode.Depth = 0;
      this.text_RentalBarcode.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.text_RentalBarcode.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.text_RentalBarcode.HidePromptOnLeave = false;
      this.text_RentalBarcode.HideSelection = true;
      this.text_RentalBarcode.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
      this.text_RentalBarcode.LeadingIcon = null;
      this.text_RentalBarcode.Location = new System.Drawing.Point(0, 84);
      this.text_RentalBarcode.Mask = "";
      this.text_RentalBarcode.MaxLength = 32767;
      this.text_RentalBarcode.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
      this.text_RentalBarcode.Name = "text_RentalBarcode";
      this.text_RentalBarcode.PasswordChar = '\0';
      this.text_RentalBarcode.PrefixSuffix = ReaLTaiizor.Controls.MaterialMaskedTextBox.PrefixSuffixTypes.Prefix;
      this.text_RentalBarcode.PrefixSuffixText = "Barcode:     ";
      this.text_RentalBarcode.PromptChar = '_';
      this.text_RentalBarcode.ReadOnly = true;
      this.text_RentalBarcode.RejectInputOnFirstFailure = false;
      this.text_RentalBarcode.ResetOnPrompt = true;
      this.text_RentalBarcode.ResetOnSpace = true;
      this.text_RentalBarcode.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.text_RentalBarcode.SelectedText = "";
      this.text_RentalBarcode.SelectionLength = 0;
      this.text_RentalBarcode.SelectionStart = 0;
      this.text_RentalBarcode.ShortcutsEnabled = true;
      this.text_RentalBarcode.Size = new System.Drawing.Size(262, 48);
      this.text_RentalBarcode.SkipLiterals = true;
      this.text_RentalBarcode.TabIndex = 3;
      this.text_RentalBarcode.TabStop = false;
      this.text_RentalBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.text_RentalBarcode.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
      this.text_RentalBarcode.TrailingIcon = null;
      this.text_RentalBarcode.UseSystemPasswordChar = false;
      this.text_RentalBarcode.ValidatingType = null;
      // 
      // pnl_RentalBooks
      // 
      this.pnl_RentalBooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pnl_RentalBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      this.pnl_RentalBooks.Controls.Add(this.gr_RentalBooks);
      this.pnl_RentalBooks.Controls.Add(this.pnl_RentalBooksHeader);
      this.pnl_RentalBooks.Location = new System.Drawing.Point(544, 202);
      this.pnl_RentalBooks.Name = "pnl_RentalBooks";
      this.pnl_RentalBooks.Padding = new System.Windows.Forms.Padding(3, 3, 3, 16);
      this.pnl_RentalBooks.Size = new System.Drawing.Size(263, 352);
      this.pnl_RentalBooks.TabIndex = 13;
      // 
      // gr_RentalBooks
      // 
      this.gr_RentalBooks.AllowUserToAddRows = false;
      this.gr_RentalBooks.AllowUserToDeleteRows = false;
      this.gr_RentalBooks.AllowUserToResizeRows = false;
      this.gr_RentalBooks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
      this.gr_RentalBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.gr_RentalBooks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
      this.gr_RentalBooks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle103.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle103.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      dataGridViewCellStyle103.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle103.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      dataGridViewCellStyle103.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      dataGridViewCellStyle103.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      dataGridViewCellStyle103.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.gr_RentalBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle103;
      this.gr_RentalBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gr_RentalBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gr_RentalID,
            this.gr_RentalBooksId,
            this.gr_RentalBooksName,
            this.Date});
      dataGridViewCellStyle106.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle106.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      dataGridViewCellStyle106.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle106.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      dataGridViewCellStyle106.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
      dataGridViewCellStyle106.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      dataGridViewCellStyle106.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.gr_RentalBooks.DefaultCellStyle = dataGridViewCellStyle106;
      this.gr_RentalBooks.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gr_RentalBooks.EnableHeadersVisualStyles = false;
      this.gr_RentalBooks.Location = new System.Drawing.Point(3, 35);
      this.gr_RentalBooks.MultiSelect = false;
      this.gr_RentalBooks.Name = "gr_RentalBooks";
      this.gr_RentalBooks.ReadOnly = true;
      this.gr_RentalBooks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle107.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle107.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle107.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle107.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      dataGridViewCellStyle107.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle107.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle107.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.gr_RentalBooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle107;
      this.gr_RentalBooks.RowHeadersVisible = false;
      this.gr_RentalBooks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.gr_RentalBooks.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gr_RentalBooks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.gr_RentalBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.gr_RentalBooks.Size = new System.Drawing.Size(257, 301);
      this.gr_RentalBooks.TabIndex = 4;
      this.gr_RentalBooks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gr_KeyDown);
      // 
      // gr_RentalID
      // 
      this.gr_RentalID.HeaderText = "RentalID";
      this.gr_RentalID.Name = "gr_RentalID";
      this.gr_RentalID.ReadOnly = true;
      this.gr_RentalID.Visible = false;
      // 
      // gr_RentalBooksId
      // 
      dataGridViewCellStyle104.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gr_RentalBooksId.DefaultCellStyle = dataGridViewCellStyle104;
      this.gr_RentalBooksId.HeaderText = "ID";
      this.gr_RentalBooksId.Name = "gr_RentalBooksId";
      this.gr_RentalBooksId.ReadOnly = true;
      this.gr_RentalBooksId.Width = 50;
      // 
      // gr_RentalBooksName
      // 
      this.gr_RentalBooksName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      dataGridViewCellStyle105.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gr_RentalBooksName.DefaultCellStyle = dataGridViewCellStyle105;
      this.gr_RentalBooksName.HeaderText = "Name";
      this.gr_RentalBooksName.Name = "gr_RentalBooksName";
      this.gr_RentalBooksName.ReadOnly = true;
      // 
      // Date
      // 
      this.Date.HeaderText = "Verleihdatum";
      this.Date.Name = "Date";
      this.Date.ReadOnly = true;
      this.Date.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      // 
      // pnl_RentalBooksHeader
      // 
      this.pnl_RentalBooksHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      this.pnl_RentalBooksHeader.Controls.Add(this.lbl_RentalBooksHeader);
      this.pnl_RentalBooksHeader.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnl_RentalBooksHeader.Location = new System.Drawing.Point(3, 3);
      this.pnl_RentalBooksHeader.Name = "pnl_RentalBooksHeader";
      this.pnl_RentalBooksHeader.Size = new System.Drawing.Size(257, 32);
      this.pnl_RentalBooksHeader.TabIndex = 0;
      // 
      // lbl_RentalBooksHeader
      // 
      this.lbl_RentalBooksHeader.BackColor = System.Drawing.Color.Transparent;
      this.lbl_RentalBooksHeader.Dock = System.Windows.Forms.DockStyle.Left;
      this.lbl_RentalBooksHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.lbl_RentalBooksHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
      this.lbl_RentalBooksHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      this.lbl_RentalBooksHeader.Location = new System.Drawing.Point(0, 0);
      this.lbl_RentalBooksHeader.Name = "lbl_RentalBooksHeader";
      this.lbl_RentalBooksHeader.Size = new System.Drawing.Size(216, 32);
      this.lbl_RentalBooksHeader.TabIndex = 14;
      this.lbl_RentalBooksHeader.Text = "  Ausgeliehene Bücher";
      this.lbl_RentalBooksHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // pnl_RentalKids
      // 
      this.pnl_RentalKids.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pnl_RentalKids.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      this.pnl_RentalKids.Controls.Add(this.gr_RentalKids);
      this.pnl_RentalKids.Controls.Add(this.pnl_RentalKidsHeader);
      this.pnl_RentalKids.Location = new System.Drawing.Point(32, 32);
      this.pnl_RentalKids.Name = "pnl_RentalKids";
      this.pnl_RentalKids.Padding = new System.Windows.Forms.Padding(3, 3, 3, 16);
      this.pnl_RentalKids.Size = new System.Drawing.Size(480, 522);
      this.pnl_RentalKids.TabIndex = 12;
      // 
      // gr_RentalKids
      // 
      this.gr_RentalKids.AllowUserToAddRows = false;
      this.gr_RentalKids.AllowUserToDeleteRows = false;
      this.gr_RentalKids.AllowUserToResizeRows = false;
      this.gr_RentalKids.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
      this.gr_RentalKids.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.gr_RentalKids.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
      this.gr_RentalKids.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle108.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle108.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      dataGridViewCellStyle108.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle108.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      dataGridViewCellStyle108.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      dataGridViewCellStyle108.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      dataGridViewCellStyle108.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.gr_RentalKids.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle108;
      this.gr_RentalKids.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gr_RentalKids.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gr_RentalKidsID,
            this.gr_RentalKidsName,
            this.gr_KidsSurname,
            this.gr_KidsGroup,
            this.gr_KidsRentalCount});
      dataGridViewCellStyle109.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle109.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
      dataGridViewCellStyle109.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle109.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      dataGridViewCellStyle109.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
      dataGridViewCellStyle109.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      dataGridViewCellStyle109.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.gr_RentalKids.DefaultCellStyle = dataGridViewCellStyle109;
      this.gr_RentalKids.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gr_RentalKids.EnableHeadersVisualStyles = false;
      this.gr_RentalKids.Location = new System.Drawing.Point(3, 35);
      this.gr_RentalKids.MultiSelect = false;
      this.gr_RentalKids.Name = "gr_RentalKids";
      this.gr_RentalKids.ReadOnly = true;
      this.gr_RentalKids.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle110.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle110.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle110.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle110.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      dataGridViewCellStyle110.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle110.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle110.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.gr_RentalKids.RowHeadersDefaultCellStyle = dataGridViewCellStyle110;
      this.gr_RentalKids.RowHeadersVisible = false;
      this.gr_RentalKids.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.gr_RentalKids.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gr_RentalKids.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.gr_RentalKids.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.gr_RentalKids.Size = new System.Drawing.Size(474, 471);
      this.gr_RentalKids.TabIndex = 1;
      this.gr_RentalKids.SelectionChanged += new System.EventHandler(this.gr_RentalKids_SelectionChanged);
      this.gr_RentalKids.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gr_KeyDown);
      // 
      // gr_RentalKidsID
      // 
      this.gr_RentalKidsID.HeaderText = "ID";
      this.gr_RentalKidsID.Name = "gr_RentalKidsID";
      this.gr_RentalKidsID.ReadOnly = true;
      this.gr_RentalKidsID.Visible = false;
      // 
      // gr_RentalKidsName
      // 
      this.gr_RentalKidsName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.gr_RentalKidsName.HeaderText = "Vorname";
      this.gr_RentalKidsName.Name = "gr_RentalKidsName";
      this.gr_RentalKidsName.ReadOnly = true;
      // 
      // gr_KidsSurname
      // 
      this.gr_KidsSurname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.gr_KidsSurname.HeaderText = "Nachname";
      this.gr_KidsSurname.Name = "gr_KidsSurname";
      this.gr_KidsSurname.ReadOnly = true;
      // 
      // gr_KidsGroup
      // 
      this.gr_KidsGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.gr_KidsGroup.HeaderText = "Gruppe";
      this.gr_KidsGroup.Name = "gr_KidsGroup";
      this.gr_KidsGroup.ReadOnly = true;
      // 
      // gr_KidsRentalCount
      // 
      this.gr_KidsRentalCount.HeaderText = "# Bücher";
      this.gr_KidsRentalCount.Name = "gr_KidsRentalCount";
      this.gr_KidsRentalCount.ReadOnly = true;
      // 
      // pnl_RentalKidsHeader
      // 
      this.pnl_RentalKidsHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      this.pnl_RentalKidsHeader.Controls.Add(this.cbb_RentalGroup);
      this.pnl_RentalKidsHeader.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnl_RentalKidsHeader.Location = new System.Drawing.Point(3, 3);
      this.pnl_RentalKidsHeader.Name = "pnl_RentalKidsHeader";
      this.pnl_RentalKidsHeader.Size = new System.Drawing.Size(474, 32);
      this.pnl_RentalKidsHeader.TabIndex = 0;
      // 
      // cbb_RentalGroup
      // 
      this.cbb_RentalGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      this.cbb_RentalGroup.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      this.cbb_RentalGroup.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      this.cbb_RentalGroup.Cursor = System.Windows.Forms.Cursors.Hand;
      this.cbb_RentalGroup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
      this.cbb_RentalGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbb_RentalGroup.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
      this.cbb_RentalGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      this.cbb_RentalGroup.FormattingEnabled = true;
      this.cbb_RentalGroup.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
      this.cbb_RentalGroup.HoverFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      this.cbb_RentalGroup.ItemHeight = 24;
      this.cbb_RentalGroup.Items.AddRange(new object[] {
            "Mäuse",
            "Igel",
            "Waschbären"});
      this.cbb_RentalGroup.Location = new System.Drawing.Point(6, 1);
      this.cbb_RentalGroup.Name = "cbb_RentalGroup";
      this.cbb_RentalGroup.Size = new System.Drawing.Size(159, 30);
      this.cbb_RentalGroup.TabIndex = 14;
      this.cbb_RentalGroup.SelectedIndexChanged += new System.EventHandler(this.cbb_RentalGroup_SelectedValueChanged);
      // 
      // tab_Return
      // 
      this.tab_Return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      this.tab_Return.Controls.Add(this.pnl_ReturnAction);
      this.tab_Return.ImageIndex = 2;
      this.tab_Return.Location = new System.Drawing.Point(164, 4);
      this.tab_Return.Name = "tab_Return";
      this.tab_Return.Size = new System.Drawing.Size(839, 587);
      this.tab_Return.TabIndex = 5;
      this.tab_Return.Text = "Bücherrückgabe";
      // 
      // pnl_ReturnAction
      // 
      this.pnl_ReturnAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.pnl_ReturnAction.BackColor = System.Drawing.Color.White;
      this.pnl_ReturnAction.Controls.Add(this.pnl_ReturnActionHeader);
      this.pnl_ReturnAction.Controls.Add(this.text_ReturnActionID);
      this.pnl_ReturnAction.Controls.Add(this.text_ReturnActionBarcode);
      this.pnl_ReturnAction.Location = new System.Drawing.Point(32, 32);
      this.pnl_ReturnAction.Name = "pnl_ReturnAction";
      this.pnl_ReturnAction.Size = new System.Drawing.Size(262, 132);
      this.pnl_ReturnAction.TabIndex = 17;
      // 
      // pnl_ReturnActionHeader
      // 
      this.pnl_ReturnActionHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      this.pnl_ReturnActionHeader.Controls.Add(this.lbl_ReturnActionHeader);
      this.pnl_ReturnActionHeader.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnl_ReturnActionHeader.Location = new System.Drawing.Point(0, 0);
      this.pnl_ReturnActionHeader.Name = "pnl_ReturnActionHeader";
      this.pnl_ReturnActionHeader.Size = new System.Drawing.Size(262, 36);
      this.pnl_ReturnActionHeader.TabIndex = 20;
      // 
      // lbl_ReturnActionHeader
      // 
      this.lbl_ReturnActionHeader.AutoSize = true;
      this.lbl_ReturnActionHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_ReturnActionHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      this.lbl_ReturnActionHeader.Location = new System.Drawing.Point(3, 7);
      this.lbl_ReturnActionHeader.Name = "lbl_ReturnActionHeader";
      this.lbl_ReturnActionHeader.Size = new System.Drawing.Size(251, 20);
      this.lbl_ReturnActionHeader.TabIndex = 18;
      this.lbl_ReturnActionHeader.Text = "Barcode scannen oder ID eingeben";
      // 
      // text_ReturnActionID
      // 
      this.text_ReturnActionID.AllowPromptAsInput = true;
      this.text_ReturnActionID.AnimateReadOnly = false;
      this.text_ReturnActionID.AsciiOnly = false;
      this.text_ReturnActionID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.text_ReturnActionID.BeepOnError = false;
      this.text_ReturnActionID.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
      this.text_ReturnActionID.Depth = 0;
      this.text_ReturnActionID.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.text_ReturnActionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.text_ReturnActionID.HidePromptOnLeave = false;
      this.text_ReturnActionID.HideSelection = true;
      this.text_ReturnActionID.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
      this.text_ReturnActionID.LeadingIcon = null;
      this.text_ReturnActionID.Location = new System.Drawing.Point(0, 36);
      this.text_ReturnActionID.Mask = "";
      this.text_ReturnActionID.MaxLength = 32767;
      this.text_ReturnActionID.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
      this.text_ReturnActionID.Name = "text_ReturnActionID";
      this.text_ReturnActionID.PasswordChar = '\0';
      this.text_ReturnActionID.PrefixSuffix = ReaLTaiizor.Controls.MaterialMaskedTextBox.PrefixSuffixTypes.Prefix;
      this.text_ReturnActionID.PrefixSuffixText = "ID:                ";
      this.text_ReturnActionID.PromptChar = '_';
      this.text_ReturnActionID.ReadOnly = false;
      this.text_ReturnActionID.RejectInputOnFirstFailure = false;
      this.text_ReturnActionID.ResetOnPrompt = true;
      this.text_ReturnActionID.ResetOnSpace = true;
      this.text_ReturnActionID.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.text_ReturnActionID.SelectedText = "";
      this.text_ReturnActionID.SelectionLength = 0;
      this.text_ReturnActionID.SelectionStart = 0;
      this.text_ReturnActionID.ShortcutsEnabled = true;
      this.text_ReturnActionID.Size = new System.Drawing.Size(262, 48);
      this.text_ReturnActionID.SkipLiterals = true;
      this.text_ReturnActionID.TabIndex = 2;
      this.text_ReturnActionID.TabStop = false;
      this.text_ReturnActionID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.text_ReturnActionID.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
      this.text_ReturnActionID.TrailingIcon = null;
      this.text_ReturnActionID.UseSystemPasswordChar = false;
      this.text_ReturnActionID.ValidatingType = null;
      this.text_ReturnActionID.Enter += new System.EventHandler(this.text_Enter);
      this.text_ReturnActionID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_ReturnActionID_KeyDown);
      // 
      // text_ReturnActionBarcode
      // 
      this.text_ReturnActionBarcode.AllowPromptAsInput = true;
      this.text_ReturnActionBarcode.AnimateReadOnly = true;
      this.text_ReturnActionBarcode.AsciiOnly = false;
      this.text_ReturnActionBarcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.text_ReturnActionBarcode.BeepOnError = false;
      this.text_ReturnActionBarcode.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
      this.text_ReturnActionBarcode.Depth = 0;
      this.text_ReturnActionBarcode.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.text_ReturnActionBarcode.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.text_ReturnActionBarcode.HidePromptOnLeave = false;
      this.text_ReturnActionBarcode.HideSelection = true;
      this.text_ReturnActionBarcode.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
      this.text_ReturnActionBarcode.LeadingIcon = null;
      this.text_ReturnActionBarcode.Location = new System.Drawing.Point(0, 84);
      this.text_ReturnActionBarcode.Mask = "";
      this.text_ReturnActionBarcode.MaxLength = 32767;
      this.text_ReturnActionBarcode.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
      this.text_ReturnActionBarcode.Name = "text_ReturnActionBarcode";
      this.text_ReturnActionBarcode.PasswordChar = '\0';
      this.text_ReturnActionBarcode.PrefixSuffix = ReaLTaiizor.Controls.MaterialMaskedTextBox.PrefixSuffixTypes.Prefix;
      this.text_ReturnActionBarcode.PrefixSuffixText = "Barcode:     ";
      this.text_ReturnActionBarcode.PromptChar = '_';
      this.text_ReturnActionBarcode.ReadOnly = true;
      this.text_ReturnActionBarcode.RejectInputOnFirstFailure = false;
      this.text_ReturnActionBarcode.ResetOnPrompt = true;
      this.text_ReturnActionBarcode.ResetOnSpace = true;
      this.text_ReturnActionBarcode.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.text_ReturnActionBarcode.SelectedText = "";
      this.text_ReturnActionBarcode.SelectionLength = 0;
      this.text_ReturnActionBarcode.SelectionStart = 0;
      this.text_ReturnActionBarcode.ShortcutsEnabled = true;
      this.text_ReturnActionBarcode.Size = new System.Drawing.Size(262, 48);
      this.text_ReturnActionBarcode.SkipLiterals = true;
      this.text_ReturnActionBarcode.TabIndex = 3;
      this.text_ReturnActionBarcode.TabStop = false;
      this.text_ReturnActionBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.text_ReturnActionBarcode.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
      this.text_ReturnActionBarcode.TrailingIcon = null;
      this.text_ReturnActionBarcode.UseSystemPasswordChar = false;
      this.text_ReturnActionBarcode.ValidatingType = null;
      this.text_ReturnActionBarcode.Enter += new System.EventHandler(this.text_Enter);
      this.text_ReturnActionBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_ReturnActionBarcode_KeyDown);
      // 
      // tab_Inventory
      // 
      this.tab_Inventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      this.tab_Inventory.Controls.Add(this.pnl_BooksInventory);
      this.tab_Inventory.Controls.Add(this.pnl_BooksNew);
      this.tab_Inventory.Controls.Add(this.pnl_Books);
      this.tab_Inventory.ImageIndex = 3;
      this.tab_Inventory.Location = new System.Drawing.Point(164, 4);
      this.tab_Inventory.Name = "tab_Inventory";
      this.tab_Inventory.Size = new System.Drawing.Size(839, 587);
      this.tab_Inventory.TabIndex = 2;
      this.tab_Inventory.Text = "Bücherliste";
      // 
      // pnl_BooksInventory
      // 
      this.pnl_BooksInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.pnl_BooksInventory.BackColor = System.Drawing.Color.White;
      this.pnl_BooksInventory.Controls.Add(this.btn_BooksInventoryStart);
      this.pnl_BooksInventory.Controls.Add(this.btn_BooksInventoryContinue);
      this.pnl_BooksInventory.Controls.Add(this.panel3);
      this.pnl_BooksInventory.Controls.Add(this.btn_BooksInventoryPrintParentInfo);
      this.pnl_BooksInventory.Location = new System.Drawing.Point(544, 267);
      this.pnl_BooksInventory.Name = "pnl_BooksInventory";
      this.pnl_BooksInventory.Size = new System.Drawing.Size(262, 128);
      this.pnl_BooksInventory.TabIndex = 18;
      // 
      // btn_BooksInventoryStart
      // 
      this.btn_BooksInventoryStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      this.btn_BooksInventoryStart.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      this.btn_BooksInventoryStart.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn_BooksInventoryStart.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.btn_BooksInventoryStart.Font = new System.Drawing.Font("Segoe UI", 11F);
      this.btn_BooksInventoryStart.Location = new System.Drawing.Point(0, 38);
      this.btn_BooksInventoryStart.Name = "btn_BooksInventoryStart";
      this.btn_BooksInventoryStart.Rounded = false;
      this.btn_BooksInventoryStart.Size = new System.Drawing.Size(262, 30);
      this.btn_BooksInventoryStart.TabIndex = 31;
      this.btn_BooksInventoryStart.Text = "Inventur starten";
      this.btn_BooksInventoryStart.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      this.btn_BooksInventoryStart.Click += new System.EventHandler(this.btn_BooksInventoryStart_Click);
      // 
      // btn_BooksInventoryContinue
      // 
      this.btn_BooksInventoryContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      this.btn_BooksInventoryContinue.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      this.btn_BooksInventoryContinue.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn_BooksInventoryContinue.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.btn_BooksInventoryContinue.Font = new System.Drawing.Font("Segoe UI", 11F);
      this.btn_BooksInventoryContinue.Location = new System.Drawing.Point(0, 68);
      this.btn_BooksInventoryContinue.Name = "btn_BooksInventoryContinue";
      this.btn_BooksInventoryContinue.Rounded = false;
      this.btn_BooksInventoryContinue.Size = new System.Drawing.Size(262, 30);
      this.btn_BooksInventoryContinue.TabIndex = 30;
      this.btn_BooksInventoryContinue.Text = "Inventur fortsetzen";
      this.btn_BooksInventoryContinue.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      this.btn_BooksInventoryContinue.Click += new System.EventHandler(this.btn_BooksInventoryContinue_Click);
      // 
      // panel3
      // 
      this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      this.panel3.Controls.Add(this.label1);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel3.Location = new System.Drawing.Point(0, 0);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(262, 98);
      this.panel3.TabIndex = 29;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      this.label1.Location = new System.Drawing.Point(3, 7);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(69, 20);
      this.label1.TabIndex = 18;
      this.label1.Text = "Inventur";
      // 
      // btn_BooksInventoryPrintParentInfo
      // 
      this.btn_BooksInventoryPrintParentInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      this.btn_BooksInventoryPrintParentInfo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      this.btn_BooksInventoryPrintParentInfo.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn_BooksInventoryPrintParentInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.btn_BooksInventoryPrintParentInfo.Font = new System.Drawing.Font("Segoe UI", 11F);
      this.btn_BooksInventoryPrintParentInfo.Location = new System.Drawing.Point(0, 98);
      this.btn_BooksInventoryPrintParentInfo.Name = "btn_BooksInventoryPrintParentInfo";
      this.btn_BooksInventoryPrintParentInfo.Rounded = false;
      this.btn_BooksInventoryPrintParentInfo.Size = new System.Drawing.Size(262, 30);
      this.btn_BooksInventoryPrintParentInfo.TabIndex = 4;
      this.btn_BooksInventoryPrintParentInfo.Text = "Elterninfo drucken";
      this.btn_BooksInventoryPrintParentInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      this.btn_BooksInventoryPrintParentInfo.Click += new System.EventHandler(this.btn_BooksInventoryPrintParentInfo_Click);
      // 
      // pnl_BooksNew
      // 
      this.pnl_BooksNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.pnl_BooksNew.BackColor = System.Drawing.Color.White;
      this.pnl_BooksNew.Controls.Add(this.pnl_BooksNewHeader);
      this.pnl_BooksNew.Controls.Add(this.text_BooksNewName);
      this.pnl_BooksNew.Controls.Add(this.text_BooksNewBarcode);
      this.pnl_BooksNew.Controls.Add(this.text_BooksNewID);
      this.pnl_BooksNew.Controls.Add(this.btn_BooksSave);
      this.pnl_BooksNew.Location = new System.Drawing.Point(544, 32);
      this.pnl_BooksNew.Name = "pnl_BooksNew";
      this.pnl_BooksNew.Size = new System.Drawing.Size(262, 210);
      this.pnl_BooksNew.TabIndex = 17;
      // 
      // pnl_BooksNewHeader
      // 
      this.pnl_BooksNewHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      this.pnl_BooksNewHeader.Controls.Add(this.lbl_BooksNewHeader);
      this.pnl_BooksNewHeader.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnl_BooksNewHeader.Location = new System.Drawing.Point(0, 0);
      this.pnl_BooksNewHeader.Name = "pnl_BooksNewHeader";
      this.pnl_BooksNewHeader.Size = new System.Drawing.Size(262, 36);
      this.pnl_BooksNewHeader.TabIndex = 26;
      // 
      // lbl_BooksNewHeader
      // 
      this.lbl_BooksNewHeader.AutoSize = true;
      this.lbl_BooksNewHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_BooksNewHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      this.lbl_BooksNewHeader.Location = new System.Drawing.Point(3, 7);
      this.lbl_BooksNewHeader.Name = "lbl_BooksNewHeader";
      this.lbl_BooksNewHeader.Size = new System.Drawing.Size(160, 20);
      this.lbl_BooksNewHeader.TabIndex = 18;
      this.lbl_BooksNewHeader.Text = "Neues Buch eingeben";
      // 
      // text_BooksNewName
      // 
      this.text_BooksNewName.AllowPromptAsInput = true;
      this.text_BooksNewName.AnimateReadOnly = false;
      this.text_BooksNewName.AsciiOnly = false;
      this.text_BooksNewName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.text_BooksNewName.BeepOnError = false;
      this.text_BooksNewName.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
      this.text_BooksNewName.Depth = 0;
      this.text_BooksNewName.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.text_BooksNewName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.text_BooksNewName.HidePromptOnLeave = false;
      this.text_BooksNewName.HideSelection = true;
      this.text_BooksNewName.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
      this.text_BooksNewName.LeadingIcon = null;
      this.text_BooksNewName.Location = new System.Drawing.Point(0, 36);
      this.text_BooksNewName.Mask = "";
      this.text_BooksNewName.MaxLength = 32767;
      this.text_BooksNewName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
      this.text_BooksNewName.Name = "text_BooksNewName";
      this.text_BooksNewName.PasswordChar = '\0';
      this.text_BooksNewName.PrefixSuffix = ReaLTaiizor.Controls.MaterialMaskedTextBox.PrefixSuffixTypes.Prefix;
      this.text_BooksNewName.PrefixSuffixText = "Name: *      ";
      this.text_BooksNewName.PromptChar = '_';
      this.text_BooksNewName.ReadOnly = false;
      this.text_BooksNewName.RejectInputOnFirstFailure = false;
      this.text_BooksNewName.ResetOnPrompt = true;
      this.text_BooksNewName.ResetOnSpace = true;
      this.text_BooksNewName.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.text_BooksNewName.SelectedText = "";
      this.text_BooksNewName.SelectionLength = 0;
      this.text_BooksNewName.SelectionStart = 0;
      this.text_BooksNewName.ShortcutsEnabled = true;
      this.text_BooksNewName.Size = new System.Drawing.Size(262, 48);
      this.text_BooksNewName.SkipLiterals = true;
      this.text_BooksNewName.TabIndex = 1;
      this.text_BooksNewName.TabStop = false;
      this.text_BooksNewName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.text_BooksNewName.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
      this.text_BooksNewName.TrailingIcon = null;
      this.text_BooksNewName.UseSystemPasswordChar = false;
      this.text_BooksNewName.ValidatingType = null;
      // 
      // text_BooksNewBarcode
      // 
      this.text_BooksNewBarcode.AllowPromptAsInput = true;
      this.text_BooksNewBarcode.AnimateReadOnly = true;
      this.text_BooksNewBarcode.AsciiOnly = false;
      this.text_BooksNewBarcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.text_BooksNewBarcode.BeepOnError = false;
      this.text_BooksNewBarcode.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
      this.text_BooksNewBarcode.Depth = 0;
      this.text_BooksNewBarcode.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.text_BooksNewBarcode.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.text_BooksNewBarcode.HidePromptOnLeave = false;
      this.text_BooksNewBarcode.HideSelection = true;
      this.text_BooksNewBarcode.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
      this.text_BooksNewBarcode.LeadingIcon = null;
      this.text_BooksNewBarcode.Location = new System.Drawing.Point(0, 84);
      this.text_BooksNewBarcode.Mask = "";
      this.text_BooksNewBarcode.MaxLength = 32767;
      this.text_BooksNewBarcode.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
      this.text_BooksNewBarcode.Name = "text_BooksNewBarcode";
      this.text_BooksNewBarcode.PasswordChar = '\0';
      this.text_BooksNewBarcode.PrefixSuffix = ReaLTaiizor.Controls.MaterialMaskedTextBox.PrefixSuffixTypes.Prefix;
      this.text_BooksNewBarcode.PrefixSuffixText = "Barcode:    ";
      this.text_BooksNewBarcode.PromptChar = '_';
      this.text_BooksNewBarcode.ReadOnly = false;
      this.text_BooksNewBarcode.RejectInputOnFirstFailure = false;
      this.text_BooksNewBarcode.ResetOnPrompt = true;
      this.text_BooksNewBarcode.ResetOnSpace = true;
      this.text_BooksNewBarcode.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.text_BooksNewBarcode.SelectedText = "";
      this.text_BooksNewBarcode.SelectionLength = 0;
      this.text_BooksNewBarcode.SelectionStart = 0;
      this.text_BooksNewBarcode.ShortcutsEnabled = true;
      this.text_BooksNewBarcode.Size = new System.Drawing.Size(262, 48);
      this.text_BooksNewBarcode.SkipLiterals = true;
      this.text_BooksNewBarcode.TabIndex = 2;
      this.text_BooksNewBarcode.TabStop = false;
      this.text_BooksNewBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.text_BooksNewBarcode.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
      this.text_BooksNewBarcode.TrailingIcon = null;
      this.text_BooksNewBarcode.UseSystemPasswordChar = false;
      this.text_BooksNewBarcode.ValidatingType = null;
      // 
      // text_BooksNewID
      // 
      this.text_BooksNewID.AllowPromptAsInput = false;
      this.text_BooksNewID.AnimateReadOnly = false;
      this.text_BooksNewID.AsciiOnly = false;
      this.text_BooksNewID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.text_BooksNewID.BeepOnError = false;
      this.text_BooksNewID.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
      this.text_BooksNewID.Depth = 0;
      this.text_BooksNewID.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.text_BooksNewID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.text_BooksNewID.HidePromptOnLeave = false;
      this.text_BooksNewID.HideSelection = true;
      this.text_BooksNewID.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
      this.text_BooksNewID.LeadingIcon = null;
      this.text_BooksNewID.Location = new System.Drawing.Point(0, 132);
      this.text_BooksNewID.Mask = "";
      this.text_BooksNewID.MaxLength = 32767;
      this.text_BooksNewID.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
      this.text_BooksNewID.Name = "text_BooksNewID";
      this.text_BooksNewID.PasswordChar = '\0';
      this.text_BooksNewID.PrefixSuffix = ReaLTaiizor.Controls.MaterialMaskedTextBox.PrefixSuffixTypes.Prefix;
      this.text_BooksNewID.PrefixSuffixText = "ID:               ";
      this.text_BooksNewID.PromptChar = '_';
      this.text_BooksNewID.ReadOnly = false;
      this.text_BooksNewID.RejectInputOnFirstFailure = false;
      this.text_BooksNewID.ResetOnPrompt = true;
      this.text_BooksNewID.ResetOnSpace = true;
      this.text_BooksNewID.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.text_BooksNewID.SelectedText = "";
      this.text_BooksNewID.SelectionLength = 0;
      this.text_BooksNewID.SelectionStart = 0;
      this.text_BooksNewID.ShortcutsEnabled = false;
      this.text_BooksNewID.Size = new System.Drawing.Size(262, 48);
      this.text_BooksNewID.SkipLiterals = true;
      this.text_BooksNewID.TabIndex = 3;
      this.text_BooksNewID.TabStop = false;
      this.text_BooksNewID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.text_BooksNewID.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
      this.text_BooksNewID.TrailingIcon = null;
      this.text_BooksNewID.UseSystemPasswordChar = false;
      this.text_BooksNewID.ValidatingType = null;
      this.text_BooksNewID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_BooksNewID_KeyDown);
      // 
      // btn_BooksSave
      // 
      this.btn_BooksSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      this.btn_BooksSave.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      this.btn_BooksSave.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn_BooksSave.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.btn_BooksSave.Font = new System.Drawing.Font("Segoe UI", 11F);
      this.btn_BooksSave.Location = new System.Drawing.Point(0, 180);
      this.btn_BooksSave.Name = "btn_BooksSave";
      this.btn_BooksSave.Rounded = false;
      this.btn_BooksSave.Size = new System.Drawing.Size(262, 30);
      this.btn_BooksSave.TabIndex = 4;
      this.btn_BooksSave.Text = "Speichern";
      this.btn_BooksSave.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      this.btn_BooksSave.Click += new System.EventHandler(this.btn_BooksSave_Click);
      // 
      // pnl_Books
      // 
      this.pnl_Books.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pnl_Books.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      this.pnl_Books.Controls.Add(this.gr_Books);
      this.pnl_Books.Controls.Add(this.pnl_BooksHeader);
      this.pnl_Books.Location = new System.Drawing.Point(32, 32);
      this.pnl_Books.Name = "pnl_Books";
      this.pnl_Books.Padding = new System.Windows.Forms.Padding(3, 3, 3, 16);
      this.pnl_Books.Size = new System.Drawing.Size(480, 522);
      this.pnl_Books.TabIndex = 13;
      // 
      // gr_Books
      // 
      this.gr_Books.AllowUserToAddRows = false;
      this.gr_Books.AllowUserToDeleteRows = false;
      this.gr_Books.AllowUserToResizeRows = false;
      this.gr_Books.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
      this.gr_Books.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.gr_Books.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
      this.gr_Books.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle111.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle111.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      dataGridViewCellStyle111.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle111.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      dataGridViewCellStyle111.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      dataGridViewCellStyle111.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      dataGridViewCellStyle111.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.gr_Books.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle111;
      this.gr_Books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gr_Books.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gr_BooksID,
            this.gr_BooksExternalID,
            this.gr_BooksName,
            this.gr_BooksBarcode,
            this.gr_BooksBarcodeScan,
            this.gr_BooksRented,
            this.gr_BooksDelete,
            this.gr_BooksInventoryCheck});
      dataGridViewCellStyle112.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle112.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
      dataGridViewCellStyle112.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle112.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      dataGridViewCellStyle112.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
      dataGridViewCellStyle112.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      dataGridViewCellStyle112.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.gr_Books.DefaultCellStyle = dataGridViewCellStyle112;
      this.gr_Books.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gr_Books.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
      this.gr_Books.EnableHeadersVisualStyles = false;
      this.gr_Books.Location = new System.Drawing.Point(3, 35);
      this.gr_Books.MultiSelect = false;
      this.gr_Books.Name = "gr_Books";
      this.gr_Books.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle113.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle113.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle113.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle113.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      dataGridViewCellStyle113.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle113.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle113.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.gr_Books.RowHeadersDefaultCellStyle = dataGridViewCellStyle113;
      this.gr_Books.RowHeadersVisible = false;
      this.gr_Books.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.gr_Books.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gr_Books.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.gr_Books.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.gr_Books.Size = new System.Drawing.Size(474, 471);
      this.gr_Books.TabIndex = 1;
      this.gr_Books.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gr_Books_CellContentClick);
      this.gr_Books.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.gr_Books_CellPainting);
      this.gr_Books.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.gr_Books_RowValidated);
      this.gr_Books.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gr_KeyDown);
      // 
      // gr_BooksID
      // 
      this.gr_BooksID.HeaderText = "ID";
      this.gr_BooksID.Name = "gr_BooksID";
      this.gr_BooksID.Visible = false;
      // 
      // gr_BooksExternalID
      // 
      this.gr_BooksExternalID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.gr_BooksExternalID.FillWeight = 236.1703F;
      this.gr_BooksExternalID.HeaderText = "ID";
      this.gr_BooksExternalID.Name = "gr_BooksExternalID";
      this.gr_BooksExternalID.Width = 40;
      // 
      // gr_BooksName
      // 
      this.gr_BooksName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.gr_BooksName.FillWeight = 11.43709F;
      this.gr_BooksName.HeaderText = "Name";
      this.gr_BooksName.Name = "gr_BooksName";
      // 
      // gr_BooksBarcode
      // 
      this.gr_BooksBarcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.gr_BooksBarcode.FillWeight = 52.39273F;
      this.gr_BooksBarcode.HeaderText = "Barcode";
      this.gr_BooksBarcode.Name = "gr_BooksBarcode";
      this.gr_BooksBarcode.Width = 80;
      // 
      // gr_BooksBarcodeScan
      // 
      this.gr_BooksBarcodeScan.HeaderText = "#";
      this.gr_BooksBarcodeScan.Name = "gr_BooksBarcodeScan";
      this.gr_BooksBarcodeScan.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.gr_BooksBarcodeScan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.gr_BooksBarcodeScan.Width = 40;
      // 
      // gr_BooksRented
      // 
      this.gr_BooksRented.HeaderText = "Verliehen an";
      this.gr_BooksRented.Name = "gr_BooksRented";
      this.gr_BooksRented.ReadOnly = true;
      this.gr_BooksRented.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      // 
      // gr_BooksDelete
      // 
      this.gr_BooksDelete.FillWeight = 50F;
      this.gr_BooksDelete.HeaderText = "Löschen";
      this.gr_BooksDelete.MinimumWidth = 50;
      this.gr_BooksDelete.Name = "gr_BooksDelete";
      this.gr_BooksDelete.Width = 50;
      // 
      // gr_BooksInventoryCheck
      // 
      this.gr_BooksInventoryCheck.HeaderText = "Inventurstatus";
      this.gr_BooksInventoryCheck.Name = "gr_BooksInventoryCheck";
      this.gr_BooksInventoryCheck.ReadOnly = true;
      this.gr_BooksInventoryCheck.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.gr_BooksInventoryCheck.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.gr_BooksInventoryCheck.Visible = false;
      this.gr_BooksInventoryCheck.Width = 50;
      // 
      // pnl_BooksHeader
      // 
      this.pnl_BooksHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      this.pnl_BooksHeader.Controls.Add(this.text_BooksFilter);
      this.pnl_BooksHeader.Controls.Add(this.lbl_BooksHeader);
      this.pnl_BooksHeader.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnl_BooksHeader.Location = new System.Drawing.Point(3, 3);
      this.pnl_BooksHeader.Name = "pnl_BooksHeader";
      this.pnl_BooksHeader.Size = new System.Drawing.Size(474, 32);
      this.pnl_BooksHeader.TabIndex = 0;
      // 
      // text_BooksFilter
      // 
      this.text_BooksFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
      this.text_BooksFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
      this.text_BooksFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
      this.text_BooksFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.text_BooksFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.text_BooksFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      this.text_BooksFilter.Location = new System.Drawing.Point(251, 3);
      this.text_BooksFilter.Name = "text_BooksFilter";
      this.text_BooksFilter.Size = new System.Drawing.Size(220, 23);
      this.text_BooksFilter.TabIndex = 19;
      this.text_BooksFilter.Text = "  Filter ...";
      this.text_BooksFilter.TextChanged += new System.EventHandler(this.text_BooksFilter_TextChanged);
      this.text_BooksFilter.Enter += new System.EventHandler(this.text_BooksFilter_Enter);
      this.text_BooksFilter.Leave += new System.EventHandler(this.text_BooksFilter_Leave);
      // 
      // lbl_BooksHeader
      // 
      this.lbl_BooksHeader.BackColor = System.Drawing.Color.Transparent;
      this.lbl_BooksHeader.Dock = System.Windows.Forms.DockStyle.Left;
      this.lbl_BooksHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.lbl_BooksHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
      this.lbl_BooksHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      this.lbl_BooksHeader.Location = new System.Drawing.Point(0, 0);
      this.lbl_BooksHeader.Name = "lbl_BooksHeader";
      this.lbl_BooksHeader.Size = new System.Drawing.Size(137, 32);
      this.lbl_BooksHeader.TabIndex = 15;
      this.lbl_BooksHeader.Text = "  Bücherliste";
      this.lbl_BooksHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // tab_Kids
      // 
      this.tab_Kids.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      this.tab_Kids.Controls.Add(this.pnl_AllKidsAddContainer);
      this.tab_Kids.Controls.Add(this.pnl_AllKids);
      this.tab_Kids.ImageIndex = 4;
      this.tab_Kids.Location = new System.Drawing.Point(164, 4);
      this.tab_Kids.Name = "tab_Kids";
      this.tab_Kids.Size = new System.Drawing.Size(839, 587);
      this.tab_Kids.TabIndex = 3;
      this.tab_Kids.Text = "Kinder";
      // 
      // pnl_AllKidsAddContainer
      // 
      this.pnl_AllKidsAddContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.pnl_AllKidsAddContainer.BackColor = System.Drawing.Color.White;
      this.pnl_AllKidsAddContainer.Controls.Add(this.text_NewKidsFirstName);
      this.pnl_AllKidsAddContainer.Controls.Add(this.text_NewKidsSurname);
      this.pnl_AllKidsAddContainer.Controls.Add(this.panel2);
      this.pnl_AllKidsAddContainer.Controls.Add(this.pnl_AllKidsAdd);
      this.pnl_AllKidsAddContainer.Controls.Add(this.btn_AllKidsAdd);
      this.pnl_AllKidsAddContainer.Location = new System.Drawing.Point(544, 32);
      this.pnl_AllKidsAddContainer.Name = "pnl_AllKidsAddContainer";
      this.pnl_AllKidsAddContainer.Size = new System.Drawing.Size(262, 210);
      this.pnl_AllKidsAddContainer.TabIndex = 18;
      // 
      // text_NewKidsFirstName
      // 
      this.text_NewKidsFirstName.AllowPromptAsInput = true;
      this.text_NewKidsFirstName.AnimateReadOnly = false;
      this.text_NewKidsFirstName.AsciiOnly = false;
      this.text_NewKidsFirstName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.text_NewKidsFirstName.BeepOnError = false;
      this.text_NewKidsFirstName.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
      this.text_NewKidsFirstName.Depth = 0;
      this.text_NewKidsFirstName.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.text_NewKidsFirstName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.text_NewKidsFirstName.HidePromptOnLeave = false;
      this.text_NewKidsFirstName.HideSelection = true;
      this.text_NewKidsFirstName.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
      this.text_NewKidsFirstName.LeadingIcon = null;
      this.text_NewKidsFirstName.Location = new System.Drawing.Point(0, 36);
      this.text_NewKidsFirstName.Mask = "";
      this.text_NewKidsFirstName.MaxLength = 32767;
      this.text_NewKidsFirstName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
      this.text_NewKidsFirstName.Name = "text_NewKidsFirstName";
      this.text_NewKidsFirstName.PasswordChar = '\0';
      this.text_NewKidsFirstName.PrefixSuffix = ReaLTaiizor.Controls.MaterialMaskedTextBox.PrefixSuffixTypes.Prefix;
      this.text_NewKidsFirstName.PrefixSuffixText = "Vorname: *      ";
      this.text_NewKidsFirstName.PromptChar = '_';
      this.text_NewKidsFirstName.ReadOnly = false;
      this.text_NewKidsFirstName.RejectInputOnFirstFailure = false;
      this.text_NewKidsFirstName.ResetOnPrompt = true;
      this.text_NewKidsFirstName.ResetOnSpace = true;
      this.text_NewKidsFirstName.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.text_NewKidsFirstName.SelectedText = "";
      this.text_NewKidsFirstName.SelectionLength = 0;
      this.text_NewKidsFirstName.SelectionStart = 0;
      this.text_NewKidsFirstName.ShortcutsEnabled = true;
      this.text_NewKidsFirstName.Size = new System.Drawing.Size(262, 48);
      this.text_NewKidsFirstName.SkipLiterals = true;
      this.text_NewKidsFirstName.TabIndex = 38;
      this.text_NewKidsFirstName.TabStop = false;
      this.text_NewKidsFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.text_NewKidsFirstName.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
      this.text_NewKidsFirstName.TrailingIcon = null;
      this.text_NewKidsFirstName.UseSystemPasswordChar = false;
      this.text_NewKidsFirstName.ValidatingType = null;
      // 
      // text_NewKidsSurname
      // 
      this.text_NewKidsSurname.AllowPromptAsInput = true;
      this.text_NewKidsSurname.AnimateReadOnly = false;
      this.text_NewKidsSurname.AsciiOnly = false;
      this.text_NewKidsSurname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.text_NewKidsSurname.BeepOnError = false;
      this.text_NewKidsSurname.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
      this.text_NewKidsSurname.Depth = 0;
      this.text_NewKidsSurname.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.text_NewKidsSurname.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.text_NewKidsSurname.HidePromptOnLeave = false;
      this.text_NewKidsSurname.HideSelection = true;
      this.text_NewKidsSurname.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
      this.text_NewKidsSurname.LeadingIcon = null;
      this.text_NewKidsSurname.Location = new System.Drawing.Point(0, 84);
      this.text_NewKidsSurname.Mask = "";
      this.text_NewKidsSurname.MaxLength = 32767;
      this.text_NewKidsSurname.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
      this.text_NewKidsSurname.Name = "text_NewKidsSurname";
      this.text_NewKidsSurname.PasswordChar = '\0';
      this.text_NewKidsSurname.PrefixSuffix = ReaLTaiizor.Controls.MaterialMaskedTextBox.PrefixSuffixTypes.Prefix;
      this.text_NewKidsSurname.PrefixSuffixText = "Nachname: *      ";
      this.text_NewKidsSurname.PromptChar = '_';
      this.text_NewKidsSurname.ReadOnly = false;
      this.text_NewKidsSurname.RejectInputOnFirstFailure = false;
      this.text_NewKidsSurname.ResetOnPrompt = true;
      this.text_NewKidsSurname.ResetOnSpace = true;
      this.text_NewKidsSurname.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.text_NewKidsSurname.SelectedText = "";
      this.text_NewKidsSurname.SelectionLength = 0;
      this.text_NewKidsSurname.SelectionStart = 0;
      this.text_NewKidsSurname.ShortcutsEnabled = true;
      this.text_NewKidsSurname.Size = new System.Drawing.Size(262, 48);
      this.text_NewKidsSurname.SkipLiterals = true;
      this.text_NewKidsSurname.TabIndex = 37;
      this.text_NewKidsSurname.TabStop = false;
      this.text_NewKidsSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.text_NewKidsSurname.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
      this.text_NewKidsSurname.TrailingIcon = null;
      this.text_NewKidsSurname.UseSystemPasswordChar = false;
      this.text_NewKidsSurname.ValidatingType = null;
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.White;
      this.panel2.Controls.Add(this.cbb_NewKidGroup);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel2.Location = new System.Drawing.Point(0, 132);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(262, 48);
      this.panel2.TabIndex = 35;
      // 
      // cbb_NewKidGroup
      // 
      this.cbb_NewKidGroup.AutoResize = false;
      this.cbb_NewKidGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      this.cbb_NewKidGroup.Depth = 0;
      this.cbb_NewKidGroup.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.cbb_NewKidGroup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
      this.cbb_NewKidGroup.DropDownHeight = 174;
      this.cbb_NewKidGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbb_NewKidGroup.DropDownWidth = 121;
      this.cbb_NewKidGroup.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
      this.cbb_NewKidGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      this.cbb_NewKidGroup.FormattingEnabled = true;
      this.cbb_NewKidGroup.IntegralHeight = false;
      this.cbb_NewKidGroup.ItemHeight = 43;
      this.cbb_NewKidGroup.Location = new System.Drawing.Point(0, -1);
      this.cbb_NewKidGroup.MaxDropDownItems = 4;
      this.cbb_NewKidGroup.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
      this.cbb_NewKidGroup.Name = "cbb_NewKidGroup";
      this.cbb_NewKidGroup.Size = new System.Drawing.Size(262, 49);
      this.cbb_NewKidGroup.StartIndex = 0;
      this.cbb_NewKidGroup.TabIndex = 4;
      // 
      // pnl_AllKidsAdd
      // 
      this.pnl_AllKidsAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      this.pnl_AllKidsAdd.Controls.Add(this.lbl_AllKidsAddHeader);
      this.pnl_AllKidsAdd.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnl_AllKidsAdd.Location = new System.Drawing.Point(0, 0);
      this.pnl_AllKidsAdd.Name = "pnl_AllKidsAdd";
      this.pnl_AllKidsAdd.Size = new System.Drawing.Size(262, 180);
      this.pnl_AllKidsAdd.TabIndex = 34;
      // 
      // lbl_AllKidsAddHeader
      // 
      this.lbl_AllKidsAddHeader.AutoSize = true;
      this.lbl_AllKidsAddHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_AllKidsAddHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      this.lbl_AllKidsAddHeader.Location = new System.Drawing.Point(3, 7);
      this.lbl_AllKidsAddHeader.Name = "lbl_AllKidsAddHeader";
      this.lbl_AllKidsAddHeader.Size = new System.Drawing.Size(124, 20);
      this.lbl_AllKidsAddHeader.TabIndex = 18;
      this.lbl_AllKidsAddHeader.Text = "Kind hinzufügen";
      // 
      // btn_AllKidsAdd
      // 
      this.btn_AllKidsAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      this.btn_AllKidsAdd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      this.btn_AllKidsAdd.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn_AllKidsAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.btn_AllKidsAdd.Font = new System.Drawing.Font("Segoe UI", 11F);
      this.btn_AllKidsAdd.Location = new System.Drawing.Point(0, 180);
      this.btn_AllKidsAdd.Name = "btn_AllKidsAdd";
      this.btn_AllKidsAdd.Rounded = false;
      this.btn_AllKidsAdd.Size = new System.Drawing.Size(262, 30);
      this.btn_AllKidsAdd.TabIndex = 4;
      this.btn_AllKidsAdd.Text = "Speichern";
      this.btn_AllKidsAdd.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      this.btn_AllKidsAdd.Click += new System.EventHandler(this.btn_AllKidsAdd_Click);
      // 
      // pnl_AllKids
      // 
      this.pnl_AllKids.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pnl_AllKids.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      this.pnl_AllKids.Controls.Add(this.gr_AllKids);
      this.pnl_AllKids.Controls.Add(this.pnl_AllKidsHeader);
      this.pnl_AllKids.Location = new System.Drawing.Point(32, 32);
      this.pnl_AllKids.Name = "pnl_AllKids";
      this.pnl_AllKids.Padding = new System.Windows.Forms.Padding(3, 3, 3, 16);
      this.pnl_AllKids.Size = new System.Drawing.Size(480, 522);
      this.pnl_AllKids.TabIndex = 14;
      // 
      // gr_AllKids
      // 
      this.gr_AllKids.AllowUserToAddRows = false;
      this.gr_AllKids.AllowUserToDeleteRows = false;
      this.gr_AllKids.AllowUserToResizeRows = false;
      this.gr_AllKids.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
      this.gr_AllKids.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.gr_AllKids.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
      this.gr_AllKids.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle114.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle114.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      dataGridViewCellStyle114.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle114.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      dataGridViewCellStyle114.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      dataGridViewCellStyle114.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      dataGridViewCellStyle114.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.gr_AllKids.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle114;
      this.gr_AllKids.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gr_AllKids.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gr_AllKidsID,
            this.gr_AllKidsFirstName,
            this.gr_AllKidsSurname,
            this.gr_AllKidsGroup,
            this.gr_AllKidsDelete});
      dataGridViewCellStyle115.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle115.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
      dataGridViewCellStyle115.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle115.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      dataGridViewCellStyle115.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
      dataGridViewCellStyle115.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      dataGridViewCellStyle115.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.gr_AllKids.DefaultCellStyle = dataGridViewCellStyle115;
      this.gr_AllKids.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gr_AllKids.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
      this.gr_AllKids.EnableHeadersVisualStyles = false;
      this.gr_AllKids.Location = new System.Drawing.Point(3, 35);
      this.gr_AllKids.MultiSelect = false;
      this.gr_AllKids.Name = "gr_AllKids";
      this.gr_AllKids.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle116.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle116.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle116.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle116.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      dataGridViewCellStyle116.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle116.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle116.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.gr_AllKids.RowHeadersDefaultCellStyle = dataGridViewCellStyle116;
      this.gr_AllKids.RowHeadersVisible = false;
      this.gr_AllKids.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.gr_AllKids.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gr_AllKids.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.gr_AllKids.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.gr_AllKids.Size = new System.Drawing.Size(474, 471);
      this.gr_AllKids.TabIndex = 1;
      this.gr_AllKids.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gr_AllKids_CellContentClick);
      this.gr_AllKids.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.gr_AllKids_CellPainting);
      this.gr_AllKids.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.gr_AllKids_RowValidated);
      this.gr_AllKids.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gr_KeyDown);
      // 
      // gr_AllKidsID
      // 
      this.gr_AllKidsID.HeaderText = "ID";
      this.gr_AllKidsID.Name = "gr_AllKidsID";
      this.gr_AllKidsID.Visible = false;
      // 
      // gr_AllKidsFirstName
      // 
      this.gr_AllKidsFirstName.HeaderText = "Vorname";
      this.gr_AllKidsFirstName.Name = "gr_AllKidsFirstName";
      this.gr_AllKidsFirstName.Width = 160;
      // 
      // gr_AllKidsSurname
      // 
      this.gr_AllKidsSurname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.gr_AllKidsSurname.HeaderText = "Nachname";
      this.gr_AllKidsSurname.Name = "gr_AllKidsSurname";
      // 
      // gr_AllKidsGroup
      // 
      this.gr_AllKidsGroup.HeaderText = "Gruppe";
      this.gr_AllKidsGroup.Name = "gr_AllKidsGroup";
      this.gr_AllKidsGroup.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.gr_AllKidsGroup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      // 
      // gr_AllKidsDelete
      // 
      this.gr_AllKidsDelete.FillWeight = 50F;
      this.gr_AllKidsDelete.HeaderText = "Löschen";
      this.gr_AllKidsDelete.MinimumWidth = 50;
      this.gr_AllKidsDelete.Name = "gr_AllKidsDelete";
      this.gr_AllKidsDelete.Width = 50;
      // 
      // pnl_AllKidsHeader
      // 
      this.pnl_AllKidsHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      this.pnl_AllKidsHeader.Controls.Add(this.text_KidsFilter);
      this.pnl_AllKidsHeader.Controls.Add(this.lbl_AllKidsHeader);
      this.pnl_AllKidsHeader.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnl_AllKidsHeader.Location = new System.Drawing.Point(3, 3);
      this.pnl_AllKidsHeader.Name = "pnl_AllKidsHeader";
      this.pnl_AllKidsHeader.Size = new System.Drawing.Size(474, 32);
      this.pnl_AllKidsHeader.TabIndex = 0;
      // 
      // text_KidsFilter
      // 
      this.text_KidsFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
      this.text_KidsFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
      this.text_KidsFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
      this.text_KidsFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.text_KidsFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.text_KidsFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      this.text_KidsFilter.Location = new System.Drawing.Point(251, 3);
      this.text_KidsFilter.Name = "text_KidsFilter";
      this.text_KidsFilter.Size = new System.Drawing.Size(220, 23);
      this.text_KidsFilter.TabIndex = 20;
      this.text_KidsFilter.Text = "  Filter ...";
      this.text_KidsFilter.TextChanged += new System.EventHandler(this.text_BooksFilter_TextChanged);
      this.text_KidsFilter.Enter += new System.EventHandler(this.text_BooksFilter_Enter);
      this.text_KidsFilter.Leave += new System.EventHandler(this.text_BooksFilter_Leave);
      // 
      // lbl_AllKidsHeader
      // 
      this.lbl_AllKidsHeader.BackColor = System.Drawing.Color.Transparent;
      this.lbl_AllKidsHeader.Dock = System.Windows.Forms.DockStyle.Left;
      this.lbl_AllKidsHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.lbl_AllKidsHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
      this.lbl_AllKidsHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      this.lbl_AllKidsHeader.Location = new System.Drawing.Point(0, 0);
      this.lbl_AllKidsHeader.Name = "lbl_AllKidsHeader";
      this.lbl_AllKidsHeader.Size = new System.Drawing.Size(216, 32);
      this.lbl_AllKidsHeader.TabIndex = 15;
      this.lbl_AllKidsHeader.Text = "  Kinder";
      this.lbl_AllKidsHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // tab_History
      // 
      this.tab_History.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      this.tab_History.Controls.Add(this.pnl_LastActions);
      this.tab_History.ImageIndex = 5;
      this.tab_History.Location = new System.Drawing.Point(164, 4);
      this.tab_History.Name = "tab_History";
      this.tab_History.Size = new System.Drawing.Size(839, 587);
      this.tab_History.TabIndex = 4;
      this.tab_History.Text = "Letzte Aktionen";
      // 
      // pnl_LastActions
      // 
      this.pnl_LastActions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pnl_LastActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      this.pnl_LastActions.Controls.Add(this.gr_LastActions);
      this.pnl_LastActions.Controls.Add(this.pnl_LastActionsHeader);
      this.pnl_LastActions.Location = new System.Drawing.Point(32, 32);
      this.pnl_LastActions.Name = "pnl_LastActions";
      this.pnl_LastActions.Padding = new System.Windows.Forms.Padding(3, 3, 3, 16);
      this.pnl_LastActions.Size = new System.Drawing.Size(480, 522);
      this.pnl_LastActions.TabIndex = 15;
      // 
      // gr_LastActions
      // 
      this.gr_LastActions.AllowUserToAddRows = false;
      this.gr_LastActions.AllowUserToDeleteRows = false;
      this.gr_LastActions.AllowUserToResizeRows = false;
      this.gr_LastActions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
      this.gr_LastActions.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.gr_LastActions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
      this.gr_LastActions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle117.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle117.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      dataGridViewCellStyle117.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle117.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      dataGridViewCellStyle117.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      dataGridViewCellStyle117.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      dataGridViewCellStyle117.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.gr_LastActions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle117;
      this.gr_LastActions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gr_LastActions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.gr_LastActionsOperation,
            this.gr_LastActionsTable,
            this.gr_LastActionsValue,
            this.gr_LastActionsTimestamp});
      dataGridViewCellStyle118.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle118.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
      dataGridViewCellStyle118.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle118.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      dataGridViewCellStyle118.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
      dataGridViewCellStyle118.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      dataGridViewCellStyle118.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.gr_LastActions.DefaultCellStyle = dataGridViewCellStyle118;
      this.gr_LastActions.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gr_LastActions.EnableHeadersVisualStyles = false;
      this.gr_LastActions.Location = new System.Drawing.Point(3, 35);
      this.gr_LastActions.MultiSelect = false;
      this.gr_LastActions.Name = "gr_LastActions";
      this.gr_LastActions.ReadOnly = true;
      this.gr_LastActions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle119.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle119.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle119.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle119.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      dataGridViewCellStyle119.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle119.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle119.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.gr_LastActions.RowHeadersDefaultCellStyle = dataGridViewCellStyle119;
      this.gr_LastActions.RowHeadersVisible = false;
      this.gr_LastActions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.gr_LastActions.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gr_LastActions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.gr_LastActions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.gr_LastActions.Size = new System.Drawing.Size(474, 471);
      this.gr_LastActions.TabIndex = 1;
      this.gr_LastActions.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gr_KeyDown);
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.HeaderText = "ID";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      this.dataGridViewTextBoxColumn1.Visible = false;
      // 
      // gr_LastActionsOperation
      // 
      this.gr_LastActionsOperation.HeaderText = "Aktion";
      this.gr_LastActionsOperation.Name = "gr_LastActionsOperation";
      this.gr_LastActionsOperation.ReadOnly = true;
      this.gr_LastActionsOperation.Width = 70;
      // 
      // gr_LastActionsTable
      // 
      this.gr_LastActionsTable.HeaderText = "Bereich";
      this.gr_LastActionsTable.Name = "gr_LastActionsTable";
      this.gr_LastActionsTable.ReadOnly = true;
      this.gr_LastActionsTable.Width = 70;
      // 
      // gr_LastActionsValue
      // 
      this.gr_LastActionsValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.gr_LastActionsValue.HeaderText = "Wert";
      this.gr_LastActionsValue.Name = "gr_LastActionsValue";
      this.gr_LastActionsValue.ReadOnly = true;
      // 
      // gr_LastActionsTimestamp
      // 
      this.gr_LastActionsTimestamp.FillWeight = 50F;
      this.gr_LastActionsTimestamp.HeaderText = "Zeitstempel";
      this.gr_LastActionsTimestamp.MinimumWidth = 50;
      this.gr_LastActionsTimestamp.Name = "gr_LastActionsTimestamp";
      this.gr_LastActionsTimestamp.ReadOnly = true;
      this.gr_LastActionsTimestamp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.gr_LastActionsTimestamp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.gr_LastActionsTimestamp.Width = 140;
      // 
      // pnl_LastActionsHeader
      // 
      this.pnl_LastActionsHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      this.pnl_LastActionsHeader.Controls.Add(this.text_HistoryFilter);
      this.pnl_LastActionsHeader.Controls.Add(this.lbl_LastActionsHeader);
      this.pnl_LastActionsHeader.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnl_LastActionsHeader.Location = new System.Drawing.Point(3, 3);
      this.pnl_LastActionsHeader.Name = "pnl_LastActionsHeader";
      this.pnl_LastActionsHeader.Size = new System.Drawing.Size(474, 32);
      this.pnl_LastActionsHeader.TabIndex = 0;
      // 
      // text_HistoryFilter
      // 
      this.text_HistoryFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
      this.text_HistoryFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
      this.text_HistoryFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
      this.text_HistoryFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.text_HistoryFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.text_HistoryFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      this.text_HistoryFilter.Location = new System.Drawing.Point(251, 3);
      this.text_HistoryFilter.Name = "text_HistoryFilter";
      this.text_HistoryFilter.Size = new System.Drawing.Size(220, 23);
      this.text_HistoryFilter.TabIndex = 21;
      this.text_HistoryFilter.Text = "  Filter ...";
      this.text_HistoryFilter.TextChanged += new System.EventHandler(this.text_BooksFilter_TextChanged);
      this.text_HistoryFilter.Enter += new System.EventHandler(this.text_BooksFilter_Enter);
      this.text_HistoryFilter.Leave += new System.EventHandler(this.text_BooksFilter_Leave);
      // 
      // lbl_LastActionsHeader
      // 
      this.lbl_LastActionsHeader.BackColor = System.Drawing.Color.Transparent;
      this.lbl_LastActionsHeader.Dock = System.Windows.Forms.DockStyle.Left;
      this.lbl_LastActionsHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.lbl_LastActionsHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
      this.lbl_LastActionsHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      this.lbl_LastActionsHeader.Location = new System.Drawing.Point(0, 0);
      this.lbl_LastActionsHeader.Name = "lbl_LastActionsHeader";
      this.lbl_LastActionsHeader.Size = new System.Drawing.Size(216, 32);
      this.lbl_LastActionsHeader.TabIndex = 15;
      this.lbl_LastActionsHeader.Text = "  Letzte Aktionen";
      this.lbl_LastActionsHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // tab_Settings
      // 
      this.tab_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      this.tab_Settings.Controls.Add(this.pnl_SettingsInfo);
      this.tab_Settings.Controls.Add(this.pnl_SettingsBackup);
      this.tab_Settings.ImageIndex = 6;
      this.tab_Settings.Location = new System.Drawing.Point(164, 4);
      this.tab_Settings.Name = "tab_Settings";
      this.tab_Settings.Size = new System.Drawing.Size(839, 587);
      this.tab_Settings.TabIndex = 6;
      this.tab_Settings.Text = "Einstellungen";
      // 
      // pnl_SettingsInfo
      // 
      this.pnl_SettingsInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.pnl_SettingsInfo.BackColor = System.Drawing.Color.White;
      this.pnl_SettingsInfo.Controls.Add(this.text_Github);
      this.pnl_SettingsInfo.Controls.Add(this.text_InfoVersion);
      this.pnl_SettingsInfo.Controls.Add(this.text_InfoAuthor);
      this.pnl_SettingsInfo.Controls.Add(this.text_InfoPhone);
      this.pnl_SettingsInfo.Controls.Add(this.panel8);
      this.pnl_SettingsInfo.Controls.Add(this.text_InfoEmail);
      this.pnl_SettingsInfo.Controls.Add(this.foreverButton1);
      this.pnl_SettingsInfo.Location = new System.Drawing.Point(544, 32);
      this.pnl_SettingsInfo.Name = "pnl_SettingsInfo";
      this.pnl_SettingsInfo.Size = new System.Drawing.Size(262, 305);
      this.pnl_SettingsInfo.TabIndex = 19;
      // 
      // text_InfoVersion
      // 
      this.text_InfoVersion.AllowPromptAsInput = true;
      this.text_InfoVersion.AnimateReadOnly = false;
      this.text_InfoVersion.AsciiOnly = false;
      this.text_InfoVersion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.text_InfoVersion.BeepOnError = false;
      this.text_InfoVersion.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
      this.text_InfoVersion.Depth = 0;
      this.text_InfoVersion.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.text_InfoVersion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.text_InfoVersion.HidePromptOnLeave = false;
      this.text_InfoVersion.HideSelection = true;
      this.text_InfoVersion.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
      this.text_InfoVersion.LeadingIcon = null;
      this.text_InfoVersion.Location = new System.Drawing.Point(0, 83);
      this.text_InfoVersion.Mask = "";
      this.text_InfoVersion.MaxLength = 32767;
      this.text_InfoVersion.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
      this.text_InfoVersion.Name = "text_InfoVersion";
      this.text_InfoVersion.PasswordChar = '\0';
      this.text_InfoVersion.PrefixSuffix = ReaLTaiizor.Controls.MaterialMaskedTextBox.PrefixSuffixTypes.Prefix;
      this.text_InfoVersion.PrefixSuffixText = "Version:   ";
      this.text_InfoVersion.PromptChar = '_';
      this.text_InfoVersion.ReadOnly = true;
      this.text_InfoVersion.RejectInputOnFirstFailure = false;
      this.text_InfoVersion.ResetOnPrompt = true;
      this.text_InfoVersion.ResetOnSpace = true;
      this.text_InfoVersion.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.text_InfoVersion.SelectedText = "";
      this.text_InfoVersion.SelectionLength = 0;
      this.text_InfoVersion.SelectionStart = 0;
      this.text_InfoVersion.ShortcutsEnabled = true;
      this.text_InfoVersion.Size = new System.Drawing.Size(262, 48);
      this.text_InfoVersion.SkipLiterals = true;
      this.text_InfoVersion.TabIndex = 40;
      this.text_InfoVersion.TabStop = false;
      this.text_InfoVersion.Text = "X.X.X";
      this.text_InfoVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.text_InfoVersion.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
      this.text_InfoVersion.TrailingIcon = null;
      this.text_InfoVersion.UseSystemPasswordChar = false;
      this.text_InfoVersion.ValidatingType = null;
      // 
      // text_InfoAuthor
      // 
      this.text_InfoAuthor.AllowPromptAsInput = true;
      this.text_InfoAuthor.AnimateReadOnly = false;
      this.text_InfoAuthor.AsciiOnly = false;
      this.text_InfoAuthor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.text_InfoAuthor.BeepOnError = false;
      this.text_InfoAuthor.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
      this.text_InfoAuthor.Depth = 0;
      this.text_InfoAuthor.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.text_InfoAuthor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.text_InfoAuthor.HidePromptOnLeave = false;
      this.text_InfoAuthor.HideSelection = true;
      this.text_InfoAuthor.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
      this.text_InfoAuthor.LeadingIcon = null;
      this.text_InfoAuthor.Location = new System.Drawing.Point(0, 131);
      this.text_InfoAuthor.Mask = "";
      this.text_InfoAuthor.MaxLength = 32767;
      this.text_InfoAuthor.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
      this.text_InfoAuthor.Name = "text_InfoAuthor";
      this.text_InfoAuthor.PasswordChar = '\0';
      this.text_InfoAuthor.PrefixSuffix = ReaLTaiizor.Controls.MaterialMaskedTextBox.PrefixSuffixTypes.Prefix;
      this.text_InfoAuthor.PrefixSuffixText = "Autor:       ";
      this.text_InfoAuthor.PromptChar = '_';
      this.text_InfoAuthor.ReadOnly = true;
      this.text_InfoAuthor.RejectInputOnFirstFailure = false;
      this.text_InfoAuthor.ResetOnPrompt = true;
      this.text_InfoAuthor.ResetOnSpace = true;
      this.text_InfoAuthor.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.text_InfoAuthor.SelectedText = "";
      this.text_InfoAuthor.SelectionLength = 0;
      this.text_InfoAuthor.SelectionStart = 0;
      this.text_InfoAuthor.ShortcutsEnabled = true;
      this.text_InfoAuthor.Size = new System.Drawing.Size(262, 48);
      this.text_InfoAuthor.SkipLiterals = true;
      this.text_InfoAuthor.TabIndex = 39;
      this.text_InfoAuthor.TabStop = false;
      this.text_InfoAuthor.Text = "Andreas Kissener";
      this.text_InfoAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.text_InfoAuthor.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
      this.text_InfoAuthor.TrailingIcon = null;
      this.text_InfoAuthor.UseSystemPasswordChar = false;
      this.text_InfoAuthor.ValidatingType = null;
      // 
      // text_InfoPhone
      // 
      this.text_InfoPhone.AllowPromptAsInput = true;
      this.text_InfoPhone.AnimateReadOnly = false;
      this.text_InfoPhone.AsciiOnly = false;
      this.text_InfoPhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.text_InfoPhone.BeepOnError = false;
      this.text_InfoPhone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
      this.text_InfoPhone.Depth = 0;
      this.text_InfoPhone.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.text_InfoPhone.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.text_InfoPhone.HidePromptOnLeave = false;
      this.text_InfoPhone.HideSelection = true;
      this.text_InfoPhone.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
      this.text_InfoPhone.LeadingIcon = null;
      this.text_InfoPhone.Location = new System.Drawing.Point(0, 179);
      this.text_InfoPhone.Mask = "";
      this.text_InfoPhone.MaxLength = 32767;
      this.text_InfoPhone.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
      this.text_InfoPhone.Name = "text_InfoPhone";
      this.text_InfoPhone.PasswordChar = '\0';
      this.text_InfoPhone.PrefixSuffix = ReaLTaiizor.Controls.MaterialMaskedTextBox.PrefixSuffixTypes.Prefix;
      this.text_InfoPhone.PrefixSuffixText = "Telefon:   ";
      this.text_InfoPhone.PromptChar = '_';
      this.text_InfoPhone.ReadOnly = true;
      this.text_InfoPhone.RejectInputOnFirstFailure = false;
      this.text_InfoPhone.ResetOnPrompt = true;
      this.text_InfoPhone.ResetOnSpace = true;
      this.text_InfoPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.text_InfoPhone.SelectedText = "";
      this.text_InfoPhone.SelectionLength = 0;
      this.text_InfoPhone.SelectionStart = 0;
      this.text_InfoPhone.ShortcutsEnabled = true;
      this.text_InfoPhone.Size = new System.Drawing.Size(262, 48);
      this.text_InfoPhone.SkipLiterals = true;
      this.text_InfoPhone.TabIndex = 38;
      this.text_InfoPhone.TabStop = false;
      this.text_InfoPhone.Text = "0163 / 17 87 291";
      this.text_InfoPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.text_InfoPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
      this.text_InfoPhone.TrailingIcon = null;
      this.text_InfoPhone.UseSystemPasswordChar = false;
      this.text_InfoPhone.ValidatingType = null;
      // 
      // panel8
      // 
      this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      this.panel8.Controls.Add(this.label2);
      this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel8.Location = new System.Drawing.Point(0, 0);
      this.panel8.Name = "panel8";
      this.panel8.Size = new System.Drawing.Size(262, 227);
      this.panel8.TabIndex = 37;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      this.label2.Location = new System.Drawing.Point(3, 7);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(38, 20);
      this.label2.TabIndex = 18;
      this.label2.Text = "Info";
      // 
      // text_InfoEmail
      // 
      this.text_InfoEmail.AllowPromptAsInput = true;
      this.text_InfoEmail.AnimateReadOnly = false;
      this.text_InfoEmail.AsciiOnly = false;
      this.text_InfoEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.text_InfoEmail.BeepOnError = false;
      this.text_InfoEmail.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
      this.text_InfoEmail.Depth = 0;
      this.text_InfoEmail.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.text_InfoEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.text_InfoEmail.HidePromptOnLeave = false;
      this.text_InfoEmail.HideSelection = true;
      this.text_InfoEmail.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
      this.text_InfoEmail.LeadingIcon = null;
      this.text_InfoEmail.Location = new System.Drawing.Point(0, 227);
      this.text_InfoEmail.Mask = "";
      this.text_InfoEmail.MaxLength = 32767;
      this.text_InfoEmail.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
      this.text_InfoEmail.Name = "text_InfoEmail";
      this.text_InfoEmail.PasswordChar = '\0';
      this.text_InfoEmail.PrefixSuffix = ReaLTaiizor.Controls.MaterialMaskedTextBox.PrefixSuffixTypes.Prefix;
      this.text_InfoEmail.PrefixSuffixText = "Email:      ";
      this.text_InfoEmail.PromptChar = '_';
      this.text_InfoEmail.ReadOnly = true;
      this.text_InfoEmail.RejectInputOnFirstFailure = false;
      this.text_InfoEmail.ResetOnPrompt = true;
      this.text_InfoEmail.ResetOnSpace = true;
      this.text_InfoEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.text_InfoEmail.SelectedText = "";
      this.text_InfoEmail.SelectionLength = 0;
      this.text_InfoEmail.SelectionStart = 0;
      this.text_InfoEmail.ShortcutsEnabled = true;
      this.text_InfoEmail.Size = new System.Drawing.Size(262, 48);
      this.text_InfoEmail.SkipLiterals = true;
      this.text_InfoEmail.TabIndex = 2;
      this.text_InfoEmail.TabStop = false;
      this.text_InfoEmail.Text = "andreas.kissener@gmx.de";
      this.text_InfoEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.text_InfoEmail.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
      this.text_InfoEmail.TrailingIcon = null;
      this.text_InfoEmail.UseSystemPasswordChar = false;
      this.text_InfoEmail.ValidatingType = null;
      // 
      // foreverButton1
      // 
      this.foreverButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      this.foreverButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      this.foreverButton1.Cursor = System.Windows.Forms.Cursors.Hand;
      this.foreverButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.foreverButton1.Enabled = false;
      this.foreverButton1.Font = new System.Drawing.Font("Segoe UI", 11F);
      this.foreverButton1.Location = new System.Drawing.Point(0, 275);
      this.foreverButton1.Name = "foreverButton1";
      this.foreverButton1.Rounded = false;
      this.foreverButton1.Size = new System.Drawing.Size(262, 30);
      this.foreverButton1.TabIndex = 4;
      this.foreverButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      // 
      // pnl_SettingsBackup
      // 
      this.pnl_SettingsBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pnl_SettingsBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      this.pnl_SettingsBackup.Controls.Add(this.pnl_SettingsBackupContent);
      this.pnl_SettingsBackup.Controls.Add(this.pnl_SettingsBackupHeader);
      this.pnl_SettingsBackup.Location = new System.Drawing.Point(32, 32);
      this.pnl_SettingsBackup.Name = "pnl_SettingsBackup";
      this.pnl_SettingsBackup.Padding = new System.Windows.Forms.Padding(3, 3, 3, 16);
      this.pnl_SettingsBackup.Size = new System.Drawing.Size(480, 522);
      this.pnl_SettingsBackup.TabIndex = 15;
      // 
      // pnl_SettingsBackupContent
      // 
      this.pnl_SettingsBackupContent.BackColor = System.Drawing.Color.White;
      this.pnl_SettingsBackupContent.Controls.Add(this.text_SettingsScanSensitivity);
      this.pnl_SettingsBackupContent.Controls.Add(this.toggle_SettingsBackupActive);
      this.pnl_SettingsBackupContent.Controls.Add(this.lbl_SettingsBackupActive);
      this.pnl_SettingsBackupContent.Controls.Add(this.text_SettingsBackupPath);
      this.pnl_SettingsBackupContent.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnl_SettingsBackupContent.Location = new System.Drawing.Point(3, 35);
      this.pnl_SettingsBackupContent.Name = "pnl_SettingsBackupContent";
      this.pnl_SettingsBackupContent.Size = new System.Drawing.Size(474, 471);
      this.pnl_SettingsBackupContent.TabIndex = 1;
      // 
      // text_SettingsScanSensitivity
      // 
      this.text_SettingsScanSensitivity.AllowPromptAsInput = true;
      this.text_SettingsScanSensitivity.AnimateReadOnly = false;
      this.text_SettingsScanSensitivity.AsciiOnly = false;
      this.text_SettingsScanSensitivity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.text_SettingsScanSensitivity.BeepOnError = false;
      this.text_SettingsScanSensitivity.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
      this.text_SettingsScanSensitivity.Depth = 0;
      this.text_SettingsScanSensitivity.Dock = System.Windows.Forms.DockStyle.Top;
      this.text_SettingsScanSensitivity.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.text_SettingsScanSensitivity.HelperText = "                                                             Erhöhen, wenn Scans " +
    "nicht erkannt werden (Standard: 50ms)";
      this.text_SettingsScanSensitivity.HidePromptOnLeave = false;
      this.text_SettingsScanSensitivity.HideSelection = true;
      this.text_SettingsScanSensitivity.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
      this.text_SettingsScanSensitivity.LeadingIcon = null;
      this.text_SettingsScanSensitivity.Location = new System.Drawing.Point(0, 96);
      this.text_SettingsScanSensitivity.Mask = "";
      this.text_SettingsScanSensitivity.MaxLength = 32767;
      this.text_SettingsScanSensitivity.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
      this.text_SettingsScanSensitivity.Name = "text_SettingsScanSensitivity";
      this.text_SettingsScanSensitivity.PasswordChar = '\0';
      this.text_SettingsScanSensitivity.PrefixSuffix = ReaLTaiizor.Controls.MaterialMaskedTextBox.PrefixSuffixTypes.Prefix;
      this.text_SettingsScanSensitivity.PrefixSuffixText = "Scansensibilität (ms):      ";
      this.text_SettingsScanSensitivity.PromptChar = '_';
      this.text_SettingsScanSensitivity.ReadOnly = false;
      this.text_SettingsScanSensitivity.RejectInputOnFirstFailure = false;
      this.text_SettingsScanSensitivity.ResetOnPrompt = true;
      this.text_SettingsScanSensitivity.ResetOnSpace = true;
      this.text_SettingsScanSensitivity.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.text_SettingsScanSensitivity.SelectedText = "";
      this.text_SettingsScanSensitivity.SelectionLength = 0;
      this.text_SettingsScanSensitivity.SelectionStart = 0;
      this.text_SettingsScanSensitivity.ShortcutsEnabled = true;
      this.text_SettingsScanSensitivity.ShowAssistiveText = true;
      this.text_SettingsScanSensitivity.Size = new System.Drawing.Size(474, 64);
      this.text_SettingsScanSensitivity.SkipLiterals = true;
      this.text_SettingsScanSensitivity.TabIndex = 11;
      this.text_SettingsScanSensitivity.TabStop = false;
      this.text_SettingsScanSensitivity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.text_SettingsScanSensitivity.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
      this.text_SettingsScanSensitivity.TrailingIcon = null;
      this.text_SettingsScanSensitivity.UseSystemPasswordChar = false;
      this.text_SettingsScanSensitivity.ValidatingType = null;
      this.text_SettingsScanSensitivity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_SettingsScanSensitivity_KeyPress);
      this.text_SettingsScanSensitivity.Validated += new System.EventHandler(this.text_SettingsScanSensitivity_Validated);
      // 
      // toggle_SettingsBackupActive
      // 
      this.toggle_SettingsBackupActive.BackColor = System.Drawing.Color.Transparent;
      this.toggle_SettingsBackupActive.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
      this.toggle_SettingsBackupActive.BaseColorRed = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
      this.toggle_SettingsBackupActive.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(85)))), ((int)(((byte)(86)))));
      this.toggle_SettingsBackupActive.Checked = false;
      this.toggle_SettingsBackupActive.Cursor = System.Windows.Forms.Cursors.Hand;
      this.toggle_SettingsBackupActive.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.toggle_SettingsBackupActive.Location = new System.Drawing.Point(393, 54);
      this.toggle_SettingsBackupActive.Name = "toggle_SettingsBackupActive";
      this.toggle_SettingsBackupActive.Options = ReaLTaiizor.Controls.ForeverToggle._Options.Style1;
      this.toggle_SettingsBackupActive.Size = new System.Drawing.Size(76, 33);
      this.toggle_SettingsBackupActive.TabIndex = 7;
      this.toggle_SettingsBackupActive.Text = "foreverToggle1";
      this.toggle_SettingsBackupActive.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
      this.toggle_SettingsBackupActive.ToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
      this.toggle_SettingsBackupActive.CheckedChanged += new ReaLTaiizor.Controls.ForeverToggle.CheckedChangedEventHandler(this.toggle_SettingsBackupActive_CheckedChanged);
      // 
      // lbl_SettingsBackupActive
      // 
      this.lbl_SettingsBackupActive.AllowPromptAsInput = true;
      this.lbl_SettingsBackupActive.AnimateReadOnly = true;
      this.lbl_SettingsBackupActive.AsciiOnly = false;
      this.lbl_SettingsBackupActive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.lbl_SettingsBackupActive.BeepOnError = false;
      this.lbl_SettingsBackupActive.Cursor = System.Windows.Forms.Cursors.Hand;
      this.lbl_SettingsBackupActive.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
      this.lbl_SettingsBackupActive.Depth = 0;
      this.lbl_SettingsBackupActive.Dock = System.Windows.Forms.DockStyle.Top;
      this.lbl_SettingsBackupActive.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.lbl_SettingsBackupActive.HidePromptOnLeave = false;
      this.lbl_SettingsBackupActive.HideSelection = true;
      this.lbl_SettingsBackupActive.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
      this.lbl_SettingsBackupActive.LeadingIcon = null;
      this.lbl_SettingsBackupActive.Location = new System.Drawing.Point(0, 48);
      this.lbl_SettingsBackupActive.Mask = "";
      this.lbl_SettingsBackupActive.MaxLength = 32767;
      this.lbl_SettingsBackupActive.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
      this.lbl_SettingsBackupActive.Name = "lbl_SettingsBackupActive";
      this.lbl_SettingsBackupActive.PasswordChar = '\0';
      this.lbl_SettingsBackupActive.PrefixSuffix = ReaLTaiizor.Controls.MaterialMaskedTextBox.PrefixSuffixTypes.Prefix;
      this.lbl_SettingsBackupActive.PrefixSuffixText = "Backup Aktiv:";
      this.lbl_SettingsBackupActive.PromptChar = '_';
      this.lbl_SettingsBackupActive.ReadOnly = true;
      this.lbl_SettingsBackupActive.RejectInputOnFirstFailure = false;
      this.lbl_SettingsBackupActive.ResetOnPrompt = true;
      this.lbl_SettingsBackupActive.ResetOnSpace = true;
      this.lbl_SettingsBackupActive.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.lbl_SettingsBackupActive.SelectedText = "";
      this.lbl_SettingsBackupActive.SelectionLength = 0;
      this.lbl_SettingsBackupActive.SelectionStart = 0;
      this.lbl_SettingsBackupActive.ShortcutsEnabled = true;
      this.lbl_SettingsBackupActive.Size = new System.Drawing.Size(474, 48);
      this.lbl_SettingsBackupActive.SkipLiterals = true;
      this.lbl_SettingsBackupActive.TabIndex = 10;
      this.lbl_SettingsBackupActive.TabStop = false;
      this.lbl_SettingsBackupActive.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.lbl_SettingsBackupActive.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
      this.lbl_SettingsBackupActive.TrailingIcon = null;
      this.lbl_SettingsBackupActive.UseSystemPasswordChar = false;
      this.lbl_SettingsBackupActive.ValidatingType = null;
      // 
      // text_SettingsBackupPath
      // 
      this.text_SettingsBackupPath.AllowPromptAsInput = true;
      this.text_SettingsBackupPath.AnimateReadOnly = false;
      this.text_SettingsBackupPath.AsciiOnly = false;
      this.text_SettingsBackupPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.text_SettingsBackupPath.BeepOnError = false;
      this.text_SettingsBackupPath.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
      this.text_SettingsBackupPath.Depth = 0;
      this.text_SettingsBackupPath.Dock = System.Windows.Forms.DockStyle.Top;
      this.text_SettingsBackupPath.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.text_SettingsBackupPath.HidePromptOnLeave = false;
      this.text_SettingsBackupPath.HideSelection = true;
      this.text_SettingsBackupPath.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
      this.text_SettingsBackupPath.LeadingIcon = null;
      this.text_SettingsBackupPath.Location = new System.Drawing.Point(0, 0);
      this.text_SettingsBackupPath.Mask = "";
      this.text_SettingsBackupPath.MaxLength = 32767;
      this.text_SettingsBackupPath.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
      this.text_SettingsBackupPath.Name = "text_SettingsBackupPath";
      this.text_SettingsBackupPath.PasswordChar = '\0';
      this.text_SettingsBackupPath.PrefixSuffix = ReaLTaiizor.Controls.MaterialMaskedTextBox.PrefixSuffixTypes.Prefix;
      this.text_SettingsBackupPath.PrefixSuffixText = "Backup Pfad:      ";
      this.text_SettingsBackupPath.PromptChar = '_';
      this.text_SettingsBackupPath.ReadOnly = false;
      this.text_SettingsBackupPath.RejectInputOnFirstFailure = false;
      this.text_SettingsBackupPath.ResetOnPrompt = true;
      this.text_SettingsBackupPath.ResetOnSpace = true;
      this.text_SettingsBackupPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.text_SettingsBackupPath.SelectedText = "";
      this.text_SettingsBackupPath.SelectionLength = 0;
      this.text_SettingsBackupPath.SelectionStart = 0;
      this.text_SettingsBackupPath.ShortcutsEnabled = true;
      this.text_SettingsBackupPath.Size = new System.Drawing.Size(474, 48);
      this.text_SettingsBackupPath.SkipLiterals = true;
      this.text_SettingsBackupPath.TabIndex = 8;
      this.text_SettingsBackupPath.TabStop = false;
      this.text_SettingsBackupPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.text_SettingsBackupPath.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
      this.text_SettingsBackupPath.TrailingIcon = global::LibraryTool.Properties.Resources.folder;
      this.text_SettingsBackupPath.UseSystemPasswordChar = false;
      this.text_SettingsBackupPath.ValidatingType = null;
      this.text_SettingsBackupPath.TrailingIconClick += new System.EventHandler(this.text_SettingsBackupPath_TrailingIconClick);
      this.text_SettingsBackupPath.Validated += new System.EventHandler(this.text_SettingsBackupPath_Validated);
      // 
      // pnl_SettingsBackupHeader
      // 
      this.pnl_SettingsBackupHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      this.pnl_SettingsBackupHeader.Controls.Add(this.lbl_SettingsBackupHeader);
      this.pnl_SettingsBackupHeader.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnl_SettingsBackupHeader.Location = new System.Drawing.Point(3, 3);
      this.pnl_SettingsBackupHeader.Name = "pnl_SettingsBackupHeader";
      this.pnl_SettingsBackupHeader.Size = new System.Drawing.Size(474, 32);
      this.pnl_SettingsBackupHeader.TabIndex = 0;
      // 
      // lbl_SettingsBackupHeader
      // 
      this.lbl_SettingsBackupHeader.BackColor = System.Drawing.Color.Transparent;
      this.lbl_SettingsBackupHeader.Dock = System.Windows.Forms.DockStyle.Left;
      this.lbl_SettingsBackupHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.lbl_SettingsBackupHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
      this.lbl_SettingsBackupHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      this.lbl_SettingsBackupHeader.Location = new System.Drawing.Point(0, 0);
      this.lbl_SettingsBackupHeader.Name = "lbl_SettingsBackupHeader";
      this.lbl_SettingsBackupHeader.Size = new System.Drawing.Size(216, 32);
      this.lbl_SettingsBackupHeader.TabIndex = 15;
      this.lbl_SettingsBackupHeader.Text = "  Einstellungen";
      this.lbl_SettingsBackupHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // il_smallButtons
      // 
      this.il_smallButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("il_smallButtons.ImageStream")));
      this.il_smallButtons.TransparentColor = System.Drawing.Color.Transparent;
      this.il_smallButtons.Images.SetKeyName(0, "add.png");
      // 
      // il_books
      // 
      this.il_books.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("il_books.ImageStream")));
      this.il_books.TransparentColor = System.Drawing.Color.Transparent;
      this.il_books.Images.SetKeyName(0, "rental.png");
      this.il_books.Images.SetKeyName(1, "return.png");
      // 
      // folderBrowserDialog1
      // 
      this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
      // 
      // text_Github
      // 
      this.text_Github.AllowPromptAsInput = true;
      this.text_Github.AnimateReadOnly = false;
      this.text_Github.AsciiOnly = false;
      this.text_Github.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.text_Github.BeepOnError = false;
      this.text_Github.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
      this.text_Github.Depth = 0;
      this.text_Github.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.text_Github.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.text_Github.HidePromptOnLeave = false;
      this.text_Github.HideSelection = true;
      this.text_Github.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
      this.text_Github.LeadingIcon = null;
      this.text_Github.Location = new System.Drawing.Point(0, 35);
      this.text_Github.Mask = "";
      this.text_Github.MaxLength = 32767;
      this.text_Github.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
      this.text_Github.Name = "text_Github";
      this.text_Github.PasswordChar = '\0';
      this.text_Github.PrefixSuffix = ReaLTaiizor.Controls.MaterialMaskedTextBox.PrefixSuffixTypes.Prefix;
      this.text_Github.PrefixSuffixText = "Github:    ";
      this.text_Github.PromptChar = '_';
      this.text_Github.ReadOnly = true;
      this.text_Github.RejectInputOnFirstFailure = false;
      this.text_Github.ResetOnPrompt = true;
      this.text_Github.ResetOnSpace = true;
      this.text_Github.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.text_Github.SelectedText = "";
      this.text_Github.SelectionLength = 0;
      this.text_Github.SelectionStart = 0;
      this.text_Github.ShortcutsEnabled = true;
      this.text_Github.Size = new System.Drawing.Size(262, 48);
      this.text_Github.SkipLiterals = true;
      this.text_Github.TabIndex = 41;
      this.text_Github.TabStop = false;
      this.text_Github.Text = "https://github.com/EchseKuhTiere/LibraryTool.git";
      this.text_Github.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.text_Github.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
      this.text_Github.TrailingIcon = null;
      this.text_Github.UseSystemPasswordChar = false;
      this.text_Github.ValidatingType = null;
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1007, 635);
      this.Controls.Add(this.tab_sideBar);
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.KeyPreview = true;
      this.Name = "Main";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form1";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.Shown += new System.EventHandler(this.Form1_Shown);
      this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Main_KeyPress);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.tab_sideBar.ResumeLayout(false);
      this.tab_Dashboard.ResumeLayout(false);
      this.pnl_DashboardNote.ResumeLayout(false);
      this.pnl_DashboardNotePadding.ResumeLayout(false);
      this.pnl_DashboardNotePadding.PerformLayout();
      this.pnl_DashboardNoteHeader.ResumeLayout(false);
      this.pnl_DashboardBackup.ResumeLayout(false);
      this.pnl_DashboardBackup.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.img_DashboardBackup)).EndInit();
      this.pnl_DashboardKids.ResumeLayout(false);
      this.pnl_DashboardKids.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.img_DashboardKids)).EndInit();
      this.pnl_DashboardBooks.ResumeLayout(false);
      this.pnl_DashboardBooks.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.img_DashboardBook)).EndInit();
      this.tab_Rental.ResumeLayout(false);
      this.pnl_RentalActions.ResumeLayout(false);
      this.pnl_RentalActionsHeader.ResumeLayout(false);
      this.pnl_RentalActionsHeader.PerformLayout();
      this.pnl_RentalBooks.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gr_RentalBooks)).EndInit();
      this.pnl_RentalBooksHeader.ResumeLayout(false);
      this.pnl_RentalKids.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gr_RentalKids)).EndInit();
      this.pnl_RentalKidsHeader.ResumeLayout(false);
      this.tab_Return.ResumeLayout(false);
      this.pnl_ReturnAction.ResumeLayout(false);
      this.pnl_ReturnActionHeader.ResumeLayout(false);
      this.pnl_ReturnActionHeader.PerformLayout();
      this.tab_Inventory.ResumeLayout(false);
      this.pnl_BooksInventory.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.pnl_BooksNew.ResumeLayout(false);
      this.pnl_BooksNewHeader.ResumeLayout(false);
      this.pnl_BooksNewHeader.PerformLayout();
      this.pnl_Books.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gr_Books)).EndInit();
      this.pnl_BooksHeader.ResumeLayout(false);
      this.pnl_BooksHeader.PerformLayout();
      this.tab_Kids.ResumeLayout(false);
      this.pnl_AllKidsAddContainer.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.pnl_AllKidsAdd.ResumeLayout(false);
      this.pnl_AllKidsAdd.PerformLayout();
      this.pnl_AllKids.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gr_AllKids)).EndInit();
      this.pnl_AllKidsHeader.ResumeLayout(false);
      this.pnl_AllKidsHeader.PerformLayout();
      this.tab_History.ResumeLayout(false);
      this.pnl_LastActions.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gr_LastActions)).EndInit();
      this.pnl_LastActionsHeader.ResumeLayout(false);
      this.pnl_LastActionsHeader.PerformLayout();
      this.tab_Settings.ResumeLayout(false);
      this.pnl_SettingsInfo.ResumeLayout(false);
      this.panel8.ResumeLayout(false);
      this.panel8.PerformLayout();
      this.pnl_SettingsBackup.ResumeLayout(false);
      this.pnl_SettingsBackupContent.ResumeLayout(false);
      this.pnl_SettingsBackupHeader.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private Panel panel1;
    private Label lbl_Header;
    private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
    private ImageList il_buttons;
    private ReaLTaiizor.Controls.TabPage tab_sideBar;
    private TabPage tab_Dashboard;
    private TabPage tab_Rental;
    private TabPage tab_Inventory;
    private TabPage tab_Kids;
    private TabPage tab_History;
    private Panel pnl_DashboardBooks;
    private ReaLTaiizor.Controls.SkyLabel lbl_DashboardBooks;
    private ReaLTaiizor.Controls.SkyLabel lbl_DashboardBooksTotal;
    private Panel pnl_DashboardKids;
    private ReaLTaiizor.Controls.SkyLabel lbl_DashboardKidsGroups;
    private ReaLTaiizor.Controls.SkyLabel lbl_DashboardKids;
    private ReaLTaiizor.Controls.SkyLabel lbl_DashboardKidsTotal;
    private PictureBox img_DashboardBook;
    private ReaLTaiizor.Controls.SkyLabel lbl_DashboardBooksRented;
    private PictureBox img_DashboardKids;
    private Panel pnl_DashboardBackup;
    private PictureBox img_DashboardBackup;
    private ReaLTaiizor.Controls.SkyLabel lbl_DashboardBackupDate;
    private ReaLTaiizor.Controls.SkyLabel lbl_DashboardBackup;
    private ReaLTaiizor.Controls.SkyLabel lbl_DashboardBackupState;
    private Panel pnl_DashboardNote;
    private Panel pnl_DashboardNoteHeader;
    private ReaLTaiizor.Controls.SkyLabel lbl_DashboardNoteHeader;
    private Panel pnl_DashboardNotePadding;
    private TextBox text_Note;
    private ImageList il_books;
    private Panel pnl_RentalKids;
    private DataGridView gr_RentalKids;
    private Panel pnl_RentalKidsHeader;
    private Panel pnl_RentalBooks;
    private DataGridView gr_RentalBooks;
    private Panel pnl_RentalBooksHeader;
    private ReaLTaiizor.Controls.SkyLabel lbl_RentalBooksHeader;
    private ImageList il_smallButtons;
    private Panel pnl_RentalActions;
    private ReaLTaiizor.Controls.ForeverComboBox cbb_RentalGroup;
    private Panel pnl_Books;
    private DataGridView gr_Books;
    private Panel pnl_BooksHeader;
    private ReaLTaiizor.Controls.SkyLabel lbl_BooksHeader;
    private Panel pnl_BooksNew;
    private ReaLTaiizor.Controls.MaterialMaskedTextBox text_RentalID;
    private ReaLTaiizor.Controls.MaterialMaskedTextBox text_BooksNewID;
    private ReaLTaiizor.Controls.ForeverButton btn_BooksSave;
    private Panel pnl_RentalActionsHeader;
    private Label lbl_RentalAction;
    private ReaLTaiizor.Controls.MaterialMaskedTextBox text_BooksNewName;
    private ReaLTaiizor.Controls.MaterialMaskedTextBox text_BooksNewBarcode;
    private ReaLTaiizor.Controls.MaterialMaskedTextBox text_RentalBarcode;
    private Panel pnl_AllKids;
    private DataGridView gr_AllKids;
    private Panel pnl_AllKidsHeader;
    private ReaLTaiizor.Controls.SkyLabel lbl_AllKidsHeader;
    private Panel pnl_AllKidsAddContainer;
    private ReaLTaiizor.Controls.ForeverButton btn_AllKidsAdd;
    private Panel pnl_BooksNewHeader;
    private Label lbl_BooksNewHeader;
    private Panel pnl_AllKidsAdd;
    private Label lbl_AllKidsAddHeader;
    private Panel pnl_BooksInventory;
    private ReaLTaiizor.Controls.ForeverButton btn_BooksInventoryPrintParentInfo;
    private Panel panel3;
    private Label label1;
    private TabPage tab_Return;
    private Panel pnl_ReturnAction;
    private Panel pnl_ReturnActionHeader;
    private Label lbl_ReturnActionHeader;
    private ReaLTaiizor.Controls.MaterialMaskedTextBox text_ReturnActionID;
    private ReaLTaiizor.Controls.MaterialMaskedTextBox text_ReturnActionBarcode;
    private Panel pnl_LastActions;
    private DataGridView gr_LastActions;
    private Panel pnl_LastActionsHeader;
    private ReaLTaiizor.Controls.SkyLabel lbl_LastActionsHeader;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn gr_LastActionsOperation;
    private DataGridViewTextBoxColumn gr_LastActionsTable;
    private DataGridViewTextBoxColumn gr_LastActionsValue;
    private DataGridViewTextBoxColumn gr_LastActionsTimestamp;
    private TabPage tab_Settings;
    private Panel pnl_SettingsBackup;
    private Panel pnl_SettingsBackupHeader;
    private ReaLTaiizor.Controls.SkyLabel lbl_SettingsBackupHeader;
    private Panel pnl_SettingsBackupContent;
    private FolderBrowserDialog folderBrowserDialog1;
    private Panel pnl_SettingsInfo;
    private Panel panel8;
    private Label label2;
    private ReaLTaiizor.Controls.MaterialMaskedTextBox text_InfoEmail;
    private ReaLTaiizor.Controls.ForeverButton foreverButton1;
    private ReaLTaiizor.Controls.MaterialMaskedTextBox text_InfoVersion;
    private ReaLTaiizor.Controls.MaterialMaskedTextBox text_InfoAuthor;
    private ReaLTaiizor.Controls.MaterialMaskedTextBox text_InfoPhone;
    private ReaLTaiizor.Controls.ForeverToggle toggle_SettingsBackupActive;
    private ReaLTaiizor.Controls.MaterialMaskedTextBox lbl_SettingsBackupActive;
    private ReaLTaiizor.Controls.MaterialMaskedTextBox text_SettingsBackupPath;
    private ReaLTaiizor.Controls.MaterialMaskedTextBox text_SettingsScanSensitivity;
    private ReaLTaiizor.Controls.ForeverButton btn_BooksInventoryStart;
    private ReaLTaiizor.Controls.ForeverButton btn_BooksInventoryContinue;
    private DataGridViewTextBoxColumn gr_AllKidsID;
    private DataGridViewTextBoxColumn gr_AllKidsFirstName;
    private DataGridViewTextBoxColumn gr_AllKidsSurname;
    private DataGridViewComboBoxColumn gr_AllKidsGroup;
    private DataGridViewButtonColumn gr_AllKidsDelete;
    private DataGridViewTextBoxColumn gr_RentalKidsID;
    private DataGridViewTextBoxColumn gr_RentalKidsName;
    private DataGridViewTextBoxColumn gr_KidsSurname;
    private DataGridViewTextBoxColumn gr_KidsGroup;
    private DataGridViewTextBoxColumn gr_KidsRentalCount;
    private ReaLTaiizor.Controls.CrownTextBox text_BooksFilter;
    private ReaLTaiizor.Controls.CrownTextBox text_KidsFilter;
    private ReaLTaiizor.Controls.CrownTextBox text_HistoryFilter;
    private Panel panel2;
    private ReaLTaiizor.Controls.MaterialComboBox cbb_NewKidGroup;
    private ReaLTaiizor.Controls.MaterialMaskedTextBox text_NewKidsFirstName;
    private ReaLTaiizor.Controls.MaterialMaskedTextBox text_NewKidsSurname;
    private DataGridViewTextBoxColumn gr_RentalID;
    private DataGridViewTextBoxColumn gr_RentalBooksId;
    private DataGridViewTextBoxColumn gr_RentalBooksName;
    private DataGridViewTextBoxColumn Date;
    private DataGridViewTextBoxColumn gr_BooksID;
    private DataGridViewTextBoxColumn gr_BooksExternalID;
    private DataGridViewTextBoxColumn gr_BooksName;
    private DataGridViewTextBoxColumn gr_BooksBarcode;
    private DataGridViewButtonColumn gr_BooksBarcodeScan;
    private DataGridViewTextBoxColumn gr_BooksRented;
    private DataGridViewButtonColumn gr_BooksDelete;
    private DataGridViewCheckBoxColumn gr_BooksInventoryCheck;
    private ReaLTaiizor.Controls.MaterialMaskedTextBox text_Github;
  }
}
