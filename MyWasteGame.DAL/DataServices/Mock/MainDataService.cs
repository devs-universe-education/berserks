using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using LiteDB;
using MyWasteGame.DAL.DataObjects;

namespace MyWasteGame.DAL.DataServices.Mock {
	class MainDataService: BaseMockDataService, IMainDataService {
		public Task<RequestResult<SampleDataObject>> GetSampleDataObject(ObjectId id, CancellationToken ctx) {
			return GetMockData<SampleDataObject>("MyWasteGame.DAL.Resources.Mock.Main.SampleDataObject.json");
		}

		public Task<RequestResult<List<SampleDataObject>>> GetAllSampleDataObjects(CancellationToken ctx) {
			return GetMockDataList<SampleDataObject>("MyWasteGame.DAL.Resources.Mock.Main.SampleDataObjects.json");
		}

		public Task<RequestResult> AddSampleDataObject(SampleDataObject data, CancellationToken ctx) {
			return Task.FromResult(new RequestResult(RequestStatus.Ok));
		}
	}
}

