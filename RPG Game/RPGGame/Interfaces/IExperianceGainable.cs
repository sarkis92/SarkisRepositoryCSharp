
namespace RPGGame.Interfaces
{
    public interface IExperianceGainable
    {
        int Experiance { get; }

        void LevelUp();
    }
}
