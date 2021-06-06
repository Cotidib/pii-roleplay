using System;
using System.Collections.Generic;


namespace RoleplayGame
{
     public interface IAttackItem : INormalItem
     {
        public int Damage{get; }
     }
}