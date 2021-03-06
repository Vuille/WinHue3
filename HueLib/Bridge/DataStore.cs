﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using HueLib2;

namespace HueLib
{
    [DataContract,Serializable]
    public class DataStore
    {
        [DataMember(EmitDefaultValue = false,IsRequired =false)]
        public Dictionary<string,Light> lights { get; set; }

        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public Dictionary<string, Group> groups { get; set; }

        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public Dictionary<string, Schedule> schedules { get; set; }

        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public Dictionary<string, Scene> scenes { get; set; }

        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public Dictionary<string, Sensor> sensors { get; set; }

        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public Dictionary<string, Rule> rules { get; set; }

        public override string ToString()
        {
            return Serializer.SerializeToJson(this);
        }
    }
}
