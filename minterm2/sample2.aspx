<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sample2.aspx.cs" Inherits="minterm2.sample2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>保單電訪單</h2>
            <asp:Label ID="Label1" runat="server" Text="保單編號" Font-Size="X-Large"></asp:Label>
            <asp:Label ID="lb_Id" runat="server" Text=""></asp:Label>
            <br/>
            <asp:Label ID="Label2" runat="server" Text="聯絡方式" Font-Size="X-Large"></asp:Label>
            <asp:DropDownList ID="ddl_Type" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_Type_SelectedIndexChanged">
                <asp:ListItem>手機</asp:ListItem>
                <asp:ListItem>市話</asp:ListItem>
            </asp:DropDownList>
            <br/>
            <asp:DropDownList ID="ddl_ZoneCode" runat="server" OnSelectedIndexChanged="ddl_ZoneCode_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
            <asp:TextBox ID="tb_Number" runat="server"></asp:TextBox>
            <br/>
            <asp:Label ID="Label3" runat="server" Text="地址" Font-Size="X-Large"></asp:Label>
            <asp:DropDownList ID="ddl_City" runat="server" AutoPostBack="True"></asp:DropDownList>
            <asp:TextBox ID="tb_Add" runat="server"></asp:TextBox>
            <br/>
            <asp:Label ID="Label4" runat="server" Text="說明 " Font-Size="X-Large"></asp:Label>
            <asp:RadioButtonList ID="rb_Des" runat="server" AutoPostBack="True" OnSelectedIndexChanged="rb_Des_SelectedIndexChanged">
                <asp:ListItem Selected="True">否</asp:ListItem>
                <asp:ListItem>是</asp:ListItem>
            </asp:RadioButtonList>
            <asp:TextBox ID="tb_Des" runat="server" Visible="False"></asp:TextBox>
            <br/>
            <asp:Button ID="btn_Submit" runat="server" Text="送出" OnClick="btn_Submit_Click" />
            <br/>
            <asp:Label ID="lb_Msg" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
