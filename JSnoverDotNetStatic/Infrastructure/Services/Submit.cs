using JSnoverDotNetStatic.DataTransferObjects.Common;
using JSnoverDotNetStatic.Infrastructure.SqlRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JSnoverDotNetStatic.Infrastructure.Services
{
    public class Submit
    {
        public static async Task<bool> SubmitContactRequest(ContactModel contactRequest)
        {
            if (RegexUtilities.IsValidEmail(contactRequest.Email))
            {
                await EmailService.NotifySnover(contactRequest);
                
                return await JsnoRepo.SubmitContactRequest(ContactModel.MapToDto(contactRequest));
            }
            return false;
        }
    }
}
