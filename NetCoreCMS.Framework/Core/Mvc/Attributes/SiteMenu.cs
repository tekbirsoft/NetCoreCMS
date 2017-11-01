﻿/*************************************************************
 *          Project: NetCoreCMS                              *
 *              Web: http://dotnetcorecms.org                *
 *           Author: OnnoRokom Software Ltd.                 *
 *          Website: www.onnorokomsoftware.com               *
 *            Email: info@onnorokomsoftware.com              *
 *        Copyright: OnnoRokom Software Ltd.                 *
 *          License: BSD-3-Clause                            *
 *************************************************************/

using System;

namespace NetCoreCMS.Framework.Core.Mvc.Attributes
{
    public interface IMenu
    {
        string Name { get; set; }
        int Order { get; set; }
        string IconCls { get; set; }        
    }

    public interface IMenuItem
    {
        string Name { get; set; }
        string Url { get; set; }
        string QueryString { get; set; }
        int Order { get; set; }
        string IconCls { get; set; }
        string[] SubActions { get; set; }
    }

    public class SiteMenu : Attribute, IMenu
    {
        public string Name { get; set; }
        public string IconCls { get; set; }
        public int Order { get; set; }
    }

    public class SiteMenuItem : Attribute, IMenuItem
    {
        public SiteMenuItem()
        {
            SubActions = new string[] { };
        }
        public string Name { get; set; }
        public string Url { get; set; }
        public string QueryString { get; set; }
        public int Order { get; set; }
        public string IconCls { get; set; }
        public string[] SubActions { get; set; }
    }
}
