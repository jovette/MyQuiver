using System;
using System.Collections.Generic;
using System.Text;
using MyQuiver.Common;
using MyQuiver.DataAccess.Model;
using MyQuiver.DataAccess;

namespace MyQuiver.Services.Implementation
{
    public class UserService : Service, IUserService
    {
        private IUserRepository m_repository = null;
        public UserService(IUserRepository repository)
        {
            m_repository = repository;
        }

        public Response DeleteUser(int userId)
        {
            ValueResponse<object> response = new ValueResponse<object>
            {
                Status = ResponseStatus.Success
            };
            try
            {
                m_repository.Delete(userId);
            }
            catch (MongoDB.Driver.MongoDuplicateKeyException dupEx)
            {
                response.Status = ResponseStatus.Failure;
                response.Message = dupEx.ErrorMessage;
            }
            catch (MongoDB.Driver.MongoConnectionException conEx)
            {
                response.Status = ResponseStatus.Failure;
                response.Message = $"Connection: {conEx.ConnectionId.LocalValue} Message: {conEx.Message}";
            }
            catch (Exception ex)
            {
                response.Status = ResponseStatus.Failure;
                response.Message = ex.Message;
            }

            return response;
        }

        public ValueResponse<User> LoadUser(int userId)
        {
            ValueResponse<User> valueResponse = new ValueResponse<User>
            {
                Status = ResponseStatus.Success
            };

            User user = m_repository.Get(userId);
            valueResponse.Value = user;
            valueResponse.Status = user == null ? ResponseStatus.Error : ResponseStatus.Success;
            return valueResponse;
        }

        public ValueResponse<User> LoadUser(string email)
        {
            ValueResponse<User> valueResponse = new ValueResponse<User>
            {
                Status = ResponseStatus.Success
            };

            User user = m_repository.GetByEmail(email);
            valueResponse.Value = user;
            valueResponse.Status = user == null ? ResponseStatus.Error : ResponseStatus.Success;
            return valueResponse;
        }

        public ValueResponse<int> SaveUser(User user)
        {
            Response validationResponse = ValidateInput(user, "User");

            ValueResponse<int> valueResponse = new ValueResponse<int>();
            valueResponse.Status = validationResponse.Status;
            valueResponse.Message = validationResponse.Message;
            if (validationResponse.Status == ResponseStatus.Success)
            {
                try
                {
                    if (user.UserId == 0)
                        m_repository.Create(user);
                    else
                        m_repository.Update(user);
                }
                catch (MongoDB.Driver.MongoDuplicateKeyException dupEx)
                {
                    valueResponse.Status = ResponseStatus.Failure;
                    valueResponse.Message = dupEx.ErrorMessage;
                }
                catch (MongoDB.Driver.MongoConnectionException conEx)
                {
                    valueResponse.Status = ResponseStatus.Failure;
                    valueResponse.Message = $"Connection: {conEx.ConnectionId.LocalValue} Message: {conEx.Message}";
                }
                catch (Exception ex)
                {
                    valueResponse.Status = ResponseStatus.Failure;
                    valueResponse.Message = ex.Message;
                }
            }
            return valueResponse;
        }
    }
}
