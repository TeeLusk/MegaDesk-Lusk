
namespace MegaDesk_Lusk
{
    partial class AddQuote
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.widthBox = new System.Windows.Forms.NumericUpDown();
            this.selectNumShelves = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblNumShelves = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.WidthWarningLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAddQuoteDate = new System.Windows.Forms.Label();
            this.btnSubmitAddQuote = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.widthBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectNumShelves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Width (in)";
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(163, 54);
            this.widthBox.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.widthBox.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(120, 20);
            this.widthBox.TabIndex = 2;
            this.widthBox.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.widthBox.ValueChanged += new System.EventHandler(this.widthBox_ValueChanged);
            // 
            // selectNumShelves
            // 
            this.selectNumShelves.Location = new System.Drawing.Point(163, 109);
            this.selectNumShelves.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.selectNumShelves.Name = "selectNumShelves";
            this.selectNumShelves.Size = new System.Drawing.Size(120, 20);
            this.selectNumShelves.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Laminate ",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.comboBox1.Location = new System.Drawing.Point(162, 140);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // lblNumShelves
            // 
            this.lblNumShelves.AutoSize = true;
            this.lblNumShelves.Location = new System.Drawing.Point(30, 111);
            this.lblNumShelves.Name = "lblNumShelves";
            this.lblNumShelves.Size = new System.Drawing.Size(97, 13);
            this.lblNumShelves.TabIndex = 6;
            this.lblNumShelves.Text = "Number of Shelves";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Wood Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Shipping Type";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "No Rush",
            "3 Days",
            "5 Days",
            "7 Days"});
            this.comboBox2.Location = new System.Drawing.Point(163, 175);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(163, 80);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Tag = "";
            this.numericUpDown1.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Depth (in)";
            // 
            // WidthWarningLabel
            // 
            this.WidthWarningLabel.AutoSize = true;
            this.WidthWarningLabel.ForeColor = System.Drawing.Color.Red;
            this.WidthWarningLabel.Location = new System.Drawing.Point(308, 61);
            this.WidthWarningLabel.Name = "WidthWarningLabel";
            this.WidthWarningLabel.Size = new System.Drawing.Size(0, 13);
            this.WidthWarningLabel.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(610, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "*Please note any values outside of the accepted format and range will automatical" +
    "ly be changed to their nearest accepted value";
            // 
            // lblAddQuoteDate
            // 
            this.lblAddQuoteDate.AutoSize = true;
            this.lblAddQuoteDate.Location = new System.Drawing.Point(683, 22);
            this.lblAddQuoteDate.Name = "lblAddQuoteDate";
            this.lblAddQuoteDate.Size = new System.Drawing.Size(0, 13);
            this.lblAddQuoteDate.TabIndex = 14;
            // 
            // btnSubmitAddQuote
            // 
            this.btnSubmitAddQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitAddQuote.Location = new System.Drawing.Point(22, 376);
            this.btnSubmitAddQuote.Name = "btnSubmitAddQuote";
            this.btnSubmitAddQuote.Size = new System.Drawing.Size(188, 37);
            this.btnSubmitAddQuote.TabIndex = 7;
            this.btnSubmitAddQuote.Text = "Submit";
            this.btnSubmitAddQuote.UseVisualStyleBackColor = true;
            this.btnSubmitAddQuote.Click += new System.EventHandler(this.btnSubmitAddQuote_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmitAddQuote);
            this.Controls.Add(this.lblAddQuoteDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.WidthWarningLabel);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNumShelves);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.selectNumShelves);
            this.Controls.Add(this.widthBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.widthBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectNumShelves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown widthBox;
        private System.Windows.Forms.NumericUpDown selectNumShelves;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblNumShelves;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label WidthWarningLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAddQuoteDate;
        private System.Windows.Forms.Button btnSubmitAddQuote;
    }
}