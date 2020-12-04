namespace autorepair
{
    partial class ContentForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("mainTable");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("auto");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("owner");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("task");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("worker");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Autorepair", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContentForm));
            this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
            this.contentSplit = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.AddNewBrandButton = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewBreakTypeButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.main_informationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kursachDataSet = new autorepair.KursachDataSet();
            this.autoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ownerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.main_informationTableAdapter = new autorepair.KursachDataSetTableAdapters.main_informationTableAdapter();
            this.tableAdapterManager = new autorepair.KursachDataSetTableAdapters.TableAdapterManager();
            this.autoTableAdapter = new autorepair.KursachDataSetTableAdapters.autoTableAdapter();
            this.ownerTableAdapter = new autorepair.KursachDataSetTableAdapters.ownerTableAdapter();
            this.taskTableAdapter = new autorepair.KursachDataSetTableAdapters.taskTableAdapter();
            this.workerTableAdapter = new autorepair.KursachDataSetTableAdapters.workerTableAdapter();
            this.toolStripContainer2.ContentPanel.SuspendLayout();
            this.toolStripContainer2.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contentSplit)).BeginInit();
            this.contentSplit.Panel1.SuspendLayout();
            this.contentSplit.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_informationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursachDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer2
            // 
            // 
            // toolStripContainer2.ContentPanel
            // 
            this.toolStripContainer2.ContentPanel.Controls.Add(this.contentSplit);
            this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(870, 572);
            this.toolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer2.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer2.Name = "toolStripContainer2";
            this.toolStripContainer2.Size = new System.Drawing.Size(870, 597);
            this.toolStripContainer2.TabIndex = 6;
            this.toolStripContainer2.Text = "toolStripContainer2";
            // 
            // toolStripContainer2.TopToolStripPanel
            // 
            this.toolStripContainer2.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // contentSplit
            // 
            this.contentSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentSplit.Location = new System.Drawing.Point(0, 0);
            this.contentSplit.Name = "contentSplit";
            // 
            // contentSplit.Panel1
            // 
            this.contentSplit.Panel1.Controls.Add(this.treeView1);
            this.contentSplit.Size = new System.Drawing.Size(870, 572);
            this.contentSplit.SplitterDistance = 144;
            this.contentSplit.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "mainTable";
            treeNode2.Name = "Node2";
            treeNode2.Text = "auto";
            treeNode3.Name = "Node3";
            treeNode3.Text = "owner";
            treeNode4.Name = "Node4";
            treeNode4.Text = "task";
            treeNode5.Name = "Node5";
            treeNode5.Text = "worker";
            treeNode6.Name = "Node0";
            treeNode6.Text = "Autorepair";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(144, 572);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(272, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewBrandButton,
            this.AddNewBreakTypeButton});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(108, 22);
            this.toolStripDropDownButton1.Text = "Добавить новое";
            // 
            // AddNewBrandButton
            // 
            this.AddNewBrandButton.Name = "AddNewBrandButton";
            this.AddNewBrandButton.Size = new System.Drawing.Size(240, 22);
            this.AddNewBrandButton.Text = "Добавить новую марку";
            this.AddNewBrandButton.Click += new System.EventHandler(this.AddNewBrandButtonToolStripMenuItem_Click);
            // 
            // AddNewBreakTypeButton
            // 
            this.AddNewBreakTypeButton.Name = "AddNewBreakTypeButton";
            this.AddNewBreakTypeButton.Size = new System.Drawing.Size(240, 22);
            this.AddNewBreakTypeButton.Text = "Добавить новый тип поломки";
            this.AddNewBreakTypeButton.Click += new System.EventHandler(this.AddNewBreakTypeButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(98, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // main_informationBindingSource
            // 
            this.main_informationBindingSource.DataMember = "main_information";
            this.main_informationBindingSource.DataSource = this.kursachDataSet;
            // 
            // kursachDataSet
            // 
            this.kursachDataSet.DataSetName = "KursachDataSet";
            this.kursachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // autoBindingSource
            // 
            this.autoBindingSource.DataMember = "auto";
            this.autoBindingSource.DataSource = this.kursachDataSet;
            // 
            // ownerBindingSource
            // 
            this.ownerBindingSource.DataMember = "owner";
            this.ownerBindingSource.DataSource = this.kursachDataSet;
            // 
            // taskBindingSource
            // 
            this.taskBindingSource.DataMember = "task";
            this.taskBindingSource.DataSource = this.kursachDataSet;
            // 
            // workerBindingSource
            // 
            this.workerBindingSource.DataMember = "worker";
            this.workerBindingSource.DataSource = this.kursachDataSet;
            // 
            // main_informationTableAdapter
            // 
            this.main_informationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.autoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.current_taskTableAdapter = null;
            this.tableAdapterManager.ownerTableAdapter = null;
            this.tableAdapterManager.taskTableAdapter = null;
            this.tableAdapterManager.type_of_repairTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = autorepair.KursachDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.workerTableAdapter = null;
            // 
            // autoTableAdapter
            // 
            this.autoTableAdapter.ClearBeforeFill = true;
            // 
            // ownerTableAdapter
            // 
            this.ownerTableAdapter.ClearBeforeFill = true;
            // 
            // taskTableAdapter
            // 
            this.taskTableAdapter.ClearBeforeFill = true;
            // 
            // workerTableAdapter
            // 
            this.workerTableAdapter.ClearBeforeFill = true;
            // 
            // ContentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(870, 597);
            this.Controls.Add(this.toolStripContainer2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ContentForm";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.ContentForm_Shown);
            this.toolStripContainer2.ContentPanel.ResumeLayout(false);
            this.toolStripContainer2.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer2.TopToolStripPanel.PerformLayout();
            this.toolStripContainer2.ResumeLayout(false);
            this.toolStripContainer2.PerformLayout();
            this.contentSplit.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contentSplit)).EndInit();
            this.contentSplit.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_informationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursachDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private KursachDataSet kursachDataSet;
        private System.Windows.Forms.BindingSource main_informationBindingSource;
        private KursachDataSetTableAdapters.main_informationTableAdapter main_informationTableAdapter;
        private KursachDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.BindingSource autoBindingSource;
        private KursachDataSetTableAdapters.autoTableAdapter autoTableAdapter;
        private System.Windows.Forms.BindingSource ownerBindingSource;
        private KursachDataSetTableAdapters.ownerTableAdapter ownerTableAdapter;
        private System.Windows.Forms.BindingSource taskBindingSource;
        private KursachDataSetTableAdapters.taskTableAdapter taskTableAdapter;
        private System.Windows.Forms.BindingSource workerBindingSource;
        private KursachDataSetTableAdapters.workerTableAdapter workerTableAdapter;
        private System.Windows.Forms.ToolStripContainer toolStripContainer2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem AddNewBrandButton;
        private System.Windows.Forms.ToolStripMenuItem AddNewBreakTypeButton;
        private System.Windows.Forms.SplitContainer contentSplit;
        private System.Windows.Forms.TreeView treeView1;
    }
}