<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="FilmSite.WEB.UI._default" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
        <div>
            <%--         <asp:Repeater ID="rptFilmler" runat="server" OnItemCommand="rptFilmler_ItemCommand">
                <ItemTemplate>
                 
                        <div class="row">

                       
                        <div class="col-lg-4 col-md-6 col-sm-6 col-xs-12" style="margin-top:5px">



                       <%--     <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='../İzle.aspx?id=<%# Eval("FilmId") %>' >
                                <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("Image") %>' Height="250px" Width="250px" />
                            </asp:HyperLink>  --%>


            <%--</div>--%>


            <%--        <div class="col-lg-8 col-md-6 col-sm-6 col-xs-12" style="margin-top:5px">
                         
                             <div><%# Eval("FilmAdi") %></div>
                            <div><%# Eval("KayitTarihi") %></div>
                            <div><%# Eval("Language") %></div>
                             <div><%# Eval("Suresi") %></div>
                             <div><%# Eval("Puanı") %></div>
                            <div><%# Eval("Konusu") %></div>
                        </div>  
                                </div> --%>

            <%--</ItemTemplate>--%>
            <%--</asp:Repeater>--%>--%>
            <asp:GridView ID="GridView1" runat="server" OnRowCommand="GridView1_RowCommand">

                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <div class="row">

                                <div class="col-lg-4 col-md-6 col-sm-6 col-xs-12" style="margin-top: 5px">

                                    <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("Image") %>' Height="250px" Width="250px" />

                                   <asp:Button ID="Button1" runat="server" Text="İzle"  CommandName="İzle" CommandArgument='<%# Eval("FilmId") %>' />
                                    </div>
            <%--                           <div class="col-lg-8 col-md-6 col-sm-6 col-xs-12" style="margin-top:5px">
                         
                             <div><%# Eval("FilmAdi") %></div>
                            <div><%# Eval("KayitTarihi") %></div>
                            <div><%# Eval("Language") %></div>
                             <div><%# Eval("Suresi") %></div>
                             <div><%# Eval("Puanı") %></div>
                            <div><%# Eval("Konusu") %></div>
                        </div>  --%>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>

        </div>
    </form>
</asp:Content>
