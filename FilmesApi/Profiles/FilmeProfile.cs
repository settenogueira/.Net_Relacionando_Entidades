﻿using AutoMapper;
using FilmesApi.Data.Dtos;
namespace FilmesApi.Models;

public class FilmeProfile : Profile
{
    public FilmeProfile() 
    {
        CreateMap<CreateFilmeDto, Filme>();
        CreateMap<UpdateFilmeDto, Filme>();
        CreateMap<Filme, UpdateFilmeDto>();
        CreateMap<Filme, ReadFilmeDto>().ForMember(filmeDto => filmeDto.Sessoes,
                    opt => opt.MapFrom(filme => filme.Sessoes)); 
    }
    
}
