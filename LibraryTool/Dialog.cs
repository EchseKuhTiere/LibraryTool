using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace LibraryTool
{
  enum DialogType
  {
    Info,
    Confirm
  }

  public partial class Dialog : Form
  {
    public Dialog()
    {
      InitializeComponent();
    }

    private void SetButtons(DialogType type, string okText, string cancelText)
    {
      btn_ConfirmCancel.Visible = type.Equals(DialogType.Confirm);
      btn_ConfirmOK.Visible = type.Equals(DialogType.Confirm);
      btn_Ok.Visible = type.Equals(DialogType.Info);

      btn_Ok.Text = okText;
      btn_ConfirmOK.Text = okText;
      btn_ConfirmCancel.Text = cancelText;
    }

    private static DialogResult CreateBase(string caption, string text, DialogType type, string okText = "Ok", string cancelText = "Abbrechen")
    {
      var dialog = new Dialog();
      dialog.SetButtons(type, okText, cancelText);

      dialog.lbl_Caption.Text = caption;
      dialog.lbl_Text.Text = text;

      dialog.Width = dialog.lbl_Text.Width + 32;
      dialog.Height = dialog.lbl_Text.Height + 96;

      return dialog.ShowDialog();
    }

    public static void Show(string caption, string text)
    {
      CreateBase(caption, text, DialogType.Info);
    }

    public static DialogResult Confirm(string caption, string text, string okText = "Ok", string cancelText = "Abbrechen")
    {
      return CreateBase(caption, text, DialogType.Confirm, okText, cancelText);
    }

    private void btn_OkClick(object sender, EventArgs e)
    {
      DialogResult = DialogResult.OK;
      Close();
    }

    private void btn_ConfirmCancel_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.Cancel;
      Close();
    }

    private void Dialog_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar.Equals((char)Keys.Enter))
      {
        DialogResult = DialogResult.OK;
        Close();
      }
      else if (e.KeyChar.Equals((char)Keys.Escape))
      {
        DialogResult = DialogResult.Cancel;
        Close();
      }
    }
  }
}
