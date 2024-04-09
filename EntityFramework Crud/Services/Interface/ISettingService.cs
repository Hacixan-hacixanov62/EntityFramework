using EntityFramework_Crud.Models;

namespace EntityFramework_Crud.Services.Interface
{
    internal interface ISettingService
    {
      Task<List<Setting>> GetAllasync();
        Task<Setting> GetByIdAsync(int id);
        Task<Setting> CreateAsync(Setting setting);
        Task<Setting> UpdateAsync(Setting setting);
        Task<Setting> DeleteAsync(int? id);
    }
}
