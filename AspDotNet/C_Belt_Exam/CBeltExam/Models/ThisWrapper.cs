using System;
using System.Collections.Generic;
namespace CBeltExam.Models
{
    public class ThisWrapper
    {
        public User ThisUser {get;set;}
        public LoginUser ThisLoginUser {get;set;}
        public Sport ThisSport {get;set;}
        public List<User> Participants {get;set;}
        public List<Sport> AllSports {get;set;}
        public Association Association {get;set;}

    }
}