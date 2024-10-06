using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryTool
{
  internal class ToastManager
  {
    private static ToastManager instance;

    List<Toast> Toasts = new List<Toast>();

    public static ToastManager Instance
    {
      get
      {
        if (instance == null)
          instance = new ToastManager();

        return instance;
      }
    }

    public static void Toast(Form parent, string title, string message, Image icon)
    {
      var toast = new Toast();
      toast.ToastHeader = title;
      toast.ToastMessage = message;
      toast.ToastIcon = icon;
      toast.FormClosed += Instance.RearrangeToasts;

      Instance.Toasts.Add(toast);

      toast.ShowToast(parent, Instance.Toasts.Count);

      parent.Focus();
    }

    private void RearrangeToasts(object sender, FormClosedEventArgs e)
    {
      Toasts.Remove((Toast) sender);
      foreach(var toast in Toasts) 
      { 
        toast.Location = new Point(toast.Location.X, toast.Location.Y + toast.Height);
      }
    }
  }
}
