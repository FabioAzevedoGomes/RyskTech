// Nuget package SyncFusion
using Syncfusion.DocIO.DLS;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace RyskTech
{
    class DocumentBuilder
    {
        private string documentName;
        private WordDocument documentReference;
        private APR apr;

        public DocumentBuilder(APR apr, string documentName)
        {
            this.apr = apr;
            this.documentName = documentName;

            documentReference = new WordDocument();
            documentReference.EnsureMinimal();
        }

        public int CreateUnitDocumentFromAPR()
        {
            AddUnitInformation();
            AddAnnexSection();

            documentReference.Save(documentName, Syncfusion.DocIO.FormatType.Docx);
            documentReference.Close();

            return 0;
        }

        public int CreateLabDocumentFromAPR()
        {
            AddLabInformation();
            AddAnnexSection();

            documentReference.Save(documentName, Syncfusion.DocIO.FormatType.Docx);
            documentReference.Close();

            return 0;
        }

        private void AddUnitInformation()
        {
            AddUnitTeamInformation();
            AddUnitLocationInformation();
            AddUnitStructureInformation();
            AddUnitHistoryInformation();
            AddAPRMethodologyInformation();
        }

        private void AddLabInformation()
        {
            IWSection labSection = AddSectionWithTitle(apr.lab.generalInformation.labName + " (" + apr.lab.generalInformation.belongingUnitName + ")");

            AddLabGeneralInfo(labSection);
            AddLabGeneralDescription(labSection);

            if (apr.lab.generalInformation.manipulatesChemicalAgents)
                AddLabChemicalAgentInfo(labSection);

            if (apr.lab.generalInformation.manipulatesBiologicalAgents)
                AddLabBiologicalAgentInfo(labSection);

            AddLabMechAgentInfo(labSection);

            if (apr.lab.generalInformation.manipulatesPhysicalAgents)
                AddLabPhysicalAgentInfo(labSection);

            AddLabIdentifiedRisks();
            AddLabFinalConsiderations();
        }

        private void AddLabGeneralInfo(IWSection section)
        {
            List<string> items = apr.GetFormattedGeneralInfoList();

            AddSubsectionTitle(section, "Data");
            AddTextParagraph(apr.lab.generalInformation.date.ToString());
            AddSubsectionTitle(section, "Informações gerais");
            AddListWithItems(items);
            AddSubsectionTitle(section, "Composição da equipe");
            AddTeamCompositionTableForLabs();
        }

        private void AddTeamCompositionTableForLabs()
        {
            IWTable labTeamTable = GetCurrentSection().AddTable();
            labTeamTable.ResetCells(5, 2);
            labTeamTable[0, 0].AddParagraph().AppendText(Resources.Language.pt_local.Type);
            labTeamTable[0, 1].AddParagraph().AppendText(Resources.Language.pt_local.Quantity);

            // Public
            labTeamTable[1, 0].AddParagraph().AppendText(Resources.Language.pt_local.Public);
            labTeamTable[1, 1].AddParagraph().AppendText(apr.lab.spaceCharacterization.generalPublicCount.ToString());

            // Students
            labTeamTable[2, 0].AddParagraph().AppendText(Resources.Language.pt_local.Students);
            labTeamTable[2, 1].AddParagraph().AppendText(apr.lab.spaceCharacterization.studentsCount.ToString());

            // Teachers
            labTeamTable[3, 0].AddParagraph().AppendText(Resources.Language.pt_local.Teachers);
            labTeamTable[3, 1].AddParagraph().AppendText(apr.lab.spaceCharacterization.teachersCount.ToString());

            // Technics
            labTeamTable[4, 0].AddParagraph().AppendText(Resources.Language.pt_local.Technics);
            labTeamTable[4, 1].AddParagraph().AppendText(apr.lab.spaceCharacterization.technicsCount.ToString());

        }

        private void AddLabGeneralDescription(IWSection section)
        {
            AddSubsectionTitle(section, "Descrição geral");
            AddTextParagraph(apr.lab.spaceCharacterization.usageCharacterization);
        }

        private void AddLabChemicalAgentInfo(IWSection section)
        {
            if (apr.lab.manipulatedChemicalReactors.Count > 0)
            {
                AddSubsectionTitle(section, "Compilação dos reagentes químicos");
                AddChemicalReactorsTable();
            }

            if (apr.lab.manipulatedChemicalResidues.Count > 0)
            {
                AddSubsectionTitle(section, "Compilação dos resíduos químicos");
                AddChemicalResidueTable();
            }

            AddChemicalResidueStorageInfo();

            AddSafetyInfo();
        }

        private void AddChemicalReactorsTable()
        {
            IWTable chemicalReactorTable = GetCurrentSection().AddTable();
            chemicalReactorTable.ResetCells(apr.lab.manipulatedChemicalReactors.Count + 1, 10);
            chemicalReactorTable[0, 0].AddParagraph().AppendText(Resources.Language.pt_local.Name);
            chemicalReactorTable[0, 1].AddParagraph().AppendText(Resources.Language.pt_local.PhysicalState);
            chemicalReactorTable[0, 2].AddParagraph().AppendText(Resources.Language.pt_local.Origin);
            chemicalReactorTable[0, 3].AddParagraph().AppendText(Resources.Language.pt_local.Quantity);
            chemicalReactorTable[0, 4].AddParagraph().AppendText(Resources.Language.pt_local.Mixture);
            chemicalReactorTable[0, 5].AddParagraph().AppendText(Resources.Language.pt_local.CasNumber);
            chemicalReactorTable[0, 6].AddParagraph().AppendText(Resources.Language.pt_local.DangerCharacteristics);
            chemicalReactorTable[0, 7].AddParagraph().AppendText(Resources.Language.pt_local.Inert);
            chemicalReactorTable[0, 8].AddParagraph().AppendText(Resources.Language.pt_local.Container);
            chemicalReactorTable[0, 9].AddParagraph().AppendText(Resources.Language.pt_local.StorageInfo);

            for (int i = 0; i < apr.lab.manipulatedChemicalReactors.Count; i++)
            {
                chemicalReactorTable[i + 1, 0].AddParagraph().AppendText(apr.lab.manipulatedChemicalReactors[i].name);
                chemicalReactorTable[i + 1, 1].AddParagraph().AppendText(apr.lab.manipulatedChemicalReactors[i].physicalState);
                chemicalReactorTable[i + 1, 2].AddParagraph().AppendText(apr.lab.manipulatedChemicalReactors[i].origin);
                chemicalReactorTable[i + 1, 3].AddParagraph().AppendText(apr.lab.manipulatedChemicalReactors[i].quantity + " " + apr.lab.manipulatedChemicalReactors[i].measurementUnit);
                chemicalReactorTable[i + 1, 4].AddParagraph().AppendText(apr.lab.manipulatedChemicalReactors[i].mixtureDescription);
                chemicalReactorTable[i + 1, 5].AddParagraph().AppendText(apr.lab.manipulatedChemicalReactors[i].casNumber);
                chemicalReactorTable[i + 1, 6].AddParagraph().AppendText(apr.lab.manipulatedChemicalReactors[i].dangerCharacteristics);
                chemicalReactorTable[i + 1, 7].AddParagraph().AppendText(apr.lab.manipulatedChemicalReactors[i].inert ? Resources.Language.pt_local.Yes : Resources.Language.pt_local.No);
                chemicalReactorTable[i + 1, 8].AddParagraph().AppendText(apr.lab.manipulatedChemicalReactors[i].container);
                chemicalReactorTable[i + 1, 9].AddParagraph().AppendText(apr.lab.manipulatedChemicalReactors[i].storageDetails);
            }
        }

        private void AddChemicalResidueTable()
        {
            IWTable chemicalResiduesTable = GetCurrentSection().AddTable();
            chemicalResiduesTable.ResetCells(apr.lab.manipulatedChemicalResidues.Count + 1, 8);
            chemicalResiduesTable[0, 0].AddParagraph().AppendText(Resources.Language.pt_local.Name);
            chemicalResiduesTable[0, 1].AddParagraph().AppendText(Resources.Language.pt_local.PhysicalState);
            chemicalResiduesTable[0, 2].AddParagraph().AppendText(Resources.Language.pt_local.Origin);
            chemicalResiduesTable[0, 3].AddParagraph().AppendText(Resources.Language.pt_local.Quantity);
            chemicalResiduesTable[0, 4].AddParagraph().AppendText(Resources.Language.pt_local.DangerCharacteristics);
            chemicalResiduesTable[0, 5].AddParagraph().AppendText(Resources.Language.pt_local.Inert);
            chemicalResiduesTable[0, 6].AddParagraph().AppendText(Resources.Language.pt_local.Container);
            chemicalResiduesTable[0, 7].AddParagraph().AppendText(Resources.Language.pt_local.StorageInfo);

            for (int i = 0; i < apr.lab.manipulatedChemicalResidues.Count; i++)
            {
                chemicalResiduesTable[i + 1, 0].AddParagraph().AppendText(apr.lab.manipulatedChemicalResidues[i].name);
                chemicalResiduesTable[i + 1, 1].AddParagraph().AppendText(apr.lab.manipulatedChemicalResidues[i].physicalState);
                chemicalResiduesTable[i + 1, 2].AddParagraph().AppendText(apr.lab.manipulatedChemicalResidues[i].origin);
                chemicalResiduesTable[i + 1, 3].AddParagraph().AppendText(apr.lab.manipulatedChemicalResidues[i].quantity + " " + apr.lab.manipulatedChemicalResidues[i].measurementUnit);
                chemicalResiduesTable[i + 1, 4].AddParagraph().AppendText(apr.lab.manipulatedChemicalResidues[i].dangerCharacteristics);
                chemicalResiduesTable[i + 1, 5].AddParagraph().AppendText(apr.lab.manipulatedChemicalResidues[i].inert ? Resources.Language.pt_local.Yes : Resources.Language.pt_local.No);
                chemicalResiduesTable[i + 1, 6].AddParagraph().AppendText(apr.lab.manipulatedChemicalResidues[i].container);
                chemicalResiduesTable[i + 1, 7].AddParagraph().AppendText(apr.lab.manipulatedChemicalResidues[i].storageDetails);
            }
        }

        private void AddChemicalResidueStorageInfo()
        {
            AddSubsectionTitle(GetCurrentSection(), "Informações de armazenamento e disposição");
            AddTextParagraph(apr.lab.chemicalResidueStorageInfo.residueDestination);

            if (!apr.lab.chemicalResidueStorageInfo.NBRCompliant)
                AddTextParagraph("O espaço não apresenta conformidade com a NBR-14725-3:2017 quanto à rotulagem dos resíduos.");
            else
                AddTextParagraph("O espaço apresenta rotulagem dos seus resíduos armazenados de acordo com a NBR-14725-3:2017");

            if (!apr.lab.chemicalResidueStorageInfo.FISPQCompliant)
                AddTextParagraph("O espaço não apresenta rotulagem dos recipientes com base na FISPQ ,em conformidade com a NBR-14725-4:2014");
            else
                AddTextParagraph("O espaço apresenta rotulagem dos recipientes com base na FISPQ, em conformidade com a NBR-14725-4:2014. ");
        }

        private void AddSafetyInfo()
        {
            AddSubsectionTitle(GetCurrentSection(), "Informações de segurança");
            AddSafetyEquipmentInfo();
            AddSafetyTrainingInfo();
        }

        private void AddSafetyEquipmentInfo()
        {
            List<String> epis = apr.lab.safetyEquipment.getEPIS();
            List<String> epcs = apr.lab.safetyEquipment.getEPCS();
            List<String> firstAid = apr.lab.safetyEquipment.getFirstAidObjects();

            if (epis == null || epis.Count <= 0)
                AddTextParagraph("O espaço não apresenta Equipamentos de Proteção Individual.");
            else
            {
                AddTextParagraph("O espaço apresenta os seguintes Equipamentos de Proteção Individual (EPIs):");
                AddListWithItems(epis);
            }

            if (epcs == null || epcs.Count <= 0)
                AddTextParagraph("O espaço não apresenta Equipamentos de Proteção Coletiva.");
            else
            {
                AddTextParagraph("O espaço apresenta os seguintes Equipamentos de Proteção Coletiva (EPCs):");
                AddListWithItems(epcs);
            }

            if (apr.lab.safetyEquipment.noFirstAid)
                AddTextParagraph("O espaço não possui uma caixa de primeiros socorros.");
            else
            {
                AddTextParagraph("O espaço possui uma caixa de primeiros socorros com os seguintes itens:");
                AddListWithItems(firstAid);
            }
        }

        private void AddSafetyTrainingInfo()
        {
            if (!apr.lab.safetyTraining.providesTraining)
                AddTextParagraph("O espaço não fornece treinamentos de segurança aos indivíduos.");
            else
            {
                AddTextParagraph("O espaço fornece treinamentos de segurança aos indivíduos a cada " +
                    apr.lab.safetyTraining.periodicityAmount + " " + apr.lab.safetyTraining.periodicityUnit + ". Os indivíduos envolvidos são:");
                AddTextParagraph(apr.lab.safetyTraining.involvedPersonel);
            }
        }

        private void AddLabBiologicalAgentInfo(IWSection section)
        {
            AddSubsectionTitle(section, "Compilação dos agentes biológicos");
            AddBiologicalAgentsTable();

            AddProcessedBioSamples();
            AddBioRegistryInformation();

            AddSubsectionTitle(section, "Armazenamento e destino");
            AddBioStorageDestinationInformation();
        }

        private void AddBiologicalAgentsTable()
        {
            IWTable bioAgentsTable = GetCurrentSection().AddTable();
            bioAgentsTable.ResetCells(apr.lab.biologicalAgentsInfo.biologicalAgentList.Count + 1, 3);
            bioAgentsTable[0, 0].AddParagraph().AppendText(Resources.Language.pt_local.Name);
            bioAgentsTable[0, 1].AddParagraph().AppendText(Resources.Language.pt_local.RiskClassification);
            bioAgentsTable[0, 2].AddParagraph().AppendText(Resources.Language.pt_local.Usage);

            for (int i = 0; i < apr.lab.biologicalAgentsInfo.biologicalAgentList.Count; i++)
            {
                bioAgentsTable[i + 1, 0].AddParagraph().AppendText(apr.lab.biologicalAgentsInfo.biologicalAgentList[i].name);
                bioAgentsTable[i + 1, 1].AddParagraph().AppendText(apr.lab.biologicalAgentsInfo.biologicalAgentList[i].riskClassification);
                bioAgentsTable[i + 1, 2].AddParagraph().AppendText(apr.lab.biologicalAgentsInfo.biologicalAgentList[i].usageScenarios);
            }
        }

        private void AddProcessedBioSamples()
        {
            AddTextParagraph("O laboratório processa os seguintes tipos de amostras biológicas");
            AddListWithItems(apr.lab.biologicalAgentsInfo.processedSamples);
        }

        private void AddBioRegistryInformation()
        {
            AddTextParagraph("O espaço " + (apr.lab.biologicalAgentsInfo.hasOGM ? "" : "não") + " manipula organismos genéticamente modificados (OGMS), e" +
                (apr.lab.biologicalAgentsInfo.hasBioSecurityCertificate ? "" : "não") + " possui certificado de qualidade em biosegurança.");

            if (apr.lab.biologicalAgentsInfo.SISGEN != null && apr.lab.biologicalAgentsInfo.SISGEN.Length > 0)
                AddTextParagraph("O espaço possui número de cadastro SISGEN " + apr.lab.biologicalAgentsInfo.SISGEN);
            else
                AddTextParagraph("O espaço não possui número de cadastro SISGEN.");
        }

        private void AddBioStorageDestinationInformation()
        {
            AddTextParagraph(apr.lab.biologicalAgentsStorage);
            AddTextParagraph(apr.lab.biologicalAgentsDestination);
        }

        private void AddLabMechAgentInfo(IWSection section)
        {
            AddSubsectionTitle(section, "Compilação dos agentes mecânicos");
            AddMechanicalAgentsTable();
        }

        private void AddMechanicalAgentsTable()
        {
            IWTable mechanicalAgentsTable = GetCurrentSection().AddTable();
            mechanicalAgentsTable.ResetCells(apr.lab.mechanicalAgentsInfo.Count + 1, 3);
            mechanicalAgentsTable[0, 0].AddParagraph().AppendText(Resources.Language.pt_local.Agent);
            mechanicalAgentsTable[0, 1].AddParagraph().AppendText(Resources.Language.pt_local.AssociatedRisk);
            mechanicalAgentsTable[0, 2].AddParagraph().AppendText(Resources.Language.pt_local.AdditionalInformation);
            for (int i = 0; i < apr.lab.mechanicalAgentsInfo.Count; i++)
            {
                mechanicalAgentsTable[i + 1, 0].AddParagraph().AppendText(apr.lab.mechanicalAgentsInfo[i].name);
                mechanicalAgentsTable[i + 1, 1].AddParagraph().AppendText(apr.lab.mechanicalAgentsInfo[i].associatedRisk);
                mechanicalAgentsTable[i + 1, 2].AddParagraph().AppendText(apr.lab.mechanicalAgentsInfo[i].additionalInfo);
            }
        }

        private void AddLabPhysicalAgentInfo(IWSection section)
        {
            AddSubsectionTitle(section, "Compilação dos agentes físicos");
            AddPhysicalAgentsTable();
        }

        private void AddPhysicalAgentsTable()
        {
            IWTable physicalAgentsTable = GetCurrentSection().AddTable();
            physicalAgentsTable.ResetCells(apr.lab.physicalAgentsInfo.Count + 1, 3);
            physicalAgentsTable[0, 0].AddParagraph().AppendText(Resources.Language.pt_local.Equipment);
            physicalAgentsTable[0, 1].AddParagraph().AppendText(Resources.Language.pt_local.Usage);
            physicalAgentsTable[0, 2].AddParagraph().AppendText(Resources.Language.pt_local.AssociatedRisk);
            for (int i = 0; i < apr.lab.physicalAgentsInfo.Count; i++)
            {
                physicalAgentsTable[i + 1, 0].AddParagraph().AppendText(apr.lab.physicalAgentsInfo[i].equipment);
                physicalAgentsTable[i + 1, 1].AddParagraph().AppendText(apr.lab.physicalAgentsInfo[i].usage);
                physicalAgentsTable[i + 1, 2].AddParagraph().AppendText(apr.lab.physicalAgentsInfo[i].generatedRisks);
            }

        }

        private void AddLabIdentifiedRisks()
        {
            AddSubsectionTitle(GetCurrentSection(), "Riscos Identificados");
            AddIdentifiedRisksTable();
        }

        private void AddIdentifiedRisksTable()
        {
            IWTable risksTable = GetCurrentSection().AddTable();
            risksTable.ResetCells(apr.lab.riskAnalysisInformation.identifiedRisks.Count + 1, 6);
            risksTable[0, 0].AddParagraph().AppendText(Resources.Language.pt_local.Risk);
            risksTable[0, 1].AddParagraph().AppendText(Resources.Language.pt_local.Danger);
            risksTable[0, 2].AddParagraph().AppendText(Resources.Language.pt_local.SafetyNet);
            risksTable[0, 3].AddParagraph().AppendText(Resources.Language.pt_local.SeverityClassification);
            risksTable[0, 4].AddParagraph().AppendText(Resources.Language.pt_local.FrequencyClassification);
            risksTable[0, 5].AddParagraph().AppendText(Resources.Language.pt_local.RiskClassification);

            for (int i = 0; i < apr.lab.riskAnalysisInformation.identifiedRisks.Count; i++)
                for (int j = 0; j < 6; j++)
                    risksTable[i + 1, j].AddParagraph().AppendText(apr.lab.riskAnalysisInformation.GetFormattedRiskList()[i][j]);
        }

        private void AddLabFinalConsiderations()
        {
            AddSubsectionTitle(GetCurrentSection(), "Histórico de acidentes");
            AddTextParagraph(apr.lab.riskAnalysisInformation.accidents);

            AddSubsectionTitle(GetCurrentSection(), "Conclusões");
            AddTextParagraph(apr.lab.riskAnalysisInformation.conclusion);

            AddSubsectionTitle(GetCurrentSection(), "Recomendações");
            AddTextParagraph(apr.lab.riskAnalysisInformation.recomendations);
        }

        private void AddUnitTeamInformation()
        {
            List<string> directors = apr.GetDirectorsFormattedDescriptionList();

            AddSectionWithTitle(this.documentReference.Sections.Count + ". Data");
            AddTextParagraph(apr.unit.generalInformation.date.ToString());
            AddSectionWithTitle(this.documentReference.Sections.Count + ". Equipe");
            AddTextParagraph("Responsáveis: ");
            AddListWithItems(directors);
            AddTextParagraph("Público frequentador: ");
            AddTeamCompositionTable();
            AddTextParagraph("Para entrar em contato com a unidade, utilizar o telefone " + apr.unit.team.contactPhone);
        }

        private void AddUnitLocationInformation()
        {
            AddSectionWithTitle(this.documentReference.Sections.Count + ". Localização");
            AddTextParagraph("A unidade está localizada em " + apr.GetLocationString() + ".");
        }

        private void AddUnitStructureInformation()
        {
            AddSectionWithTitle(this.documentReference.Sections.Count + ". Estrutura");
            AddTextParagraph("A unidade utiliza os seguintes espaços: ");
            AddRoomsBuildingsTimesTable();
        }

        private void AddUnitHistoryInformation()
        {
            AddSectionWithTitle(this.documentReference.Sections.Count + ". Histórico");
            AddTextParagraph(apr.unit.history);
        }

        private void AddAPRMethodologyInformation()
        {
            AddSectionWithTitle(this.documentReference.Sections.Count + ". Metodologia");
            AddTextParagraph(apr.unit.methodologyDescription);
        }

        private void AddRoomsBuildingsTimesTable()
        {
            // Create table with rooms, buildings and time ranges
            IWTable unit_spaces_table = GetCurrentSection().AddTable();
            unit_spaces_table.ResetCells(apr.unit.structure.spaces.Count + 1, 6);
            unit_spaces_table[0, 0].AddParagraph().AppendText(Resources.Language.pt_local.Building);
            unit_spaces_table[0, 1].AddParagraph().AppendText(Resources.Language.pt_local.Room);
            unit_spaces_table[0, 2].AddParagraph().AppendText(Resources.Language.pt_local.Floor);
            unit_spaces_table[0, 3].AddParagraph().AppendText(Resources.Language.pt_local.UsagePeriod);
            unit_spaces_table[0, 4].AddParagraph().AppendText(Resources.Language.pt_local.SurroundingsComments);
            unit_spaces_table[0, 5].AddParagraph().AppendText(Resources.Language.pt_local.Days);
            for (int i = 0; i < apr.unit.structure.spaces.Count; i++)
            {
                unit_spaces_table[i + 1, 0].AddParagraph().AppendText(apr.unit.structure.spaces[i].buildingIdentifier);
                unit_spaces_table[i + 1, 1].AddParagraph().AppendText(apr.unit.structure.spaces[i].roomIdentifier);
                unit_spaces_table[i + 1, 2].AddParagraph().AppendText(apr.unit.structure.spaces[i].floorIdentifier);
                unit_spaces_table[i + 1, 3].AddParagraph().AppendText(apr.unit.structure.spaces[i].turnStart.ToString() + " - " + apr.unit.structure.spaces[i].turnEnd.ToString());
                unit_spaces_table[i + 1, 4].AddParagraph().AppendText(apr.unit.structure.spaces[i].surroundingsComments);
                unit_spaces_table[i + 1, 5].AddParagraph().AppendText(apr.unit.structure.spaces[i].weekDays);
            }
        }

        private void AddTeamCompositionTable()
        {
            IWTable unit_team_table = GetCurrentSection().AddTable();
            unit_team_table.ResetCells(6, 2);
            unit_team_table[0, 0].AddParagraph().AppendText(Resources.Language.pt_local.Type);
            unit_team_table[0, 1].AddParagraph().AppendText(Resources.Language.pt_local.Quantity);

            // Public
            unit_team_table[1, 0].AddParagraph().AppendText(Resources.Language.pt_local.Public);
            unit_team_table[1, 1].AddParagraph().AppendText(apr.unit.team.generalPublicCount.ToString());

            // Students
            unit_team_table[2, 0].AddParagraph().AppendText(Resources.Language.pt_local.Students);
            unit_team_table[2, 1].AddParagraph().AppendText(apr.unit.team.studentsCount.ToString());

            // Teachers
            unit_team_table[3, 0].AddParagraph().AppendText(Resources.Language.pt_local.Teachers);
            unit_team_table[3, 1].AddParagraph().AppendText(apr.unit.team.teachersCount.ToString());

            // Technics
            unit_team_table[4, 0].AddParagraph().AppendText(Resources.Language.pt_local.Technics);
            unit_team_table[4, 1].AddParagraph().AppendText(apr.unit.team.technicsCount.ToString());

            // Other
            if (apr.unit.team.otherDescription != null)
            {
                unit_team_table[5, 0].AddParagraph().AppendText(apr.unit.team.otherDescription);
                unit_team_table[5, 1].AddParagraph().AppendText(apr.unit.team.otherCount.ToString());
            }
        }

        private void AddAnnexSection()
        {
            AddSectionWithTitle("Anexos");

            Image table1 = Properties.Resources.Quadro1;
            Image table2 = Properties.Resources.Quadro2;
            Image table3 = Properties.Resources.Quadro3;
            Image table4 = Properties.Resources.Quadro4;

            AddSubsectionTitle(GetCurrentSection(), "Quadro1");
            IWPicture table1pic = GetCurrentSection().AddParagraph().AppendPicture(table1);
            table1pic.Height = 400;
            table1pic.Width = 500;

            AddSubsectionTitle(GetCurrentSection(), "Quadro2");
            IWPicture table2pic = GetCurrentSection().AddParagraph().AppendPicture(table2);
            table2pic.Height = 300;
            table2pic.Width = 450;

            AddSubsectionTitle(GetCurrentSection(), "Quadro3");
            IWPicture table3pic = GetCurrentSection().AddParagraph().AppendPicture(table3);
            table3pic.Height = 300;
            table3pic.Width = 450;

            AddSubsectionTitle(GetCurrentSection(), "Quadro4");
            IWPicture table4pic = GetCurrentSection().AddParagraph().AppendPicture(table4);
            table4pic.Height = 250;
            table4pic.Width = 500;

        }

        private void AddListWithItems(List<string> items)
        {
            IWParagraph listParagraph = GetCurrentSection().AddParagraph();
            for (int i = 0; i < items.Count; i++)
            {
                if (i != items.Count - 1)
                    listParagraph.AppendText(items[i] + "\n");
                else
                    listParagraph.AppendText(items[i]);
            }
            listParagraph.ListFormat.ApplyDefBulletStyle();
        }

        private IWSection AddSectionWithTitle(string title)
        {
            IWSection section = AddSection();
            IWParagraph titleParagraph = AddTitleToSection(section, title);

            return section;
        }

        private void AddSubsectionTitle(IWSection section, string subsectionTile)
        {
            IWParagraph spacingParagraph = section.AddParagraph();
            spacingParagraph.AppendText("\n");
            IWParagraph title_paragraph = section.AddParagraph();
            IWTextRange title_text = title_paragraph.AppendText(subsectionTile);
            title_text.CharacterFormat.Bold = false;
            title_text.CharacterFormat.FontName = "Times New Roman";
            title_text.CharacterFormat.UnderlineStyle = UnderlineStyle.Single;
            title_text.CharacterFormat.FontSize = 14;
            title_paragraph.AppendText("\n");
        }

        private IWSection AddSection()
        {
            IWSection section = this.documentReference.AddSection();
            section.BreakCode = SectionBreakCode.NoBreak;
            section.PageSetup.Margins.All = 50f;

            return section;
        }

        private IWParagraph AddTitleToSection(IWSection section, string title)
        {
            IWParagraph title_paragraph = section.AddParagraph();
            title_paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Left;

            IWTextRange title_text = title_paragraph.AppendText(title);
            title_text.CharacterFormat.Bold = true;
            title_text.CharacterFormat.FontName = "Times New Roman";
            title_text.CharacterFormat.UnderlineStyle = UnderlineStyle.Single;
            title_text.CharacterFormat.FontSize = 16;
            title_paragraph.AppendText("\n");

            return title_paragraph;
        }

        private void AddTextParagraph(string content)
        {
            IWParagraph paragraph = GetCurrentSection().AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Justify;
            paragraph.AppendText(content);
        }

        private IWSection GetCurrentSection()
        {
            return this.documentReference.Sections[this.documentReference.Sections.Count - 1];
        }
    }
}
