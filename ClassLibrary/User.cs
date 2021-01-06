using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class User
    {
        private string name;//Name of the user
        private string phoneNumber; //Phone number of the user
        private string about; //'About' section of user profile

        public User(string name, string phoneNumber, string about) //constructor for a user object instantiation
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.about = about;
        }
        public void setName(string name)
        {
            this.name = name;
        }

        public void setPhoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        public void setAbout(string about)
        {
            this.about = about;
        }

        public void editProfilePicture() //method to add/remove or change profile picture
        {
            //code to edit profile 
        }

      
        


    }
}
