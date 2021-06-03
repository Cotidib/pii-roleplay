namespace RoleplayGame
{
    public class Staff: IAttackItem, IDefenseItem
    {
        public int AttackValue 
        {
            get
            {
                return 100;
            } 
        }

        public int DefenseValue
        {
            get
            {
                return 100;
            }
        }
    }
}