﻿﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Website.Ware;

namespace JdSdk.Request.Website.Ware
{
﻿    public class WareSearchRequst : JdRequestBase<WareSearchResponse>
    {
        public String Cid
        {
            get;
            set;
        }

        public String Q
        {
            get;
            set;
        }

        public String Page
        {
            get;
            set;
        }

        public String PageSize
        {
            get;
            set;
        }

        public String Fields
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.wares.search"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("cid" ,this.Cid);
            paramters.Add("q" ,this.Q);
            paramters.Add("page" ,this.Page);
            paramters.Add("page_size" ,this.PageSize);
            paramters.Add("fields" ,this.Fields);
        }

    }

}
