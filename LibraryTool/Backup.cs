using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTool
{
  internal class Backup
  {
    private static Backup instance;
    public bool Active { get { return active; } set { active = value; } }

    private bool active = false;
    private string BackupPath;

    public Backup() 
    {
      Active = false;
      BackupPath = string.Empty;
    }

    public static Backup Instance
    {
      get
      {
        if (instance == null)
          instance = new Backup();

        return instance;
      }
    }

    public DateTime? GetLastBackupDate()
    {
      if (File.Exists(BackupPath)) 
      { 
        return File.GetLastWriteTime(BackupPath);
      }
      else
      {
        return null;
      }
    }

    public void SetBackupPath(string path)
    {
      BackupPath = path;
    }

    public void CreateBackup()
    {
      if (Active && !BackupPath.Equals(string.Empty))
        Persistence.Instance.CreateBackup(BackupPath);
    }

    public void RestoreBackup()
    {
      if (Active && !BackupPath.Equals(string.Empty))
        Persistence.Instance.RestoreBackup(BackupPath);
    }
  }
}
