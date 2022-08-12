using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Link
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }



    }
}
