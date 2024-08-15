using System.Windows.Forms;
using System;
using 員工資料管理.Models;
namespace 員工資料管理;
public partial class Form2 : Form
{
    AppDbContext dbContext = new();
    BindingSource bindingSource = [];
    private 員工資料模型 currentEmployeeData;
    //public event Action<員工資料模型> OnDataSaved;
    private Form1 frm;


    public Form2(Form1 form1)
    {
        InitializeComponent();
        frm = form1;
        this.currentEmployeeData = currentEmployeeData;
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

    private void dataGridView_RowEnter_1(object sender, DataGridViewCellEventArgs e)
    {
        DataGridViewRow currentRow = dataGridView.Rows[e.RowIndex];
        BirthDatedate.Value = (DateTime)currentRow.Cells["出生日期"].Value;
        IDNumbertxt.Text = (string)currentRow.Cells["身分證號"].Value;
        Software_AccessRightstxt.Text = (string)currentRow.Cells["軟體登入權限"].Value;
        Software_PermissionGroupcombo.SelectedItem = currentRow.Cells["軟體權限群組"];
        Software_Passwordtxt.Text = (string)currentRow.Cells["軟體登入密碼"].Value;
        Software_LoginIDtxt.Text = (string)currentRow.Cells["軟體登入帳號"].Value;
        LDF_AccessRightscombo.SelectedItem = currentRow.Cells["LDF_操作權限"].Value;
        LDF_Passwordtxt.Text = (string)currentRow.Cells["LDF_登入密碼"].Value;
        EmployeeNametxt.Text = (string)currentRow.Cells["員工姓名"].Value;
        EmployeeIDtxt.TabIndex = (int)currentRow.Cells["員工編號"].Value;
        HomeAddresstxt.Text = (string)currentRow.Cells["住家地址"].Value;
        EmergencyContactNametxt.Text = (string)currentRow.Cells["聯絡人姓名"].Value;
        Gendercombo.SelectedItem = currentRow.Cells["性別"].Value;
        MobilePhonetxt.Text = (string)currentRow.Cells["行動電話"].Value;
        Hiredate.Value = (DateTime)currentRow.Cells["到職日期"].Value;
        resignationdate.Value = (DateTime)currentRow.Cells["離職日期"].Value;
        Departmentcombo.SelectedItem = currentRow.Cells["部門"];
        Positioncombo.SelectedItem = currentRow.Cells["職務"];
        Educationcombo.SelectedItem = currentRow.Cells["學歷"];
        Mailing_Addresstxt.Text = (string)currentRow.Cells["通訊地址"].Value;
        MailingPhonetxt.Text = (string)currentRow.Cells["通訊電話"].Value;
        HomePhonetxt.Text = (string)currentRow.Cells["住家電話"].Value;
        EmergencyContactPhonetxt.Text = (string)currentRow.Cells["連絡人電話"].Value;
        Notestxt.Text = (string)currentRow.Cells["備註"].Value;
        CreatedBycombo.SelectedItem = currentRow.Cells["建檔人"];
        CreatedDatedate.Value = (DateTime)currentRow.Cells["建檔日期"].Value;
        IsActivecheck.Checked = (bool)currentRow.Cells["啟停狀態0停用1啟用"].Value;

    }

    /*public void SaveData()
   {
       MessageBox.Show("Here");
       try
       {
           // 獲取當前選中的行
           //if (dataGridView.CurrentRow != null)

               int index = dataGridView.CurrentRow.Index;
               //var employee = (員工資料模型)bindingSource[index];

               // 更新員工資料
               //currentEmployeeData.員工編號 = int.Parse(EmployeeIDtxt.Text);
               currentEmployeeData.員工姓名 = EmployeeNametxt.Text;
               currentEmployeeData.身分證號 = IDNumbertxt.Text;
               currentEmployeeData.出生日期 = BirthDatedate.Value;
               currentEmployeeData.性別 = Gendercombo.SelectedItem?.ToString();
               currentEmployeeData.行動電話 = MobilePhonetxt.Text;
               currentEmployeeData.到職日期 = Hiredate.Value;
               currentEmployeeData.離職日期 = resignationdate.Value;
               currentEmployeeData.部門 = Departmentcombo.SelectedItem?.ToString();
               currentEmployeeData.職務 = Positioncombo.SelectedItem?.ToString();
               currentEmployeeData.學歷 = Educationcombo.SelectedItem?.ToString();
               currentEmployeeData.通訊地址 = Mailing_Addresstxt.Text;
               currentEmployeeData.通訊電話 = MailingPhonetxt.Text;
               currentEmployeeData.住家電話 = HomePhonetxt.Text;
               currentEmployeeData.住家地址 = HomeAddresstxt.Text;
               currentEmployeeData.聯絡人姓名 = EmergencyContactNametxt.Text;
               currentEmployeeData.連絡人電話 = EmergencyContactPhonetxt.Text;
               currentEmployeeData.LDF_登入密碼 = LDF_Passwordtxt.Text;
               currentEmployeeData.LDF_操作權限 = LDF_AccessRightscombo.SelectedItem?.ToString();
               currentEmployeeData.軟體登入帳號 = Software_LoginIDtxt.Text;
               currentEmployeeData.軟體登入密碼 = Software_Passwordtxt.Text;
               currentEmployeeData.軟體權限群組 = Software_PermissionGroupcombo.SelectedItem?.ToString();
               currentEmployeeData.軟體登入權限 = Software_AccessRightstxt.Text;
               currentEmployeeData.備註 = Notestxt.Text;
               currentEmployeeData.建檔人 = CreatedBycombo.SelectedItem?.ToString();
               currentEmployeeData.建檔日期 = CreatedDatedate.Value;
               currentEmployeeData.啟停狀態0停用1啟用 = IsActivecheck.Checked;

               //OnDataSaved?.Invoke(currentEmployeeData);
               // 保存更改到數據庫
               dbContext.SaveChanges();

               // 刷新 DataGridView
               bindingSource.ResetCurrentItem();

               MessageBox.Show("數據已成功保存。", "保存成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

           /*else
           {
               MessageBox.Show("請先選擇一個員工記錄。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           }*//*
       }
       catch (Exception ex)
       {
           MessageBox.Show($"保存數據時發生錯誤：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
       }
   }*/

    public void saveButton_Click(object sender, EventArgs e)
    {
        //try
        //{
        // 假設這裡已經更新好了員工資料模型
        員工資料模型 employeeData = new 員工資料模型
        {
            LDF_登入密碼 = "password",
            LDF_操作權限 = "admin",
            性別 = "男性",
            建檔人 = "admin",
            建檔日期 = System.DateTime.Now,
            員工姓名 = "admin",
            //員工編號 = 0,
            啟停狀態0停用1啟用 = true
        };

        // 通過 Form1 的引用，調用它的公開方法來更新數據
        //employeeData.員工編號 = int.Parse(EmployeeIDtxt.Text);
        employeeData.員工姓名 = EmployeeNametxt.Text;
        employeeData.身分證號 = IDNumbertxt.Text;
        employeeData.出生日期 = BirthDatedate.Value;
        employeeData.性別 = "male";//Gendercombo.SelectedItem?.ToString();
        employeeData.行動電話 = MobilePhonetxt.Text;
        employeeData.到職日期 = Hiredate.Value;
        employeeData.離職日期 = resignationdate.Value;
        employeeData.部門 = Departmentcombo.SelectedItem?.ToString();
        employeeData.職務 = Positioncombo.SelectedItem?.ToString();
        employeeData.學歷 = Educationcombo.SelectedItem?.ToString();
        employeeData.通訊地址 = Mailing_Addresstxt.Text;
        employeeData.通訊電話 = MailingPhonetxt.Text;
        employeeData.住家電話 = HomePhonetxt.Text;
        employeeData.住家地址 = HomeAddresstxt.Text;
        employeeData.聯絡人姓名 = EmergencyContactNametxt.Text;
        employeeData.連絡人電話 = EmergencyContactPhonetxt.Text;
        employeeData.LDF_登入密碼 = LDF_Passwordtxt.Text;
        employeeData.LDF_操作權限 = "admin";//LDF_AccessRightscombo.SelectedItem?.ToString();
        employeeData.軟體登入帳號 = Software_LoginIDtxt.Text;
        employeeData.軟體登入密碼 = Software_Passwordtxt.Text;
        employeeData.軟體權限群組 = Software_PermissionGroupcombo.SelectedItem?.ToString();
        employeeData.軟體登入權限 = Software_AccessRightstxt.Text;
        employeeData.備註 = Notestxt.Text;
        employeeData.建檔人 = "ADMIN";//CreatedBycombo.SelectedItem?.ToString();
        employeeData.建檔日期 = CreatedDatedate.Value;
        employeeData.啟停狀態0停用1啟用 = IsActivecheck.Checked;
        dbContext.Entry(employeeData).State = Microsoft.EntityFrameworkCore.EntityState.Added;
        //dbContext.Entry(employeeData).CurrentValues.SetValues(employeeData);
        dbContext.SaveChanges();
        bindingSource.Add(employeeData);
        bindingSource.ResetBindings(false);
        MessageBox.Show("數據已成功更新到 Form1。", "更新成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
        this.Close(); // 關閉 Form2
                      // }
                      //catch (Exception ex)
                      //{
                      //    MessageBox.Show($"保存數據時發生錯誤：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                      // }
    }

    public void editButton_Click(object sender, EventArgs e)
    {
        //try
        //{

        員工資料模型 currentData = (員工資料模型)bindingSource.Current;

        // 通過 Form1 的引用，調用它的公開方法來更新數據
        //currentData.員工編號 = int.Parse(EmployeeIDtxt.Text);
        if (currentData != null)
        {
            currentData.員工姓名 = EmployeeNametxt.Text;
            currentData.身分證號 = IDNumbertxt.Text;
            currentData.出生日期 = BirthDatedate.Value;
            currentData.性別 = "male";//Gendercombo.SelectedItem?.ToString();
            currentData.行動電話 = MobilePhonetxt.Text;
            currentData.到職日期 = Hiredate.Value;
            currentData.離職日期 = resignationdate.Value;
            currentData.部門 = Departmentcombo.SelectedItem?.ToString();
            currentData.職務 = Positioncombo.SelectedItem?.ToString();
            currentData.學歷 = Educationcombo.SelectedItem?.ToString();
            currentData.通訊地址 = Mailing_Addresstxt.Text;
            currentData.通訊電話 = MailingPhonetxt.Text;
            currentData.住家電話 = HomePhonetxt.Text;
            currentData.住家地址 = HomeAddresstxt.Text;
            currentData.聯絡人姓名 = EmergencyContactNametxt.Text;
            currentData.連絡人電話 = EmergencyContactPhonetxt.Text;
            currentData.LDF_登入密碼 = LDF_Passwordtxt.Text;
            currentData.LDF_操作權限 = "admin";//LDF_AccessRightscombo.SelectedItem?.ToString();
            currentData.軟體登入帳號 = Software_LoginIDtxt.Text;
            currentData.軟體登入密碼 = Software_Passwordtxt.Text;
            currentData.軟體權限群組 = Software_PermissionGroupcombo.SelectedItem?.ToString();
            currentData.軟體登入權限 = Software_AccessRightstxt.Text;
            currentData.備註 = Notestxt.Text;
            currentData.建檔人 = "ADMIN";//CreatedBycombo.SelectedItem?.ToString();
            currentData.建檔日期 = CreatedDatedate.Value;
            currentData.啟停狀態0停用1啟用 = IsActivecheck.Checked;
            dbContext.Entry(currentData).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            //dbContext.Entry(currentData).CurrentValues.SetValues(currentData);
            dbContext.SaveChanges();
            bindingSource.ResetCurrentItem();
            MessageBox.Show("數據已成功修改到 Form1。", "修改成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // 關閉 Form2
                          // }
                          //catch (Exception ex)
                          //{
                          //    MessageBox.Show($"保存數據時發生錯誤：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                          // }
        }
    }

    public void deleteButton_Click(object sender, EventArgs e)
    {
        員工資料模型 currentData = (員工資料模型)bindingSource.Current;
        dbContext.Entry(currentData).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
        dbContext.SaveChanges();
        bindingSource.Remove(currentData);
        MessageBox.Show("資料已刪除!");
    }

    public void filterButton_Click(Object sender, EventArgs e, string filterText, string combobox)
    {
        MessageBox.Show(filterText);
        if (combobox == "員工姓名")
        {
            bindingSource.DataSource = dbContext.員工資料.Where(t => t.員工姓名.ToUpper().Contains(filterText)).OrderBy(t => t.員工編號).ToList();
        }
        else if (combobox == "身分證號")
        {
            bindingSource.DataSource = dbContext.員工資料.Where(t => t.身分證號.ToUpper().Contains(filterText)).OrderBy(t => t.員工編號).ToList();
        }
        else if (combobox == "性別")
        {
            bindingSource.DataSource = dbContext.員工資料.Where(t => t.性別.ToUpper().Contains(filterText)).OrderBy(t => t.員工編號).ToList();
        }
        else if (combobox == "行動電話")
        {
            bindingSource.DataSource = dbContext.員工資料.Where(t => t.行動電話.ToUpper().Contains(filterText)).OrderBy(t => t.員工編號).ToList();
        }
        else if (combobox == "部門")
        {
            bindingSource.DataSource = dbContext.員工資料.Where(t => t.部門.ToUpper().Contains(filterText)).OrderBy(t => t.員工編號).ToList();
        }
        else if (combobox == "職務")
        {
            bindingSource.DataSource = dbContext.員工資料.Where(t => t.職務.ToUpper().Contains(filterText)).OrderBy(t => t.員工編號).ToList();
        }
        else if (combobox == "學歷")
        {
            bindingSource.DataSource = dbContext.員工資料.Where(t => t.學歷.ToUpper().Contains(filterText)).OrderBy(t => t.員工編號).ToList();
        }
        else if (combobox == "通訊地址")
        {
            bindingSource.DataSource = dbContext.員工資料.Where(t => t.通訊地址.ToUpper().Contains(filterText)).OrderBy(t => t.員工編號).ToList();
        }
        else if (combobox == "通訊電話")
        {
            bindingSource.DataSource = dbContext.員工資料.Where(t => t.通訊電話.ToUpper().Contains(filterText)).OrderBy(t => t.員工編號).ToList();
        }
        else if (combobox == "住家電話")
        {
            bindingSource.DataSource = dbContext.員工資料.Where(t => t.住家電話.ToUpper().Contains(filterText)).OrderBy(t => t.員工編號).ToList();
        }
        else if (combobox == "住家地址")
        {
            bindingSource.DataSource = dbContext.員工資料.Where(t => t.住家地址.ToUpper().Contains(filterText)).OrderBy(t => t.員工編號).ToList();
        }
        else if (combobox == "聯絡人姓名")
        {
            bindingSource.DataSource = dbContext.員工資料.Where(t => t.聯絡人姓名.ToUpper().Contains(filterText)).OrderBy(t => t.員工編號).ToList();
        }
        else if (combobox == "連絡人電話")
        {
            bindingSource.DataSource = dbContext.員工資料.Where(t => t.連絡人電話.ToUpper().Contains(filterText)).OrderBy(t => t.員工編號).ToList();
        }
        else if (combobox == "LDF_登入密碼")
        {
            bindingSource.DataSource = dbContext.員工資料.Where(t => t.LDF_登入密碼.ToUpper().Contains(filterText)).OrderBy(t => t.員工編號).ToList();
        }
        else if (combobox == "LDF_操作權限")
        {
            bindingSource.DataSource = dbContext.員工資料.Where(t => t.LDF_操作權限.ToUpper().Contains(filterText)).OrderBy(t => t.員工編號).ToList();
        }
        else if (combobox == "軟體登入帳號")
        {
            bindingSource.DataSource = dbContext.員工資料.Where(t => t.軟體登入帳號.ToUpper().Contains(filterText)).OrderBy(t => t.員工編號).ToList();
        }
        else if (combobox == "軟體登入密碼")
        {
            bindingSource.DataSource = dbContext.員工資料.Where(t => t.軟體登入密碼.ToUpper().Contains(filterText)).OrderBy(t => t.員工編號).ToList();
        }
        else if (combobox == "軟體權限群組")
        {
            bindingSource.DataSource = dbContext.員工資料.Where(t => t.軟體權限群組.ToUpper().Contains(filterText)).OrderBy(t => t.員工編號).ToList();
        }
        else if (combobox == "軟體登入權限")
        {
            bindingSource.DataSource = dbContext.員工資料.Where(t => t.軟體登入權限.ToUpper().Contains(filterText)).OrderBy(t => t.員工編號).ToList();
        }
        else if (combobox == "備註")
        {
            bindingSource.DataSource = dbContext.員工資料.Where(t => t.備註.ToUpper().Contains(filterText)).OrderBy(t => t.員工編號).ToList();
        }
        else if (combobox == "建檔人")
        {
            bindingSource.DataSource = dbContext.員工資料.Where(t => t.建檔人.ToUpper().Contains(filterText)).OrderBy(t => t.員工編號).ToList();
        }
        dataGridView.DataSource = bindingSource;

    }



    private void textBox15_TextChanged(object sender, EventArgs e)
    {

    }


}
