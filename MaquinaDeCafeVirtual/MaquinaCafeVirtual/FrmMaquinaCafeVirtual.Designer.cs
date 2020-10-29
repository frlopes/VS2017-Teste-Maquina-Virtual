namespace MaquinaCafeVirtual
{
    partial class FrmMaquinaCafeVirtual
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMaquinaCafeVirtual));
            this.btn1Centavo = new System.Windows.Forms.Button();
            this.btn5Centavos = new System.Windows.Forms.Button();
            this.btn10Centavos = new System.Windows.Forms.Button();
            this.btn25Centavos = new System.Windows.Forms.Button();
            this.btn50Centavos = new System.Windows.Forms.Button();
            this.btn1Real = new System.Windows.Forms.Button();
            this.btnNovoPedido = new System.Windows.Forms.Button();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.txtTotalMoedaInserida = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCafeComLeite = new System.Windows.Forms.Button();
            this.btnMocha = new System.Windows.Forms.Button();
            this.btnCappuccino = new System.Windows.Forms.Button();
            this.lblValorInserido = new System.Windows.Forms.Label();
            this.lblTroco = new System.Windows.Forms.Label();
            this.lblCafeComLeite = new System.Windows.Forms.Label();
            this.lblMocha = new System.Windows.Forms.Label();
            this.lblCappuccino = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1Centavo
            // 
            this.btn1Centavo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn1Centavo.Image = ((System.Drawing.Image)(resources.GetObject("btn1Centavo.Image")));
            this.btn1Centavo.Location = new System.Drawing.Point(12, 12);
            this.btn1Centavo.Name = "btn1Centavo";
            this.btn1Centavo.Size = new System.Drawing.Size(82, 82);
            this.btn1Centavo.TabIndex = 0;
            this.btn1Centavo.UseVisualStyleBackColor = true;
            this.btn1Centavo.Click += new System.EventHandler(this.btn1Centavo_Click);
            // 
            // btn5Centavos
            // 
            this.btn5Centavos.Image = ((System.Drawing.Image)(resources.GetObject("btn5Centavos.Image")));
            this.btn5Centavos.Location = new System.Drawing.Point(101, 12);
            this.btn5Centavos.Name = "btn5Centavos";
            this.btn5Centavos.Size = new System.Drawing.Size(82, 82);
            this.btn5Centavos.TabIndex = 1;
            this.btn5Centavos.UseVisualStyleBackColor = true;
            this.btn5Centavos.Click += new System.EventHandler(this.btn5Centavos_Click);
            // 
            // btn10Centavos
            // 
            this.btn10Centavos.Image = ((System.Drawing.Image)(resources.GetObject("btn10Centavos.Image")));
            this.btn10Centavos.Location = new System.Drawing.Point(12, 101);
            this.btn10Centavos.Name = "btn10Centavos";
            this.btn10Centavos.Size = new System.Drawing.Size(82, 82);
            this.btn10Centavos.TabIndex = 2;
            this.btn10Centavos.UseVisualStyleBackColor = true;
            this.btn10Centavos.Click += new System.EventHandler(this.btn10Centavos_Click);
            // 
            // btn25Centavos
            // 
            this.btn25Centavos.Image = ((System.Drawing.Image)(resources.GetObject("btn25Centavos.Image")));
            this.btn25Centavos.Location = new System.Drawing.Point(101, 101);
            this.btn25Centavos.Name = "btn25Centavos";
            this.btn25Centavos.Size = new System.Drawing.Size(82, 82);
            this.btn25Centavos.TabIndex = 3;
            this.btn25Centavos.UseVisualStyleBackColor = true;
            this.btn25Centavos.Click += new System.EventHandler(this.btn25Centavos_Click);
            // 
            // btn50Centavos
            // 
            this.btn50Centavos.Image = ((System.Drawing.Image)(resources.GetObject("btn50Centavos.Image")));
            this.btn50Centavos.Location = new System.Drawing.Point(12, 190);
            this.btn50Centavos.Name = "btn50Centavos";
            this.btn50Centavos.Size = new System.Drawing.Size(82, 82);
            this.btn50Centavos.TabIndex = 4;
            this.btn50Centavos.UseVisualStyleBackColor = true;
            this.btn50Centavos.Click += new System.EventHandler(this.btn50Centavos_Click);
            // 
            // btn1Real
            // 
            this.btn1Real.Image = ((System.Drawing.Image)(resources.GetObject("btn1Real.Image")));
            this.btn1Real.Location = new System.Drawing.Point(101, 190);
            this.btn1Real.Name = "btn1Real";
            this.btn1Real.Size = new System.Drawing.Size(82, 82);
            this.btn1Real.TabIndex = 5;
            this.btn1Real.UseVisualStyleBackColor = true;
            this.btn1Real.Click += new System.EventHandler(this.btn1Real_Click);
            // 
            // btnNovoPedido
            // 
            this.btnNovoPedido.Location = new System.Drawing.Point(606, 227);
            this.btnNovoPedido.Name = "btnNovoPedido";
            this.btnNovoPedido.Size = new System.Drawing.Size(72, 52);
            this.btnNovoPedido.TabIndex = 16;
            this.btnNovoPedido.Text = "Novo Pedido";
            this.toolTip1.SetToolTip(this.btnNovoPedido, "Novo Pedido");
            this.btnNovoPedido.UseVisualStyleBackColor = true;
            this.btnNovoPedido.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // txtTroco
            // 
            this.txtTroco.BackColor = System.Drawing.SystemColors.Menu;
            this.txtTroco.Enabled = false;
            this.txtTroco.Location = new System.Drawing.Point(337, 239);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.Size = new System.Drawing.Size(112, 26);
            this.txtTroco.TabIndex = 15;
            // 
            // txtTotalMoedaInserida
            // 
            this.txtTotalMoedaInserida.BackColor = System.Drawing.SystemColors.Menu;
            this.txtTotalMoedaInserida.Enabled = false;
            this.txtTotalMoedaInserida.Location = new System.Drawing.Point(337, 201);
            this.txtTotalMoedaInserida.Name = "txtTotalMoedaInserida";
            this.txtTotalMoedaInserida.Size = new System.Drawing.Size(112, 26);
            this.txtTotalMoedaInserida.TabIndex = 13;
            // 
            // btnCafeComLeite
            // 
            this.btnCafeComLeite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCafeComLeite.Image = ((System.Drawing.Image)(resources.GetObject("btnCafeComLeite.Image")));
            this.btnCafeComLeite.Location = new System.Drawing.Point(543, 34);
            this.btnCafeComLeite.Name = "btnCafeComLeite";
            this.btnCafeComLeite.Size = new System.Drawing.Size(135, 137);
            this.btnCafeComLeite.TabIndex = 11;
            this.btnCafeComLeite.Text = "R$ 3,00";
            this.btnCafeComLeite.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnCafeComLeite, "Café com Leite");
            this.btnCafeComLeite.UseVisualStyleBackColor = false;
            this.btnCafeComLeite.Click += new System.EventHandler(this.btnCafeComLeite_Click);
            // 
            // btnMocha
            // 
            this.btnMocha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMocha.Image = ((System.Drawing.Image)(resources.GetObject("btnMocha.Image")));
            this.btnMocha.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMocha.Location = new System.Drawing.Point(373, 34);
            this.btnMocha.Name = "btnMocha";
            this.btnMocha.Size = new System.Drawing.Size(135, 137);
            this.btnMocha.TabIndex = 10;
            this.btnMocha.Text = "R$ 4,00";
            this.btnMocha.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnMocha, "Mocha");
            this.btnMocha.UseVisualStyleBackColor = false;
            this.btnMocha.Click += new System.EventHandler(this.btnMocha_Click);
            // 
            // btnCappuccino
            // 
            this.btnCappuccino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCappuccino.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCappuccino.Image = ((System.Drawing.Image)(resources.GetObject("btnCappuccino.Image")));
            this.btnCappuccino.Location = new System.Drawing.Point(208, 34);
            this.btnCappuccino.Name = "btnCappuccino";
            this.btnCappuccino.Size = new System.Drawing.Size(135, 137);
            this.btnCappuccino.TabIndex = 9;
            this.btnCappuccino.Text = "R$ 3,50";
            this.btnCappuccino.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnCappuccino, "Cappuccino");
            this.btnCappuccino.UseVisualStyleBackColor = false;
            this.btnCappuccino.Click += new System.EventHandler(this.btnCappuccino_Click);
            // 
            // lblValorInserido
            // 
            this.lblValorInserido.AutoSize = true;
            this.lblValorInserido.Location = new System.Drawing.Point(215, 209);
            this.lblValorInserido.Name = "lblValorInserido";
            this.lblValorInserido.Size = new System.Drawing.Size(116, 18);
            this.lblValorInserido.TabIndex = 12;
            this.lblValorInserido.Text = "Valor Inserido:";
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.Location = new System.Drawing.Point(215, 247);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(57, 18);
            this.lblTroco.TabIndex = 14;
            this.lblTroco.Text = "Troco:";
            // 
            // lblCafeComLeite
            // 
            this.lblCafeComLeite.AutoSize = true;
            this.lblCafeComLeite.Location = new System.Drawing.Point(545, 12);
            this.lblCafeComLeite.Name = "lblCafeComLeite";
            this.lblCafeComLeite.Size = new System.Drawing.Size(133, 18);
            this.lblCafeComLeite.TabIndex = 8;
            this.lblCafeComLeite.Text = "CAFÉ COM LEITE";
            // 
            // lblMocha
            // 
            this.lblMocha.AutoSize = true;
            this.lblMocha.Location = new System.Drawing.Point(411, 12);
            this.lblMocha.Name = "lblMocha";
            this.lblMocha.Size = new System.Drawing.Size(65, 18);
            this.lblMocha.TabIndex = 7;
            this.lblMocha.Text = "MOCHA";
            // 
            // lblCappuccino
            // 
            this.lblCappuccino.AutoSize = true;
            this.lblCappuccino.Location = new System.Drawing.Point(223, 12);
            this.lblCappuccino.Name = "lblCappuccino";
            this.lblCappuccino.Size = new System.Drawing.Size(108, 18);
            this.lblCappuccino.TabIndex = 6;
            this.lblCappuccino.Text = "CAPPUCCINO";
            // 
            // FrmMaquinaCafeVirtual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 291);
            this.Controls.Add(this.lblCafeComLeite);
            this.Controls.Add(this.lblMocha);
            this.Controls.Add(this.lblCappuccino);
            this.Controls.Add(this.btnCafeComLeite);
            this.Controls.Add(this.btnMocha);
            this.Controls.Add(this.btnCappuccino);
            this.Controls.Add(this.lblTroco);
            this.Controls.Add(this.lblValorInserido);
            this.Controls.Add(this.txtTotalMoedaInserida);
            this.Controls.Add(this.txtTroco);
            this.Controls.Add(this.btnNovoPedido);
            this.Controls.Add(this.btn1Real);
            this.Controls.Add(this.btn50Centavos);
            this.Controls.Add(this.btn25Centavos);
            this.Controls.Add(this.btn10Centavos);
            this.Controls.Add(this.btn5Centavos);
            this.Controls.Add(this.btn1Centavo);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMaquinaCafeVirtual";
            this.Text = "Máquina de Café Virtual";
            this.Load += new System.EventHandler(this.FrmMaquinaCafeVirtual_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1Centavo;
        private System.Windows.Forms.Button btn5Centavos;
        private System.Windows.Forms.Button btn10Centavos;
        private System.Windows.Forms.Button btn25Centavos;
        private System.Windows.Forms.Button btn50Centavos;
        private System.Windows.Forms.Button btn1Real;
        private System.Windows.Forms.Button btnNovoPedido;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.TextBox txtTotalMoedaInserida;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblValorInserido;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.Label lblCafeComLeite;
        private System.Windows.Forms.Label lblMocha;
        private System.Windows.Forms.Label lblCappuccino;
        private System.Windows.Forms.Button btnCafeComLeite;
        private System.Windows.Forms.Button btnMocha;
        private System.Windows.Forms.Button btnCappuccino;
    }
}

