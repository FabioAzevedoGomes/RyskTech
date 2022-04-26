using System;

namespace RyskTech.Data
{
    public class UnitScope
    {
        public string name;
        public DateTime date;

        // TODO Analysis scope goes here maybe?

        public UnitScope()
        {
        }

        public void CheckValidity()
        {
            if (this.name == null || this.name.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.UnitWelcomeScreen + " : " + Resources.Language.pt_local.ErrorInvalidUnitName);

        }
    }
}
