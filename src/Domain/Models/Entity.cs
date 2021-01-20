using System;

namespace Domain.Models
{
   public class Entity
    {
         public Entity(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; set; }

    }
}