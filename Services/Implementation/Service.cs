using MongoDB.Driver;
using MyQuiver.Common;
using MyQuiver.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyQuiver.Services.Implementation
{
    public abstract class Service
    {
        protected Response ValidateInput<T>(T input, string objectName) where T : class
        {
            Response response = new ValueResponse<T> { Status = ResponseStatus.Success };

            if (input == null)
            {
                response.Status = ResponseStatus.Error;
                response.Message = String.Format("ERROR: {0} is null.", objectName);
            }
            else if (EqualityComparer<T>.Default.Equals(input, default(T)))
            {
                response.Status = ResponseStatus.Error;
                response.Message = String.Format("ERROR: {0} ({1}) is invalid.", objectName, input);
            }

            return response;
        }
    }
}
