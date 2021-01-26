<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DefaultAward.aspx.cs" Inherits="DefaultAward" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 34px;
            left: 10px;
            z-index: 1;
            width: 352px;
            height: 292px;
        }
        .auto-style2 {
            position: absolute;
            top: 375px;
            left: 16px;
            z-index: 1;
            width: 54px;
        }
        .auto-style3 {
            position: absolute;
            top: 374px;
            left: 90px;
            z-index: 1;
            width: 54px;
        }
        .auto-style4 {
            position: absolute;
            top: 372px;
            left: 182px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 372px;
            left: 258px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 336px;
            left: 15px;
            z-index: 1;
            width: 166px;
        }
        .auto-style7 {
            position: absolute;
            top: 331px;
            left: 263px;
            z-index: 1;
            width: 91px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="ListAward" runat="server" CssClass="auto-style1"></asp:ListBox>
        <asp:Button ID="BtnAdd" runat="server" CssClass="auto-style2" OnClick="BtnAdd_Click" Text="Add" />
        <asp:Button ID="Btnview" runat="server" CssClass="auto-style3" OnClick="Btnview_Click" Text="View" />
        <asp:Button ID="Btndelete" runat="server" CssClass="auto-style4" Text="Delete" />
        <asp:Button ID="BtndisplayAllAward" runat="server" CssClass="auto-style5" OnClick="BtndisplayAllAward_Click" Text="DisplayAward" />
        <asp:TextBox ID="TxtAwardbody" runat="server" CssClass="auto-style6"></asp:TextBox>
        <asp:Button ID="btnApplyAward" runat="server" CssClass="auto-style7" OnClick="btnApplyAward_Click" Text="Apply" />
    </form>
</body>
</html>
