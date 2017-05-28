using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messengers
{
    public class Message
    {
#region Puplic Properties

        /// <summary>
        /// Has the message been handled
        /// </summary>
        public MessageHandledStatus HandledStatus
        {
            get;
            set;
        }

        /// <summary>
        /// What type of message this is
        /// </summary>
        public MessageTypes MessageType
        {
            get
            {
                return messageType;
            }
        }
        private MessageTypes messageType;

        /// <summary>
        /// The payload for the message
        /// </summary>
        public object Payload
        {
            get;
            set;
        }

        #endregion

        #region Constructor
        public Message(MessageTypes messageType)
        {
            this.messageType = messageType;
        }
#endregion
    }
}
