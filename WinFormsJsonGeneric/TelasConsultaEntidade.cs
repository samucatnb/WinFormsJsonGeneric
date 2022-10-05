
using System.Diagnostics.Contracts;

namespace WinFormsJsonGeneric
{
  /// <summary>
  /// Vamos usar para criar nosso arquivo Json guardando as configurações das telas de consulta
  /// </summary>

  public class Caixa
  {

    public int NumeroCaixa { get; set; }
    public string NomeTelaConsulta { get; set; }
    public IList<TelasConsultaEntidade> Parametros { get; set; }

    public Caixa(int _caixa, string _nomeTelaConsulta)
    {
      this.NumeroCaixa = _caixa;
      this.NomeTelaConsulta = _nomeTelaConsulta;
      this.Parametros = new List<TelasConsultaEntidade>();

    }
  }

  public class TelasConsultaEntidade
  {
    public bool PesquisaCadaDigitacao { get; set; }
    public string ValorComboFiltro { get; set; }
    public string ValorComboPesquisa { get; set; }
    public string TipoDeBusca { get; set; }

    public IDictionary<string, string> LarguraColsGrid { get; set; }

    public TelasConsultaEntidade()
    {
      this.PesquisaCadaDigitacao = false;
      this.ValorComboFiltro = "";
      this.ValorComboPesquisa = "";
      this.TipoDeBusca = "";
      this.LarguraColsGrid = new Dictionary<string, string>();
    }
    public TelasConsultaEntidade(bool pesquisaCadaDigitacao, string valorComboFiltro, string valorComboPesquisa, string tipoDeBusca, IDictionary<string, string> larguraColsGrid)
    {
      PesquisaCadaDigitacao = pesquisaCadaDigitacao;
      ValorComboFiltro = valorComboFiltro;
      ValorComboPesquisa = valorComboPesquisa;
      TipoDeBusca = tipoDeBusca;
      LarguraColsGrid = larguraColsGrid;
    }
  }
}
