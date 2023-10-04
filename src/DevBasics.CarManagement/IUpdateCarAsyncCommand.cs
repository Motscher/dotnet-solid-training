using DevBasics.CarManagement.Dependencies;
using System.Threading.Tasks;

namespace DevBasics.CarManagement
{
    public interface IUpdateCarAsyncCommand
    {
        Task<bool> UpdateCarAsync(CarRegistrationDto dbCar);
    }
}
