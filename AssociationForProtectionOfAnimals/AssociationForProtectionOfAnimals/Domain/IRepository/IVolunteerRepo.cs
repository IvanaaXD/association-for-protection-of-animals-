﻿using LangLang.Domain.Model;
using LangLang.Observer;

namespace LangLang.Domain.IRepository
{
    public interface IVolunteerRepo 
    {
        RegisteredUser? GetById(int id);
        List<RegisteredUser> GetAllRegisteredUsers();
        int GenerateId();
        RegisteredUser AddUser(RegisteredUser user);
        RegisteredUser? UpdateUser(RegisteredUser? user);
        RegisteredUser? RemoveUser(int id);
        void Subscribe(IObserver observer);
    }
}