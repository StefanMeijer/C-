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
            System.Windows.Forms.Label bedrijfsnaamLabel;
            this.bedrijfBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new Verhuur_van_speedboten.DatabaseDataSet();
            this.bedrijfTableAdapter = new Verhuur_van_speedboten.DatabaseDataSetTableAdapters.BedrijfTableAdapter();
            this.tableAdapterManager = new Verhuur_van_speedboten.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.bedrijfsnaamTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            bedrijfsnaamLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bedrijfBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bedrijfsnaamLabel
            // 
            bedrijfsnaamLabel.AutoSize = true;
            bedrijfsnaamLabel.Location = new System.Drawing.Point(6, 14);
            bedrijfsnaamLabel.Name = "bedrijfsnaamLabel";
            bedrijfsnaamLabel.Size = new System.Drawing.Size(69, 13);
            bedrijfsnaamLabel.TabIndex = 2;
            bedrijfsnaamLabel.Text = "bedrijfsnaam:";
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
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(bedrijfsnaamLabel);
            this.tabPage1.Controls.Add(this.bedrijfsnaamTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(789, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bedrijf";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bedrijfsnaamTextBox
            // 
            this.bedrijfsnaamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bedrijfBindingSource, "bedrijfsnaam", true));
            this.bedrijfsnaamTextBox.Location = new System.Drawing.Point(81, 11);
            this.bedrijfsnaamTextBox.Name = "bedrijfsnaamTextBox";
            this.bedrijfsnaamTextBox.Size = new System.Drawing.Size(100, 20);
            this.bedrijfsnaamTextBox.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(789, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Verhuur";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(789, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Speedboot";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(38, 120);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bedrijfBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource bedrijfBindingSource;
        private DatabaseDataSetTableAdapters.BedrijfTableAdapter bedrijfTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox bedrijfsnaamTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

