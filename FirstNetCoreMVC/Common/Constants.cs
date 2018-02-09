using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstNetCoreMVC.Common
{
    public static class Constants
    {
        public enum ErrorCode
        {
            ObjectIsNotValid,
            TodoItemIDInUse,
            RecordNotFound,
            CouldNotCreateObject,
            CouldNotUpdateObject,
            CouldNotDeleteItem
        }
    }
}
