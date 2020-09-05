namespace ClienteChat
{
    partial class FrmChat
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
            this.lstContactos = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstContactos
            // 
            this.lstContactos.FormattingEnabled = true;
            this.lstContactos.Location = new System.Drawing.Point(57, 76);
            this.lstContactos.Name = "lstContactos";
            this.lstContactos.Size = new System.Drawing.Size(244, 251);
            this.lstContactos.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "uygjuyguyguyyyyyyyyyyyyyyydsjdgoasdjksdfkasdfkljasdkadfsklsdafkjlasdfksdfakdfklas" +
                "kasdfksdfakasdfjkldsfajkasdfjkkasdfklsdafkadfkjlasdfjklasdfklasdfkasdfkladfsjkla" +
                "sdfjklasdfklljkasdklsadfljkdas",
            "\t1uygjuyguyguyyyyyyyyyyyyyyydsjdgoasdjksdfkasdfkljasdkadfsklsdafkjlasdfksdfakdfkl" +
                "askasdfksdfakasdfjkldsfajkasdfjkkasdfklsdafkadfkjlasdfjklasdfklasdfkasdfkladfsjk" +
                "lasdfjklasdfklljkasdklsadfljkdas",
            "2uygjuyguyguyyyyyyyyyyyyyyydsjdgoasdjksdfkasdfkljasdkadfsklsdafkjlasdfksdfakdfkla" +
                "skasdfksdfakasdfjkldsfajkasdfjkkasdfklsdafkadfkjlasdfjklasdfklasdfkasdfkladfsjkl" +
                "asdfjklasdfklljkasdklsadfljkdas",
            "\t3uygjuyguyguyyyyyyyyyyyyyyydsjdgoasdjksdfkasdfkljasdkadfsklsdafkjlasdfksdfakdfkl" +
                "askasdfksdfakasdfjkldsfajkasdfjkkasdfklsdafkadfkjlasdfjklasdfklasdfkasdfkladfsjk" +
                "lasdfjklasdfklljkasdklsadfljkdas"});
            this.listBox2.Location = new System.Drawing.Point(471, 76);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(271, 251);
            this.listBox2.TabIndex = 1;
            // 
            // FrmChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.lstContactos);
            this.Name = "FrmChat";
            this.Text = "FrmChat";
            this.Load += new System.EventHandler(this.FrmChat_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstContactos;
        private System.Windows.Forms.ListBox listBox2;
    }
}