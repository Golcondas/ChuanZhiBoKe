    <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebOnde.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" method="post" action="./Handler1.ashx">
    <div>
        <table>
            <tr><td><input type="checkbox" name="ck" value="1"/></td></tr>
             <tr><td><input type="checkbox" name="ck" value="2"/></td></tr>
              <tr><td><input type="checkbox" name="ck" value="3"/></td></tr>
        </table>
    </div>
    <input id="clickss" type="submit" value="提交" />
    </form>
</body>
</html>
