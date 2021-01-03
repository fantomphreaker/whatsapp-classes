using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Groups : Chats
    {
        private List<Contacts> members = new List<Contacts>();

        Groups(List<Contacts> members)
        {
            this.members = members;
        }
    }
}
