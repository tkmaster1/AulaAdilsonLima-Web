namespace TKMaster.ProjetoAulaAdilson.Web.UI.Application.BaseService.Interfaces
{
    public interface INotificationHandler<T> where T : class
    {
        Task Handle(T notification);
    }
}
