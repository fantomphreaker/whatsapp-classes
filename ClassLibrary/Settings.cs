using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Settings
    {
       private bool isLastSeenVisible;
       private bool isReadReceiptsOn;
       static User user; //supports only one user account per app. 
       public void createUser(string name, string phonenumber, string about)
        {
            user = new User(name, phonenumber, about);

        }

        public void modifyPrivacySettings()
        {
            
        }

      public void modifyLastSeen()
        {
            isLastSeenVisible = true;
        }
      
      public void modifyReadReceipts()
        {
            isReadReceiptsOn = true;
        }

      public void editProfilePicture()
        {
            //code to edit or remove profile picture
        }

      public void changeNumber(string newNumber)
        {
            user.setPhoneNumber(newNumber);
        }

      public void deleteAccount()
        {
            
        }


    }
}
