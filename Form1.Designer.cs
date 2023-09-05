
namespace Prismo_Client
{
    partial class Form1
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
            if (disposing && (components != null))
            {
                components.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.labelATRando = new System.Windows.Forms.Label();
            this.buttonRandomize = new System.Windows.Forms.Button();
            this.checkBoxItemRando = new System.Windows.Forms.CheckBox();
            this.labelPrismo = new System.Windows.Forms.Label();
            this.checkBoxNPCRando = new System.Windows.Forms.CheckBox();
            this.checkBoxLSP = new System.Windows.Forms.CheckBox();
            this.checkBoxNMC = new System.Windows.Forms.CheckBox();
            this.checkBoxCBM = new System.Windows.Forms.CheckBox();
            this.comboBoxItemLogic = new System.Windows.Forms.ComboBox();
            this.comboBoxItemPool = new System.Windows.Forms.ComboBox();
            this.comboBoxNPCPool = new System.Windows.Forms.ComboBox();
            this.labelItemLogic = new System.Windows.Forms.Label();
            this.labelItemPool = new System.Windows.Forms.Label();
            this.labelNPCPool = new System.Windows.Forms.Label();
            this.folderBrowserDialogData = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxSeed = new System.Windows.Forms.TextBox();
            this.labelSeed = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.buttonData = new System.Windows.Forms.Button();
            this.checkBoxSpoilerLog = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("From Where You Are - AT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(782, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prismo\r\nAdventure Time: Secret of the Nameless Kingdom Randomizer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelATRando
            // 
            this.labelATRando.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelATRando.BackColor = System.Drawing.Color.Transparent;
            this.labelATRando.Font = new System.Drawing.Font("From Where You Are - AT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelATRando.Location = new System.Drawing.Point(0, 9);
            this.labelATRando.Name = "labelATRando";
            this.labelATRando.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelATRando.Size = new System.Drawing.Size(800, 82);
            this.labelATRando.TabIndex = 0;
            this.labelATRando.Text = "Prismo\r\nAdventure Time: Secret of the Nameless Kingdom Randomizer";
            this.labelATRando.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonRandomize
            // 
            this.buttonRandomize.AutoSize = true;
            this.buttonRandomize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.buttonRandomize.FlatAppearance.BorderSize = 2;
            this.buttonRandomize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRandomize.Font = new System.Drawing.Font("Adventure Time Logo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRandomize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(6)))));
            this.buttonRandomize.Location = new System.Drawing.Point(272, 395);
            this.buttonRandomize.Name = "buttonRandomize";
            this.buttonRandomize.Size = new System.Drawing.Size(248, 32);
            this.buttonRandomize.TabIndex = 1;
            this.buttonRandomize.Text = "Its Randomize Time";
            this.buttonRandomize.UseVisualStyleBackColor = false;
            // 
            // checkBoxItemRando
            // 
            this.checkBoxItemRando.AutoSize = true;
            this.checkBoxItemRando.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxItemRando.Checked = true;
            this.checkBoxItemRando.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxItemRando.FlatAppearance.BorderSize = 2;
            this.checkBoxItemRando.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxItemRando.Font = new System.Drawing.Font("From Where You Are - AT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxItemRando.Location = new System.Drawing.Point(150, 218);
            this.checkBoxItemRando.Name = "checkBoxItemRando";
            this.checkBoxItemRando.Size = new System.Drawing.Size(156, 25);
            this.checkBoxItemRando.TabIndex = 2;
            this.checkBoxItemRando.Text = "Item Randomization";
            this.checkBoxItemRando.UseVisualStyleBackColor = false;
            this.checkBoxItemRando.CheckedChanged += new System.EventHandler(this.checkBoxItemRando_CheckedChanged);
            // 
            // labelPrismo
            // 
            this.labelPrismo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPrismo.BackColor = System.Drawing.Color.Transparent;
            this.labelPrismo.Font = new System.Drawing.Font("Adventure Time Logo", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrismo.Location = new System.Drawing.Point(0, 8);
            this.labelPrismo.Name = "labelPrismo";
            this.labelPrismo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPrismo.Size = new System.Drawing.Size(800, 45);
            this.labelPrismo.TabIndex = 3;
            this.labelPrismo.Text = "Prismo";
            this.labelPrismo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxNPCRando
            // 
            this.checkBoxNPCRando.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxNPCRando.Checked = true;
            this.checkBoxNPCRando.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNPCRando.FlatAppearance.BorderSize = 2;
            this.checkBoxNPCRando.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxNPCRando.Font = new System.Drawing.Font("From Where You Are - AT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNPCRando.Location = new System.Drawing.Point(497, 218);
            this.checkBoxNPCRando.Name = "checkBoxNPCRando";
            this.checkBoxNPCRando.Size = new System.Drawing.Size(153, 25);
            this.checkBoxNPCRando.TabIndex = 4;
            this.checkBoxNPCRando.Text = "NPC Randomization";
            this.checkBoxNPCRando.UseVisualStyleBackColor = false;
            this.checkBoxNPCRando.CheckedChanged += new System.EventHandler(this.checkBoxNPCRando_CheckedChanged);
            // 
            // checkBoxLSP
            // 
            this.checkBoxLSP.AutoSize = true;
            this.checkBoxLSP.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxLSP.FlatAppearance.BorderSize = 2;
            this.checkBoxLSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxLSP.Font = new System.Drawing.Font("From Where You Are - AT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLSP.Location = new System.Drawing.Point(321, 329);
            this.checkBoxLSP.Name = "checkBoxLSP";
            this.checkBoxLSP.Size = new System.Drawing.Size(159, 25);
            this.checkBoxLSP.TabIndex = 5;
            this.checkBoxLSP.Text = "Randomize LSP Cave";
            this.checkBoxLSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxLSP.UseVisualStyleBackColor = false;
            // 
            // checkBoxNMC
            // 
            this.checkBoxNMC.AutoSize = true;
            this.checkBoxNMC.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxNMC.FlatAppearance.BorderSize = 2;
            this.checkBoxNMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxNMC.Font = new System.Drawing.Font("From Where You Are - AT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNMC.Location = new System.Drawing.Point(500, 329);
            this.checkBoxNMC.Name = "checkBoxNMC";
            this.checkBoxNMC.Size = new System.Drawing.Size(213, 25);
            this.checkBoxNMC.TabIndex = 6;
            this.checkBoxNMC.Text = "Randomize Nightmare Castle";
            this.checkBoxNMC.UseVisualStyleBackColor = false;
            // 
            // checkBoxCBM
            // 
            this.checkBoxCBM.AutoSize = true;
            this.checkBoxCBM.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxCBM.FlatAppearance.BorderSize = 2;
            this.checkBoxCBM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxCBM.Font = new System.Drawing.Font("From Where You Are - AT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCBM.Location = new System.Drawing.Point(95, 329);
            this.checkBoxCBM.Name = "checkBoxCBM";
            this.checkBoxCBM.Size = new System.Drawing.Size(205, 25);
            this.checkBoxCBM.TabIndex = 7;
            this.checkBoxCBM.Text = "Randomize Castle Basement";
            this.checkBoxCBM.UseVisualStyleBackColor = false;
            // 
            // comboBoxItemLogic
            // 
            this.comboBoxItemLogic.AllowDrop = true;
            this.comboBoxItemLogic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.comboBoxItemLogic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItemLogic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxItemLogic.Font = new System.Drawing.Font("From Where You Are - AT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxItemLogic.FormattingEnabled = true;
            this.comboBoxItemLogic.Items.AddRange(new object[] {
            "None",
            "Standard"});
            this.comboBoxItemLogic.Location = new System.Drawing.Point(185, 279);
            this.comboBoxItemLogic.MaxDropDownItems = 2;
            this.comboBoxItemLogic.Name = "comboBoxItemLogic";
            this.comboBoxItemLogic.Size = new System.Drawing.Size(92, 29);
            this.comboBoxItemLogic.TabIndex = 8;
            // 
            // comboBoxItemPool
            // 
            this.comboBoxItemPool.AllowDrop = true;
            this.comboBoxItemPool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.comboBoxItemPool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItemPool.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxItemPool.Font = new System.Drawing.Font("From Where You Are - AT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxItemPool.FormattingEnabled = true;
            this.comboBoxItemPool.Items.AddRange(new object[] {
            "Standard",
            "Expanded"});
            this.comboBoxItemPool.Location = new System.Drawing.Point(354, 279);
            this.comboBoxItemPool.MaxDropDownItems = 2;
            this.comboBoxItemPool.Name = "comboBoxItemPool";
            this.comboBoxItemPool.Size = new System.Drawing.Size(92, 29);
            this.comboBoxItemPool.TabIndex = 9;
            // 
            // comboBoxNPCPool
            // 
            this.comboBoxNPCPool.AllowDrop = true;
            this.comboBoxNPCPool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.comboBoxNPCPool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNPCPool.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxNPCPool.Font = new System.Drawing.Font("From Where You Are - AT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNPCPool.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxNPCPool.FormattingEnabled = true;
            this.comboBoxNPCPool.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxNPCPool.Items.AddRange(new object[] {
            "Standard",
            "Guntsanity"});
            this.comboBoxNPCPool.Location = new System.Drawing.Point(526, 279);
            this.comboBoxNPCPool.MaxDropDownItems = 2;
            this.comboBoxNPCPool.Name = "comboBoxNPCPool";
            this.comboBoxNPCPool.Size = new System.Drawing.Size(92, 29);
            this.comboBoxNPCPool.TabIndex = 10;
            // 
            // labelItemLogic
            // 
            this.labelItemLogic.AutoSize = true;
            this.labelItemLogic.BackColor = System.Drawing.Color.Transparent;
            this.labelItemLogic.Font = new System.Drawing.Font("From Where You Are - AT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemLogic.Location = new System.Drawing.Point(191, 255);
            this.labelItemLogic.Name = "labelItemLogic";
            this.labelItemLogic.Size = new System.Drawing.Size(80, 21);
            this.labelItemLogic.TabIndex = 11;
            this.labelItemLogic.Text = "Item Logic";
            // 
            // labelItemPool
            // 
            this.labelItemPool.BackColor = System.Drawing.Color.Transparent;
            this.labelItemPool.Font = new System.Drawing.Font("From Where You Are - AT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemPool.Location = new System.Drawing.Point(364, 255);
            this.labelItemPool.Name = "labelItemPool";
            this.labelItemPool.Size = new System.Drawing.Size(72, 21);
            this.labelItemPool.TabIndex = 12;
            this.labelItemPool.Text = "Item Pool";
            // 
            // labelNPCPool
            // 
            this.labelNPCPool.AutoSize = true;
            this.labelNPCPool.BackColor = System.Drawing.Color.Transparent;
            this.labelNPCPool.Font = new System.Drawing.Font("From Where You Are - AT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNPCPool.Location = new System.Drawing.Point(538, 255);
            this.labelNPCPool.Name = "labelNPCPool";
            this.labelNPCPool.Size = new System.Drawing.Size(68, 21);
            this.labelNPCPool.TabIndex = 13;
            this.labelNPCPool.Text = "NPC Pool";
            // 
            // textBoxSeed
            // 
            this.textBoxSeed.Location = new System.Drawing.Point(257, 190);
            this.textBoxSeed.Name = "textBoxSeed";
            this.textBoxSeed.Size = new System.Drawing.Size(286, 20);
            this.textBoxSeed.TabIndex = 14;
            // 
            // labelSeed
            // 
            this.labelSeed.BackColor = System.Drawing.Color.Transparent;
            this.labelSeed.Font = new System.Drawing.Font("From Where You Are - AT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeed.Location = new System.Drawing.Point(0, 166);
            this.labelSeed.Name = "labelSeed";
            this.labelSeed.Size = new System.Drawing.Size(800, 21);
            this.labelSeed.TabIndex = 15;
            this.labelSeed.Text = "Seed (Leave empty for random seed)";
            this.labelSeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelData
            // 
            this.labelData.BackColor = System.Drawing.Color.Transparent;
            this.labelData.Font = new System.Drawing.Font("From Where You Are - AT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.Location = new System.Drawing.Point(0, 111);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(800, 21);
            this.labelData.TabIndex = 16;
            this.labelData.Text = "Select SotNK data directory";
            this.labelData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Adventure Time Logo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(6)))));
            this.button1.Location = new System.Drawing.Point(272, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Its Randomize Time";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // buttonRandom
            // 
            this.buttonRandom.AutoSize = true;
            this.buttonRandom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.buttonRandom.CausesValidation = false;
            this.buttonRandom.FlatAppearance.BorderSize = 2;
            this.buttonRandom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRandom.Font = new System.Drawing.Font("Adventure Time Logo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRandom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(251)))));
            this.buttonRandom.Location = new System.Drawing.Point(272, 395);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(252, 36);
            this.buttonRandom.TabIndex = 1;
            this.buttonRandom.Text = "Its Randomize Time";
            this.buttonRandom.UseVisualStyleBackColor = false;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // textBoxData
            // 
            this.textBoxData.CausesValidation = false;
            this.textBoxData.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxData.Enabled = false;
            this.textBoxData.Location = new System.Drawing.Point(219, 135);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.ReadOnly = true;
            this.textBoxData.Size = new System.Drawing.Size(286, 20);
            this.textBoxData.TabIndex = 17;
            // 
            // buttonData
            // 
            this.buttonData.FlatAppearance.BorderSize = 0;
            this.buttonData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonData.Font = new System.Drawing.Font("From Where You Are - AT", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonData.Location = new System.Drawing.Point(505, 135);
            this.buttonData.Margin = new System.Windows.Forms.Padding(0);
            this.buttonData.Name = "buttonData";
            this.buttonData.Size = new System.Drawing.Size(76, 20);
            this.buttonData.TabIndex = 18;
            this.buttonData.Text = "Browse...";
            this.buttonData.UseVisualStyleBackColor = true;
            this.buttonData.Click += new System.EventHandler(this.buttonData_Click_1);
            // 
            // checkBoxSpoilerLog
            // 
            this.checkBoxSpoilerLog.AutoSize = true;
            this.checkBoxSpoilerLog.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxSpoilerLog.FlatAppearance.BorderSize = 2;
            this.checkBoxSpoilerLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxSpoilerLog.Font = new System.Drawing.Font("From Where You Are - AT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSpoilerLog.Location = new System.Drawing.Point(318, 367);
            this.checkBoxSpoilerLog.Name = "checkBoxSpoilerLog";
            this.checkBoxSpoilerLog.Size = new System.Drawing.Size(164, 25);
            this.checkBoxSpoilerLog.TabIndex = 19;
            this.checkBoxSpoilerLog.Text = "Generate Spoiler Log";
            this.checkBoxSpoilerLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxSpoilerLog.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Prismo_Client.Properties.Resources.prismo_background;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.checkBoxSpoilerLog);
            this.Controls.Add(this.buttonData);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelSeed);
            this.Controls.Add(this.textBoxSeed);
            this.Controls.Add(this.labelNPCPool);
            this.Controls.Add(this.labelItemPool);
            this.Controls.Add(this.labelItemLogic);
            this.Controls.Add(this.comboBoxNPCPool);
            this.Controls.Add(this.comboBoxItemPool);
            this.Controls.Add(this.comboBoxItemLogic);
            this.Controls.Add(this.checkBoxCBM);
            this.Controls.Add(this.checkBoxNMC);
            this.Controls.Add(this.checkBoxLSP);
            this.Controls.Add(this.checkBoxNPCRando);
            this.Controls.Add(this.labelPrismo);
            this.Controls.Add(this.checkBoxItemRando);
            this.Controls.Add(this.buttonRandom);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonRandomize);
            this.Controls.Add(this.labelATRando);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prismo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelATRando;
        private System.Windows.Forms.Button buttonRandomize;
        private System.Windows.Forms.CheckBox checkBoxItemRando;
        private System.Windows.Forms.Label labelPrismo;
        private System.Windows.Forms.CheckBox checkBoxNPCRando;
        private System.Windows.Forms.CheckBox checkBoxLSP;
        private System.Windows.Forms.CheckBox checkBoxNMC;
        private System.Windows.Forms.CheckBox checkBoxCBM;
        private System.Windows.Forms.ComboBox comboBoxItemLogic;
        private System.Windows.Forms.ComboBox comboBoxItemPool;
        private System.Windows.Forms.ComboBox comboBoxNPCPool;
        private System.Windows.Forms.Label labelItemLogic;
        private System.Windows.Forms.Label labelItemPool;
        private System.Windows.Forms.Label labelNPCPool;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogData;
        private System.Windows.Forms.TextBox textBoxSeed;
        private System.Windows.Forms.Label labelSeed;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.Button buttonData;
        private System.Windows.Forms.CheckBox checkBoxSpoilerLog;
    }
}

