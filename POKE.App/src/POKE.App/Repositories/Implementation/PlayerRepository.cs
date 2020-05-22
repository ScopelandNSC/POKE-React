using POKE.App.Dtos.Player;
using POKE.App.Repositories.Interface;

namespace POKE.App.Repositories.Implementation
{
    public class PlayerRepository : IPlayerRepository
    {
        public BasePlayer GetPlayer(int playerId)
        {
            return new BasePlayer();
        }
    }
}
