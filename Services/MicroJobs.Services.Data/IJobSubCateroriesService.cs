namespace MicroJobs.Services.Data
{
    using System.Collections.Generic;

    public interface IJobSubCateroriesService
    {
        IEnumerable<KeyValuePair<string, string>> GetAllAsKeyValuePairs();
    }
}
