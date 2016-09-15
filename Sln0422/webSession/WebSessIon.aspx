<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebSessIon.aspx.cs" Inherits="webSession.WebSessIon" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>咱自己的session</div>
    <div>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_OnClick"/>
    </div>
    </form>
</body>
</html>
