using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Groups : Chats
    {
        private List<Contacts> members = new List<Contacts>();
        string groupName;
        

        public Groups(List<Contacts> members, string name)
        {
            this.members = members;
            this.groupName = name;
        }

        public void changeGroupIcon()
        {

        }

        public void changeGroupName()
        {

        }

        public override void sendText()
        {

        }

        public override void sendImage()
        {

        }

        public override void sendVideo()
        {

        }

        public override void sendDocuments()
        {

        }

        public override void sendAudio()
        {

        }

        public override void deleteMessage()
        {

        }

    }
}
