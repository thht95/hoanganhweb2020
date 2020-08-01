<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="tlhoidap.aspx.cs" Inherits="WebApplication_CayCanhOnline.tlhoidap" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
    <table class="table">
        <tr>
                <th class="firstname">Firstname</th>
                <th class="Lastname">Lastname</th>
                <th class="Email">Email</th>
                <th class="Subject">Subject</th>
            <th  class="message">Message</th>
            <th class="congcu">Công cụ</th>
            </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr id="danhmuc_<%# Eval("id")%>">
                    <td  class="firstname"><%# Eval("firstname")  %></td>
                    <td class="Lastname"><%# Eval("lastname")  %></td>
                    <td class="Email"><%# Eval("email")  %></td>
                    <td class="Subject"><%# Eval("subj")  %></td>
                    <td class="message"><%# Eval("messenger")  %></td>
                    <td class="congcu"><a href="javascript:xoachude(<%# Eval("id")  %>)"> xóa</a></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
</asp:Content>
