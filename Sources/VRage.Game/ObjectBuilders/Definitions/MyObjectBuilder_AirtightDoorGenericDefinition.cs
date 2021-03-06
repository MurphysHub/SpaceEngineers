﻿using ProtoBuf;
using VRage.ObjectBuilders;

namespace Sandbox.Common.ObjectBuilders.Definitions
{
    [ProtoContract]
    [MyObjectBuilderDefinition]
    public class MyObjectBuilder_AirtightDoorGenericDefinition : MyObjectBuilder_CubeBlockDefinition
    {
        [ProtoMember]
        public float PowerConsumptionIdle;
        [ProtoMember]
        public float PowerConsumptionMoving;
        [ProtoMember]
        public float OpeningSpeed;
        [ProtoMember]
        public string Sound;
        [ProtoMember]
        public float SubpartMovementDistance=2.5f;
    }
}
