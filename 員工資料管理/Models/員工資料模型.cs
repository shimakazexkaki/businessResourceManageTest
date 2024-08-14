using System.ComponentModel.DataAnnotations;
namespace 員工資料管理.Models
{
    public class 員工資料模型
    {
        /*public 員工資料模型(int 員工編號, string LDF_登入密碼, string LDF_操作權限, string 員工姓名, string 性別, string 建檔人, DateTime 建檔日期, bool 啟停狀態0停用1啟用) 
        {
            this.員工編號 = 員工編號;
            this.員工姓名 = 員工姓名;
            this.LDF_登入密碼 = LDF_登入密碼;
            this.LDF_操作權限 = LDF_操作權限;
            this.性別 = 性別;
            this.建檔人 = 建檔人;
            this.建檔日期 = System.DateTime.Now;
            this.啟停狀態0停用1啟用 = 啟停狀態0停用1啟用;
        }*/
        [Key]
        public int 員工編號 {  get; set; }
        public required string LDF_登入密碼 { get; set; }
        public required string LDF_操作權限 { get; set; }
        public string? 軟體登入帳號 { get; set; }
        public string? 軟體登入密碼 { get; set; }
        public string? 軟體權限群組 { get; set; }
        public string? 軟體登入權限 { get; set; }
        public required string 員工姓名 { get; set; }
        public required string 性別 { get; set;}
        public DateTime? 出生日期 { get; set; }
        public string? 身分證號 { get; set; }
        public string? 學歷 { get; set;}
        public string? 部門 { get; set;}
        public string? 職務 { get; set; }
        public string? 通訊地址 { get; set; }
        public string? 通訊電話 { get; set; }
        public string? 行動電話 { get; set; }
        public string? 住家地址 { get; set;}
        public string? 住家電話 { get; set; }
        public string? 聯絡人姓名 { get; set; }
        public string? 連絡人電話 { get; set; }
        public DateTime? 到職日期 { get; set; }
        public DateTime? 離職日期 { get; set; }
        public string? 備註 { get; set; }
        public string? 字串一 { get; set; }
        public string? 字串二 { get; set; }
        public string? 字串三 { get; set; }
        public decimal? 小數一 { get; set; }
        public decimal? 小數二 { get; set; }
        public decimal? 小數三 { get; set; }
        public bool? 邏輯一 { get; set; }
        public bool? 邏輯二 { get; set; }
        public bool? 邏輯三 { get; set; }
        public required string 建檔人 { get; set; }
        public required DateTime 建檔日期 { get; set; }
        public required bool 啟停狀態0停用1啟用 { get; set; }
        public byte[]? 照片 { get; set; }
        public byte[]? 檔附件 { get; set; }
        public string? 擴展欄位 { get; set; }

    }
}
