﻿using ChickenAPI.Data.AccessLayer.Repository;
using ChickenAPI.Data.TransferObjects.NpcMonster;

namespace ChickenAPI.Data.AccessLayer.NpcMonster
{
    public interface INpcMonsterService : IMappedRepository<NpcMonsterDto>
    {
    }
}