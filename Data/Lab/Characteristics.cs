using System;

namespace RyskTech.Data
{
    public class Characteristics
    {
        public string responsiblePersonName;
        public string responsiblePersonContact;
        public string responsiblePersonOccupation;
        public string responsiblePersonEmail;

        public string building;
        public string room;

        public int generalPublicCount;
        public int studentsCount;
        public int teachersCount;
        public int technicsCount;

        public string usageCharacterization;

        public Characteristics() {
            generalPublicCount = 0;
            studentsCount = 0;
            teachersCount = 0;
            technicsCount = 0;
        }

        public void CheckValidity()
        {
            if (responsiblePersonName == null || responsiblePersonName.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.InvalidName);

            if (responsiblePersonContact == null || responsiblePersonContact.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.InvalidPhoneNumber);

            if (responsiblePersonOccupation == null || responsiblePersonOccupation.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.ErrorNoOccupation);

            if (building == null || building.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.InvalidSpaceBuilding);

            if (room == null || room.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.InvalidSpaceRoom);

            if (usageCharacterization == null || usageCharacterization.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.ErrorNoUsageDescription);

            if (generalPublicCount + studentsCount + teachersCount + technicsCount == 0)
                throw new ApplicationException(Resources.Language.pt_local.ErrorNoTeamComposition);
        }
    }
}
