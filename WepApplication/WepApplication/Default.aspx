<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WepApplication._Default" %>
<%@ Register TagPrefix="UC" TagName="TodoInput" Src="~/TodoInput.ascx" %>
<%@ Register TagPrefix="UC" TagName="TodoList" Src="~/TodoList.ascx" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <UC:TodoInput ID="Input" runat="server" />
    <br />
    <br />
    <UC:TodoList ID="List" runat="server" />
    <br />
</asp:Content>
