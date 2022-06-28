using TKMaster.ProjetoAulaAdilson.Web.UI.Application.Response;

namespace TKMaster.ProjetoAulaAdilson.Web.UI.Application.BaseService.Interfaces
{
    public interface IBaseService
    {
        string UrlBase { get; }

        string MontarParametros(string[] parametros);

        HttpRequestMessage MontarRequest(string metodo, string url, object parametros = null);

        Task<RetornoAPIData<T>> MontarResponse<T>(HttpRequestMessage request) where T : class;

        Task<RetornoAPIData<KeyValuePair<object, string>>> MontarResponseRegraNegocio(HttpRequestMessage request);

        Task<RetornoAPIDataList<T>> MontarResponseList<T>(HttpRequestMessage request) where T : class;
    }
}
