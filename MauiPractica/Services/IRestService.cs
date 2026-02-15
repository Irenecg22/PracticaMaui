using System;
using System.Collections.Generic;
using System.Text;

namespace MauiPractica.Services
{
    public interface IRestService<T>
    {
        public List<T> GetAll();
    }
}
