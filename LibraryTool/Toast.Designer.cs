namespace LibraryTool
{
  partial class Toast
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
      this.pnl_ToastHeader = new System.Windows.Forms.Panel();
      this.lbl_ToastHeader = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.img_ToastIcon = new System.Windows.Forms.PictureBox();
      this.text_ToastMessage = new System.Windows.Forms.TextBox();
      this.timer_Toast = new System.Windows.Forms.Timer(this.components);
      this.pnl_ToastHeader.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.img_ToastIcon)).BeginInit();
      this.SuspendLayout();
      // 
      // pnl_ToastHeader
      // 
      this.pnl_ToastHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      this.pnl_ToastHeader.Controls.Add(this.lbl_ToastHeader);
      this.pnl_ToastHeader.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnl_ToastHeader.Location = new System.Drawing.Point(0, 0);
      this.pnl_ToastHeader.Name = "pnl_ToastHeader";
      this.pnl_ToastHeader.Size = new System.Drawing.Size(308, 32);
      this.pnl_ToastHeader.TabIndex = 0;
      // 
      // lbl_ToastHeader
      // 
      this.lbl_ToastHeader.AutoSize = true;
      this.lbl_ToastHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_ToastHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      this.lbl_ToastHeader.Location = new System.Drawing.Point(4, 6);
      this.lbl_ToastHeader.Name = "lbl_ToastHeader";
      this.lbl_ToastHeader.Size = new System.Drawing.Size(97, 20);
      this.lbl_ToastHeader.TabIndex = 0;
      this.lbl_ToastHeader.Text = "Toast Header";
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
      this.panel1.Controls.Add(this.img_ToastIcon);
      this.panel1.Controls.Add(this.text_ToastMessage);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(0, 32);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(308, 54);
      this.panel1.TabIndex = 1;
      // 
      // img_ToastIcon
      // 
      this.img_ToastIcon.Location = new System.Drawing.Point(11, 10);
      this.img_ToastIcon.Name = "img_ToastIcon";
      this.img_ToastIcon.Size = new System.Drawing.Size(32, 32);
      this.img_ToastIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.img_ToastIcon.TabIndex = 1;
      this.img_ToastIcon.TabStop = false;
      // 
      // text_ToastMessage
      // 
      this.text_ToastMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.text_ToastMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
      this.text_ToastMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.text_ToastMessage.Cursor = System.Windows.Forms.Cursors.Default;
      this.text_ToastMessage.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.text_ToastMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      this.text_ToastMessage.Location = new System.Drawing.Point(55, 6);
      this.text_ToastMessage.Multiline = true;
      this.text_ToastMessage.Name = "text_ToastMessage";
      this.text_ToastMessage.Size = new System.Drawing.Size(241, 43);
      this.text_ToastMessage.TabIndex = 0;
      this.text_ToastMessage.TabStop = false;
      this.text_ToastMessage.Text = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod t" +
    "empor invidunt";
      // 
      // timer_Toast
      // 
      this.timer_Toast.Interval = 5000;
      this.timer_Toast.Tick += new System.EventHandler(this.timer_Toast_Tick);
      // 
      // Toast
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(308, 86);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.pnl_ToastHeader);
      this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "Toast";
      this.Opacity = 0.97D;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
      this.Text = "Toast";
      this.TopMost = true;
      this.Shown += new System.EventHandler(this.Toast_Shown);
      this.pnl_ToastHeader.ResumeLayout(false);
      this.pnl_ToastHeader.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.img_ToastIcon)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel pnl_ToastHeader;
    private System.Windows.Forms.Label lbl_ToastHeader;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.PictureBox img_ToastIcon;
    private System.Windows.Forms.TextBox text_ToastMessage;
    private System.Windows.Forms.Timer timer_Toast;
  }
}