using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actions
{
    public abstract class FileAction
    {
        public abstract void Do();
        public abstract void RollBack();
        public abstract void RollUp();
    }


    enum ActionType
    {
        Changed,
        Created,
        Deleted,
        Renamed
    }
}
