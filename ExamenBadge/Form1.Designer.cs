namespace ExamenBadge
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.badgeDataSet = new ExamenBadge.BadgeDataSet();
            this.groupeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupeTableAdapter = new ExamenBadge.BadgeDataSetTableAdapters.GroupeTableAdapter();
            this.tableAdapterManager = new ExamenBadge.BadgeDataSetTableAdapters.TableAdapterManager();
            this.groupeComboBox = new System.Windows.Forms.ComboBox();
            this.stagiaireBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stagiaireTableAdapter = new ExamenBadge.BadgeDataSetTableAdapters.StagiaireTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.badgeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stagiaireBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(112, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(266, 44);
            this.button2.TabIndex = 0;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(112, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(266, 44);
            this.button3.TabIndex = 0;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // badgeDataSet
            // 
            this.badgeDataSet.DataSetName = "BadgeDataSet";
            this.badgeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupeBindingSource
            // 
            this.groupeBindingSource.DataMember = "Groupe";
            this.groupeBindingSource.DataSource = this.badgeDataSet;
            // 
            // groupeTableAdapter
            // 
            this.groupeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GroupeTableAdapter = this.groupeTableAdapter;
            this.tableAdapterManager.StagiaireTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ExamenBadge.BadgeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupeComboBox
            // 
            this.groupeComboBox.DataSource = this.groupeBindingSource;
            this.groupeComboBox.DisplayMember = "NomGroupe";
            this.groupeComboBox.FormattingEnabled = true;
            this.groupeComboBox.Location = new System.Drawing.Point(12, 85);
            this.groupeComboBox.Name = "groupeComboBox";
            this.groupeComboBox.Size = new System.Drawing.Size(439, 24);
            this.groupeComboBox.TabIndex = 4;
            this.groupeComboBox.ValueMember = "IdGroupe";
            // 
            // stagiaireBindingSource
            // 
            this.stagiaireBindingSource.DataMember = "Stagiaire";
            this.stagiaireBindingSource.DataSource = this.badgeDataSet;
            // 
            // stagiaireTableAdapter
            // 
            this.stagiaireTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 393);
            this.Controls.Add(this.groupeComboBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.badgeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stagiaireBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private BadgeDataSet badgeDataSet;
        private System.Windows.Forms.BindingSource groupeBindingSource;
        private BadgeDataSetTableAdapters.GroupeTableAdapter groupeTableAdapter;
        private BadgeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox groupeComboBox;
        private System.Windows.Forms.BindingSource stagiaireBindingSource;
        private BadgeDataSetTableAdapters.StagiaireTableAdapter stagiaireTableAdapter;
    }
}

