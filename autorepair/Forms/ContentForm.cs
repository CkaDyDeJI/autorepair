﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Xceed.Words.NET;

using Dapper;

using Microsoft.VisualBasic;

using Npgsql;

using Xceed.Document.NET;


namespace autorepair
{
    public partial class ContentForm : Form
    {
        public ContentForm()
        {
            InitializeComponent();
        }

        private void ContentForm_Shown(object sender, EventArgs e)
        {
            var AuthorizationForm = new AuthorizationForm(this);
            AuthorizationForm.ShowDialog();
            if (this.IsDisposed != true)
                userLabel.Text = $"Вы вошли как {Holder.user}";

            if (Holder.user.Contains ("mechanic")) {
                var mecForm = new MechanicForm(this);
                mecForm.MdiParent = this;
                mecForm.Show();

                treeView1.Enabled = false;
                treeView1.Visible = false;
            }
        }


        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Form newForm = new Form();
            switch (treeView1.SelectedNode.Index) {
                case 0:
                    newForm = new MainForm();
                    
                    break;
                case 1:
                    newForm = new AutoForm();
            
                    break;
                case 2:
                    newForm = new OwnerForm();
            
                    break;
                case 3:
                    newForm = new TaskForm();
            
                    break;
                case 4:
                    newForm = new WorkerForm();
            
                    break;
            }

            newForm.MdiParent = this;
            newForm.Show();
        }


        private void AddNewBrandButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (true) {
                var temp = Interaction.InputBox("Enter brand name: ");

                if (temp != "")
                {
                    using (var conn = new NpgsqlConnection(Holder.connectionStr))
                    {
                        conn.Query($"set role {Holder.user}; insert into brands (description) values ('{temp}');");
                    }

                    MessageBox.Show("Brand added successfully", "Cool", MessageBoxButtons.OK);
                    break;
                }
                else
                {
                    if (MessageBox.Show("Incorrect data", "Error", MessageBoxButtons.RetryCancel) == DialogResult.Cancel)
                        break;
                }
            }
        }


        private void AddNewBreakTypeButton_Click(object sender, EventArgs e)
        {
            while (true)
            {
                var temp = Interaction.InputBox("Enter broken part name: ");

                if (temp != "")
                {
                    using (var conn = new NpgsqlConnection(Holder.connectionStr))
                    {
                        conn.Query($"set role {Holder.user}; insert into type_of_repair (description) values ('{temp}');");
                    }

                    MessageBox.Show("Broken type added successfully", "Cool", MessageBoxButtons.OK);
                    break;
                }
                else
                {
                    MessageBox.Show("Incorrect data", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show ("Are you sure you wanna make a report?\nIt could take some time.", "Warning",
                MessageBoxButtons.YesNo) == DialogResult.Yes) {
                saveFileDialog1.ShowDialog();

                createReport(saveFileDialog1.FileName);
            }
        }


        private void createReport(string filePath)
        {
            DocX document = DocX.Create(filePath);

            document.InsertParagraph ("Report about autorepair establishment").Font ("Times New Roman").FontSize (18)
                .Alignment = Alignment.left;
            document.InsertParagraph();


            int brokenCars = 0;
            using (var conn = new NpgsqlConnection(Holder.connectionStr))
            {
                brokenCars =
                    conn.QueryFirst<int>(
                        "select count(*) from task join current_task on current_task.task_id = task.id where current_task.isComplited = false");
            }

            Table mainTable = document.AddTable (5, 2);
            mainTable.Alignment = Alignment.center;
            mainTable.SetWidthsPercentage (new[] { 30.0f, 70.0f });
            mainTable.Design = TableDesign.TableGrid;

            mainTable.Rows[0].Cells[0].Paragraphs[0].Append("Количество ремонтируемых автомобилей: ");
            mainTable.Rows[0].Cells[1].Paragraphs[0].Append (brokenCars.ToString());


            List <Auto_Repair_Worker> newList1;
            using (var conn = new NpgsqlConnection(Holder.connectionStr))
            {
                newList1 =
                    conn.Query<Auto_Repair_Worker>(
                        "select auto.id, auto.creator, auto.model, (task.end_date - task.start_date) || ' days' as duration, concat_ws(' '::text, worker.firstname, worker.lastname) as worker_fio from auto join task on task.auto_id = auto.id join current_task on current_task.task_id = task.id join worker on worker.id = current_task.worker_id").ToList();
            }

            Table addTable1 = document.AddTable (newList1.Count + 1, 5);
            addTable1.Alignment = Alignment.center;
            addTable1.SetWidthsPercentage(new[] { 10.0f, 15.0f, 25.0f, 25.0f, 25.0f });
            addTable1.Design = TableDesign.TableGrid;

            addTable1.Rows[0].Cells[0].Paragraphs[0].Append("Гос номер");
            addTable1.Rows[0].Cells[1].Paragraphs[0].Append("Марка");
            addTable1.Rows[0].Cells[2].Paragraphs[0].Append("Модель");
            addTable1.Rows[0].Cells[3].Paragraphs[0].Append("Длительность ремонта");
            addTable1.Rows[0].Cells[4].Paragraphs[0].Append("ФИО работника");
            for (int i = 1; i < newList1.Count + 1; i++)
            {
                addTable1.Rows[i].Cells[0].Paragraphs[0].Append(newList1[i - 1].id.ToString());
                addTable1.Rows[i].Cells[1].Paragraphs[0].Append(newList1[i - 1].creator);
                addTable1.Rows[i].Cells[2].Paragraphs[0].Append(newList1[i - 1].model);
                addTable1.Rows[i].Cells[3].Paragraphs[0].Append(newList1[i - 1].duration);
                addTable1.Rows[i].Cells[4].Paragraphs[0].Append(newList1[i - 1].worker_fio);
            }


            List <Brand_Repair> newList2;
            using (var conn = new NpgsqlConnection(Holder.connectionStr))
            {
                newList2 =
                    conn.Query<Brand_Repair>(
                        "select distinct(auto.creator), string_agg(task.description, ', ') as description from auto join task on task.auto_id = auto.id group by auto.creator").ToList();
            }

            Table addTable2 = document.AddTable (newList2.Count + 1, 2);
            addTable2.Alignment = Alignment.center;
            addTable2.SetWidthsPercentage(new[] { 30.0f, 70.0f });
            addTable2.Design = TableDesign.TableGrid;

            addTable2.Rows[0].Cells[0].Paragraphs[0].Append ("Производители");
            addTable2.Rows[0].Cells[1].Paragraphs[0].Append("Поломки");
            for (int i = 1; i < newList2.Count + 1; i++) {
                addTable2.Rows[i].Cells[0].Paragraphs[0].Append (newList2[i - 1].creator);
                addTable2.Rows[i].Cells[1].Paragraphs[0].Append (newList2[i - 1].description);
            }


            mainTable.Rows[1].MergeCells(0, 1);
            mainTable.Rows[1].Cells[0].Paragraphs[0].LineSpacingAfter = 6;
            mainTable.Rows[1].Cells[0].Paragraphs[0].LineSpacingBefore = 6;
            mainTable.Rows[1].Height = 30;
            mainTable.Rows[1].Cells[0].FillColor = Color.Gray;
            mainTable.Rows[1].Cells[0].Paragraphs[0].Append("Машины и информация об их ремонте").FontSize(14);
            mainTable.Rows[2].MergeCells(0, 1);
            mainTable.Rows[2].Cells[0].Paragraphs[0].InsertTableBeforeSelf(addTable1);

            mainTable.Rows[3].MergeCells(0, 1);
            mainTable.Rows[3].Cells[0].Paragraphs[0].LineSpacingAfter = 6;
            mainTable.Rows[3].Cells[0].Paragraphs[0].LineSpacingBefore = 6;
            mainTable.Rows[3].Height = 30;
            mainTable.Rows[3].Cells[0].FillColor = Color.Gray;
            mainTable.Rows[3].Cells[0].Paragraphs[0].Append ("Производители и типы поломок у них").FontSize(14);
            mainTable.Rows[4].MergeCells(0, 1);
            mainTable.Rows[4].Cells[0].Paragraphs[0].InsertTableBeforeSelf (addTable2);


            document.InsertTable (mainTable);

            document.Save();
        }


        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show ("Program for administrating auto repair shop.\nAll rights reserved.\n(c) Shmelev Grigory 2020", "About",
                MessageBoxButtons.OK);
        }
    }
}