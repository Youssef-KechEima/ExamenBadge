﻿namespace ExamenBadge
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
            this.btnBadge = new System.Windows.Forms.Button();
            this.btnConvocation = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.badgeDataSet = new ExamenBadge.BadgeDataSet();
            this.tableAdapterManager = new ExamenBadge.BadgeDataSetTableAdapters.TableAdapterManager();
            this.groupeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupeTableAdapter = new ExamenBadge.BadgeDataSetTableAdapters.GroupeTableAdapter();
            this.groupeComboBox = new System.Windows.Forms.ComboBox();
            this.stagiaireBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stagiaireTableAdapter = new ExamenBadge.BadgeDataSetTableAdapters.StagiaireTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.badgeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stagiaireBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBadge
            // 
            this.btnBadge.Location = new System.Drawing.Point(112, 166);
            this.btnBadge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBadge.Name = "btnBadge";
            this.btnBadge.Size = new System.Drawing.Size(267, 44);
            this.btnBadge.TabIndex = 0;
            this.btnBadge.Text = "ImprimerBadge";
            this.btnBadge.UseVisualStyleBackColor = true;
            this.btnBadge.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConvocation
            // 
            this.btnConvocation.Location = new System.Drawing.Point(112, 217);
            this.btnConvocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConvocation.Name = "btnConvocation";
            this.btnConvocation.Size = new System.Drawing.Size(267, 44);
            this.btnConvocation.TabIndex = 0;
            this.btnConvocation.Text = "ImprimerConvocation";
            this.btnConvocation.UseVisualStyleBackColor = true;
            this.btnConvocation.Click += new System.EventHandler(this.btnInvocation_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(112, 266);
            this.btnList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(267, 44);
            this.btnList.TabIndex = 0;
            this.btnList.Text = "ImprimerListe";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // badgeDataSet
            // 
            this.badgeDataSet.DataSetName = "BadgeDataSet";
            this.badgeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StagiaireTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ExamenBadge.BadgeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // groupeComboBox
            // 
            this.groupeComboBox.DataSource = this.groupeBindingSource;
            this.groupeComboBox.DisplayMember = "NomGroupe";
            this.groupeComboBox.FormattingEnabled = true;
            this.groupeComboBox.Location = new System.Drawing.Point(43, 91);
            this.groupeComboBox.Name = "groupeComboBox";
            this.groupeComboBox.Size = new System.Drawing.Size(423, 24);
            this.groupeComboBox.TabIndex = 3;
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
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnConvocation);
            this.Controls.Add(this.btnBadge);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.badgeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stagiaireBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBadge;
        private System.Windows.Forms.Button btnConvocation;
        private System.Windows.Forms.Button btnList;
        private BadgeDataSet badgeDataSet;
        private BadgeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource groupeBindingSource;
        private BadgeDataSetTableAdapters.GroupeTableAdapter groupeTableAdapter;
        private System.Windows.Forms.ComboBox groupeComboBox;
        private System.Windows.Forms.BindingSource stagiaireBindingSource;
        private BadgeDataSetTableAdapters.StagiaireTableAdapter stagiaireTableAdapter;
    }
}

