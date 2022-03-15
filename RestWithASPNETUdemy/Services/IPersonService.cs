﻿using RestWithASPNETUdemy.Data.VO;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Services
{
    public interface IPersonService
    {
        PersonVO Create(PersonVO person);
        PersonVO FindByID(long id);
        List<PersonVO> FindByName(string firstName, string lastName);
        List<PersonVO> FindAll();
        PersonVO Update(PersonVO person);
        PersonVO Disable(long id);
        void Delete(long id);
    }
}
