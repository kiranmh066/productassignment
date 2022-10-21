﻿using BookShowEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookShowDAL.Repost
{
    public class UserRepository : IUserRepository
    {
        BookShowDbContext _dbContext;//default private

        public UserRepository(BookShowDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddUser(User user)
        {
            _dbContext.tbluser.Add(user);
            _dbContext.SaveChanges();
        }

        public void DeleteUser(int userId)
        {
            var user = _dbContext.tbluser.Find(userId);
            _dbContext.tbluser.Remove(user);
            _dbContext.SaveChanges();
        }

        public User GetUserById(int userId)
        {
            return _dbContext.tbluser.Find(userId);
        }

        public IEnumerable<User> GetUsers()
        {
            return _dbContext.tbluser.ToList();
        }

        public void UpdateUser(User user)
        {
            _dbContext.Entry(user).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
        public User Login(User user)
        {
            User userInfo = null;
            var result = _dbContext.tbluser.Where(obj => obj.Email == user.Email && obj.Password == user.Password).ToList();
            if (result.Count > 0)
            {
                userInfo = result[0];
            }
            return userInfo;
        }

        public void Register(User userInfo)
        {
            _dbContext.tbluser.Add(userInfo);
            _dbContext.SaveChanges();
        }
    }
}
