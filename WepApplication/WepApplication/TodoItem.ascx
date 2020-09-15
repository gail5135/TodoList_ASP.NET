<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TodoItem.ascx.cs" Inherits="WepApplication.TodoItem" %>

<li id="todoItem" runat="server">
    <%=todo %>  
    <% if (!complete)
        { %>
        <asp:Button ID="btnComp" runat="server" Text="완료" OnClick="Click_Complete" />
    <%} %>
    <%else
        { %>
        <asp:Button ID="btmCncl" runat="server" Text="삭제" OnClick="Click_Remove" />
    <%} %>
</li>
