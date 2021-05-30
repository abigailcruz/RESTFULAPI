using Application.Interfaces;
using Ardalis.Specification.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.Repository
{
    public class MyRepositoryAsync<T> : RepositoryBase<T> , IRepositoryAsync<T> where T : class
    { 

    }
}
