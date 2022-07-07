<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Exemplo1.aspx.cs" Inherits="REPEATER.Exemplo1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript" src="Scripts/exemplo1.js"></script>
    <script type="text/javascript">
        if (window.history.replaceState) window.history.replaceState(null, null, window.location.href);
    </script>
    <div runat="server" id="divPrincipal" class="panel panel-default floatLeft body-formulario">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div id="Titulo" class="title" style="text-align: center;">
                    <h2 class="tituloDefault">
                        <asp:Label ID="lblTitulo" Text="Exemplo de uso recurso REPEATER do ASP.NET" runat="server" />
                    </h2>
                </div>
                <br />
                <div class="row default-padding">
                    <div class="col-xs-9 floatLeft">
                        <asp:Label ID="lblDescricao" runat="server" Text="Cliente:" Font-Bold="true" />
                        <asp:DropDownList ID="ddlCliente" runat="server" CssClass="form-control chosen-select ddlCliente" AppendDataBoundItems="true" onchange="ddlCliente_Change(this);" AutoPostBack="false"></asp:DropDownList>
                    </div>
                    <div class="col-xs-3 floatLeft">
                        <asp:Label ID="lblData" runat="server" Text="Data:" Font-Bold="true" />
                        <div class="input-group">
                            <span class="input-group-addon">
                                <asp:Label ID="lblDataIcon" runat="server" CssClass="glyphicon glyphicon-calendar" />
                            </span>
                            <asp:TextBox ID="txtData" Style="margin-right: 10px" class="form-control txtData" placeholder="DD/MM/AAAA" runat="server" MaxLength="50" onchange="txtData_Change(this);" AutoPostBack="false" />
                        </div>
                    </div>
                </div>
                <br />
                <div class="row" style="text-align: right; min-height: 50px">
                    <div class="col-xs-12">
                        <asp:Button ID="btnPesquisar" CssClass="btn btn-primary btnPesquisar" Style="min-width: 130px;" Text="Pesquisar" runat="server" EnableViewState="true" OnClick="btnPesquisar_Click" Enabled="false" />
                    </div>
                </div>
                <br />
                <div class="row default-padding" id="divProdutos" runat="server" visible="false">
                    <asp:Repeater ID="rptProdutos" runat="server" OnItemDataBound="rptProdutos_ItemDataBound">
                        <ItemTemplate>
                            <div class="col-xs-12 floatLeft">
                                <div class="row default-padding ">
                                    <div class="col-xs-4 floatLeft" style="margin-top: 32px;">
                                        <label><b>Produto: </b></label>
                                        <asp:Label CssClass="jsIdProduto" ID="lblIdProduto" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ID") %>' />&nbsp;-
                                        <asp:Label ID="lblDescricaoProduto" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Descricao") %>' />
                                        <asp:HiddenField ClientIDMode="Static" ID="hidden_IdProduto" runat="server" Value='<%# DataBinder.Eval(Container.DataItem, "ID") %>' />
                                    </div>
                                    <div class="col-xs-4 floatLeft">
                                        <label><b>Categoria: </b></label>
                                        <asp:DropDownList ID="ddlProdutoCategoria" runat="server" CssClass="form-control chosen-select ddlProdutoCategoria" AppendDataBoundItems="false" AutoPostBack="false" onchange="changeDropdown(this)"></asp:DropDownList>
                                    </div>
                                    <div class="col-xs-4 floatLeft">
                                        <label><b>SubCategoria: </b></label>
                                        <asp:DropDownList ID="ddlProdutoSubCategoria" runat="server" CssClass="form-control chosen-select ddlProdutoSubCategoria" AppendDataBoundItems="false" AutoPostBack="false"></asp:DropDownList>
                                    </div>
                                </div>
                                <br /><br />
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    <script type="text/javascript">
        $(document).ready(function () {
            inicializar();
        });
    </script>
</asp:Content>
