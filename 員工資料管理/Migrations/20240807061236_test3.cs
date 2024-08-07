using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace 員工資料管理.Migrations
{
    /// <inheritdoc />
    public partial class test3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Software_PermissionGroup",
                table: "員工資料",
                newName: "部門");

            migrationBuilder.RenameColumn(
                name: "Software_Password",
                table: "員工資料",
                newName: "通訊電話");

            migrationBuilder.RenameColumn(
                name: "Software_LoginID",
                table: "員工資料",
                newName: "通訊地址");

            migrationBuilder.RenameColumn(
                name: "Software_AccessRights",
                table: "員工資料",
                newName: "軟體登入權限");

            migrationBuilder.RenameColumn(
                name: "ResignationDate",
                table: "員工資料",
                newName: "離職日期");

            migrationBuilder.RenameColumn(
                name: "Position",
                table: "員工資料",
                newName: "軟體登入帳號");

            migrationBuilder.RenameColumn(
                name: "Photo",
                table: "員工資料",
                newName: "照片");

            migrationBuilder.RenameColumn(
                name: "Notes",
                table: "員工資料",
                newName: "軟體登入密碼");

            migrationBuilder.RenameColumn(
                name: "MobilePhone",
                table: "員工資料",
                newName: "軟體權限群組");

            migrationBuilder.RenameColumn(
                name: "MailingPhone",
                table: "員工資料",
                newName: "身分證號");

            migrationBuilder.RenameColumn(
                name: "MailingAddress",
                table: "員工資料",
                newName: "行動電話");

            migrationBuilder.RenameColumn(
                name: "LDF_Password",
                table: "員工資料",
                newName: "性別");

            migrationBuilder.RenameColumn(
                name: "LDF_AccessRights",
                table: "員工資料",
                newName: "建檔人");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "員工資料",
                newName: "啟停狀態0停用1啟用");

            migrationBuilder.RenameColumn(
                name: "IDNumber",
                table: "員工資料",
                newName: "職務");

            migrationBuilder.RenameColumn(
                name: "HomePhone",
                table: "員工資料",
                newName: "聯絡人電話");

            migrationBuilder.RenameColumn(
                name: "HomeAddress",
                table: "員工資料",
                newName: "聯絡人姓名");

            migrationBuilder.RenameColumn(
                name: "HireDate",
                table: "員工資料",
                newName: "到職日期");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "員工資料",
                newName: "員工姓名");

            migrationBuilder.RenameColumn(
                name: "ExtensionField",
                table: "員工資料",
                newName: "擴展欄位");

            migrationBuilder.RenameColumn(
                name: "EmployeeName",
                table: "員工資料",
                newName: "LDF_登入密碼");

            migrationBuilder.RenameColumn(
                name: "EmergencyContactPhone",
                table: "員工資料",
                newName: "學歷");

            migrationBuilder.RenameColumn(
                name: "EmergencyContactName",
                table: "員工資料",
                newName: "字串二");

            migrationBuilder.RenameColumn(
                name: "Education",
                table: "員工資料",
                newName: "字串三");

            migrationBuilder.RenameColumn(
                name: "Department",
                table: "員工資料",
                newName: "字串一");

            migrationBuilder.RenameColumn(
                name: "CustomString3",
                table: "員工資料",
                newName: "備註");

            migrationBuilder.RenameColumn(
                name: "CustomString2",
                table: "員工資料",
                newName: "住家電話");

            migrationBuilder.RenameColumn(
                name: "CustomString1",
                table: "員工資料",
                newName: "住家地址");

            migrationBuilder.RenameColumn(
                name: "CustomDecimal3",
                table: "員工資料",
                newName: "小數二");

            migrationBuilder.RenameColumn(
                name: "CustomDecimal2",
                table: "員工資料",
                newName: "小數三");

            migrationBuilder.RenameColumn(
                name: "CustomDecimal1",
                table: "員工資料",
                newName: "小數一");

            migrationBuilder.RenameColumn(
                name: "CustomBoolean3",
                table: "員工資料",
                newName: "邏輯二");

            migrationBuilder.RenameColumn(
                name: "CustomBoolean2",
                table: "員工資料",
                newName: "邏輯三");

            migrationBuilder.RenameColumn(
                name: "CustomBoolean1",
                table: "員工資料",
                newName: "邏輯一");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "員工資料",
                newName: "建檔日期");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "員工資料",
                newName: "LDF_操作權限");

            migrationBuilder.RenameColumn(
                name: "BirthDate",
                table: "員工資料",
                newName: "出生日期");

            migrationBuilder.RenameColumn(
                name: "Attachment",
                table: "員工資料",
                newName: "檔附件");

            migrationBuilder.RenameColumn(
                name: "EmployeeID",
                table: "員工資料",
                newName: "員工編號");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "離職日期",
                table: "員工資料",
                newName: "ResignationDate");

            migrationBuilder.RenameColumn(
                name: "部門",
                table: "員工資料",
                newName: "Software_PermissionGroup");

            migrationBuilder.RenameColumn(
                name: "邏輯二",
                table: "員工資料",
                newName: "CustomBoolean3");

            migrationBuilder.RenameColumn(
                name: "邏輯三",
                table: "員工資料",
                newName: "CustomBoolean2");

            migrationBuilder.RenameColumn(
                name: "邏輯一",
                table: "員工資料",
                newName: "CustomBoolean1");

            migrationBuilder.RenameColumn(
                name: "通訊電話",
                table: "員工資料",
                newName: "Software_Password");

            migrationBuilder.RenameColumn(
                name: "通訊地址",
                table: "員工資料",
                newName: "Software_LoginID");

            migrationBuilder.RenameColumn(
                name: "軟體登入權限",
                table: "員工資料",
                newName: "Software_AccessRights");

            migrationBuilder.RenameColumn(
                name: "軟體登入帳號",
                table: "員工資料",
                newName: "Position");

            migrationBuilder.RenameColumn(
                name: "軟體登入密碼",
                table: "員工資料",
                newName: "Notes");

            migrationBuilder.RenameColumn(
                name: "軟體權限群組",
                table: "員工資料",
                newName: "MobilePhone");

            migrationBuilder.RenameColumn(
                name: "身分證號",
                table: "員工資料",
                newName: "MailingPhone");

            migrationBuilder.RenameColumn(
                name: "行動電話",
                table: "員工資料",
                newName: "MailingAddress");

            migrationBuilder.RenameColumn(
                name: "職務",
                table: "員工資料",
                newName: "IDNumber");

            migrationBuilder.RenameColumn(
                name: "聯絡人電話",
                table: "員工資料",
                newName: "HomePhone");

            migrationBuilder.RenameColumn(
                name: "聯絡人姓名",
                table: "員工資料",
                newName: "HomeAddress");

            migrationBuilder.RenameColumn(
                name: "照片",
                table: "員工資料",
                newName: "Photo");

            migrationBuilder.RenameColumn(
                name: "檔附件",
                table: "員工資料",
                newName: "Attachment");

            migrationBuilder.RenameColumn(
                name: "擴展欄位",
                table: "員工資料",
                newName: "ExtensionField");

            migrationBuilder.RenameColumn(
                name: "性別",
                table: "員工資料",
                newName: "LDF_Password");

            migrationBuilder.RenameColumn(
                name: "建檔日期",
                table: "員工資料",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "建檔人",
                table: "員工資料",
                newName: "LDF_AccessRights");

            migrationBuilder.RenameColumn(
                name: "小數二",
                table: "員工資料",
                newName: "CustomDecimal3");

            migrationBuilder.RenameColumn(
                name: "小數三",
                table: "員工資料",
                newName: "CustomDecimal2");

            migrationBuilder.RenameColumn(
                name: "小數一",
                table: "員工資料",
                newName: "CustomDecimal1");

            migrationBuilder.RenameColumn(
                name: "學歷",
                table: "員工資料",
                newName: "EmergencyContactPhone");

            migrationBuilder.RenameColumn(
                name: "字串二",
                table: "員工資料",
                newName: "EmergencyContactName");

            migrationBuilder.RenameColumn(
                name: "字串三",
                table: "員工資料",
                newName: "Education");

            migrationBuilder.RenameColumn(
                name: "字串一",
                table: "員工資料",
                newName: "Department");

            migrationBuilder.RenameColumn(
                name: "啟停狀態0停用1啟用",
                table: "員工資料",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "員工姓名",
                table: "員工資料",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "到職日期",
                table: "員工資料",
                newName: "HireDate");

            migrationBuilder.RenameColumn(
                name: "出生日期",
                table: "員工資料",
                newName: "BirthDate");

            migrationBuilder.RenameColumn(
                name: "備註",
                table: "員工資料",
                newName: "CustomString3");

            migrationBuilder.RenameColumn(
                name: "住家電話",
                table: "員工資料",
                newName: "CustomString2");

            migrationBuilder.RenameColumn(
                name: "住家地址",
                table: "員工資料",
                newName: "CustomString1");

            migrationBuilder.RenameColumn(
                name: "LDF_登入密碼",
                table: "員工資料",
                newName: "EmployeeName");

            migrationBuilder.RenameColumn(
                name: "LDF_操作權限",
                table: "員工資料",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "員工編號",
                table: "員工資料",
                newName: "EmployeeID");
        }
    }
}
