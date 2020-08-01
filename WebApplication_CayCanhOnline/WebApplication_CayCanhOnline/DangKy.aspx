<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DangKy.aspx.cs" Inherits="WebApplication_CayCanhOnline.DangKy1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="styles/dangky.css" />
    <title>Đăng ký</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
    <div class="form-dangky">
        <label>Tài khoản:</label>
        <asp:TextBox ID="txtTaiKhoan" runat="server" CssClass="txtTaiKhoan" placeholder="Nhập tên tài khoản"  />
        <p id="loiTaiKhoan" class="loi" runat="server"></p>
        <br />
        <label>Mật khẩu:</label>
        <asp:TextBox runat="server" TextMode="Password" ID="txtMatKhau" CssClass="txtMatKhau" placeholder="Nhập mật khẩu"></asp:TextBox>
        <p id="loiMatKhau" class="loi" runat="server"></p>
        <br />
        <label>Mật khẩu:</label>
        <asp:TextBox runat="server" TextMode="Password" ID="txtMatKhau2" CssClass="txtMatKhau" placeholder="Nhập lại mật khẩu"></asp:TextBox>
        <p id="loiMatKhau2" class="loi" runat="server"></p>
        <br />
        <asp:Button runat="server" ID="btnDangKy" Text="Đăng ký" CssClass="btnDangKy" OnClick="btnDangKy_Click" />
</asp:Content>
