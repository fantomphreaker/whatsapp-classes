using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Action
    {   
       List<Contacts> contacts = new List<Contacts>();
       Groups group;
       public void createNewGroup()
        {
            addMembers();// invokes method to add members(contacts) to the group
            string name = editGroupName(); // invokes method to set/edit group name.
            group = new Groups(contacts, name); //creates group 

        }

       public void createBroadcast() //method to create a broadcast message
        {

        }

        public void deleteChat() //method to delete chat
        {

        }

        public void addMembers() //method to add members to contacts
        {
            
        }

        public string editGroupName() //method to edit group name
        {
            return "groupname"; //returns a placeholder
        }
    }
}
