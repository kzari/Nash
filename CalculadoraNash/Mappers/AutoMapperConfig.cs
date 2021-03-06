﻿using AutoMapper;

namespace CalculadoraNash.Mappers
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(cgc =>
            {
                cgc.AddProfile<DomainToViewModelMappingProfile>();
                cgc.AddProfile<ViewModelToDomainMappingProfile>();
            });
        }
    }
}