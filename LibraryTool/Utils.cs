using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryTool
{
  public static class Utils
  {
    public static int? ObjToNullableInt(object value)
    {
      if (value == DBNull.Value)
        return null;

      return Convert.ToInt32(value);
    }

    [DllImport("user32.dll", EntryPoint = "SendMessageA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
    private static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
    private const int WM_SETREDRAW = 0xB;

    public static void BeginUpdate(this Control target)
    {
      SendMessage(target.Handle, WM_SETREDRAW, 0, 0);
    }

    public static void EndUpdate(this Control target) { EndUpdate(target, true); }
    public static void EndUpdate(this Control target, bool redraw)
    {
      SendMessage(target.Handle, WM_SETREDRAW, 1, 0);

      if (redraw)
      {
        target.Refresh();
      }
    }

    [Flags]
    public enum EllipsisFormat
    {
      // Text is not modified.
      None = 0,
      // Text is trimmed at the end of the string. An ellipsis (...) 
      // is drawn in place of remaining text.
      End = 1,
      // Text is trimmed at the beginning of the string. 
      // An ellipsis (...) is drawn in place of remaining text. 
      Start = 2,
      // Text is trimmed in the middle of the string. 
      // An ellipsis (...) is drawn in place of remaining text.
      Middle = 3,
      // Preserve as much as possible of the drive and filename information. 
      // Must be combined with alignment information.
      Path = 4,
      // Text is trimmed at a word boundary. 
      // Must be combined with alignment information.
      Word = 8
    }

    public static readonly string EllipsisChars = "...";

    public static string Compact(string text, Control ctrl, EllipsisFormat options)
    {
      using (Graphics dc = ctrl.CreateGraphics())
      {
        Size s = TextRenderer.MeasureText(dc, text, ctrl.Font);

        // control is large enough to display the whole text 
        if (s.Width <= ctrl.Width)
          return text;

        int len = 0;
        int seg = text.Length;
        string fit = "";

        // find the longest string that fits into
        // the control boundaries using bisection method 
        while (seg > 1)
        {
          seg -= seg / 2;

          int left = len + seg;
          int right = text.Length;

          if (left > right)
            continue;

          if ((EllipsisFormat.Middle & options) ==
                EllipsisFormat.Middle)
          {
            right -= left / 2;
            left -= left / 2;
          }
          else if ((EllipsisFormat.Start & options) != 0)
          {
            right -= left;
            left = 0;
          }

          // build and measure a candidate string with ellipsis
          string tst = text.Substring(0, left) +
            EllipsisChars + text.Substring(right);

          s = TextRenderer.MeasureText(dc, tst, ctrl.Font);

          // candidate string fits into control boundaries, 
          // try a longer string
          // stop when seg <= 1 
          if (s.Width <= ctrl.Width)
          {
            len += seg;
            fit = tst;
          }
        }

        if (len == 0) // string can't fit into control
        {
          return EllipsisChars;
        }
        return fit;
      }
    }
  }
}
