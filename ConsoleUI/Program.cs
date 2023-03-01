// See https://aka.ms/new-console-template for more information
using OCPLibrary;
using OCPLibrary.Interfaces;
using OCPLibrary.Models;

List<IApplicantModel> applicants = new List<IApplicantModel>
{
    new PersonModel(){FirstName = "Hatice", LastName= "Bulut"},
    new ExecutiveModel(){FirstName = "Hatice1", LastName= "Bulut1"},
    new ManagerModel(){FirstName = "Hatice2", LastName= "Bulut2"},
};

List<EmployeeModel> employees = new List<EmployeeModel>();

foreach (var person in applicants)
{
    employees.Add(person.AccountProcessor.Create(person));
}

foreach (var employee in employees)
{
    Console.WriteLine($"{employee.FirstName} {employee.LastName}: {employee.EmailAddress}, IsExecutive: {employee.IsExecutive}, IsManager: {employee.IsManager}");
}

Console.ReadLine();