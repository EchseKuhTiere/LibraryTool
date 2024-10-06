using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryTool
{
  public partial class Toast : Form
  {
    public Toast()
    {
      InitializeComponent();
    }

    public Image ToastIcon { set { img_ToastIcon.Image = value; } }
    public string ToastMessage { set { text_ToastMessage.Text = Utils.Compact(value, text_ToastMessage, Utils.EllipsisFormat.End); } }
    public string ToastHeader { set { lbl_ToastHeader.Text = value; } }

    public void ShowToast(Form parent, int index)
    {
      Location = new Point(parent.Location.X + parent.Width - Width - 8, parent.Location.Y + parent.Height - index * Height - 8);

      Show();
    }

    private void Toast_Shown(object sender, EventArgs e)
    {
      timer_Toast.Enabled = true;
    }

    private void timer_Toast_Tick(object sender, EventArgs e)
    {
      Close();
    }
  }
}
