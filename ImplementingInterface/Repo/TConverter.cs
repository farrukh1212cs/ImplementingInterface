using ImplementingInterface.Interface;
using ImplementingInterface.Models;
using ImplementingInterface.Repo.IRepo;

namespace ImplementingInterface.Repo
{
    public class TConverter : TableReader<Root>, ITConverter
    {
        public TConverter(IDataConverter<Root> dataConverter) : base(dataConverter)
        {
        }
    }
}
