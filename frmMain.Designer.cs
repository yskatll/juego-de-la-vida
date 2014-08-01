namespace Juego_de_la_Vida
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            this.btnBloque = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBarca = new System.Windows.Forms.Button();
            this.btnPortaa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tmrLoop = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIniciar.Image = ((System.Drawing.Image)(resources.GetObject("btnIniciar.Image")));
            this.btnIniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniciar.Location = new System.Drawing.Point(623, 12);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(85, 23);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetener.Enabled = false;
            this.btnDetener.Image = ((System.Drawing.Image)(resources.GetObject("btnDetener.Image")));
            this.btnDetener.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetener.Location = new System.Drawing.Point(623, 41);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(85, 23);
            this.btnDetener.TabIndex = 1;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // btnBloque
            // 
            this.btnBloque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBloque.Location = new System.Drawing.Point(623, 115);
            this.btnBloque.Name = "btnBloque";
            this.btnBloque.Size = new System.Drawing.Size(85, 23);
            this.btnBloque.TabIndex = 2;
            this.btnBloque.Text = "Bloque";
            this.btnBloque.UseVisualStyleBackColor = true;
            this.btnBloque.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(620, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Plantillas";
            this.label1.Visible = false;
            // 
            // btnBarca
            // 
            this.btnBarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBarca.Location = new System.Drawing.Point(623, 144);
            this.btnBarca.Name = "btnBarca";
            this.btnBarca.Size = new System.Drawing.Size(85, 23);
            this.btnBarca.TabIndex = 4;
            this.btnBarca.Text = "Barca";
            this.btnBarca.UseVisualStyleBackColor = true;
            this.btnBarca.Visible = false;
            // 
            // btnPortaa
            // 
            this.btnPortaa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPortaa.Location = new System.Drawing.Point(623, 173);
            this.btnPortaa.Name = "btnPortaa";
            this.btnPortaa.Size = new System.Drawing.Size(85, 23);
            this.btnPortaa.TabIndex = 5;
            this.btnPortaa.Text = "Portaaviones";
            this.btnPortaa.UseVisualStyleBackColor = true;
            this.btnPortaa.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(620, 525);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 65);
            this.label2.TabIndex = 6;
            this.label2.Text = "Desarrollado por:\r\nMiguel Izcatl\r\n\r\nPara:\r\nCrowd Interactive";
            // 
            // tmrLoop
            // 
            this.tmrLoop.Interval = 2000;
            this.tmrLoop.Tick += new System.EventHandler(this.tmrLoop_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 599);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPortaa);
            this.Controls.Add(this.btnBarca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBloque);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnIniciar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego de la Vida";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Button btnBloque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBarca;
        private System.Windows.Forms.Button btnPortaa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer tmrLoop;


    }
}

