using System.Collections.Generic;

namespace HomeWork2
{
    class ActionProvider : IActionProvider
    {
        public List<IAction> GetActiveActions()
        {
            var actions = new List<IAction>
            {
                new TwoPaperForOneElectronicBook(),
                new PaperDelivery()
            };

            return actions;
        }
    }

}
