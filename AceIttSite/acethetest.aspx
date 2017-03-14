<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="acethetest.aspx.cs" Inherits="acethetest" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
        <div id="test" runat="server"></div>

    <form method="post" runat="server" action="TestCompleted.aspx">
    <fieldset>
         <div class="row">
        <div class="col-lg-12"  >
            <p class="text-center">
            <h2>
        <asp:label ID="ExamTitle" runat="server" CssClass="text-center" /></h2></p>
            </div>
             </div>
        <p><br /></p>
            
                <div id="questions" runat="server"></div>

        <input type="submit" value="Submit" />
       
    </fieldset>
</form>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="LeftColumnContent" Runat="Server">
    
       
</asp:Content>

