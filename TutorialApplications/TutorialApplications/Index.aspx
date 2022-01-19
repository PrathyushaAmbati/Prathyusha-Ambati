﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="TutorialApplications.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tutorial Appliications</title>
    Tutorial Applications
</head>
<body>
    <form id="form1" runat="server">
        <div style =" background-color  :aqua">
            <table>
                <tr>
                    <td><asp:Label ID ="Label1" runat="server" Text="Tutorial Id"></asp:Label></td>
                    <td><asp:TextBox ID="txtTutorialId" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label2" runat="server" Text="Tutorial Name"></asp:Label></td>
                    <td><asp:TextBox ID="txtTutorialName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label4" runat="server" Text="Description"></asp:Label></td>
                    <td><asp:TextBox ID="txtDescription" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Published"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtPublished" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td><asp:Button ID="BtnSave" runat="server" Text="Save" OnClick="BtnSave_Click" />
            <asp:Button ID="BtnReset" runat="server" Text="Reset" OnClick="BtnReset_Click" /></td>
                </tr>
            </table>
            
            <hr />
            <asp:Label Text="" ID="lblResult" runat="server"/>
            <hr />
            <h2>Tutorial Details</h2>
            <asp:GridView ID="gvTutorialDetails" runat="server"></asp:GridView>

        </div>
    </form>
</body>
</html>
