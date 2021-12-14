<%@ Page Language="C#"  AutoEventWireup="true"  CodeBehind="BaseForm.aspx.cs" Inherits="WebApplicationServicePerson.BaseForm" %>
<%@import  Namespace ="WebApplicationServicePerson"%>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server" >
    <link rel="StyleSheet" href="StyleSheet.css" />
    <link rel="StyleSheet" href="Content/bootstrap.css" />
    <script src="Scripts/bootstrap.js"></script>
    <title></title>
</head>
<body class="alert-light">
    <form id="form2" class="Progamm" runat="server">
        <div >
            <asp:Button ID="ButtonLogout"  CssClass="btn-danger" runat="server" Text="Выйти" OnClick="ButtonLogout_Click" />
        </div>
        
         
     <asp:Panel  ID="PanelInformation" runat="server"  HorizontalAlign="Center">
                <asp:Label ID="LabelPrintInformation" runat="server"></asp:Label>
                <br />
                <br />
         
                <asp:TextBox ID="TextBoxInputChar" runat="server" CausesValidation="True" MaxLength="1"  OnTextChanged="TextBoxInputChar_TextChanged"> </asp:TextBox>
                
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorFirst" ValidationGroup="ButtonFirst" runat="server" ControlToValidate="TextBoxInputChar" Display="Dynamic" ErrorMessage="Ничего не введено">*
</asp:RequiredFieldValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorAny" ValidationGroup="ButtonAny" runat="server" ControlToValidate="TextBoxInputChar" Display="Dynamic" ErrorMessage="Ничего не введено">*
</asp:RequiredFieldValidator>
                 <asp:CheckBox ID="CheckEmployee" runat="server" HorizontalAlign="Center" Text="Работники"/>
                 <asp:ValidationSummary runat="server" ID="ValidationSummaryForGridViewNames" DisplayMode="BulletList"   ValidationGroup="Select"
        HeaderText="Пожалуйста, исправьте следующие ошибки: " ShowSummary="true" ShowMessageBox="true"/>
                 <asp:ValidationSummary runat="server" ID="ValidationSummaryAny" DisplayMode="BulletList"   ValidationGroup="ButtonAny"
        HeaderText="Пожалуйста, исправьте следующие ошибки: " ShowSummary="true" ShowMessageBox="true"/>
            <asp:ValidationSummary runat="server" ID="ValidationSummaryFirst" DisplayMode="BulletList"   ValidationGroup="ButtonFirst"
        HeaderText="Пожалуйста, исправьте следующие ошибки: " ShowSummary="true" ShowMessageBox="true"/>

     </asp:Panel>
        <p class="text-center">
            <asp:Label ID="LabelHelp" runat="server"></asp:Label>
        </p>   
        
        <div  class="text-center"  >

            <asp:Button ID="ButtonFirst" runat="server" CssClass="btn-primary" ValidationGroup="ButtonFirst" OnClick="ButtonFirst_Click" Text="FIRST"/>
             <asp:RegularExpressionValidator ID="RegularExpressionValidatorForFirstButton" ValidationGroup="ButtonFirst" 
                 ErrorMessage="Введено неверное значение, введите 1 символ латинского алфавита" 
                 Display="Dynamic" runat="server" ValidationExpression="[A-Za-z]" ControlToValidate="TextBoxInputChar">*
             </asp:RegularExpressionValidator>
            

                <asp:Button ID="ButtonAny" runat="server" OnClick="ButtonAny_Click"  ValidationGroup="ButtonAny" CssClass="btn-success"  Text="ANY" />
             <asp:RegularExpressionValidator ID="RegularExpressionValidatorForButtonAny" runat="server" ValidationGroup="ButtonAny"
                   ValidationExpression="[A-Za-z.-]" ControlToValidate="TextBoxInputChar"
                   ErrorMessage="Введено неверное значение, введите 1 символ латинского алфавита" Display="Dynamic">*
               </asp:RegularExpressionValidator>
            <br />
           
        </div>
     
        <p class="pLabelInformationAfterInput">
            <asp:Label ID="LabelInformationAfterInput"  runat="server" ></asp:Label>
        </p>
        <p class="LabelOutRezult">
            <asp:Label ID="LabelOutRezult" runat="server"></asp:Label>
        </p>
        <p class="text-center">
            <asp:Label ID="LabelEmployCheck" CssClass="lead" runat="server"></asp:Label>

        </p>
    <div class="text-center">
            <asp:Panel ID="ResultPanel" runat="server" CssClass="text-center"   ScrollBars="Auto" Visible="true" Height="400px" >
   
            <asp:GridView ID="GridViewNames"  OnRowCommand="GridViewNames_RowCommand" DataKeyNames="BusinessEntityID" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" ShowHeaderWhenEmpty="True" OnSelectedIndexChanged="GridViewNames_SelectedIndexChanged"  CssClass="table-bordered" HorizontalAlign="Center">
                <Columns>
                   
                    <asp:BoundField DataField="BusinessEntityID" HeaderText="BusinessEntityID" SortExpression="BusinessEntityID" Visible="False" />
                    <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                    <asp:CommandField ButtonType="Button" HeaderText="Подробнее" ShowHeader="True" ShowSelectButton="True" SelectText="Посмотреть" />
                    <asp:ButtonField ButtonType="Button" HeaderText="Прием на работу" Text="Нанять"  CommandName="Hire"  />
                </Columns>
                
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />
            </asp:GridView>
        </asp:Panel>

    </div>
      
    </form>
</body>
</html>
