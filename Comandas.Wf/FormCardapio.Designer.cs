namespace Comandas.Wf
{
    partial class FormCardapio
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
            label1 = new Label();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            btnEditar = new Button();
            dataGridView1 = new DataGridView();
            btnExcluir = new Button();
            btnAdItemCardapio = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 9);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Pesquisar";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(67, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(709, 23);
            textBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Location = new Point(22, 106);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(766, 347);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Itens Pedidos";
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.LightGreen;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Location = new Point(669, 305);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(746, 260);
            dataGridView1.TabIndex = 0;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Salmon;
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Location = new Point(588, 305);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 1;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnAdItemCardapio
            // 
            btnAdItemCardapio.BackColor = Color.White;
            btnAdItemCardapio.FlatAppearance.BorderSize = 0;
            btnAdItemCardapio.FlatStyle = FlatStyle.Flat;
            btnAdItemCardapio.Location = new Point(6, 57);
            btnAdItemCardapio.Name = "btnAdItemCardapio";
            btnAdItemCardapio.Size = new Size(103, 23);
            btnAdItemCardapio.TabIndex = 3;
            btnAdItemCardapio.Text = "+ Item Cardápio";
            btnAdItemCardapio.UseVisualStyleBackColor = false;
            btnAdItemCardapio.Click += btnAdItemCardapio_Click;
            // 
            // FormCardapio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 556);
            Controls.Add(btnAdItemCardapio);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "FormCardapio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fazer Pedido";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private Button btnEditar;
        private Button btnExcluir;
        private DataGridView dataGridView1;
        private Button btnAdItemCardapio;
    }
}