using Microsoft.Identity.Client;
using System.Windows.Forms;
using 員工資料管理.Models;

namespace 員工資料管理
{
    public partial class Form1 : Form
    {
        private Form2 newForm;
        public Form1()
        {
            InitializeComponent();
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

        /*public 員工資料模型 currentEmployeeData { get; private set; } = new 員工資料模型
        {
            LDF_登入密碼 = "password",
            LDF_操作權限 = "admin",
            性別 = "男性",
            建檔人 = "admin",
            建檔日期 = System.DateTime.Now,
            員工姓名 = "admin",
            員工編號 = 1000,
            啟停狀態0停用1啟用 = true
        }; */
        public void addButton_Click(object sender, EventArgs e)
        {

            newForm = new Form2(this);

            //newForm.OnDataSaved += newForm_OnDataSaved;
            newForm.MdiParent = this;
            newForm.Show();
        }


        /*public void saveButton_Click(object sender, EventArgs e)
        {
            // 保存 currentEmployeeData 到數據庫
            try
            {
                using (var dbContext = new AppDbContext())
                {
                    var existingEmployee = dbContext.員工資料.Find(currentEmployeeData.員工編號);
                    if (existingEmployee != null)
                    {
                        dbContext.Entry(existingEmployee).CurrentValues.SetValues(currentEmployeeData);
                    }
                    else
                    {
                        dbContext.員工資料.Add(currentEmployeeData);
                    }

                    dbContext.SaveChanges();
                    MessageBox.Show("數據已成功保存到數據庫。", "保存成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"保存數據時發生錯誤：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/
        public void saveButton_Click(object sender, EventArgs e)
        {
            if (newForm != null)
            {
                newForm.saveButton_Click(sender, e);
            }
            else
                MessageBox.Show("Error");
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (newForm != null)
            {
                newForm.editButton_Click(sender, e);
            }
            else MessageBox.Show("編輯檔案失敗");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (newForm != null)
            {
                newForm.deleteButton_Click(sender, e);
            }
            else MessageBox.Show("刪除檔案失敗");
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            string searchTarget = filterText.Text;
            string combobox = filterComboBox1.Text;
            if (newForm != null)
            {
                newForm.filterButton_Click(sender, e, searchTarget, combobox);
            }
            else MessageBox.Show("尚未開啟檔案");
        }
    }
}
