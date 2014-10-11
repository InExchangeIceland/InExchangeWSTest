namespace FROMInExchange
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose( bool disposing )
    {
      if ( disposing && ( components != null ) )
      {
        components.Dispose ();
      }
      base.Dispose ( disposing );
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.textBoxUsername = new System.Windows.Forms.TextBox();
      this.textBoxPassword = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.radioButtonPing = new System.Windows.Forms.RadioButton();
      this.buttonExecute = new System.Windows.Forms.Button();
      this.textBoxResult = new System.Windows.Forms.TextBox();
      this.radioButtonGetTransactionList = new System.Windows.Forms.RadioButton();
      this.textBoxReceiverPartyIdentifier = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.radioButtonGetTransaction = new System.Windows.Forms.RadioButton();
      this.textBoxTransactionUUID = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.radioButtonUpdateTransactionStatus = new System.Windows.Forms.RadioButton();
      this.comboBoxNewStatus = new System.Windows.Forms.ComboBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(678, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "&File";
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
      this.exitToolStripMenuItem.Text = "Exit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.helpToolStripMenuItem.Text = "&Help";
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
      this.aboutToolStripMenuItem.Text = "&About...";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
      // 
      // textBoxUsername
      // 
      this.textBoxUsername.Location = new System.Drawing.Point(128, 27);
      this.textBoxUsername.Name = "textBoxUsername";
      this.textBoxUsername.Size = new System.Drawing.Size(223, 20);
      this.textBoxUsername.TabIndex = 2;
      // 
      // textBoxPassword
      // 
      this.textBoxPassword.Location = new System.Drawing.Point(128, 54);
      this.textBoxPassword.Name = "textBoxPassword";
      this.textBoxPassword.Size = new System.Drawing.Size(223, 20);
      this.textBoxPassword.TabIndex = 4;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(71, 30);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(55, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "&Username";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(73, 57);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(53, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "&Password";
      // 
      // radioButtonPing
      // 
      this.radioButtonPing.AutoSize = true;
      this.radioButtonPing.Checked = true;
      this.radioButtonPing.Location = new System.Drawing.Point(478, 30);
      this.radioButtonPing.Name = "radioButtonPing";
      this.radioButtonPing.Size = new System.Drawing.Size(46, 17);
      this.radioButtonPing.TabIndex = 11;
      this.radioButtonPing.TabStop = true;
      this.radioButtonPing.Text = "P&ing";
      this.radioButtonPing.UseVisualStyleBackColor = true;
      // 
      // buttonExecute
      // 
      this.buttonExecute.Location = new System.Drawing.Point(478, 134);
      this.buttonExecute.Name = "buttonExecute";
      this.buttonExecute.Size = new System.Drawing.Size(75, 23);
      this.buttonExecute.TabIndex = 15;
      this.buttonExecute.Text = "&Execute";
      this.buttonExecute.UseVisualStyleBackColor = true;
      this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
      // 
      // textBoxResult
      // 
      this.textBoxResult.Location = new System.Drawing.Point(12, 211);
      this.textBoxResult.Multiline = true;
      this.textBoxResult.Name = "textBoxResult";
      this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.textBoxResult.Size = new System.Drawing.Size(654, 621);
      this.textBoxResult.TabIndex = 17;
      // 
      // radioButtonGetTransactionList
      // 
      this.radioButtonGetTransactionList.AutoSize = true;
      this.radioButtonGetTransactionList.Location = new System.Drawing.Point(478, 54);
      this.radioButtonGetTransactionList.Name = "radioButtonGetTransactionList";
      this.radioButtonGetTransactionList.Size = new System.Drawing.Size(114, 17);
      this.radioButtonGetTransactionList.TabIndex = 12;
      this.radioButtonGetTransactionList.Text = "GetTransaction&List";
      this.radioButtonGetTransactionList.UseVisualStyleBackColor = true;
      // 
      // textBoxReceiverPartyIdentifier
      // 
      this.textBoxReceiverPartyIdentifier.Location = new System.Drawing.Point(128, 80);
      this.textBoxReceiverPartyIdentifier.Name = "textBoxReceiverPartyIdentifier";
      this.textBoxReceiverPartyIdentifier.Size = new System.Drawing.Size(223, 20);
      this.textBoxReceiverPartyIdentifier.TabIndex = 6;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(6, 83);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(120, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "&Receiver Party Identifier";
      // 
      // radioButtonGetTransaction
      // 
      this.radioButtonGetTransaction.AutoSize = true;
      this.radioButtonGetTransaction.Location = new System.Drawing.Point(478, 78);
      this.radioButtonGetTransaction.Name = "radioButtonGetTransaction";
      this.radioButtonGetTransaction.Size = new System.Drawing.Size(98, 17);
      this.radioButtonGetTransaction.TabIndex = 13;
      this.radioButtonGetTransaction.TabStop = true;
      this.radioButtonGetTransaction.Text = "&GetTransaction";
      this.radioButtonGetTransaction.UseVisualStyleBackColor = true;
      // 
      // textBoxTransactionUUID
      // 
      this.textBoxTransactionUUID.Location = new System.Drawing.Point(128, 104);
      this.textBoxTransactionUUID.Name = "textBoxTransactionUUID";
      this.textBoxTransactionUUID.Size = new System.Drawing.Size(223, 20);
      this.textBoxTransactionUUID.TabIndex = 8;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(36, 109);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(90, 13);
      this.label4.TabIndex = 7;
      this.label4.Text = "&TransactionUUID";
      // 
      // radioButtonUpdateTransactionStatus
      // 
      this.radioButtonUpdateTransactionStatus.AutoSize = true;
      this.radioButtonUpdateTransactionStatus.Location = new System.Drawing.Point(478, 102);
      this.radioButtonUpdateTransactionStatus.Name = "radioButtonUpdateTransactionStatus";
      this.radioButtonUpdateTransactionStatus.Size = new System.Drawing.Size(146, 17);
      this.radioButtonUpdateTransactionStatus.TabIndex = 14;
      this.radioButtonUpdateTransactionStatus.TabStop = true;
      this.radioButtonUpdateTransactionStatus.Text = "&UpdateTransactionStatus";
      this.radioButtonUpdateTransactionStatus.UseVisualStyleBackColor = true;
      // 
      // comboBoxNewStatus
      // 
      this.comboBoxNewStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBoxNewStatus.FormattingEnabled = true;
      this.comboBoxNewStatus.Items.AddRange(new object[] {
            "ssUnDeliverd",
            "ssDeliverdNoStatus",
            "ssDeliverd",
            "ssDeliverdWithError",
            "ssDeliverdWithWarning",
            "ssDeliverdRejected",
            "ssUnDeliverdCanceled"});
      this.comboBoxNewStatus.Location = new System.Drawing.Point(128, 131);
      this.comboBoxNewStatus.Name = "comboBoxNewStatus";
      this.comboBoxNewStatus.Size = new System.Drawing.Size(223, 21);
      this.comboBoxNewStatus.TabIndex = 10;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(66, 134);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(60, 13);
      this.label5.TabIndex = 9;
      this.label5.Text = "&New status";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(12, 195);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(95, 13);
      this.label6.TabIndex = 16;
      this.label6.Text = "Result / &messages";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(678, 844);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.comboBoxNewStatus);
      this.Controls.Add(this.radioButtonUpdateTransactionStatus);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.textBoxTransactionUUID);
      this.Controls.Add(this.radioButtonGetTransaction);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.textBoxReceiverPartyIdentifier);
      this.Controls.Add(this.radioButtonGetTransactionList);
      this.Controls.Add(this.textBoxResult);
      this.Controls.Add(this.buttonExecute);
      this.Controls.Add(this.radioButtonPing);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBoxPassword);
      this.Controls.Add(this.textBoxUsername);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Get invoices FROM InExchange";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.TextBox textBoxUsername;
    private System.Windows.Forms.TextBox textBoxPassword;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.RadioButton radioButtonPing;
    private System.Windows.Forms.Button buttonExecute;
    private System.Windows.Forms.TextBox textBoxResult;
    private System.Windows.Forms.RadioButton radioButtonGetTransactionList;
    private System.Windows.Forms.TextBox textBoxReceiverPartyIdentifier;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.RadioButton radioButtonGetTransaction;
    private System.Windows.Forms.TextBox textBoxTransactionUUID;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.RadioButton radioButtonUpdateTransactionStatus;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.ComboBox comboBoxNewStatus;
  }
}

