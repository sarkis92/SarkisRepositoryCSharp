
namespace RPGGame.Interfaces
{
    using Characters;
    interface IPlayer : ICharacter, IMoveable, ICollect, IHeal
    {
        PlayerRace Race { get; }
    }
}
