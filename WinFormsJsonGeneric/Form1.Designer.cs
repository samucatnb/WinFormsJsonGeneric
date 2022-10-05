namespace WinFormsJsonGeneric
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
      this.components = new System.ComponentModel.Container();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.txtCaixa = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txtVisualiza = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.txtNomeTela = new System.Windows.Forms.TextBox();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(81, 274);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(170, 59);
      this.button1.TabIndex = 0;
      this.button1.Text = "Gravar Json";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(81, 339);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(170, 59);
      this.button2.TabIndex = 1;
      this.button2.Text = "Ler Json";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // txtCaixa
      // 
      this.txtCaixa.Location = new System.Drawing.Point(21, 86);
      this.txtCaixa.Name = "txtCaixa";
      this.txtCaixa.Size = new System.Drawing.Size(113, 23);
      this.txtCaixa.TabIndex = 2;
      this.toolTip1.SetToolTip(this.txtCaixa, "Informe número do Caixa para gravar no arquivo");
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(21, 68);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(100, 15);
      this.label1.TabIndex = 3;
      this.label1.Text = "Número do Caixa";
      // 
      // txtVisualiza
      // 
      this.txtVisualiza.Location = new System.Drawing.Point(282, 48);
      this.txtVisualiza.Multiline = true;
      this.txtVisualiza.Name = "txtVisualiza";
      this.txtVisualiza.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.txtVisualiza.Size = new System.Drawing.Size(495, 350);
      this.txtVisualiza.TabIndex = 4;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(282, 30);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(159, 15);
      this.label2.TabIndex = 5;
      this.label2.Text = "Retorno Leitura Arquivo Json";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(21, 147);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(113, 15);
      this.label3.TabIndex = 7;
      this.label3.Text = "Nome Tela Consulta";
      // 
      // txtNomeTela
      // 
      this.txtNomeTela.Location = new System.Drawing.Point(21, 165);
      this.txtNomeTela.Name = "txtNomeTela";
      this.txtNomeTela.Size = new System.Drawing.Size(230, 23);
      this.txtNomeTela.TabIndex = 6;
      this.toolTip1.SetToolTip(this.txtNomeTela, "Informe o Nome da Tela para gravar no arquivo");
      // 
      // toolTip1
      // 
      this.toolTip1.AutomaticDelay = 300;
      this.toolTip1.IsBalloon = true;
      this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
      this.toolTip1.ToolTipTitle = "Ajuda Sistema";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtNomeTela);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtVisualiza);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtCaixa);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox txtCaixa;
        private Label label1;
        private TextBox txtVisualiza;
        private Label label2;
        private Label label3;
        private TextBox txtNomeTela;
        private ToolTip toolTip1;
    }
}