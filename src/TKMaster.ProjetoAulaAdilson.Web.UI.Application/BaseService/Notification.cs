namespace TKMaster.ProjetoAulaAdilson.Web.UI.Application.BaseService
{
    public class Notification
    {
        #region Properties

        public string Key { get; }

        public string Message { get; }

        #endregion

        #region Constructor

        public Notification(string key, string message)
        {
            Key = key;
            Message = message;
        }

        #endregion
    }
}
