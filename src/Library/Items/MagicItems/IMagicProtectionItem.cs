using System;
using System.Collections.Generic;


namespace RoleplayGame
{
     public interface IMagicProtectionItem : IMagicItem
     {
        public int Protection{get; }
     }
}