namespace ForeignExchangeOffice
{
    partial class AddForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxEuroAmountInSafe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxUsdAmountInSafe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxTlAmountInSafe = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dragControl1 = new ForeignExchangeOffice.DragControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the amount of money in your safe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TL:";
            // 
            // tbxEuroAmountInSafe
            // 
            this.tbxEuroAmountInSafe.Location = new System.Drawing.Point(107, 155);
            this.tbxEuroAmountInSafe.Name = "tbxEuroAmountInSafe";
            this.tbxEuroAmountInSafe.Size = new System.Drawing.Size(141, 20);
            this.tbxEuroAmountInSafe.TabIndex = 2;
            this.tbxEuroAmountInSafe.TextChanged += new System.EventHandler(this.tbxEuroAmountInSafe_TextChanged);
            this.tbxEuroAmountInSafe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxEuroAmountInSafe_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "USD:";
            // 
            // tbxUsdAmountInSafe
            // 
            this.tbxUsdAmountInSafe.Location = new System.Drawing.Point(107, 124);
            this.tbxUsdAmountInSafe.Name = "tbxUsdAmountInSafe";
            this.tbxUsdAmountInSafe.Size = new System.Drawing.Size(141, 20);
            this.tbxUsdAmountInSafe.TabIndex = 2;
            this.tbxUsdAmountInSafe.TextChanged += new System.EventHandler(this.tbxUsdAmountInSafe_TextChanged);
            this.tbxUsdAmountInSafe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxUsdAmountInSafe_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "EURO:";
            // 
            // tbxTlAmountInSafe
            // 
            this.tbxTlAmountInSafe.Location = new System.Drawing.Point(107, 93);
            this.tbxTlAmountInSafe.Name = "tbxTlAmountInSafe";
            this.tbxTlAmountInSafe.Size = new System.Drawing.Size(141, 20);
            this.tbxTlAmountInSafe.TabIndex = 2;
            this.tbxTlAmountInSafe.TextChanged += new System.EventHandler(this.tbxTlAmountInSafe_TextChanged);
            this.tbxTlAmountInSafe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxTlAmountInSafe_KeyPress);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.Location = new System.Drawing.Point(185, 197);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(63, 25);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(107, 197);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(63, 25);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 252);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbxTlAmountInSafe);
            this.Controls.Add(this.tbxUsdAmountInSafe);
            this.Controls.Add(this.tbxEuroAmountInSafe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxEuroAmountInSafe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxUsdAmountInSafe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxTlAmountInSafe;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private DragControl dragControl1;
    }
}