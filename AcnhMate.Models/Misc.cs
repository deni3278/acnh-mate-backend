﻿using MongoDB.Bson.Serialization.Attributes;

namespace AcnhMate.Models;

[CollectionName("misc")]
public class Misc : BaseDataObject
{
    [BsonElement("buy-price")] public int? BuyPrice { get; set; }

    [BsonElement("sell-price")] public int? SellPrice { get; set; }

    [BsonElement("isOrderable")] public bool IsOrderable { get; set; }

    [BsonElement("music_uri")] public string MusicUri { get; set; }

    [BsonElement("image_uri")] public string ImageUri { get; set; }
}