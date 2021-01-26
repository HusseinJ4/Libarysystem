<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnBook.aspx.cs" Inherits="AnBook" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Checkbox1 {
            z-index: 1;
            left: 574px;
            top: 194px;
            position: absolute;
        }
        #Button1 {
            z-index: 1;
            top: 230px;
            position: absolute;
            left: 628px;
            width: 79px;
        }
        .auto-style1 {
            position: absolute;
            top: 238px;
            left: 608px;
            z-index: 1;
            width: 214px;
            height: 20px;
        }
        .auto-style2 {
            position: absolute;
            top: 238px;
            left: 536px;
            z-index: 1;
        }
    </style>
</head>
<body style="height: 47px; width: 969px">
    <form id="form1" runat="server">
        <p>
            <asp:TextBox ID="txtBooksNo" runat="server" style="z-index: 1; left: 123px; top: 94px; position: absolute; bottom: 559px; width: 227px; height: 11px;"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="txtBookName" runat="server" style="z-index: 1; left: 120px; top: 138px; position: absolute; width: 230px"></asp:TextBox>
        </p>
        <asp:TextBox ID="txtCountryOforigin" runat="server" style="z-index: 1; left: 120px; top: 226px; position: absolute; height: 19px; width: 227px"></asp:TextBox>
        <asp:TextBox ID="txtISBN" runat="server" style="z-index: 1; left: 121px; top: 282px; position: absolute; width: 224px"></asp:TextBox>
        <asp:DropDownList ID="cmbPublisher" runat="server" style="z-index: 1; left: 595px; top: 93px; position: absolute; height: 16px; width: 155px;">
        </asp:DropDownList>
        <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 604px; top: 147px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 521px; top: 96px; position: absolute" Text="Publisher"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 38px; top: 95px; position: absolute; height: 19px; width: 77px" Text="Book No"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 27px; top: 138px; position: absolute; height: 21px; width: 81px; bottom: 325px;" Text="Book Name"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 7px; top: 234px; position: absolute; height: 18px; width: 108px; bottom: 232px" Text="Country of Origin"></asp:Label>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 35px; top: 281px; position: absolute" Text="ISBN"></asp:Label>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 502px; top: 147px; position: absolute; height: 19px; width: 76px;" Text="Date added"></asp:Label>
        <p>
            <asp:Button ID="btnOk" runat="server" style="z-index: 1; top: 51px; position: absolute; right: 799px; width: 81px; height: 26px;" Text="Ok" OnClick="btnOk_Click"/>
            <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 592px; top: 190px; position: absolute; right: 286px;" />
            <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 45px; top: 188px; position: absolute" Text="Author"></asp:Label>
            <asp:TextBox ID="txtAuthor" runat="server" style="z-index: 1; left: 121px; top: 183px; position: absolute; height: 21px; width: 227px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 534px; top: 192px; position: absolute" Text="Active"></asp:Label>
        </p>
        <p>
            <asp:Button ID="BtnCancel" runat="server" OnClick="BtnCancel_Click" Text="Cancel" />
            <asp:DropDownList ID="cmdAward" runat="server" CssClass="auto-style1">
            </asp:DropDownList>
            <asp:Label ID="Label9" runat="server" CssClass="auto-style2" Text="Award"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Label ID="LblError" runat="server" style="z-index: 1; left: 61px; top: 333px; position: absolute" Text="LblError"></asp:Label>
            <p>
                &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
