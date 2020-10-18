namespace Login_JW
{
    partial class LOGIN
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            this.titulo = new System.Windows.Forms.Panel();
            this.botonMinimizar = new System.Windows.Forms.PictureBox();
            this.botonCerrar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.intUsusario = new System.Windows.Forms.TextBox();
            this.botonAcceder = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.intContraceña = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.BackColor = System.Drawing.Color.SlateGray;
            this.titulo.Controls.Add(this.botonMinimizar);
            this.titulo.Controls.Add(this.botonCerrar);
            this.titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.titulo.Location = new System.Drawing.Point(0, 0);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(303, 29);
            this.titulo.TabIndex = 0;
            this.titulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titulo_MouseMove);
            // 
            // botonMinimizar
            // 
            this.botonMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("botonMinimizar.Image")));
            this.botonMinimizar.Location = new System.Drawing.Point(229, 0);
            this.botonMinimizar.Name = "botonMinimizar";
            this.botonMinimizar.Size = new System.Drawing.Size(30, 29);
            this.botonMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonMinimizar.TabIndex = 2;
            this.botonMinimizar.TabStop = false;
            this.botonMinimizar.Click += new System.EventHandler(this.botonMinimizar_Click);
            // 
            // botonCerrar
            // 
            this.botonCerrar.Image = ((System.Drawing.Image)(resources.GetObject("botonCerrar.Image")));
            this.botonCerrar.Location = new System.Drawing.Point(256, -2);
            this.botonCerrar.Name = "botonCerrar";
            this.botonCerrar.Size = new System.Drawing.Size(41, 31);
            this.botonCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonCerrar.TabIndex = 0;
            this.botonCerrar.TabStop = false;
            this.botonCerrar.Click += new System.EventHandler(this.botonCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 459);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 10);
            this.panel1.TabIndex = 1;
            // 
            // intUsusario
            // 
            this.intUsusario.BackColor = System.Drawing.Color.Black;
            this.intUsusario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.intUsusario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intUsusario.ForeColor = System.Drawing.Color.DarkGray;
            this.intUsusario.Location = new System.Drawing.Point(40, 185);
            this.intUsusario.Name = "intUsusario";
            this.intUsusario.Size = new System.Drawing.Size(219, 18);
            this.intUsusario.TabIndex = 1;
            this.intUsusario.Text = "USUARIO";
            this.intUsusario.Enter += new System.EventHandler(this.intUsusario_Enter);
            this.intUsusario.Leave += new System.EventHandler(this.intUsusario_Leave);
            // 
            // botonAcceder
            // 
            this.botonAcceder.BackColor = System.Drawing.Color.SlateGray;
            this.botonAcceder.FlatAppearance.BorderSize = 0;
            this.botonAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAcceder.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAcceder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonAcceder.Location = new System.Drawing.Point(42, 323);
            this.botonAcceder.Name = "botonAcceder";
            this.botonAcceder.Size = new System.Drawing.Size(219, 38);
            this.botonAcceder.TabIndex = 3;
            this.botonAcceder.Text = "ACCEDER";
            this.botonAcceder.UseVisualStyleBackColor = false;
            this.botonAcceder.Click += new System.EventHandler(this.botonAcceder_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape3,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(303, 469);
            this.shapeContainer1.TabIndex = 7;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 39;
            this.lineShape2.X2 = 256;
            this.lineShape2.Y1 = 252;
            this.lineShape2.Y2 = 252;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lineShape3.Enabled = false;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 39;
            this.lineShape3.X2 = 256;
            this.lineShape3.Y1 = 203;
            this.lineShape3.Y2 = 203;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 1;
            this.lineShape1.X2 = 302;
            this.lineShape1.Y1 = 405;
            this.lineShape1.Y2 = 405;
            // 
            // intContraceña
            // 
            this.intContraceña.BackColor = System.Drawing.Color.Black;
            this.intContraceña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.intContraceña.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intContraceña.ForeColor = System.Drawing.Color.DarkGray;
            this.intContraceña.Location = new System.Drawing.Point(40, 232);
            this.intContraceña.Name = "intContraceña";
            this.intContraceña.Size = new System.Drawing.Size(219, 18);
            this.intContraceña.TabIndex = 2;
            this.intContraceña.Text = "CONTRACEÑA";
            this.intContraceña.Enter += new System.EventHandler(this.intContraceña_Enter);
            this.intContraceña.Leave += new System.EventHandler(this.intContraceña_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Ink Free", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label2.Location = new System.Drawing.Point(59, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 118);
            this.label2.TabIndex = 10;
            this.label2.Text = "JW";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label1.Location = new System.Drawing.Point(123, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "LOGIN";
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(303, 469);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.intContraceña);
            this.Controls.Add(this.botonAcceder);
            this.Controls.Add(this.intUsusario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "LOGIN";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.botonMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel titulo;
        private System.Windows.Forms.PictureBox botonMinimizar;
        private System.Windows.Forms.PictureBox botonCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox intUsusario;
        private System.Windows.Forms.Button botonAcceder;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox intContraceña;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

