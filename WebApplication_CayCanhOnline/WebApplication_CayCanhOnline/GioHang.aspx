<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GioHang.aspx.cs" Inherits="WebApplication_CayCanhOnline.GioHang1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="styles/giohang.css" />
    <title>Giỏ hàng</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
    <asp:GridView runat="server" ID="gridviewGioHang"
        AutoGenerateColumns="false"
        AllowPaging="false"
        GridLines="Both"
        CssClass="giohang"
        ShowHeader="true">
        <HeaderStyle Height="30px" Font-Bold="true" />
        <Columns>
            <asp:TemplateField HeaderText="Sản Phẩm" ItemStyle-Width="30%" HeaderStyle-Width="30%">
                <ItemTemplate>
                    <div>
                        <img src='<%#Eval("img") %>' class="gh-anh" /><br />
                        <p style="padding: 15px; color: #f28902" class="gh-ten"><%#Eval("name") %></p>
                    </div>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Giá" ItemStyle-Width="20%" HeaderStyle-Width="20%">
                <ItemTemplate>
                    <p id="gia" class="gh-gia"><%#Eval("price") %></p>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Số lượng" ItemStyle-Width="15%" HeaderStyle-Width="15%">
                <ItemTemplate>
                    <p class="gh-sl"><%#Eval("sl") %></p>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Thành tiền" ItemStyle-Width="20%" HeaderStyle-Width="20%">
                <ItemTemplate>
                    <p id="tongtien"><%#Eval("thanhtien") %></p>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Loại bỏ" ItemStyle-Width="15%" HeaderStyle-Width="15%">
                <ItemTemplate>
                    <asp:Button runat="server" CssClass="btnhuy" CommandArgument='<%# Eval("id") %>' Text="Xóa" OnClick="btnXoa_Click" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:Button runat="server" ID="btnThanhToan" CssClass="btnthanhtoan" Text="Thanh toán" OnClick="btnThanhToan_Click" />

</asp:Content>
