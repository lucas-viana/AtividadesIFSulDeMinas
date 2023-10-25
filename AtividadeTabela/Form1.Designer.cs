namespace AtividadeTabela
{
    partial class Form1
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
            this.dgTarefas = new System.Windows.Forms.DataGridView();
            this.TAREFA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_limite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnResolver = new System.Windows.Forms.Button();
            this.txtTarefa = new System.Windows.Forms.TextBox();
            this.dateFinishTask = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgTarefas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTarefas
            // 
            this.dgTarefas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTarefas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgTarefas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTarefas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TAREFA,
            this.data_limite});
            this.dgTarefas.Location = new System.Drawing.Point(82, 72);
            this.dgTarefas.Margin = new System.Windows.Forms.Padding(2);
            this.dgTarefas.Name = "dgTarefas";
            this.dgTarefas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTarefas.Size = new System.Drawing.Size(406, 133);
            this.dgTarefas.TabIndex = 0;
            this.dgTarefas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // TAREFA
            // 
            this.TAREFA.HeaderText = "TAREFA";
            this.TAREFA.Name = "TAREFA";
            // 
            // data_limite
            // 
            this.data_limite.HeaderText = "DATA LIMITE";
            this.data_limite.Name = "data_limite";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(315, 34);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnResolver
            // 
            this.btnResolver.Location = new System.Drawing.Point(413, 36);
            this.btnResolver.Name = "btnResolver";
            this.btnResolver.Size = new System.Drawing.Size(75, 23);
            this.btnResolver.TabIndex = 2;
            this.btnResolver.Text = "RESOLVER";
            this.btnResolver.UseVisualStyleBackColor = true;
            this.btnResolver.Click += new System.EventHandler(this.btnResolver_Click);
            // 
            // txtTarefa
            // 
            this.txtTarefa.Location = new System.Drawing.Point(82, 36);
            this.txtTarefa.Name = "txtTarefa";
            this.txtTarefa.Size = new System.Drawing.Size(115, 20);
            this.txtTarefa.TabIndex = 3;
            // 
            // dateFinishTask
            // 
            this.dateFinishTask.CustomFormat = "dd/MM/yyyy";
            this.dateFinishTask.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFinishTask.Location = new System.Drawing.Point(203, 37);
            this.dateFinishTask.Name = "dateFinishTask";
            this.dateFinishTask.Size = new System.Drawing.Size(106, 20);
            this.dateFinishTask.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateFinishTask);
            this.Controls.Add(this.txtTarefa);
            this.Controls.Add(this.btnResolver);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgTarefas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgTarefas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTarefas;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnResolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAREFA;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_limite;
        private System.Windows.Forms.TextBox txtTarefa;
        private System.Windows.Forms.DateTimePicker dateFinishTask;
    }
}

