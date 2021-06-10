namespace RSA_SCHEMA_Reciever
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
            this.StartReceiver = new System.Windows.Forms.Button();
            this.ReceivedTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckSignuture = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartReceiver
            // 
            this.StartReceiver.Location = new System.Drawing.Point(55, 26);
            this.StartReceiver.Name = "StartReceiver";
            this.StartReceiver.Size = new System.Drawing.Size(113, 23);
            this.StartReceiver.TabIndex = 0;
            this.StartReceiver.Text = "Start Receiving";
            this.StartReceiver.UseVisualStyleBackColor = true;
            this.StartReceiver.Click += new System.EventHandler(this.StartReceiver_Click);
            // 
            // ReceivedTextBox
            // 
            this.ReceivedTextBox.Location = new System.Drawing.Point(55, 93);
            this.ReceivedTextBox.Name = "ReceivedTextBox";
            this.ReceivedTextBox.Size = new System.Drawing.Size(226, 38);
            this.ReceivedTextBox.TabIndex = 1;
            this.ReceivedTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Received:";
            // 
            // CheckSignuture
            // 
            this.CheckSignuture.Location = new System.Drawing.Point(55, 150);
            this.CheckSignuture.Name = "CheckSignuture";
            this.CheckSignuture.Size = new System.Drawing.Size(100, 23);
            this.CheckSignuture.TabIndex = 3;
            this.CheckSignuture.Text = "Check Signuture";
            this.CheckSignuture.UseVisualStyleBackColor = true;
            this.CheckSignuture.Click += new System.EventHandler(this.CheckSignuture_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CheckSignuture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReceivedTextBox);
            this.Controls.Add(this.StartReceiver);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartReceiver;
        private System.Windows.Forms.RichTextBox ReceivedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CheckSignuture;
    }
}

