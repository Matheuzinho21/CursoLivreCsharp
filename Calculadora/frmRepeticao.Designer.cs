namespace Calculadora
{
    partial class frmRepeticao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRepeticao));
            this.cbbCategorias = new System.Windows.Forms.ComboBox();
            this.lblCategorias = new System.Windows.Forms.Label();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.ltbCategorias = new System.Windows.Forms.ListBox();
            this.lblListarCategorias = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbbCategorias
            // 
            this.cbbCategorias.FormattingEnabled = true;
            this.cbbCategorias.Location = new System.Drawing.Point(73, 53);
            this.cbbCategorias.Name = "cbbCategorias";
            this.cbbCategorias.Size = new System.Drawing.Size(121, 21);
            this.cbbCategorias.TabIndex = 0;
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.Location = new System.Drawing.Point(70, 27);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(57, 13);
            this.lblCategorias.TabIndex = 1;
            this.lblCategorias.Text = "Categorias";
            // 
            // btnCategorias
            // 
            this.btnCategorias.Location = new System.Drawing.Point(73, 330);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(166, 52);
            this.btnCategorias.TabIndex = 2;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // ltbCategorias
            // 
            this.ltbCategorias.FormattingEnabled = true;
            this.ltbCategorias.Location = new System.Drawing.Point(521, 112);
            this.ltbCategorias.Name = "ltbCategorias";
            this.ltbCategorias.Size = new System.Drawing.Size(223, 238);
            this.ltbCategorias.TabIndex = 3;
            this.ltbCategorias.SelectedIndexChanged += new System.EventHandler(this.ltbCategorias_SelectedIndexChanged);
            // 
            // lblListarCategorias
            // 
            this.lblListarCategorias.Location = new System.Drawing.Point(546, 360);
            this.lblListarCategorias.Name = "lblListarCategorias";
            this.lblListarCategorias.Size = new System.Drawing.Size(151, 58);
            this.lblListarCategorias.TabIndex = 4;
            this.lblListarCategorias.Text = "Listar Categorias";
            this.lblListarCategorias.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(543, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Listar Categorias";
            // 
            // frmRepeticao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblListarCategorias);
            this.Controls.Add(this.ltbCategorias);
            this.Controls.Add(this.btnCategorias);
            this.Controls.Add(this.lblCategorias);
            this.Controls.Add(this.cbbCategorias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRepeticao";
            this.Text = "Repetição";
            this.Load += new System.EventHandler(this.frmRepeticao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbCategorias;
        private System.Windows.Forms.Label lblCategorias;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.ListBox ltbCategorias;
        private System.Windows.Forms.Button lblListarCategorias;
        private System.Windows.Forms.Label label1;
    }
}