using DocumentFormat.OpenXml.Bibliography;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SQLite;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LibraryTool
{
  public enum DBOperation
  {
    Insert, Update, Delete
  }

  public enum TableName
  {
    SysInfo,
    Groups,
    Ranks,
    Books,
    Kids,
    Rental,
    History
  }

  internal class Persistence
  {
    public string DatabaseName { get { return databaseName; } }

    private const string databaseName = "Library.db";
    private static Persistence instance;
    private SQLiteConnection SQLiteConnection;

    private Persistence()
    {
      var newDB = !File.Exists(DatabaseName);

      if (newDB)
        File.Create(DatabaseName).Close();

      SQLiteConnection = new SQLiteConnection("Data Source=" + DatabaseName + ";Version=3;foreign keys=true;");
      SQLiteConnection.Open();

      InitDB(SQLiteConnection);
      if (newDB)
        FillLookups(SQLiteConnection);

      instance = this;
    }

    public static Persistence Instance
    {
      get
      {
        if (instance == null)
          instance = new Persistence();

        return instance;
      }
    }

    private void InitDB(SQLiteConnection connection)
    {
      using (SQLiteCommand command = new SQLiteCommand(connection))
      {
        command.CommandText = "CREATE TABLE IF NOT EXISTS SYSINFO (" +
          "ID INTEGER PRIMARY KEY AUTOINCREMENT, " +
          "Info TEXT, " +
          "Version TEXT, " +
          "BackupActive INTEGER, " +
          "BackupPath TEXT, " +
          "ScanSensitivity INTEGER" +
          ");";
        command.ExecuteNonQuery();

        command.CommandText = "CREATE TABLE IF NOT EXISTS GROUPS (" +
          "ID INTEGER PRIMARY KEY AUTOINCREMENT, " +
          "Name TEXT" +
          ");";
        command.ExecuteNonQuery();

        command.CommandText = "CREATE TABLE IF NOT EXISTS RANKS (" +
          "ID INTEGER PRIMARY KEY AUTOINCREMENT, " +
          "Name TEXT" +
          ");";
        command.ExecuteNonQuery();

        command.CommandText = "CREATE TABLE IF NOT EXISTS BOOKS (" +
          "ID INTEGER PRIMARY KEY AUTOINCREMENT, " +
          "ExternalID INTEGER TYPE UNIQUE, " +
          "Name TEXT, " +
          "Barcode TEXT, " +
          "InventoryStatus INTEGER" +
          ");";
        command.ExecuteNonQuery();

        command.CommandText = "CREATE TABLE IF NOT EXISTS KIDS (" +
          "ID INTEGER PRIMARY KEY AUTOINCREMENT, " +
          "Name TEXT, " +
          "Surname TEXT, " +
          "GroupId INTEGER, " +
          "RankId INTEGER, " +
          "FOREIGN KEY(GroupId) REFERENCES GROUPS(ID));";
        command.ExecuteNonQuery();

        command.CommandText = "CREATE TABLE IF NOT EXISTS RENTAL (" +
          "ID INTEGER PRIMARY KEY AUTOINCREMENT, " +
          "KidId INTEGER, " +
          "BookId INTEGER TYPE UNIQUE, " +
          "RentalDate TIMESTAMP, " +
          "FOREIGN KEY(KidId) REFERENCES KIDS(ID) ON DELETE CASCADE, " +
          "FOREIGN KEY(BookId) REFERENCES BOOKS(ID) ON DELETE CASCADE" +
          ");";
        command.ExecuteNonQuery();

        command.CommandText = "CREATE TABLE IF NOT EXISTS HISTORY (" +
          "ID INTEGER PRIMARY KEY AUTOINCREMENT, " +
          "Operation INTEGER, " +
          "OperationTimestamp TIMESTAMP, " +
          "TableName TEXT, " +
          "Value TEXT" +
          ");";
        command.ExecuteNonQuery();
      }
    }

    public void Close()
    {
      if (SQLiteConnection != null)
        SQLiteConnection.Close();
    }

    private void FillLookups(SQLiteConnection connection)
    {
      foreach (Groups item in Enum.GetValues(typeof(Groups)))
      {
        CreateGroup(item);
      }
    }

    public SysInfo InitSystemInfo()
    {
      var sysInfo = new SysInfo
      {
        Version = Assembly.GetExecutingAssembly().GetName().Version.ToString(),
        BackupActive = false,
        BackupPath = string.Empty,
        Info = string.Empty,
        ScanSensitivity = 50
      };

      using (SQLiteCommand command = new SQLiteCommand("INSERT INTO SYSINFO (Version, ScanSensitivity) VALUES (@Version, @ScanSensitivity);", SQLiteConnection))
      {
        command.Parameters.AddWithValue("@Version", sysInfo.Version);
        command.Parameters.AddWithValue("@ScanSensitivity", sysInfo.ScanSensitivity);
        command.ExecuteNonQuery(); // This statement may be auto-committed.
      }

      return sysInfo;
    }

    public void SetVersion(string version)
    {
      using (SQLiteCommand command = new SQLiteCommand("UPDATE SYSINFO SET Version = @Version;", SQLiteConnection))
      {
        command.Parameters.AddWithValue("@Version", version);
        command.ExecuteNonQuery(); // This statement may be auto-committed.
      }
    }

    public void SetInfo(string info)
    {
      using (SQLiteCommand command = new SQLiteCommand("UPDATE SYSINFO SET Info = @Info;", SQLiteConnection))
      {
        command.Parameters.AddWithValue("@Info", info);
        command.ExecuteNonQuery(); // This statement may be auto-committed.
      }
    }

    public void SetBackupPath(string backupPath)
    {
      using (SQLiteCommand command = new SQLiteCommand("UPDATE SYSINFO SET BackupPath = @BackupPath;", SQLiteConnection))
      {
        command.Parameters.AddWithValue("@BackupPath", backupPath);
        command.ExecuteNonQuery(); // This statement may be auto-committed.
      }
    }

    public void SetBackupActive(bool active)
    {
      using (SQLiteCommand command = new SQLiteCommand("UPDATE SYSINFO SET BackupActive = @BackupActive;", SQLiteConnection))
      {
        command.Parameters.AddWithValue("@BackupActive", active ? 1 : 0);
        command.ExecuteNonQuery(); // This statement may be auto-committed.
      }
    }

    public void SetScanSensitivity(int milliseconds)
    {
      using (SQLiteCommand command = new SQLiteCommand("UPDATE SYSINFO SET ScanSensitivity = @ScanSensitivity;", SQLiteConnection))
      {
        command.Parameters.AddWithValue("@ScanSensitivity", milliseconds);
        command.ExecuteNonQuery(); // This statement may be auto-committed.
      }
    }

    public SysInfo GetSysInfo()
    {
      SysInfo sysInfo = null;

      using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM SYSINFO LIMIT 1", SQLiteConnection))
      { 
        using (SQLiteDataReader reader = command.ExecuteReader())
        {
          if (reader.Read())
          {
            sysInfo = new SysInfo
            {
              Version = reader["Version"].ToString(),
              Info = reader["Info"].ToString(),
              BackupActive = Convert.ToInt32(reader["BackupActive"]).Equals(1),
              BackupPath = reader["BackupPath"].ToString(),
              ScanSensitivity = Convert.ToInt32(reader["ScanSensitivity"])
            };
          }
        }
      }

      return sysInfo;
    }

    public Kid CreateKid(string name, string surname, Groups group)
    {
      using (SQLiteCommand command = new SQLiteCommand("INSERT INTO KIDS (Name, Surname, GroupId) VALUES (@Name, @Surname, @GroupId);", SQLiteConnection))
      {
        command.Parameters.AddWithValue("@Name", name);
        command.Parameters.AddWithValue("@Surname", surname);
        command.Parameters.AddWithValue("@GroupId", (int)group);
        command.ExecuteNonQuery(); // This statement may be auto-committed.
      }

      var kid = new Kid
      {
        ID = (int)SQLiteConnection.LastInsertRowId,
        Name = name,
        Surname = surname,
        GroupId = group
      };

      WriteHistory(TableName.Kids, name + " " + surname + "/" + Enum.GetName(typeof(Groups), group), DBOperation.Insert);

      return kid;
    }

    public bool UpdateKid(int kidId, string newName, string newSurname, Groups newGroup)
    {
      var kid = GetKidById(kidId);

      // not found or no update => abort
      if (kid == null || (kid.Name.Equals(newName) && kid.Surname.Equals(newSurname) && kid.GroupId.Equals(newGroup)))
        return false;

      using (SQLiteCommand command = new SQLiteCommand("UPDATE KIDS SET Name = @NewName, Surname = @NewSurname, GroupId = @NewGroupId WHERE ID = @KidId;", SQLiteConnection))
      {
        command.Parameters.AddWithValue("@KidId", kidId);
        command.Parameters.AddWithValue("@NewName", newName);
        command.Parameters.AddWithValue("@NewSurname", newSurname);
        command.Parameters.AddWithValue("@NewGroupId", (int)newGroup);
        command.ExecuteNonQuery();
      }
      WriteHistory(TableName.Kids, kid.Name + " " + kid.Surname + "/" + Enum.GetName(typeof(Groups), kid.GroupId) + " => " + newName + " " + newSurname + "/" + Enum.GetName(typeof(Groups), newGroup), DBOperation.Update);
      return true;
    }

    public void DeleteKid(int kidId)
    {
      var kid = GetKidById(kidId);

      using (SQLiteCommand command = new SQLiteCommand("DELETE FROM KIDS WHERE ID = @KidId;", SQLiteConnection))
      {
        command.Parameters.AddWithValue("@KidId", kidId);
        command.ExecuteNonQuery();
      }
      WriteHistory(TableName.Kids, kid.Name + " " + kid.Surname, DBOperation.Delete);
    }

    public List<Kid> GetAllKids()
    {
      List<Kid> kids = new List<Kid>();

      using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM KIDS ORDER BY GroupId, Name;", SQLiteConnection))
      {
        using (SQLiteDataReader reader = command.ExecuteReader())
        {
          while (reader.Read())
          {
            Kid kid = new Kid
            {
              ID = Convert.ToInt32(reader["ID"]),
              Name = reader["Name"].ToString(),
              Surname = reader["Surname"].ToString(),
              GroupId = (Groups)Convert.ToInt32(reader["GroupId"])
            };
            kids.Add(kid);
          }
        }
      }

      return kids;
    }

    public List<Kid> GetKidsByGroup(Groups group)
    {
      List<Kid> kids = new List<Kid>();

      using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM KIDS WHERE GroupId = @GroupId ORDER BY Name;", SQLiteConnection))
      {
        command.Parameters.AddWithValue("@GroupId", (int)group);

        using (SQLiteDataReader reader = command.ExecuteReader())
        {
          while (reader.Read())
          {
            Kid kid = new Kid
            {
              ID = Convert.ToInt32(reader["ID"]),
              Name = reader["Name"].ToString(),
              Surname = reader["Surname"].ToString(),
              GroupId = (Groups)Convert.ToInt32(reader["GroupId"])
            };
            kids.Add(kid);
          }
        }
      }

      return kids;
    }

    public Kid GetKidById(int kidId)
    {
      Kid kid = null;

      using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM KIDS WHERE ID = @KidId;", SQLiteConnection))
      {
        command.Parameters.AddWithValue("@KidId", kidId);

        using (SQLiteDataReader reader = command.ExecuteReader())
        {
          if (reader.Read())
          {
            kid = new Kid
            {
              ID = Convert.ToInt32(reader["ID"]),
              Name = reader["Name"].ToString(),
              Surname = reader["Surname"].ToString(),
              GroupId = (Groups)Convert.ToInt32(reader["GroupId"])
            };
          }
        }
      }

      return kid;
    }

    public int GetCount(string table, string condition = "")
    {
      int count = 0;
      using (SQLiteCommand command = new SQLiteCommand("SELECT COUNT(*) FROM " + table + " " + condition + ";", SQLiteConnection))
      {
        using (SQLiteDataReader reader = command.ExecuteReader())
        {
          if (reader.Read())
          {
            count = Convert.ToInt32(reader["COUNT(*)"]);
          }
        }
      }
      return count;
    }

    public int GetKidsCount(Groups? group)
    {
      return GetCount("KIDS", group == null ? "" : "WHERE GroupId = " + (int)group.Value);
    }

    public int GetBooksCount()
    {
      return GetCount("BOOKS");
    }

    public int GetRentalCount()
    {
      return GetCount("RENTAL");
    }

    public void StartInventory()
    {
      using (SQLiteCommand command = new SQLiteCommand("UPDATE BOOKS SET InventoryStatus = 0;", SQLiteConnection))
      {
        command.ExecuteNonQuery();
      }
    }

    public void SetInventoryStatus(int bookId)
    {
      DeleteRentalByBook(bookId);

      using (SQLiteCommand command = new SQLiteCommand("UPDATE BOOKS SET InventoryStatus = 1 WHERE ID = @Id;", SQLiteConnection))
      {
        command.Parameters.AddWithValue("@Id", bookId);
        command.ExecuteNonQuery();
      }
    }

    public List<Book> GetInventoryMissingBooks()
    {
      List<Book> books = new List<Book>();

      using (SQLiteCommand command = new SQLiteCommand("SELECT BOOKS.ID, BOOKS.ExternalID, BOOKS.Name, BOOKS.Barcode, RENTAL.ID AS RentalId " +
          "FROM BOOKS " +
          "LEFT JOIN RENTAL ON BOOKS.ID = RENTAL.BookId;", SQLiteConnection))
      {
        using (SQLiteDataReader reader = command.ExecuteReader())
        {
          while (reader.Read())
          {
            Book book = new Book
            {
              ID = Convert.ToInt32(reader["ID"]),
              ExternalID = Utils.ObjToNullableInt(reader["ExternalId"]),
              Name = reader["Name"].ToString(),
              Barcode = reader["Barcode"].ToString(),
              RentalId = Utils.ObjToNullableInt(reader["RentalId"])
            };
            books.Add(book);
          }
        }
      }

      var rentals = GetAllRentals();

      foreach (var rental in rentals)
        books.RemoveAll(book => book.ID == rental.Book.ID);

      return books;
    }

    public Book CreateBook(int? externalId, string name, string barcode)
    {
      if ((!externalId.HasValue || GetBookByExternalId(externalId.Value) == null) && GetBookByBarcode(barcode) == null)
      {
        using (SQLiteCommand command = new SQLiteCommand("INSERT INTO BOOKS (ExternalID, Name, Barcode, InventoryStatus) VALUES (@ExternalId, @Name, @Barcode, 1);", SQLiteConnection))
        {
          command.Parameters.AddWithValue("@ExternalId", externalId);
          command.Parameters.AddWithValue("@Name", name);
          command.Parameters.AddWithValue("@Barcode", barcode);
          command.ExecuteNonQuery();
        }

        var book = new Book
        {
          ID = (int)SQLiteConnection.LastInsertRowId,
          ExternalID = externalId,
          Name = name,
          Barcode = barcode
        };

        WriteHistory(TableName.Books, name + "/" + barcode, DBOperation.Insert);

        return book;
      }
      else
      {
        Dialog.Show("Fehler!", "Ein Buch mit dieser ID / diesem Barcode existiert bereits");
        return null;
      }
    }

    public bool UpdateBook(int bookId, int externalId, string newName, string newBarcode)
    {
      var book = GetBookById(bookId);

      // not found or no update => abort
      if (book == null || (book.ExternalID.Equals(externalId) && book.Name.Equals(newName) && book.Barcode.Equals(newBarcode)))
        return false;

      using (SQLiteCommand command = new SQLiteCommand("UPDATE BOOKS SET ExternalId = @ExternalId, Name = @NewName, Barcode = @NewBarcode WHERE ID = @BookId;", SQLiteConnection))
      {
        command.Parameters.AddWithValue("@BookId", bookId);
        command.Parameters.AddWithValue("@ExternalId", externalId);
        command.Parameters.AddWithValue("@NewName", newName);
        command.Parameters.AddWithValue("@NewBarcode", newBarcode);
        command.ExecuteNonQuery();
      }
      WriteHistory(TableName.Books, book.ExternalID + "/" + book.Name + "/" + book.Barcode + " => " + book.ExternalID + "/" + newName + "/" + newBarcode, DBOperation.Update);

      return true;
    }

    public void DeleteBook(int bookId)
    {
      var book = GetBookById(bookId);

      using (SQLiteCommand command = new SQLiteCommand("DELETE FROM BOOKS WHERE ID = @BookId;", SQLiteConnection))
      {
        command.Parameters.AddWithValue("@BookId", bookId);
        command.ExecuteNonQuery();
      }
      WriteHistory(TableName.Books, book.Name, DBOperation.Delete);
    }

    public List<Book> GetAllBooks()
    {
      List<Book> books = new List<Book>();

      using (SQLiteCommand command = new SQLiteCommand("SELECT BOOKS.ID, BOOKS.ExternalID, BOOKS.Name, BOOKS.Barcode, BOOKS.InventoryStatus, RENTAL.ID AS RentalId " +
          "FROM BOOKS " +
          "LEFT JOIN RENTAL ON BOOKS.ID = RENTAL.BookId;", SQLiteConnection))
      {
        using (SQLiteDataReader reader = command.ExecuteReader())
        {
          while (reader.Read())
          {
            Book book = new Book
            {
              ID = Convert.ToInt32(reader["ID"]),
              ExternalID = Utils.ObjToNullableInt(reader["ExternalId"]),
              Name = reader["Name"].ToString(),
              Barcode = reader["Barcode"].ToString(),
              InventoryStatus = Convert.ToInt32(reader["InventoryStatus"]),
              RentalId = Utils.ObjToNullableInt(reader["RentalId"])
            };
            books.Add(book);
          }
        }
      }

      return books;
    }

    private Book GetBookByParam<T>(string paramName, T paramValue)
    {
      Book book = null;

      try
      {
        using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM BOOKS WHERE " + paramName + " = @Param;", SQLiteConnection))
        {
          SQLiteParameter parameter = new SQLiteParameter("@Param");

          // Set parameter value based on its type
          if (typeof(T) == typeof(int))
          {
            parameter.Value = Convert.ToInt32(paramValue);
          }
          else if (typeof(T) == typeof(string))
          {
            parameter.Value = paramValue.ToString();
          }
          else
          {
            // Handle unsupported types
            throw new ArgumentException("Unsupported parameter type");
          }

          command.Parameters.Add(parameter);

          using (SQLiteDataReader reader = command.ExecuteReader())
          {
            if (reader.Read())
            {
              book = new Book
              {
                ID = Convert.ToInt32(reader["ID"]),
                ExternalID = Convert.ToInt32(reader["ExternalID"]),
                Name = reader["Name"].ToString(),
                Barcode = reader["Barcode"].ToString(),
                InventoryStatus = Convert.ToInt32(reader["InventoryStatus"])
              };
            }
          }
        }
      }
      catch (Exception ex)
      {
        // Handle exceptions
        Console.WriteLine("An error occurred: " + ex.Message);
      }

      return book;
    }

    public Book GetBookById(int bookId)
    {
      return GetBookByParam("ID", bookId);
    }

    public Book GetBookByExternalId(int externalId)
    {
      return GetBookByParam("ExternalID", externalId);
    }

    public Book GetBookByBarcode(string barcode)
    {
      return GetBookByParam("Barcode", barcode);
    }

    public Rental CreateRental(int kidId, int bookId)
    {
      // Cancel other reservations for this book, if existing
      DeleteRentalByBook(bookId);

      Rental rental = null;
      var now = DateTime.Now;

      using (SQLiteCommand command = new SQLiteCommand("INSERT INTO RENTAL (KidId, BookId, RentalDate) VALUES (@KidId, @BookId, @RentalDate);", SQLiteConnection))
      {

        command.Parameters.AddWithValue("@KidId", kidId);
        command.Parameters.AddWithValue("@BookId", bookId);
        command.Parameters.AddWithValue("@RentalDate", now);
        command.ExecuteNonQuery();
        rental = new Rental((int)command.Connection.LastInsertRowId, kidId, bookId, now);
      }
      WriteHistory(TableName.Rental, rental.Kid.Name + " " + rental.Kid.Surname + " <=> " + rental.Book.Name + " (" + now.ToString() + ")", DBOperation.Insert);

      return rental;
    }

    public bool UpdateRental(Rental rental)
    {
      var log = rental.Kid.Name + " " + rental.Kid.Surname + " <=> " + rental.Book.Name;

      var oldRental = GetRentalById(rental.ID);

      // not found or no update => abort
      if (oldRental == null || (oldRental.KidId.Equals(rental.KidId) && oldRental.BookId.Equals(rental.BookId)))
        return false;

      using (SQLiteCommand command = new SQLiteCommand("UPDATE RENTAL SET KidId = @NewKidId, BookId = @NewBookId, RentalDate = @NewRentalDate WHERE ID = @RentalId;", SQLiteConnection))
      {
        command.Parameters.AddWithValue("@RentalId", rental.ID);
        command.Parameters.AddWithValue("@NewKidId", rental.KidId);
        command.Parameters.AddWithValue("@NewBookId", rental.BookId);
        command.Parameters.AddWithValue("@NewRentalDate", rental.BookId);
        command.ExecuteNonQuery();
      }
      WriteHistory(TableName.Rental, log, DBOperation.Update);

      return true;
    }

    public void DeleteRental(int rentalId)
    {
      var rental = GetRentalById(rentalId);
      var log = "Rückgabe: " + rental.Book.Name + " von " + rental.Kid.Name + " " + rental.Kid.Surname;

      using (SQLiteCommand command = new SQLiteCommand("DELETE FROM RENTAL WHERE ID = @RentalId;", SQLiteConnection))
      {
        command.Parameters.AddWithValue("@RentalId", rentalId);
        command.ExecuteNonQuery();
      }
      WriteHistory(TableName.Rental, log, DBOperation.Delete);
    }

    public bool DeleteRentalByBook(int bookId)
    {
      var rental = GetRentalByBookId(bookId);
      string log = string.Empty;
      if (rental != null)
        log = "Rückgabe: " + rental.Book.Name + " von " + rental.Kid.Name + " " + rental.Kid.Surname;

      using (SQLiteCommand command = new SQLiteCommand("DELETE FROM RENTAL WHERE BookId = @BookId;", SQLiteConnection))
      {
        command.Parameters.AddWithValue("@BookId", bookId);
        command.ExecuteNonQuery();
      }
      if (rental != null)
        WriteHistory(TableName.Rental, log, DBOperation.Delete);

      return rental != null;
    }

    public List<Rental> GetAllRentals()
    {
      List<Rental> rentals = new List<Rental>();

      using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM RENTAL ORDER BY KidId;", SQLiteConnection))
      {
        using (SQLiteDataReader reader = command.ExecuteReader())
        {
          while (reader.Read())
          {
            Rental rental = new Rental
            {
              ID = Convert.ToInt32(reader["ID"]),
              KidId = Convert.ToInt32(reader["KidId"]),
              BookId = Convert.ToInt32(reader["BookId"]),
              RentalDate = (DateTime)reader["RentalDate"]
            };
            rentals.Add(rental);
          }
        }
      }

      return rentals;
    }

    public List<Rental> GetRentalsByKid(int kidId) 
    {
      List<Rental> rentals = new List<Rental>();

      using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM RENTAL WHERE KidId = @KidId;", SQLiteConnection))
      {
        command.Parameters.AddWithValue("@KidId", kidId);

        using (SQLiteDataReader reader = command.ExecuteReader())
        {
          while (reader.Read())
          {
            Rental rental = new Rental
            {
              ID = Convert.ToInt32(reader["ID"]),
              KidId = Convert.ToInt32(reader["KidId"]),
              BookId = Convert.ToInt32(reader["BookId"]),
              RentalDate = (DateTime)reader["RentalDate"]
            };
            rentals.Add(rental);
          }
        }
      }

      return rentals;
    }

    private Rental GetRentalByParam(string param, int value) 
    {
      Rental rental = null;

      using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM RENTAL WHERE " + param + " = @Param;", SQLiteConnection))
      {
        command.Parameters.AddWithValue("@Param", value);

        using (SQLiteDataReader reader = command.ExecuteReader())
        {
          if (reader.Read())
          {
            rental = new Rental
            {
              ID = Convert.ToInt32(reader["ID"]),
              KidId = Convert.ToInt32(reader["KidId"]),
              BookId = Convert.ToInt32(reader["BookId"]),
              RentalDate = (DateTime)reader["RentalDate"]
            };
          }
        }
      }

      return rental;
    }

    public Rental GetRentalById(int ID)
    {
      return GetRentalByParam("ID", ID);
    }

    internal Rental GetRentalByBookId(int bookId)
    {
      return GetRentalByParam("BookId", bookId);
    }

    public void CreateGroup(Groups group)
    {
      using (SQLiteCommand command = new SQLiteCommand("INSERT INTO GROUPS (ID, Name) VALUES (@ID, @Name);", SQLiteConnection))
      {
        command.Parameters.AddWithValue("@ID", (int)group);
        command.Parameters.AddWithValue("@Name", Enum.GetName(typeof(Groups), group));
        command.ExecuteNonQuery();
      }
    }

    public void CreateBackup(string backupPath)
    {
      if (Directory.CreateDirectory(Path.GetDirectoryName(backupPath)).Exists)
      {
        using (var destination = new SQLiteConnection(string.Format(@"Data Source={0}; Version=3;", backupPath)))
        {
          destination.Open();
          SQLiteConnection.BackupDatabase(destination, "main", "main", -1, null, 0);
        }
      }
      else
        Dialog.Show("Achtung!", "Backup-Pfad konnte nicht gefunden werden: " + Environment.NewLine + backupPath);
    }

    internal void RestoreBackup(string backupPath)
    {
      SQLiteConnection.Close();
      File.Copy(backupPath, DatabaseName, true);
      SQLiteConnection.Open();
    }

    private string GetTableNameStr(TableName table)
    {
      switch (table)
      {
        case TableName.Rental:
          return "Verleih";
        case TableName.Ranks:
          return "Rang";
        case TableName.Groups:
          return "Gruppe";
        case TableName.Books:
          return "Buch";
        case TableName.Kids:
          return "Kind";
        case TableName.SysInfo:
          return "System";
        case TableName.History:
          return "Historie";
        default:
          return "-";
      }
    }

    private void WriteHistory(TableName table, string value, DBOperation operation)
    {
      using (SQLiteCommand command = new SQLiteCommand("INSERT INTO HISTORY (TableName, Value, Operation, OperationTimestamp) VALUES (@TableName, @Value, @Operation, @OperationTimestamp);", SQLiteConnection))
      {
        command.Parameters.AddWithValue("@TableName", GetTableNameStr(table));
        command.Parameters.AddWithValue("@Value", value);
        command.Parameters.AddWithValue("@Operation", (int)operation);
        command.Parameters.AddWithValue("@OperationTimestamp", DateTime.Now);
        command.ExecuteNonQuery();
      }
    }

    public List<History> GetHistory(int pageSize, int offset)
    {
      List<History> rentals = new List<History>();

      using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM HISTORY ORDER BY OperationTimestamp DESC LIMIT @PageSize OFFSET @Offset;", SQLiteConnection))
      {
        command.Parameters.AddWithValue("@PageSize", pageSize);
        command.Parameters.AddWithValue("@Offset", offset);

        using (SQLiteDataReader reader = command.ExecuteReader())
        {
          while (reader.Read())
          {
            History rental = new History
            {
              ID = Convert.ToInt32(reader["ID"]),
              Operation = (DBOperation)Convert.ToInt32(reader["Operation"]),
              TableName = reader["TableName"].ToString(),
              Value = reader["Value"].ToString(),
              TimeStamp = (DateTime)reader["OperationTimestamp"]
            };
            rentals.Add(rental);
          }
        }
      }

      return rentals;
    }
  }
}
