namespace Morskoy_boy.UI
{
    using System.Data.Entity;

    public class UserInfoModel : DbContext
    {
        public DbSet<UserInfo> UserInfos { get; set; }
    }
    public class UserInfo
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public int Loging { get; set; }
        public string Password { get; set; }
        public string Translate { get; set; }

    }
}
