namespace verificadorIP
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bConvertir = new System.Windows.Forms.Button();
            this.gbFormato = new System.Windows.Forms.GroupBox();
            this.rbDecimal = new System.Windows.Forms.RadioButton();
            this.rbBinario = new System.Windows.Forms.RadioButton();
            this.lMuestra = new System.Windows.Forms.Label();
            this.lResultado = new System.Windows.Forms.Label();
            this.bVerificar = new System.Windows.Forms.Button();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.errorIP = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbFormato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIP)).BeginInit();
            this.SuspendLayout();
            // 
            // bConvertir
            // 
            this.bConvertir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bConvertir.Enabled = false;
            this.bConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.bConvertir.Location = new System.Drawing.Point(66, 164);
            this.bConvertir.Name = "bConvertir";
            this.bConvertir.Size = new System.Drawing.Size(166, 23);
            this.bConvertir.TabIndex = 1;
            this.bConvertir.Text = "&CONVERTIR A DECIMAL";
            this.bConvertir.UseVisualStyleBackColor = true;
            this.bConvertir.Click += new System.EventHandler(this.bConvertir_Click);
            // 
            // gbFormato
            // 
            this.gbFormato.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbFormato.Controls.Add(this.rbBinario);
            this.gbFormato.Controls.Add(this.rbDecimal);
            this.gbFormato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.gbFormato.Location = new System.Drawing.Point(42, 21);
            this.gbFormato.Name = "gbFormato";
            this.gbFormato.Size = new System.Drawing.Size(228, 80);
            this.gbFormato.TabIndex = 2;
            this.gbFormato.TabStop = false;
            this.gbFormato.Text = "FORMATO:";
            // 
            // rbDecimal
            // 
            this.rbDecimal.AutoSize = true;
            this.rbDecimal.Checked = true;
            this.rbDecimal.Location = new System.Drawing.Point(6, 37);
            this.rbDecimal.Name = "rbDecimal";
            this.rbDecimal.Size = new System.Drawing.Size(91, 20);
            this.rbDecimal.TabIndex = 0;
            this.rbDecimal.TabStop = true;
            this.rbDecimal.Text = "DECIMAL";
            this.rbDecimal.UseVisualStyleBackColor = true;
            this.rbDecimal.CheckedChanged += new System.EventHandler(this.rbDecimal_CheckedChanged);
            // 
            // rbBinario
            // 
            this.rbBinario.AutoSize = true;
            this.rbBinario.Location = new System.Drawing.Point(118, 37);
            this.rbBinario.Name = "rbBinario";
            this.rbBinario.Size = new System.Drawing.Size(87, 20);
            this.rbBinario.TabIndex = 1;
            this.rbBinario.Text = "BINARIO";
            this.rbBinario.UseVisualStyleBackColor = true;
            this.rbBinario.CheckedChanged += new System.EventHandler(this.rbBinario_CheckedChanged);
            // 
            // lMuestra
            // 
            this.lMuestra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lMuestra.AutoSize = true;
            this.lMuestra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lMuestra.Location = new System.Drawing.Point(12, 209);
            this.lMuestra.Name = "lMuestra";
            this.lMuestra.Size = new System.Drawing.Size(104, 16);
            this.lMuestra.TabIndex = 3;
            this.lMuestra.Text = "RESULTADO:";
            // 
            // lResultado
            // 
            this.lResultado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lResultado.AutoSize = true;
            this.lResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lResultado.Location = new System.Drawing.Point(16, 225);
            this.lResultado.Name = "lResultado";
            this.lResultado.Size = new System.Drawing.Size(0, 16);
            this.lResultado.TabIndex = 4;
            // 
            // bVerificar
            // 
            this.bVerificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.bVerificar.Location = new System.Drawing.Point(66, 135);
            this.bVerificar.Name = "bVerificar";
            this.bVerificar.Size = new System.Drawing.Size(166, 23);
            this.bVerificar.TabIndex = 5;
            this.bVerificar.Text = "VERIFICAR IP";
            this.bVerificar.UseVisualStyleBackColor = true;
            this.bVerificar.Click += new System.EventHandler(this.bVerificar_Click);
            // 
            // tbIP
            // 
            this.tbIP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbIP.Location = new System.Drawing.Point(42, 107);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(228, 22);
            this.tbIP.TabIndex = 6;
            // 
            // errorIP
            // 
            this.errorIP.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 301);
            this.Controls.Add(this.tbIP);
            this.Controls.Add(this.bVerificar);
            this.Controls.Add(this.lResultado);
            this.Controls.Add(this.lMuestra);
            this.Controls.Add(this.gbFormato);
            this.Controls.Add(this.bConvertir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConVIP";
            this.gbFormato.ResumeLayout(false);
            this.gbFormato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bConvertir;
        private System.Windows.Forms.GroupBox gbFormato;
        private System.Windows.Forms.RadioButton rbBinario;
        private System.Windows.Forms.RadioButton rbDecimal;
        private System.Windows.Forms.Label lMuestra;
        private System.Windows.Forms.Label lResultado;
        private System.Windows.Forms.Button bVerificar;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.ErrorProvider errorIP;
    }
}

