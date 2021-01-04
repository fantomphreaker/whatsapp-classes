using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Chats: IMedia
    {
        string message; //message to be sent
        string chatHistory; //chat history that has all the conversation in text along with the date and time.

        public virtual void sendText()
        {
            //code that sends text message to a single contact
        }

        public virtual void sendImage()
        {
            //code that sends Image File(s) to a single contact
        }

        public virtual void sendVideo()
        {
            //code that sends Video File(s) to a single contact
        }

        public virtual void sendDocuments()
        {
            //code that sends Documet(s) to a single contact
        }

        public virtual void sendAudio()
        {
            //code that sends Audio File(s) to a single contact
        }

        public virtual void deleteMessage()
        {
            //code that deletes Message(s) from chat
        }

        public void playAudio()
        {
            //code that plays audio messages in chat
        }

        public void playVideo()
        {
            //code that plays video messages in chat
        }

        public void viewImage()
        {
            //code to view image messages in chat
        }

        public void viewDocument()
        {
            //code to view document file in chat.
        }
    }
}
