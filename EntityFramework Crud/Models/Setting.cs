

namespace EntityFramework_Crud.Models
{
    internal class Setting : BaseEntity
    {
        public Setting(string v1, string v2, string v3, string v4)
        {
        }

        public string Address  { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
    }
}


