namespace YazilimYapimi
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
            this.mlstStories = new MetroFramework.Controls.MetroListView();
            this.mlstBaslanan = new MetroFramework.Controls.MetroListView();
            this.mlstGelistirilen = new MetroFramework.Controls.MetroListView();
            this.mlstTamamlanan = new MetroFramework.Controls.MetroListView();
            this.mlblStories = new MetroFramework.Controls.MetroLabel();
            this.mlblBaslanan = new MetroFramework.Controls.MetroLabel();
            this.mlblGelistirilen = new MetroFramework.Controls.MetroLabel();
            this.mlblTamamlanan = new MetroFramework.Controls.MetroLabel();
            this.btnGoster = new System.Windows.Forms.Button();
            this.rtxtStory1 = new System.Windows.Forms.RichTextBox();
            this.rtxtTask1 = new System.Windows.Forms.RichTextBox();
            this.rtxtStory2 = new System.Windows.Forms.RichTextBox();
            this.rtxtStory3 = new System.Windows.Forms.RichTextBox();
            this.rtxtTask2 = new System.Windows.Forms.RichTextBox();
            this.rtxtTask3 = new System.Windows.Forms.RichTextBox();
            this.rtxtTask4 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // mlstStories
            // 
            this.mlstStories.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mlstStories.FullRowSelect = true;
            this.mlstStories.Location = new System.Drawing.Point(97, 31);
            this.mlstStories.Name = "mlstStories";
            this.mlstStories.OwnerDraw = true;
            this.mlstStories.Size = new System.Drawing.Size(176, 409);
            this.mlstStories.TabIndex = 0;
            this.mlstStories.UseCompatibleStateImageBehavior = false;
            this.mlstStories.UseSelectable = true;
            // 
            // mlstBaslanan
            // 
            this.mlstBaslanan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mlstBaslanan.FullRowSelect = true;
            this.mlstBaslanan.Location = new System.Drawing.Point(267, 31);
            this.mlstBaslanan.Name = "mlstBaslanan";
            this.mlstBaslanan.OwnerDraw = true;
            this.mlstBaslanan.Size = new System.Drawing.Size(176, 409);
            this.mlstBaslanan.TabIndex = 1;
            this.mlstBaslanan.UseCompatibleStateImageBehavior = false;
            this.mlstBaslanan.UseSelectable = true;
            // 
            // mlstGelistirilen
            // 
            this.mlstGelistirilen.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mlstGelistirilen.FullRowSelect = true;
            this.mlstGelistirilen.Location = new System.Drawing.Point(430, 31);
            this.mlstGelistirilen.Name = "mlstGelistirilen";
            this.mlstGelistirilen.OwnerDraw = true;
            this.mlstGelistirilen.Size = new System.Drawing.Size(175, 409);
            this.mlstGelistirilen.TabIndex = 2;
            this.mlstGelistirilen.UseCompatibleStateImageBehavior = false;
            this.mlstGelistirilen.UseSelectable = true;
            // 
            // mlstTamamlanan
            // 
            this.mlstTamamlanan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mlstTamamlanan.FullRowSelect = true;
            this.mlstTamamlanan.Location = new System.Drawing.Point(597, 31);
            this.mlstTamamlanan.Name = "mlstTamamlanan";
            this.mlstTamamlanan.OwnerDraw = true;
            this.mlstTamamlanan.Size = new System.Drawing.Size(177, 409);
            this.mlstTamamlanan.TabIndex = 3;
            this.mlstTamamlanan.UseCompatibleStateImageBehavior = false;
            this.mlstTamamlanan.UseSelectable = true;
            // 
            // mlblStories
            // 
            this.mlblStories.AutoSize = true;
            this.mlblStories.Location = new System.Drawing.Point(147, 9);
            this.mlblStories.Name = "mlblStories";
            this.mlblStories.Size = new System.Drawing.Size(58, 19);
            this.mlblStories.TabIndex = 4;
            this.mlblStories.Text = "STORİES";
            // 
            // mlblBaslanan
            // 
            this.mlblBaslanan.AutoSize = true;
            this.mlblBaslanan.Location = new System.Drawing.Point(308, 9);
            this.mlblBaslanan.Name = "mlblBaslanan";
            this.mlblBaslanan.Size = new System.Drawing.Size(78, 19);
            this.mlblBaslanan.TabIndex = 5;
            this.mlblBaslanan.Text = "BAŞLANAN";
            // 
            // mlblGelistirilen
            // 
            this.mlblGelistirilen.AutoSize = true;
            this.mlblGelistirilen.Location = new System.Drawing.Point(485, 9);
            this.mlblGelistirilen.Name = "mlblGelistirilen";
            this.mlblGelistirilen.Size = new System.Drawing.Size(85, 19);
            this.mlblGelistirilen.TabIndex = 6;
            this.mlblGelistirilen.Text = "GELİŞTİRİLEN";
            // 
            // mlblTamamlanan
            // 
            this.mlblTamamlanan.AutoSize = true;
            this.mlblTamamlanan.Location = new System.Drawing.Point(635, 9);
            this.mlblTamamlanan.Name = "mlblTamamlanan";
            this.mlblTamamlanan.Size = new System.Drawing.Size(101, 19);
            this.mlblTamamlanan.TabIndex = 7;
            this.mlblTamamlanan.Text = "TAMAMLANAN";
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(796, 193);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(139, 73);
            this.btnGoster.TabIndex = 15;
            this.btnGoster.Text = "GÖSTER";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // rtxtStory1
            // 
            this.rtxtStory1.Location = new System.Drawing.Point(135, 66);
            this.rtxtStory1.Name = "rtxtStory1";
            this.rtxtStory1.Size = new System.Drawing.Size(100, 96);
            this.rtxtStory1.TabIndex = 16;
            this.rtxtStory1.Text = "";
            // 
            // rtxtTask1
            // 
            this.rtxtTask1.Location = new System.Drawing.Point(292, 66);
            this.rtxtTask1.Name = "rtxtTask1";
            this.rtxtTask1.Size = new System.Drawing.Size(100, 96);
            this.rtxtTask1.TabIndex = 17;
            this.rtxtTask1.Text = "";
            // 
            // rtxtStory2
            // 
            this.rtxtStory2.Location = new System.Drawing.Point(135, 193);
            this.rtxtStory2.Name = "rtxtStory2";
            this.rtxtStory2.Size = new System.Drawing.Size(100, 96);
            this.rtxtStory2.TabIndex = 18;
            this.rtxtStory2.Text = "";
            // 
            // rtxtStory3
            // 
            this.rtxtStory3.Location = new System.Drawing.Point(135, 315);
            this.rtxtStory3.Name = "rtxtStory3";
            this.rtxtStory3.Size = new System.Drawing.Size(100, 96);
            this.rtxtStory3.TabIndex = 19;
            this.rtxtStory3.Text = "";
            // 
            // rtxtTask2
            // 
            this.rtxtTask2.Location = new System.Drawing.Point(449, 188);
            this.rtxtTask2.Name = "rtxtTask2";
            this.rtxtTask2.Size = new System.Drawing.Size(100, 96);
            this.rtxtTask2.TabIndex = 20;
            this.rtxtTask2.Text = "";
            // 
            // rtxtTask3
            // 
            this.rtxtTask3.Location = new System.Drawing.Point(449, 315);
            this.rtxtTask3.Name = "rtxtTask3";
            this.rtxtTask3.Size = new System.Drawing.Size(100, 96);
            this.rtxtTask3.TabIndex = 21;
            this.rtxtTask3.Text = "";
            // 
            // rtxtTask4
            // 
            this.rtxtTask4.Location = new System.Drawing.Point(635, 315);
            this.rtxtTask4.Name = "rtxtTask4";
            this.rtxtTask4.Size = new System.Drawing.Size(100, 96);
            this.rtxtTask4.TabIndex = 22;
            this.rtxtTask4.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 472);
            this.Controls.Add(this.rtxtTask4);
            this.Controls.Add(this.rtxtTask3);
            this.Controls.Add(this.rtxtTask2);
            this.Controls.Add(this.rtxtStory3);
            this.Controls.Add(this.rtxtStory2);
            this.Controls.Add(this.rtxtTask1);
            this.Controls.Add(this.rtxtStory1);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.mlblTamamlanan);
            this.Controls.Add(this.mlblGelistirilen);
            this.Controls.Add(this.mlblBaslanan);
            this.Controls.Add(this.mlblStories);
            this.Controls.Add(this.mlstTamamlanan);
            this.Controls.Add(this.mlstGelistirilen);
            this.Controls.Add(this.mlstBaslanan);
            this.Controls.Add(this.mlstStories);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroListView mlstStories;
        private MetroFramework.Controls.MetroListView mlstBaslanan;
        private MetroFramework.Controls.MetroListView mlstGelistirilen;
        private MetroFramework.Controls.MetroListView mlstTamamlanan;
        private MetroFramework.Controls.MetroLabel mlblStories;
        private MetroFramework.Controls.MetroLabel mlblBaslanan;
        private MetroFramework.Controls.MetroLabel mlblGelistirilen;
        private MetroFramework.Controls.MetroLabel mlblTamamlanan;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.RichTextBox rtxtStory1;
        private System.Windows.Forms.RichTextBox rtxtTask1;
        private System.Windows.Forms.RichTextBox rtxtStory2;
        private System.Windows.Forms.RichTextBox rtxtStory3;
        private System.Windows.Forms.RichTextBox rtxtTask2;
        private System.Windows.Forms.RichTextBox rtxtTask3;
        private System.Windows.Forms.RichTextBox rtxtTask4;
    }
}

