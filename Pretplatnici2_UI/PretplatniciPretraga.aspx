<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PretplatniciPretraga.aspx.cs" Inherits="Pretplatnici2_UI.PretplatniciPretraga" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>
        <asp:TextBox ID="txtPretraga" runat="server" OnTextChanged="txtPretraga_TextChanged"></asp:TextBox>
        </p>
        <p>
            <asp:GridView ID="GridPretplatnici" runat="server" AutoGenerateColumns="false">
                <Columns>
                   <asp:BoundField HeaderText="Ime i Prezime" DataField="Ime" />
                </Columns>
            </asp:GridView>
        </p>
    </div>
    </form>
</body>
</html>
