<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DangNhap.aspx.cs" Inherits="WebApplication_CayCanhOnline.DangNhap1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="styles/dangnhap.css" />
    <style>

    </style>
    <script src="js/dangnhap.js"></script>
    <title>Đăng nhập</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
    <!--ĐĂNG NHẬP -->
    <div class="form-dangnhap">
        <label>Tài khoản</label>
        <asp:TextBox ID="txtTaiKhoan" runat="server" CssClass="txtTaiKhoan" placeholder="Nhập tên tài khoản"  />
        <p id="loiTaiKhoan" class="loiTaiKhoan" runat="server"></p>
        <br />
        <label>Mật khẩu:</label>
        <asp:TextBox runat="server" TextMode="Password" ID="txtMatKhau" CssClass="txtMatKhau" placeholder="Nhập password"></asp:TextBox>
        <p id="loiMatKhau" class="loiMatKhau" runat="server"></p>
        <asp:Button runat="server" ID="btnDangKy" CssClass="btnDangKy" Text="Đăng ký" OnClick="btnDangKy_Click" />
        <asp:Button runat="server" ID="btnDangNhap" CssClass="btnDangNhap" Text="Đăng nhập" OnClick="btnDangNhap_Click" />
     </div>
           <!--HẾT ĐĂNG NHẬP-->
</asp:Content>
