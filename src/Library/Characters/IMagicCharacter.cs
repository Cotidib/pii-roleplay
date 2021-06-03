namespace RoleplayGame
{
    public interface IMagicCharacter: ICharacter
    {
        void AddItem(IMagicalItem item);

        void RemoveItem(IMagicalItem item);
    }
}
