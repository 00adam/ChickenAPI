using System;
using ChickenAPI.Core.Network;
using ChickenAPI.Game.Network;

namespace ChickenAPI.Packets
{
    public interface IPacketHandler
    {
        void Register(CharacterScreenPacketHandler method);
        void Register(GamePacketHandler method);

        void UnregisterCharacterScreenHandler(Type packetType);
        void UnregisterCharacterScreenHandler(string header);

        void UnregisterGameHandler(Type packetType);
        void UnregisterGameHandler(string header);

        CharacterScreenPacketHandler GetCharacterScreenPacketHandler(string header);
        GamePacketHandler GetGamePacketHandler(string header);

        /// <summary>
        ///     Handle the CharacterScreen packet
        /// </summary>
        /// <param name="handlingInfo"></param>
        void Handle((IPacket, ISession) handlingInfo);

        /// <summary>
        ///     Handle the Game packet
        /// </summary>
        /// <param name="handlingInfo"></param>
        void Handle((IPacket, IGameSession) handlingInfo);
    }
}