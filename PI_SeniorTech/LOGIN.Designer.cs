
namespace PI_SeniorTech
{
    partial class LOGIN
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUSUARIO = new System.Windows.Forms.TextBox();
            this.textBoxSENHA = new System.Windows.Forms.TextBox();
            this.btConectar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(368, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUÁRIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(377, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "SENHA";
            // 
            // textBoxUSUARIO
            // 
            this.textBoxUSUARIO.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUSUARIO.Location = new System.Drawing.Point(337, 65);
            this.textBoxUSUARIO.Name = "textBoxUSUARIO";
            this.textBoxUSUARIO.Size = new System.Drawing.Size(150, 29);
            this.textBoxUSUARIO.TabIndex = 1;
            // 
            // textBoxSENHA
            // 
            this.textBoxSENHA.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSENHA.Location = new System.Drawing.Point(337, 146);
            this.textBoxSENHA.Name = "textBoxSENHA";
            this.textBoxSENHA.PasswordChar = '*';
            this.textBoxSENHA.Size = new System.Drawing.Size(150, 29);
            this.textBoxSENHA.TabIndex = 3;
            // 
            // btConectar
            // 
            this.btConectar.BackColor = System.Drawing.Color.LimeGreen;
            this.btConectar.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConectar.ForeColor = System.Drawing.Color.White;
            this.btConectar.Location = new System.Drawing.Point(337, 207);
            this.btConectar.Name = "btConectar";
            this.btConectar.Size = new System.Drawing.Size(150, 50);
            this.btConectar.TabIndex = 4;
            this.btConectar.Text = "CONECTAR";
            this.btConectar.UseVisualStyleBackColor = false;
            this.btConectar.Click += new System.EventHandler(this.btConectar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 309);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.LimeGreen;
            this.btCadastrar.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.ForeColor = System.Drawing.Color.White;
            this.btCadastrar.Location = new System.Drawing.Point(337, 285);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(150, 47);
            this.btCadastrar.TabIndex = 5;
            this.btCadastrar.Text = "CADASTRAR";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.LimeGreen;
            this.btSair.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.ForeColor = System.Drawing.Color.White;
            this.btSair.Location = new System.Drawing.Point(337, 355);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(150, 47);
            this.btSair.TabIndex = 6;
            this.btSair.Text = "SAIR";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(515, 423);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btConectar);
            this.Controls.Add(this.textBoxSENHA);
            this.Controls.Add(this.textBoxUSUARIO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LOGIN";
            this.ShowIcon = false;
            this.Text = "LOGIN";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Load += new System.EventHandler(this.LOGIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUSUARIO;
        private System.Windows.Forms.TextBox textBoxSENHA;
        private System.Windows.Forms.Button btConectar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btSair;
    }
}

