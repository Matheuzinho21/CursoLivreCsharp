namespace GerenciarPessoas
{
    partial class frmBuscaPessoas
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
            this.label1 = new System.Windows.Forms.Label();
            this.ltbPessoas = new System.Windows.Forms.ListBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descricao";
            // 
            // ltbPessoas
            // 
            this.ltbPessoas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbPessoas.FormattingEnabled = true;
            this.ltbPessoas.ItemHeight = 20;
            this.ltbPessoas.Location = new System.Drawing.Point(71, 142);
            this.ltbPessoas.Name = "ltbPessoas";
            this.ltbPessoas.Size = new System.Drawing.Size(492, 144);
            this.ltbPessoas.TabIndex = 1;
            this.ltbPessoas.SelectedIndexChanged += new System.EventHandler(this.ltbPessoas_SelectedIndexChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(598, 55);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(151, 88);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtDescriçao
            // 
            this.txtDescricao.FormattingEnabled = true;
            this.txtDescricao.Location = new System.Drawing.Point(71, 71);
            this.txtDescricao.Name = "txtDescriçao";
            this.txtDescricao.Size = new System.Drawing.Size(459, 21);
            this.txtDescricao.TabIndex = 3;
            this.txtDescricao.SelectedIndexChanged += new System.EventHandler(this.txtDescrição_SelectedIndexChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(598, 161);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(151, 88);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // frmBuscaPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.ltbPessoas);
            this.Controls.Add(this.label1);
            this.Name = "frmBuscaPessoas";
            this.Text = "frmBuscaPessoas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ltbPessoas;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox txtDescricao;
        private System.Windows.Forms.Button btnLimpar;
    }
}