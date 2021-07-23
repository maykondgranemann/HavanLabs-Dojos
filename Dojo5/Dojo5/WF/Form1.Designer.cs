
namespace WF
{
    partial class Fcategoria
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbCategoria = new System.Windows.Forms.GroupBox();
            this.lbIdC = new System.Windows.Forms.Label();
            this.lbNomeC = new System.Windows.Forms.Label();
            this.lbDescricaoC = new System.Windows.Forms.Label();
            this.tbIdC = new System.Windows.Forms.TextBox();
            this.tbNomeC = new System.Windows.Forms.TextBox();
            this.tbDescriC = new System.Windows.Forms.TextBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.dgListaCategoria = new System.Windows.Forms.DataGridView();
            this.btDeletar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.gbCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCategoria
            // 
            this.gbCategoria.Controls.Add(this.btDeletar);
            this.gbCategoria.Controls.Add(this.btEditar);
            this.gbCategoria.Controls.Add(this.dgListaCategoria);
            this.gbCategoria.Controls.Add(this.btLimpar);
            this.gbCategoria.Controls.Add(this.btSalvar);
            this.gbCategoria.Controls.Add(this.tbDescriC);
            this.gbCategoria.Controls.Add(this.tbNomeC);
            this.gbCategoria.Controls.Add(this.tbIdC);
            this.gbCategoria.Controls.Add(this.lbDescricaoC);
            this.gbCategoria.Controls.Add(this.lbNomeC);
            this.gbCategoria.Controls.Add(this.lbIdC);
            this.gbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCategoria.Location = new System.Drawing.Point(12, 12);
            this.gbCategoria.Name = "gbCategoria";
            this.gbCategoria.Size = new System.Drawing.Size(553, 532);
            this.gbCategoria.TabIndex = 0;
            this.gbCategoria.TabStop = false;
            this.gbCategoria.Text = "Cadastro Categorias";
            // 
            // lbIdC
            // 
            this.lbIdC.AutoSize = true;
            this.lbIdC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdC.Location = new System.Drawing.Point(22, 87);
            this.lbIdC.Name = "lbIdC";
            this.lbIdC.Size = new System.Drawing.Size(31, 25);
            this.lbIdC.TabIndex = 0;
            this.lbIdC.Text = "Id";
            // 
            // lbNomeC
            // 
            this.lbNomeC.AutoSize = true;
            this.lbNomeC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeC.Location = new System.Drawing.Point(22, 141);
            this.lbNomeC.Name = "lbNomeC";
            this.lbNomeC.Size = new System.Drawing.Size(114, 25);
            this.lbNomeC.TabIndex = 1;
            this.lbNomeC.Text = "Categoria";
            // 
            // lbDescricaoC
            // 
            this.lbDescricaoC.AutoSize = true;
            this.lbDescricaoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescricaoC.Location = new System.Drawing.Point(22, 192);
            this.lbDescricaoC.Name = "lbDescricaoC";
            this.lbDescricaoC.Size = new System.Drawing.Size(117, 25);
            this.lbDescricaoC.TabIndex = 2;
            this.lbDescricaoC.Text = "Descrição";
            // 
            // tbIdC
            // 
            this.tbIdC.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdC.Location = new System.Drawing.Point(151, 87);
            this.tbIdC.Name = "tbIdC";
            this.tbIdC.Size = new System.Drawing.Size(117, 34);
            this.tbIdC.TabIndex = 3;
            // 
            // tbNomeC
            // 
            this.tbNomeC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomeC.Location = new System.Drawing.Point(151, 138);
            this.tbNomeC.Name = "tbNomeC";
            this.tbNomeC.Size = new System.Drawing.Size(227, 31);
            this.tbNomeC.TabIndex = 4;
            // 
            // tbDescriC
            // 
            this.tbDescriC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescriC.Location = new System.Drawing.Point(151, 186);
            this.tbDescriC.Name = "tbDescriC";
            this.tbDescriC.Size = new System.Drawing.Size(350, 31);
            this.tbDescriC.TabIndex = 5;
            // 
            // btSalvar
            // 
            this.btSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.Location = new System.Drawing.Point(151, 234);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(96, 49);
            this.btSalvar.TabIndex = 6;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            // 
            // btLimpar
            // 
            this.btLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.Location = new System.Drawing.Point(266, 234);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(96, 49);
            this.btLimpar.TabIndex = 7;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            // 
            // dgListaCategoria
            // 
            this.dgListaCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgListaCategoria.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgListaCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaCategoria.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgListaCategoria.Location = new System.Drawing.Point(0, 337);
            this.dgListaCategoria.Name = "dgListaCategoria";
            this.dgListaCategoria.Size = new System.Drawing.Size(553, 154);
            this.dgListaCategoria.TabIndex = 8;
            // 
            // btDeletar
            // 
            this.btDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeletar.Location = new System.Drawing.Point(454, 497);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(96, 35);
            this.btDeletar.TabIndex = 10;
            this.btDeletar.Text = "Deletar";
            this.btDeletar.UseVisualStyleBackColor = true;
            // 
            // btEditar
            // 
            this.btEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.Location = new System.Drawing.Point(339, 497);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(96, 35);
            this.btEditar.TabIndex = 9;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            // 
            // Fcategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 556);
            this.Controls.Add(this.gbCategoria);
            this.Name = "Fcategoria";
            this.gbCategoria.ResumeLayout(false);
            this.gbCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCategoria;
        private System.Windows.Forms.Label lbDescricaoC;
        private System.Windows.Forms.Label lbNomeC;
        private System.Windows.Forms.Label lbIdC;
        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.DataGridView dgListaCategoria;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.TextBox tbDescriC;
        private System.Windows.Forms.TextBox tbNomeC;
        private System.Windows.Forms.TextBox tbIdC;
    }
}

