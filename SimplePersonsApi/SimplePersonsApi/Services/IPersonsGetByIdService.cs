﻿using SimplePersonsApi.Models;

namespace SimplePersonsApi.Services
{
    public interface IPersonsGetByIdService
    {
        Person Get(int id);
    }
}