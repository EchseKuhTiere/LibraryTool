using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTool
{
  public enum Groups
  {
    Waschbären = 1,
    Igel = 2,
    Mäuse = 3,
  }

  public class SysInfo
  {
    public string Version;
    public string Info;
    public bool BackupActive;
    public string BackupPath;
    public int ScanSensitivity;
  }

  public class Kid
  {
    public int ID;
    public string Name;
    public string Surname;
    public Groups GroupId;
  }

  public class Book
  {
    public int ID;
    public int? ExternalID;
    public string Name;
    public string Barcode;
    public int InventoryStatus;

    public int? RentalId; // no DB field, just fetched from RENTAL for conveinience
  }

  public class Rental
  {
    public int ID;
    public int KidId;
    public int BookId;
    public DateTime RentalDate;

    private Kid kid;
    private Book book;

    public Rental()
    {

    }

    public Rental(int id, int kidId, int bookId, DateTime rentalDate)
    {
      ID = id;
      KidId = kidId;
      BookId = bookId;
      RentalDate = rentalDate;
    }

    public Kid Kid 
    {
      get 
      { 
        if (kid == null)
          kid = Persistence.Instance.GetKidById(KidId); 

        return kid;
      } 
    }

    public Book Book 
    { 
      get 
      { 
        if(book == null)
          book = Persistence.Instance.GetBookById(BookId);

        return book;
      } 
    }
  }

  public class History
  {
    public int ID;
    public DBOperation Operation;
    public string TableName;
    public string Value;
    public DateTime TimeStamp;

    public string GetOperationName()
    {
      switch (Operation)
      {
        case DBOperation.Insert:
          return "Erstellt";
        case DBOperation.Update:
          return "Aktualisiert";
        case DBOperation.Delete:
          return "Gelöscht";
        default:
          return "";
      }
    }
  }
}
