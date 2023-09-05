namespace TestesFuncionaisSAG.Formulario
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
            radioProducao = new RadioButton();
            radioHomologacao = new RadioButton();
            groupBox1 = new GroupBox();
            labelTxtURL = new Label();
            labelURL = new Label();
            checkBoxLoginVirtual = new CheckBox();
            groupBox2 = new GroupBox();
            labelEbusinessId = new Label();
            textBoxEbusinessId = new TextBox();
            checkedListBoxOperacoesRealizadas = new CheckedListBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            checkedListBox2 = new CheckedListBox();
            painelStatusExecucao = new RichTextBox();
            buttonTestes = new Button();
            textBoxUsuario = new TextBox();
            textBoxSenha = new TextBox();
            labelUsuario = new Label();
            labelSenha = new Label();
            groupBox6 = new GroupBox();
            groupBox7 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            SuspendLayout();
            // 
            // radioProducao
            // 
            radioProducao.AutoSize = true;
            radioProducao.Checked = true;
            radioProducao.Location = new Point(133, 24);
            radioProducao.Name = "radioProducao";
            radioProducao.Size = new Size(76, 19);
            radioProducao.TabIndex = 1;
            radioProducao.TabStop = true;
            radioProducao.Text = "Produção";
            radioProducao.UseVisualStyleBackColor = true;
            radioProducao.CheckedChanged += radioProducao_CheckedChanged;
            // 
            // radioHomologacao
            // 
            radioHomologacao.AutoSize = true;
            radioHomologacao.Location = new Point(14, 24);
            radioHomologacao.Name = "radioHomologacao";
            radioHomologacao.Size = new Size(101, 19);
            radioHomologacao.TabIndex = 2;
            radioHomologacao.Text = "Homologação";
            radioHomologacao.UseVisualStyleBackColor = true;
            radioHomologacao.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelTxtURL);
            groupBox1.Controls.Add(labelURL);
            groupBox1.Controls.Add(radioHomologacao);
            groupBox1.Controls.Add(radioProducao);
            groupBox1.Location = new Point(17, 111);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(436, 62);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ambiente";
            // 
            // labelTxtURL
            // 
            labelTxtURL.AutoSize = true;
            labelTxtURL.Location = new Point(237, 26);
            labelTxtURL.Name = "labelTxtURL";
            labelTxtURL.Size = new Size(31, 15);
            labelTxtURL.TabIndex = 4;
            labelTxtURL.Text = "URL:";
            // 
            // labelURL
            // 
            labelURL.AutoSize = true;
            labelURL.Location = new Point(274, 26);
            labelURL.Name = "labelURL";
            labelURL.Size = new Size(134, 15);
            labelURL.TabIndex = 3;
            labelURL.Text = "https://sag.itau.com.br/";
            // 
            // checkBoxLoginVirtual
            // 
            checkBoxLoginVirtual.AutoSize = true;
            checkBoxLoginVirtual.Checked = true;
            checkBoxLoginVirtual.CheckState = CheckState.Checked;
            checkBoxLoginVirtual.Location = new Point(22, 26);
            checkBoxLoginVirtual.Name = "checkBoxLoginVirtual";
            checkBoxLoginVirtual.Size = new Size(136, 19);
            checkBoxLoginVirtual.TabIndex = 5;
            checkBoxLoginVirtual.Text = "Realizar Login Virtual";
            checkBoxLoginVirtual.UseVisualStyleBackColor = true;
            checkBoxLoginVirtual.CheckedChanged += checkBoxLoginVirtual_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(labelEbusinessId);
            groupBox2.Controls.Add(textBoxEbusinessId);
            groupBox2.Controls.Add(checkBoxLoginVirtual);
            groupBox2.Location = new Point(17, 188);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(436, 59);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Login Virtual";
            // 
            // labelEbusinessId
            // 
            labelEbusinessId.AutoSize = true;
            labelEbusinessId.Location = new Point(188, 26);
            labelEbusinessId.Name = "labelEbusinessId";
            labelEbusinessId.Size = new Size(71, 15);
            labelEbusinessId.TabIndex = 7;
            labelEbusinessId.Text = "EbusinessId:";
            // 
            // textBoxEbusinessId
            // 
            textBoxEbusinessId.Location = new Point(262, 21);
            textBoxEbusinessId.Name = "textBoxEbusinessId";
            textBoxEbusinessId.Size = new Size(153, 23);
            textBoxEbusinessId.TabIndex = 6;
            textBoxEbusinessId.Text = "itauf.007657653";
            // 
            // checkedListBoxOperacoesRealizadas
            // 
            checkedListBoxOperacoesRealizadas.FormattingEnabled = true;
            checkedListBoxOperacoesRealizadas.Items.AddRange(new object[] { "Operações Realizadas", "Repasses", "Repasses Gestão", "Zé com Zé", "Exercício de Opções", "Liquidação de Aluguel", "Operações Estruturada", "Posição" });
            checkedListBoxOperacoesRealizadas.Location = new Point(10, 22);
            checkedListBoxOperacoesRealizadas.Name = "checkedListBoxOperacoesRealizadas";
            checkedListBoxOperacoesRealizadas.Size = new Size(184, 148);
            checkedListBoxOperacoesRealizadas.TabIndex = 7;
            checkedListBoxOperacoesRealizadas.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(checkedListBoxOperacoesRealizadas);
            groupBox3.Location = new Point(26, 32);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 178);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Operações e Posição";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(groupBox5);
            groupBox4.Controls.Add(groupBox3);
            groupBox4.Location = new Point(29, 297);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(476, 228);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Telas SAG";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(checkedListBox2);
            groupBox5.Location = new Point(253, 32);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(200, 178);
            groupBox5.TabIndex = 9;
            groupBox5.TabStop = false;
            groupBox5.Text = "Middle Office";
            // 
            // checkedListBox2
            // 
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Items.AddRange(new object[] { "Distribuição BMF - Histórico", "Distribuição BMF - Envio" });
            checkedListBox2.Location = new Point(9, 22);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(185, 40);
            checkedListBox2.TabIndex = 0;
            // 
            // painelStatusExecucao
            // 
            painelStatusExecucao.Location = new Point(520, 35);
            painelStatusExecucao.Name = "painelStatusExecucao";
            painelStatusExecucao.ReadOnly = true;
            painelStatusExecucao.Size = new Size(194, 358);
            painelStatusExecucao.TabIndex = 10;
            painelStatusExecucao.Text = "";
            // 
            // buttonTestes
            // 
            buttonTestes.Location = new Point(566, 448);
            buttonTestes.Name = "buttonTestes";
            buttonTestes.Size = new Size(119, 29);
            buttonTestes.TabIndex = 11;
            buttonTestes.Text = "Realizar Testes";
            buttonTestes.UseVisualStyleBackColor = true;
            buttonTestes.Click += buttonTestes_Click;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(73, 22);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(134, 23);
            textBoxUsuario.TabIndex = 12;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(279, 17);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.PasswordChar = '*';
            textBoxSenha.Size = new Size(140, 23);
            textBoxSenha.TabIndex = 13;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(22, 25);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(50, 15);
            labelUsuario.TabIndex = 14;
            labelUsuario.Text = "Usuário:";
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Location = new Point(234, 20);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(42, 15);
            labelSenha.TabIndex = 15;
            labelSenha.Text = "Senha:";
            labelSenha.Click += label2_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(labelSenha);
            groupBox6.Controls.Add(textBoxSenha);
            groupBox6.Controls.Add(labelUsuario);
            groupBox6.Controls.Add(textBoxUsuario);
            groupBox6.Location = new Point(17, 30);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(436, 65);
            groupBox6.TabIndex = 16;
            groupBox6.TabStop = false;
            groupBox6.Text = "Login";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(groupBox6);
            groupBox7.Controls.Add(groupBox1);
            groupBox7.Controls.Add(groupBox2);
            groupBox7.Location = new Point(29, 12);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(476, 265);
            groupBox7.TabIndex = 17;
            groupBox7.TabStop = false;
            groupBox7.Text = "Dados Execução";
            groupBox7.Enter += groupBox7_Enter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 538);
            Controls.Add(buttonTestes);
            Controls.Add(painelStatusExecucao);
            Controls.Add(groupBox4);
            Controls.Add(groupBox7);
            Name = "Form1";
            Text = "Testes Funcionais SAG";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private RadioButton radioProducao;
        private RadioButton radioHomologacao;
        private GroupBox groupBox1;
        private Label labelURL;
        private Label labelTxtURL;
        private CheckBox checkBoxLoginVirtual;
        private GroupBox groupBox2;
        private Label labelEbusinessId;
        private TextBox textBoxEbusinessId;
        private CheckedListBox checkedListBoxOperacoesRealizadas;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private CheckedListBox checkedListBox2;
        private RichTextBox painelStatusExecucao;
        private Button buttonTestes;
        private TextBox textBoxUsuario;
        private TextBox textBoxSenha;
        private Label labelUsuario;
        private Label labelSenha;
        private GroupBox groupBox6;
        private GroupBox groupBox7;
    }
}