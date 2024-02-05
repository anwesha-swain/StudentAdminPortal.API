using StudentAdminPortal.API.DataModels;

namespace StudentAdminPortal.API.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetStudentsAsync();
        Task<Student> GetStudentByIdAsync(Guid studentId);
        Task<List<Gender>> GetGendersAsync();
        Task<bool> Exists(Guid studentId);
        Task<Student> UpdateStudentAsync(Guid studentId, Student request);
        Task<Student> DeleteStudentAsync(Guid studentId);
        Task<Student> AddStudentAsync(Student request);
        Task<bool> UpdateProfileImage(Guid studentId, string profileImageUrl);
    }
}
