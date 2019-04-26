using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using LiteDB;
using MyWasteGame.DAL.DataObjects;

namespace MyWasteGame.DAL.DataServices {
	public interface IMainDataService {
		Task<RequestResult<SampleDataObject>> GetSampleDataObject(ObjectId id, CancellationToken ctx);
		Task<RequestResult<List<SampleDataObject>>> GetAllSampleDataObjects(CancellationToken ctx);
		Task<RequestResult> AddSampleDataObject(SampleDataObject data, CancellationToken ctx);
	}
}

