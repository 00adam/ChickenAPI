﻿using System.Collections.Generic;
using ChickenAPI.DAL.Interfaces.Repository;
using ChickenAPI.Dtos;

namespace ChickenAPI.DAL.Interfaces
{
    public interface ICharacterService : IMappedRepository<CharacterDto>
    {
        IEnumerable<CharacterDto> GetActiveByAccountId(ulong accountId);
    }
}