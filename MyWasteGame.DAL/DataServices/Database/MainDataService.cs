using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using LiteDB;
using MyWasteGame.DAL.DataObjects;

namespace MyWasteGame.DAL.DataServices.Database {
	class MainDataService : BaseOfflineDataService, IMainDataService {
		public MainDataService(string filePath): base(filePath) {
		}

		public Task<RequestResult> AddSampleDataObject(SampleDataObject data, CancellationToken ctx) {
			return AddObject(data, ctx);
		}

		public Task<RequestResult<SampleDataObject>> GetSampleDataObject(ObjectId id, CancellationToken ctx) {
			return GetObject<SampleDataObject>(o => o.Id == id, ctx);
		}

		public Task<RequestResult<List<SampleDataObject>>> GetAllSampleDataObjects(CancellationToken ctx) {
			return GetAllObjects<SampleDataObject>(ctx);
		}
	}
}
