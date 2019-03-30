using System.Threading;
using System.Threading.Tasks;
using MyWasteGame.DAL.DataObjects;

namespace MyWasteGame.DAL.DataServices.Mock {
	class MockMainDataService: BaseMockDataService, IMainDataService {
		public Task<RequestResult<SampleDataObject>> GetSampleDataObject(CancellationToken ctx) {
			return GetMockData<SampleDataObject>("MyWasteGame.DAL.Resources.Mock.Main.SampleDataObject.json");
		}
	}
}

