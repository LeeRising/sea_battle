using SQLite;

namespace Morskoy_boy.Models
{
    class UserAppInfo
    {
        [PrimaryKey, Unique]
        public int Id { get; set; }

        [MaxLength(30)]
        public string userId { get; set; }

        [MaxLength(30)]
        public string login { get; set; }

        [MaxLength(30)]
        public string password { get; set; }

        [MaxLength(30)]
        public string loging { get; set; }

        [MaxLength(30)]
        public string translate { get; set; }
    }
}
