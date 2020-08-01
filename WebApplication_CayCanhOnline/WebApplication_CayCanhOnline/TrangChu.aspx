<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TrangChu.aspx.cs" Inherits="WebApplication_CayCanhOnline.TrangChu1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
                    <!--Datalist
                    <asp:DataList ID="dlSanPhamNoiBat" cssClass="DataListSanPham" runat="server" CellPadding="0" RepeatColumns="3" RepeatDirection="Horizontal">
                        <ItemTemplate>
                            <div class="san-pham">       
                                <asp:Image runat="server" ImageUrl='<%#Eval("img") %>' CssClass="anh-san-pham"/><br />
                                <p class="ten"><%#Eval("name") %></p>
                                <p class="gia"><%#Eval("price") %> đồng</p>
                                <asp:Button runat="server" CssClass="btnThem"  CommandArgument='<%# Eval("id") %>' Text="THÊM VÀO GIỎ" OnClick="btnThem_Click"/>
                            </div>
                        </ItemTemplate>
                    </asp:DataList>
                    -->
                    <div class="row" style="width:100%">
                        <asp:Repeater ID="myRepeater" runat="server">
                            <ItemTemplate>
                                <div class="san-pham">       
                                    <asp:Image runat="server" ImageUrl='<%#Eval("img") %>' CssClass="anh-san-pham"/><br />
                                    <p class="ten"><%#Eval("name") %></p>
                                    <p class="gia"><%#Eval("price") %> đồng</p>
                                    <asp:Button runat="server" CssClass="btnThem"  CommandArgument='<%# Eval("id") %>' Text="THÊM VÀO GIỎ" OnClick="btnThem_Click"/>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
</asp:Content>
