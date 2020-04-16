namespace Store_Manager
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.storeGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StoreDGV = new System.Windows.Forms.DataGridView();
            this.storeEFDBDataSet = new Store_Manager.StoreEFDBDataSet();
            this.storeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeTableAdapter = new Store_Manager.StoreEFDBDataSetTableAdapters.StoreTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.sidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smanagerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StoreDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeEFDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(73, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(73, 71);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 47);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(73, 124);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 20);
            this.textBox4.TabIndex = 3;
            // 
            // storeGroupBox
            // 
            this.storeGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.storeGroupBox.Controls.Add(this.button3);
            this.storeGroupBox.Controls.Add(this.button2);
            this.storeGroupBox.Controls.Add(this.button1);
            this.storeGroupBox.Controls.Add(this.StoreDGV);
            this.storeGroupBox.Controls.Add(this.label2);
            this.storeGroupBox.Controls.Add(this.label3);
            this.storeGroupBox.Controls.Add(this.label4);
            this.storeGroupBox.Controls.Add(this.label1);
            this.storeGroupBox.Controls.Add(this.textBox1);
            this.storeGroupBox.Controls.Add(this.textBox4);
            this.storeGroupBox.Controls.Add(this.textBox2);
            this.storeGroupBox.Controls.Add(this.textBox3);
            this.storeGroupBox.Location = new System.Drawing.Point(29, 33);
            this.storeGroupBox.Name = "storeGroupBox";
            this.storeGroupBox.Size = new System.Drawing.Size(706, 289);
            this.storeGroupBox.TabIndex = 4;
            this.storeGroupBox.TabStop = false;
            this.storeGroupBox.Text = "Store";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Manager";
            // 
            // StoreDGV
            // 
            this.StoreDGV.AutoGenerateColumns = false;
            this.StoreDGV.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.StoreDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StoreDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sidDataGridViewTextBoxColumn,
            this.snameDataGridViewTextBoxColumn,
            this.saddressDataGridViewTextBoxColumn,
            this.smanagerDataGridViewTextBoxColumn});
            this.StoreDGV.DataSource = this.storeBindingSource;
            this.StoreDGV.Location = new System.Drawing.Point(223, 19);
            this.StoreDGV.Name = "StoreDGV";
            this.StoreDGV.Size = new System.Drawing.Size(443, 192);
            this.StoreDGV.TabIndex = 5;
            this.StoreDGV.DoubleClick += new System.EventHandler(this.StoreDGV_DoubleClick);
            // 
            // storeEFDBDataSet
            // 
            this.storeEFDBDataSet.DataSetName = "StoreEFDBDataSet";
            this.storeEFDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storeBindingSource
            // 
            this.storeBindingSource.DataMember = "Store";
            this.storeBindingSource.DataSource = this.storeEFDBDataSet;
            // 
            // storeTableAdapter
            // 
            this.storeTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(73, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(771, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // itemsToolStripMenuItem
            // 
            this.itemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.storeToolStripMenuItem1,
            this.categoryToolStripMenuItem1,
            this.supplierToolStripMenuItem1,
            this.customerToolStripMenuItem1});
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.itemsToolStripMenuItem.Text = "Items";
            // 
            // storeToolStripMenuItem1
            // 
            this.storeToolStripMenuItem1.Name = "storeToolStripMenuItem1";
            this.storeToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.storeToolStripMenuItem1.Text = "Store";
            this.storeToolStripMenuItem1.Click += new System.EventHandler(this.storeToolStripMenuItem1_Click);
            // 
            // categoryToolStripMenuItem1
            // 
            this.categoryToolStripMenuItem1.Name = "categoryToolStripMenuItem1";
            this.categoryToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.categoryToolStripMenuItem1.Text = "Category";
            // 
            // supplierToolStripMenuItem1
            // 
            this.supplierToolStripMenuItem1.Name = "supplierToolStripMenuItem1";
            this.supplierToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.supplierToolStripMenuItem1.Text = "Supplier";
            // 
            // customerToolStripMenuItem1
            // 
            this.customerToolStripMenuItem1.Name = "customerToolStripMenuItem1";
            this.customerToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.customerToolStripMenuItem1.Text = "Customer";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(591, 244);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // sidDataGridViewTextBoxColumn
            // 
            this.sidDataGridViewTextBoxColumn.DataPropertyName = "s_id";
            this.sidDataGridViewTextBoxColumn.HeaderText = "Id";
            this.sidDataGridViewTextBoxColumn.Name = "sidDataGridViewTextBoxColumn";
            // 
            // snameDataGridViewTextBoxColumn
            // 
            this.snameDataGridViewTextBoxColumn.DataPropertyName = "s_name";
            this.snameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.snameDataGridViewTextBoxColumn.Name = "snameDataGridViewTextBoxColumn";
            // 
            // saddressDataGridViewTextBoxColumn
            // 
            this.saddressDataGridViewTextBoxColumn.DataPropertyName = "s_address";
            this.saddressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.saddressDataGridViewTextBoxColumn.Name = "saddressDataGridViewTextBoxColumn";
            // 
            // smanagerDataGridViewTextBoxColumn
            // 
            this.smanagerDataGridViewTextBoxColumn.DataPropertyName = "s_manager";
            this.smanagerDataGridViewTextBoxColumn.HeaderText = "Manager";
            this.smanagerDataGridViewTextBoxColumn.Name = "smanagerDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(771, 358);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.storeGroupBox);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Store Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.storeGroupBox.ResumeLayout(false);
            this.storeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StoreDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeEFDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox storeGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView StoreDGV;
        private StoreEFDBDataSet storeEFDBDataSet;
        private System.Windows.Forms.BindingSource storeBindingSource;
        private StoreEFDBDataSetTableAdapters.StoreTableAdapter storeTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn sidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn smanagerDataGridViewTextBoxColumn;
    }
}

