using System;

namespace crud.Dtos
{
    public record UpdateItemDto{
        public string Name {get; init;}
        public decimal Price {get; init;}
    }
}
