<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="questions.aspx.cs" Inherits="practicaExamenFinal.questions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Bienvenido <asp:Label ID="lblUsername" runat="server" Text=""></asp:Label></h1>
        
        <asp:Panel ID="Panel1" runat="server">
            <h2>Pregunta 1: <asp:Label ID="lblQuestion1" runat="server" Text=""></asp:Label></h2>
            <asp:RadioButtonList ID="rblAnswers1" runat="server">
            </asp:RadioButtonList>
            <asp:Button ID="btnValidate1" runat="server" Text="Validate" OnClick="btnValidate1_Click" />
            <asp:Label ID="lblResult1" runat="server" Text=""></asp:Label>
        </asp:Panel>

        <asp:Panel ID="Panel2" runat="server">
            <h2>Pregunta 2: <asp:Label ID="lblQuestion2" runat="server" Text=""></asp:Label></h2>
            <asp:DropDownList ID="ddlAnswers2" runat="server">
            </asp:DropDownList>
            <asp:Button ID="btnValidate2" runat="server" Text="Validate" OnClick="btnValidate2_Click" />
            <asp:Label ID="lblResult2" runat="server" Text=""></asp:Label>
        </asp:Panel>

        <asp:Panel ID="Panel3" runat="server">
            <h2>Pregunta 3: <asp:Label ID="lblQuestion3" runat="server" Text=""></asp:Label></h2>
            <asp:ListBox ID="lbAnswers3" runat="server">
            </asp:ListBox>
            <asp:Button ID="btnValidate3" runat="server" Text="Validate" OnClick="btnValidate3_Click" />
            <asp:Label ID="lblResult3" runat="server" Text=""></asp:Label>
        </asp:Panel>

        <asp:Button ID="btnFinalize" runat="server" Text="Finish" OnClick="btnFinalize_Click" />
    </form>
</body>
</html>
