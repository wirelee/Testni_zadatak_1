using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Yahoo_Finance_Scraper
{
    public partial class frmTicker : Form
    {
        public string _applicationName = "Yahoo! Finance Scraper";
        public frmTicker()
        {
            InitializeComponent();
            dtpDate.Value = DateTime.Now;
        }

        private void btnScraper_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTiker.Text))
            {
                MessageBox.Show("Ticker not provided.", _applicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\Database\\" + "Database.accdb");
                    OleDbCommand cmd = con.CreateCommand();
                    con.Open();
                    StockInfo stockInfo = null;
                    //Check if record exists
                    //If yes update the record
                    //Pull the record and display on screen
                    cmd.CommandText = "SELECT * FROM StockInfo WHERE [Ticker] = '" + txtTiker.Text + "' AND PriceDate = #" + dtpDate.Value.ToString("MM-dd-yyyy") + "#";
                    cmd.Connection = con;
                    OleDbDataReader oddr = cmd.ExecuteReader();
                    if (oddr.HasRows)
                    {
                        oddr.Read();
                        stockInfo = new StockInfo(oddr.GetString(1));
                        stockInfo.CompanyName = oddr.GetString(0);
                        stockInfo.YearFounded = oddr.GetInt32(2);
                        stockInfo.NumberOfEmployees = oddr.GetInt32(3);
                        stockInfo.City = oddr.GetString(4);
                        stockInfo.State = oddr.GetString(5);
                        stockInfo.PriceDate = oddr.GetDateTime(6);
                        stockInfo.PreviousClosePrice = oddr.GetDecimal(7);
                        stockInfo.OpenPrice = oddr.GetDecimal(8);
                        stockInfo.MarketCap = oddr.GetString(9);
                    }
                    else
                    {
                        oddr.Close();
                        WebClient wc = new WebClient();
                        stockInfo = wc.RetrieveStock(txtTiker.Text, dtpDate.Value);
                        cmd.CommandText = "INSERT INTO Stockinfo(CompanyName, Ticker, YearFounded, NumberOfEmployees, City, State, PriceDate, PreviousClosePrice, OpenPrice, MarketCap) VALUES ('"
                            + stockInfo.CompanyName + "', '" + stockInfo.Ticker + "', '" + stockInfo.YearFounded + "', '" + stockInfo.NumberOfEmployees + "', '" + stockInfo.City + "', '"
                            + stockInfo.State + "', '" + stockInfo.PriceDate.ToString("dd.MM.yyyy.") + "', '" + stockInfo.PreviousClosePrice + "', '" + stockInfo.OpenPrice + "', '" + stockInfo.MarketCap + "')";
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Submitted", "Congrats");
                        con.Close();
                    }

                    if (stockInfo != null)
                    {
                        rtbTickerInformation.Text = "";
                        rtbTickerInformation.Text += "Company Name: " + stockInfo.CompanyName + "\n";
                        rtbTickerInformation.Text += "Year Founded: " + stockInfo.YearFounded.ToString() + "\n";
                        rtbTickerInformation.Text += "Number of Employees: " + stockInfo.NumberOfEmployees.ToString() + "\n";
                        rtbTickerInformation.Text += "City: " + stockInfo.City + "\n";
                        rtbTickerInformation.Text += "State: " + stockInfo.State + "\n";
                        rtbTickerInformation.Text += "Price Date Time: " + stockInfo.PriceDate.ToShortDateString() + "\n";
                        rtbTickerInformation.Text += "Previous Close Price: " + stockInfo.PreviousClosePrice.ToString() + "\n";
                        rtbTickerInformation.Text += "Open Price: " + stockInfo.OpenPrice.ToString() + "\n";
                        rtbTickerInformation.Text += "Market Cap: " + stockInfo.MarketCap + "\n";
                        
                    }
                }

                catch (Exception ex)
                {
                    //Write error handling
                    MessageBox.Show("Error info: " + ex.Message);

                }
            }
        }
    }
}


