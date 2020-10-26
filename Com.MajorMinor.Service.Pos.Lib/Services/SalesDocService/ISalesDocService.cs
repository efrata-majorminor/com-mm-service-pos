using Com.MajorMinor.Service.Pos.Lib.ViewModels.SalesDoc;
using Com.MM.Service.Pos.Lib.Models.SalesDoc;
using Com.MM.Service.Pos.Lib.ViewModels.SalesDoc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Com.MajorMinor.Service.Pos.Lib.Services.SalesDocService
{
    public interface ISalesDocService
    {
        Tuple<List<SalesDoc>, int, Dictionary<string, string>, List<string>> ReadModel(string storecode, int Page = 1, int Size = 25, string Order = "{}", string Keyword = null, string Filter = "{}", string Username = "");
        SalesDoc ReadModelById(int id);
        List<SalesDoc> OmzetReport(string storecode, DateTimeOffset dateFrom, DateTimeOffset dateTo, string shift);
        Task<SalesDoc> Create(SalesDoc model);
        SalesDocViewModel MaptoViewModel(SalesDoc model);
        SalesDoc MapToModel(SalesDocViewModel viewModel);
        Tuple<List<SalesDoc>, int, Dictionary<string, string>, List<string>> ReadModelVoid(string storecode, int Page = 1, int Size = 25, string Order = "{}", string Keyword = null, string Filter = "{}", string Username = "");
        Task<int> Void(int id, string user, int clientTimeZoneOffset = 7);
        SalesDoc ReadModelByCode(string code, string storecode);
        Tuple<List<SalesDoc>, int, Dictionary<string, string>, List<string>> ReadModelReturn(string storecode, int Page = 1, int Size = 25, string Order = "{}", string Keyword = null, string Filter = "{}", string Username = "");
        Tuple<List<PaymentMethodReportViewModel>, int> GetPaymentMethodReport(string storecode, DateTimeOffset dateFrom, DateTimeOffset dateTo, string shift, string info,  int offset, string username, int page, int size, string Order="{}");

        Tuple<TotalCategoryViewModel, int> GetOmzetDayReport(DateTimeOffset dateFrom, DateTimeOffset dateTo, int offset, int page = 1, int size = 25, string Order = "{}");
        Tuple<List<OmzetReportViewModel>, int> GetOmzetReport(string storecode, DateTimeOffset dateFrom, DateTimeOffset dateTo, string shift, string info, int offset, string username, int page = 1, int size = 25, string Order = "{}");
        MemoryStream GenerateExcelOmzet(string storecode, DateTimeOffset dateFrom, DateTimeOffset dateTo, string shift);

    }
}
