﻿/* this code is auto-generated. */

using System.Collections.Generic;
using Server.Core.Component;
using Server.Core.Messaging;

namespace Server.Message.Game
{
    public class DespawnMsg : IMessage
    {
        public const int TypeId = 1004;
        
        [Attribute(EntityId = true)]
        public int Id { get; set; }
        
    }
    
}
