using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using LiteDB;
using MyWasteGame.DAL.DataObjects;

namespace MyWasteGame.DAL.DataServices.Database
{
	public class LightDbAdapter {
		readonly LiteDatabase _liteDatabase;

		public LightDbAdapter(string filePath) {
			_liteDatabase = new LiteDatabase(filePath);
		}

		public Task AddObject<T>(T obj, CancellationToken cancellationToken)  where T : new() {
			return Task.Run(() => {
				var collName = typeof(T).Name;
				var col = _liteDatabase.GetCollection<T>(collName);
				col.Insert(obj);
			}, cancellationToken);
		}

		public Task AddObjects<T>(IList<T> list, CancellationToken cancellationToken)  where T : new() {
			return Task.Run(() => {
				var collName = typeof(T).Name;
				var col = _liteDatabase.GetCollection<T>(collName);
				col.Insert(list);
			}, cancellationToken);
		}

		public Task UpdateObject<T>(T obj, CancellationToken cancellationToken)  where T : new() {
			return Task.Run(() => {
				var collName = typeof(T).Name;
				var col = _liteDatabase.GetCollection<T>(collName);
				col.Update(obj);
			}, cancellationToken);
		}

		public Task UpdateObjects<T>(IList<T> list, CancellationToken cancellationToken)  where T : new() {
			return Task.Run(() => {
				var collName = typeof(T).Name;
				var col = _liteDatabase.GetCollection<T>(collName);
				col.Update(list);
			}, cancellationToken);
		}

		public Task<T> GetObject<T>(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken) where T : BaseObject, new() {
			return Task.Run(() => {
				var collName = typeof(T).Name;
				var col = _liteDatabase.GetCollection<T>(collName);
				return col.FindOne(predicate);
			}, cancellationToken);
		}

		public Task<List<T>> GetObjects<T>(Expression<Func<T, bool>> predicate,
			CancellationToken cancellationToken = new CancellationToken()) where T : BaseObject, new() {
			return Task.Run(() => {
				var collName = typeof(T).Name;
				var col = _liteDatabase.GetCollection<T>(collName);
				return col.Find(predicate).ToList();
			}, cancellationToken);
		}

		public Task<List<T>> GetAll<T>(CancellationToken cancellationToken) where T : BaseObject, new() {
			return Task.Run(() => {
				var collName = typeof(T).Name;
				var col = _liteDatabase.GetCollection<T>(collName);
				return col.FindAll().ToList();
			}, cancellationToken);
		}

		public Task RemoveObject<T>(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken) where T : BaseObject, new() {

			return Task.Run(() => {
				var collName = typeof(T).Name;
				var col = _liteDatabase.GetCollection<T>(collName);
				return col.Delete(predicate);
			}, cancellationToken);

		}

		public Task RemoveObjects<T>(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken) where T : BaseObject, new()  {
			return Task.Run(() => {
				var collName = typeof(T).Name;
				var col = _liteDatabase.GetCollection<T>(collName);
				return col.Delete(predicate);
			}, cancellationToken);

		}

		public Task DropTable<T>(CancellationToken cancellationToken) where T : BaseObject, new()  {
			return Task.Run(() => {
				var collName = typeof(T).Name;
				_liteDatabase.DropCollection(collName);
			}, cancellationToken);
		}
	}
}