﻿using System.Net;

namespace CourseWork2.Model;

public interface IUserRepository
{
    public Task<bool>      AuthenticateUserAsync(NetworkCredential credential);
    public Task            Add(UserModel                           user);
    public Task            Edit(UserModel                          user);
    public Task            Remove(int                              id);
    public Task<UserModel> GetByUsername(string username);
    IEnumerable<UserModel> GetAll();
}