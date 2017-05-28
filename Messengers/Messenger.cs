using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messengers
{
    public enum MessageHandledStatus
    {
        NotHandles,         // Message not handled
        HandledContinues,   //I have hanlded it but let others know about it
        HandlesComplete,    //I have hanlded it but let  no one know about it
        NotHandledAbort     //I havent handled it but abort antyway
    }

    public class Messenger
    {

    }
}
