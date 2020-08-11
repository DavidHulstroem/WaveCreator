namespace WaveCreator
{
    partial class NewContainerForm
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ContainerIdInput = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DisplayNameInput = new System.Windows.Forms.TextBox();
            this.DescriptionInput = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.NewGroup = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.ContentList = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.CategoryDD = new System.Windows.Forms.ComboBox();
            this.ReferenceDD = new System.Windows.Forms.ComboBox();
            this.Save = new System.Windows.Forms.Button();
            this.QuantityInput = new System.Windows.Forms.NumericUpDown();
            this.referenceInput = new System.Windows.Forms.NumericUpDown();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.CVValue = new System.Windows.Forms.TextBox();
            this.CVId = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.HolderSlotsDD = new System.Windows.Forms.ComboBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.CustomValuesBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.RemoveCV = new System.Windows.Forms.Button();
            this.NewCustomValue = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.RemoveContent = new System.Windows.Forms.Button();
            this.LoadContainerJson = new System.Windows.Forms.Button();
            this.FileBTN = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.referenceInput)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(12, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(139, 13);
            this.textBox3.TabIndex = 8;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "ContainerID";
            // 
            // ContainerIdInput
            // 
            this.ContainerIdInput.Location = new System.Drawing.Point(12, 31);
            this.ContainerIdInput.Name = "ContainerIdInput";
            this.ContainerIdInput.Size = new System.Drawing.Size(100, 20);
            this.ContainerIdInput.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(139, 13);
            this.textBox1.TabIndex = 10;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Display Name";
            // 
            // DisplayNameInput
            // 
            this.DisplayNameInput.Location = new System.Drawing.Point(12, 85);
            this.DisplayNameInput.Name = "DisplayNameInput";
            this.DisplayNameInput.Size = new System.Drawing.Size(100, 20);
            this.DisplayNameInput.TabIndex = 1;
            // 
            // DescriptionInput
            // 
            this.DescriptionInput.Location = new System.Drawing.Point(134, 31);
            this.DescriptionInput.Name = "DescriptionInput";
            this.DescriptionInput.Size = new System.Drawing.Size(169, 65);
            this.DescriptionInput.TabIndex = 2;
            this.DescriptionInput.Text = "";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(134, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(139, 13);
            this.textBox2.TabIndex = 14;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Description";
            // 
            // NewGroup
            // 
            this.NewGroup.Location = new System.Drawing.Point(76, 215);
            this.NewGroup.Name = "NewGroup";
            this.NewGroup.Size = new System.Drawing.Size(75, 23);
            this.NewGroup.TabIndex = 18;
            this.NewGroup.TabStop = false;
            this.NewGroup.Text = "New";
            this.NewGroup.UseVisualStyleBackColor = true;
            this.NewGroup.Click += new System.EventHandler(this.NewGroup_Click);
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(12, 220);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(139, 13);
            this.textBox4.TabIndex = 17;
            this.textBox4.TabStop = false;
            this.textBox4.Text = "Content";
            // 
            // ContentList
            // 
            this.ContentList.FormattingEnabled = true;
            this.ContentList.Location = new System.Drawing.Point(12, 239);
            this.ContentList.Name = "ContentList";
            this.ContentList.Size = new System.Drawing.Size(140, 407);
            this.ContentList.TabIndex = 3;
            this.ContentList.SelectedIndexChanged += new System.EventHandler(this.ContentList_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.8103F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.1897F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel8, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Save, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.QuantityInput, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.referenceInput, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox8, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(504, 399);
            this.tableLayoutPanel1.TabIndex = 19;
            this.tableLayoutPanel1.Visible = false;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.16092F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.83908F));
            this.tableLayoutPanel8.Controls.Add(this.CategoryDD, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.ReferenceDD, 1, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(153, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(348, 24);
            this.tableLayoutPanel8.TabIndex = 37;
            // 
            // CategoryDD
            // 
            this.CategoryDD.FormattingEnabled = true;
            this.CategoryDD.Location = new System.Drawing.Point(3, 3);
            this.CategoryDD.Name = "CategoryDD";
            this.CategoryDD.Size = new System.Drawing.Size(91, 21);
            this.CategoryDD.TabIndex = 0;
            this.CategoryDD.SelectedIndexChanged += new System.EventHandler(this.CategoryDD_SelectedIndexChanged);
            // 
            // ReferenceDD
            // 
            this.ReferenceDD.FormattingEnabled = true;
            this.ReferenceDD.Location = new System.Drawing.Point(100, 3);
            this.ReferenceDD.Name = "ReferenceDD";
            this.ReferenceDD.Size = new System.Drawing.Size(245, 21);
            this.ReferenceDD.TabIndex = 1;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(153, 354);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(296, 42);
            this.Save.TabIndex = 2;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // QuantityInput
            // 
            this.QuantityInput.Location = new System.Drawing.Point(153, 57);
            this.QuantityInput.Name = "QuantityInput";
            this.QuantityInput.Size = new System.Drawing.Size(35, 20);
            this.QuantityInput.TabIndex = 1;
            // 
            // referenceInput
            // 
            this.referenceInput.Location = new System.Drawing.Point(153, 33);
            this.referenceInput.Name = "referenceInput";
            this.referenceInput.Size = new System.Drawing.Size(35, 20);
            this.referenceInput.TabIndex = 0;
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(3, 57);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(70, 13);
            this.textBox7.TabIndex = 21;
            this.textBox7.TabStop = false;
            this.textBox7.Text = "quantity";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(3, 3);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(70, 13);
            this.textBox5.TabIndex = 20;
            this.textBox5.TabStop = false;
            this.textBox5.Text = "referenceID";
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(3, 33);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(70, 13);
            this.textBox6.TabIndex = 21;
            this.textBox6.TabStop = false;
            this.textBox6.Text = "reference";
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(3, 84);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(70, 13);
            this.textBox8.TabIndex = 22;
            this.textBox8.TabStop = false;
            this.textBox8.Text = "CustomValues";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.CustomValuesBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(153, 84);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(256, 250);
            this.tableLayoutPanel2.TabIndex = 27;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(121, 38);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.24528F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.75471F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(132, 209);
            this.tableLayoutPanel5.TabIndex = 21;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.47771F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.52229F));
            this.tableLayoutPanel3.Controls.Add(this.textBox10, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.CVValue, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.CVId, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBox9, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(126, 55);
            this.tableLayoutPanel3.TabIndex = 20;
            this.tableLayoutPanel3.Visible = false;
            // 
            // textBox10
            // 
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Enabled = false;
            this.textBox10.Location = new System.Drawing.Point(4, 31);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(25, 13);
            this.textBox10.TabIndex = 1;
            this.textBox10.TabStop = false;
            this.textBox10.Text = "Value";
            // 
            // CVValue
            // 
            this.CVValue.Location = new System.Drawing.Point(36, 31);
            this.CVValue.Name = "CVValue";
            this.CVValue.Size = new System.Drawing.Size(86, 20);
            this.CVValue.TabIndex = 23;
            // 
            // CVId
            // 
            this.CVId.Location = new System.Drawing.Point(36, 4);
            this.CVId.Name = "CVId";
            this.CVId.Size = new System.Drawing.Size(86, 20);
            this.CVId.TabIndex = 0;
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Enabled = false;
            this.textBox9.Location = new System.Drawing.Point(4, 4);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(25, 13);
            this.textBox9.TabIndex = 21;
            this.textBox9.TabStop = false;
            this.textBox9.Text = "Id";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.96296F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.03704F));
            this.tableLayoutPanel6.Controls.Add(this.HolderSlotsDD, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.textBox11, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.27778F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.72222F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(126, 142);
            this.tableLayoutPanel6.TabIndex = 21;
            // 
            // HolderSlotsDD
            // 
            this.HolderSlotsDD.FormattingEnabled = true;
            this.HolderSlotsDD.Location = new System.Drawing.Point(3, 24);
            this.HolderSlotsDD.Name = "HolderSlotsDD";
            this.HolderSlotsDD.Size = new System.Drawing.Size(98, 21);
            this.HolderSlotsDD.TabIndex = 0;
            // 
            // textBox11
            // 
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Enabled = false;
            this.textBox11.Location = new System.Drawing.Point(3, 3);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(98, 13);
            this.textBox11.TabIndex = 21;
            this.textBox11.TabStop = false;
            this.textBox11.Text = "StoredSlot";
            // 
            // CustomValuesBox
            // 
            this.CustomValuesBox.FormattingEnabled = true;
            this.CustomValuesBox.Location = new System.Drawing.Point(3, 38);
            this.CustomValuesBox.Name = "CustomValuesBox";
            this.CustomValuesBox.Size = new System.Drawing.Size(106, 199);
            this.CustomValuesBox.TabIndex = 0;
            this.CustomValuesBox.SelectedIndexChanged += new System.EventHandler(this.CustomValuesBox_SelectedIndexChanged);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.17094F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.82906F));
            this.tableLayoutPanel7.Controls.Add(this.RemoveCV, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.NewCustomValue, 0, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(112, 29);
            this.tableLayoutPanel7.TabIndex = 23;
            this.tableLayoutPanel7.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel7_Paint);
            // 
            // RemoveCV
            // 
            this.RemoveCV.Location = new System.Drawing.Point(47, 3);
            this.RemoveCV.Name = "RemoveCV";
            this.RemoveCV.Size = new System.Drawing.Size(60, 23);
            this.RemoveCV.TabIndex = 22;
            this.RemoveCV.TabStop = false;
            this.RemoveCV.Text = "Remove";
            this.RemoveCV.UseVisualStyleBackColor = true;
            this.RemoveCV.Click += new System.EventHandler(this.RemoveCV_Click);
            // 
            // NewCustomValue
            // 
            this.NewCustomValue.Location = new System.Drawing.Point(3, 3);
            this.NewCustomValue.Name = "NewCustomValue";
            this.NewCustomValue.Size = new System.Drawing.Size(37, 21);
            this.NewCustomValue.TabIndex = 20;
            this.NewCustomValue.TabStop = false;
            this.NewCustomValue.Text = "New";
            this.NewCustomValue.UseVisualStyleBackColor = true;
            this.NewCustomValue.Click += new System.EventHandler(this.NewCustomValue_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(158, 239);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(512, 407);
            this.tableLayoutPanel4.TabIndex = 20;
            // 
            // RemoveContent
            // 
            this.RemoveContent.Location = new System.Drawing.Point(76, 191);
            this.RemoveContent.Name = "RemoveContent";
            this.RemoveContent.Size = new System.Drawing.Size(75, 23);
            this.RemoveContent.TabIndex = 21;
            this.RemoveContent.TabStop = false;
            this.RemoveContent.Text = "Remove";
            this.RemoveContent.UseVisualStyleBackColor = true;
            this.RemoveContent.Click += new System.EventHandler(this.RemoveContent_Click);
            // 
            // LoadContainerJson
            // 
            this.LoadContainerJson.Location = new System.Drawing.Point(686, 12);
            this.LoadContainerJson.Name = "LoadContainerJson";
            this.LoadContainerJson.Size = new System.Drawing.Size(102, 23);
            this.LoadContainerJson.TabIndex = 34;
            this.LoadContainerJson.Text = "Load Container Json";
            this.LoadContainerJson.UseVisualStyleBackColor = true;
            this.LoadContainerJson.Click += new System.EventHandler(this.LoadContainerJson_Click);
            // 
            // FileBTN
            // 
            this.FileBTN.Location = new System.Drawing.Point(693, 635);
            this.FileBTN.Name = "FileBTN";
            this.FileBTN.Size = new System.Drawing.Size(95, 23);
            this.FileBTN.TabIndex = 35;
            this.FileBTN.Text = "Generate Json";
            this.FileBTN.UseVisualStyleBackColor = true;
            this.FileBTN.Click += new System.EventHandler(this.FileBTN_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // NewContainerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 670);
            this.Controls.Add(this.FileBTN);
            this.Controls.Add(this.LoadContainerJson);
            this.Controls.Add(this.RemoveContent);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.NewGroup);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.ContentList);
            this.Controls.Add(this.DescriptionInput);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DisplayNameInput);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.ContainerIdInput);
            this.Name = "NewContainerForm";
            this.Text = "NewContainerForm";
            this.Load += new System.EventHandler(this.NewContainerForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QuantityInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.referenceInput)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox ContainerIdInput;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox DisplayNameInput;
        private System.Windows.Forms.RichTextBox DescriptionInput;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button NewGroup;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ListBox ContentList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.ComboBox ReferenceDD;
        private System.Windows.Forms.NumericUpDown QuantityInput;
        private System.Windows.Forms.NumericUpDown referenceInput;
        private System.Windows.Forms.ListBox CustomValuesBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button NewCustomValue;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox CVValue;
        private System.Windows.Forms.TextBox CVId;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.ComboBox HolderSlotsDD;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Button RemoveContent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button RemoveCV;
        private System.Windows.Forms.Button LoadContainerJson;
        private System.Windows.Forms.Button FileBTN;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.ComboBox CategoryDD;
    }
}