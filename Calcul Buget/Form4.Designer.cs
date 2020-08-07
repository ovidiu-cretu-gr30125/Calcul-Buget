namespace Calcul_Buget
{
    partial class Form4
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venituriBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.db_calculbugetDataSet3 = new Calcul_Buget.db_calculbugetDataSet3();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.contulDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tVADataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheltuieliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_calculbugetDataSet4 = new Calcul_Buget.db_calculbugetDataSet4();
            this.db_calculbugetDataSet2 = new Calcul_Buget.db_calculbugetDataSet2();
            this.venituriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.venituriTableAdapter = new Calcul_Buget.db_calculbugetDataSet2TableAdapters.VenituriTableAdapter();
            this.venituriTableAdapter1 = new Calcul_Buget.db_calculbugetDataSet3TableAdapters.VenituriTableAdapter();
            this.cheltuieliTableAdapter = new Calcul_Buget.db_calculbugetDataSet4TableAdapters.CheltuieliTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.venituriBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_calculbugetDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheltuieliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_calculbugetDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_calculbugetDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.venituriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 463);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(620, 463);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Venituri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(644, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total Cheltuieli";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(316, 486);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contulDataGridViewTextBoxColumn,
            this.sumaDataGridViewTextBoxColumn,
            this.tVADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.venituriBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(350, 429);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // contulDataGridViewTextBoxColumn
            // 
            this.contulDataGridViewTextBoxColumn.DataPropertyName = "Contul";
            this.contulDataGridViewTextBoxColumn.HeaderText = "Contul";
            this.contulDataGridViewTextBoxColumn.Name = "contulDataGridViewTextBoxColumn";
            this.contulDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sumaDataGridViewTextBoxColumn
            // 
            this.sumaDataGridViewTextBoxColumn.DataPropertyName = "Suma";
            this.sumaDataGridViewTextBoxColumn.HeaderText = "Suma";
            this.sumaDataGridViewTextBoxColumn.Name = "sumaDataGridViewTextBoxColumn";
            this.sumaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tVADataGridViewTextBoxColumn
            // 
            this.tVADataGridViewTextBoxColumn.DataPropertyName = "TVA";
            this.tVADataGridViewTextBoxColumn.HeaderText = "TVA";
            this.tVADataGridViewTextBoxColumn.Name = "tVADataGridViewTextBoxColumn";
            this.tVADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // venituriBindingSource1
            // 
            this.venituriBindingSource1.DataMember = "Venituri";
            this.venituriBindingSource1.DataSource = this.db_calculbugetDataSet3;
            // 
            // db_calculbugetDataSet3
            // 
            this.db_calculbugetDataSet3.DataSetName = "db_calculbugetDataSet3";
            this.db_calculbugetDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contulDataGridViewTextBoxColumn1,
            this.sumaDataGridViewTextBoxColumn1,
            this.tVADataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.cheltuieliBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(374, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(350, 429);
            this.dataGridView2.TabIndex = 9;
            // 
            // contulDataGridViewTextBoxColumn1
            // 
            this.contulDataGridViewTextBoxColumn1.DataPropertyName = "Contul";
            this.contulDataGridViewTextBoxColumn1.HeaderText = "Contul";
            this.contulDataGridViewTextBoxColumn1.Name = "contulDataGridViewTextBoxColumn1";
            this.contulDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // sumaDataGridViewTextBoxColumn1
            // 
            this.sumaDataGridViewTextBoxColumn1.DataPropertyName = "Suma";
            this.sumaDataGridViewTextBoxColumn1.HeaderText = "Suma";
            this.sumaDataGridViewTextBoxColumn1.Name = "sumaDataGridViewTextBoxColumn1";
            this.sumaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tVADataGridViewTextBoxColumn1
            // 
            this.tVADataGridViewTextBoxColumn1.DataPropertyName = "TVA";
            this.tVADataGridViewTextBoxColumn1.HeaderText = "TVA";
            this.tVADataGridViewTextBoxColumn1.Name = "tVADataGridViewTextBoxColumn1";
            this.tVADataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cheltuieliBindingSource
            // 
            this.cheltuieliBindingSource.DataMember = "Cheltuieli";
            this.cheltuieliBindingSource.DataSource = this.db_calculbugetDataSet4;
            // 
            // db_calculbugetDataSet4
            // 
            this.db_calculbugetDataSet4.DataSetName = "db_calculbugetDataSet4";
            this.db_calculbugetDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // db_calculbugetDataSet2
            // 
            this.db_calculbugetDataSet2.DataSetName = "db_calculbugetDataSet2";
            this.db_calculbugetDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // venituriBindingSource
            // 
            this.venituriBindingSource.DataMember = "Venituri";
            this.venituriBindingSource.DataSource = this.db_calculbugetDataSet2;
            // 
            // venituriTableAdapter
            // 
            this.venituriTableAdapter.ClearBeforeFill = true;
            // 
            // venituriTableAdapter1
            // 
            this.venituriTableAdapter1.ClearBeforeFill = true;
            // 
            // cheltuieliTableAdapter
            // 
            this.cheltuieliTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(313, 463);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Rezultatul exercitiului";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 547);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balanta";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.venituriBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_calculbugetDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheltuieliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_calculbugetDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_calculbugetDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.venituriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private db_calculbugetDataSet2 db_calculbugetDataSet2;
        private System.Windows.Forms.BindingSource venituriBindingSource;
        private db_calculbugetDataSet2TableAdapters.VenituriTableAdapter venituriTableAdapter;
        private db_calculbugetDataSet3 db_calculbugetDataSet3;
        private System.Windows.Forms.BindingSource venituriBindingSource1;
        private db_calculbugetDataSet3TableAdapters.VenituriTableAdapter venituriTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn contulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tVADataGridViewTextBoxColumn;
        private db_calculbugetDataSet4 db_calculbugetDataSet4;
        private System.Windows.Forms.BindingSource cheltuieliBindingSource;
        private db_calculbugetDataSet4TableAdapters.CheltuieliTableAdapter cheltuieliTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn contulDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tVADataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label3;
    }
}