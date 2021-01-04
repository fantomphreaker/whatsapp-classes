﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Settings
    {
      
       public static User user; //supports only one user account per app. 

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
                
            }

        }

        public void modifyPrivacySettings()
        {
            
        }

        public void modifyLastSeen()
        {
           
        }
      
       public void modifyReadReceipts()
        {
            
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
                //body that executes when the number is not valid
            }
            
        }

      public void deleteAccount() //method to delete account
        {
            
        }

    
    }
}
