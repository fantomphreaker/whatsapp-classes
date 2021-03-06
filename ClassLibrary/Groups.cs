﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class GroupChat : Chats
    {
        private List<Contacts> members = new List<Contacts>(); //stores list of group members
        private string groupName; //name of the group
        private List<string> adminList = new List<string>() { "user" }; // user will be the default admin of the group
        

        public GroupChat(List<Contacts> members, string name)
        {
            this.members = members;
            this.groupName = name;
        }

        public void changeGroupIcon()
        {
            //code to change or remove the group icon
        }

        public void changeGroupName()
        {
            //code to change group name
        }

        public override void sendText()
        {
            //code to send text message to the group
        }

        public override void sendImage()
        {
            //code to send image file(s) to the group
        }

        public override void sendVideo()
        {
            //code to send video file(s) to the group
        }

        public override void sendDocuments()
        {
            //code to send document(s) to the group
        }

        public override void sendAudio()
        {
            //code to send audio(s) to the group
        }

        public override void deleteMessage()
        {
            //code to delete message(s) from the group
        }

        public void makeAdmin() //method that gives admin privileges to multiple members of the group
        {
            //adminList.Add(members[i])
        }

        public new void playAudio()
        {
            //code that plays audio in group chat
        }

        public new void playVideo()
        {
            //code that plays video messages in group chat
        }

        public new void viewImage()
        {
            //code to view image file messages in group chat
        }

        public new void viewDocument()
        {
            //code to view document file message in group chat.
        }

        public new void recordAudio()
        {
            //code that records audio using device's microphone to send as an audiomessage(file) to the group chat.
        }

        public new void recordVideo()
        {
            //code that records video using device's camera to send as a video message(file) to the group chat.
        }


    }
}
