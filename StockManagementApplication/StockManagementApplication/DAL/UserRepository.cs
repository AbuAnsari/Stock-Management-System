using StockManagementApplication.Models;
using System;

namespace StockManagementApplication.DAL
{
    public class UserRepository
    {
        private string _userName;
        private string _password;
        private readonly string _connectionString = GenericRepository.ConnectionString();
        readonly GenericRepository _genericRepository = new GenericRepository();
        public bool Save(UserInfo user)
        {
            try
            {
                var query = "INSERT INTO Users VALUES('" + user.Name + "','" + user.Password + "','" + user.CreateBy + "','" + user.CrateDate + "')";
                var rowAffected = _genericRepository.ExecuteNonQuery(query, _connectionString);
                return rowAffected > 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool IsUserNameExist(UserInfo user)
        {
            try
            {
                var query = "SELECT * FROM Users WHERE Name='" + user.Name + "'";
                var reader = _genericRepository.ExecuteReader(query, _connectionString);
                return reader.HasRows;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Login(string userName, string password)
        {
            try
            {
                var query = "SELECT * FROM Users WHERE Name='" + userName + "' AND Password='" + password + "'";
                var reader = _genericRepository.ExecuteReader(query, _connectionString);
                if (reader.HasRows)
                {
                    reader.Read();
                    this._userName = reader["Name"].ToString();
                    this._password = reader["Password"].ToString();
                }

                if (this._userName == userName && this._password == password)
                    return true;

                throw new ApplicationException("Your User Name and Password is not correct.");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
