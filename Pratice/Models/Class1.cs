using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pratice.Models
{
    public class Class1
    {

        public object taolecardevent_id { get; set; }
        [Display(Name = "優惠活動開始日期")]
        public string event_start_date { get; set; }
        [Display(Name = "優惠活動結束日期")]
        public string event_end_date { get; set; }
        [Display(Name = "優惠活動名稱")]
        public string event_name { get; set; }
        [Display(Name = "優惠活動說明")]
        public string event_content { get; set; }
        public object event_note { get; set; }
        [Display(Name = "郵遞區號")]
        public string event_address1 { get; set; }
        [Display(Name = "縣市")]
        public string event_address2 { get; set; }
        [Display(Name = "鄉鎮區")]
        public string event_address3 { get; set; }
        [Display(Name = "地址")]
        public string event_address4 { get; set; }
        [Display(Name = "優惠活動電話")]
        public string event_phone { get; set; }
        [Display(Name = "特約商店傳真")]
        public string store_fax { get; set; }
        [Display(Name = "特約商店email")]
        public string store_email { get; set; }
        [Display(Name = "優惠活動網址")]
        public string event_url { get; set; }
        [Display(Name = "建立日期")]
        public string create_date { get; set; }
        [Display(Name = "更新日期")]
        public string update_date { get; set; }
        [Display(Name = "商店logo")]
        public string strstorelogopath { get; set; }
        [Display(Name = "優惠活動圖片")]
        public string streventimgpath { get; set; }


    }
}