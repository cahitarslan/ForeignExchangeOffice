namespace ForeignExchangeOffice
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSellDollars = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDollarBuy = new System.Windows.Forms.Button();
            this.lblBuyDollars = new System.Windows.Forms.Label();
            this.btnDollarSell = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.btnEuroBuy = new System.Windows.Forms.Button();
            this.lblSellEuros = new System.Windows.Forms.Label();
            this.btnEuroSell = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBuyEuros = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgwBaseData = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEur = new System.Windows.Forms.Label();
            this.lblTl = new System.Windows.Forms.Label();
            this.lblUsd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTlSymbol = new System.Windows.Forms.Label();
            this.lblDollarSymbolForLeftTop = new System.Windows.Forms.Label();
            this.tbxExchangeRateLeft = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbxAmountLeft = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnTransactionLeft = new System.Windows.Forms.Button();
            this.tbxTotalAmountLeft = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblEuroSymbol = new System.Windows.Forms.Label();
            this.tbxExchangeRateRight = new System.Windows.Forms.TextBox();
            this.lblDollarSymbol = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxAmountRight = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnTransactionRight = new System.Windows.Forms.Button();
            this.tbxTotalAmountRight = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClearTable = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dragControl1 = new ForeignExchangeOffice.DragControl();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBaseData)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(35, 82);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(350, 206);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.lblSellDollars);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnDollarBuy);
            this.tabPage1.Controls.Add(this.lblBuyDollars);
            this.tabPage1.Controls.Add(this.btnDollarSell);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(342, 180);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "USD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(105, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "(For Turkish Liras)";
            // 
            // lblSellDollars
            // 
            this.lblSellDollars.AutoSize = true;
            this.lblSellDollars.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSellDollars.Location = new System.Drawing.Point(160, 71);
            this.lblSellDollars.Name = "lblSellDollars";
            this.lblSellDollars.Size = new System.Drawing.Size(0, 18);
            this.lblSellDollars.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(24, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "SELL DOLLARS:";
            // 
            // btnDollarBuy
            // 
            this.btnDollarBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDollarBuy.Location = new System.Drawing.Point(257, 16);
            this.btnDollarBuy.Name = "btnDollarBuy";
            this.btnDollarBuy.Size = new System.Drawing.Size(31, 32);
            this.btnDollarBuy.TabIndex = 7;
            this.btnDollarBuy.Text = "←";
            this.btnDollarBuy.UseVisualStyleBackColor = true;
            this.btnDollarBuy.Click += new System.EventHandler(this.btnDollarBuy_Click);
            // 
            // lblBuyDollars
            // 
            this.lblBuyDollars.AutoSize = true;
            this.lblBuyDollars.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBuyDollars.Location = new System.Drawing.Point(160, 28);
            this.lblBuyDollars.Name = "lblBuyDollars";
            this.lblBuyDollars.Size = new System.Drawing.Size(0, 18);
            this.lblBuyDollars.TabIndex = 0;
            // 
            // btnDollarSell
            // 
            this.btnDollarSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDollarSell.Location = new System.Drawing.Point(257, 59);
            this.btnDollarSell.Name = "btnDollarSell";
            this.btnDollarSell.Size = new System.Drawing.Size(31, 32);
            this.btnDollarSell.TabIndex = 6;
            this.btnDollarSell.Text = "→";
            this.btnDollarSell.UseVisualStyleBackColor = true;
            this.btnDollarSell.Click += new System.EventHandler(this.btnDollarSell_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "BUY DOLLARS:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.btnEuroBuy);
            this.tabPage2.Controls.Add(this.lblSellEuros);
            this.tabPage2.Controls.Add(this.btnEuroSell);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.lblBuyEuros);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(342, 180);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "EURO";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(105, 126);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(130, 18);
            this.label21.TabIndex = 17;
            this.label21.Text = "(For Turkish Liras)";
            // 
            // btnEuroBuy
            // 
            this.btnEuroBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEuroBuy.Location = new System.Drawing.Point(253, 17);
            this.btnEuroBuy.Name = "btnEuroBuy";
            this.btnEuroBuy.Size = new System.Drawing.Size(34, 33);
            this.btnEuroBuy.TabIndex = 2;
            this.btnEuroBuy.Text = "←";
            this.btnEuroBuy.UseVisualStyleBackColor = true;
            this.btnEuroBuy.Click += new System.EventHandler(this.btnEuroBuy_Click);
            // 
            // lblSellEuros
            // 
            this.lblSellEuros.AutoSize = true;
            this.lblSellEuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSellEuros.Location = new System.Drawing.Point(156, 72);
            this.lblSellEuros.Name = "lblSellEuros";
            this.lblSellEuros.Size = new System.Drawing.Size(0, 18);
            this.lblSellEuros.TabIndex = 1;
            // 
            // btnEuroSell
            // 
            this.btnEuroSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEuroSell.Location = new System.Drawing.Point(253, 60);
            this.btnEuroSell.Name = "btnEuroSell";
            this.btnEuroSell.Size = new System.Drawing.Size(34, 33);
            this.btnEuroSell.TabIndex = 1;
            this.btnEuroSell.Text = "→";
            this.btnEuroSell.UseVisualStyleBackColor = true;
            this.btnEuroSell.Click += new System.EventHandler(this.btnEuroSell_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(22, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "SELL EUROS:";
            // 
            // lblBuyEuros
            // 
            this.lblBuyEuros.AutoSize = true;
            this.lblBuyEuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBuyEuros.Location = new System.Drawing.Point(156, 29);
            this.lblBuyEuros.Name = "lblBuyEuros";
            this.lblBuyEuros.Size = new System.Drawing.Size(0, 18);
            this.lblBuyEuros.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(26, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "BUY EUROS:";
            // 
            // dgwBaseData
            // 
            this.dgwBaseData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwBaseData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.dgwBaseData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBaseData.Location = new System.Drawing.Point(799, 82);
            this.dgwBaseData.Name = "dgwBaseData";
            this.dgwBaseData.Size = new System.Drawing.Size(410, 463);
            this.dgwBaseData.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblEur);
            this.panel1.Controls.Add(this.lblTl);
            this.panel1.Controls.Add(this.lblUsd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(433, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 211);
            this.panel1.TabIndex = 2;
            // 
            // lblEur
            // 
            this.lblEur.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEur.AutoSize = true;
            this.lblEur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEur.Location = new System.Drawing.Point(145, 140);
            this.lblEur.Name = "lblEur";
            this.lblEur.Size = new System.Drawing.Size(38, 24);
            this.lblEur.TabIndex = 0;
            this.lblEur.Text = "0 €";
            // 
            // lblTl
            // 
            this.lblTl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTl.AutoSize = true;
            this.lblTl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTl.Location = new System.Drawing.Point(145, 44);
            this.lblTl.Name = "lblTl";
            this.lblTl.Size = new System.Drawing.Size(39, 24);
            this.lblTl.TabIndex = 0;
            this.lblTl.Text = "0 ₺";
            // 
            // lblUsd
            // 
            this.lblUsd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsd.AutoSize = true;
            this.lblUsd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUsd.Location = new System.Drawing.Point(145, 92);
            this.lblUsd.Name = "lblUsd";
            this.lblUsd.Size = new System.Drawing.Size(38, 24);
            this.lblUsd.TabIndex = 0;
            this.lblUsd.Text = "0 $";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(85, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "TL:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(67, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "EUR:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(68, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "USD:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblTlSymbol);
            this.panel2.Controls.Add(this.lblDollarSymbolForLeftTop);
            this.panel2.Controls.Add(this.tbxExchangeRateLeft);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.tbxAmountLeft);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.btnTransactionLeft);
            this.panel2.Controls.Add(this.tbxTotalAmountLeft);
            this.panel2.Location = new System.Drawing.Point(35, 359);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 228);
            this.panel2.TabIndex = 21;
            // 
            // lblTlSymbol
            // 
            this.lblTlSymbol.AutoSize = true;
            this.lblTlSymbol.BackColor = System.Drawing.Color.White;
            this.lblTlSymbol.Location = new System.Drawing.Point(278, 78);
            this.lblTlSymbol.Name = "lblTlSymbol";
            this.lblTlSymbol.Size = new System.Drawing.Size(13, 13);
            this.lblTlSymbol.TabIndex = 23;
            this.lblTlSymbol.Text = "₺";
            this.lblTlSymbol.Visible = false;
            // 
            // lblDollarSymbolForLeftTop
            // 
            this.lblDollarSymbolForLeftTop.AutoSize = true;
            this.lblDollarSymbolForLeftTop.BackColor = System.Drawing.Color.White;
            this.lblDollarSymbolForLeftTop.ForeColor = System.Drawing.Color.White;
            this.lblDollarSymbolForLeftTop.Location = new System.Drawing.Point(269, 110);
            this.lblDollarSymbolForLeftTop.Name = "lblDollarSymbolForLeftTop";
            this.lblDollarSymbolForLeftTop.Size = new System.Drawing.Size(13, 13);
            this.lblDollarSymbolForLeftTop.TabIndex = 18;
            this.lblDollarSymbolForLeftTop.Text = "$";
            this.lblDollarSymbolForLeftTop.Visible = false;
            // 
            // tbxExchangeRateLeft
            // 
            this.tbxExchangeRateLeft.Enabled = false;
            this.tbxExchangeRateLeft.Location = new System.Drawing.Point(131, 43);
            this.tbxExchangeRateLeft.Name = "tbxExchangeRateLeft";
            this.tbxExchangeRateLeft.Size = new System.Drawing.Size(166, 20);
            this.tbxExchangeRateLeft.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(36, 46);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Exchange Rate:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(74, 78);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Amount:";
            // 
            // tbxAmountLeft
            // 
            this.tbxAmountLeft.Location = new System.Drawing.Point(131, 75);
            this.tbxAmountLeft.Name = "tbxAmountLeft";
            this.tbxAmountLeft.Size = new System.Drawing.Size(166, 20);
            this.tbxAmountLeft.TabIndex = 12;
            this.tbxAmountLeft.TextChanged += new System.EventHandler(this.tbxAmountLeft_TextChanged);
            this.tbxAmountLeft.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAmountLeft_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(47, 110);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Total Amount:";
            // 
            // btnTransactionLeft
            // 
            this.btnTransactionLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(190)))), ((int)(((byte)(222)))));
            this.btnTransactionLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransactionLeft.Enabled = false;
            this.btnTransactionLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(190)))), ((int)(((byte)(222)))));
            this.btnTransactionLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnTransactionLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactionLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTransactionLeft.Location = new System.Drawing.Point(131, 161);
            this.btnTransactionLeft.Name = "btnTransactionLeft";
            this.btnTransactionLeft.Size = new System.Drawing.Size(166, 47);
            this.btnTransactionLeft.TabIndex = 8;
            this.btnTransactionLeft.Text = "CURRENCY TRANSACTION";
            this.btnTransactionLeft.UseVisualStyleBackColor = false;
            this.btnTransactionLeft.Click += new System.EventHandler(this.btnTransactionLeft_Click);
            // 
            // tbxTotalAmountLeft
            // 
            this.tbxTotalAmountLeft.Enabled = false;
            this.tbxTotalAmountLeft.Location = new System.Drawing.Point(131, 107);
            this.tbxTotalAmountLeft.Name = "tbxTotalAmountLeft";
            this.tbxTotalAmountLeft.Size = new System.Drawing.Size(166, 20);
            this.tbxTotalAmountLeft.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblEuroSymbol);
            this.panel3.Controls.Add(this.tbxExchangeRateRight);
            this.panel3.Controls.Add(this.lblDollarSymbol);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.tbxAmountRight);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.btnTransactionRight);
            this.panel3.Controls.Add(this.tbxTotalAmountRight);
            this.panel3.Location = new System.Drawing.Point(417, 359);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 228);
            this.panel3.TabIndex = 22;
            // 
            // lblEuroSymbol
            // 
            this.lblEuroSymbol.AutoSize = true;
            this.lblEuroSymbol.BackColor = System.Drawing.Color.White;
            this.lblEuroSymbol.Location = new System.Drawing.Point(275, 82);
            this.lblEuroSymbol.Name = "lblEuroSymbol";
            this.lblEuroSymbol.Size = new System.Drawing.Size(13, 13);
            this.lblEuroSymbol.TabIndex = 19;
            this.lblEuroSymbol.Text = "€";
            this.lblEuroSymbol.Visible = false;
            // 
            // tbxExchangeRateRight
            // 
            this.tbxExchangeRateRight.Enabled = false;
            this.tbxExchangeRateRight.Location = new System.Drawing.Point(131, 47);
            this.tbxExchangeRateRight.Name = "tbxExchangeRateRight";
            this.tbxExchangeRateRight.Size = new System.Drawing.Size(166, 20);
            this.tbxExchangeRateRight.TabIndex = 10;
            // 
            // lblDollarSymbol
            // 
            this.lblDollarSymbol.AutoSize = true;
            this.lblDollarSymbol.BackColor = System.Drawing.Color.White;
            this.lblDollarSymbol.Location = new System.Drawing.Point(275, 82);
            this.lblDollarSymbol.Name = "lblDollarSymbol";
            this.lblDollarSymbol.Size = new System.Drawing.Size(13, 13);
            this.lblDollarSymbol.TabIndex = 18;
            this.lblDollarSymbol.Text = "$";
            this.lblDollarSymbol.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(36, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Exchange Rate:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(74, 82);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Amount:";
            // 
            // tbxAmountRight
            // 
            this.tbxAmountRight.Location = new System.Drawing.Point(131, 79);
            this.tbxAmountRight.Name = "tbxAmountRight";
            this.tbxAmountRight.Size = new System.Drawing.Size(166, 20);
            this.tbxAmountRight.TabIndex = 12;
            this.tbxAmountRight.TextChanged += new System.EventHandler(this.tbxAmountRight_TextChanged);
            this.tbxAmountRight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAmountRight_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(47, 114);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Total Amount:";
            // 
            // btnTransactionRight
            // 
            this.btnTransactionRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(190)))), ((int)(((byte)(222)))));
            this.btnTransactionRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransactionRight.Enabled = false;
            this.btnTransactionRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(190)))), ((int)(((byte)(222)))));
            this.btnTransactionRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnTransactionRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactionRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTransactionRight.Location = new System.Drawing.Point(131, 161);
            this.btnTransactionRight.Name = "btnTransactionRight";
            this.btnTransactionRight.Size = new System.Drawing.Size(166, 47);
            this.btnTransactionRight.TabIndex = 8;
            this.btnTransactionRight.Text = "CURRENCY TRANSACTION";
            this.btnTransactionRight.UseVisualStyleBackColor = false;
            this.btnTransactionRight.Click += new System.EventHandler(this.btnTransactionRight_Click);
            // 
            // tbxTotalAmountRight
            // 
            this.tbxTotalAmountRight.Enabled = false;
            this.tbxTotalAmountRight.Location = new System.Drawing.Point(131, 111);
            this.tbxTotalAmountRight.Name = "tbxTotalAmountRight";
            this.tbxTotalAmountRight.Size = new System.Drawing.Size(166, 20);
            this.tbxTotalAmountRight.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(123, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(182, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "DAILY EXCHANGE RATE";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(494, 46);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(212, 16);
            this.label18.TabIndex = 27;
            this.label18.Text = "TOTAL MONEY IN THE SAFE";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(84, 324);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(249, 16);
            this.label17.TabIndex = 28;
            this.label17.Text = "FROM TL to OTHER CURRENCIES";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(504, 324);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(192, 16);
            this.label19.TabIndex = 29;
            this.label19.Text = "FROM CURRENCIES to TL";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(900, 46);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(206, 16);
            this.label20.TabIndex = 30;
            this.label20.Text = "TRANSACTION MOVEMENT";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(190)))), ((int)(((byte)(222)))));
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(190)))), ((int)(((byte)(222)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(799, 551);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 36);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClearTable
            // 
            this.btnClearTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(190)))), ((int)(((byte)(222)))));
            this.btnClearTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(190)))), ((int)(((byte)(222)))));
            this.btnClearTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnClearTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClearTable.Location = new System.Drawing.Point(1007, 551);
            this.btnClearTable.Name = "btnClearTable";
            this.btnClearTable.Size = new System.Drawing.Size(98, 36);
            this.btnClearTable.TabIndex = 31;
            this.btnClearTable.Text = "CLEAR TABLE";
            this.btnClearTable.UseVisualStyleBackColor = false;
            this.btnClearTable.Click += new System.EventHandler(this.btnClearTable_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(190)))), ((int)(((byte)(222)))));
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(190)))), ((int)(((byte)(222)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.Location = new System.Drawing.Point(1111, 551);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 36);
            this.btnExit.TabIndex = 31;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(190)))), ((int)(((byte)(222)))));
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(190)))), ((int)(((byte)(222)))));
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRefresh.Location = new System.Drawing.Point(903, 551);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(98, 36);
            this.btnRefresh.TabIndex = 32;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(204)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1249, 621);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearTable);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgwBaseData);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBaseData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblSellDollars;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBuyDollars;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSellEuros;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBuyEuros;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgwBaseData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEur;
        private System.Windows.Forms.Label lblUsd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTl;
        private System.Windows.Forms.Button btnEuroBuy;
        private System.Windows.Forms.Button btnEuroSell;
        private System.Windows.Forms.Button btnDollarBuy;
        private System.Windows.Forms.Button btnDollarSell;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTlSymbol;
        private System.Windows.Forms.Label lblDollarSymbolForLeftTop;
        private System.Windows.Forms.TextBox tbxExchangeRateLeft;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbxAmountLeft;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnTransactionLeft;
        private System.Windows.Forms.TextBox tbxTotalAmountLeft;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblEuroSymbol;
        private System.Windows.Forms.TextBox tbxExchangeRateRight;
        private System.Windows.Forms.Label lblDollarSymbol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxAmountRight;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnTransactionRight;
        private System.Windows.Forms.TextBox tbxTotalAmountRight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClearTable;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label21;
        private DragControl dragControl1;
    }
}

