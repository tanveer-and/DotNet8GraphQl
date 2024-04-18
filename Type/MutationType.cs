using DotNet8GraphQl.Entities;
using  DotNet8GraphQl.Data;

namespace DotNet8GraphQl.Type;

public class MutationType{
    public async Task<User> CreateUserAsync([Service] UserDBContext userDBContext, string name, string email, string password){
        var user = new User{
            Name = name,
            Password= password,
            Email = email
        };
    await userDBContext.User.AddAsync(user);
    await userDBContext.SaveChangesAsync();
    return user;
    } 
}

