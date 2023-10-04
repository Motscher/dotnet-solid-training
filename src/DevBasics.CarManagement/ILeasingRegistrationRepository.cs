using DevBasics.CarManagement.Dependencies;
using System.Threading.Tasks;

namespace DevBasics.CarManagement
{
    /// <summary>
    /// Wird in Dependencies verwendet, deshalb keine weitere Änderung möglich
    /// </summary>
    public interface ILeasingRegistrationRepository : IGetAppSettingAsyncCommand, IUpdateCarAsyncCommand, IInsertHistoryAsyncCommand
    {
    }
}
