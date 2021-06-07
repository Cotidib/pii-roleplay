using System;
using System.Collections;
using System.Collections.Generic;

namespace RoleplayGame
{

    public abstract class Enemy : Character
    {
        public int vP{get; protected set;}

        public abstract void Attack(Hero character);
    }

}