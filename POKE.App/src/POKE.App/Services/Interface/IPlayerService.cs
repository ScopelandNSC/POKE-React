using POKE.App.Dtos.Player;

namespace POKE.App.Services.Interface
{
    public interface IPlayerService
    {
        BasePlayer GetPlayer(int playerId);
    }
}
