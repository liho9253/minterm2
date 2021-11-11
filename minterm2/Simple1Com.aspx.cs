using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace minterm2{
    public partial class Simple1Com : System.Web.UI.Page{
        protected void Page_Load(object sender, EventArgs e){
            string temp = "";
            temp += Request.Form.Get("tb_CellPhone") +"<br/>";
            temp += Request.Form.Get("tb_Ps") + "<br/>";
            temp += Request.Form.Get("rb_Gender") + "<br/>";
            temp += Request.Form.Get("tb_Num") + "<br/>";
            temp += Request.Form.Get("hd_Num") + "<br/>";
            temp += mt_2MD5(Request.Form.Get("tb_Num")) + "<br/>";
            // 驗證碼 Password
            lb_Msg.Text = temp;
        }
        public string mt_2MD5(string s_Str){
            System.Security.Cryptography.MD5 cryptoMD5 = System.Security.Cryptography.MD5.Create();
            byte[] ba_Bytes = System.Text.Encoding.UTF8.GetBytes(s_Str);
            byte[] ba_Hash = cryptoMD5.ComputeHash(ba_Bytes);

            string s_Md5 = BitConverter.ToString(ba_Hash)
                .Replace("-", String.Empty)
                .ToUpper();
            return s_Md5;
        }
    }
}