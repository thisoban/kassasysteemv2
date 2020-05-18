using System;
using System.Collections.Generic;
using System.Text;
using DataModel;

namespace ILogic
{
    public interface Transactions 
    {
        ProductModel AddItem(int serialnumber);

        bool RetourTransaction(int transactionnumber);
        //todo make transaction
        //todo retour transaction
        //todo  confirm transaction payed
    }
}
