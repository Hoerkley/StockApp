namespace StockApp.WindowsForms.Cadastros
{
    partial class frmCategoria
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
            btnSalvar = new Button();
            chkStatus = new CheckBox();
            label1 = new Label();
            txtCategoria = new TextBox();
            groupBoxCadastrar = new GroupBox();
            groupBoxCadastrar.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(201, 90);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // chkStatus
            // 
            chkStatus.AutoSize = true;
            chkStatus.Location = new Point(222, 47);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(54, 19);
            chkStatus.TabIndex = 1;
            chkStatus.Text = "Ativo";
            chkStatus.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 22);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(6, 46);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(171, 23);
            txtCategoria.TabIndex = 3;
            // 
            // groupBoxCadastrar
            // 
            groupBoxCadastrar.Controls.Add(chkStatus);
            groupBoxCadastrar.Controls.Add(label1);
            groupBoxCadastrar.Controls.Add(txtCategoria);
            groupBoxCadastrar.Controls.Add(btnSalvar);
            groupBoxCadastrar.Location = new Point(12, 23);
            groupBoxCadastrar.Name = "groupBoxCadastrar";
            groupBoxCadastrar.Size = new Size(470, 138);
            groupBoxCadastrar.TabIndex = 4;
            groupBoxCadastrar.TabStop = false;
            groupBoxCadastrar.Text = "Cadastro de categoria";
            // 
            // frmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxCadastrar);
            Name = "frmCategoria";
            Text = "frmCategoria";
            groupBoxCadastrar.ResumeLayout(false);
            groupBoxCadastrar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSalvar;
        private CheckBox chkStatus;
        private Label label1;
        private TextBox txtCategoria;
        private GroupBox groupBoxCadastrar;
    }
}