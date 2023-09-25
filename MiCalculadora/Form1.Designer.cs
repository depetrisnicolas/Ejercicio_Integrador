namespace MiCalculadora
{
    partial class FrmCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculadora));
            lblResultado = new Label();
            lblPrimerOperador = new Label();
            lblOperacion = new Label();
            lblSegundoOperador = new Label();
            cmbOperacion = new ComboBox();
            rdbDecimal = new RadioButton();
            rdbBinario = new RadioButton();
            grpSistema = new GroupBox();
            btnOperar = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            txtSegundoOperador = new TextBox();
            txtPrimerOperador = new TextBox();
            grpSistema.SuspendLayout();
            SuspendLayout();
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.Location = new Point(22, 60);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(181, 47);
            lblResultado.TabIndex = 0;
            lblResultado.Text = "Resultado:";
            // 
            // lblPrimerOperador
            // 
            lblPrimerOperador.AutoSize = true;
            lblPrimerOperador.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrimerOperador.Location = new Point(22, 260);
            lblPrimerOperador.Name = "lblPrimerOperador";
            lblPrimerOperador.Size = new Size(158, 25);
            lblPrimerOperador.TabIndex = 1;
            lblPrimerOperador.Text = "Primer operador:";
            // 
            // lblOperacion
            // 
            lblOperacion.AutoSize = true;
            lblOperacion.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblOperacion.Location = new Point(227, 260);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(105, 25);
            lblOperacion.TabIndex = 2;
            lblOperacion.Text = "Operacion:";
            // 
            // lblSegundoOperador
            // 
            lblSegundoOperador.AutoSize = true;
            lblSegundoOperador.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSegundoOperador.Location = new Point(373, 260);
            lblSegundoOperador.Name = "lblSegundoOperador";
            lblSegundoOperador.Size = new Size(176, 25);
            lblSegundoOperador.TabIndex = 3;
            lblSegundoOperador.Text = "Segundo operador:";
            // 
            // cmbOperacion
            // 
            cmbOperacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.Location = new Point(221, 288);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(121, 23);
            cmbOperacion.TabIndex = 1;
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.Location = new Point(6, 34);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(68, 19);
            rdbDecimal.TabIndex = 5;
            rdbDecimal.TabStop = true;
            rdbDecimal.Text = "Decimal";
            rdbDecimal.UseVisualStyleBackColor = true;
            rdbDecimal.CheckedChanged += rdbDecimal_CheckedChanged;
            // 
            // rdbBinario
            // 
            rdbBinario.AutoSize = true;
            rdbBinario.Location = new Point(100, 34);
            rdbBinario.Name = "rdbBinario";
            rdbBinario.Size = new Size(62, 19);
            rdbBinario.TabIndex = 6;
            rdbBinario.TabStop = true;
            rdbBinario.Text = "Binario";
            rdbBinario.UseVisualStyleBackColor = true;
            rdbBinario.CheckedChanged += rdbBinario_CheckedChanged;
            // 
            // grpSistema
            // 
            grpSistema.Controls.Add(rdbDecimal);
            grpSistema.Controls.Add(rdbBinario);
            grpSistema.Location = new Point(186, 144);
            grpSistema.Name = "grpSistema";
            grpSistema.Size = new Size(200, 73);
            grpSistema.TabIndex = 50;
            grpSistema.TabStop = false;
            grpSistema.Text = "Representar resultado en:";
            // 
            // btnOperar
            // 
            btnOperar.Location = new Point(22, 327);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(168, 42);
            btnOperar.TabIndex = 3;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = true;
            btnOperar.Click += btnOperar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(199, 327);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(168, 42);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(377, 327);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(168, 42);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // txtSegundoOperador
            // 
            txtSegundoOperador.Location = new Point(373, 288);
            txtSegundoOperador.Name = "txtSegundoOperador";
            txtSegundoOperador.Size = new Size(170, 23);
            txtSegundoOperador.TabIndex = 2;
            txtSegundoOperador.TextChanged += txtSegundoOperador_TextChanged;
            // 
            // txtPrimerOperador
            // 
            txtPrimerOperador.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPrimerOperador.Location = new Point(22, 288);
            txtPrimerOperador.Name = "txtPrimerOperador";
            txtPrimerOperador.Size = new Size(168, 23);
            txtPrimerOperador.TabIndex = 0;
            txtPrimerOperador.TextChanged += txtPrimerOperador_TextChanged;
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 389);
            Controls.Add(txtPrimerOperador);
            Controls.Add(txtSegundoOperador);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnOperar);
            Controls.Add(grpSistema);
            Controls.Add(cmbOperacion);
            Controls.Add(lblSegundoOperador);
            Controls.Add(lblOperacion);
            Controls.Add(lblPrimerOperador);
            Controls.Add(lblResultado);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCalculadora";
            Text = "Calculadora Alumno: Nicolas Depetris";
            FormClosing += FrmCalculadora_FormClosing;
            Load += Form1_Load;
            grpSistema.ResumeLayout(false);
            grpSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResultado;
        private Label lblPrimerOperador;
        private Label lblOperacion;
        private Label lblSegundoOperador;
        private ComboBox cmbOperacion;
        private RadioButton rdbDecimal;
        private RadioButton rdbBinario;
        private GroupBox grpSistema;
        private Button btnOperar;
        private Button btnLimpiar;
        private Button btnCerrar;
        private TextBox txtSegundoOperador;
        private TextBox txtPrimerOperador;
    }
}