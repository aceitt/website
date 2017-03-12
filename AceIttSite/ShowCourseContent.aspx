<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ShowCourseContent.aspx.cs" Inherits="ShowCourseContent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <br /><br /><br /><br />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="LeftColumnContent" Runat="Server">
    <div id="test" Runat="server"></div>

    <div class="row">
        <div class="col-lg-6">
          <h2><asp:Label ID="courseName" runat="server"></asp:Label></h2>
          <p><div id="content" Runat="server"></div>
          </p>
            <br /><br />
          <p><a class="btn btn-default" href="Courses.aspx" role="button">Back to courses &raquo;</a></p>
        </div><!-- /.col-lg-4 -->
        <div class="col-lg-6">
            <p>
          <h2>Measure acquired skills</h2></p>
         <p><div id ="tests" runat="server"></div></p>
            <p class="pull-left"><a class="btn btn-default" href="default.aspx" role="button">Home &raquo;</a></p>
        </div><!-- /.col-lg-4 -->
      </div>
</asp:Content>

