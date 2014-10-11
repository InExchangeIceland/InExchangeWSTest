using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using TOInExchange.TOInExServiceReference;
using System.IO;

namespace TOInExchange
{
  public partial class Form1 : Form
  {
    Color _resultTextDefaultColor;

    public Form1()
    {
      InitializeComponent ();
      
      _resultTextDefaultColor = textBoxResult.ForeColor;

      textBoxUsername.Text = ConfigurationManager.AppSettings[ "WS_Username" ].ToString ();
      textBoxPassword.Text = ConfigurationManager.AppSettings[ "WS_Password" ].ToString ();
      textBoxReceiverPartyIdentifier.Text = ConfigurationManager.AppSettings[ "WS_ReceiverPartyIdentifier" ].ToString ();
      textBoxFilename.Text = ConfigurationManager.AppSettings[ "Filename" ].ToString ();
    }

    /// <summary>
    /// Exit the application.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void exitToolStripMenuItem_Click( object sender, EventArgs e )
    {
      Application.Exit ();
    }

    /// <summary>
    /// Execute action.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void buttonExecute_Click( object sender, EventArgs e )
    {
      try
      {
        textBoxResult.Clear ();
        textBoxResult.ForeColor = _resultTextDefaultColor;

        if ( radioButtonHelloWorld.Checked )
          HelloWorld ();
        if ( radioButtonIsRecipient.Checked )
          IsRecipient ();
        if ( radioButtonInvoiceToInExchange.Checked )
          InvoiceToInExchange ();
      }
      catch ( Exception ex )
      {
        textBoxResult.ForeColor = Color.Red;
        MessageBox.Show ( ex.Message );
      }
    }

    /// <summary>
    /// Invoice sent to InExchange.
    /// </summary>
    /// <remarks>
    /// Possible values of Subaccount are:
    ///   Standard                  Subaccount
    ///   ------------------------- ----------------------------
    ///   NES-UBL                   toinex/prod
    ///   TS136 - BII Invoice       toinex/prod/invoice
    ///   TS137 - BII Creditnote    toinex/prod/creditnote
    ///   TS138 - BII Order         toinex/prod/order
    ///   TS139 - BII Catalogue     toinex/prod/catalogue
    /// </remarks>
    /// <exception cref="System.NotImplementedException"></exception>
    private void InvoiceToInExchange()
    {
      //client.InvoiceToInExchange ( "username", "password", "subaccount", "filename", new byte[]{});
      try
      {
        string xmlFile = string.Empty;

        System.Text.Encoding _encoding = System.Text.Encoding.GetEncoding ( "utf-8" );

        using ( StreamReader sr = new StreamReader ( textBoxFilename.Text, _encoding ) )
        {
          xmlFile = sr.ReadToEnd ();

          byte[] _xmlFileByteArray = _encoding.GetBytes ( xmlFile );

          InvoiceServiceClient client = new InvoiceServiceClient ();
          Reply reply = client.InvoiceToInExchange ( textBoxUsername.Text, textBoxPassword.Text, comboBoxSubaccount.Text, textBoxFilename.Text, _xmlFileByteArray );
          textBoxResult.Text = string.Format ( "Service return code = {0}{1}Service return string = {2}", reply.ReturnCode, Environment.NewLine, reply.ReturnString );
          sr.Close ();
        }
      }
      catch ( Exception )
      {
        throw;
      }
    }

    /// <summary>
    /// Determines whether a legal entity is recipient at InExchange.
    /// </summary>
    private void IsRecipient()
    {
      try
      {
        InvoiceServiceClient client = new InvoiceServiceClient ();
        bool bfRet = client.IsRecipient ( textBoxUsername.Text, textBoxPassword.Text, textBoxReceiverPartyIdentifier.Text, PartyIdentifierTypes.IS_KT );
        if ( bfRet )
          textBoxResult.Text = string.Format ( "{0} is a recipient at InExchange.", textBoxReceiverPartyIdentifier.Text );
        else 
          textBoxResult.Text = string.Format ( "{0} is NOT a recipient at InExchange.", textBoxReceiverPartyIdentifier.Text );
      }
      catch ( Exception )
      {
        throw;
      }
    }

    /// <summary>
    /// Simple connection test to the web service.
    /// </summary>
    private void HelloWorld()
    {
      try
      {
        InvoiceServiceClient client = new InvoiceServiceClient ();
        textBoxResult.Text = client.HelloWorld ();

      }
      catch ( Exception )
      {
        throw;
      }
    }

    private void buttonBrowseForFile_Click( object sender, EventArgs e )
    {
      try
      {
        OpenFileDialog ofd = new OpenFileDialog ();
        ofd.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";

        if ( ofd.ShowDialog () == System.Windows.Forms.DialogResult.OK )
        {
          textBoxFilename.Text = ofd.FileName;
        }

      }
      catch ( Exception ex )
      {
        MessageBox.Show ( ex.Message );
      }
    }


    /// <summary>
    /// Show about dialog
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void aboutToolStripMenuItem_Click( object sender, EventArgs e )
    {
      AboutBox1 about = new AboutBox1 ();
      about.ShowDialog ();
    }

  }
}
