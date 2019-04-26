using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using MyWasteGame.DAL.DataObjects;

namespace MyWasteGame.DAL.DataServices.Database {
    public class BaseOfflineDataService {
        protected LightDbAdapter Connection { get; } 

        protected BaseOfflineDataService(string filePath) {
            Connection = new LightDbAdapter(filePath);
        }
        public Task<RequestResult> AddObject<T>(T obj, CancellationToken cancellationToken) where T: new(){
	        return MakeRequest(Connection.AddObject(obj, cancellationToken));
        }

		public Task<RequestResult> RemoveObjects<T>(Expression<Func<T,bool>> predicate,CancellationToken token) where T: BaseObject, new()
		{
			return MakeRequest(Connection.RemoveObjects(predicate, token));
		}

	    public Task<RequestResult> UpdateObject<T>(T obj, CancellationToken cancellationToken) where T: new() {
		    return MakeRequest(Connection.UpdateObject(obj, cancellationToken));
	    }

	    public Task<RequestResult> UpdateObjects<T>(IList<T> list, CancellationToken cancellationToken)  where T: new(){
		    return MakeRequest(Connection.UpdateObjects(list, cancellationToken));
	    }

        public Task<RequestResult<List<T>>> GetObjects<T>(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken) where T : BaseObject, new() {
	        return MakeRequest(Connection.GetObjects(predicate, cancellationToken));
        }

	    public Task<RequestResult<List<T>>> GetAllObjects<T>(CancellationToken cancellationToken) where T : BaseObject, new () {
		    return MakeRequest(Connection.GetAll<T>(cancellationToken));
	    }
		public Task<RequestResult<T>> GetObject<T>(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken) where T : BaseObject, new () {
	        return MakeRequest(Connection.GetObject(predicate, cancellationToken));
        }

        public Task<RequestResult> DropCollection<T>(CancellationToken cancellationToken) where T : BaseObject, new() {
	        return MakeRequest(Connection.DropTable<T>(cancellationToken));
        }

	    async Task<RequestResult> MakeRequest(Task loadingTask, [CallerMemberName] string caller = null) {
		    try {
			    await loadingTask.ConfigureAwait(false);
			    return new RequestResult(RequestStatus.Ok);
		    }
		    catch (Exception e) {
			    return new RequestResult(RequestStatus.DatabaseError, e.Message);
		    }
	    }

	    async Task<RequestResult<T>> MakeRequest<T>(Task<T> loadingTask, [CallerMemberName] string caller = null) where T : BaseObject {
		    try {
			    var res = await loadingTask.ConfigureAwait(false);
			    return new RequestResult<T>(res, RequestStatus.Ok);
		    }
		    catch (Exception e) {
			    return new RequestResult<T>(default(T), RequestStatus.DatabaseError, e.Message);
		    }
	    }

	    async Task<RequestResult<List<T>>> MakeRequest<T>(Task<List<T>> loadingTask, [CallerMemberName] string caller = null) {
		    try {
			    var res = await loadingTask.ConfigureAwait(false);
			    return new RequestResult<List<T>>(res, RequestStatus.Ok);
		    }
		    catch (Exception e) {
			    return new RequestResult<List<T>>(null, RequestStatus.DatabaseError, e.Message);
		    }
	    }
    }
}
