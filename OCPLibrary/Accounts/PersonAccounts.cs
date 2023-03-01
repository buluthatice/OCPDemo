using OCPLibrary.Interfaces;
using OCPLibrary.Models;

namespace OCPLibrary.Accounts
{
    public class PersonAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();
            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{person.FirstName.Substring(0, 1)}{person.LastName}@blt.com";

            return output;
        }
    }
}