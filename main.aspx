    <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="Key_Notes.Form1" %>
    <%@ Register Src="~/foot.ascx" TagName="Footer" TagPrefix="User" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel ="stylesheet" href="main_css.css" runat ="server"/>
    <title>Key Notes</title>
</head>
<body>
    <form id="form1" runat="server"> 
            <h1>Key Notes !</h1>
         
        <section>

            <div class ="main">
                    <div class="login_div">
                        <h3>Login</h3>
                        <br />
                        <asp:TextBox ID="Login_Username" Class="Login_Username" placeholder="Username" AutoCompleteType="Disabled" runat="server"></asp:TextBox>
                        <br />
                        <asp:TextBox ID="Login_Password"  TextMode="Password" Class="Login_Password" placeholder ="Password" AutoCompleteType="Disabled" runat="server"></asp:TextBox>
                        <br />
                        <asp:Button ID="Login_btn" CssClass="Login_btn" runat="server" Text="Login" OnClick="Button1_Click" />
                        <br />
                        <asp:Label ID="Label2" CssClass="lab" Visible="False" runat="server" Text="Incorrect Username or password"></asp:Label>
                        </div>
                <div class="signup_div">
                    <h3>Signup</h3>
                        <br />
                        <asp:TextBox ID="Signup_Username" Class="Signup_Username" placeholder="Username" AutoCompleteType="Disabled" runat="server"></asp:TextBox>
                        <br />
                        <asp:TextBox ID="Signup_Password"  TextMode="Password" Class="Signup_Password" placeholder ="Password" AutoCompleteType="Disabled" runat="server"></asp:TextBox>
                        <br />
                        <asp:TextBox ID="Signup_repass" TextMode="Password" Class="Signup_repass" placeholder ="Retype-Password" AutoCompleteType="Disabled" runat="server"></asp:TextBox>
                        <br />
                        <asp:Button ID="Signup_btn" CssClass="Signup_btn" runat="server" Text="Signup" OnClick="Button2_Click" />
                        <br />
                        <asp:Label ID="Label3" CssClass="lab" Visible="False" runat="server" Text="Both The Passwords Are Not Same"></asp:Label>
                </div>
              
                </div>
        </section>
        <User:Footer ID="Footer" runat="server" />
        
    </form>
</body>
</html>
