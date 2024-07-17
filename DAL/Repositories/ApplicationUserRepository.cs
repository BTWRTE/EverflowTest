using AutoMapper;
using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class ApplicationUserRepository : IApplicationUserRepository
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public ApplicationUserRepository(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<ApplicationUserModel> Get(Guid id)
        {
            var applicationUser = await context.ApplicationUser
                .Include(au => au.Address)
                .SingleOrDefaultAsync(au => au.Id == id);

            return mapper
                .Map<ApplicationUserModel>(applicationUser);
        }

        public async Task<ApplicationUserModel> Update(ApplicationUserModel model)
        {
            var applicationUser = await context.ApplicationUser
                .Include(au => au.Address)
                .SingleOrDefaultAsync(au => au.Id == model.Id);

            if (applicationUser != null)
            {
                applicationUser.FirstName = model.FirstName;
                applicationUser.LastName = model.LastName;
                applicationUser.AddressId = model.AddressId;
                applicationUser.Email = model.Email;
                applicationUser.EmailConfirmed = model.EmailConfirmed;
                applicationUser.PhoneNumber = model.PhoneNumber;
                applicationUser.PhoneNumberConfirmed = model.PhoneNumberConfirmed;

                if (applicationUser.Address != null && model.Address != null)
                {
                    applicationUser.Address.StreetLine1 = model.Address.StreetLine1;
                    applicationUser.Address.StreetLine2 = model.Address.StreetLine2;
                    applicationUser.Address.StreetLine3 = model.Address.StreetLine3;
                    applicationUser.Address.City = model.Address.City;
                    applicationUser.Address.County = model.Address.County;
                    applicationUser.Address.PostCode = model.Address.PostCode;
                }

                await context
                    .SaveChangesAsync();
            }

            return mapper
                .Map<ApplicationUserModel>(applicationUser);
        }
    }
}