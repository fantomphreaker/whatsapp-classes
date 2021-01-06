using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Action
    {   
        
       private GroupChat group; //group is created only after valid members are selected from the contacts.
       public void createNewGroup()
        {
            List<Contacts> Contacts = new List<Contacts>(); //multiple contacts selected to be added to a group or broadcast is stored in this list
            Contacts = AddMembers();// invokes method to add members(contacts) to the group
            string name = editGroupName(); // invokes method to set/edit group name.
            group = new GroupChat(Contacts, name); //creates group with  selected contacts as its members.

        }

       public void createBroadcast() //method to create a broadcast message
        {

        }

        public void deleteChat() //method to delete chat
        {

        }

        public List<Contacts> AddMembers() //method to add members to contacts
        {
            List<Contacts> members = new List<Contacts>();
            return members;//code that add contacts to the List<Contacts> 
        }

        public string editGroupName() //method to edit group name
        {
            return "groupname"; //returns a placeholder
        }
    }
}
