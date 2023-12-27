using jwtWebAPI.Models;
using Microsoft.AspNetCore.Identity;

namespace jwtWebAPI.Helpers
{
    public class MasterModelHelper
    {
        private List<UserModel> users;
        private List<RoleModel> roles;
        private List<RefreshTokenModel> refreshTokens;

        public MasterModelHelper()
        {
            users = new List<UserModel>();
            roles = new List<RoleModel>();
            refreshTokens = new List<RefreshTokenModel>();
            #region adduser
            users.Add(new UserModel()
            {
                ID = 1,
                RoleID = 1,
                FullName = "Sam",
                Sex = 0,
                BrithDay = DateTime.Now.AddYears(-23),
                UserName = "sam@gmail.com",
                Password = "123"
            });
            users.Add(new UserModel()
            {
                ID = 2,
                RoleID = 2,
                FullName = "Erisk",
                Sex = 0,
                BrithDay = DateTime.Now.AddYears(-23),
                UserName = "erik@gmail.com",
                Password = "123"

            });
            users.Add(new UserModel()
            {
                ID = 3,
                RoleID = 3,
                FullName = "Tom",
                Sex = 0,
                BrithDay = DateTime.Now.AddYears(-23),
                UserName = "tom@gmail.com",
                Password = "123"
            });
            users.Add(new UserModel()
            {
                ID = 4,
                RoleID = 3,
                FullName = "Jack",
                Sex = 0,
                BrithDay = DateTime.Now.AddYears(-23),
                UserName = "jack@gmail.com",
                Password = "123"

            });
            users.Add(new UserModel()
            {
                ID = 5,
                RoleID = 3,
                FullName = "Oda",
                Sex = 0,
                BrithDay = DateTime.Now.AddYears(-23),
                UserName = "oda@gmail.com",
                Password = "123"
            });
            #endregion
            roles.Add(new RoleModel()
            {
                ID = 1,
                RoleName = "Admin"
            });
            roles.Add(new RoleModel()
            {
                ID = 2,
                RoleName = "Manager"
            });
            roles.Add(new RoleModel()
            {
                ID = 3,
                RoleName = "Staff"
            });
        }
        public List<UserModel> GetUsers()
        {
            return users;
        }
        public List<RoleModel> GetRoles()
        {
            return roles;
        }
        public bool UpdateProfile(UserModel model)
        {
            if (model == null)
            {
                return false;
            }
            UserModel user = users.Where(s => s.ID == model.ID).FirstOrDefault();
            user.FullName = model.FullName;
            user.RoleID = model.RoleID;
            user.Sex = model.Sex;
            user.BrithDay = model.BrithDay;
            return true;
        }
        public UserModel GetUserByID(int id)
        {
            UserModel user = users.Where(s => s.ID == id).FirstOrDefault();
            if(user != null)
            {
                return user;
            }
            return null;
        }
        public RoleModel GetRoleByID(int id)
        {
            RoleModel role = roles.Where(s => s.ID == id).FirstOrDefault();
            if (role != null)
            {
                return role;
            }
            return null;
        }
        public UserModel Login(LoginModel model)
        {
            if(model == null)
            {
                return null;
            }
            UserModel user = users.Where(s => s.UserName == model.UserName && s.Password == model.PassWord).FirstOrDefault();
            if(user != null)
            {
                return user;
            }
            return null;
        }
        public bool AddRefreshToken(RefreshTokenModel model)
        {
            if(model == null)
            {
                return false;
            }

            refreshTokens.Add(model);
            return true;
        }
        public bool CheckIsValidToken(string keyRefresh,string token)
        {
            // neu key = null thi false
            if (string.IsNullOrEmpty(keyRefresh) || string.IsNullOrEmpty(token))
            {
                return false;
            }
            // lay ra model co keyRefresh va token
            RefreshTokenModel refreshToken = refreshTokens.Where(s => s.KeyRefresh == keyRefresh && s.Token == token).FirstOrDefault();
            // neu khong tim thay key thi false
            if(refreshToken == null)
            {
                return false;
            }
            //DateTime date = refreshToken.CreatedOn;
            // Chi cho phep key hoat dong trong 24h
            if (refreshToken.CreatedOn.AddDays(1) > DateTime.Now && !refreshToken.IsUsed)
            {
                refreshToken.IsUsed = true;
                return true;
            }

            return false;
        }
    }
}
