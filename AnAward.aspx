<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnAward.aspx.cs" Inherits="AnAward" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 48px;
            left: 124px;
            z-index: 1;
            width: 175px;
            height: 18px;
        }
        .auto-style2 {
            position: absolute;
            top: 82px;
            left: 126px;
            z-index: 1;
            width: 171px;
        }
        .auto-style3 {
            position: absolute;
            top: 115px;
            left: 127px;
            z-index: 1;
            width: 171px;
        }
        .auto-style4 {
            position: absolute;
            top: 152px;
            left: 125px;
            z-index: 1;
            width: 169px;
        }
        .auto-style5 {
            position: absolute;
            top: 49px;
            left: 12px;
            z-index: 1;
            right: 895px;
        }
        .auto-style6 {
            position: absolute;
            top: 83px;
            left: 2px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 116px;
            left: 28px;
            z-index: 1;
        }
        .auto-style8 {
            position: absolute;
            top: 152px;
            left: 45px;
            z-index: 1;
        }
        .auto-style9 {
            position: absolute;
            top: 201px;
            left: 40px;
            z-index: 1;
            right: 875px;
        }
        .auto-style10 {
            position: absolute;
            top: 203px;
            left: 210px;
            z-index: 1;
            width: 52px;
        }
        .auto-style11 {
            position: absolute;
            top: 196px;
            left: 396px;
            z-index: 1;
            width: 90px;
            height: 18px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="txtAwardBodyNo" runat="server" CssClass="auto-style1"></asp:TextBox>
        <asp:TextBox ID="txtAwardBodyName" runat="server" CssClass="auto-style2"></asp:TextBox>
        <asp:TextBox ID="txtDateFounded" runat="server" CssClass="auto-style3"></asp:TextBox>
        <asp:TextBox ID="txtLocation" runat="server" CssClass="auto-style4"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" CssClass="auto-style5" Text="AwardBodyNo"></asp:Label>
        <asp:Label ID="Label2" runat="server" CssClass="auto-style6" Text="AwardBodyName"></asp:Label>
        <asp:Label ID="Label3" runat="server" CssClass="auto-style7" Text="DateFounded"></asp:Label>
        <asp:Label ID="Label4" runat="server" CssClass="auto-style8" Text="Location"></asp:Label>
        <asp:Button ID="ABtnCancel" runat="server" CssClass="auto-style9" Text="Cancel" OnClick="ABtnCancel_Click" />
        <asp:Button ID="Abtnok" runat="server" CssClass="auto-style10" Text="ok" OnClick="Abtnok_Click" />
        <asp:Label ID="lblAwardError" runat="server" CssClass="auto-style11" Text="Label"></asp:Label>
    </form>
</body>
</html>
