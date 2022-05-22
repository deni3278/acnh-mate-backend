﻿using MongoDB.Bson.Serialization.Attributes;

namespace AcnhMate.Models;

[CollectionName("fossils")]
public class Fossil : BaseDataObject
{
    [BsonElement("price")] public int Price { get; set; }

    [BsonElement("museum-phrase")] public string MuseumPhrase { get; set; }

    [BsonElement("image_uri")] public string ImageUri { get; set; }

    [BsonElement("part-of")] public string PartOf { get; set; }
}