using System.Windows.Forms;
using System;
using 員工資料管理.Models;

namespace 員工資料管理;
public partial class Form2 : Form
{
    AppDbContext dbContext = new();
    BindingSource bindingSource = [];


    public Form2()
    {
        InitializeComponent();
        this.StartPosition = FormStartPosition.Manual;
        bindingSource.DataSource = dbContext.員工資料.ToList();
        dataGridView.DataSource = bindingSource;
    }

    private void Form2_Load(object sender, EventArgs e)
    {
        dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridView.DefaultCellStyle.ForeColor = Color.White;
        dataGridView.DefaultCellStyle.BackColor = Color.Black;
        dataGridView.DefaultCellStyle.SelectionForeColor = Color.Yellow;
        dataGridView.DefaultCellStyle.SelectionBackColor = Color.Black;
        dataGridView.Columns["員工編號"].Frozen = true;
        dataGridView.Columns["員工編號"].Width = 120;
        dataGridView.Columns["員工姓名"].Frozen = true;
        dataGridView.Columns["員工姓名"].Width = 280;

    }




    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void EmployeeName_Click(object sender, EventArgs e)
    {

    }

    private void label1_Click_1(object sender, EventArgs e)
    {

    }

    private void label1_Click_2(object sender, EventArgs e)
    {

    }

    private void label1_Click_3(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void Panel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void panel2_Paint(object sender, PaintEventArgs e)
    {

    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void Software_Password_Click(object sender, EventArgs e)
    {

    }

    private void dataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
    {
        DataGridViewRow currentRow = dataGridView.Rows[e.RowIndex];
        BirthDatedate.Value = (DateTime)currentRow.Cells["出生日期"].Value;
        IDNumbertxt.Text = (string)currentRow.Cells["身分證號"].Value;
        Software_AccessRightstxt.Text = (string)currentRow.Cells["軟體登入權限"].Value;
        Software_PermissionGroupcombo = new ComboBox();
        Software_Passwordtxt.Text= (string)currentRow.Cells["軟體登入密碼"].Value;
        Software_LoginIDtxt.Text = (string)currentRow.Cells["軟體登入帳號"].Value;
        LDF_AccessRightscombo = new ComboBox();
        LDF_Passwordtxt.Text = (string)currentRow.Cells["LDF_登入密碼"].Value;
        EmployeeNametxt.Text = (string)currentRow.Cells["員工姓名"].Value;
        EmployeeIDtxt.Text = (string)currentRow.Cells["員工編號"].Value;
        HomeAddresstxt.Text = (string)currentRow.Cells["住家地址"].Value;
        EmergencyContactNametxt.Text = (string)currentRow.Cells["聯絡人姓名"].Value;
        Gendercombo = new ComboBox();
        MobilePhonetxt.Text = (string)currentRow.Cells["行動電話"].Value;
        Hiredate.Value = (DateTime)currentRow.Cells["到職日期"].Value;
        resignationdate.Value = (DateTime)currentRow.Cells["離職日期"].Value;
        Departmentcombo = new ComboBox();
        Positioncombo = new ComboBox();
        Educationcombo = new ComboBox();
        Mailing_Addresstxt.Text = (string)currentRow.Cells["通訊地址"].Value;
        MailingPhonetxt.Text = (string)currentRow.Cells["通訊電話"].Value;
        HomePhonetxt.Text = (string)currentRow.Cells["住家電話"].Value;
        EmergencyContactPhonetxt.Text = (string)currentRow.Cells["連絡人電話"].Value;
        Notestxt.Text = (string)currentRow.Cells["備註"].Value;
        CreatedBycombo = new ComboBox();
        CreatedDatedate.Value = (DateTime)currentRow.Cells["建檔日期"].Value;
        IsActivecheck.Checked = (bool)currentRow.Cells["啟停狀態0停用1啟用"].Value;

    }
    public void SaveData()
    {
        try
        {
            // 獲取當前選中的行
            //if (dataGridView.CurrentRow != null)
            {
                int index = dataGridView.CurrentRow.Index;
                var employee = (員工資料模型)bindingSource[index];

                // 更新員工資料
                employee.員工編號 = int.Parse(EmployeeIDtxt.Text);
                employee.員工姓名 = EmployeeNametxt.Text;
                employee.身分證號 = IDNumbertxt.Text;
                employee.出生日期 = BirthDatedate.Value;
                employee.性別 = Gendercombo.SelectedItem?.ToString();
                employee.行動電話 = MobilePhonetxt.Text;
                employee.到職日期 = Hiredate.Value;
                employee.離職日期 = resignationdate.Value;
                employee.部門 = Departmentcombo.SelectedItem?.ToString();
                employee.職務 = Positioncombo.SelectedItem?.ToString();
                employee.學歷 = Educationcombo.SelectedItem?.ToString();
                employee.通訊地址 = Mailing_Addresstxt.Text;
                employee.通訊電話 = MailingPhonetxt.Text;
                employee.住家電話 = HomePhonetxt.Text;
                employee.住家地址 = HomeAddresstxt.Text;
                employee.聯絡人姓名 = EmergencyContactNametxt.Text;
                employee.連絡人電話 = EmergencyContactPhonetxt.Text;
                employee.LDF_登入密碼 = LDF_Passwordtxt.Text;
                employee.LDF_操作權限 = LDF_AccessRightscombo.SelectedItem?.ToString();
                employee.軟體登入帳號 = Software_LoginIDtxt.Text;
                employee.軟體登入密碼 = Software_Passwordtxt.Text;
                employee.軟體權限群組 = Software_PermissionGroupcombo.SelectedItem?.ToString();
                employee.軟體登入權限 = Software_AccessRightstxt.Text;
                employee.備註 = Notestxt.Text;
                employee.建檔人 = CreatedBycombo.SelectedItem?.ToString();
                employee.建檔日期 = CreatedDatedate.Value;
                employee.啟停狀態0停用1啟用 = IsActivecheck.Checked;

                // 保存更改到數據庫
                dbContext.SaveChanges();

                // 刷新 DataGridView
                bindingSource.ResetCurrentItem();

                MessageBox.Show("數據已成功保存。", "保存成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            /*else
            {
                MessageBox.Show("請先選擇一個員工記錄。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
        }
        catch (Exception ex)
        {
            MessageBox.Show($"保存數據時發生錯誤：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void textBox15_TextChanged(object sender, EventArgs e)
    {

    }
}
