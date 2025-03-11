namespace ControleEstoqueApp
{
    partial class FrmControleEstoque
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
            txtProduto = new TextBox();
            txtId = new TextBox();
            txtPreco = new TextBox();
            txtQuantidade = new TextBox();
            lblId = new Label();
            lblProduto = new Label();
            lblQuantidade = new Label();
            lblPreco = new Label();
            btnExcluir = new Button();
            btnSalvar = new Button();
            dtgEstoque = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgEstoque).BeginInit();
            SuspendLayout();
            // 
            // txtProduto
            // 
            txtProduto.Location = new Point(67, 35);
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(156, 23);
            txtProduto.TabIndex = 0;
            // 
            // txtId
            // 
            txtId.Location = new Point(12, 35);
            txtId.Name = "txtId";
            txtId.Size = new Size(49, 23);
            txtId.TabIndex = 1;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(229, 35);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(60, 23);
            txtPreco.TabIndex = 2;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(295, 35);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(60, 23);
            txtQuantidade.TabIndex = 3;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(12, 9);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 4;
            lblId.Text = "Id";
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Location = new Point(67, 9);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(50, 15);
            lblProduto.TabIndex = 5;
            lblProduto.Text = "Produto";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(295, 9);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(69, 15);
            lblQuantidade.TabIndex = 6;
            lblQuantidade.Text = "Quantidade";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(229, 9);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(37, 15);
            lblPreco.TabIndex = 7;
            lblPreco.Text = "Preço";
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(451, 35);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 8;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(370, 35);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // dtgEstoque
            // 
            dtgEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgEstoque.Location = new Point(12, 75);
            dtgEstoque.Name = "dtgEstoque";
            dtgEstoque.Size = new Size(514, 204);
            dtgEstoque.TabIndex = 10;
            dtgEstoque.CellDoubleClick += dtgEstoque_CellDoubleClick;
            // 
            // FrmControleEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 291);
            Controls.Add(dtgEstoque);
            Controls.Add(btnSalvar);
            Controls.Add(btnExcluir);
            Controls.Add(lblPreco);
            Controls.Add(lblQuantidade);
            Controls.Add(lblProduto);
            Controls.Add(lblId);
            Controls.Add(txtQuantidade);
            Controls.Add(txtPreco);
            Controls.Add(txtId);
            Controls.Add(txtProduto);
            Name = "FrmControleEstoque";
            Text = "Form1";
            Load += FrmControleEstoque_Load;
            ((System.ComponentModel.ISupportInitialize)dtgEstoque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProduto;
        private TextBox txtId;
        private TextBox txtPreco;
        private TextBox txtQuantidade;
        private Label lblId;
        private Label lblProduto;
        private Label lblQuantidade;
        private Label lblPreco;
        private Button btnExcluir;
        private Button btnSalvar;
        private DataGridView dtgEstoque;
    }
}
