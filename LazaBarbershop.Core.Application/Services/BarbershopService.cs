using AutoMapper;
using LazaBarbershop.Core.Application.Dtos.Barbershops;
using LazaBarbershop.Core.Application.Interfaces.Repositories;
using LazaBarbershop.Core.Application.Interfaces.Services;
using LazaBarbershop.Core.Domain.Entities;

namespace LazaBarbershop.Core.Application.Services;

public class BarbershopService : GenericService<Barbershop, BarbershopDto, SaveBarbershopDto>, IBarbershopService
{
    private readonly IMapper _mapper;
    private readonly IBarbershopRepository _barbershopRepository;
    
    public BarbershopService(IMapper mapper, IGenericRepository<Barbershop> genericRepository, IBarbershopRepository barbershopRepository) : base(mapper, genericRepository)
    {
        _mapper = mapper;
        _barbershopRepository = barbershopRepository;
    }

    public async Task<BarbershopDto?> GetAsync(int id)
    {
        Barbershop? barbershop = await _barbershopRepository.GetAsync(id);

        if (barbershop == null) return null;

        BarbershopDto barbershopDto = _mapper.Map<BarbershopDto>(barbershop);
        return barbershopDto;
    }

    public async Task<List<BarbershopDto>> GetAsync()
    {
        List<Barbershop> barbershops = await _barbershopRepository.GetAsync();
        List<BarbershopDto> barbershopDtos = _mapper.Map<List<BarbershopDto>>(barbershops);

        return barbershopDtos;
    }
}