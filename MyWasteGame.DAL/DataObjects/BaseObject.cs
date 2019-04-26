using LiteDB;

namespace MyWasteGame.DAL.DataObjects {
	public class BaseObject {
		public ObjectId Id { get; set; } = ObjectId.NewObjectId();
	}
}
