using MyRequest = Serenity.Services.SaveRequest<SereneEmployees.Administration.LanguageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SereneEmployees.Administration.LanguageRow;


namespace SereneEmployees.Administration;
public interface ILanguageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }
public class LanguageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageSaveHandler
{
    public LanguageSaveHandler(IRequestContext context)
         : base(context)
    {
    }
}