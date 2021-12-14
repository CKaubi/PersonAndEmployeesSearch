<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="WebApplicationServicePerson.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
  <link rel="StyleSheet" href="StyleSheet.css" />
       <link rel="StyleSheet" href="Content/bootstrap.css" />
</head>
<body class="alert-light">
    <form id="form1" runat="server">
        <div>
       
        <asp:Panel ID="Panel1" HorizontalAlign="Center" runat="server">
            
            <asp:Label ID="LabelLogin" runat="server" Text="Введите логин:  "></asp:Label>
            <asp:TextBox ID="TextBoxLogin" runat="server"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="LoginRequiredValidator" runat="server"
                     ValidationGroup="ButtonReg"
                     ErrorMessage="*" ControlToValidate="TextBoxLogin" ForeColor="Red" />
            <br />
             <asp:RegularExpressionValidator
                 ValidationGroup="ButtonReg"
                 ID="UsernameValidator" runat="server"
                 ControlToValidate="TextBoxLogin"
                 ErrorMessage="Некорректное имя пользователя"
                 ValidationExpression="[\w| ]*"
                 ForeColor="Red" />
            <br />
            <asp:Label ID="LabelPassword" runat="server" Text="Введите пароль:  "></asp:Label>
            <asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password"></asp:TextBox>
             <asp:RequiredFieldValidator ID="PwdRequiredValidator"
                 ValidationGroup="ButtonReg"
                 runat="server" ErrorMessage="*"
                 ControlToValidate="TextBoxPassword" ForeColor="Red" />
            <br />
            <asp:RegularExpressionValidator ID="PwdValidator"
                runat="server" ControlToValidate="TextBoxPassword"
                ErrorMessage="Некорректный пароль"
                ValidationGroup="ButtonReg"
                ValidationExpression='[\w| !"§$%&amp;/()=\-?\*]*'
                ForeColor="Red" />
            <br />
            <asp:Label ID="LabelPasswordDouble" runat="server" Text="Введите пароль еще раз:  "></asp:Label>
            <asp:TextBox ID="TextBoxPasswordDouble" TextMode="Password" runat="server"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator1"
                 runat="server" ErrorMessage="*"
                 ValidationGroup="ButtonReg"
                 ControlToValidate="TextBoxPasswordDouble" ForeColor="Red" />
            <br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1"
                ValidationGroup="ButtonReg"
                runat="server" ControlToValidate="TextBoxPasswordDouble"
                ErrorMessage="Некорректный пароль"
                ValidationExpression='[\w| !"§$%&amp;/()=\-?\*]*'
                ForeColor="Red" />
            <br />
            <asp:Label ID="LabelCheck" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="ButtonRegistration" runat="server" CssClass="btn-success" Text="Зарегистрировать" ValidationGroup="ButtonReg" OnClick="ButtonRegistration_Click" />
            <br />
            <br />
            <asp:Label ID="LabelStatus" runat="server"></asp:Label>
            <br />
            <asp:Button ID="ButtonLog" runat="server" CssClass="btn-info" OnClick="ButtonLog_Click" Text="Авторизоваться" />
        </asp:Panel>

        </div>
    </form>
</body>
</html>
