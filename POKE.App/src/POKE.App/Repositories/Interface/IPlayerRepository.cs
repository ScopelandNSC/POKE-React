using POKE.App.Dtos.Player;

namespace POKE.App.Repositories.Interface
{
    public interface IPlayerRepository
    {
        BasePlayer GetPlayer(int playerId);
    }
}
