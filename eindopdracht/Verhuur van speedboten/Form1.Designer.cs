namespace Verhuur_van_speedboten
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bedrijfBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new Verhuur_van_speedboten.DatabaseDataSet();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.bedrijfLabel = new System.Windows.Forms.Label();
            this.korstVerhuurdeLabel = new System.Windows.Forms.Label();
            this.percentageSchadeLabel = new System.Windows.Forms.Label();
            this.hoogstebrandstofLabel = new System.Windows.Forms.Label();
            this.verhuurtijdLabel = new System.Windows.Forms.Label();
            this.omzetLabel = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.verhuurd = new System.Windows.Forms.Label();
            this.schadeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.verhuurBootButton = new System.Windows.Forms.Button();
            this.eindtijd = new System.Windows.Forms.TextBox();
            this.aanvangstijd = new System.Windows.Forms.TextBox();
            this.verbruikteliters = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.botenComboLijst = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.beschikbareBoten = new System.Windows.Forms.Label();
            this.speedbotenlabel = new System.Windows.Forms.Label();
            this.headlabel1 = new System.Windows.Forms.Label();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bedrijfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verhuurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speedbotenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bedrijfTableAdapter = new Verhuur_van_speedboten.DatabaseDataSetTableAdapters.BedrijfTableAdapter();
            this.tableAdapterManager = new Verhuur_van_speedboten.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bedrijfBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bedrijfBindingSource
            // 
            this.bedrijfBindingSource.DataMember = "Bedrijf";
            this.bedrijfBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(797, 447);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.ContextMenuStrip = this.contextMenuStrip;
            this.tabPage1.Controls.Add(this.bedrijfLabel);
            this.tabPage1.Controls.Add(this.korstVerhuurdeLabel);
            this.tabPage1.Controls.Add(this.percentageSchadeLabel);
            this.tabPage1.Controls.Add(this.hoogstebrandstofLabel);
            this.tabPage1.Controls.Add(this.verhuurtijdLabel);
            this.tabPage1.Controls.Add(this.omzetLabel);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(789, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bedrijf";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox2,
            this.toolStripMenuItem1,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(144, 92);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.toolStripMenuItem1.Text = "About";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(143, 22);
            this.toolStripMenuItem4.Text = "Open";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(143, 22);
            this.toolStripMenuItem5.Text = "Close";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // bedrijfLabel
            // 
            this.bedrijfLabel.AutoSize = true;
            this.bedrijfLabel.BackColor = System.Drawing.Color.SkyBlue;
            this.bedrijfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bedrijfLabel.Location = new System.Drawing.Point(92, 7);
            this.bedrijfLabel.Name = "bedrijfLabel";
            this.bedrijfLabel.Size = new System.Drawing.Size(130, 24);
            this.bedrijfLabel.TabIndex = 24;
            this.bedrijfLabel.Text = "Bedrijfsnaam";
            // 
            // korstVerhuurdeLabel
            // 
            this.korstVerhuurdeLabel.AutoSize = true;
            this.korstVerhuurdeLabel.Location = new System.Drawing.Point(183, 165);
            this.korstVerhuurdeLabel.Name = "korstVerhuurdeLabel";
            this.korstVerhuurdeLabel.Size = new System.Drawing.Size(72, 13);
            this.korstVerhuurdeLabel.TabIndex = 19;
            this.korstVerhuurdeLabel.Text = "Bootnummer: ";
            // 
            // percentageSchadeLabel
            // 
            this.percentageSchadeLabel.AutoSize = true;
            this.percentageSchadeLabel.Location = new System.Drawing.Point(183, 136);
            this.percentageSchadeLabel.Name = "percentageSchadeLabel";
            this.percentageSchadeLabel.Size = new System.Drawing.Size(21, 13);
            this.percentageSchadeLabel.TabIndex = 18;
            this.percentageSchadeLabel.Text = "0%";
            // 
            // hoogstebrandstofLabel
            // 
            this.hoogstebrandstofLabel.AutoSize = true;
            this.hoogstebrandstofLabel.Location = new System.Drawing.Point(223, 107);
            this.hoogstebrandstofLabel.Name = "hoogstebrandstofLabel";
            this.hoogstebrandstofLabel.Size = new System.Drawing.Size(72, 13);
            this.hoogstebrandstofLabel.TabIndex = 17;
            this.hoogstebrandstofLabel.Text = "Bootnummer: ";
            // 
            // verhuurtijdLabel
            // 
            this.verhuurtijdLabel.AutoSize = true;
            this.verhuurtijdLabel.Location = new System.Drawing.Point(183, 78);
            this.verhuurtijdLabel.Name = "verhuurtijdLabel";
            this.verhuurtijdLabel.Size = new System.Drawing.Size(34, 13);
            this.verhuurtijdLabel.TabIndex = 16;
            this.verhuurtijdLabel.Text = "00:00";
            // 
            // omzetLabel
            // 
            this.omzetLabel.AutoSize = true;
            this.omzetLabel.Location = new System.Drawing.Point(183, 49);
            this.omzetLabel.Name = "omzetLabel";
            this.omzetLabel.Size = new System.Drawing.Size(13, 13);
            this.omzetLabel.TabIndex = 15;
            this.omzetLabel.Text = "0";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 160);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(174, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "Krijg kortst verhuurde boot";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 131);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Krijg percentage schadeboten";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(214, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Krijg boot met hoogste brandstof verbruik";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Krijg totale verhuurtijd";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Krijg totale omzet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Thistle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Bedrijf";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.verhuurd);
            this.tabPage2.Controls.Add(this.schadeComboBox);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.verhuurBootButton);
            this.tabPage2.Controls.Add(this.eindtijd);
            this.tabPage2.Controls.Add(this.aanvangstijd);
            this.tabPage2.Controls.Add(this.verbruikteliters);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.botenComboLijst);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(789, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Verhuur";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // verhuurd
            // 
            this.verhuurd.AutoSize = true;
            this.verhuurd.BackColor = System.Drawing.Color.SkyBlue;
            this.verhuurd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verhuurd.Location = new System.Drawing.Point(106, 7);
            this.verhuurd.Name = "verhuurd";
            this.verhuurd.Size = new System.Drawing.Size(169, 24);
            this.verhuurd.TabIndex = 23;
            this.verhuurd.Text = "Totaal verhuurd: ";
            // 
            // schadeComboBox
            // 
            this.schadeComboBox.FormattingEnabled = true;
            this.schadeComboBox.Items.AddRange(new object[] {
            "true",
            "false"});
            this.schadeComboBox.Location = new System.Drawing.Point(3, 226);
            this.schadeComboBox.Name = "schadeComboBox";
            this.schadeComboBox.Size = new System.Drawing.Size(121, 21);
            this.schadeComboBox.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Heeft de boot schade opgelopen?";
            // 
            // verhuurBootButton
            // 
            this.verhuurBootButton.Location = new System.Drawing.Point(3, 253);
            this.verhuurBootButton.Name = "verhuurBootButton";
            this.verhuurBootButton.Size = new System.Drawing.Size(100, 23);
            this.verhuurBootButton.TabIndex = 19;
            this.verhuurBootButton.Text = "Verhuur boot";
            this.verhuurBootButton.UseVisualStyleBackColor = true;
            this.verhuurBootButton.Click += new System.EventHandler(this.verhuurBootButton_Click);
            // 
            // eindtijd
            // 
            this.eindtijd.Location = new System.Drawing.Point(3, 142);
            this.eindtijd.Name = "eindtijd";
            this.eindtijd.Size = new System.Drawing.Size(100, 20);
            this.eindtijd.TabIndex = 18;
            // 
            // aanvangstijd
            // 
            this.aanvangstijd.Location = new System.Drawing.Point(3, 98);
            this.aanvangstijd.Name = "aanvangstijd";
            this.aanvangstijd.Size = new System.Drawing.Size(100, 20);
            this.aanvangstijd.TabIndex = 17;
            this.aanvangstijd.Tag = "";
            // 
            // verbruikteliters
            // 
            this.verbruikteliters.Location = new System.Drawing.Point(3, 187);
            this.verbruikteliters.Name = "verbruikteliters";
            this.verbruikteliters.Size = new System.Drawing.Size(100, 20);
            this.verbruikteliters.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Verbruikte liters";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Eindtijd";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Aanvangstijd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Thistle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Verhuur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Selecteer boot";
            // 
            // botenComboLijst
            // 
            this.botenComboLijst.FormattingEnabled = true;
            this.botenComboLijst.Location = new System.Drawing.Point(3, 58);
            this.botenComboLijst.Name = "botenComboLijst";
            this.botenComboLijst.Size = new System.Drawing.Size(121, 21);
            this.botenComboLijst.TabIndex = 6;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.beschikbareBoten);
            this.tabPage3.Controls.Add(this.speedbotenlabel);
            this.tabPage3.Controls.Add(this.headlabel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(789, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Speedboot";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // beschikbareBoten
            // 
            this.beschikbareBoten.AutoSize = true;
            this.beschikbareBoten.BackColor = System.Drawing.Color.SkyBlue;
            this.beschikbareBoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beschikbareBoten.Location = new System.Drawing.Point(155, 7);
            this.beschikbareBoten.Name = "beschikbareBoten";
            this.beschikbareBoten.Size = new System.Drawing.Size(195, 24);
            this.beschikbareBoten.TabIndex = 21;
            this.beschikbareBoten.Text = "Boten beschikbaar: ";
            // 
            // speedbotenlabel
            // 
            this.speedbotenlabel.AutoSize = true;
            this.speedbotenlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedbotenlabel.Location = new System.Drawing.Point(6, 42);
            this.speedbotenlabel.Name = "speedbotenlabel";
            this.speedbotenlabel.Size = new System.Drawing.Size(257, 20);
            this.speedbotenlabel.TabIndex = 1;
            this.speedbotenlabel.Text = "Nog geen speedboten beschikbaar";
            // 
            // headlabel1
            // 
            this.headlabel1.AutoSize = true;
            this.headlabel1.BackColor = System.Drawing.Color.Thistle;
            this.headlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headlabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.headlabel1.Location = new System.Drawing.Point(3, 3);
            this.headlabel1.Name = "headlabel1";
            this.headlabel1.Size = new System.Drawing.Size(146, 29);
            this.headlabel1.TabIndex = 0;
            this.headlabel1.Text = "Speedboten";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem2.Text = "Open";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem3.Text = "Close";
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bedrijfToolStripMenuItem,
            this.verhuurToolStripMenuItem,
            this.speedbotenToolStripMenuItem});
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(143, 22);
            this.toolStripComboBox2.Text = "Open tabblat";
            // 
            // bedrijfToolStripMenuItem
            // 
            this.bedrijfToolStripMenuItem.Name = "bedrijfToolStripMenuItem";
            this.bedrijfToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bedrijfToolStripMenuItem.Text = "Bedrijf";
            this.bedrijfToolStripMenuItem.Click += new System.EventHandler(this.bedrijfToolStripMenuItem_Click);
            // 
            // verhuurToolStripMenuItem
            // 
            this.verhuurToolStripMenuItem.Name = "verhuurToolStripMenuItem";
            this.verhuurToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verhuurToolStripMenuItem.Text = "Verhuur";
            this.verhuurToolStripMenuItem.Click += new System.EventHandler(this.verhuurToolStripMenuItem_Click);
            // 
            // speedbotenToolStripMenuItem
            // 
            this.speedbotenToolStripMenuItem.Name = "speedbotenToolStripMenuItem";
            this.speedbotenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.speedbotenToolStripMenuItem.Text = "Speedboten";
            this.speedbotenToolStripMenuItem.Click += new System.EventHandler(this.speedbotenToolStripMenuItem_Click);
            // 
            // bedrijfTableAdapter
            // 
            this.bedrijfTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BedrijfTableAdapter = this.bedrijfTableAdapter;
            this.tableAdapterManager.UpdateOrder = Verhuur_van_speedboten.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Speedbootverhuur";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Speedboten verhuur";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bedrijfBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource bedrijfBindingSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label speedbotenlabel;
        private System.Windows.Forms.Label headlabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox botenComboLijst;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox verbruikteliters;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox eindtijd;
        private System.Windows.Forms.TextBox aanvangstijd;
        private System.Windows.Forms.Label korstVerhuurdeLabel;
        private System.Windows.Forms.Label percentageSchadeLabel;
        private System.Windows.Forms.Label hoogstebrandstofLabel;
        private System.Windows.Forms.Label verhuurtijdLabel;
        private System.Windows.Forms.Label omzetLabel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button verhuurBootButton;
        private System.Windows.Forms.ComboBox schadeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label verhuurd;
        private System.Windows.Forms.Label beschikbareBoten;
        private System.Windows.Forms.Label bedrijfLabel;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripComboBox2;
        private System.Windows.Forms.ToolStripMenuItem bedrijfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verhuurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speedbotenToolStripMenuItem;
        private DatabaseDataSetTableAdapters.BedrijfTableAdapter bedrijfTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

