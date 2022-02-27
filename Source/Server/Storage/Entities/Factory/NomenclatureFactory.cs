using Shared.Dto.Enities;
using Storage.Entities.Implementation;

namespace Storage.Entities.Factory;

internal class NomenclatureFactory
{
    public static NomenclatureDto CreateDto(Nomenclature nomenclature) =>
        new()
        {
            ParentId = nomenclature.ParentId,
            ChildId = nomenclature.ChildId,
            Amount = nomenclature.Amount
        };

    public static Nomenclature Create(NomenclatureDto nomenclatureDto) =>
        new(nomenclatureDto.ParentId, nomenclatureDto.ChildId, nomenclatureDto.Amount);
}