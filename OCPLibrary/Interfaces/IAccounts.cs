using OCPLibrary.Models;

namespace OCPLibrary.Interfaces
{
    public interface IAccounts
    {
        EmployeeModel Create(IApplicantModel person);
    }
}