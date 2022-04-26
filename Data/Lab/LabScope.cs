using System;

namespace RyskTech.Data
{
    public class LabScope
    {
        public string belongingUnitName;
        public string labName;

        public bool manipulatesChemicalAgents;
        public bool manipulatesBiologicalAgents;
        public bool manipulatesPhysicalAgents;

        public DateTime date;

        public LabScope()
        {
            manipulatesChemicalAgents = false;
            manipulatesBiologicalAgents = false;
            manipulatesPhysicalAgents = false;
            date = DateTime.MinValue;
        }

        public void CheckValidity()
        {
            if (this.belongingUnitName == null || this.belongingUnitName.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.ErrorInvalidUnitName);

            if (this.labName == null || this.labName.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.ErrorInvalidLabName);

            if (!manipulatesBiologicalAgents && !manipulatesChemicalAgents && !manipulatesPhysicalAgents)
                throw new ApplicationException(Resources.Language.pt_local.ErrorNoManipulatedAreasSelected);
        }
    }
}
