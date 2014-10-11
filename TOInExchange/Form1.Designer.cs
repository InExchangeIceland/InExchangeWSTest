namespace TOInExchange
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
      this.buttonExecute = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.textBoxReceiverPartyIdentifier = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.textBoxPassword = new System.Windows.Forms.TextBox();
      this.textBoxUsername = new System.Windows.Forms.TextBox();
      this.radioButtonHelloWorld = new System.Windows.Forms.RadioButton();
      this.radioButtonIsRecipient = new System.Windows.Forms.RadioButton();
      this.radioButtonInvoiceToInExchange = new System.Windows.Forms.RadioButton();
      this.textBoxFilename = new System.Windows.Forms.TextBox();
      this.buttonBrowseForFile = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.textBoxResult = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.comboBoxSubaccount = new System.Windows.Forms.ComboBox();
      this.label5 = new System.Windows.Forms.Label();
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
      this.menuStrip1.Size = new System.Drawing.Size(624, 24);
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
      this.exitToolStripMenuItem.Text = "&Exit";
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
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.aboutToolStripMenuItem.Text = "&About";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
      // 
      // buttonExecute
      // 
      this.buttonExecute.Location = new System.Drawing.Point(483, 106);
      this.buttonExecute.Name = "buttonExecute";
      this.buttonExecute.Size = new System.Drawing.Size(75, 23);
      this.buttonExecute.TabIndex = 15;
      this.buttonExecute.Text = "&Execute";
      this.buttonExecute.UseVisualStyleBackColor = true;
      this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(5, 83);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(120, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "&Receiver Party Identifier";
      // 
      // textBoxReceiverPartyIdentifier
      // 
      this.textBoxReceiverPartyIdentifier.Location = new System.Drawing.Point(131, 80);
      this.textBoxReceiverPartyIdentifier.Name = "textBoxReceiverPartyIdentifier";
      this.textBoxReceiverPartyIdentifier.Size = new System.Drawing.Size(223, 20);
      this.textBoxReceiverPartyIdentifier.TabIndex = 6;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(72, 57);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(53, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "&Password";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(70, 30);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(55, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "&Username";
      // 
      // textBoxPassword
      // 
      this.textBoxPassword.Location = new System.Drawing.Point(131, 54);
      this.textBoxPassword.Name = "textBoxPassword";
      this.textBoxPassword.Size = new System.Drawing.Size(223, 20);
      this.textBoxPassword.TabIndex = 4;
      // 
      // textBoxUsername
      // 
      this.textBoxUsername.Location = new System.Drawing.Point(131, 27);
      this.textBoxUsername.Name = "textBoxUsername";
      this.textBoxUsername.Size = new System.Drawing.Size(223, 20);
      this.textBoxUsername.TabIndex = 2;
      // 
      // radioButtonHelloWorld
      // 
      this.radioButtonHelloWorld.AutoSize = true;
      this.radioButtonHelloWorld.Checked = true;
      this.radioButtonHelloWorld.Location = new System.Drawing.Point(483, 27);
      this.radioButtonHelloWorld.Name = "radioButtonHelloWorld";
      this.radioButtonHelloWorld.Size = new System.Drawing.Size(77, 17);
      this.radioButtonHelloWorld.TabIndex = 12;
      this.radioButtonHelloWorld.TabStop = true;
      this.radioButtonHelloWorld.Text = "Hello&World";
      this.radioButtonHelloWorld.UseVisualStyleBackColor = true;
      // 
      // radioButtonIsRecipient
      // 
      this.radioButtonIsRecipient.AutoSize = true;
      this.radioButtonIsRecipient.Location = new System.Drawing.Point(483, 50);
      this.radioButtonIsRecipient.Name = "radioButtonIsRecipient";
      this.radioButtonIsRecipient.Size = new System.Drawing.Size(78, 17);
      this.radioButtonIsRecipient.TabIndex = 13;
      this.radioButtonIsRecipient.Text = "&IsRecipient";
      this.radioButtonIsRecipient.UseVisualStyleBackColor = true;
      // 
      // radioButtonInvoiceToInExchange
      // 
      this.radioButtonInvoiceToInExchange.AutoSize = true;
      this.radioButtonInvoiceToInExchange.Location = new System.Drawing.Point(483, 73);
      this.radioButtonInvoiceToInExchange.Name = "radioButtonInvoiceToInExchange";
      this.radioButtonInvoiceToInExchange.Size = new System.Drawing.Size(130, 17);
      this.radioButtonInvoiceToInExchange.TabIndex = 14;
      this.radioButtonInvoiceToInExchange.Text = "Invoice&ToInExchange";
      this.radioButtonInvoiceToInExchange.UseVisualStyleBackColor = true;
      // 
      // textBoxFilename
      // 
      this.textBoxFilename.Location = new System.Drawing.Point(131, 133);
      this.textBoxFilename.Name = "textBoxFilename";
      this.textBoxFilename.Size = new System.Drawing.Size(282, 20);
      this.textBoxFilename.TabIndex = 10;
      // 
      // buttonBrowseForFile
      // 
      this.buttonBrowseForFile.Location = new System.Drawing.Point(419, 133);
      this.buttonBrowseForFile.Name = "buttonBrowseForFile";
      this.buttonBrowseForFile.Size = new System.Drawing.Size(28, 20);
      this.buttonBrowseForFile.TabIndex = 11;
      this.buttonBrowseForFile.Text = "...";
      this.buttonBrowseForFile.UseVisualStyleBackColor = true;
      this.buttonBrowseForFile.Click += new System.EventHandler(this.buttonBrowseForFile_Click);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(76, 136);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(49, 13);
      this.label4.TabIndex = 9;
      this.label4.Text = "Filen&ame";
      // 
      // textBoxResult
      // 
      this.textBoxResult.Location = new System.Drawing.Point(12, 177);
      this.textBoxResult.Multiline = true;
      this.textBoxResult.Name = "textBoxResult";
      this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.textBoxResult.Size = new System.Drawing.Size(600, 284);
      this.textBoxResult.TabIndex = 17;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(12, 161);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(95, 13);
      this.label6.TabIndex = 16;
      this.label6.Text = "Result / &messages";
      // 
      // comboBoxSubaccount
      // 
      this.comboBoxSubaccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBoxSubaccount.FormattingEnabled = true;
      this.comboBoxSubaccount.Items.AddRange(new object[] {
            "toinex/prod",
            "toinex/prod/invoice",
            "toinex/prod/creditnote",
            "toinex/prod/order",
            "toinex/prod/catalogue"});
      this.comboBoxSubaccount.Location = new System.Drawing.Point(131, 106);
      this.comboBoxSubaccount.Name = "comboBoxSubaccount";
      this.comboBoxSubaccount.Size = new System.Drawing.Size(223, 21);
      this.comboBoxSubaccount.TabIndex = 8;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(60, 111);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(65, 13);
      this.label5.TabIndex = 7;
      this.label5.Text = "&Subaccount";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(624, 473);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.comboBoxSubaccount);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.textBoxResult);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.buttonBrowseForFile);
      this.Controls.Add(this.textBoxFilename);
      this.Controls.Add(this.radioButtonInvoiceToInExchange);
      this.Controls.Add(this.radioButtonIsRecipient);
      this.Controls.Add(this.radioButtonHelloWorld);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.textBoxReceiverPartyIdentifier);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBoxPassword);
      this.Controls.Add(this.textBoxUsername);
      this.Controls.Add(this.buttonExecute);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "TO InExchange";
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
    private System.Windows.Forms.Button buttonExecute;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBoxReceiverPartyIdentifier;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBoxPassword;
    private System.Windows.Forms.TextBox textBoxUsername;
    private System.Windows.Forms.RadioButton radioButtonHelloWorld;
    private System.Windows.Forms.RadioButton radioButtonIsRecipient;
    private System.Windows.Forms.RadioButton radioButtonInvoiceToInExchange;
    private System.Windows.Forms.TextBox textBoxFilename;
    private System.Windows.Forms.Button buttonBrowseForFile;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textBoxResult;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.ComboBox comboBoxSubaccount;
    private System.Windows.Forms.Label label5;
  }
}

