using System;
using System.Collections.Generic;


namespace RoleplayGame
{
     public interface IProtectionItem : INormalItem
     {
        public int Protection{get; }
     }
}