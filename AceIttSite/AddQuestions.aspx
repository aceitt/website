<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddQuestions.aspx.cs" Inherits="AddQuestions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <br /><br /><br /><br /><br /><br />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="LeftColumnContent" Runat="Server">
    
    <%--<a href="https://www.codecogs.com/eqnedit.php?latex=\frac{d}{dx}c^n=nx^{n-1}" target="_blank"><img src="https://latex.codecogs.com/gif.latex?\frac{d}{dx}c^n=nx^{n-1}" title="\frac{d}{dx}c^n=nx^{n-1}" /></a>--%>
    
    <form method="post" action="AddQuestionToDb.aspx" runat="server" >
        <fieldset>
            <div>
            <label for="sel1">Select Course:</label>
  <select class="form-control" id="sel1" name="SubId">
    <option>EAMCET MATHS</option>
    <option>EAMCET Physics</option>
    <option>EAMCET Chemistry</option>
    <option>Probability</option>    
  </select></div> <br />

          <div class="form-group">
  <label for="comment">Question:</label>
  <textarea class="form-control" rows="5" id="comment" name="Question"></textarea>
</div>
      
              <div class="form-group">
  <label for="comment">Choices:</label>
  <textarea class="form-control" rows="5" id="comment" name="choices"></textarea>
</div>

                          <div class="form-group">
  <label for="comment">Answer:</label>
  <textarea class="form-control" rows="5" id="comment" name="answer"></textarea>
</div>
         <button type="submit" class="btn btn-default">Submit</button>
        </fieldset>
    </form>
</asp:Content>

