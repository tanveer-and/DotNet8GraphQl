using DotNet8GraphQl.Entities;
using DotNet8GraphQl.Data;
using Microsoft.EntityFrameworkCore;

namespace DotNet8GraphQl.Type
{
    public class QueryType{
        public async Task<List<User>> AllUsersAsync([Service] UserDBContext dBContext){
            return await dBContext.User.ToListAsync();
        }
    }

}