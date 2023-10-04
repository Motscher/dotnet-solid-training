using DevBasics.CarManagement.Dependencies;
using System.Threading.Tasks;

namespace DevBasics.CarManagement
{
    public interface ICarManagementService
    {
        bool HasMissingData(CarRegistrationModel car);
        Task<RequestContext> InitializeRequestContextAsync();
        Task<ServiceResult> RegisterCarsAsync(RegisterCarsModel registerCarsModel, bool isForcedRegistration, Claims claims, string identity = "Unknown");
    }
}