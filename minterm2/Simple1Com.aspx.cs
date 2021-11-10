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
            for (int i = 1;i <=3; i++ ) {
                temp += Request.Form.Get("rb_Gender.Selected") + "<br/>";
            }
            temp += Request.Form.Get("tb_Num") + "<br/>";
            lb_Msg.Text = temp;

        }
    }
}