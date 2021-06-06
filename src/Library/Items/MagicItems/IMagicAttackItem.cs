using System;
using System.Collections.Generic;


namespace RoleplayGame
{
     public interface IMagicAttackItem : IMagicItem
     {
        public int Damage{get; }
     }
}