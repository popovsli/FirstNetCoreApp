using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntities.Validation
{
    public interface IValidationStratergy<T>
    {
        bool Validate(T obj);
    }
}
