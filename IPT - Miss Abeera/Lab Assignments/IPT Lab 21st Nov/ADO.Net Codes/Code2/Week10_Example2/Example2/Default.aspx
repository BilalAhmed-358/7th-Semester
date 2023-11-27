<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Example2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddlStudent" runat="server" AutoPostBack="true"
                OnSelectedIndexChanged="ddlStudent_SelectedIndexChanged">
            </asp:DropDownList>
            <br /><br />
            <div style="display: table">
                <div style="display: table-row">
                    <asp:Label runat="server" Text="Name" style="display:table-cell" />&nbsp;
                    <asp:TextBox runat="server" ID="txtName" style="display:table-cell" />
                </div>
                <div style="display: table-row">
                    <asp:Label runat="server" Text="Admission Year" style="display:table-cell" />&nbsp;
                    <asp:TextBox runat="server" ID="txtAdmissionYear" style="display:table-cell" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
