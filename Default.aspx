<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 414px;
            left: 329px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="ListBooks" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 238px; width: 381px"></asp:ListBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 15px; top: 282px; position: absolute" Text="Please enter a Country of Origin"></asp:Label>
        <asp:TextBox ID="TxtCountryofOrigin" runat="server" style="z-index: 1; left: 15px; top: 311px; position: absolute; height: 19px; width: 208px"></asp:TextBox>
        <asp:Button ID="BtnApply" runat="server" style="z-index: 1; left: 263px; top: 301px; position: absolute; height: 32px; width: 127px" Text="Apply" OnClick="BtnApply_Click" />
        <asp:Button ID="BtnDisplayAll" runat="server" style="z-index: 1; left: 261px; top: 350px; position: absolute; height: 30px; width: 128px" Text="Display All" OnClick="BtnDisplayAll_Click"/>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 19px; top: 349px; position: absolute; height: 23px; width: 155px" Text="[LblError]"></asp:Label>
        <asp:Button ID="BtnAdd" runat="server" style="z-index: 1; left: 18px; top: 428px; position: absolute; height: 26px; width: 73px" Text="Add" OnClick="BtnAdd_Click" />
        <asp:Button ID="BtnEdit" runat="server" style="z-index: 1; left: 105px; top: 428px; position: absolute; height: 25px; width: 66px; right: 879px" Text="Edit" OnClick="BtnEdit_Click" />
        <asp:Button ID="BtnDelete" runat="server" OnClick="BtnDelete_Click" style="z-index: 1; left: 192px; top: 427px; position: absolute; height: 27px; width: 70px" Text="Delete" />
        <asp:Button ID="btnAwardpage" runat="server" CssClass="auto-style1" OnClick="btnAwardpage_Click" Text="Awardpage" />
    </form>
</body>
</html>
