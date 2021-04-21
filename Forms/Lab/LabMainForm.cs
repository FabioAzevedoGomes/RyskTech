﻿using System;
using System.Windows.Forms;

namespace RyskTech.Forms.Lab
{
    public partial class LabMainForm : Form
    {
        private Data.Lab data;

        public LabMainForm()
        {
            InitializeComponent();
        }

        private void LabMainForm_Load(object sender, EventArgs e)
        {
            data = new Data.Lab();
        }

        private void PrepareForGeneration()
        {
            labWelcomeControl1.ValidateData();
            data.generalInformation = labWelcomeControl1.data;
            MessageBox.Show("Welcome data validated");
            generalInformationControl1.ValidateData();
            data.spaceCharacterization = generalInformationControl1.data;
            MessageBox.Show("General info validated");
            safetyEquipmentControl1.ValidateData();
            data.safetyEquipment = safetyEquipmentControl1.data;
            MessageBox.Show("Safety equipment validated");
            safetyTrainingControl2.ValidateData();
            data.safetyTraining = safetyTrainingControl2.data;
            MessageBox.Show("safety training validated");
            chemicalResidueControl1.ValidateData();
            MessageBox.Show("chemical agent data validated");
            data.manipulatedChemicalResidues = chemicalResidueControl1.residueData;
            data.manipulatedChemicalReactors = chemicalResidueControl1.reactorData;
            data.chemicalResidueStorageInfo = chemicalResidueControl1.storageInfo;

            // TODO Validate all subtabs
            // throw new NotImplementedException();

            finalConsiderationsControl1.ValidateData();
            data.riskAnalysisInformation = finalConsiderationsControl1.data;

            MessageBox.Show("final considerations data validated");
        }

        public void Complete()
        {
            try
            {
                PrepareForGeneration();

                APR compilation = new APR(data);

                DocumentBuilder docBuilder = new DocumentBuilder(compilation, "APR_Laboratorio.docx");

                int statusCode = docBuilder.CreateLabDocumentFromAPR();

                if (statusCode == 0)
                    MessageBox.Show("APR Gerada com sucesso!", "Obrigado por usar RyskTech! :)");
                else
                    MessageBox.Show("Foram encontrados alguns erros na geração da APR", ":(");

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
