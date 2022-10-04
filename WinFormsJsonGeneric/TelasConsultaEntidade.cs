
using System.Diagnostics.Contracts;

namespace WinFormsJsonGeneric
{
  /// <summary>
  /// Vamos usar para criar nosso arquivo Json guardando as configurações das telas de consulta
  /// </summary>

  public class Caixa
  {

    public int NumeroCaixa { get; set; }
    public IList<TelasConsultaEntidade> TelaConsulta { get; set; }

    public Caixa(int _caixa)
    {
      this.NumeroCaixa = _caixa;
      this.TelaConsulta = new List<TelasConsultaEntidade>();

    }
  }

  public class TelasConsultaEntidade
  {
    public string NomeTelaConsulta { get; set; }
    public bool PesquisaCadaDigitacao { get; set; }
    public string ValorComboFiltro { get; set; }
    public string ValorComboPesquisa { get; set; }
    public string TipoDeBusca { get; set; }

    public IDictionary<string, string> LarguraColsGrid { get; set; }

    public TelasConsultaEntidade()
    {
      this.NomeTelaConsulta = "";
      this.PesquisaCadaDigitacao = false;
      this.ValorComboFiltro = "";
      this.ValorComboPesquisa = "";
      this.TipoDeBusca = "";
      this.LarguraColsGrid = new Dictionary<string, string>();
    }
    public TelasConsultaEntidade(string telaConsulta, bool pesquisaCadaDigitacao, string valorComboFiltro, string valorComboPesquisa, string tipoDeBusca, IDictionary<string, string> larguraColsGrid)
    {
      NomeTelaConsulta = telaConsulta;
      PesquisaCadaDigitacao = pesquisaCadaDigitacao;
      ValorComboFiltro = valorComboFiltro;
      ValorComboPesquisa = valorComboPesquisa;
      TipoDeBusca = tipoDeBusca;
      LarguraColsGrid = larguraColsGrid;
    }
  }
}
