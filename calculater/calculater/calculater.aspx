﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calculater.aspx.cs" Inherits="calculater.calculatercalculater" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label id="calcation" runat="server"></label>
        <br />
            <label id="resul" runat="server"></label>
        </div>        
         <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="1"  />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="2" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="3" />
             <asp:Button ID="ButtonAdd" runat="server" OnClick="ButtonAdd_Click" Text=" + " />
           
            </div>
            <div>
             <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="4" />
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="5" />
            <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="6" />
            <asp:Button ID="ButtonSub" runat="server" OnClick="ButtonSub_Click" Text="  - " />
            
            </div>
            <div>
            <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="7" />
            <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="8" />
            <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="9" />
            <asp:Button ID="ButtonMult" runat="server" OnClick="ButtonMult_Click" Text=" *  " />
                </div>
        <div>
            <asp:Button ID="Button0" runat="server" OnClick="Button0_Click" Text="   0   "  />
            <asp:Button ID="ButtonDiv" runat="server" OnClick="ButtonDiv_Click" Text=" /  " />
            <asp:Button ID="ButtoMood" runat="server" Text=" % " OnClick="ButtoMood_Click" />
            </div>
            <div>
                <asp:Button ID="ButtonEqual" runat="server" OnClick="ButtonEqual_Click" Text="    =    "  />
             

            </div>
            
        
    </form>
</body>
</html>
