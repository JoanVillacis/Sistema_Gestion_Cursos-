namespace Gestion_Cursos
{
    partial class frm_login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btn_Cancelar = new Button();
            label3 = new Label();
            label2 = new Label();
            txt_Pwd = new TextBox();
            btn_Login = new Button();
            txt_Correo = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.user_icon_icons_com_57997;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(110, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(114, 110);
            panel1.TabIndex = 30;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = Color.FromArgb(0, 180, 216);
            btn_Cancelar.ForeColor = Color.White;
            btn_Cancelar.Location = new Point(176, 381);
            btn_Cancelar.Margin = new Padding(5);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(153, 45);
            btn_Cancelar.TabIndex = 26;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(3, 4, 94);
            label3.Location = new Point(41, 268);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(139, 32);
            label3.TabIndex = 29;
            label3.Text = "Contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(3, 4, 94);
            label2.Location = new Point(41, 164);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(91, 32);
            label2.TabIndex = 28;
            label2.Text = "Correo:";
            // 
            // txt_Pwd
            // 
            txt_Pwd.Location = new Point(41, 305);
            txt_Pwd.Margin = new Padding(5);
            txt_Pwd.Name = "txt_Pwd";
            txt_Pwd.PasswordChar = '*';
            txt_Pwd.Size = new Size(262, 39);
            txt_Pwd.TabIndex = 24;
            txt_Pwd.Leave += txt_Pwd_Leave;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.FromArgb(0, 119, 182);
            btn_Login.ForeColor = Color.White;
            btn_Login.Location = new Point(13, 381);
            btn_Login.Margin = new Padding(5);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(153, 45);
            btn_Login.TabIndex = 25;
            btn_Login.Text = "Iniciar";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // txt_Correo
            // 
            txt_Correo.Location = new Point(41, 201);
            txt_Correo.Margin = new Padding(5);
            txt_Correo.Name = "txt_Correo";
            txt_Correo.Size = new Size(262, 39);
            txt_Correo.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(3, 4, 94);
            label1.Location = new Point(83, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(182, 32);
            label1.TabIndex = 27;
            label1.Text = "Inicio de Sesion";
            // 
            // frm_login
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(202, 240, 248);
            ClientSize = new Size(342, 440);
            Controls.Add(panel1);
            Controls.Add(btn_Cancelar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_Pwd);
            Controls.Add(btn_Login);
            Controls.Add(txt_Correo);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            MinimizeBox = false;
            Name = "frm_login";
            ShowIcon = false;
            Text = "Inicio de Sesión";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btn_Cancelar;
        private Label label3;
        private Label label2;
        private TextBox txt_Pwd;
        private Button btn_Login;
        private TextBox txt_Correo;
        private Label label1;
    }
}
