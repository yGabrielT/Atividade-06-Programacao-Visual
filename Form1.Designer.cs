namespace Atividade_05
{
    partial class Form1
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
            this.grpEntrada = new System.Windows.Forms.GroupBox();
            this.lstItensPedido = new System.Windows.Forms.ListBox();
            this.grpOpcoes = new System.Windows.Forms.GroupBox();
            this.chkCupom = new System.Windows.Forms.CheckBox();
            this.chkPresente = new System.Windows.Forms.CheckBox();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.grpEntrega = new System.Windows.Forms.GroupBox();
            this.rdbEntrega = new System.Windows.Forms.RadioButton();
            this.rdbRetirada = new System.Windows.Forms.RadioButton();
            this.btnAdicionarItem = new System.Windows.Forms.Button();
            this.grpResumo = new System.Windows.Forms.GroupBox();
            this.lblResumo = new System.Windows.Forms.Label();
            this.lblProtocolo = new System.Windows.Forms.Label();
            this.lblDataHora = new System.Windows.Forms.Label();
            this.brnGerarPedido = new System.Windows.Forms.Button();
            this.btnGerarNovoPedido = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.grpEntrada.SuspendLayout();
            this.grpOpcoes.SuspendLayout();
            this.grpEntrega.SuspendLayout();
            this.grpResumo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pedido Simples";
            // 
            // grpEntrada
            // 
            this.grpEntrada.Controls.Add(this.btnAdicionarItem);
            this.grpEntrada.Controls.Add(this.grpEntrega);
            this.grpEntrada.Controls.Add(this.lstItensPedido);
            this.grpEntrada.Controls.Add(this.grpOpcoes);
            this.grpEntrada.Controls.Add(this.cmbProduto);
            this.grpEntrada.Controls.Add(this.txtQuantidade);
            this.grpEntrada.Controls.Add(this.txtCliente);
            this.grpEntrada.Controls.Add(this.lblQuantidade);
            this.grpEntrada.Controls.Add(this.lblProduto);
            this.grpEntrada.Controls.Add(this.lblCliente);
            this.grpEntrada.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEntrada.Location = new System.Drawing.Point(12, 36);
            this.grpEntrada.Name = "grpEntrada";
            this.grpEntrada.Size = new System.Drawing.Size(360, 464);
            this.grpEntrada.TabIndex = 1;
            this.grpEntrada.TabStop = false;
            this.grpEntrada.Text = "Entrada de Dados";
            // 
            // lstItensPedido
            // 
            this.lstItensPedido.FormattingEnabled = true;
            this.lstItensPedido.ItemHeight = 18;
            this.lstItensPedido.Location = new System.Drawing.Point(9, 331);
            this.lstItensPedido.Name = "lstItensPedido";
            this.lstItensPedido.Size = new System.Drawing.Size(319, 76);
            this.lstItensPedido.TabIndex = 3;
            // 
            // grpOpcoes
            // 
            this.grpOpcoes.Controls.Add(this.chkCupom);
            this.grpOpcoes.Controls.Add(this.chkPresente);
            this.grpOpcoes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOpcoes.Location = new System.Drawing.Point(9, 233);
            this.grpOpcoes.Name = "grpOpcoes";
            this.grpOpcoes.Size = new System.Drawing.Size(319, 91);
            this.grpOpcoes.TabIndex = 1;
            this.grpOpcoes.TabStop = false;
            this.grpOpcoes.Text = "Opções Adicionais";
            // 
            // chkCupom
            // 
            this.chkCupom.AutoSize = true;
            this.chkCupom.Location = new System.Drawing.Point(6, 53);
            this.chkCupom.Name = "chkCupom";
            this.chkCupom.Size = new System.Drawing.Size(237, 22);
            this.chkCupom.TabIndex = 0;
            this.chkCupom.Text = "Aplicar Cumpom de Desconto";
            this.chkCupom.UseVisualStyleBackColor = true;
            // 
            // chkPresente
            // 
            this.chkPresente.AutoSize = true;
            this.chkPresente.Location = new System.Drawing.Point(6, 25);
            this.chkPresente.Name = "chkPresente";
            this.chkPresente.Size = new System.Drawing.Size(215, 22);
            this.chkPresente.TabIndex = 0;
            this.chkPresente.Text = "Embalagem para Presente";
            this.chkPresente.UseVisualStyleBackColor = true;
            // 
            // cmbProduto
            // 
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Items.AddRange(new object[] {
            "Laptop",
            "Teclado",
            "Mouse",
            "Impressora",
            "Retirada na Loja",
            "Entrega Na Loja",
            "Entrega Expressa"});
            this.cmbProduto.Location = new System.Drawing.Point(101, 78);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(227, 26);
            this.cmbProduto.TabIndex = 2;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(101, 121);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(227, 26);
            this.txtQuantidade.TabIndex = 1;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(101, 40);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(227, 26);
            this.txtCliente.TabIndex = 1;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(6, 124);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(93, 18);
            this.lblQuantidade.TabIndex = 0;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(6, 82);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(67, 18);
            this.lblProduto.TabIndex = 0;
            this.lblProduto.Text = "Produto:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(6, 43);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(61, 18);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente:";
            // 
            // grpEntrega
            // 
            this.grpEntrega.Controls.Add(this.rdbEntrega);
            this.grpEntrega.Controls.Add(this.rdbRetirada);
            this.grpEntrega.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEntrega.Location = new System.Drawing.Point(9, 164);
            this.grpEntrega.Name = "grpEntrega";
            this.grpEntrega.Size = new System.Drawing.Size(319, 63);
            this.grpEntrega.TabIndex = 1;
            this.grpEntrega.TabStop = false;
            this.grpEntrega.Text = "Tipo de Entrega";
            // 
            // rdbEntrega
            // 
            this.rdbEntrega.AutoSize = true;
            this.rdbEntrega.Location = new System.Drawing.Point(98, 25);
            this.rdbEntrega.Name = "rdbEntrega";
            this.rdbEntrega.Size = new System.Drawing.Size(81, 22);
            this.rdbEntrega.TabIndex = 0;
            this.rdbEntrega.TabStop = true;
            this.rdbEntrega.Text = "Entrada";
            this.rdbEntrega.UseVisualStyleBackColor = true;
            // 
            // rdbRetirada
            // 
            this.rdbRetirada.AutoSize = true;
            this.rdbRetirada.Location = new System.Drawing.Point(6, 25);
            this.rdbRetirada.Name = "rdbRetirada";
            this.rdbRetirada.Size = new System.Drawing.Size(86, 22);
            this.rdbRetirada.TabIndex = 0;
            this.rdbRetirada.TabStop = true;
            this.rdbRetirada.Text = "Retirada";
            this.rdbRetirada.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarItem
            // 
            this.btnAdicionarItem.Location = new System.Drawing.Point(9, 413);
            this.btnAdicionarItem.Name = "btnAdicionarItem";
            this.btnAdicionarItem.Size = new System.Drawing.Size(319, 36);
            this.btnAdicionarItem.TabIndex = 4;
            this.btnAdicionarItem.Text = "Adicionar Item";
            this.btnAdicionarItem.UseVisualStyleBackColor = true;
            // 
            // grpResumo
            // 
            this.grpResumo.Controls.Add(this.lblDataHora);
            this.grpResumo.Controls.Add(this.lblProtocolo);
            this.grpResumo.Controls.Add(this.lblResumo);
            this.grpResumo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpResumo.Location = new System.Drawing.Point(378, 36);
            this.grpResumo.Name = "grpResumo";
            this.grpResumo.Size = new System.Drawing.Size(362, 464);
            this.grpResumo.TabIndex = 2;
            this.grpResumo.TabStop = false;
            this.grpResumo.Text = "Resumo do Pedido";
            // 
            // lblResumo
            // 
            this.lblResumo.AutoSize = true;
            this.lblResumo.Location = new System.Drawing.Point(6, 40);
            this.lblResumo.Name = "lblResumo";
            this.lblResumo.Size = new System.Drawing.Size(63, 18);
            this.lblResumo.TabIndex = 0;
            this.lblResumo.Text = "Pedido:";
            // 
            // lblProtocolo
            // 
            this.lblProtocolo.AutoSize = true;
            this.lblProtocolo.Location = new System.Drawing.Point(6, 129);
            this.lblProtocolo.Name = "lblProtocolo";
            this.lblProtocolo.Size = new System.Drawing.Size(119, 18);
            this.lblProtocolo.TabIndex = 0;
            this.lblProtocolo.Text = "Protocolo: 0000";
            // 
            // lblDataHora
            // 
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.Location = new System.Drawing.Point(6, 147);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(97, 18);
            this.lblDataHora.TabIndex = 0;
            this.lblDataHora.Text = "Data e Hora:";
            // 
            // brnGerarPedido
            // 
            this.brnGerarPedido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnGerarPedido.Location = new System.Drawing.Point(12, 530);
            this.brnGerarPedido.Name = "brnGerarPedido";
            this.brnGerarPedido.Size = new System.Drawing.Size(240, 36);
            this.brnGerarPedido.TabIndex = 4;
            this.brnGerarPedido.Text = "Gerar Pedido";
            this.brnGerarPedido.UseVisualStyleBackColor = true;
            this.brnGerarPedido.Click += new System.EventHandler(this.brnGerarPedido_Click);
            // 
            // btnGerarNovoPedido
            // 
            this.btnGerarNovoPedido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarNovoPedido.Location = new System.Drawing.Point(258, 530);
            this.btnGerarNovoPedido.Name = "btnGerarNovoPedido";
            this.btnGerarNovoPedido.Size = new System.Drawing.Size(240, 36);
            this.btnGerarNovoPedido.TabIndex = 4;
            this.btnGerarNovoPedido.Text = "Gerar Novo Pedido";
            this.btnGerarNovoPedido.UseVisualStyleBackColor = true;
            this.btnGerarNovoPedido.Click += new System.EventHandler(this.btnGerarNovoPedido_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(504, 530);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(240, 36);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 578);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGerarNovoPedido);
            this.Controls.Add(this.brnGerarPedido);
            this.Controls.Add(this.grpResumo);
            this.Controls.Add(this.grpEntrada);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pedido Simples";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpEntrada.ResumeLayout(false);
            this.grpEntrada.PerformLayout();
            this.grpOpcoes.ResumeLayout(false);
            this.grpOpcoes.PerformLayout();
            this.grpEntrega.ResumeLayout(false);
            this.grpEntrega.PerformLayout();
            this.grpResumo.ResumeLayout(false);
            this.grpResumo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpEntrada;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.GroupBox grpEntrega;
        private System.Windows.Forms.RadioButton rdbRetirada;
        private System.Windows.Forms.RadioButton rdbEntrega;
        private System.Windows.Forms.GroupBox grpOpcoes;
        private System.Windows.Forms.CheckBox chkCupom;
        private System.Windows.Forms.CheckBox chkPresente;
        private System.Windows.Forms.ListBox lstItensPedido;
        private System.Windows.Forms.Button btnAdicionarItem;
        private System.Windows.Forms.GroupBox grpResumo;
        private System.Windows.Forms.Label lblResumo;
        private System.Windows.Forms.Label lblDataHora;
        private System.Windows.Forms.Label lblProtocolo;
        private System.Windows.Forms.Button brnGerarPedido;
        private System.Windows.Forms.Button btnGerarNovoPedido;
        private System.Windows.Forms.Button btnSair;
    }
}

