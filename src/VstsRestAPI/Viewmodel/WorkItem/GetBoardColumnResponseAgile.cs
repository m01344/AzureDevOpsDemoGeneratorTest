﻿using Newtonsoft.Json;

namespace VstsRestAPI.Viewmodel.WorkItem
{
    public class GetBoardColumnResponseAgile
    {
        public class ColumnResponse : BaseViewModel
        {
            public int count { get; set; }
            public Value[] columns { get; set; }
            public Fields fields { get; set; }
        }

        public class Value
        {
            public string id { get; set; }
            public string name { get; set; }
            public string itemLimit { get; set; }
            public string isSplit { get; set; }
            public string description { get; set; }
            public string columnType { get; set; }
            public StateMappings stateMappings { get; set; }
        }

        public class Fields
        {
            public Field columnField { get; set; }
            public Field rowField { get; set; }
            public Field doneField { get; set; }
        }

        public class Field
        {
            public string referenceName { get; set; }
            public string url { get; set; }
        }

        public class StateMappings
        {
            [JsonProperty(PropertyName = "User Story")]
            public string UserStory { get; set; }
            [JsonProperty(PropertyName = "Bug")]
            public string bug { get; set; }
            [JsonProperty(PropertyName = "Epic")]
            public string epic { get; set; }
            [JsonProperty(PropertyName = "Feature")]
            public string feature { get; set; }
        }
    }
}

