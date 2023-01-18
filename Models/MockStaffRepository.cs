namespace StaffManagement.Models
{
    public class MockStaffRepository : IStaffRepository
    {
        private List<Staff> _staffs = null;

        public MockStaffRepository()
        {
            _staffs = new List<Staff>()
            {
                new Staff{ Id = 1, FirstName = "Said", LastName = "Kamol", Email = "said@staff.uz", Department = "Admin" },
                new Staff{ Id = 2, FirstName = "Abdu", LastName = "Azim", Email = "abduazim@staff.uz", Department = "Developer" },
                new Staff{ Id = 3, FirstName = "Sher", LastName = "Ali", Email = "sherali@staff.uz", Department = "Designer" },
            };
        }
        public Staff Get(int id)
        {
            return _staffs.FirstOrDefault(staff => staff.Id.Equals(id));
        }

        public IEnumerable<Staff> GetAll()
        {
            return _staffs;
        }
    }
}
