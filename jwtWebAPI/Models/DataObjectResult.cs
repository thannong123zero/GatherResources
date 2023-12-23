﻿namespace jwtWebAPI.Models
{
    public class DataObjectResult
    {
        public bool Ok { get; set; }
        public string Message { get; set; }
        public object Content { get; set; }
        public DataObjectResult()
        {
            Ok = false;
        }
    }
}
