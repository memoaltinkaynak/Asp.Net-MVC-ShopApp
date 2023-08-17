using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Business.Abstract
{
    public interface IValidator<T>
    {
        String ErrorMessage { get; set; }
        bool Validation(T entity);
    }
}
