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
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(40, 40);
            toolStrip1.Items.AddRange(new ToolStripItem[] { addButton, saveButton, editButton, deleteButton, toolStripSeparator1 });
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
            editButton.Text = "開啟(&O)";
            // 
            // deleteButton
            // 
            deleteButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            deleteButton.Image = (Image)resources.GetObject("deleteButton.Image");
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(44, 44);
            deleteButton.Text = "剪下(&U)";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 47);
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
        private ToolStripButton 列印PToolStripButton;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton deleteButton;
        private ToolStripButton 複製CToolStripButton;
        private ToolStripButton 貼上PToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton 說明LToolStripButton;
    }
}
