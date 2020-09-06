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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChat));
            this.lstContactos = new System.Windows.Forms.ListBox();
            this.lstMensajes = new System.Windows.Forms.ListBox();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.btnEnviar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddContact = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // lstContactos
            // 
            this.lstContactos.FormattingEnabled = true;
            this.lstContactos.Location = new System.Drawing.Point(14, 28);
            this.lstContactos.Name = "lstContactos";
            this.lstContactos.Size = new System.Drawing.Size(161, 238);
            this.lstContactos.TabIndex = 0;
            this.lstContactos.SelectedIndexChanged += new System.EventHandler(this.lstContactos_SelectedIndexChanged);
            // 
            // lstMensajes
            // 
            this.lstMensajes.FormattingEnabled = true;
            this.lstMensajes.Location = new System.Drawing.Point(190, 28);
            this.lstMensajes.Name = "lstMensajes";
            this.lstMensajes.Size = new System.Drawing.Size(598, 238);
            this.lstMensajes.TabIndex = 1;
            this.lstMensajes.SelectedIndexChanged += new System.EventHandler(this.lstMensajes_SelectedIndexChanged);
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(190, 272);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(351, 48);
            this.txtMensaje.TabIndex = 2;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnviar.BorderRadius = 0;
            this.btnEnviar.ButtonText = "Enviar";
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.DisabledColor = System.Drawing.Color.Gray;
            this.btnEnviar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEnviar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEnviar.Iconimage")));
            this.btnEnviar.Iconimage_right = null;
            this.btnEnviar.Iconimage_right_Selected = null;
            this.btnEnviar.Iconimage_Selected = null;
            this.btnEnviar.IconMarginLeft = 0;
            this.btnEnviar.IconMarginRight = 0;
            this.btnEnviar.IconRightVisible = true;
            this.btnEnviar.IconRightZoom = 0D;
            this.btnEnviar.IconVisible = true;
            this.btnEnviar.IconZoom = 90D;
            this.btnEnviar.IsTab = false;
            this.btnEnviar.Location = new System.Drawing.Point(547, 272);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEnviar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnEnviar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEnviar.selected = false;
            this.btnEnviar.Size = new System.Drawing.Size(241, 48);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnviar.Textcolor = System.Drawing.Color.White;
            this.btnEnviar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnAddContact
            // 
            this.btnAddContact.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddContact.BorderRadius = 0;
            this.btnAddContact.ButtonText = "Añadir Contacto";
            this.btnAddContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddContact.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddContact.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddContact.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddContact.Iconimage")));
            this.btnAddContact.Iconimage_right = null;
            this.btnAddContact.Iconimage_right_Selected = null;
            this.btnAddContact.Iconimage_Selected = null;
            this.btnAddContact.IconMarginLeft = 0;
            this.btnAddContact.IconMarginRight = 0;
            this.btnAddContact.IconRightVisible = true;
            this.btnAddContact.IconRightZoom = 0D;
            this.btnAddContact.IconVisible = true;
            this.btnAddContact.IconZoom = 90D;
            this.btnAddContact.IsTab = false;
            this.btnAddContact.Location = new System.Drawing.Point(14, 272);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddContact.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAddContact.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddContact.selected = false;
            this.btnAddContact.Size = new System.Drawing.Size(161, 48);
            this.btnAddContact.TabIndex = 4;
            this.btnAddContact.Text = "Añadir Contacto";
            this.btnAddContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddContact.Textcolor = System.Drawing.Color.White;
            this.btnAddContact.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // FrmChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddContact);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.lstMensajes);
            this.Controls.Add(this.lstContactos);
            this.Name = "FrmChat";
            this.Text = "FrmChat";
            this.Load += new System.EventHandler(this.FrmChat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstContactos;
        private System.Windows.Forms.ListBox lstMensajes;
        private System.Windows.Forms.TextBox txtMensaje;
        private Bunifu.Framework.UI.BunifuFlatButton btnEnviar;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddContact;
    }
}