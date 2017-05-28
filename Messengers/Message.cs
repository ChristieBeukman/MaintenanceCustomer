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



#endregion
    }
}
