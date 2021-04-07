using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vertical_Prototype
{
    
    public class userInformation
    {
        public string UserName { get; set; }
        public string password { get; set; }
        public Recipe NewRecipe { get; set; }
        public InitRecipes Init { get; set; }

        public int LogInstatus { get; set; }

        public userInformation(string name, string password, Recipe NewRecipe, InitRecipes Init)
        {
            this.UserName = name;
            this.password = password;
            this.NewRecipe = NewRecipe;
            this.Init = Init;
            this.LogInstatus = 1;
            
        }

        public userInformation()
        {
            this.UserName = "nobody";
            this.password = "123456";
            this.LogInstatus = 0;
        }

    }
}
