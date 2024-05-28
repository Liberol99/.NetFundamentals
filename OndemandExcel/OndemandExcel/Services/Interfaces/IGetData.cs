using System.Dynamic;

namespace OndemandExcel.Services.Interfaces
{
    public interface IGetData
    {
        public List<ExpandoObject> GetData(string filepath);
    }
}
