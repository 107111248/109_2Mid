<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sample2.aspx.cs" Inherits="_109_2Mid.Sample2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
              <div><h1>訂貨單</h1></div>
            <div>
                <asp:DropDownList ID="ddl_Area" runat="server" Font-Size="Medium" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    <asp:ListItem>北區</asp:ListItem>
                    <asp:ListItem>中區</asp:ListItem>
                </asp:DropDownList><br/>
                <asp:DropDownList ID="ddl_Place" runat="server" Font-Size="Medium" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" AutoPostBack="True">
                    <asp:ListItem>基隆</asp:ListItem>
                    <asp:ListItem>台北</asp:ListItem>
                    <asp:ListItem>新北</asp:ListItem>
                </asp:DropDownList><br/><br/>
                <asp:Label ID="laber2" runat="server" Text = "姓名&nbsp&nbsp&nbsp"  Font-Size="Large"></asp:Label>
                <asp:TextBox ID="tb_Name" runat="server" Height="20px"></asp:TextBox><br/><br/>
                <asp:Label ID="Label1" runat="server" Text="其他" Font-Size="Large"></asp:Label><br/>
                <asp:RadioButtonList ID="rbl_Res" runat="server" Width="49px" AutoPostBack="True"  OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                    <asp:ListItem Selected="False" Enabled="True">否</asp:ListItem>
                    <asp:ListItem Selected="True" Enabled="True">是</asp:ListItem>
                </asp:RadioButtonList>
                <asp:TextBox ID="td_Des" runat="server" Width="400px"></asp:TextBox>
                <br/>
                <asp:Button ID="btn_Sub" runat="server" Text="送出" OnClick="Button1_Click" /><br/>
                <asp:Label ID="lb_Msg" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
