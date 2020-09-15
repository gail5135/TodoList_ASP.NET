<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TodoList.ascx.cs" Inherits="WepApplication.TodoList" %>
<%@ Register TagPrefix="UC" TagName="TodoItem" Src="~/TodoItem.ascx" %>

<span>< Not Complete ></span>
<ul id="doing" runat="server">
</ul>

<span>< Complete ></span>
<ul id="done" runat="server">
</ul> 
