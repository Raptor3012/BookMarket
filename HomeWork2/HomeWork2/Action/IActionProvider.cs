using System.Collections.Generic;

namespace HomeWork2
{
    interface IActionProvider
    {
        List<IAction> GetActiveActions();
    }

}
