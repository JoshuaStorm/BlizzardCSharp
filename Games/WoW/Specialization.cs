﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzardCSharp.Games.WoW
{
    public class Specialization
    {
        public string Name { get; internal set; }

        public string Role { get; internal set; }

        public string BackgroundImage { get; internal set; }

        public string Icon { get; internal set; }

        public string Description { get; internal set; }

        public int Order { get; internal set; }

        public Specialization(JObject SpecObject)
        {
            if (SpecObject["name"] != null)
                Name = SpecObject["name"].ToString();
            if (SpecObject["role"] != null)
                Role = SpecObject["role"].ToString();
            if (SpecObject["backgroundImage"] != null)
                BackgroundImage = SpecObject["backgroundImage"].ToString();
            if (SpecObject["icon"] != null)
                Icon = SpecObject["icon"].ToString();
            if (SpecObject["description"] != null)
                Description = SpecObject["description"].ToString();
            if (SpecObject["order"] != null)
                Order = int.Parse(SpecObject["order"].ToString());
        }
    }
}
