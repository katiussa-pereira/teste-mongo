using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace TesteMongo
{
    public class GuestModel
    {
        [BsonId]  // _id
        public Guid Id { get; set; }
        public string Email { get; set; }

        [BsonElement("Name")]
        public string FullName { get; set; }
        public bool HasConfirmed { get; set; }
    }
}
