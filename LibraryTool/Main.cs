using DocumentFormat.OpenXml.Wordprocessing;
using MiniSoftware;
using ReaLTaiizor.Child.Material;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LibraryTool
{
  public partial class Main : Form
  {
    public const int WM_NCLBUTTONDOWN = 0xA1;
    public const int HT_CAPTION = 0x2;

    private bool m_InventoryActive = false;

    private string barcodeBuffer = string.Empty;
    private int BarcodeTimeoutMilliseconds = 30;
    private Timer barcodeInputTimer;
    private string ActiveControlTextBackup = string.Empty;
    private SoundPlayer AlertSound;

    [DllImportAttribute("user32.dll")]
    public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
    [DllImportAttribute("user32.dll")]
    public static extern bool ReleaseCapture();

    // https://stackoverflow.com/questions/55567602/system-entrypointnotfoundexception-gdi32-dll-dllsinde-createroundrecrgn-n
    [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

    public Main()
    {
      InitializeComponent();
      InitializeBarcodeInputTimer();

      var version = Assembly.GetExecutingAssembly().GetName().Version;
      text_InfoVersion.Text = version.Major + "." + version.Minor + "." + version.Build;

      AlertSound = new SoundPlayer(Properties.Resources.alert_sound);
    }

    private void InitializeBarcodeInputTimer()
    {
      barcodeInputTimer = new Timer();
      barcodeInputTimer.Interval = BarcodeTimeoutMilliseconds;
      barcodeInputTimer.Tick += BarcodeInputTimer_Tick;
    }

    private void BarcodeInputTimer_Tick(object sender, EventArgs e)
    {
      barcodeBuffer = string.Empty;
    }

    private void panel1_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        ReleaseCapture();
        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      var sysInfo = Persistence.Instance.GetSysInfo();

      if (sysInfo == null)
      {
        sysInfo = Persistence.Instance.InitSystemInfo();
      }

      text_SettingsBackupPath.Text = sysInfo.BackupPath;
      toggle_SettingsBackupActive.Checked = sysInfo.BackupActive;
      toggle_SettingsBackupActive_CheckedChanged(toggle_SettingsBackupActive); // not firing from line above...
      if (sysInfo.ScanSensitivity > 0)
      {
        BarcodeTimeoutMilliseconds = sysInfo.ScanSensitivity;
      }
      text_SettingsScanSensitivity.Text = BarcodeTimeoutMilliseconds.ToString();
      text_Note.Text = sysInfo.Info;

      Backup.Instance.SetBackupPath(Path.Combine(sysInfo.BackupPath, Persistence.Instance.DatabaseName));

      int radius = 14;
      pnl_DashboardBooks.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnl_DashboardBooks.Width, pnl_DashboardBooks.Height, radius, radius));
      pnl_DashboardKids.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnl_DashboardKids.Width, pnl_DashboardKids.Height, radius, radius));
      pnl_DashboardBackup.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnl_DashboardBackup.Width, pnl_DashboardBackup.Height, radius, radius));
      pnl_DashboardNote.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnl_DashboardNote.Width, pnl_DashboardNote.Height, radius, radius));

      pnl_RentalKids.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnl_RentalKids.Width, pnl_RentalKids.Height, radius, radius));
      pnl_RentalBooks.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnl_RentalBooks.Width, pnl_RentalBooks.Height, radius, radius));
      pnl_RentalActions.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnl_RentalActions.Width, pnl_RentalActions.Height, radius, radius));

      pnl_ReturnAction.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnl_ReturnAction.Width, pnl_ReturnAction.Height, radius, radius));

      pnl_Books.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnl_Books.Width, pnl_Books.Height, radius, radius));
      pnl_BooksNew.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnl_BooksNew.Width, pnl_BooksNew.Height, radius, radius));
      pnl_BooksInventory.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnl_BooksInventory.Width, pnl_BooksInventory.Height, radius, radius));

      pnl_AllKids.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnl_AllKids.Width, pnl_AllKids.Height, radius, radius));
      pnl_AllKidsAddContainer.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnl_AllKidsAddContainer.Width, pnl_AllKidsAddContainer.Height, radius, radius));

      pnl_LastActions.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnl_LastActions.Width, pnl_LastActions.Height, radius, radius));

      pnl_SettingsBackup.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnl_SettingsBackup.Width, pnl_SettingsBackup.Height, radius, radius));
      pnl_SettingsInfo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnl_SettingsInfo.Width, pnl_SettingsInfo.Height, radius, radius));
    }

    private void Form1_Shown(object sender, EventArgs e)
    {
      LoadDashboard();
    }

    private void GR_RentalKids_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
      if (gr_RentalKids.Columns[e.ColumnIndex].Name == "GR_ACTION_RENTAL")
      {
        e.Value = il_books.Images[0];
        e.FormattingApplied = true;
      }
    }

    private void tab_sideBar_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (tab_sideBar.SelectedTab.Equals(tab_Dashboard))
      {
        LoadDashboard();
      }
      else if (tab_sideBar.SelectedTab.Equals(tab_Rental))
      {
        LoadRental();
      }
      else if (tab_sideBar.SelectedTab.Equals(tab_Return))
      {
        LoadReturn();
      }
      else if (tab_sideBar.SelectedTab.Equals(tab_Inventory))
      {
        LoadInventory();
      }
      else if (tab_sideBar.SelectedTab.Equals(tab_Kids))
      {
        LoadKids();
      }
      else if (tab_sideBar.SelectedTab.Equals(tab_History))
      {
        LoadHistory();
      }
    }

    private void LoadDashboard()
    {
      lbl_DashboardBooksTotal.Text = Persistence.Instance.GetBooksCount().ToString();
      lbl_DashboardBooksRented.Text = Persistence.Instance.GetRentalCount().ToString() + " verliehen";
      lbl_DashboardKidsTotal.Text = Persistence.Instance.GetKidsCount(null).ToString();
      lbl_DashboardKidsGroups.Text = Persistence.Instance.GetKidsCount(Groups.Waschbären).ToString() + " W/" +
        Persistence.Instance.GetKidsCount(Groups.Igel).ToString() + " I/" +
        Persistence.Instance.GetKidsCount(Groups.Mäuse).ToString() + " M";

      lbl_DashboardBackupState.Text = Backup.Instance.Active ? "Aktiv" : "Inaktiv";
      var lastBackupDate = Backup.Instance.GetLastBackupDate();
      if (lastBackupDate.HasValue)
        lbl_DashboardBackupDate.Text = lastBackupDate.ToString();
      else
        lbl_DashboardBackupDate.Text = "---";
    }

    private void LoadRental()
    {
      cbb_RentalGroup.Items.Clear();
      cbb_RentalGroup.Items.AddRange(Enum.GetNames(typeof(Groups)));
      cbb_RentalGroup.SelectedIndex = 0;
    }

    private void LoadReturn()
    {

    }

    private void LoadInventory()
    {
      gr_Books.Rows.Clear();
      var books = Persistence.Instance.GetAllBooks();
      text_BooksFilter.AutoCompleteCustomSource.AddRange(books.Select(book => book.Name).ToArray());
      gr_Books.BeginUpdate();
      try
      {
        foreach (var book in books)
        {
          var rental = Persistence.Instance.GetRentalByBookId(book.ID);
          var rentalInfo = rental != null ? rental.Kid.Name + " " + rental.Kid.Surname + " (" + Enum.GetName(typeof(Groups), rental.Kid.GroupId) + ")" : "";
          gr_Books.Rows.Add(book.ID, book.ExternalID, book.Name, book.Barcode, string.Empty, rentalInfo, null, book.InventoryStatus == 1 ? true : false);
        }
      } finally
      {
        gr_Books.EndUpdate();
      }
    }

    private void LoadKids()
    {
      cbb_NewKidGroup.Items.Clear();
      cbb_NewKidGroup.Items.Add("Gruppe: *");
      cbb_NewKidGroup.Items.AddRange(Enum.GetNames(typeof(Groups)));
      cbb_NewKidGroup.SelectedIndex = 0;

      gr_AllKidsGroup.Items.Clear();
      gr_AllKidsGroup.Items.AddRange(Enum.GetNames(typeof(Groups)));

      gr_AllKids.Rows.Clear();
      var kids = Persistence.Instance.GetAllKids();
      gr_AllKids.BeginUpdate();
      try
      {
        foreach (var kid in kids)
        {
          gr_AllKids.Rows.Add(kid.ID, kid.Name, kid.Surname, Enum.GetName(typeof(Groups), kid.GroupId));
        }
      } finally
      {
        gr_AllKids.EndUpdate();
      }
    }

    private void LoadHistory()
    {
      SetHistoryPage(0);
    }

    private void SetHistoryPage(int page)
    {
      var lastActions = Persistence.Instance.GetHistory(100, page * 100);

      gr_LastActions.Rows.Clear();

      gr_LastActions.BeginUpdate();
      try
      {
        foreach (var action in lastActions)
        {
          gr_LastActions.Rows.Add(action.ID, action.GetOperationName(), action.TableName, action.Value, action.TimeStamp);
        }
      }
      finally
      {
        gr_LastActions.EndUpdate();
      }
    }

    private void cbb_RentalGroup_SelectedValueChanged(object sender, EventArgs e)
    {
      var kids = Persistence.Instance.GetKidsByGroup((Groups)Enum.Parse(typeof(Groups), cbb_RentalGroup.Text));
      gr_RentalKids.Rows.Clear();
      gr_RentalKids.BeginUpdate();
      try
      {
        foreach (var kid in kids)
        {
          var rentalCount = Persistence.Instance.GetRentalsByKid(kid.ID).Count;
          gr_RentalKids.Rows.Add(kid.ID, kid.Name, kid.Surname, Enum.GetName(typeof(Groups), kid.GroupId), rentalCount > 0 ? (object)rentalCount : null);
        }
      }
      finally
      {
        gr_RentalKids.EndUpdate();
      }
    }

    private void gr_RentalKids_SelectionChanged(object sender, EventArgs e)
    {
      gr_RentalBooks.Rows.Clear();

      if (gr_RentalKids.SelectedRows.Count.Equals(0))
        return;

      var rentals = Persistence.Instance.GetRentalsByKid((int)gr_RentalKids.SelectedRows[0].Cells[gr_RentalKidsID.Index].Value);
      gr_RentalBooks.BeginUpdate();
      try
      {
        foreach (var rental in rentals)
        {
          gr_RentalBooks.Rows.Add(rental.ID, rental.Book.ExternalID, rental.Book.Name, rental.RentalDate.ToString("dd.MM.yyyy"));
        }
      }
      finally
      {
        gr_RentalBooks.EndUpdate();
      }
    }

    private void text_RentalID_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter && !text_RentalID.Text.Equals(string.Empty))
      {
        if (int.TryParse(text_RentalID.Text, out int ID))
        {
          var book = Persistence.Instance.GetBookByExternalId(ID);

          if (book != null)
          {
            if (gr_RentalKids.SelectedRows.Count > 0)
            {
              var kidId = (int)gr_RentalKids.SelectedRows[0].Cells[gr_RentalKidsID.Index].Value;
              var oldRental = Persistence.Instance.GetRentalByBookId(book.ID);

              // Create rental for current kid
              Persistence.Instance.CreateRental(kidId, book.ID);
              gr_RentalKids_SelectionChanged(null, null);
              gr_RentalKids.CurrentRow.Cells[gr_KidsRentalCount.Index].Value = gr_RentalBooks.RowCount;

              // Update book count from other kid if it was still rented
              if (oldRental != null && !oldRental.KidId.Equals(kidId))
              {
                var rowList = gr_RentalKids.Rows.Cast<DataGridViewRow>().Where(
                  r => (r.Cells[gr_RentalKidsID.Index].Value as int?).Value.Equals(oldRental.KidId)
                );
                if (rowList.Count() > 0)
                {
                  var row = rowList.First();
                  var rentalCount = Persistence.Instance.GetRentalsByKid(oldRental.KidId).Count;
                  row.Cells[gr_KidsRentalCount.Index].Value = rentalCount > 0 ? (object)rentalCount : null;
                }
              }
              text_RentalID.Text = string.Empty;
              text_RentalBarcode.Text = string.Empty;
            }
            else
              ShowBarcodeNoKidSelected();
          }
          else
            ShowBookIdNotFound(text_RentalID.Text);
        }
        e.Handled = true;
      }
    }

    private void btn_BooksSave_Click(object sender, EventArgs e)
    {
      SaveBook();
    }

    private void SaveBook()
    {
      if (!m_InventoryActive)
      {
        if (text_BooksNewName.Text.Length > 0)
        {
          int? externalId = null;
          if (text_BooksNewID.Text != string.Empty)
            externalId = int.Parse(text_BooksNewID.Text);
          var book = Persistence.Instance.CreateBook(externalId, text_BooksNewName.Text, text_BooksNewBarcode.Text);
          if (book != null)
          {
            gr_Books.Rows.Add(book.ID, book.ExternalID, book.Name, book.Barcode, book.RentalId != null);

            text_BooksNewName.Text = string.Empty;
            text_BooksNewBarcode.Text = string.Empty;
            text_BooksNewID.Text = string.Empty;
          }
        }
        else
          ShowDialogMissingData();
      }
      else
      {
        if (int.TryParse(text_BooksNewID.Text, out int externalId))
        {
          var book = Persistence.Instance.GetBookByExternalId(externalId);

          if (book != null)
          {
            ToastManager.Toast(this, "Inventur", "ID: " + book.ExternalID + Environment.NewLine + book.Name, Properties.Resources.barcode);
            Persistence.Instance.SetInventoryStatus(book.ID);
            foreach (DataGridViewRow row in gr_Books.Rows)
            {
              if ((int)row.Cells[gr_BooksID.Index].Value == book.ID)
              {
                row.Cells[gr_BooksInventoryCheck.Index].Value = true;
                row.Cells[gr_BooksRented.Index].Value = string.Empty;
                break;
              }
            }
            text_BooksNewID.Text = string.Empty;
          }
          else
            ShowBookIdNotFound(externalId.ToString());
        }
      }
    }

    private void DrawCellButtonIcon(Bitmap icon, DataGridViewCellPaintingEventArgs e)
    {
      e.Paint(e.CellBounds, DataGridViewPaintParts.All);
      var w = 18;
      var h = 18;
      var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
      var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

      e.Graphics.DrawImage(icon, new Rectangle(x, y, w, h));
      e.Handled = true;
    }

    private void gr_Books_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
    {
      if (e.RowIndex < 0)
          return;

      if (e.ColumnIndex == gr_BooksDelete.Index)
        DrawCellButtonIcon(Properties.Resources.delete, e);
      else if (e.ColumnIndex == gr_BooksBarcodeScan.Index)
        DrawCellButtonIcon(Properties.Resources.barcodeSmall, e);
    }

    private void gr_AllKids_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
    {
      if (e.RowIndex < 0)
        return;

      if (e.ColumnIndex == gr_AllKidsDelete.Index)
      {
        DrawCellButtonIcon(Properties.Resources.delete, e);
      }
    }

    private void btn_AllKidsAdd_Click(object sender, EventArgs e)
    {
      if (!text_NewKidsFirstName.Text.Equals(string.Empty) && !text_NewKidsSurname.Text.Equals(string.Empty) && cbb_NewKidGroup.SelectedIndex > 0)
      {
        var kid = Persistence.Instance.CreateKid(text_NewKidsFirstName.Text, text_NewKidsSurname.Text, (Groups)Enum.Parse(typeof(Groups), cbb_NewKidGroup.Text));
        
        gr_AllKids.Rows.Add(kid.ID,  kid.Name, kid.Surname, Enum.GetName(typeof(Groups), kid.GroupId));

        text_NewKidsFirstName.Clear();
        text_NewKidsSurname.Clear();
        cbb_NewKidGroup.SelectedIndex = 0;
      }
      else
        ShowDialogMissingData();
    }

    private void gr_Books_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      var senderGrid = (DataGridView)sender;

      if (e.RowIndex >= 0)
      {
        if (e.ColumnIndex == gr_BooksBarcodeScan.Index)
        {
          gr_Books.CurrentCell = gr_Books.CurrentRow.Cells[gr_BooksBarcode.Index];
          gr_Books.BeginEdit(true);
        }
        if (e.ColumnIndex == gr_BooksDelete.Index)
        {
          if (Dialog.Confirm("Bestätigen Sie", "Wirklich löschen?", "Löschen").Equals(DialogResult.OK))
          {
            Persistence.Instance.DeleteBook((int)senderGrid.Rows[e.RowIndex].Cells[gr_BooksID.Index].Value);
            gr_Books.Rows.RemoveAt(e.RowIndex);
          }
        }
      }
    }

    private void gr_AllKids_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      var senderGrid = (DataGridView)sender;

      if (e.ColumnIndex == gr_AllKidsDelete.Index && e.RowIndex >= 0)
      {
        var kidId = (int)senderGrid.Rows[e.RowIndex].Cells[gr_AllKidsID.Index].Value;
        if (Persistence.Instance.GetRentalsByKid(kidId).Count.Equals(0))
        {
          if (Dialog.Confirm("Bestätigen Sie", "Wirklich löschen?", "Löschen").Equals(DialogResult.OK))
          {
            Persistence.Instance.DeleteKid(kidId);
            gr_AllKids.Rows.RemoveAt(e.RowIndex);
          }
        }
        else
          Dialog.Show("Achtung!", "Löschen nicht möglich, es sind noch ausgeliehene Bücher eingetragen.");
      }
    }

    private void text_Enter(object sender, EventArgs e)
    {
      (sender as MaterialBaseMaskedTextBox).SelectAll();
    }

    private void text_ReturnActionID_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter && !text_ReturnActionID.Text.Equals(string.Empty))
      {
        if (int.TryParse(text_ReturnActionID.Text, out int externalId))
        {
          var book = Persistence.Instance.GetBookByExternalId(externalId);

          if (book != null)
          {
            if (Persistence.Instance.DeleteRentalByBook(book.ID))
            {
              ToastManager.Toast(this, "Rückgabe", book.ExternalID + Environment.NewLine + book.Name, Properties.Resources.buch);
            }
            else
            {
              ToastManager.Toast(this, "Fehler", "Kein Verleih eingetragen" + Environment.NewLine + "ID: " + book.ExternalID, Properties.Resources.Missing);
            }
            text_ReturnActionID.Text = string.Empty;
            text_ReturnActionBarcode.Text = string.Empty;
          }
          else
            ShowBookIdNotFound(text_ReturnActionID.Text);
        }

        e.Handled = true;
      }
    }

    private void text_ReturnActionBarcode_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter && !text_ReturnActionBarcode.Text.Equals(string.Empty))
      {
        var book = Persistence.Instance.GetBookByBarcode(text_ReturnActionBarcode.Text);

        if (book != null)
        {
          Persistence.Instance.DeleteRentalByBook(book.ID);

          text_ReturnActionID.Text = string.Empty;
          text_ReturnActionBarcode.Text = string.Empty;
        }
        else
          ShowBarcodeNotFound(text_ReturnActionBarcode.Text);

        e.Handled = true;
      }
    }

    private void text_SettingsBackupPath_TrailingIconClick(object sender, EventArgs e)
    {
      if (folderBrowserDialog1.ShowDialog().Equals(DialogResult.OK))
      {
        text_SettingsBackupPath.Text = folderBrowserDialog1.SelectedPath;
        text_SettingsBackupPath_Validated(sender, e);
      }
    }

    private void toggle_SettingsBackupActive_CheckedChanged(object sender)
    {
      Persistence.Instance.SetBackupActive(toggle_SettingsBackupActive.Checked);
      Backup.Instance.Active = toggle_SettingsBackupActive.Checked;
    }

    private void text_SettingsBackupPath_Validated(object sender, EventArgs e)
    {
      Persistence.Instance.SetBackupPath(text_SettingsBackupPath.Text);
      Backup.Instance.SetBackupPath(Path.Combine(text_SettingsBackupPath.Text, Persistence.Instance.DatabaseName));
    }

    private void text_Note_Validated(object sender, EventArgs e)
    {
      Persistence.Instance.SetInfo(text_Note.Text);
    }

    private void Main_FormClosing(object sender, FormClosingEventArgs e)
    {
      Backup.Instance.CreateBackup();
    }

    private void btn_BooksInventoryStart_Click(object sender, EventArgs e)
    {
      m_InventoryActive = !m_InventoryActive;
      text_BooksNewName.Enabled = !m_InventoryActive;

      if (m_InventoryActive)
      {
        if (Dialog.Confirm("Inventur starten", "Bei einer Inventur müssen alle Bücher gescannt/eingegeben werden." + Environment.NewLine +
              "Bücher die noch als ausgeliehen vermerkt sind, werden beim scannen automatisch zurückgegeben." + Environment.NewLine +
              "Ist die Inventur abgeschlossen, kann ein Bericht über fehlende, bzw. noch ausgeliehene Bücher erstellt werden." + Environment.NewLine +
              "Fortfahren?").Equals(DialogResult.OK))
        {
          Persistence.Instance.StartInventory();

          btn_BooksInventoryContinue_Click(sender, e);
        }
      }
      else
      {
        btn_BooksInventoryStart.Text = "Inventur starten";
        lbl_BooksNewHeader.Text = "Neues Buch eingeben";
        text_BooksNewName.PrefixSuffixText = "Name: *      ";
        text_BooksNewBarcode.PrefixSuffixText = "Barcode: *  ";
        btn_BooksSave.Text = "Speichern";
        btn_BooksInventoryContinue.Enabled = true;
        gr_BooksDelete.Visible = true;
        gr_BooksInventoryCheck.Visible = false;
        text_BooksNewName.Enabled = true;
      }
      btn_BooksSave.Invalidate();
    }

    private void btn_BooksInventoryContinue_Click(object sender, EventArgs e)
    {
      m_InventoryActive = true;

      btn_BooksInventoryStart.Text = "Inventur beenden";
      lbl_BooksNewHeader.Text = "Buch scannen oder ID eingeben";
      text_BooksNewName.PrefixSuffixText = "Name:         ";
      text_BooksNewBarcode.PrefixSuffixText = "Barcode:     ";
      btn_BooksSave.Text = "Bestätigen";
      btn_BooksInventoryContinue.Enabled = false;
      gr_BooksDelete.Visible = false;
      gr_BooksInventoryCheck.Visible = true;
      text_BooksNewName.Enabled = false;
      btn_BooksSave.Invalidate();
    }

    private void btn_BooksInventoryPrintParentInfo_Click(object sender, EventArgs e)
    {
      var docPath = Path.Combine(Directory.GetCurrentDirectory(), "Elternbriefe");

      DirectoryInfo di = new DirectoryInfo(docPath);

      foreach (FileInfo file in di.GetFiles())
      {
        if (file.FullName.ToLower().EndsWith(".docx"))
          file.Delete();
      }

      var rentals = Persistence.Instance.GetAllRentals();
      string firstName = string.Empty;
      string familyName = string.Empty;
      string bookList = string.Empty;
      Groups groupId = 0;
      int currentKidId = -1;

      foreach(var rental in rentals)
      {
        if (rental.KidId != currentKidId)
        {
          currentKidId = rental.KidId;
          CreateParentNotice(groupId, firstName, familyName, bookList.Trim());
          groupId = rental.Kid.GroupId;
          firstName = rental.Kid.Name;
          familyName = rental.Kid.Surname;
          bookList = string.Empty;
        }
        bookList += "• " + rental.Book.Name + Environment.NewLine;
      }
      CreateParentNotice(groupId, firstName, familyName, bookList.Trim());

      Process.Start(docPath);
    }

    private void CreateParentNotice(Groups group, string firstName, string familyName, string bookList)
    {
      if (familyName.Equals(string.Empty) || bookList.Equals(string.Empty))
        return;

      var fileName = "Elternbrief_" + Enum.GetName(typeof(Groups), group) + "_" + familyName + "_" + firstName + ".docx";
      foreach (var c in Path.GetInvalidFileNameChars())
      {
        fileName = fileName.Replace(c, '-');
      }

      var value = new Dictionary<string, object>()
      {
        ["FAMILY_NAME"] = familyName,
        ["BOOK_LIST"] = bookList
      };
      var path = Path.Combine(Directory.GetCurrentDirectory(), "Elternbriefe", fileName);
      Directory.CreateDirectory(Path.GetDirectoryName(path));
      MiniWord.SaveAsByTemplate(path, "Elternbrief_Template.docx", value);
    }

    private void Main_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (barcodeBuffer.Equals(string.Empty))
        ActiveControlTextBackup = ActiveControl.Text;

      barcodeInputTimer.Stop();
      barcodeInputTimer.Start();

      if (e.KeyChar.Equals((char)Keys.Enter) && barcodeBuffer.Length.Equals(13))
      {
        // Reset input in Active control, might not be a barcode control
        if (ActiveControl is MaterialBaseMaskedTextBox)
        {
          (ActiveControl as MaterialBaseMaskedTextBox).SelectionStart = 0;
          ActiveControl.Text = ActiveControlTextBackup;
          (ActiveControl as MaterialBaseMaskedTextBox).SelectionStart = 0;
        }
        else if (ActiveControl is TextBox)
        {
          (ActiveControl as TextBox).SelectionStart = 0;
          ActiveControl.Text = ActiveControlTextBackup;
          (ActiveControl as TextBox).SelectionStart = 0;
        }
        ProcessBarcode(barcodeBuffer);
        barcodeBuffer = string.Empty;
        e.Handled = true;
      }
      else
      {
        barcodeBuffer += e.KeyChar;
        if (barcodeBuffer.Length > 13)
          barcodeBuffer.Substring(barcodeBuffer.Length - 13, 13);
      }
    }

    private void ProcessBarcode(string barcode)
    {
      if (tab_sideBar.SelectedTab.Equals(tab_Rental))
      {
        text_RentalBarcode.Text = barcode;
        ProcessBarcodeRental(barcode);
      }
      else if (tab_sideBar.SelectedTab.Equals(tab_Return))
      {
        text_ReturnActionBarcode.Text = barcode;
        ProcessBarcodeReturn(barcode);
      }
      else if (tab_sideBar.SelectedTab.Equals(tab_Inventory))
      {
        text_BooksNewBarcode.Text = barcode;
        ProcessBarcodeInventory(barcode);
      }
    }

    private void ProcessBarcodeRental(string barcode)
    {
      var book = Persistence.Instance.GetBookByBarcode(barcode);

      if (book != null)
      {
        if (gr_RentalKids.SelectedRows.Count > 0)
        {
          ToastManager.Toast(this, "Verleih", "ID: " + book.ExternalID + Environment.NewLine + book.Name, Properties.Resources.barcode);

          var oldRental = Persistence.Instance.GetRentalByBookId(book.ID);

          // Create rental for current kid
          var kidId = (int)gr_RentalKids.SelectedRows[0].Cells[gr_RentalKidsID.Index].Value;
          Persistence.Instance.CreateRental(kidId, book.ID);
          gr_RentalKids_SelectionChanged(null, null);
          gr_RentalKids.CurrentRow.Cells[gr_KidsRentalCount.Index].Value = gr_RentalBooks.RowCount;

          // Update book count from other kid if it was still rented
          if (oldRental != null && !oldRental.KidId.Equals(kidId))
          {
            var rowList = gr_RentalKids.Rows.Cast<DataGridViewRow>().Where(
              r => (r.Cells[gr_RentalKidsID.Index].Value as int?).Value.Equals(oldRental.KidId)
            );
            if (rowList.Count() > 0)
            {
              var row = rowList.First();
              var rentalCount = Persistence.Instance.GetRentalsByKid(oldRental.KidId).Count;
              row.Cells[gr_KidsRentalCount.Index].Value = rentalCount > 0 ? (object)rentalCount : null;
            }
          }

          text_RentalID.Text = book.ExternalID.ToString();
        }
        else
          ShowBarcodeNoKidSelected();
      }
      else
        ShowBarcodeNotFound(barcode);
    }

    private void ProcessBarcodeReturn(string barcode)
    {
      var book = Persistence.Instance.GetBookByBarcode(barcode);

      if (book != null)
      {
        ToastManager.Toast(this, "Rückgabe", "ID: " + book.ExternalID + Environment.NewLine + book.Name, Properties.Resources.barcode);

        Persistence.Instance.DeleteRentalByBook(book.ID);
      }
      else
        ShowBarcodeNotFound(barcode);
    }

    private void ProcessBarcodeInventory(string barcode)
    {
      if (m_InventoryActive)
      {
        var book = Persistence.Instance.GetBookByBarcode(barcode);
        if (book != null)
        {
          ToastManager.Toast(this, "Inventur", "ID: " + book.ExternalID + Environment.NewLine + book.Name, Properties.Resources.barcode);
          Persistence.Instance.SetInventoryStatus(book.ID);
          foreach (DataGridViewRow row in gr_Books.Rows)
          {
            if ((int)row.Cells[gr_BooksID.Index].Value == book.ID)
            {
              row.Cells[gr_BooksInventoryCheck.Index].Value = true;
              break;
            }
          }
        }
        else
          ShowBarcodeNotFound(barcode);
      }
    }

    private void gr_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode.Equals(Keys.Enter))
      {
        e.Handled = true;
      }
    }

    private void text_SettingsScanSensitivity_Validated(object sender, EventArgs e)
    {
      if (!int.TryParse(text_SettingsScanSensitivity.Text, out int value))
        value = 50;

      BarcodeTimeoutMilliseconds = value;
      Persistence.Instance.SetScanSensitivity(value);
    }

    private void text_SettingsScanSensitivity_KeyPress(object sender, KeyPressEventArgs e)
    {
      e.Handled = !"0123456789".Contains(e.KeyChar);
    }

    private void ShowDialogMissingData()
    {
      Dialog.Show("Achtung", "Bitte geben Sie alle notwendigen Daten an");
      AlertSound.Play();
    }

    private void ShowBookIdNotFound(string bookId)
    {
      BeginInvoke((Action)(() => Dialog.Show("Ungültige ID", "Buch mit ID '" + text_ReturnActionID.Text + "' konnte nicht gefunden werden")));
      AlertSound.Play();
    }

    private void ShowBarcodeNotFound(string barcode)
    {
      BeginInvoke((Action)(() => Dialog.Show("Ungültiger Barcode", "Buch mit Barcode '" + barcode + "' konnte nicht gefunden werden")));
      AlertSound.Play();
    }

    private void ShowBarcodeNoKidSelected()
    {
      BeginInvoke((Action)(() => Dialog.Show("Ungültige Auswahl", "Kein Kind ausgewählt")));
      AlertSound.Play();
    }

    private void gr_Books_RowValidated(object sender, DataGridViewCellEventArgs e)
    {
      var row = gr_Books.Rows[e.RowIndex];

      Persistence.Instance.UpdateBook(
        (int)row.Cells[0].Value, 
        (int)row.Cells[1].Value, 
        (string)row.Cells[2].Value, 
        (string)row.Cells[3].Value
      );     
    }

    private void gr_AllKids_RowValidated(object sender, DataGridViewCellEventArgs e)
    {
      var row = gr_AllKids.Rows[e.RowIndex];

      Persistence.Instance.UpdateKid(
        (int)row.Cells[0].Value,
        (string)(row.Cells[1].Value),
        (string)row.Cells[2].Value,
        (Groups)Enum.Parse(typeof(Groups), (string)row.Cells[3].Value)
      );
    }

    const string c_str_Filter = "  Filter ...";

    private void text_BooksFilter_TextChanged(object sender, EventArgs e)
    {
      CrownTextBox textBox;
      DataGridView view;
      List<int> searchColumns = new List<int>();
      if (sender == text_BooksFilter)
      {
        textBox = text_BooksFilter;
        view = gr_Books;
        searchColumns.Add(gr_BooksName.Index);
        searchColumns.Add(gr_BooksExternalID.Index);
      }
      else if (sender == text_KidsFilter)
      {
        textBox = text_KidsFilter;
        view = gr_AllKids;
        searchColumns.Add(gr_AllKidsFirstName.Index);
        searchColumns.Add(gr_AllKidsSurname.Index);
      }
      else
      {
        textBox = text_HistoryFilter;
        view = gr_LastActions;
        searchColumns.Add(gr_LastActionsValue.Index);
      }

      if (textBox.Text.Equals(c_str_Filter) || textBox.Text.Length == 0)
      {
        for (int i = 0; i < view.RowCount; i++)
          view.Rows[i].Visible = true;
      }
      else
      {
        for (int i = 0; i < view.RowCount; i++)
        {
          var result = searchColumns.FindIndex(column => view.Rows[i].Cells[column].Value.ToString().ToLower().Contains(textBox.Text.ToLower()));
          view.Rows[i].Visible = result > -1;
        }
      }
    }

    private void text_BooksFilter_Enter(object sender, EventArgs e)
    {
      var filterTextbox = sender as CrownTextBox;
      filterTextbox.Font = new System.Drawing.Font(filterTextbox.Font, FontStyle.Regular);
      if (filterTextbox.Text.Equals(c_str_Filter))
      {
        filterTextbox.Text = string.Empty;
      }
    }

    private void text_BooksFilter_Leave(object sender, EventArgs e)
    {
      var filterTextbox = sender as CrownTextBox;
      if (filterTextbox.Text.Equals(string.Empty))
      {
        filterTextbox.Text = c_str_Filter;
        filterTextbox.Font = new System.Drawing.Font(filterTextbox.Font, FontStyle.Italic);
      }
    }

    private void text_BooksNewID_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode.Equals(Keys.Enter)) 
      {
        SaveBook();
      }
    }
  }
}
