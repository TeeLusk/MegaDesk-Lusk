
namespace MegaDesk_Lusk
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btn_AddNewQuote = new System.Windows.Forms.Button();
            this.btn_ViewQuotes = new System.Windows.Forms.Button();
            this.btn_SearchQuotes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lblMainMenuMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AddNewQuote
            // 
            this.btn_AddNewQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddNewQuote.Location = new System.Drawing.Point(43, 37);
            this.btn_AddNewQuote.Name = "btn_AddNewQuote";
            this.btn_AddNewQuote.Size = new System.Drawing.Size(278, 67);
            this.btn_AddNewQuote.TabIndex = 0;
            this.btn_AddNewQuote.Text = "Add New Quote";
            this.btn_AddNewQuote.UseVisualStyleBackColor = true;
            this.btn_AddNewQuote.Click += new System.EventHandler(this.btn_AddNewQuote_Click);
            // 
            // btn_ViewQuotes
            // 
            this.btn_ViewQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewQuotes.Location = new System.Drawing.Point(43, 124);
            this.btn_ViewQuotes.Name = "btn_ViewQuotes";
            this.btn_ViewQuotes.Size = new System.Drawing.Size(278, 67);
            this.btn_ViewQuotes.TabIndex = 1;
            this.btn_ViewQuotes.Text = "View Quotes";
            this.btn_ViewQuotes.UseVisualStyleBackColor = true;
            this.btn_ViewQuotes.Click += new System.EventHandler(this.btn_ViewQuotes_Click);
            // 
            // btn_SearchQuotes
            // 
            this.btn_SearchQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchQuotes.Location = new System.Drawing.Point(43, 211);
            this.btn_SearchQuotes.Name = "btn_SearchQuotes";
            this.btn_SearchQuotes.Size = new System.Drawing.Size(278, 67);
            this.btn_SearchQuotes.TabIndex = 2;
            this.btn_SearchQuotes.Text = "Search Quotes";
            this.btn_SearchQuotes.UseVisualStyleBackColor = true;
            this.btn_SearchQuotes.Click += new System.EventHandler(this.btn_SearchQuotes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(387, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 328);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(43, 298);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(278, 67);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lblMainMenuMsg
            // 
            this.lblMainMenuMsg.AutoSize = true;
            this.lblMainMenuMsg.Location = new System.Drawing.Point(310, 389);
            this.lblMainMenuMsg.Name = "lblMainMenuMsg";
            this.lblMainMenuMsg.Size = new System.Drawing.Size(0, 13);
            this.lblMainMenuMsg.TabIndex = 5;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMainMenuMsg);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_SearchQuotes);
            this.Controls.Add(this.btn_ViewQuotes);
            this.Controls.Add(this.btn_AddNewQuote);
            this.Name = "MainMenu";
            this.Text = "MegaDesk";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddNewQuote;
        private System.Windows.Forms.Button btn_ViewQuotes;
        private System.Windows.Forms.Button btn_SearchQuotes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lblMainMenuMsg;
    }
}

