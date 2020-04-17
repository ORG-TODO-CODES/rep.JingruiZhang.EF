﻿using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class BaseAuthorizedata
    {
        public string AuthorizeDataId { get; set; }
        public int? AuthorizeType { get; set; }
        public int? Category { get; set; }
        public string ObjectId { get; set; }
        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public string ResourceId { get; set; }
        public int? IsRead { get; set; }
        public string AuthorizeConstraint { get; set; }
        public int? SortCode { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }
    }
}
