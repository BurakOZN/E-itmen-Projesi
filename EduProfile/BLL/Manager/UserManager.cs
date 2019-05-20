using BLL.Repository;
using Entity.DataModel;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Manager
{
    public interface IUserManager {
        Task<StateUserM> AddUser(User user);
        User Find(Expression<Func<User, bool>> where);
    }
    public class UserManager:IUserManager
    {
        private IRepository<User> _repository;
        public UserManager(IRepository<User> userRep)
        {
            _repository = userRep;
        }
        public async Task<StateUserM> AddUser(User user)
        {
            User _user = Find(x => x.Email == user.Email);
            return await Task.Run(() =>
            {
                if (_user == null)
                {
                    _repository.Add(user);
                    return StateUserM.success;
                }
                else { return StateUserM.error; }
            });
        }

        public User Find(Expression<Func<User, bool>> where)
        {
            var filter = Builders<User>.Filter.Eq(a => a.Email, "");
            var res = _repository.Get(where);//bir email ile birden fazla bulursa hataya düşülecek
            res.Wait();
            if (res.Result.Count == 0)
                return null;
            else
                return res.Result[0];
        }

    }
    public enum StateUserM
    {
        success,
        error,
        connectionerror
    }
}
