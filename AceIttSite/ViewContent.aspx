<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ViewContent.aspx.cs" Inherits="ViewContent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <br /><br /><br /><br /><br />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="LeftColumnContent" Runat="Server">
    <asp:Label ID="ContentName" runat="server"></asp:Label>
    <br />
    <p></p>
    <div>
        <div class="embed-responsive embed-responsive-16by9">
            <iframe ID="ContentVideo" class="embed-responsive-item" src="//www.youtube.com/embed/ePbKGoIGAXY" runat="server"></iframe>
        </div>
    </div>
</asp:Content>

