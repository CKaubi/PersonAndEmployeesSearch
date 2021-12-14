<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PersonInfo.aspx.cs" Inherits="WebApplicationServicePerson.PersonInfo" %>
<%@ Import Namespace="WebApplicationServicePerson" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server"> 
    
    <title></title>
   <link rel="StyleSheet" href="StyleSheet.css" />  
    <link rel="StyleSheet" href="Content/bootstrap.css" />
    
</head>
<body class="alert-light">
    <form id="form1" runat="server">
        <div class="text-center">
            <asp:GridView ID="GridViewPersonInfo" runat="server" DataKeyNames="BusinessEntityID"  AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" CssClass="table-bordered" >
                <Columns>
                    <asp:BoundField DataField="BusinessEntityID" HeaderText="BusinessEntityID" SortExpression="BusinessEntityID" />
                    <asp:BoundField DataField="PersonType" HeaderText="PersonType" SortExpression="PersonType" />
                    <asp:BoundField DataField="NameStyle" HeaderText="NameStyle" SortExpression="NameStyle" />
                    <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
                    <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                    <asp:BoundField DataField="MiddleName" HeaderText="MiddleName" SortExpression="MiddleName" />
                    <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                    <asp:BoundField DataField="Suffix" HeaderText="Suffix" SortExpression="Suffix" />
                    <asp:BoundField DataField="EmailPromotion" HeaderText="EmailPromotion" SortExpression="EmailPromotion" />
                    <asp:BoundField DataField="AdditionalContactInfo" HeaderText="AdditionalContactInfo" SortExpression="AdditionalContactInfo" />
                    <asp:BoundField DataField="Demographics" HeaderText="Demographics" SortExpression="Demographics" />
                    <asp:BoundField DataField="Rowguid" HeaderText="Rowguid" SortExpression="Rowguid" />
                    <asp:BoundField DataField="ModifiedDate" HeaderText="ModifiedDate" SortExpression="ModifiedDate" />
                </Columns>
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066"/>
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />
            </asp:GridView>
            <asp:Button ID="ButtonOnBasePage" runat="server" CssClass="btn-danger" OnClick="ButtonOnBasePage_Click" Text="На главную" Width="126px" /> 

        </div>
     
    </form>
</body>
</html>
