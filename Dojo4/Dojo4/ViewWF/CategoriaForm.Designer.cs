
namespace ViewWF
{
    partial class CategoriaForm
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.lbMensagem = new System.Windows.Forms.Label();
            this.dgCategorias = new System.Windows.Forms.DataGridView();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dlEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clDeletar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(284, 44);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(182, 25);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Cadastro Categoria";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(99, 115);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(22, 13);
            this.lbId.TabIndex = 1;
            this.lbId.Text = "Id :";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(80, 153);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(41, 13);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Nome :";
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Location = new System.Drawing.Point(60, 193);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(61, 13);
            this.lbDescricao.TabIndex = 3;
            this.lbDescricao.Text = "Descrição :";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(118, 112);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(175, 20);
            this.tbId.TabIndex = 4;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(118, 150);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(175, 20);
            this.tbNome.TabIndex = 5;
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(118, 190);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(175, 20);
            this.tbDescricao.TabIndex = 6;
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(118, 240);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 7;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(218, 240);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 8;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // lbMensagem
            // 
            this.lbMensagem.AutoSize = true;
            this.lbMensagem.ForeColor = System.Drawing.Color.Green;
            this.lbMensagem.Location = new System.Drawing.Point(118, 217);
            this.lbMensagem.Name = "lbMensagem";
            this.lbMensagem.Size = new System.Drawing.Size(0, 13);
            this.lbMensagem.TabIndex = 9;
            // 
            // dgCategorias
            // 
            this.dgCategorias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clId,
            this.clNome,
            this.clDescricao,
            this.dlEditar,
            this.clDeletar});
            this.dgCategorias.Location = new System.Drawing.Point(326, 112);
            this.dgCategorias.Name = "dgCategorias";
            this.dgCategorias.Size = new System.Drawing.Size(443, 290);
            this.dgCategorias.TabIndex = 10;
            this.dgCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCategorias_CellContentClick);
            // 
            // clId
            // 
            this.clId.HeaderText = "Id";
            this.clId.MinimumWidth = 10;
            this.clId.Name = "clId";
            this.clId.Width = 50;
            // 
            // clNome
            // 
            this.clNome.HeaderText = "Nome";
            this.clNome.Name = "clNome";
            // 
            // clDescricao
            // 
            this.clDescricao.HeaderText = "Descrição";
            this.clDescricao.Name = "clDescricao";
            this.clDescricao.Width = 150;
            // 
            // dlEditar
            // 
            this.dlEditar.HeaderText = "Editar";
            this.dlEditar.Name = "dlEditar";
            this.dlEditar.Text = "^";
            this.dlEditar.Width = 50;
            // 
            // clDeletar
            // 
            this.clDeletar.HeaderText = "Deletar";
            this.clDeletar.Name = "clDeletar";
            this.clDeletar.Width = 50;
            // 
            // CategoriaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgCategorias);
            this.Controls.Add(this.lbMensagem);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lbDescricao);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.lbTitulo);
            this.Name = "CategoriaForm";
            this.Text = "CategoriaForm";
            this.Load += new System.EventHandler(this.CategoriaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Label lbMensagem;
        private System.Windows.Forms.DataGridView dgCategorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDescricao;
        private System.Windows.Forms.DataGridViewButtonColumn dlEditar;
        private System.Windows.Forms.DataGridViewButtonColumn clDeletar;
    }
}