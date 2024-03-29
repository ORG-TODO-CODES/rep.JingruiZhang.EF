﻿using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class BaseModule
    {
        public string ModuleId { get; set; }
        public string ParentId { get; set; }
        public string EnCode { get; set; }
        public string FullName { get; set; }
        public string Icon { get; set; }
        public string UrlAddress { get; set; }
        public string Target { get; set; }
        public int? IsMenu { get; set; }
        public int? AllowExpand { get; set; }
        public int? IsPublic { get; set; }
        public int? AllowEdit { get; set; }
        public int? AllowDelete { get; set; }
        public int? SortCode { get; set; }
        public int? DeleteMark { get; set; }
        public int? EnabledMark { get; set; }
        public string Description { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyUserId { get; set; }
        public string ModifyUserName { get; set; }
        public int? Category { get; set; }
    }
}
