using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ForeignExchangeOffice
{
    public partial class AddForm : Form
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
        public AddForm()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(tbxTlAmountInSafe.Text) && !String.IsNullOrWhiteSpace(tbxUsdAmountInSafe.Text) && !String.IsNullOrWhiteSpace(tbxEuroAmountInSafe.Text))
            {
                SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ForeignExchangeOffice;integrated security=true");

                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }

                SqlCommand command = new SqlCommand("Insert into MoneyCase values(@date,@tl,@usd,@eur)", _connection);
                command.Parameters.AddWithValue("@date", DateTime.Today);
                command.Parameters.AddWithValue("@tl", Convert.ToDecimal(tbxTlAmountInSafe.Text));
                command.Parameters.AddWithValue("@usd", Convert.ToDecimal(tbxUsdAmountInSafe.Text));
                command.Parameters.AddWithValue("@eur", Convert.ToDecimal(tbxEuroAmountInSafe.Text));
                command.ExecuteNonQuery();

                _connection.Close();

                MessageBox.Show("The amount you entered has been added to your cash register.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please enter the money amounts.","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IsNumeric()
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbxTlAmountInSafe.Text, "  ^ [0-9]"))
            {
                tbxTlAmountInSafe.Text = "";
            }
        }

        private void DecimalPermissionOnly(KeyPressEventArgs e, object sender)
        {
            char seperator = char.Parse(Application.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
            e.Handled =!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == seperator && !(sender as TextBox).Text.Contains(seperator.ToString()));
        }

        private void tbxTlAmountInSafe_TextChanged(object sender, EventArgs e)
        {
            IsNumeric();
        }
        private void tbxTlAmountInSafe_KeyPress(object sender, KeyPressEventArgs e)
        {
            DecimalPermissionOnly(e, sender);
        }


        private void tbxUsdAmountInSafe_TextChanged(object sender, EventArgs e)
        {
            IsNumeric();
        }

        private void tbxUsdAmountInSafe_KeyPress(object sender, KeyPressEventArgs e)
        {
            DecimalPermissionOnly(e, sender);
        }

        private void tbxEuroAmountInSafe_TextChanged(object sender, EventArgs e)
        {
            IsNumeric();
        }

        private void tbxEuroAmountInSafe_KeyPress(object sender, KeyPressEventArgs e)
        {
            DecimalPermissionOnly(e, sender);
        }
    }
}
