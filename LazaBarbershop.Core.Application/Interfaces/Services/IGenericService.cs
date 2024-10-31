namespace LazaBarbershop.Core.Application.Interfaces.Services;

public interface IGenericService<TEntityDto, in TSaveEntityDto>
{
    Task<TEntityDto> AddAsync(TSaveEntityDto saveEntityDto);
    Task UpdateAsync(int id, TEntityDto entityDto);
    Task DeleteAsync(int id);
}