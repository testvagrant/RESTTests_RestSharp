﻿using System.Collections.Generic;

namespace RESTTests_RestSharp.Contract
{
    public class ResponseContainer
    {
        public string apiVersion { get; set; }
        public Data data { get; set; }
    }

    public class Thumbnail
    {
        public string sqDefault { get; set; }
        public string hqDefault { get; set; }
    }

    public class Player
    {
        public string @default { get; set; }
        public string mobile { get; set; }
    }

    public class Content
    {
        public string __invalid_name__5 { get; set; }
        public string __invalid_name__1 { get; set; }
        public string __invalid_name__6 { get; set; }
    }

    public class AccessControl
    {
        public string comment { get; set; }
        public string commentVote { get; set; }
        public string videoRespond { get; set; }
        public string rate { get; set; }
        public string embed { get; set; }
        public string list { get; set; }
        public string autoPlay { get; set; }
        public string syndicate { get; set; }
    }

    public class Status
    {
        public string value { get; set; }
        public string reason { get; set; }
    }

    public class Restriction
    {
        public string type { get; set; }
        public string relationship { get; set; }
        public string countries { get; set; }
    }

    public class GeoCoordinates
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
    }

    public class Item
    {
        public string id { get; set; }
        public string uploaded { get; set; }
        public string updated { get; set; }
        public string uploader { get; set; }
        public string category { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public Thumbnail thumbnail { get; set; }
        public Player player { get; set; }
        public Content content { get; set; }
        public int duration { get; set; }
        public string aspectRatio { get; set; }
        public double rating { get; set; }
        public string likeCount { get; set; }
        public int ratingCount { get; set; }
        public int viewCount { get; set; }
        public int favoriteCount { get; set; }
        public int commentCount { get; set; }
        public AccessControl accessControl { get; set; }
        public Status status { get; set; }
        public List<Restriction> restrictions { get; set; }
        public string recorded { get; set; }
        public GeoCoordinates geoCoordinates { get; set; }
    }

    public class Data
    {
        public string updated { get; set; }
        public int totalItems { get; set; }
        public int startIndex { get; set; }
        public int itemsPerPage { get; set; }
        public List<Item> items { get; set; }
    }

}
