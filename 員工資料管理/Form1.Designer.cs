namespace 員工資料管理
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            addButton = new ToolStripButton();
            saveButton = new ToolStripButton();
            editButton = new ToolStripButton();
            deleteButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel1 = new ToolStripLabel();
            filterComboBox1 = new ToolStripComboBox();
            toolStripLabel2 = new ToolStripLabel();
            filterText = new ToolStripTextBox();
            filterButton = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(40, 40);
            toolStrip1.Items.AddRange(new ToolStripItem[] { addButton, saveButton, editButton, deleteButton, toolStripSeparator1, toolStripLabel1, filterComboBox1, toolStripLabel2, filterText, filterButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1262, 47);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // addButton
            // 
            addButton.CheckOnClick = true;
            addButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            addButton.Image = (Image)resources.GetObject("addButton.Image");
            addButton.Name = "addButton";
            addButton.Size = new Size(44, 44);
            addButton.Text = "新增(&N)";
            addButton.Click += addButton_Click;
            // 
            // saveButton
            // 
            saveButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            saveButton.Image = (Image)resources.GetObject("saveButton.Image");
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(44, 44);
            saveButton.Text = "儲存(&S)";
            saveButton.Click += saveButton_Click;
            // 
            // editButton
            // 
            editButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            editButton.Image = (Image)resources.GetObject("editButton.Image");
            editButton.Name = "editButton";
            editButton.Size = new Size(44, 44);
            editButton.Text = "修改(&O)";
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            deleteButton.Image = (Image)resources.GetObject("deleteButton.Image");
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(44, 44);
            deleteButton.Text = "刪除(&U)";
            deleteButton.Click += deleteButton_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 47);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Margin = new Padding(370, 1, 0, 2);
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(39, 44);
            toolStripLabel1.Text = "欄位";
            // 
            // filterComboBox1
            // 
            filterComboBox1.Items.AddRange(new object[] { "員工姓名", "身分證號", "性別", "行動電話", "部門", "職務", "學歷", "通訊地址", "通訊電話", "住家電話", "住家地址", "聯絡人姓名", "連絡人電話", "LDF_登入密碼", "LDF_操作權限", "軟體登入帳號", "軟體登入密碼", "軟體權限群組", "軟體登入權限", "備註", "建檔人" });
            filterComboBox1.Name = "filterComboBox1";
            filterComboBox1.Size = new Size(121, 47);
            filterComboBox1.Click += toolStripComboBox1_Click;
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Margin = new Padding(10, 1, 0, 2);
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(39, 44);
            toolStripLabel2.Text = "含有";
            // 
            // filterText
            // 
            filterText.BorderStyle = BorderStyle.FixedSingle;
            filterText.Name = "filterText";
            filterText.Size = new Size(100, 47);
            // 
            // filterButton
            // 
            filterButton.BackColor = SystemColors.ButtonShadow;
            filterButton.ImageTransparentColor = Color.Indigo;
            filterButton.Margin = new Padding(5, 1, 0, 2);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(43, 44);
            filterButton.Text = "篩選";
            filterButton.Click += filterButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 477);
            Controls.Add(toolStrip1);
            IsMdiContainer = true;
            Name = "Form1";
            Text = "後臺主畫面";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        public ToolStripButton addButton;
        private ToolStripButton editButton;
        public ToolStripButton saveButton;
        private ToolStripButton deleteButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripLabel toolStripLabel2;
        public ToolStripButton filterButton;
        public ToolStripComboBox filterComboBox1;
        public ToolStripTextBox filterText;
    }
}
