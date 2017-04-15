﻿/*
 * Author: Xonaki
 * Website: http://xonaki.com
 * Copyright (c) xonaki.com
 * License: BSD (3 Clause)
*/
using NetCoreCMS.Framework.Core.Mvc.Models;
using System;
using System.Collections.Generic;

namespace NetCoreCMS.Framework.Core.Models
{
    public class NccPage : BaseModel
    {
        public NccPage()
        {
            PageOrder = 0;
            PublishDate = DateTime.Now;
        }
        public NccPage Parent { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeyword { get; set; }
        public byte[] Content { get; set; }
        public List<NccPage> LinkedPages { get; set; }
        public bool AddToNavigationMenu { get; set; }
        public NccPageStatus PageStatus { get; set; }
        public NccPageType PageType { get; set; }
        public DateTime PublishDate { get; set; }
        public int PageOrder { get; set; }

        public enum NccPageStatus
        {
            Draft,
            Review,
            Published,
            UnPublished,
            Archived
        }

        public enum NccPageType
        {
            Public,
            Private,
            PasswordProtected
        }
    }
}
