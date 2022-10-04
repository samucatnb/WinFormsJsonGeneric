using System.Reflection;

namespace WinFormsJsonGeneric
{
  public partial class Form1 : Form
  {
    JsonGeneric<List<Caixa>> json;
    List<Caixa> caixas;

    public Form1()
    {
      InitializeComponent();
      json = new JsonGeneric<List<Caixa>>(this.Name);

    }

    private void button1_Click(object sender, EventArgs e)
    {
      //encontra o item na lista e remove se existir
      int nCaixa = int.Parse(txtCaixa.Text);
      var listaArquivo = json.LeArquivoJson();
      listaArquivo.RemoveAll(l => l.NumeroCaixa == nCaixa);
      //listaArquivo.Remove(item);

      Caixa caixa = new Caixa(nCaixa);
      TelasConsultaEntidade paramTela = new TelasConsultaEntidade();
      paramTela.PesquisaCadaDigitacao = true;
      paramTela.TipoDeBusca = "EXATA";
      paramTela.ValorComboPesquisa = "Codigo";
      paramTela.ValorComboFiltro = "Todos";

      caixas = listaArquivo;
      caixa.TelaConsulta.Add(paramTela);

      caixas = caixas ?? new List<Caixa>(nCaixa);

      caixas.Add(caixa);
      json.GravarAlterarArquivo(caixas);

    }

    private void button2_Click(object sender, EventArgs e)
    {
      txtVisualiza.Text = json.GetArquivoJsonString();
    }
  }
}