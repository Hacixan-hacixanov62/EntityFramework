using EntityFramework_Crud.Data;
using EntityFramework_Crud.Helpers.Exceptions;
using EntityFramework_Crud.Models;
using EntityFramework_Crud.Services.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Crud.Services
{
    internal class SettingService : ISettingService
    {
        private readonly AppDbContext _context;

        public SettingService()
        {
            _context = new AppDbContext();
        }

        public  async Task CreateAsync(Setting setting)
        {
           await _context.Settings.AddAsync(setting);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int? id)
        {
            if(id is null) throw new ArgumentNullException(nameof(id));

            var data = _context.Settings.FirstOrDefault(m => m.Id == id);

            if (data is null) throw new NotFoundException("Data notfound");

             _context.Settings.Remove(data);

            await _context.SaveChangesAsync();


        }
        public async Task<List<Setting>> GetAllasync()
        {
            return await  _context.Settings.ToListAsync();
        }

        public async Task<Setting> GetByIdAsync(int id)
        {
           var data = _context.Settings.FirstOrDefault(m=>m.Id ==id);


            if (data is null)  throw new NotFoundException("Data notfound");

            return data;
        }

        public Task<Setting> UpdateAsync(Setting setting)
        {
            throw new NotImplementedException();
        }

        Task<Setting> ISettingService.CreateAsync(Setting setting)
        {
            throw new NotImplementedException();
        }

        Task<Setting> ISettingService.DeleteAsync(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
