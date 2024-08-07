using System.Windows.Forms;
using 員工資料管理.Models;

namespace 員工資料管理
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            saveButton.Click += saveButton_Click;
        }

        /*private void MainForm_Load(object sender, EventArgs e )
        {
            //ToolStripMenuItem StaffFile = new ToolStripMenuItem("員工資料");
            //StaffFile.Click += 新增NToolStripButton_Click_1;

        }*/


        /*private void 新增NToolStripButton_Click_1(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.MdiParent = this;
            newForm.Show();
        }*/
        /*private void InitializeToolStrip()
        {
            toolStrip1 = new ToolStrip();

            refreshButton = new ToolStripButton("Refresh");
            addButton = new ToolStripButton("Add");
            editButton = new ToolStripButton("Edit");
            deleteButton = new ToolStripButton("Delete");


            toolStrip1.Items.Add(refreshButton);
            toolStrip1.Items.Add(addButton);
            toolStrip1.Items.Add(editButton);
            toolStrip1.Items.Add(deleteButton);


            this.Controls.Add(toolStrip1);
        }*/
        /*private void InitMenuEvent()
        {
            refreshButton.Click += (s, e) =>
            {
                if (currentForm is MenuAction action)
                {
                    action.ProcessRefresh(s, e);
                }
            };
            addButton.Click += (s, e) =>
            {
                if (currentForm is MenuAction action)
                {
                    action.ProcessAdd(s, e);
                }
            };
            editButton.Click += (s, e) =>
            {
                if (currentForm is MenuAction action)
                {
                    action.ProcessEdit(s, e);
                }
            };
            deleteButton.Click += (s, e) =>
            {
                if (currentForm is MenuAction action)
                {
                    action.ProcessDelete(s, e);
                }
            };
        }
        private void LoadForm(Form form)
        {
            currentForm?.Close();
            currentForm = form;
            form.MdiParent = this;
            form.Show();
            RefreshButton(form);
        }
        private void RefreshButton(Form form)
        {
            MenuAction action = form as MenuAction;
            if (action != null)
            {
                refreshButton.Enabled = action.HasEventRefresh;
                addButton.Enabled = action.HasEventAdd;
                editButton.Enabled = action.HasEventEdit;
                deleteButton.Enabled = action.HasEventDelete;
            }
        }
        private void OpenFrmApplicationMenu()
        {
            Form2 form = new Form2();
            LoadForm(form);
        }*/

        private void addButton_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Form2 activeForm2 = this.ActiveMdiChild as Form2;
            if (activeForm2 != null)
            {
                activeForm2.SaveData();
            }
            else
            {
                MessageBox.Show("沒有打開的員工資料表單可以儲存。");
            }
        }
    }
}
