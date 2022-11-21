using InventoryModels.DTOs;
using System;
using System.Collections.Generic;

namespace InventoryDatabaseLayer
{
    public interface IItemsRepo
    {
        List<ItemDto> GetItems();
        List<ItemDto> GetItemsByDateRange(DateTime minDateValue, DateTime maxDateValue);
        List<GetItemsForListingDto> GetItemsForListingFromProcedure();
        List<GetItemsTotalValueDto> GetItemsTotalValues(bool isActive);
        List<FullItemDetailDto> GetItemsWithGenresAndCategories();
    }
}
