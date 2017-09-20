<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="İzle.aspx.cs" Inherits="FilmSite.WEB.UI.İzle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form>
        <div>
    <asp:Repeater ID="rptIzle" runat="server">
        <ItemTemplate>
            <div class="row">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">                  
                        <iframe width="560" height="315" src='<%# Eval("FilmUrlAdi") %>'></iframe>                
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
        </div>
    </form>

 


</asp:Content>
