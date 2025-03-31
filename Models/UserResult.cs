using System;

namespace ApiWoman.Models;

public class UserResult
{
    public UserName Name { get; set; }
    public Dob Dob { get; set; }
    public string Email { get; set; }
    public string Gender { get; set;}
    
     public Picture Picture { get; set; }

}
