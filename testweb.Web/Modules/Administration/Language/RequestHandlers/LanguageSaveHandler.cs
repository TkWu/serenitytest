using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<testweb.Administration.LanguageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = testweb.Administration.LanguageRow;


namespace testweb.Administration
{
    public interface ILanguageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }
    public class LanguageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageSaveHandler
    {
        public LanguageSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}