namespace LibraryTool
{
  partial class Dialog
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
      this.pnl_Dialog = new System.Windows.Forms.Panel();
      this.btn_ConfirmOK = new ReaLTaiizor.Controls.ForeverButton();
      this.btn_ConfirmCancel = new ReaLTaiizor.Controls.ForeverButton();
      this.lbl_Text = new System.Windows.Forms.Label();
      this.btn_Ok = new ReaLTaiizor.Controls.ForeverButton();
      this.pnl_Header = new System.Windows.Forms.Panel();
      this.lbl_Caption = new System.Windows.Forms.Label();
      this.pnl_Dialog.SuspendLayout();
      this.pnl_Header.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnl_Dialog
      // 
      this.pnl_Dialog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
      this.pnl_Dialog.Controls.Add(this.btn_Ok);
      this.pnl_Dialog.Controls.Add(this.btn_ConfirmOK);
      this.pnl_Dialog.Controls.Add(this.btn_ConfirmCancel);
      this.pnl_Dialog.Controls.Add(this.lbl_Text);
      this.pnl_Dialog.Controls.Add(this.pnl_Header);
      this.pnl_Dialog.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnl_Dialog.Location = new System.Drawing.Point(0, 0);
      this.pnl_Dialog.Name = "pnl_Dialog";
      this.pnl_Dialog.Size = new System.Drawing.Size(298, 128);
      this.pnl_Dialog.TabIndex = 0;
      // 
      // btn_ConfirmOK
      // 
      this.btn_ConfirmOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btn_ConfirmOK.BackColor = System.Drawing.Color.Transparent;
      this.btn_ConfirmOK.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      this.btn_ConfirmOK.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn_ConfirmOK.Font = new System.Drawing.Font("Segoe UI", 11F);
      this.btn_ConfirmOK.Location = new System.Drawing.Point(80, 87);
      this.btn_ConfirmOK.Name = "btn_ConfirmOK";
      this.btn_ConfirmOK.Rounded = false;
      this.btn_ConfirmOK.Size = new System.Drawing.Size(100, 29);
      this.btn_ConfirmOK.TabIndex = 4;
      this.btn_ConfirmOK.Text = "Ok";
      this.btn_ConfirmOK.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      this.btn_ConfirmOK.Click += new System.EventHandler(this.btn_OkClick);
      // 
      // btn_ConfirmCancel
      // 
      this.btn_ConfirmCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btn_ConfirmCancel.BackColor = System.Drawing.Color.Transparent;
      this.btn_ConfirmCancel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      this.btn_ConfirmCancel.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn_ConfirmCancel.Font = new System.Drawing.Font("Segoe UI", 11F);
      this.btn_ConfirmCancel.Location = new System.Drawing.Point(186, 87);
      this.btn_ConfirmCancel.Name = "btn_ConfirmCancel";
      this.btn_ConfirmCancel.Rounded = false;
      this.btn_ConfirmCancel.Size = new System.Drawing.Size(100, 29);
      this.btn_ConfirmCancel.TabIndex = 3;
      this.btn_ConfirmCancel.Text = "Abbrechen";
      this.btn_ConfirmCancel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      this.btn_ConfirmCancel.Click += new System.EventHandler(this.btn_ConfirmCancel_Click);
      // 
      // lbl_Text
      // 
      this.lbl_Text.AutoSize = true;
      this.lbl_Text.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      this.lbl_Text.Location = new System.Drawing.Point(12, 35);
      this.lbl_Text.Name = "lbl_Text";
      this.lbl_Text.Size = new System.Drawing.Size(602, 60);
      this.lbl_Text.TabIndex = 2;
      this.lbl_Text.Text = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod t" +
    "empor\r\nTestqwe\r\nqweqwe";
      this.lbl_Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // btn_Ok
      // 
      this.btn_Ok.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
      this.btn_Ok.BackColor = System.Drawing.Color.Transparent;
      this.btn_Ok.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      this.btn_Ok.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn_Ok.Font = new System.Drawing.Font("Segoe UI", 11F);
      this.btn_Ok.Location = new System.Drawing.Point(100, 87);
      this.btn_Ok.Name = "btn_Ok";
      this.btn_Ok.Rounded = false;
      this.btn_Ok.Size = new System.Drawing.Size(100, 29);
      this.btn_Ok.TabIndex = 1;
      this.btn_Ok.Text = "Ok";
      this.btn_Ok.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      this.btn_Ok.Click += new System.EventHandler(this.btn_OkClick);
      // 
      // pnl_Header
      // 
      this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
      this.pnl_Header.Controls.Add(this.lbl_Caption);
      this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnl_Header.Location = new System.Drawing.Point(0, 0);
      this.pnl_Header.Name = "pnl_Header";
      this.pnl_Header.Size = new System.Drawing.Size(298, 32);
      this.pnl_Header.TabIndex = 0;
      // 
      // lbl_Caption
      // 
      this.lbl_Caption.Dock = System.Windows.Forms.DockStyle.Left;
      this.lbl_Caption.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_Caption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
      this.lbl_Caption.Location = new System.Drawing.Point(0, 0);
      this.lbl_Caption.Name = "lbl_Caption";
      this.lbl_Caption.Size = new System.Drawing.Size(250, 32);
      this.lbl_Caption.TabIndex = 3;
      this.lbl_Caption.Text = "Caption";
      this.lbl_Caption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // Dialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(298, 128);
      this.Controls.Add(this.pnl_Dialog);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.KeyPreview = true;
      this.MinimumSize = new System.Drawing.Size(298, 128);
      this.Name = "Dialog";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Dialog";
      this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dialog_KeyPress);
      this.pnl_Dialog.ResumeLayout(false);
      this.pnl_Dialog.PerformLayout();
      this.pnl_Header.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel pnl_Dialog;
    private System.Windows.Forms.Panel pnl_Header;
    private System.Windows.Forms.Label lbl_Text;
    private ReaLTaiizor.Controls.ForeverButton btn_Ok;
    private System.Windows.Forms.Label lbl_Caption;
    private ReaLTaiizor.Controls.ForeverButton btn_ConfirmCancel;
    private ReaLTaiizor.Controls.ForeverButton btn_ConfirmOK;
  }
}