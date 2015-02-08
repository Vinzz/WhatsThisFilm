﻿using System.Runtime.Serialization;

namespace AlloCine
{
    [DataContract]
    public class Language
    {
        [DataMember(Name = "code")]
        public int Code { get; set; }

        [DataMember(Name = "$")]
        public string Value { get; set; }
    }
}
