﻿﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Service.AfsServiceConfFacade
{
﻿    [Serializable]
    public class PublicResultObjectMajorCategory : JdObject
    {
        [JsonProperty("resultCode")]
        public Nullable<Int32> ResultCode
        {
            get;
            set;
        }

        [JsonProperty("majorCategoryList")]
        public List<AfsCategoryOutMajor> MajorCategoryList
        {
            get;
            set;
        }

    }

}
