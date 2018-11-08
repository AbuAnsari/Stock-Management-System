
using System;

namespace StockManagementApplication.Models
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string CreateBy { get; set; }
        public DateTime CrateDate { get; set; }
    }
}
