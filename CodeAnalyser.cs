using System;
using System.IO;
using System.Windows.Forms;

namespace CodeAnalyser
{
    public partial class CodeAnalyser : Form
    {
        private readonly SourceCodeEditor _sourceCodeEditor = new SourceCodeEditor();
        private const string CyclomaticComplexityText = "The cyclomatic complexity of a program: ";
        private const string TotalNumberOfOperatorsText = "The total number of operators: ";
        private const string TotalNumberOfOperandsText = "The total number of operands: ";
        private const string NumberOfDistinctOperatorsText = "The number of distinct operators: ";
        private const string NumberOfDistrinctOperandsText = "The number of distinct operands: ";
        private const string ProgramVocabularyText = "The program vocabulary: ";
        private const string ProgramLengthText = "The program length: ";
        private const string ProgramVolumeText = "The program volume: ";
        private const string TheoreticalProgramVocabularyText = "The theoretical program vocabulary: ";
        private const string TheoreticalProgramLengthText = "The theoretical program length: ";
        private const string TheoreticalProgramVolumeText = "The theoretical program volume: ";
        private const string LevelOfProgrammingQualityText = "The level of programming quality: ";
        private const string LevelOfProgrammingQualityWithoutTpvText = "The level of programming quality without theoretical program volume: ";
        private const string NumberOfElementarySolutionsForWText = "The number of required elementary solutions for writing a program: ";
        private const string NumberOfElementarySolutionsForUText = "The number of required elementary solutions for understanding the program: ";
        private const string IndexOfCodeMaintainability = "The index of code maintainability: ";

        public CodeAnalyser()
        {
            this.InitializeComponent();
        }

        private void ClearForm()
        {
            this.cyclomaticComplexityLabel.Text = CyclomaticComplexityText;
            this.totalNumberOfOperatorsLabel.Text = TotalNumberOfOperatorsText;
            this.totalNumberOfOperandsLabel.Text = TotalNumberOfOperandsText;
            this.numberOfDistinctOperatorsLabel.Text = NumberOfDistinctOperatorsText;
            this.numberOfDistinctOperandsLabel.Text = NumberOfDistrinctOperandsText;
            this.programVocabularyLabel.Text = ProgramVocabularyText;
            this.programLengthLabel.Text = ProgramLengthText;
            this.programVolumeLabel.Text = ProgramVolumeText;
            this.theoreticalProgramVocabularyLabel.Text = TheoreticalProgramVocabularyText;
            this.theoreticalProgramLengthLabel.Text = TheoreticalProgramLengthText;
            this.theoreticalProgramVolumeLabel.Text = TheoreticalProgramVolumeText;
            this.levelOfProgrammingQualityLabel.Text = LevelOfProgrammingQualityText;
            this.levelOfProgramQualityWithoutTPVLabel.Text = LevelOfProgrammingQualityWithoutTpvText;
            this.numberOfElementarySolutionsForWLabel.Text = NumberOfElementarySolutionsForWText;
            this.numberOfElementarySolutionsForULabel.Text = NumberOfElementarySolutionsForUText;
            this.indexOfCodeMaintainability.Text = IndexOfCodeMaintainability;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.sourceCodeTextBox.Clear();
            this.ClearForm();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this._sourceCodeEditor.OpenFromFile(this.openFileDialog, this.sourceCodeTextBox);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SourceCodeEditor.SaveToFile(this.saveFileDialog, this.sourceCodeTextBox);
        }

        private void sourceCodeTextBox_DoubleClick(object sender, EventArgs e)
        {
            this._sourceCodeEditor.OpenFromFile(this.openFileDialog, this.sourceCodeTextBox);
        }

        private void mcCabeButton_Click(object sender, EventArgs e)
        {
            var mcCabe = new McCabe(this.sourceCodeTextBox.Text);
            this.cyclomaticComplexityLabel.Text = CyclomaticComplexityText
                + Convert.ToString(mcCabe.CalculateCyclomaticComplexity());
        }

        private void halsteadButton_Click(object sender, EventArgs e)
        {
            var halstead = new Halstead(this.sourceCodeTextBox.Text);

            this.totalNumberOfOperatorsLabel.Text = TotalNumberOfOperatorsText
                + Convert.ToString(halstead.CountTotalNumberOfOperators());

            this.numberOfDistinctOperatorsLabel.Text = NumberOfDistinctOperatorsText
                + Convert.ToString(halstead.CountNumberOfDistinctOperators());

            this.totalNumberOfOperandsLabel.Text = TotalNumberOfOperandsText
                + Convert.ToString(halstead.CountTotalNumberOfOperands());

            this.numberOfDistinctOperandsLabel.Text = NumberOfDistrinctOperandsText
                + Convert.ToString(halstead.CountNumberOfDistinctOperands());

            this.programVocabularyLabel.Text = ProgramVocabularyText + Convert.ToString(halstead.CalculateProgramVocabulary());
            this.programLengthLabel.Text = ProgramLengthText + Convert.ToString(halstead.CalculateProgramLength());
            this.programVolumeLabel.Text = ProgramVolumeText + Convert.ToString(halstead.CalculateProgramVolume());

            this.theoreticalProgramVocabularyLabel.Text = TheoreticalProgramVocabularyText
                + Convert.ToString(halstead.CountTheoreticalProgramVocabulary());

            this.theoreticalProgramLengthLabel.Text = TheoreticalProgramLengthText
                + Convert.ToString(halstead.CalculateTheoreticalProgramLength());

            this.theoreticalProgramVolumeLabel.Text = TheoreticalProgramVolumeText
                + Convert.ToString(halstead.CalculateTheoreticalProgramVolume());

            this.levelOfProgrammingQualityLabel.Text = LevelOfProgrammingQualityText
                + Convert.ToString(halstead.CalculateLevelOfProgrammingQuality());

            this.levelOfProgramQualityWithoutTPVLabel.Text = LevelOfProgrammingQualityWithoutTpvText
                + Convert.ToString(halstead.CalculateLevelOfProgrammingQualityWithoutTpv());

            this.numberOfElementarySolutionsForWLabel.Text = NumberOfElementarySolutionsForWText
                + Convert.ToString(halstead.CalculateNumberOfRequiredElementarySolutionsForW());

            this.numberOfElementarySolutionsForULabel.Text = NumberOfElementarySolutionsForUText
                + Convert.ToString(halstead.CalculateNumberOfRequiredElementarySolutionsForU());
        }

        private void maintainabilityIndexButton_Click(object sender, EventArgs e)
        {
            try
            {
                //HV  – Объем программы (Halstead Volume),
                float HV = Convert.ToSingle(programVolumeLabel.Text.Remove(0, programVolumeLabel.Text.LastIndexOf(" ") + 1));
                //CC  – Цикломатическая сложность;
                int CC = Convert.ToInt32(cyclomaticComplexityLabel.Text.Remove(0, cyclomaticComplexityLabel.Text.LastIndexOf(" ") + 1));
                //LoC – Количество строк кода.
                int LoC = sourceCodeTextBox.Lines.Length;

                this.indexOfCodeMaintainability.Text = IndexOfCodeMaintainability
                    + (Math.Max(0, (171 - 5.2 * Math.Log(HV, Math.E) - 0.23 * CC - 16.2 * Math.Log(LoC, Math.E)) * 100 / 171)).ToString();
            }
            catch
            {
                this.indexOfCodeMaintainability.Text = IndexOfCodeMaintainability + "NaN";
            }
        }

        private void sourceCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            this.ClearForm();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
