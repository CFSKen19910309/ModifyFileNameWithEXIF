namespace ModifyFileNameWithEXIF
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Button_Browser = new System.Windows.Forms.Button();
            this.TextBox_FolderPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ListView_Find = new System.Windows.Forms.ListView();
            this.Button_Find = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_DirectoryPath = new System.Windows.Forms.TextBox();
            this.TextBox_FullFileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ListView_Modify = new System.Windows.Forms.ListView();
            this.label9 = new System.Windows.Forms.Label();
            this.Button_DoFileMove = new System.Windows.Forms.Button();
            this.Button_ModifyBatch = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.TextBox_Filter = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Button_DeleteFindItem = new System.Windows.Forms.Button();
            this.Button_DeleteModifyItems = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Button_Modify = new System.Windows.Forms.Button();
            this.DateTimePicker_LastWriteTime = new System.Windows.Forms.DateTimePicker();
            this.DateTimePicker_LastWriteTimeUtc = new System.Windows.Forms.DateTimePicker();
            this.DateTimePicker_LastAccessTimeUtc = new System.Windows.Forms.DateTimePicker();
            this.DateTimePicker_PictureDate = new System.Windows.Forms.DateTimePicker();
            this.DateTimePicker_LastAccessTime = new System.Windows.Forms.DateTimePicker();
            this.TextBox_FileExtension = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_Browser
            // 
            this.Button_Browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_Browser.Location = new System.Drawing.Point(519, 3);
            this.Button_Browser.Name = "Button_Browser";
            this.Button_Browser.Size = new System.Drawing.Size(166, 24);
            this.Button_Browser.TabIndex = 0;
            this.Button_Browser.Text = "Browser";
            this.Button_Browser.UseVisualStyleBackColor = true;
            this.Button_Browser.Click += new System.EventHandler(this.Button_Browser_Click);
            // 
            // TextBox_FolderPath
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.TextBox_FolderPath, 2);
            this.TextBox_FolderPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_FolderPath.Location = new System.Drawing.Point(175, 3);
            this.TextBox_FolderPath.Name = "TextBox_FolderPath";
            this.TextBox_FolderPath.Size = new System.Drawing.Size(338, 25);
            this.TextBox_FolderPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Folder Path:";
            // 
            // ListView_Find
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.ListView_Find, 4);
            this.ListView_Find.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView_Find.FullRowSelect = true;
            this.ListView_Find.GridLines = true;
            this.ListView_Find.Location = new System.Drawing.Point(3, 123);
            this.ListView_Find.MultiSelect = false;
            this.ListView_Find.Name = "ListView_Find";
            this.ListView_Find.Size = new System.Drawing.Size(682, 204);
            this.ListView_Find.TabIndex = 3;
            this.ListView_Find.UseCompatibleStateImageBehavior = false;
            this.ListView_Find.View = System.Windows.Forms.View.Details;
            this.ListView_Find.SelectedIndexChanged += new System.EventHandler(this.ListView_Find_SelectedIndexChanged);
            // 
            // Button_Find
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.Button_Find, 2);
            this.Button_Find.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_Find.Location = new System.Drawing.Point(3, 63);
            this.Button_Find.Name = "Button_Find";
            this.Button_Find.Size = new System.Drawing.Size(338, 24);
            this.Button_Find.TabIndex = 0;
            this.Button_Find.Text = "Find";
            this.Button_Find.UseVisualStyleBackColor = true;
            this.Button_Find.Click += new System.EventHandler(this.Button_Find_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "DirectoryPath :";
            // 
            // TextBox_DirectoryPath
            // 
            this.TextBox_DirectoryPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_DirectoryPath.Location = new System.Drawing.Point(175, 333);
            this.TextBox_DirectoryPath.Name = "TextBox_DirectoryPath";
            this.TextBox_DirectoryPath.Size = new System.Drawing.Size(166, 25);
            this.TextBox_DirectoryPath.TabIndex = 1;
            // 
            // TextBox_FullFileName
            // 
            this.TextBox_FullFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_FullFileName.Location = new System.Drawing.Point(519, 333);
            this.TextBox_FullFileName.Name = "TextBox_FullFileName";
            this.TextBox_FullFileName.Size = new System.Drawing.Size(166, 25);
            this.TextBox_FullFileName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(347, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "FullFileName :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "LastAccessTime";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(347, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 30);
            this.label5.TabIndex = 2;
            this.label5.Text = "LastAccessTimeUtc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 30);
            this.label6.TabIndex = 2;
            this.label6.Text = "LastWriteTime";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(347, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 30);
            this.label7.TabIndex = 2;
            this.label7.Text = "LastWriteTimeUtc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(347, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 30);
            this.label8.TabIndex = 2;
            this.label8.Text = "PictureDate";
            // 
            // ListView_Modify
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.ListView_Modify, 4);
            this.ListView_Modify.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView_Modify.FullRowSelect = true;
            this.ListView_Modify.GridLines = true;
            this.ListView_Modify.Location = new System.Drawing.Point(3, 63);
            this.ListView_Modify.Name = "ListView_Modify";
            this.ListView_Modify.Size = new System.Drawing.Size(286, 384);
            this.ListView_Modify.TabIndex = 3;
            this.ListView_Modify.UseCompatibleStateImageBehavior = false;
            this.ListView_Modify.View = System.Windows.Forms.View.Details;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 30);
            this.label9.TabIndex = 2;
            this.label9.Text = "File Extension:";
            // 
            // Button_DoFileMove
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.Button_DoFileMove, 2);
            this.Button_DoFileMove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_DoFileMove.Location = new System.Drawing.Point(149, 453);
            this.Button_DoFileMove.Name = "Button_DoFileMove";
            this.Button_DoFileMove.Size = new System.Drawing.Size(140, 24);
            this.Button_DoFileMove.TabIndex = 4;
            this.Button_DoFileMove.Text = "Do File Move";
            this.Button_DoFileMove.UseVisualStyleBackColor = true;
            this.Button_DoFileMove.Click += new System.EventHandler(this.Button_DoFileMove_Click);
            // 
            // Button_ModifyBatch
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.Button_ModifyBatch, 2);
            this.Button_ModifyBatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_ModifyBatch.Location = new System.Drawing.Point(149, 3);
            this.Button_ModifyBatch.Name = "Button_ModifyBatch";
            this.Button_ModifyBatch.Size = new System.Drawing.Size(140, 24);
            this.Button_ModifyBatch.TabIndex = 0;
            this.Button_ModifyBatch.Text = "Modify Batch Name";
            this.Button_ModifyBatch.UseVisualStyleBackColor = true;
            this.Button_ModifyBatch.Click += new System.EventHandler(this.Button_ModifyBatch_Click);
            // 
            // progressBar1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.progressBar1, 3);
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(3, 93);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(510, 24);
            this.progressBar1.TabIndex = 3;
            // 
            // progressBar2
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.progressBar2, 3);
            this.progressBar2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar2.Location = new System.Drawing.Point(3, 33);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(213, 24);
            this.progressBar2.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Filter File:";
            // 
            // TextBox_Filter
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.TextBox_Filter, 3);
            this.TextBox_Filter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_Filter.Location = new System.Drawing.Point(175, 33);
            this.TextBox_Filter.Name = "TextBox_Filter";
            this.TextBox_Filter.Size = new System.Drawing.Size(510, 25);
            this.TextBox_Filter.TabIndex = 1;
            this.TextBox_Filter.Text = "*.bmp+*.jpeg+*.jpg+*.png";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(519, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "/";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(222, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 30);
            this.label12.TabIndex = 2;
            this.label12.Text = "/";
            // 
            // Button_DeleteFindItem
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.Button_DeleteFindItem, 2);
            this.Button_DeleteFindItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_DeleteFindItem.Location = new System.Drawing.Point(347, 63);
            this.Button_DeleteFindItem.Name = "Button_DeleteFindItem";
            this.Button_DeleteFindItem.Size = new System.Drawing.Size(338, 24);
            this.Button_DeleteFindItem.TabIndex = 0;
            this.Button_DeleteFindItem.Text = "Delete Items";
            this.Button_DeleteFindItem.UseVisualStyleBackColor = true;
            this.Button_DeleteFindItem.Click += new System.EventHandler(this.Button_DeleteFindItem_Click);
            // 
            // Button_DeleteModifyItems
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.Button_DeleteModifyItems, 2);
            this.Button_DeleteModifyItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_DeleteModifyItems.Location = new System.Drawing.Point(3, 453);
            this.Button_DeleteModifyItems.Name = "Button_DeleteModifyItems";
            this.Button_DeleteModifyItems.Size = new System.Drawing.Size(140, 24);
            this.Button_DeleteModifyItems.TabIndex = 0;
            this.Button_DeleteModifyItems.Text = "Delete Items";
            this.Button_DeleteModifyItems.UseVisualStyleBackColor = true;
            this.Button_DeleteModifyItems.Click += new System.EventHandler(this.Button_DeleteModifyItems_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 30);
            this.label13.TabIndex = 2;
            this.label13.Text = "Format:";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(76, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 25);
            this.textBox1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(992, 486);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Button_Modify, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.DateTimePicker_LastWriteTime, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.DateTimePicker_LastWriteTimeUtc, 3, 8);
            this.tableLayoutPanel2.Controls.Add(this.DateTimePicker_LastAccessTimeUtc, 3, 7);
            this.tableLayoutPanel2.Controls.Add(this.DateTimePicker_PictureDate, 3, 6);
            this.tableLayoutPanel2.Controls.Add(this.DateTimePicker_LastAccessTime, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.TextBox_FolderPath, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 2, 8);
            this.tableLayoutPanel2.Controls.Add(this.label8, 2, 6);
            this.tableLayoutPanel2.Controls.Add(this.TextBox_FullFileName, 3, 5);
            this.tableLayoutPanel2.Controls.Add(this.label11, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.label5, 2, 7);
            this.tableLayoutPanel2.Controls.Add(this.Button_Browser, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.TextBox_Filter, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.Button_Find, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.Button_DeleteFindItem, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.ListView_Find, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.progressBar1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.TextBox_DirectoryPath, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.TextBox_FileExtension, 1, 6);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(688, 480);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // Button_Modify
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.Button_Modify, 4);
            this.Button_Modify.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_Modify.Location = new System.Drawing.Point(3, 453);
            this.Button_Modify.Name = "Button_Modify";
            this.Button_Modify.Size = new System.Drawing.Size(682, 24);
            this.Button_Modify.TabIndex = 0;
            this.Button_Modify.Text = "Modify";
            this.Button_Modify.UseVisualStyleBackColor = true;
            this.Button_Modify.Click += new System.EventHandler(this.Button_Modify_Click);
            // 
            // DateTimePicker_LastWriteTime
            // 
            this.DateTimePicker_LastWriteTime.CustomFormat = "yyyy-MM-dd-HH-mm-ss";
            this.DateTimePicker_LastWriteTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateTimePicker_LastWriteTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker_LastWriteTime.Location = new System.Drawing.Point(175, 423);
            this.DateTimePicker_LastWriteTime.Name = "DateTimePicker_LastWriteTime";
            this.DateTimePicker_LastWriteTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateTimePicker_LastWriteTime.Size = new System.Drawing.Size(166, 25);
            this.DateTimePicker_LastWriteTime.TabIndex = 4;
            // 
            // DateTimePicker_LastWriteTimeUtc
            // 
            this.DateTimePicker_LastWriteTimeUtc.CustomFormat = "yyyy-MM-dd-HH-mm-ss";
            this.DateTimePicker_LastWriteTimeUtc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateTimePicker_LastWriteTimeUtc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker_LastWriteTimeUtc.Location = new System.Drawing.Point(519, 423);
            this.DateTimePicker_LastWriteTimeUtc.Name = "DateTimePicker_LastWriteTimeUtc";
            this.DateTimePicker_LastWriteTimeUtc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateTimePicker_LastWriteTimeUtc.Size = new System.Drawing.Size(166, 25);
            this.DateTimePicker_LastWriteTimeUtc.TabIndex = 4;
            // 
            // DateTimePicker_LastAccessTimeUtc
            // 
            this.DateTimePicker_LastAccessTimeUtc.CustomFormat = "yyyy-MM-dd-HH-mm-ss";
            this.DateTimePicker_LastAccessTimeUtc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateTimePicker_LastAccessTimeUtc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker_LastAccessTimeUtc.Location = new System.Drawing.Point(519, 393);
            this.DateTimePicker_LastAccessTimeUtc.Name = "DateTimePicker_LastAccessTimeUtc";
            this.DateTimePicker_LastAccessTimeUtc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateTimePicker_LastAccessTimeUtc.Size = new System.Drawing.Size(166, 25);
            this.DateTimePicker_LastAccessTimeUtc.TabIndex = 4;
            // 
            // DateTimePicker_PictureDate
            // 
            this.DateTimePicker_PictureDate.CustomFormat = "yyyy-MM-dd-HH-mm-ss";
            this.DateTimePicker_PictureDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateTimePicker_PictureDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker_PictureDate.Location = new System.Drawing.Point(519, 363);
            this.DateTimePicker_PictureDate.Name = "DateTimePicker_PictureDate";
            this.DateTimePicker_PictureDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateTimePicker_PictureDate.Size = new System.Drawing.Size(166, 25);
            this.DateTimePicker_PictureDate.TabIndex = 4;
            this.DateTimePicker_PictureDate.Value = new System.DateTime(2018, 12, 17, 0, 0, 0, 0);
            // 
            // DateTimePicker_LastAccessTime
            // 
            this.DateTimePicker_LastAccessTime.CustomFormat = "yyyy-MM-dd-HH-mm-ss";
            this.DateTimePicker_LastAccessTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateTimePicker_LastAccessTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker_LastAccessTime.Location = new System.Drawing.Point(175, 393);
            this.DateTimePicker_LastAccessTime.Name = "DateTimePicker_LastAccessTime";
            this.DateTimePicker_LastAccessTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateTimePicker_LastAccessTime.Size = new System.Drawing.Size(166, 25);
            this.DateTimePicker_LastAccessTime.TabIndex = 4;
            // 
            // TextBox_FileExtension
            // 
            this.TextBox_FileExtension.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_FileExtension.Location = new System.Drawing.Point(175, 363);
            this.TextBox_FileExtension.Name = "TextBox_FileExtension";
            this.TextBox_FileExtension.Size = new System.Drawing.Size(166, 25);
            this.TextBox_FileExtension.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.ListView_Modify, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.Button_DoFileMove, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.label12, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.Button_DeleteModifyItems, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.Button_ModifyBatch, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.progressBar2, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(697, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(292, 480);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 486);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_Browser;
        private System.Windows.Forms.TextBox TextBox_FolderPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView ListView_Find;
        private System.Windows.Forms.Button Button_Find;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox_DirectoryPath;
        private System.Windows.Forms.TextBox TextBox_FullFileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView ListView_Modify;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Button_DoFileMove;
        private System.Windows.Forms.Button Button_ModifyBatch;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TextBox_Filter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Button_DeleteFindItem;
        private System.Windows.Forms.Button Button_DeleteModifyItems;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button Button_Modify;
        private System.Windows.Forms.DateTimePicker DateTimePicker_LastAccessTime;
        private System.Windows.Forms.TextBox TextBox_FileExtension;
        private System.Windows.Forms.DateTimePicker DateTimePicker_LastWriteTime;
        private System.Windows.Forms.DateTimePicker DateTimePicker_LastWriteTimeUtc;
        private System.Windows.Forms.DateTimePicker DateTimePicker_LastAccessTimeUtc;
        private System.Windows.Forms.DateTimePicker DateTimePicker_PictureDate;
    }
}

