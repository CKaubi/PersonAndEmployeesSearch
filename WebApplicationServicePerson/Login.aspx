<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplicationServicePerson.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="StyleSheet" href="Content/bootstrap.css" />
    <script src="Scripts/bootstrap.js"></script>
    <title></title>   
   
</head>
<body class="bg-light" >
    <form id="form1" runat="server" >
       
        <asp:Panel ID="Panel1" HorizontalAlign="Center"  CssClass="font-weight-bolder"  runat="server"  Height="330px">
       
               <h1>
                   <asp:Label ID="LabelInfo" runat="server" CssClass="font-weight-bold" Text="Пожалуйста, войдите в систему"></asp:Label> 

               </h1>
            <br />
            <asp:Label ID="LabelLogin" runat="server" Text="Логин: "></asp:Label>
            <asp:TextBox ID="TextBoxLogin" CssClass="shadow" ValidationGroup="ButtonLogin" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="LoginRequiredValidator" runat="server" ValidationGroup="ButtonLogin"
                                ErrorMessage="*" ControlToValidate="TextBoxLogin" ForeColor="Red" />
            <br />
             <asp:RegularExpressionValidator
                                ID="UsernameValidator" runat="server"
                                ControlToValidate="TextBoxLogin"
                                ValidationGroup="ButtonLogin"
                                ErrorMessage="Некорректное имя пользователя"
                                ValidationExpression="[\w| ]*"
                                ForeColor="Red" />
            <br />
                        
            <asp:Label ID="LabelPassword" runat="server" Text="Пароль: "></asp:Label>
            <asp:TextBox ID="TextBoxPassword" CssClass="shadow" ValidationGroup="ButtonLogin" runat="server" TextMode="Password" ></asp:TextBox>
             <asp:RequiredFieldValidator ID="PwdRequiredValidator"
                                ValidationGroup="ButtonLogin"
                                runat="server" ErrorMessage="*"
                                ControlToValidate="TextBoxPassword" ForeColor="Red" />
            <br />
            <asp:RegularExpressionValidator ID="PwdValidator"
                                runat="server" ControlToValidate="TextBoxPassword"
                                ErrorMessage="Некорректный пароль"
                                ValidationExpression='[\w| !"§$%&amp;/()=\-?\*]*'
                                ForeColor="Red" />
               <br />
            <asp:Button ID="ButtonLogin"  ValidationGroup="ButtonLogin" runat="server" CssClass="shadow" Text="Войти" OnClick="ButtonLogin_Click" />
            <br />
            <br />
            <asp:Button ID="ButtonRegistration" CssClass="btn-success shadow"  runat="server" OnClick="ButtonRegistration_Click" Text="Зарегистрироваться" />
            <br />
            <br />
            <asp:Label ID="LBStatus" runat="server"></asp:Label>
        </asp:Panel>
    </form>
</body>
</html>
