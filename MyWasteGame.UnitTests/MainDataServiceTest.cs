using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyWasteGame.DAL.DataObjects;
using MyWasteGame.DAL.DataServices;

namespace MyWasteGame.UnitTests {
	[TestClass]
	public class MainDataServiceTest: BaseUnitTest {
		readonly Random _rnd = new Random((int)DateTimeOffset.UtcNow.ToUnixTimeMilliseconds());

		[TestMethod]
		public async Task TestAddSampleDataObject() {
			var reqRes = await DataServices.Main.AddSampleDataObject(new SampleDataObject {
				Description = "Unit Test"+_rnd.Next()
			}, CToken);
			CheckRequestStatus(reqRes);
		}

		[TestMethod]
		public async Task TestGetAllSampleDataObjects() {
			var reqRes = await DataServices.Main.GetAllSampleDataObjects(CToken);
			CheckRequestStatus(reqRes);
		}
	}
}
