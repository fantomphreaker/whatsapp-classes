using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Contacts
    {
        private string contactName; //assumed to be fetched from device's memory 
        private string contactPhoneNumber; // assumed to be fetched from device's memory
        private string contactAbout; //assumed to be fetched from device's memory

        Chats pChat = new Chats(); //There is a chat per contact 

        public void startChat() //method that initiates the chat between the user and the contact.
        {
           // pChat.sendText();
            //pChat.sendAudio();
            //pChat.sendImage();
            //pChat.sendVideo();
            //pChat.sendDocuments();
            //pChat.playAudio();
            //pChat.playVideo();
            
        }
        

        
    }
}
