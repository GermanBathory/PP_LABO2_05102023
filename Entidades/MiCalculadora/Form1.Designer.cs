namespace MiCalculadora
{
    partial class Form1
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
            btnCerrar = new Button();
            btnLimpiar = new Button();
            txtSegundoOperador = new TextBox();
            cmbOperacion = new ComboBox();
            txtPrimerOperador = new TextBox();
            btnOperar = new Button();
            grpSistema = new GroupBox();
            rdbDecimal = new RadioButton();
            rdbBinario = new RadioButton();
            lblPrimerOperador = new Label();
            lblOperacion = new Label();
            lblSegundoOperador = new Label();
            lblResultado = new Label();
            lstHistorial = new ListBox();
            lblHistorial = new Label();
            grpSistema.SuspendLayout();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = SystemColors.ButtonHighlight;
            btnCerrar.Location = new Point(589, 391);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(199, 33);
            btnCerrar.TabIndex = 6;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ButtonHighlight;
            btnLimpiar.Location = new Point(300, 391);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(201, 33);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtSegundoOperador
            // 
            txtSegundoOperador.Location = new Point(598, 345);
            txtSegundoOperador.Name = "txtSegundoOperador";
            txtSegundoOperador.Size = new Size(181, 23);
            txtSegundoOperador.TabIndex = 9;
            txtSegundoOperador.TextChanged += txtSegundoOperador_TextChanged;
            // 
            // cmbOperacion
            // 
            cmbOperacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.Items.AddRange(new object[] { "", "+", "-", "*", "/" });
            cmbOperacion.Location = new Point(311, 345);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(181, 23);
            cmbOperacion.TabIndex = 10;
            // 
            // txtPrimerOperador
            // 
            txtPrimerOperador.Location = new Point(23, 345);
            txtPrimerOperador.Name = "txtPrimerOperador";
            txtPrimerOperador.ShortcutsEnabled = false;
            txtPrimerOperador.Size = new Size(181, 23);
            txtPrimerOperador.TabIndex = 11;
            txtPrimerOperador.TextChanged += txtPrimerOperador_TextChanged;
            // 
            // btnOperar
            // 
            btnOperar.BackColor = SystemColors.ButtonHighlight;
            btnOperar.Location = new Point(12, 391);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(208, 33);
            btnOperar.TabIndex = 12;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = false;
            btnOperar.Click += btnOperar_Click;
            // 
            // grpSistema
            // 
            grpSistema.Controls.Add(rdbDecimal);
            grpSistema.Controls.Add(rdbBinario);
            grpSistema.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            grpSistema.Location = new Point(32, 163);
            grpSistema.Name = "grpSistema";
            grpSistema.Size = new Size(281, 78);
            grpSistema.TabIndex = 13;
            grpSistema.TabStop = false;
            grpSistema.Text = "Representar resultado en:";
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.Location = new Point(6, 40);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(82, 24);
            rdbDecimal.TabIndex = 11;
            rdbDecimal.TabStop = true;
            rdbDecimal.Text = "Decimal";
            rdbDecimal.UseVisualStyleBackColor = true;
            rdbDecimal.CheckedChanged += rdbDecimal_CheckedChanged;
            // 
            // rdbBinario
            // 
            rdbBinario.AutoSize = true;
            rdbBinario.Location = new Point(135, 40);
            rdbBinario.Name = "rdbBinario";
            rdbBinario.Size = new Size(74, 24);
            rdbBinario.TabIndex = 12;
            rdbBinario.TabStop = true;
            rdbBinario.Text = "Binario";
            rdbBinario.UseVisualStyleBackColor = true;
            rdbBinario.CheckedChanged += rdbBinario_CheckedChanged;
            // 
            // lblPrimerOperador
            // 
            lblPrimerOperador.AutoSize = true;
            lblPrimerOperador.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrimerOperador.Location = new Point(23, 290);
            lblPrimerOperador.Name = "lblPrimerOperador";
            lblPrimerOperador.Size = new Size(181, 30);
            lblPrimerOperador.TabIndex = 14;
            lblPrimerOperador.Text = "Primer operador:";
            // 
            // lblOperacion
            // 
            lblOperacion.AutoSize = true;
            lblOperacion.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblOperacion.Location = new Point(340, 290);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(120, 30);
            lblOperacion.TabIndex = 15;
            lblOperacion.Text = "Operación:";
            // 
            // lblSegundoOperador
            // 
            lblSegundoOperador.AutoSize = true;
            lblSegundoOperador.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSegundoOperador.Location = new Point(584, 290);
            lblSegundoOperador.Name = "lblSegundoOperador";
            lblSegundoOperador.Size = new Size(204, 30);
            lblSegundoOperador.TabIndex = 16;
            lblSegundoOperador.Text = "Segundo operador:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.Location = new Point(32, 39);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(192, 50);
            lblResultado.TabIndex = 17;
            lblResultado.Text = "Resultado:";
            // 
            // lstHistorial
            // 
            lstHistorial.FormattingEnabled = true;
            lstHistorial.ItemHeight = 15;
            lstHistorial.Location = new Point(584, 58);
            lstHistorial.Name = "lstHistorial";
            lstHistorial.Size = new Size(258, 214);
            lstHistorial.TabIndex = 18;
            lstHistorial.SelectedIndexChanged += lstHistorial_SelectedIndexChanged;
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblHistorial.Location = new Point(584, 9);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(96, 30);
            lblHistorial.TabIndex = 19;
            lblHistorial.Text = "Historial";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(884, 471);
            Controls.Add(lblHistorial);
            Controls.Add(lstHistorial);
            Controls.Add(lblResultado);
            Controls.Add(lblSegundoOperador);
            Controls.Add(lblOperacion);
            Controls.Add(lblPrimerOperador);
            Controls.Add(grpSistema);
            Controls.Add(btnOperar);
            Controls.Add(txtPrimerOperador);
            Controls.Add(cmbOperacion);
            Controls.Add(txtSegundoOperador);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCerrar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            grpSistema.ResumeLayout(false);
            grpSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCerrar;
        private Button btnLimpiar;
        private TextBox txtSegundoOperador;
        private ComboBox cmbOperacion;
        private TextBox txtPrimerOperador;
        private Button btnOperar;
        private GroupBox grpSistema;
        private RadioButton rdbDecimal;
        private RadioButton rdbBinario;
        private Label lblPrimerOperador;
        private Label lblOperacion;
        private Label lblSegundoOperador;
        private Label lblResultado;
        private ListBox lstHistorial;
        private Label lblHistorial;
    }
}