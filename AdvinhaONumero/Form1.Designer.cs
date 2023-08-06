namespace AdvinhaONumero
{
    partial class frmPrincipal
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
            this.lblTexto = new MaterialSkin.Controls.MaterialLabel();
            this.txtNumero = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnVerificar = new Guna.UI2.WinForms.Guna2Button();
            this.nudNumero = new Guna.UI2.WinForms.Guna2NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Depth = 0;
            this.lblTexto.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTexto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTexto.Location = new System.Drawing.Point(39, 56);
            this.lblTexto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(274, 19);
            this.lblTexto.TabIndex = 0;
            this.lblTexto.Text = "Introduza um número inteiro de 0 à 100:";
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.Transparent;
            this.txtNumero.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(40)))));
            this.txtNumero.BorderRadius = 5;
            this.txtNumero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumero.DefaultText = "";
            this.txtNumero.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNumero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNumero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumero.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumero.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumero.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(40)))));
            this.txtNumero.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumero.Location = new System.Drawing.Point(315, 49);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumero.MaxLength = 3;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.PasswordChar = '\0';
            this.txtNumero.PlaceholderText = "";
            this.txtNumero.SelectedText = "";
            this.txtNumero.Size = new System.Drawing.Size(69, 31);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.Transparent;
            this.btnVerificar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(40)))));
            this.btnVerificar.BorderRadius = 5;
            this.btnVerificar.BorderThickness = 1;
            this.btnVerificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerificar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVerificar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVerificar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVerificar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVerificar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(40)))));
            this.btnVerificar.Font = new System.Drawing.Font("Roboto", 11F);
            this.btnVerificar.ForeColor = System.Drawing.Color.White;
            this.btnVerificar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(40)))));
            this.btnVerificar.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(40)))));
            this.btnVerificar.HoverState.FillColor = System.Drawing.Color.White;
            this.btnVerificar.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(40)))));
            this.btnVerificar.Location = new System.Drawing.Point(43, 96);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(40)))));
            this.btnVerificar.Size = new System.Drawing.Size(341, 31);
            this.btnVerificar.TabIndex = 2;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseTransparentBackground = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // nudNumero
            // 
            this.nudNumero.BackColor = System.Drawing.Color.Transparent;
            this.nudNumero.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(40)))));
            this.nudNumero.BorderRadius = 5;
            this.nudNumero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudNumero.Font = new System.Drawing.Font("Roboto", 11F);
            this.nudNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(40)))));
            this.nudNumero.Location = new System.Drawing.Point(315, 49);
            this.nudNumero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudNumero.Name = "nudNumero";
            this.nudNumero.Size = new System.Drawing.Size(69, 31);
            this.nudNumero.TabIndex = 3;
            this.nudNumero.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(40)))));
            this.nudNumero.UpDownButtonForeColor = System.Drawing.Color.White;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(437, 183);
            this.Controls.Add(this.nudNumero);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblTexto);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advinha o número";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTexto;
        private Guna.UI2.WinForms.Guna2TextBox txtNumero;
        private Guna.UI2.WinForms.Guna2Button btnVerificar;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudNumero;
    }
}

