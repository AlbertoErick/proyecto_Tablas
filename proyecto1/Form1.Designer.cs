﻿namespace proyecto1
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nombreLabel;
            this.postgresDataSet = new proyecto1.postgresDataSet();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriasTableAdapter = new proyecto1.postgresDataSetTableAdapters.categoriasTableAdapter();
            this.tableAdapterManager = new proyecto1.postgresDataSetTableAdapters.TableAdapterManager();
            this.categoriasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.categoriasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.postgresDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingNavigator)).BeginInit();
            this.categoriasBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // postgresDataSet
            // 
            this.postgresDataSet.DataSetName = "postgresDataSet";
            this.postgresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataMember = "categorias";
            this.categoriasBindingSource.DataSource = this.postgresDataSet;
            // 
            // categoriasTableAdapter
            // 
            this.categoriasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoriasTableAdapter = this.categoriasTableAdapter;
            this.tableAdapterManager.entradasTableAdapter = null;
            this.tableAdapterManager.inventariosTableAdapter = null;
            this.tableAdapterManager.productosTableAdapter = null;
            this.tableAdapterManager.ubicacionesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = proyecto1.postgresDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // categoriasBindingNavigator
            // 
            this.categoriasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.categoriasBindingNavigator.BindingSource = this.categoriasBindingSource;
            this.categoriasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.categoriasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.categoriasBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.categoriasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.categoriasBindingNavigatorSaveItem});
            this.categoriasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.categoriasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.categoriasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.categoriasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.categoriasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.categoriasBindingNavigator.Name = "categoriasBindingNavigator";
            this.categoriasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.categoriasBindingNavigator.Size = new System.Drawing.Size(372, 29);
            this.categoriasBindingNavigator.TabIndex = 0;
            this.categoriasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 26);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // categoriasBindingNavigatorSaveItem
            // 
            this.categoriasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.categoriasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("categoriasBindingNavigatorSaveItem.Image")));
            this.categoriasBindingNavigatorSaveItem.Name = "categoriasBindingNavigatorSaveItem";
            this.categoriasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.categoriasBindingNavigatorSaveItem.Text = "Save Data";
            this.categoriasBindingNavigatorSaveItem.Click += new System.EventHandler(this.categoriasBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(186, 60);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriasBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(252, 57);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 22);
            this.idTextBox.TabIndex = 2;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(186, 88);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(60, 17);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriasBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(252, 85);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 22);
            this.nombreTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 253);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.categoriasBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.postgresDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingNavigator)).EndInit();
            this.categoriasBindingNavigator.ResumeLayout(false);
            this.categoriasBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private postgresDataSet postgresDataSet;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private postgresDataSetTableAdapters.categoriasTableAdapter categoriasTableAdapter;
        private postgresDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator categoriasBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton categoriasBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
    }
}

