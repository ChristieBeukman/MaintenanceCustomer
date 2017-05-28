using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messengers
{
    public enum MessageTypes
    {
        MSG_CUSTOMER_SELECTED_FOR_EDIT,     // Sent when a Customer is selected for Editing
        MSG_CUSTOMER_SAVED,                 // Sent when a Customer is updated in the Repository

       
    }
}
