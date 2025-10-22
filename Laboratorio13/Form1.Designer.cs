namespace Laboratorio13
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.ListBox lstProductos;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnConectar = new System.Windows.Forms.Button();
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(20, 20);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(260, 40);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Conectar y desconectar de SQL Server";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // lstProductos
            // 
            this.lstProductos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.ItemHeight = 17;
            this.lstProductos.Location = new System.Drawing.Point(20, 75);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(300, 242);
            this.lstProductos.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 340);
            this.Controls.Add(this.lstProductos);
            this.Controls.Add(this.btnConectar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratorio 13 - Northwind";
            this.ResumeLayout(false);
        }
    }
}
