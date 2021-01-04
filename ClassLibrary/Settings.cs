using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Settings
    {
      
       static User user; //supports only one user account per app. 

        public bool verifyPhoneNumber()
        {   //code to verify that the user's phone number is valid. giving placeholder as 'true' for now.
            return true;
        }
       public void createUser(string name, string phonenumber, string about="Hey, I'm using Whatsapp!")
        {   
             //code tht accepts values of name, phonenumber and about from user.

            if (verifyPhoneNumber()) //if phone number is valid
            {
                user = new User(name, phonenumber, about); //creates user profile

            }
            else
            {
                //phone number is not a valid phone number. Cannot create user profile.
            }

        }

        public void modifyPrivacySettings()
        {
            //code that modifies privacy settings of the user
        }

        public void modifyLastSeen()
        {
           //code that modifies 'last seen' of the user
        }
      
       public void modifyReadReceipts()
        {
            //code that modifies 'read receipts' of the user
        }

      public void editProfilePicture()
        {
            //code to edit or remove profile picture
        }

      public void changeNumber(string newNumber) //method to change phone number
        {
            if (verifyPhoneNumber())
            {
                user.setPhoneNumber(newNumber); //sets phone number to a new valid phone number
            }
            else
            {
                //body that executes when the new phone number is not valid
            }
            
        }

      public void deleteAccount() //method to delete account
        {
            
        }

    
    }
}
