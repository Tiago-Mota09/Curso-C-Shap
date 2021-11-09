
namespace Componentes02
{
    partial class F_ComboBox
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
            this.cb_transportes = new System.Windows.Forms.ComboBox();
            this.btn_mostrarSelecionado = new System.Windows.Forms.Button();
            this.btn_limparElementos = new System.Windows.Forms.Button();
            this.btn_resetarElementos = new System.Windows.Forms.Button();
            this.tb_transport = new System.Windows.Forms.TextBox();
            this.btn_adicionarNovoTransporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_transportes
            // 
            this.cb_transportes.FormattingEnabled = true;
            this.cb_transportes.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "Ônibus",
            "Trem"});
            this.cb_transportes.Location = new System.Drawing.Point(27, 46);
            this.cb_transportes.Name = "cb_transportes";
            this.cb_transportes.Size = new System.Drawing.Size(204, 21);
            this.cb_transportes.TabIndex = 0;
            this.cb_transportes.SelectedIndexChanged += new System.EventHandler(this.cb_transportes_SelectedIndexChanged);
            // 
            // btn_mostrarSelecionado
            // 
            this.btn_mostrarSelecionado.Location = new System.Drawing.Point(237, 44);
            this.btn_mostrarSelecionado.Name = "btn_mostrarSelecionado";
            this.btn_mostrarSelecionado.Size = new System.Drawing.Size(200, 23);
            this.btn_mostrarSelecionado.TabIndex = 1;
            this.btn_mostrarSelecionado.Text = "Mostar Selecionado";
            this.btn_mostrarSelecionado.UseVisualStyleBackColor = true;
            this.btn_mostrarSelecionado.Click += new System.EventHandler(this.btn_mostrarSelecionado_Click);
            // 
            // btn_limparElementos
            // 
            this.btn_limparElementos.Location = new System.Drawing.Point(237, 74);
            this.btn_limparElementos.Name = "btn_limparElementos";
            this.btn_limparElementos.Size = new System.Drawing.Size(200, 23);
            this.btn_limparElementos.TabIndex = 2;
            this.btn_limparElementos.Text = "Limpar elemento";
            this.btn_limparElementos.UseVisualStyleBackColor = true;
            this.btn_limparElementos.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_resetarElementos
            // 
            this.btn_resetarElementos.Location = new System.Drawing.Point(240, 106);
            this.btn_resetarElementos.Name = "btn_resetarElementos";
            this.btn_resetarElementos.Size = new System.Drawing.Size(197, 23);
            this.btn_resetarElementos.TabIndex = 3;
            this.btn_resetarElementos.Text = "Resetar elementos";
            this.btn_resetarElementos.UseVisualStyleBackColor = true;
            this.btn_resetarElementos.Click += new System.EventHandler(this.btn_resetarElementos_Click);
            // 
            // tb_transport
            // 
            this.tb_transport.Location = new System.Drawing.Point(240, 154);
            this.tb_transport.Name = "tb_transport";
            this.tb_transport.Size = new System.Drawing.Size(196, 20);
            this.tb_transport.TabIndex = 4;
            // 
            // btn_adicionarNovoTransporte
            // 
            this.btn_adicionarNovoTransporte.Location = new System.Drawing.Point(240, 185);
            this.btn_adicionarNovoTransporte.Name = "btn_adicionarNovoTransporte";
            this.btn_adicionarNovoTransporte.Size = new System.Drawing.Size(196, 23);
            this.btn_adicionarNovoTransporte.TabIndex = 5;
            this.btn_adicionarNovoTransporte.Text = "Adicionar Novo Transporte";
            this.btn_adicionarNovoTransporte.UseVisualStyleBackColor = true;
            this.btn_adicionarNovoTransporte.Click += new System.EventHandler(this.btn_adicionarNovoTransporte_Click);
            // 
            // F_ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 450);
            this.Controls.Add(this.btn_adicionarNovoTransporte);
            this.Controls.Add(this.tb_transport);
            this.Controls.Add(this.btn_resetarElementos);
            this.Controls.Add(this.btn_limparElementos);
            this.Controls.Add(this.btn_mostrarSelecionado);
            this.Controls.Add(this.cb_transportes);
            this.Name = "F_ComboBox";
            this.Text = "F_ComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_transportes;
        private System.Windows.Forms.Button btn_mostrarSelecionado;
        private System.Windows.Forms.Button btn_limparElementos;
        private System.Windows.Forms.Button btn_resetarElementos;
        private System.Windows.Forms.TextBox tb_transport;
        private System.Windows.Forms.Button btn_adicionarNovoTransporte;
    }
}