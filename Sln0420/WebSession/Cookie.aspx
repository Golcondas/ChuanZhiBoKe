<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cookie.aspx.cs" Inherits="WebSession.Cookie" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
    <label>用户名:</label><asp:TextBox runat="server" ID="txtName"></asp:TextBox>
    </div>
    <div>
    <label>密  码:</label><asp:TextBox runat="server" ID="txtPassword"></asp:TextBox>
    </div>
    <div><asp:Button ID="btnOK" runat="server" Text="提交" OnClick="btnOK_OnClick"/></div>
    </div>
    </form>
</body>
</html>
