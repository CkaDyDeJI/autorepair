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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Основное содержимое");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Машины");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Владельцы");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Задачи");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Работники");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Таблицы", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBrandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBrokeTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportButton = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.userLabel = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.kursachDataSet = new autorepair.KursachDataSet();
            this.main_informationTableAdapter = new autorepair.KursachDataSetTableAdapters.main_informationTableAdapter();
            this.tableAdapterManager = new autorepair.KursachDataSetTableAdapters.TableAdapterManager();
            this.autoTableAdapter = new autorepair.KursachDataSetTableAdapters.autoTableAdapter();
            this.ownerTableAdapter = new autorepair.KursachDataSetTableAdapters.ownerTableAdapter();
            this.taskTableAdapter = new autorepair.KursachDataSetTableAdapters.taskTableAdapter();
            this.workerTableAdapter = new autorepair.KursachDataSetTableAdapters.workerTableAdapter();
            this.main_informationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ownerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kursachDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.main_informationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Основное содержимое";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Машины";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Владельцы";
            treeNode4.Name = "Node4";
            treeNode4.Text = "Задачи";
            treeNode5.Name = "Node5";
            treeNode5.Text = "Работники";
            treeNode6.Name = "Node0";
            treeNode6.Text = "Таблицы";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(150, 286);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.reportButton,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(870, 24);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewBrandToolStripMenuItem,
            this.addNewBrokeTypeToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(66, 20);
            this.toolStripMenuItem1.Text = "Add new";
            // 
            // addNewBrandToolStripMenuItem
            // 
            this.addNewBrandToolStripMenuItem.Name = "addNewBrandToolStripMenuItem";
            this.addNewBrandToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.addNewBrandToolStripMenuItem.Text = "Добавить нового произв";
            this.addNewBrandToolStripMenuItem.Click += new System.EventHandler(this.AddNewBrandButtonToolStripMenuItem_Click);
            // 
            // addNewBrokeTypeToolStripMenuItem
            // 
            this.addNewBrokeTypeToolStripMenuItem.Name = "addNewBrokeTypeToolStripMenuItem";
            this.addNewBrokeTypeToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.addNewBrokeTypeToolStripMenuItem.Text = "Добавить новый тип поломки";
            this.addNewBrokeTypeToolStripMenuItem.Click += new System.EventHandler(this.AddNewBreakTypeButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.BackColor = System.Drawing.SystemColors.Control;
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(88, 20);
            this.reportButton.Text = "Create report";
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.userLabel);
            this.splitContainer1.Size = new System.Drawing.Size(150, 573);
            this.splitContainer1.SplitterDistance = 286;
            this.splitContainer1.TabIndex = 3;
            // 
            // userLabel
            // 
            this.userLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.userLabel.Location = new System.Drawing.Point(0, 260);
            this.userLabel.Margin = new System.Windows.Forms.Padding(15);
            this.userLabel.Name = "userLabel";
            this.userLabel.Padding = new System.Windows.Forms.Padding(5);
            this.userLabel.Size = new System.Drawing.Size(150, 23);
            this.userLabel.TabIndex = 0;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "\"Word files (*.docx)|*.docx\"";
            // 
            // kursachDataSet
            // 
            this.kursachDataSet.DataSetName = "KursachDataSet";
            this.kursachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // main_informationTableAdapter
            // 
            this.main_informationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.autoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.brandsTableAdapter = null;
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
            // main_informationBindingSource
            // 
            this.main_informationBindingSource.DataMember = "main_information";
            this.main_informationBindingSource.DataSource = this.kursachDataSet;
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
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(52, 20);
            this.toolStripMenuItem2.Text = "About";
            // 
            // ContentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(870, 597);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ContentForm";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.ContentForm_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kursachDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.main_informationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TreeView treeView1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewBrandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewBrokeTypeToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.ToolStripMenuItem reportButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}