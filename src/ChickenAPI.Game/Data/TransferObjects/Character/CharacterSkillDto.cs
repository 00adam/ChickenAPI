using System;
using ChickenAPI.Core.DAL.AccessLayer.Repository;

namespace ChickenAPI.Data.TransferObjects.Character
{
    public class CharacterSkillDto : ISynchronizedDto
    {
        public Guid Id { get; set; }
        public long SkillId { get; set; }
    }
}