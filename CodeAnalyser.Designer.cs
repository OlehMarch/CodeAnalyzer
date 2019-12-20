namespace CodeAnalyser
{
    partial class CodeAnalyser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sourceCodeTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.mcCabeButton = new System.Windows.Forms.Button();
            this.cyclomaticComplexityLabel = new System.Windows.Forms.Label();
            this.halsteadButton = new System.Windows.Forms.Button();
            this.totalNumberOfOperatorsLabel = new System.Windows.Forms.Label();
            this.numberOfDistinctOperatorsLabel = new System.Windows.Forms.Label();
            this.totalNumberOfOperandsLabel = new System.Windows.Forms.Label();
            this.numberOfDistinctOperandsLabel = new System.Windows.Forms.Label();
            this.theoreticalProgramVocabularyLabel = new System.Windows.Forms.Label();
            this.programVocabularyLabel = new System.Windows.Forms.Label();
            this.programLengthLabel = new System.Windows.Forms.Label();
            this.programVolumeLabel = new System.Windows.Forms.Label();
            this.theoreticalProgramLengthLabel = new System.Windows.Forms.Label();
            this.theoreticalProgramVolumeLabel = new System.Windows.Forms.Label();
            this.levelOfProgrammingQualityLabel = new System.Windows.Forms.Label();
            this.levelOfProgramQualityWithoutTPVLabel = new System.Windows.Forms.Label();
            this.numberOfElementarySolutionsForWLabel = new System.Windows.Forms.Label();
            this.numberOfElementarySolutionsForULabel = new System.Windows.Forms.Label();
            this.GB_MCM = new System.Windows.Forms.GroupBox();
            this.GB_HM = new System.Windows.Forms.GroupBox();
            this.graphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TLP_Main = new System.Windows.Forms.TableLayoutPanel();
            this.GB_MI = new System.Windows.Forms.GroupBox();
            this.indexOfCodeMaintainability = new System.Windows.Forms.Label();
            this.TLP_Metrics = new System.Windows.Forms.TableLayoutPanel();
            this.maintainabilityIndexButton = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.GB_MCM.SuspendLayout();
            this.GB_HM.SuspendLayout();
            this.TLP_Main.SuspendLayout();
            this.GB_MI.SuspendLayout();
            this.TLP_Metrics.SuspendLayout();
            this.SuspendLayout();
            // 
            // sourceCodeTextBox
            // 
            this.sourceCodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sourceCodeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceCodeTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourceCodeTextBox.Location = new System.Drawing.Point(757, 0);
            this.sourceCodeTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.sourceCodeTextBox.MaxLength = 2147483647;
            this.sourceCodeTextBox.MinimumSize = new System.Drawing.Size(400, 0);
            this.sourceCodeTextBox.Multiline = true;
            this.sourceCodeTextBox.Name = "sourceCodeTextBox";
            this.TLP_Main.SetRowSpan(this.sourceCodeTextBox, 4);
            this.sourceCodeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.sourceCodeTextBox.Size = new System.Drawing.Size(544, 617);
            this.sourceCodeTextBox.TabIndex = 1;
            this.sourceCodeTextBox.WordWrap = false;
            this.sourceCodeTextBox.TextChanged += new System.EventHandler(this.sourceCodeTextBox_TextChanged);
            this.sourceCodeTextBox.DoubleClick += new System.EventHandler(this.sourceCodeTextBox_DoubleClick);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.graphToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(1301, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "File";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "C# source file (*.cs)|*.cs";
            this.openFileDialog.InitialDirectory = "d:\\Education\\Subjects\\3 Курс\\5 Семестр\\Предметы\\МССвИР\\LP\\Лабораторная работа №2\\" +
    "LAB2\\RubyMcCabeHalstead\\";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "C# source file (*.cs)|*.cs";
            this.saveFileDialog.InitialDirectory = "d:\\Education\\Subjects\\3 Курс\\5 Семестр\\Предметы\\МССвИР\\LP\\Лабораторная работа №2\\" +
    "LAB2\\RubyMcCabeHalstead\\";
            // 
            // mcCabeButton
            // 
            this.mcCabeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mcCabeButton.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcCabeButton.Location = new System.Drawing.Point(3, 3);
            this.mcCabeButton.Name = "mcCabeButton";
            this.mcCabeButton.Size = new System.Drawing.Size(246, 57);
            this.mcCabeButton.TabIndex = 3;
            this.mcCabeButton.Text = "McCabe";
            this.mcCabeButton.UseVisualStyleBackColor = true;
            this.mcCabeButton.Click += new System.EventHandler(this.mcCabeButton_Click);
            // 
            // cyclomaticComplexityLabel
            // 
            this.cyclomaticComplexityLabel.AutoSize = true;
            this.cyclomaticComplexityLabel.Font = new System.Drawing.Font("Lucida Fax", 11.25F);
            this.cyclomaticComplexityLabel.Location = new System.Drawing.Point(6, 40);
            this.cyclomaticComplexityLabel.Name = "cyclomaticComplexityLabel";
            this.cyclomaticComplexityLabel.Size = new System.Drawing.Size(324, 17);
            this.cyclomaticComplexityLabel.TabIndex = 4;
            this.cyclomaticComplexityLabel.Text = "The cyclomatic complexity of a program: ";
            // 
            // halsteadButton
            // 
            this.halsteadButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.halsteadButton.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.halsteadButton.Location = new System.Drawing.Point(255, 3);
            this.halsteadButton.Name = "halsteadButton";
            this.halsteadButton.Size = new System.Drawing.Size(246, 57);
            this.halsteadButton.TabIndex = 5;
            this.halsteadButton.Text = "Halstead";
            this.halsteadButton.UseVisualStyleBackColor = true;
            this.halsteadButton.Click += new System.EventHandler(this.halsteadButton_Click);
            // 
            // totalNumberOfOperatorsLabel
            // 
            this.totalNumberOfOperatorsLabel.AutoSize = true;
            this.totalNumberOfOperatorsLabel.Font = new System.Drawing.Font("Lucida Fax", 11.25F);
            this.totalNumberOfOperatorsLabel.Location = new System.Drawing.Point(6, 76);
            this.totalNumberOfOperatorsLabel.Name = "totalNumberOfOperatorsLabel";
            this.totalNumberOfOperatorsLabel.Size = new System.Drawing.Size(247, 17);
            this.totalNumberOfOperatorsLabel.TabIndex = 6;
            this.totalNumberOfOperatorsLabel.Text = "The total number of operators: ";
            // 
            // numberOfDistinctOperatorsLabel
            // 
            this.numberOfDistinctOperatorsLabel.AutoSize = true;
            this.numberOfDistinctOperatorsLabel.Font = new System.Drawing.Font("Lucida Fax", 11.25F);
            this.numberOfDistinctOperatorsLabel.Location = new System.Drawing.Point(6, 26);
            this.numberOfDistinctOperatorsLabel.Name = "numberOfDistinctOperatorsLabel";
            this.numberOfDistinctOperatorsLabel.Size = new System.Drawing.Size(271, 17);
            this.numberOfDistinctOperatorsLabel.TabIndex = 7;
            this.numberOfDistinctOperatorsLabel.Text = "The number of distinct operators: ";
            // 
            // totalNumberOfOperandsLabel
            // 
            this.totalNumberOfOperandsLabel.AutoSize = true;
            this.totalNumberOfOperandsLabel.Font = new System.Drawing.Font("Lucida Fax", 11.25F);
            this.totalNumberOfOperandsLabel.Location = new System.Drawing.Point(6, 96);
            this.totalNumberOfOperandsLabel.Name = "totalNumberOfOperandsLabel";
            this.totalNumberOfOperandsLabel.Size = new System.Drawing.Size(240, 17);
            this.totalNumberOfOperandsLabel.TabIndex = 8;
            this.totalNumberOfOperandsLabel.Text = "The total number of operands:";
            // 
            // numberOfDistinctOperandsLabel
            // 
            this.numberOfDistinctOperandsLabel.AutoSize = true;
            this.numberOfDistinctOperandsLabel.Font = new System.Drawing.Font("Lucida Fax", 11.25F);
            this.numberOfDistinctOperandsLabel.Location = new System.Drawing.Point(6, 46);
            this.numberOfDistinctOperandsLabel.Name = "numberOfDistinctOperandsLabel";
            this.numberOfDistinctOperandsLabel.Size = new System.Drawing.Size(269, 17);
            this.numberOfDistinctOperandsLabel.TabIndex = 9;
            this.numberOfDistinctOperandsLabel.Text = "The number of distinct operands: ";
            // 
            // theoreticalProgramVocabularyLabel
            // 
            this.theoreticalProgramVocabularyLabel.AutoSize = true;
            this.theoreticalProgramVocabularyLabel.Font = new System.Drawing.Font("Lucida Fax", 11.25F);
            this.theoreticalProgramVocabularyLabel.Location = new System.Drawing.Point(6, 196);
            this.theoreticalProgramVocabularyLabel.Name = "theoreticalProgramVocabularyLabel";
            this.theoreticalProgramVocabularyLabel.Size = new System.Drawing.Size(289, 17);
            this.theoreticalProgramVocabularyLabel.TabIndex = 10;
            this.theoreticalProgramVocabularyLabel.Text = "The theoretical program vocabulary: ";
            // 
            // programVocabularyLabel
            // 
            this.programVocabularyLabel.AutoSize = true;
            this.programVocabularyLabel.Font = new System.Drawing.Font("Lucida Fax", 11.25F);
            this.programVocabularyLabel.Location = new System.Drawing.Point(6, 126);
            this.programVocabularyLabel.Name = "programVocabularyLabel";
            this.programVocabularyLabel.Size = new System.Drawing.Size(204, 17);
            this.programVocabularyLabel.TabIndex = 11;
            this.programVocabularyLabel.Text = "The program vocabulary: ";
            // 
            // programLengthLabel
            // 
            this.programLengthLabel.AutoSize = true;
            this.programLengthLabel.Font = new System.Drawing.Font("Lucida Fax", 11.25F);
            this.programLengthLabel.Location = new System.Drawing.Point(6, 146);
            this.programLengthLabel.Name = "programLengthLabel";
            this.programLengthLabel.Size = new System.Drawing.Size(169, 17);
            this.programLengthLabel.TabIndex = 12;
            this.programLengthLabel.Text = "The program length: ";
            // 
            // programVolumeLabel
            // 
            this.programVolumeLabel.AutoSize = true;
            this.programVolumeLabel.Font = new System.Drawing.Font("Lucida Fax", 11.25F);
            this.programVolumeLabel.Location = new System.Drawing.Point(6, 166);
            this.programVolumeLabel.Name = "programVolumeLabel";
            this.programVolumeLabel.Size = new System.Drawing.Size(177, 17);
            this.programVolumeLabel.TabIndex = 13;
            this.programVolumeLabel.Text = "The program volume: ";
            // 
            // theoreticalProgramLengthLabel
            // 
            this.theoreticalProgramLengthLabel.AutoSize = true;
            this.theoreticalProgramLengthLabel.Font = new System.Drawing.Font("Lucida Fax", 11.25F);
            this.theoreticalProgramLengthLabel.Location = new System.Drawing.Point(6, 216);
            this.theoreticalProgramLengthLabel.Name = "theoreticalProgramLengthLabel";
            this.theoreticalProgramLengthLabel.Size = new System.Drawing.Size(254, 17);
            this.theoreticalProgramLengthLabel.TabIndex = 16;
            this.theoreticalProgramLengthLabel.Text = "The theoretical program length: ";
            // 
            // theoreticalProgramVolumeLabel
            // 
            this.theoreticalProgramVolumeLabel.AutoSize = true;
            this.theoreticalProgramVolumeLabel.Font = new System.Drawing.Font("Lucida Fax", 11.25F);
            this.theoreticalProgramVolumeLabel.Location = new System.Drawing.Point(6, 236);
            this.theoreticalProgramVolumeLabel.Name = "theoreticalProgramVolumeLabel";
            this.theoreticalProgramVolumeLabel.Size = new System.Drawing.Size(262, 17);
            this.theoreticalProgramVolumeLabel.TabIndex = 17;
            this.theoreticalProgramVolumeLabel.Text = "The theoretical program volume: ";
            // 
            // levelOfProgrammingQualityLabel
            // 
            this.levelOfProgrammingQualityLabel.AutoSize = true;
            this.levelOfProgrammingQualityLabel.Font = new System.Drawing.Font("Lucida Fax", 11.25F);
            this.levelOfProgrammingQualityLabel.Location = new System.Drawing.Point(6, 266);
            this.levelOfProgrammingQualityLabel.Name = "levelOfProgrammingQualityLabel";
            this.levelOfProgrammingQualityLabel.Size = new System.Drawing.Size(273, 17);
            this.levelOfProgrammingQualityLabel.TabIndex = 18;
            this.levelOfProgrammingQualityLabel.Text = "The level of programming quality: ";
            // 
            // levelOfProgramQualityWithoutTPVLabel
            // 
            this.levelOfProgramQualityWithoutTPVLabel.AutoSize = true;
            this.levelOfProgramQualityWithoutTPVLabel.Font = new System.Drawing.Font("Lucida Fax", 11.25F);
            this.levelOfProgramQualityWithoutTPVLabel.Location = new System.Drawing.Point(6, 286);
            this.levelOfProgramQualityWithoutTPVLabel.Name = "levelOfProgramQualityWithoutTPVLabel";
            this.levelOfProgramQualityWithoutTPVLabel.Size = new System.Drawing.Size(552, 17);
            this.levelOfProgramQualityWithoutTPVLabel.TabIndex = 19;
            this.levelOfProgramQualityWithoutTPVLabel.Text = "The level of programming quality without theoretical program volume: ";
            // 
            // numberOfElementarySolutionsForWLabel
            // 
            this.numberOfElementarySolutionsForWLabel.AutoSize = true;
            this.numberOfElementarySolutionsForWLabel.Font = new System.Drawing.Font("Lucida Fax", 11.25F);
            this.numberOfElementarySolutionsForWLabel.Location = new System.Drawing.Point(6, 316);
            this.numberOfElementarySolutionsForWLabel.Name = "numberOfElementarySolutionsForWLabel";
            this.numberOfElementarySolutionsForWLabel.Size = new System.Drawing.Size(534, 17);
            this.numberOfElementarySolutionsForWLabel.TabIndex = 20;
            this.numberOfElementarySolutionsForWLabel.Text = "The number of required elementary solutions for writing a program: ";
            // 
            // numberOfElementarySolutionsForULabel
            // 
            this.numberOfElementarySolutionsForULabel.AutoSize = true;
            this.numberOfElementarySolutionsForULabel.Font = new System.Drawing.Font("Lucida Fax", 11.25F);
            this.numberOfElementarySolutionsForULabel.Location = new System.Drawing.Point(6, 336);
            this.numberOfElementarySolutionsForULabel.Name = "numberOfElementarySolutionsForULabel";
            this.numberOfElementarySolutionsForULabel.Size = new System.Drawing.Size(607, 17);
            this.numberOfElementarySolutionsForULabel.TabIndex = 21;
            this.numberOfElementarySolutionsForULabel.Text = "The number of required elementary solutions for understanding the program: ";
            // 
            // GB_MCM
            // 
            this.GB_MCM.BackColor = System.Drawing.Color.Ivory;
            this.GB_MCM.Controls.Add(this.cyclomaticComplexityLabel);
            this.GB_MCM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_MCM.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_MCM.ForeColor = System.Drawing.Color.Navy;
            this.GB_MCM.Location = new System.Drawing.Point(0, 0);
            this.GB_MCM.Margin = new System.Windows.Forms.Padding(0);
            this.GB_MCM.MaximumSize = new System.Drawing.Size(757, 87);
            this.GB_MCM.Name = "GB_MCM";
            this.GB_MCM.Size = new System.Drawing.Size(757, 87);
            this.GB_MCM.TabIndex = 22;
            this.GB_MCM.TabStop = false;
            this.GB_MCM.Text = "McCabe metric:";
            // 
            // GB_HM
            // 
            this.GB_HM.BackColor = System.Drawing.Color.Ivory;
            this.GB_HM.Controls.Add(this.numberOfDistinctOperatorsLabel);
            this.GB_HM.Controls.Add(this.totalNumberOfOperatorsLabel);
            this.GB_HM.Controls.Add(this.numberOfElementarySolutionsForULabel);
            this.GB_HM.Controls.Add(this.totalNumberOfOperandsLabel);
            this.GB_HM.Controls.Add(this.numberOfElementarySolutionsForWLabel);
            this.GB_HM.Controls.Add(this.numberOfDistinctOperandsLabel);
            this.GB_HM.Controls.Add(this.levelOfProgramQualityWithoutTPVLabel);
            this.GB_HM.Controls.Add(this.theoreticalProgramVocabularyLabel);
            this.GB_HM.Controls.Add(this.levelOfProgrammingQualityLabel);
            this.GB_HM.Controls.Add(this.programVocabularyLabel);
            this.GB_HM.Controls.Add(this.theoreticalProgramVolumeLabel);
            this.GB_HM.Controls.Add(this.programLengthLabel);
            this.GB_HM.Controls.Add(this.theoreticalProgramLengthLabel);
            this.GB_HM.Controls.Add(this.programVolumeLabel);
            this.GB_HM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_HM.Font = new System.Drawing.Font("Lucida Fax", 14.25F);
            this.GB_HM.ForeColor = System.Drawing.Color.Navy;
            this.GB_HM.Location = new System.Drawing.Point(0, 87);
            this.GB_HM.Margin = new System.Windows.Forms.Padding(0);
            this.GB_HM.MaximumSize = new System.Drawing.Size(757, 380);
            this.GB_HM.Name = "GB_HM";
            this.GB_HM.Size = new System.Drawing.Size(757, 380);
            this.GB_HM.TabIndex = 23;
            this.GB_HM.TabStop = false;
            this.GB_HM.Text = "Halstead metric:";
            // 
            // graphToolStripMenuItem
            // 
            this.graphToolStripMenuItem.Name = "graphToolStripMenuItem";
            this.graphToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.graphToolStripMenuItem.Text = "Graph";
            // 
            // TLP_Main
            // 
            this.TLP_Main.BackColor = System.Drawing.SystemColors.Window;
            this.TLP_Main.ColumnCount = 2;
            this.TLP_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 757F));
            this.TLP_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Main.Controls.Add(this.TLP_Metrics, 0, 3);
            this.TLP_Main.Controls.Add(this.GB_MI, 0, 2);
            this.TLP_Main.Controls.Add(this.sourceCodeTextBox, 1, 0);
            this.TLP_Main.Controls.Add(this.GB_HM, 0, 1);
            this.TLP_Main.Controls.Add(this.GB_MCM, 0, 0);
            this.TLP_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Main.Location = new System.Drawing.Point(0, 24);
            this.TLP_Main.Name = "TLP_Main";
            this.TLP_Main.RowCount = 4;
            this.TLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.TLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 380F));
            this.TLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.TLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Main.Size = new System.Drawing.Size(1301, 617);
            this.TLP_Main.TabIndex = 24;
            // 
            // GB_MI
            // 
            this.GB_MI.BackColor = System.Drawing.Color.Ivory;
            this.GB_MI.Controls.Add(this.indexOfCodeMaintainability);
            this.GB_MI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_MI.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_MI.ForeColor = System.Drawing.Color.Navy;
            this.GB_MI.Location = new System.Drawing.Point(0, 467);
            this.GB_MI.Margin = new System.Windows.Forms.Padding(0);
            this.GB_MI.MaximumSize = new System.Drawing.Size(757, 87);
            this.GB_MI.Name = "GB_MI";
            this.GB_MI.Size = new System.Drawing.Size(757, 87);
            this.GB_MI.TabIndex = 25;
            this.GB_MI.TabStop = false;
            this.GB_MI.Text = "Code maintainability:";
            // 
            // indexOfCodeMaintainability
            // 
            this.indexOfCodeMaintainability.AutoSize = true;
            this.indexOfCodeMaintainability.Font = new System.Drawing.Font("Lucida Fax", 11.25F);
            this.indexOfCodeMaintainability.Location = new System.Drawing.Point(6, 40);
            this.indexOfCodeMaintainability.Name = "indexOfCodeMaintainability";
            this.indexOfCodeMaintainability.Size = new System.Drawing.Size(273, 17);
            this.indexOfCodeMaintainability.TabIndex = 4;
            this.indexOfCodeMaintainability.Text = "The index of code maintainability: ";
            // 
            // TLP_Metrics
            // 
            this.TLP_Metrics.BackColor = System.Drawing.SystemColors.Window;
            this.TLP_Metrics.ColumnCount = 3;
            this.TLP_Metrics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TLP_Metrics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TLP_Metrics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TLP_Metrics.Controls.Add(this.mcCabeButton, 0, 0);
            this.TLP_Metrics.Controls.Add(this.halsteadButton, 1, 0);
            this.TLP_Metrics.Controls.Add(this.maintainabilityIndexButton, 2, 0);
            this.TLP_Metrics.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TLP_Metrics.Location = new System.Drawing.Point(0, 554);
            this.TLP_Metrics.Margin = new System.Windows.Forms.Padding(0);
            this.TLP_Metrics.MaximumSize = new System.Drawing.Size(757, 63);
            this.TLP_Metrics.Name = "TLP_Metrics";
            this.TLP_Metrics.RowCount = 1;
            this.TLP_Metrics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Metrics.Size = new System.Drawing.Size(757, 63);
            this.TLP_Metrics.TabIndex = 25;
            // 
            // maintainabilityIndexButton
            // 
            this.maintainabilityIndexButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maintainabilityIndexButton.Font = new System.Drawing.Font("Lucida Fax", 14.25F);
            this.maintainabilityIndexButton.Location = new System.Drawing.Point(507, 3);
            this.maintainabilityIndexButton.Name = "maintainabilityIndexButton";
            this.maintainabilityIndexButton.Size = new System.Drawing.Size(247, 57);
            this.maintainabilityIndexButton.TabIndex = 6;
            this.maintainabilityIndexButton.Text = "Maintainability Index";
            this.maintainabilityIndexButton.UseVisualStyleBackColor = true;
            this.maintainabilityIndexButton.Click += new System.EventHandler(this.maintainabilityIndexButton_Click);
            // 
            // CodeAnalyser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 641);
            this.Controls.Add(this.TLP_Main);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(1157, 680);
            this.Name = "CodeAnalyser";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Analyzer";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.GB_MCM.ResumeLayout(false);
            this.GB_MCM.PerformLayout();
            this.GB_HM.ResumeLayout(false);
            this.GB_HM.PerformLayout();
            this.TLP_Main.ResumeLayout(false);
            this.TLP_Main.PerformLayout();
            this.GB_MI.ResumeLayout(false);
            this.GB_MI.PerformLayout();
            this.TLP_Metrics.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sourceCodeTextBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button mcCabeButton;
        private System.Windows.Forms.Label cyclomaticComplexityLabel;
        private System.Windows.Forms.Button halsteadButton;
        private System.Windows.Forms.Label totalNumberOfOperatorsLabel;
        private System.Windows.Forms.Label numberOfDistinctOperatorsLabel;
        private System.Windows.Forms.Label totalNumberOfOperandsLabel;
        private System.Windows.Forms.Label numberOfDistinctOperandsLabel;
        private System.Windows.Forms.Label theoreticalProgramVocabularyLabel;
        private System.Windows.Forms.Label programVocabularyLabel;
        private System.Windows.Forms.Label programLengthLabel;
        private System.Windows.Forms.Label programVolumeLabel;
        private System.Windows.Forms.Label theoreticalProgramLengthLabel;
        private System.Windows.Forms.Label theoreticalProgramVolumeLabel;
        private System.Windows.Forms.Label levelOfProgrammingQualityLabel;
        private System.Windows.Forms.Label levelOfProgramQualityWithoutTPVLabel;
        private System.Windows.Forms.Label numberOfElementarySolutionsForWLabel;
        private System.Windows.Forms.Label numberOfElementarySolutionsForULabel;
        private System.Windows.Forms.GroupBox GB_MCM;
        private System.Windows.Forms.GroupBox GB_HM;
        private System.Windows.Forms.TableLayoutPanel TLP_Main;
        private System.Windows.Forms.TableLayoutPanel TLP_Metrics;
        private System.Windows.Forms.GroupBox GB_MI;
        private System.Windows.Forms.Label indexOfCodeMaintainability;
        private System.Windows.Forms.ToolStripMenuItem graphToolStripMenuItem;
        private System.Windows.Forms.Button maintainabilityIndexButton;
    }
}

