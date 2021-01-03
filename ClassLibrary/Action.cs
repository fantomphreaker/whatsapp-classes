using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Action
    {   List<Contacts> contacts = new List<Contacts>();
        Groups group;
       public void createNewGroup()
        {
            group = new Groups(contacts);

        }

       public void createBroadcast()
        {

        }

        public void deleteChat()
        {

        }
    }
}
