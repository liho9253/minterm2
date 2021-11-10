using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace minterm2 {
    public partial class sample2 : System.Web.UI.Page {
        String[,] sa_ZoneCode = new String[2, 3] { { "0911", "0921", "0960" },{ "02", "04", "07" } };
        String[] sa_City1 = new String[6] { "台北市","新北市","台中市","台中縣","高雄市","高雄縣" };
        String[,] sa_City2 = new String[3, 2] { {"台北市","新北市" },
                                                {"台中市","台中縣" },
                                                {"高雄市","高雄縣" } };
        protected void Page_Load(object sender, EventArgs e){
            if (IsPostBack == false) {
                ListItem o_li;
                for (int i = 0;i <= 2;i++) {
                    o_li = new ListItem(sa_ZoneCode[0, i], sa_ZoneCode[0, i]);
                    ddl_ZoneCode.Items.Add(o_li);
                }
                for (int i = 0; i <= 5; i++) {
                    o_li = new ListItem(sa_City1[i], sa_City1[i]);
                    ddl_City.Items.Add(o_li);
                }
                lb_Id.Text = mt_GenVeriStr();
            }
        }
        protected void ddl_Type_SelectedIndexChanged(object sender, EventArgs e){
            ddl_ZoneCode.Items.Clear();
            ddl_City.Items.Clear();
            ListItem o_li;
            if (ddl_Type.SelectedValue == "手機") {
                for (int i = 0;i <= 2;i++) {
                    o_li = new ListItem(sa_ZoneCode[0, i], sa_ZoneCode[0, i]);
                    ddl_ZoneCode.Items.Add(o_li);
                }
                for (int i = 0;i <= 5;i++) {
                    o_li = new ListItem(sa_City1[i], sa_City1[i]);
                    ddl_City.Items.Add(o_li);
                }
            }else{
                for (int i = 0;i <= 2;i++) {
                    o_li = new ListItem(sa_ZoneCode[1,i], sa_ZoneCode[1,i]);
                    ddl_ZoneCode.Items.Add(o_li);
                }
                for (int i = 0;i <= 1;i++) {
                    o_li = new ListItem(sa_City2[0, i], sa_City2[0, i]);
                    ddl_City.Items.Add(o_li);
                }
            }
        }
        protected void ddl_ZoneCode_SelectedIndexChanged(object sender, EventArgs e){
            ddl_City.Items.Clear();
            ListItem o_li;
            if (ddl_ZoneCode.SelectedValue == "02") {
                for (int i = 0;i <= 1;i++) {
                    o_li = new ListItem(sa_City2[0, i], sa_City2[0, i]);
                    ddl_City.Items.Add(o_li);
                }
            }else if(ddl_ZoneCode.SelectedValue == "04") { 
                for (int i = 0;i <= 1;i++) {
                    o_li = new ListItem(sa_City2[1, i], sa_City2[1, i]);
                    ddl_City.Items.Add(o_li);
                }
            }else if(ddl_ZoneCode.SelectedValue == "07") { 
                for (int i = 0;i <= 1;i++) {
                    o_li = new ListItem(sa_City2[2, i], sa_City2[2, i]);
                    ddl_City.Items.Add(o_li);
                }
            }else{ 
                for (int i = 0;i <= 5;i++) {
                    o_li = new ListItem(sa_City1[i], sa_City1[i]);
                    ddl_City.Items.Add(o_li);
                }
            }
        }
        protected void rb_Des_SelectedIndexChanged(object sender, EventArgs e){
            if (rb_Des.SelectedValue == "是") {
                tb_Des.Visible = true;
            }else{
                tb_Des.Visible = false;
            }
        }
        protected void btn_Submit_Click(object sender, EventArgs e){
            String temp = "";
            temp += lb_Id.Text + "<br/>";
            temp += ddl_Type.Text + "<br/>";
            temp += ddl_ZoneCode.Text + tb_Number.Text + "<br/>";
            temp += ddl_City.Text+tb_Add.Text + "<br/>";
            temp += tb_Des.Text + "<br/>";
            lb_Msg.Text = temp;
        }
        public string mt_GenVeriStr() {
            string s_Res = "";
            Random o_Ran = new Random();
            for (int i_Ct = 0; i_Ct < 4; i_Ct++) {
                int i_Tmp = o_Ran.Next(0, 10);
                s_Res = s_Res + i_Tmp.ToString();
            }
            return s_Res;
        }
    }
}