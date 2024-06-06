<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmOperators.aspx.cs" Inherits="ArithmeticOperations.frmOperators" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblValidNo1" runat="server" Text="*" ForeColor="red" /><br />
            <asp:Label ID="lblNo1" runat="Server" Text="Number 1" />&nbsp
            <asp:TextBox ID="txtNumber1" runat="server" TextMode="Number" />
            <asp:Label ID="lblNo1Error" runat="server" Text="*" ForeColor="red" /><br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblValidNo2" runat="server" Text="*" ForeColor="red" /><br />
            <asp:Label ID="lblNo2" runat="Server" Text="Number 2" />&nbsp
            <asp:TextBox ID="txtNumber2" runat="server" TextMode="Number" /> 
            <asp:Label ID="lblNo2Error" runat="server" Text="*" ForeColor="red" />
        </p>
            <p>
                <asp:Button ID="btnADD" runat="server" OnClick="btnADD_Click" Text="ADD" />
&nbsp;<asp:Button ID="btnSUB" runat="server" OnClick="btnSUB_Click" Text="SUB" />
&nbsp;<asp:Button ID="btnMUL" runat="server" OnClick="btnMUL_Click" Text="MUL" />
&nbsp;<asp:Button ID="btnDIV" runat="server" OnClick="btnDIV_Click" Text="DIV" />
&nbsp;<asp:Button ID="btnPOW" runat="server" OnClick="btnPOW_Click" Text="POW" />
        </p>
           
               

            
        <p>
            <asp:Label ID="lblAns" runat="server"  />
        </p>
        </div>
    </form>
</body>
</html>
