<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HoiDap.aspx.cs " Inherits="WebApplication_CayCanhOnline.HoiDap" ValidateRequest="false" %>

<asp:Content ID="Content" ContentPlaceHolderID="content" runat="server">
    <link rel="stylesheet" href="styles/tintuc.css" />

    <p class="current"><a href="TrangChu.aspx">TRANG CHỦ</a> > HỎI ĐÁP</p>

    <div class="contact-info">
        <div class="container">
            <div class="row">
                <center>
                    <table>
                        <tr>
                            <td>
                                <img width="30" src="images/icon địa điểm.png"/>
                            </td>
                            <td>
                                <p>Address: 96 Dinh Cong, Hoang Mai, Ha Noi</p>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <img width="30" src="images/icon điện thoại.png"/>
                            </td>
                            <td>
                                <p>Tel: 0123456789</p>
                            </td>
                        </tr>
                    </table>
                </center>
            </div>
            <div class="row">
                <div class="col-6">
                    <table>
                        <div class="col-6">
                            <table style="float: right;">
                                <tr>
                                    <td>
                                        <form action="" method="GET">
                                            <fieldset>
                                                <legend>
                                                    <h2>Get In Touch</h2>
                                                </legend>
                                                <table>
                                                    <tr>
                                                        <td>First Name<br>
                                                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="bắt buộc" ControlToValidate="TextBox1" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                                                        </td>
                                                        <td>Last Name<br>
                                                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="bắt buộc" ControlToValidate="TextBox2" Display="Dynamic" SetFocusOnError="true"></asp:RequiredFieldValidator>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2">Email<br>
                                                            <asp:TextBox ID="TextBox3" runat="server" Width="319px"></asp:TextBox>
                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="bắt buộc" ControlToValidate="TextBox3" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2">Subject<br>
                                                            <asp:TextBox ID="TextBox4" runat="server" Width="322px"></asp:TextBox>
                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="bắt buộc" SetFocusOnError="true" ControlToValidate="TextBox4" Display="Dynamic"></asp:RequiredFieldValidator>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2">Message<br>
                                                            <asp:TextBox ID="TextBox5" runat="server" Width="319px" TextMode="MultiLine"></asp:TextBox>
                                                            <script type="text/javascript" lang="javascript">
                                                                CKEDITOR.replace('<%= TextBox5.ClientID%>');
                                                            </script>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </fieldset>
                                            <div align="right">
                                                <asp:Label ID="Label1" runat="server" Text="có lỗi xảy ra" Visible="False"></asp:Label>
                                                <asp:Button ID="Button1" runat="server" Text="Send message" OnClick="Button1_Click" />
                                            </div>
                                        </form>
                                    </td>
                                </tr>
                            </table>
                        </div>
                </div>
            </div>
        </div>
</asp:Content>
