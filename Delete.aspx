<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        are you sure you want to delete this Book?<asp:Button ID="BtnYes" runat="server" OnClick="BtnYes_Click" style="z-index: 1; left: 11px; top: 140px; position: absolute; height: 26px; width: 60px" Text="Yes" />
        <asp:Button ID="BtnNo" runat="server" style="z-index: 1; left: 155px; top: 140px; position: absolute; height: 25px; width: 74px" Text="No" OnClick="BtnNo_Click" />
        <asp:Label ID="LblError" runat="server" style="z-index: 1; left: 459px; top: 335px; position: absolute" Text="Label" Visible="False"></asp:Label>
        <asp:Label ID="lblBooksNo" runat="server" style="z-index: 1; left: 16px; top: 191px; position: absolute" Text="Label"></asp:Label>
    </form>
</body>
</html>
