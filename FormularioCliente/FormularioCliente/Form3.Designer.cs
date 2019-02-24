namespace FormularioCliente
{
    partial class Inicial
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
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnManipularClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(72, 132);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(240, 48);
            this.btnCadastro.TabIndex = 0;
            this.btnCadastro.Text = "Cadastrar cliente";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnManipularClientes
            // 
            this.btnManipularClientes.Location = new System.Drawing.Point(72, 186);
            this.btnManipularClientes.Name = "btnManipularClientes";
            this.btnManipularClientes.Size = new System.Drawing.Size(240, 49);
            this.btnManipularClientes.TabIndex = 1;
            this.btnManipularClientes.Text = "Excluir/ Alterar clientes";
            this.btnManipularClientes.UseVisualStyleBackColor = true;
            this.btnManipularClientes.Click += new System.EventHandler(this.btnManipular_Click);
            // 
            // Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 351);
            this.Controls.Add(this.btnManipularClientes);
            this.Controls.Add(this.btnCadastro);
            this.Name = "Inicial";
            this.Text = "Página inicial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnManipularClientes;
    }
}