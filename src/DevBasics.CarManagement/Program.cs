using AutoMapper;
using DevBasics.CarManagement.Dependencies;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevBasics.CarManagement
{
    internal sealed class Program
    {
        internal static async Task Main(string[] args)
        {
            var serviceProvider = RegisterServices();
            var carManagementService = serviceProvider.GetRequiredService<ICarManagementService>();
            await carManagementService.RegisterCarsAsync(
                new RegisterCarsModel
                {
                    CompanyId = "Company",
                    CustomerId = "Customer",
                    VendorId = "Vendor",
                    Cars = new List<CarRegistrationModel>
                    {
                        new CarRegistrationModel
                        {
                            CompanyId = "Company",
                            CustomerId = "Customer",
                            VehicleIdentificationNumber = Guid.NewGuid().ToString(),
                            DeliveryDate = DateTime.Now.AddDays(14).Date,
                            ErpDeliveryNumber = Guid.NewGuid().ToString()
                        }
                    }
                },
                false,
                new Claims()
            );
        }

        internal static ServiceProvider RegisterServices()
        {
            var services = new ServiceCollection();
            services.AddTransient<CarRegistrationModel>();
            services.AddTransient<HttpHeaderSettings>();
            services.AddAutoMapper(typeof(CarRegistrationModel));
            services.AddTransient<IMapper>(provider =>
            {
                var model = provider.GetRequiredService<CarRegistrationModel>();
                var configuration = new MapperConfiguration(conf => model.CreateMappings(conf));
                return configuration.CreateMapper();
            });
            services.AddTransient<IBulkRegistrationService, BulkRegistrationServiceMock>();
            services.AddTransient<ICarPoolNumbeGenerator, ToyotaCarPoolNumberGenerator>();
            services.AddTransient<ICarPoolNumbeGenerator, FordCarPoolNumberGenerator>();
            services.AddTransient<ILeasingRegistrationRepository, LeasingRegistrationRepository>();
            services.AddTransient<ICarRegistrationRepository>(provider =>
            {
                var leasingRegistrationRepository = provider.GetRequiredService<ILeasingRegistrationRepository>();
                var bulkRegistrationServiceMock = provider.GetRequiredService<IBulkRegistrationService>();
                var mapper = provider.GetRequiredService<IMapper>();
                return new CarRegistrationRepository(leasingRegistrationRepository, bulkRegistrationServiceMock, mapper);
            });
            services.AddTransient<IKowoLeasingApiClient, KowoLeasingApiClientMock>();
            services.AddTransient<ITransactionStateService, TransactionStateServiceMock>();
            services.AddTransient<IRegistrationDetailService, RegistrationDetailServiceMock>();
            services.AddTransient<ICarManagementService, CarManagementService>();

            var serviceProvider = services.BuildServiceProvider();
            return serviceProvider;
        }
    }
}
