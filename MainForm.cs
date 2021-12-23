using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Runtime.InteropServices;

namespace ForeignExchangeOffice
{
    public partial class MainForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
      );
        public MainForm()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }

        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ForeignExchangeOffice;integrated security=true");
        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                string todayCurrency = "https://www.tcmb.gov.tr/kurlar/today.xml";
                var xmlDocument = new XmlDocument();
                xmlDocument.Load(todayCurrency);

                string buyDollars = xmlDocument.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
                lblBuyDollars.Text = buyDollars + " ₺";

                string sellDollars = xmlDocument.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
                lblSellDollars.Text = sellDollars + " ₺";

                string buyEuros = xmlDocument.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
                lblBuyEuros.Text = buyEuros + " ₺";

                string sellEuro = xmlDocument.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
                lblSellEuros.Text = sellEuro + " ₺";

                LoadTable();
                GetTotalAmount();
            }
            catch
            {
                MessageBox.Show("On this basis, internet connection is required to use", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnDollarBuy.Enabled = false;
                btnDollarSell.Enabled = false;
                btnEuroBuy.Enabled = false;
                btnEuroSell.Enabled = false;
                btnTransactionLeft.Enabled = false;
                btnTransactionRight.Enabled = false;
                lblBuyDollars.Text = "0";
                lblBuyEuros.Text = "0";
                lblSellDollars.Text = "0";
                lblSellEuros.Text = "0";
            }

        }

        private void GetTotalAmount()
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("Select sum(TL) from MoneyCase", _connection);
            lblTl.Text = (command.ExecuteScalar()).ToString();
            lblTl.Text += lblTl.Text == "" || lblTl.Text == null ? "0 ₺" : " ₺";

            command = new SqlCommand("Select sum(USD) from MoneyCase", _connection);
            lblUsd.Text = (command.ExecuteScalar()).ToString() + " $";
            lblUsd.Text = (command.ExecuteScalar()).ToString();
            lblUsd.Text += lblUsd.Text == "" || lblUsd.Text == null ? "0 $" : " $";

            command = new SqlCommand("Select sum(EUR) from MoneyCase", _connection);
            lblEur.Text = (command.ExecuteScalar()).ToString() + " €";
            lblEur.Text = (command.ExecuteScalar()).ToString();
            lblEur.Text += lblEur.Text == "" || lblEur.Text == null ? "0 €" : " €";
        }

        public void LoadTable()
        {
            dgwBaseData.DataSource = this.GetAll();
        }

        public DataTable GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from MoneyCase", _connection);

            SqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            reader.Close();
            _connection.Close();

            return dataTable;
        }

        bool dollarState = false;

        private void btnDollarBuy_Click(object sender, EventArgs e)
        {
            tbxExchangeRateLeft.Text = lblBuyDollars.Text;
            tbxExchangeRateRight.Text = lblBuyDollars.Text;
            btnTransactionLeft.Enabled = true;
            btnTransactionLeft.Text = "BUY";
            lblEuroSymbol.Visible = false;
            lblDollarSymbol.Visible = true;

            lblTlSymbol.Visible = true;

            dollarState = true;

            btnTransactionRight.Enabled = true;
            btnTransactionRight.Text = "BUY";

            ClearTbx();
        }

        private void ClearTbx()
        {
            tbxAmountLeft.Text = "";
            tbxTotalAmountLeft.Text = "";
            tbxAmountRight.Text = "";
            tbxTotalAmountRight.Text = "";
        }

        private void btnDollarSell_Click(object sender, EventArgs e)
        {
            tbxExchangeRateLeft.Text = lblBuyDollars.Text;
            tbxExchangeRateRight.Text = lblBuyDollars.Text;
            btnTransactionLeft.Enabled = true;
            btnTransactionLeft.Text = "SELL";
            lblEuroSymbol.Visible = false;
            lblDollarSymbol.Visible = true;

            lblTlSymbol.Visible = true;

            dollarState = true;

            btnTransactionRight.Enabled = true;
            btnTransactionRight.Text = "SELL";

            ClearTbx();
        }

        private void btnEuroBuy_Click(object sender, EventArgs e)
        {
            tbxExchangeRateLeft.Text = lblBuyDollars.Text;
            tbxExchangeRateRight.Text = lblBuyDollars.Text;
            btnTransactionLeft.Enabled = true;
            btnTransactionLeft.Text = "BUY";
            lblEuroSymbol.Visible = true;
            lblDollarSymbol.Visible = false;

            lblTlSymbol.Visible = true;

            dollarState = false;

            btnTransactionRight.Enabled = true;
            btnTransactionRight.Text = "BUY";

            ClearTbx();
        }

        private void btnEuroSell_Click(object sender, EventArgs e)
        {
            tbxExchangeRateLeft.Text = lblBuyDollars.Text;
            tbxExchangeRateRight.Text = lblBuyDollars.Text;
            btnTransactionLeft.Enabled = true;
            btnTransactionLeft.Text = "SELL";
            lblEuroSymbol.Visible = true;
            lblDollarSymbol.Visible = false;

            lblTlSymbol.Visible = true;

            dollarState = false;

            btnTransactionRight.Enabled = true;
            btnTransactionRight.Text = "SELL";

            ClearTbx();
        }

        private void btnTransactionRight_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(tbxAmountRight.Text))
            {
                double exchangeRate, amount, totalAmount;
                exchangeRate = Convert.ToDouble((tbxExchangeRateRight.Text).Replace("₺", ""));
                amount = Convert.ToDouble(tbxAmountRight.Text);
                totalAmount = exchangeRate * amount;
                tbxTotalAmountRight.Text = totalAmount.ToString("0.0000") + " ₺";

                if (btnTransactionRight.Text == "BUY")
                {
                    if (lblDollarSymbol.Visible == true)
                    {
                        ConnectionControl();
                        SqlCommand command = new SqlCommand("Insert into MoneyCase values(@date,@tl,@usd,@eur)", _connection);
                        command.Parameters.AddWithValue("@date", DateTime.Today);
                        command.Parameters.AddWithValue("@tl", totalAmount * (-1));
                        command.Parameters.AddWithValue("@usd", amount);
                        command.Parameters.AddWithValue("@eur", 0);
                        command.ExecuteNonQuery();

                        _connection.Close();
                    }
                    else
                    {
                        ConnectionControl();
                        SqlCommand command = new SqlCommand("Insert into MoneyCase values(@date,@tl,@usd,@eur)", _connection);
                        command.Parameters.AddWithValue("@date", DateTime.Today);
                        command.Parameters.AddWithValue("@tl", totalAmount * (-1));
                        command.Parameters.AddWithValue("@usd", 0);
                        command.Parameters.AddWithValue("@eur", amount);
                        command.ExecuteNonQuery();

                        _connection.Close();
                    }
                }
                else
                {
                    if (lblDollarSymbol.Visible == true)
                    {
                        ConnectionControl();
                        SqlCommand command = new SqlCommand("Insert into MoneyCase values(@date,@tl,@usd,@eur)", _connection);
                        command.Parameters.AddWithValue("@date", DateTime.Today);
                        command.Parameters.AddWithValue("@tl", totalAmount);
                        command.Parameters.AddWithValue("@usd", amount * (-1));
                        command.Parameters.AddWithValue("@eur", 0);
                        command.ExecuteNonQuery();

                        _connection.Close();
                    }
                    else
                    {
                        ConnectionControl();
                        SqlCommand command = new SqlCommand("Insert into MoneyCase values(@date,@tl,@usd,@eur)", _connection);
                        command.Parameters.AddWithValue("@date", DateTime.Today);
                        command.Parameters.AddWithValue("@tl", totalAmount);
                        command.Parameters.AddWithValue("@usd", 0);
                        command.Parameters.AddWithValue("@eur", amount * (-1));
                        command.ExecuteNonQuery();

                        _connection.Close();
                    }
                }

                LoadTable();
                GetTotalAmount();
            }
            else
            {
                MessageBox.Show("Please enter amount.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTransactionLeft_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(tbxAmountLeft.Text))
            {
                double exchangeRate = Convert.ToDouble((tbxExchangeRateLeft.Text).Replace("₺", ""));
                double amount = Convert.ToDouble(tbxAmountLeft.Text);
                double totalAmount = Convert.ToDouble(amount / exchangeRate);

                if (dollarState == true)
                {
                    tbxTotalAmountLeft.Text = totalAmount.ToString("0.0000") + " $";
                }
                else
                {
                    tbxTotalAmountLeft.Text = totalAmount.ToString("0.0000") + " €";
                }


                if (btnTransactionLeft.Text == "BUY")
                {
                    if (dollarState == true)
                    {
                        ConnectionControl();
                        SqlCommand command = new SqlCommand("Insert into MoneyCase values(@date,@tl,@usd,@eur)", _connection);
                        command.Parameters.AddWithValue("@date", DateTime.Today);
                        command.Parameters.AddWithValue("@tl", amount * (-1));
                        command.Parameters.AddWithValue("@usd", totalAmount);
                        command.Parameters.AddWithValue("@eur", 0);
                        command.ExecuteNonQuery();

                        _connection.Close();
                    }
                    else
                    {
                        ConnectionControl();
                        SqlCommand command = new SqlCommand("Insert into MoneyCase values(@date,@tl,@usd,@eur)", _connection);
                        command.Parameters.AddWithValue("@date", DateTime.Today);
                        command.Parameters.AddWithValue("@tl", amount * (-1));
                        command.Parameters.AddWithValue("@usd", 0);
                        command.Parameters.AddWithValue("@eur", totalAmount);
                        command.ExecuteNonQuery();

                        _connection.Close();
                    }
                }
                else
                {
                    if (dollarState == true)
                    {
                        ConnectionControl();
                        SqlCommand command = new SqlCommand("Insert into MoneyCase values(@date,@tl,@usd,@eur)", _connection);
                        command.Parameters.AddWithValue("@date", DateTime.Today);
                        command.Parameters.AddWithValue("@tl", amount);
                        command.Parameters.AddWithValue("@usd", (totalAmount) * (-1));
                        command.Parameters.AddWithValue("@eur", 0);
                        command.ExecuteNonQuery();

                        _connection.Close();
                    }
                    else
                    {
                        ConnectionControl();
                        SqlCommand command = new SqlCommand("Insert into MoneyCase values(@date,@tl,@usd,@eur)", _connection);
                        command.Parameters.AddWithValue("@date", DateTime.Today);
                        command.Parameters.AddWithValue("@tl", amount);
                        command.Parameters.AddWithValue("@usd", 0);
                        command.Parameters.AddWithValue("@eur", (totalAmount) * (-1));
                        command.ExecuteNonQuery();

                        _connection.Close();
                    }
                }

                LoadTable();
                GetTotalAmount();
            }
            else
            {
                MessageBox.Show("Please enter amount.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearTbx();
            LoadTable();
            GetTotalAmount();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClearTable_Click(object sender, EventArgs e)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("exec sp_MSforeachtable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL' exec sp_MSforeachtable 'ALTER TABLE ? DISABLE TRIGGER ALL'  exec sp_MSforeachtable 'DELETE ?'  exec sp_MSforeachtable 'ALTER TABLE ? CHECK CONSTRAINT ALL' exec sp_MSforeachtable 'ALTER TABLE ? ENABLE TRIGGER ALL' exec sp_MSforeachtable 'IF OBJECTPROPERTY(OBJECT_ID(''?''), ''TableHasIdentity'') = 1 BEGIN DBCC CHECKIDENT (''?'',RESEED,0) END'", _connection);
            command.ExecuteNonQuery();

            _connection.Close();

            LoadTable();
            GetTotalAmount();
        }

        private void IsNumeric(object obj)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch((obj as TextBox).Text, "  ^ [0-9]"))
            {
                (obj as TextBox).Text = "";
            }
        }

        private void DecimalPermissionOnly(KeyPressEventArgs e, object sender)
        {
            char seperator = char.Parse(Application.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == seperator && !(sender as TextBox).Text.Contains(seperator.ToString()));
        }

        private void tbxAmountLeft_TextChanged(object sender, EventArgs e)
        {
            IsNumeric(sender);
        }

        private void tbxAmountLeft_KeyPress(object sender, KeyPressEventArgs e)
        {
            DecimalPermissionOnly(e, sender);
        }

        private void tbxAmountRight_TextChanged(object sender, EventArgs e)
        {
            IsNumeric(sender);
        }

        private void tbxAmountRight_KeyPress(object sender, KeyPressEventArgs e)
        {
            DecimalPermissionOnly(e, sender);
        }
    }
}
