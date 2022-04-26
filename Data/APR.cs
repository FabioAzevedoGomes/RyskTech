using RyskTech.Data;
using System.Collections.Generic;

namespace RyskTech
{
    public class APR
    {
        public Unit unit;
        public Lab lab;

        public APR(Unit unit)
        {
            this.unit = unit;
            this.lab = null;
        }

        public APR(Lab lab)
        {
            this.unit = null;
            this.lab = lab;
        }

        public string GetLocationString()
        {
            return unit.location.GetFormattedLocationString();
        }

        public List<string> GetDirectorsFormattedDescriptionList()
        {
            List<string> directors = new List<string>();

            directors.Add(unit.team.director.GetFormattedIndividualString());
            directors.Add(unit.team.viceDirector.GetFormattedIndividualString());

            return directors;
        }

        public List<string> GetFormattedGeneralInfoList()
        {
            List<string> info = new List<string>();

            info.Add("Unidade pertencente: " + lab.generalInformation.belongingUnitName);
            info.Add("Prédio: " + lab.spaceCharacterization.building);
            info.Add("Sala: " + lab.spaceCharacterization.room);
            info.Add("Data: " + lab.generalInformation.date.ToString()); 
            info.Add(lab.spaceCharacterization.responsiblePersonOccupation + ": " + lab.spaceCharacterization.responsiblePersonName + "(" + lab.spaceCharacterization.responsiblePersonContact + ")");

            return info;
        }
    }
}
