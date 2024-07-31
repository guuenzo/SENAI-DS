using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MinimalAPIMongoDB.Domains
{
    public class Order
    {
        [BsonId]
        [BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("date")]
        public DateOnly? Date { get; set; }

        [BsonElement("status")]
        public string? Status { get; set; }

        [BsonElement("productId")]
        public List<string>? ProductId { get; set; }

        public List<Product>? Products { get; set; }

        [BsonElement("clientId")]
        public string? ClientId {  get; set; }
        
        public Client? Client { get; set; }
    }
}
