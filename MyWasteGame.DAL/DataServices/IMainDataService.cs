using System.Threading;
using System.Threading.Tasks;
using MyWasteGame.DAL.DataObjects;

namespace MyWasteGame.DAL.DataServices {
	public interface IMainDataService {
		Task<RequestResult<SampleDataObject>> GetSampleDataObject(CancellationToken ctx);
	}
}

