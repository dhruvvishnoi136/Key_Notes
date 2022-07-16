<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="afterlogin.aspx.cs" Inherits="Key_Notes.afterlogin" %>
<%@ Register Src="~/foot.ascx" TagName="Footer" TagPrefix="User" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <title>Logged In</title>
</head>
<body >
    <form id="form1" runat="server">
        <div>
            <h1>Logged In</h1>
        </div>
    <User:Footer ID="Footer" runat="server" />    
    </form>

</body>
</html>
