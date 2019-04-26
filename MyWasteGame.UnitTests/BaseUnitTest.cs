using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyWasteGame.DAL;
using MyWasteGame.DAL.DataServices;
using Newtonsoft.Json;

namespace MyWasteGame.UnitTests {
	public class BaseUnitTest {
		readonly CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromMinutes(3));
		protected CancellationToken CToken => _cancellationTokenSource.Token;

		[TestInitialize]
		public async Task Init() {
			DataServices.Init(false, "local.db");
		}

		void LogError(IDictionary<string, string> errorData) {
			var json = JsonConvert.SerializeObject(errorData, Formatting.Indented);
			Console.WriteLine(json);
		}

		protected void CheckRequestStatus(RequestResult result, [CallerMemberName] string callerName = null) {
			CheckRequestStatus(result, RequestStatus.Ok, callerName);
		}

		protected void CheckRequestStatus<T>(RequestResult<T> result, [CallerMemberName] string callerName = null) where T : class {
			CheckRequestStatus(result, RequestStatus.Ok, callerName);
		}

		protected void CheckListNotEmpty(IList list) {
			Assert.IsNotNull(list);
			Assert.IsTrue(list.Count > 0);
		}

		protected void CheckRequestStatus(RequestResult result, RequestStatus expectedStatus, [CallerMemberName] string callerName = null) {
			Assert.AreEqual(expectedStatus, result.Status, $"Invalid {callerName}(): {result.Status}, {result.Message}");
		}

		protected void CheckRequestStatus<T>(RequestResult<T> result, RequestStatus expectedStatus, [CallerMemberName] string callerName = null) where T : class {
			Assert.AreEqual(expectedStatus, result.Status, $"Invalid {callerName}(): {result.Status}, {result.Message}");
		}
	}
}
