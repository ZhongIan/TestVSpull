//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class t菜品
    {
        public t菜品()
        {
            this.f菜品照片 = "";
        }

        public int fVID { get; set; }
        public int fPID { get; set; }
        public string f菜品名稱 { get; set; }
        public string f菜品簡介 { get; set; }
        public string f菜品照片 { get; set; }
    
        public virtual t販售項目 t販售項目 { get; set; }
    }
}
