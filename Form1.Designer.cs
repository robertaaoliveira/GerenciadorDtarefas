namespace GerenciadorDtarefas
{
    partial class Form1
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.grbAdicionar = new System.Windows.Forms.GroupBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbRespon = new System.Windows.Forms.TextBox();
            this.lblRespon = new System.Windows.Forms.Label();
            this.lblSetor = new System.Windows.Forms.Label();
            this.cmbSetor = new System.Windows.Forms.ComboBox();
            this.lblData = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.grbTarefas = new System.Windows.Forms.GroupBox();
            this.dgvTarefa = new System.Windows.Forms.DataGridView();
            this.pibApagar = new System.Windows.Forms.PictureBox();
            this.pibLogo = new System.Windows.Forms.PictureBox();
            this.grbAdicionar.SuspendLayout();
            this.grbTarefas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibApagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(143, 26);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(399, 48);
            this.lbTitulo.TabIndex = 1;
            this.lbTitulo.Text = "Gerenciador de Tarefas";
            // 
            // grbAdicionar
            // 
            this.grbAdicionar.Controls.Add(this.btnAdicionar);
            this.grbAdicionar.Controls.Add(this.dtpData);
            this.grbAdicionar.Controls.Add(this.lblData);
            this.grbAdicionar.Controls.Add(this.cmbSetor);
            this.grbAdicionar.Controls.Add(this.lblSetor);
            this.grbAdicionar.Controls.Add(this.txbRespon);
            this.grbAdicionar.Controls.Add(this.lblRespon);
            this.grbAdicionar.Controls.Add(this.txbNome);
            this.grbAdicionar.Controls.Add(this.lblNome);
            this.grbAdicionar.Location = new System.Drawing.Point(46, 142);
            this.grbAdicionar.Name = "grbAdicionar";
            this.grbAdicionar.Size = new System.Drawing.Size(377, 256);
            this.grbAdicionar.TabIndex = 2;
            this.grbAdicionar.TabStop = false;
            this.grbAdicionar.Text = "Adicionar";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(24, 34);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(115, 17);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome da Tarefa:";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(145, 31);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(100, 20);
            this.txbNome.TabIndex = 1;
            // 
            // txbRespon
            // 
            this.txbRespon.Location = new System.Drawing.Point(189, 77);
            this.txbRespon.Name = "txbRespon";
            this.txbRespon.Size = new System.Drawing.Size(100, 20);
            this.txbRespon.TabIndex = 3;
            // 
            // lblRespon
            // 
            this.lblRespon.AutoSize = true;
            this.lblRespon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespon.Location = new System.Drawing.Point(24, 78);
            this.lblRespon.Name = "lblRespon";
            this.lblRespon.Size = new System.Drawing.Size(155, 17);
            this.lblRespon.TabIndex = 2;
            this.lblRespon.Text = "Nome do Responsável:";
            // 
            // lblSetor
            // 
            this.lblSetor.AutoSize = true;
            this.lblSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetor.Location = new System.Drawing.Point(27, 119);
            this.lblSetor.Name = "lblSetor";
            this.lblSetor.Size = new System.Drawing.Size(46, 17);
            this.lblSetor.TabIndex = 4;
            this.lblSetor.Text = "Setor:";
            // 
            // cmbSetor
            // 
            this.cmbSetor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetor.FormattingEnabled = true;
            this.cmbSetor.Location = new System.Drawing.Point(79, 119);
            this.cmbSetor.Name = "cmbSetor";
            this.cmbSetor.Size = new System.Drawing.Size(121, 21);
            this.cmbSetor.TabIndex = 5;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(27, 156);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(83, 17);
            this.lblData.TabIndex = 6;
            this.lblData.Text = "Data Limite:";
            this.lblData.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(116, 156);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(221, 20);
            this.dtpData.TabIndex = 7;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAdicionar.Location = new System.Drawing.Point(30, 193);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(313, 43);
            this.btnAdicionar.TabIndex = 8;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // grbTarefas
            // 
            this.grbTarefas.Controls.Add(this.pibApagar);
            this.grbTarefas.Controls.Add(this.dgvTarefa);
            this.grbTarefas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbTarefas.Location = new System.Drawing.Point(451, 142);
            this.grbTarefas.Name = "grbTarefas";
            this.grbTarefas.Size = new System.Drawing.Size(395, 256);
            this.grbTarefas.TabIndex = 3;
            this.grbTarefas.TabStop = false;
            this.grbTarefas.Text = "Tarefas";
            // 
            // dgvTarefa
            // 
            this.dgvTarefa.AllowUserToAddRows = false;
            this.dgvTarefa.AllowUserToDeleteRows = false;
            this.dgvTarefa.AllowUserToResizeColumns = false;
            this.dgvTarefa.AllowUserToResizeRows = false;
            this.dgvTarefa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTarefa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarefa.Location = new System.Drawing.Point(0, 14);
            this.dgvTarefa.Name = "dgvTarefa";
            this.dgvTarefa.ReadOnly = true;
            this.dgvTarefa.Size = new System.Drawing.Size(395, 193);
            this.dgvTarefa.TabIndex = 0;
            this.dgvTarefa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTarefa_CellDoubleClick);
            // 
            // pibApagar
            // 
            this.pibApagar.Image = global::GerenciadorDtarefas.Properties.Resources.remove;
            this.pibApagar.Location = new System.Drawing.Point(344, 209);
            this.pibApagar.Name = "pibApagar";
            this.pibApagar.Size = new System.Drawing.Size(51, 47);
            this.pibApagar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibApagar.TabIndex = 4;
            this.pibApagar.TabStop = false;
            this.pibApagar.Click += new System.EventHandler(this.pibApagar_Click);
            // 
            // pibLogo
            // 
            this.pibLogo.Image = global::GerenciadorDtarefas.Properties.Resources.check;
            this.pibLogo.Location = new System.Drawing.Point(12, 12);
            this.pibLogo.Name = "pibLogo";
            this.pibLogo.Size = new System.Drawing.Size(109, 99);
            this.pibLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibLogo.TabIndex = 0;
            this.pibLogo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 474);
            this.Controls.Add(this.grbTarefas);
            this.Controls.Add(this.grbAdicionar);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.pibLogo);
            this.Name = "Form1";
            this.Text = "::Gerenciador de Tarefas::";
            this.grbAdicionar.ResumeLayout(false);
            this.grbAdicionar.PerformLayout();
            this.grbTarefas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibApagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pibLogo;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.GroupBox grbAdicionar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.ComboBox cmbSetor;
        private System.Windows.Forms.Label lblSetor;
        private System.Windows.Forms.TextBox txbRespon;
        private System.Windows.Forms.Label lblRespon;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.GroupBox grbTarefas;
        private System.Windows.Forms.DataGridView dgvTarefa;
        private System.Windows.Forms.PictureBox pibApagar;
    }
}

