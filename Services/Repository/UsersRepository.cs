using MetrosoftForm.Data;
using MetrosoftForm.Models;
using MetrosoftForm.Models.Dto;
using MetrosoftForm.Services.IRepository;

namespace MetrosoftForm.Services.Repository
{
    public class UsersRepository : IUsersRepository<Employee>
    {
        private readonly ApplicationDbContext _context;
        private readonly IBaseRepository<Employee> _baseRepository;
        public UsersRepository(ApplicationDbContext context, IBaseRepository<Employee> baseRepository) 
        {
            _context= context;
            _baseRepository= baseRepository;
        }

        public async Task<Employee> Create(EmployeesDto details)
        {
            try
            {
                Employee usersdetails = new Employee();
                usersdetails.Surname = details.Surname;
                usersdetails.Name = details.Name;
                usersdetails.OtherName = details.OtherName;
                usersdetails.Email = details.Email;
                usersdetails.HomeAddress = details.HomeAddress;
                usersdetails.ContactAddress = details.ContactAddress;
                usersdetails.TelePhone = details.TelePhone;
                usersdetails.DateOfBirth = details.DateOfBirth;
                usersdetails.Origin = details.Origin;
                usersdetails.MaritalStatus = details.MaritalStatus;
                usersdetails.Nationality = details.Nationality;
                usersdetails.NameOfSpouse = details.NameOfSpouse;
                usersdetails.SpouseProfession = details.SpouseProfession;
                usersdetails.NameOfChildren = details.NameOfChildren;
                usersdetails.NextOfKin = details.NextOfKin;
                usersdetails.NextOfKinProfession = details.NextOfKinProfession;
                usersdetails.Relationship = details.Relationship;
                usersdetails.Emergency = details.Emergency;
                usersdetails.Address = details.Address;
                usersdetails.PersonPhoneNumber = details.PersonPhoneNumber;
                usersdetails.PersonEmail = details.PersonEmail;
                usersdetails.FatherFullName = details.FatherFullName;
                usersdetails.FatherHomeTown = details.FatherHomeTown;
                usersdetails.FatherCurrentAddres = details.FatherCurrentAddres;
                usersdetails.MotherFullName = details.MotherFullName;
                usersdetails.MotherHomeTown = details.MotherHomeTown;
                usersdetails.MotherCurrentAddress = details.MotherCurrentAddress;
                usersdetails.ProfessionalQualification = details.ProfessionalQualification;
                usersdetails.Project = details.Project;
                usersdetails.Sporting = details.Sporting;
                usersdetails.Indebt = details.Indebt;
                usersdetails.IndebtAmount = details.IndebtAmount;
                usersdetails.MedicalHistory = details.MedicalHistory;
                usersdetails.crime = details.crime;
                usersdetails.CrimeDate = details.CrimeDate;
                usersdetails.NameOfLawEnforcement = details.NameOfLawEnforcement;
                usersdetails.PenaltyImpose = details.PenaltyImpose;
                usersdetails.Leisure = details.Leisure;
                usersdetails.General = details.General;
                usersdetails.Briefly = details.Briefly;
                usersdetails.Addictional = details.Addictional;
              //  usersdetails.Experience = details.Experience;
                usersdetails.Reference = details.Reference;
                usersdetails.Educations = details.Educations;
                usersdetails.DateOfResumption = details.DateOfResumption;
                usersdetails.NoticePeriod = details.NoticePeriod;
                usersdetails.RequiredSalary = details.RequiredSalary;

                if (usersdetails != null)
                {
                    var created = await _baseRepository.CreateAsync(usersdetails);
                    return created;
                }
                return usersdetails;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
