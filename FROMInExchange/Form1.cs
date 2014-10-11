using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FROMInExchange.FROMInExServiceReference;
using System.Configuration;

namespace FROMInExchange
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
      textBoxTransactionUUID.Text = ConfigurationManager.AppSettings[ "WS_TransactionUUID" ].ToString ();
      
    }


    /// <summary>
    /// Handles the Click event of the exitToolStripMenuItem control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void exitToolStripMenuItem_Click( object sender, EventArgs e )
    {
      Application.Exit ();
    }

    /// <summary>
    /// Handles the Click event of the aboutToolStripMenuItem control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void aboutToolStripMenuItem_Click( object sender, EventArgs e )
    {
      AboutBox1 about = new AboutBox1 ();
      about.ShowDialog ();
    }


    /// <summary>
    /// Execute selected method.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void buttonExecute_Click( object sender, EventArgs e )
    {
      try
      {
        textBoxResult.Clear ();
        textBoxResult.ForeColor = _resultTextDefaultColor;
        if ( radioButtonPing.Checked )
          Ping ();
        if ( radioButtonGetTransactionList.Checked )
          GetTransactionList ();
        if ( radioButtonGetTransaction.Checked )
          GetTransaction ();
        if ( radioButtonUpdateTransactionStatus.Checked )
          UpdateStatus ();
      }
      catch ( Exception ex )
      {
        textBoxResult.ForeColor = Color.Red;
        textBoxResult.Text = ex.Message;
      }
    }

    /// <summary>
    /// Updates the status.
    /// </summary>
    /// <exception cref="System.Exception"></exception>
    private void UpdateStatus()
    {
      try
      {
        string retMessage = string.Empty;
        WSSkTransactionSoapHttpClient client = new FROMInExServiceReference.WSSkTransactionSoapHttpClient ();
        SkTransactionResults res = client.UpdateTransactionStatus ( textBoxTransactionUUID.Text, textBoxUsername.Text, textBoxPassword.Text, comboBoxNewStatus.Text, retMessage );
        if ( res.errorCode != null )
          throw new Exception ( res.errorMessage );

        textBoxResult.Text = string.Format ( "Status for invoice with UUID {0} updated to {1}", res.UUID, comboBoxNewStatus.Text );
      }
      catch ( Exception )
      {
        throw;
      }
    }

    /// <summary>
    /// Gets the transaction.
    /// </summary>
    /// <exception cref="System.Exception"></exception>
    private void GetTransaction()
    {
      try
      {
        WSSkTransactionSoapHttpClient client = new FROMInExServiceReference.WSSkTransactionSoapHttpClient ();
        SkTransactionPayload invoice = client.GetTransaction ( textBoxTransactionUUID.Text, textBoxUsername.Text, textBoxPassword.Text );
        if ( invoice.errorCode != null )
          throw new Exception ( invoice.errorMessage );

        textBoxResult.Text = System.Text.Encoding.UTF8.GetString ( Convert.FromBase64String ( invoice.payload ) );
      }
      catch ( Exception )
      {
        throw;
      }
    }

    /// <summary>
    /// Gets the transaction list.
    /// </summary>
    /// <exception cref="System.Exception"></exception>
    private void GetTransactionList()
    {
      try
      {
        WSSkTransactionSoapHttpClient client = new FROMInExServiceReference.WSSkTransactionSoapHttpClient ();
        TransactionListResult res = client.GetTransactionList ( textBoxReceiverPartyIdentifier.Text, null, null, textBoxUsername.Text, textBoxPassword.Text );
        if ( res.errorCode != null )
          throw new Exception ( res.errorMessage );
        textBoxResult.Text = string.Format ( "{0} invoice(s) found.{1}{1}", res.lines.Count(), Environment.NewLine );
        foreach ( string line in res.lines)
        {
          textBoxResult.Text += string.Format ( "Invoice Id = {0}{1}", line, Environment.NewLine );
        }
      }
      catch ( Exception )
      {
        throw;
      }
    }

    /// <summary>
    /// Call ping method of the web service
    /// If the call is successful it will return the parameter back.
    /// </summary>
    private void Ping()
    {
      try
      {
        WSSkTransactionSoapHttpClient client = new FROMInExServiceReference.WSSkTransactionSoapHttpClient ();
        string ret = client.Ping ( "Hello World!" );
        textBoxResult.Text = ret;
      }
      catch ( Exception )
      {
        throw;
      }
    }

  }
}
