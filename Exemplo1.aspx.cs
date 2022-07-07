using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using REPEATER.Models;

namespace REPEATER
{
    public partial class Exemplo1 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Carregar_Clientes();

                txtData.Text = string.Format("{0: dd/MM/yyyy}", DateTime.Now);
            }
        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            Carregar_Produtos();
        }

        protected void rptProdutos_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            DropDownList ddlProdutoCategoria = (DropDownList)e.Item.FindControl("ddlProdutoCategoria");
            DropDownList ddlProdutoSubCategoria = (DropDownList)e.Item.FindControl("ddlProdutoSubCategoria");

            Produto pd = (Produto)e.Item.DataItem;

            Carregar_Produto_Categoria(ddlProdutoCategoria, pd.Categoria);
            Carregar_Produto_SubCategoria(ddlProdutoSubCategoria, pd.SubCategoria);
        }

        private void Carregar_Clientes()
        {
            ddlCliente.Items.Clear();
            ddlCliente.DataValueField = "ID";
            ddlCliente.DataTextField = "Nome";
            ddlCliente.DataSource = Cliente.Listar();
            ddlCliente.DataBind();
            ddlCliente.Items.Insert(0, new ListItem("--- Selecione ---", ""));
            ddlCliente.SelectedIndex = 0;
        }

        private void Carregar_Produtos()
        {
            rptProdutos.DataSource = null;
            rptProdutos.DataBind();

            rptProdutos.DataSource = Produto.Listar();
            rptProdutos.DataBind();

            divProdutos.Visible = true;
        }

        private void Carregar_Produto_Categoria(DropDownList ddlProdutoCategoria, int Categoria)
        {
            ddlProdutoCategoria.Items.Clear();
            ddlProdutoCategoria.DataValueField = "ID";
            ddlProdutoCategoria.DataTextField = "Descricao";
            ddlProdutoCategoria.DataSource = ProdutoCategoria.Listar();
            ddlProdutoCategoria.DataBind();
            ddlProdutoCategoria.Items.Insert(0, new ListItem("--- Selecione ---", ""));

            switch (Categoria)
            {
                case 201:
                    ddlProdutoCategoria.SelectedIndex = 1;
                    break;
                case 202:
                    ddlProdutoCategoria.SelectedIndex = 2;
                    break;
                case 203:
                    ddlProdutoCategoria.SelectedIndex = 3;
                    break;
                default:
                    ddlProdutoCategoria.SelectedIndex = 0;
                    break;
            }
        }

        private void Carregar_Produto_SubCategoria(DropDownList ddlProdutoSubCategoria, int SubCategoria)
        {
            ddlProdutoSubCategoria.Items.Clear();
            ddlProdutoSubCategoria.DataValueField = "ID";
            ddlProdutoSubCategoria.DataTextField = "Descricao";
            ddlProdutoSubCategoria.DataSource = ProdutoSubCategoria.Listar();
            ddlProdutoSubCategoria.DataBind();
            ddlProdutoSubCategoria.Items.Insert(0, new ListItem("--- Selecione ---", ""));

            switch (SubCategoria)
            {
                case 301:
                    ddlProdutoSubCategoria.SelectedIndex = 1;
                    break;
                case 302:
                    ddlProdutoSubCategoria.SelectedIndex = 2;
                    break;
                case 303:
                    ddlProdutoSubCategoria.SelectedIndex = 3;
                    break;
                default:
                    ddlProdutoSubCategoria.SelectedIndex = 0;
                    break;
            }
        }
    }
}
