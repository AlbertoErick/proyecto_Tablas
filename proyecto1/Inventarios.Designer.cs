namespace proyecto1
{
    partial class Inventarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventarios));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nu_productoLabel;
            System.Windows.Forms.Label nu_ubicacionLabel;
            System.Windows.Forms.Label cantidadLabel;
            this.postgresDataSet = new proyecto1.postgresDataSet();
            this.inventariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventariosTableAdapter = new proyecto1.postgresDataSetTableAdapters.inventariosTableAdapter();
            this.tableAdapterManager = new proyecto1.postgresDataSetTableAdapters.TableAdapterManager();
            this.inventariosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.inventariosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nu_productoTextBox = new System.Windows.Forms.TextBox();
            this.nu_ubicacionTextBox = new System.Windows.Forms.TextBox();
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            nu_productoLabel = new System.Windows.Forms.Label();
            nu_ubicacionLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.postgresDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventariosBindingNavigator)).BeginInit();
            this.inventariosBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // postgresDataSet
            // 
            this.postgresDataSet.DataSetName = "postgresDataSet";
            this.postgresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventariosBindingSource
            // 
            this.inventariosBindingSource.DataMember = "inventarios";
            this.inventariosBindingSource.DataSource = this.postgresDataSet;
            // 
            // inventariosTableAdapter
            // 
            this.inventariosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoriasTableAdapter = null;
            this.tableAdapterManager.entradasTableAdapter = null;
            this.tableAdapterManager.inventariosTableAdapter = this.inventariosTableAdapter;
            this.tableAdapterManager.productosTableAdapter = null;
            this.tableAdapterManager.ubicacionesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = proyecto1.postgresDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // inventariosBindingNavigator
            // 
            this.inventariosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.inventariosBindingNavigator.BindingSource = this.inventariosBindingSource;
            this.inventariosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.inventariosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.inventariosBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.inventariosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.inventariosBindingNavigatorSaveItem});
            this.inventariosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.inventariosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.inventariosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.inventariosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.inventariosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.inventariosBindingNavigator.Name = "inventariosBindingNavigator";
            this.inventariosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.inventariosBindingNavigator.Size = new System.Drawing.Size(411, 27);
            this.inventariosBindingNavigator.TabIndex = 0;
            this.inventariosBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
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
            // inventariosBindingNavigatorSaveItem
            // 
            this.inventariosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.inventariosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("inventariosBindingNavigatorSaveItem.Image")));
            this.inventariosBindingNavigatorSaveItem.Name = "inventariosBindingNavigatorSaveItem";
            this.inventariosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.inventariosBindingNavigatorSaveItem.Text = "Save Data";
            this.inventariosBindingNavigatorSaveItem.Click += new System.EventHandler(this.inventariosBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(193, 69);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventariosBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(291, 66);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 22);
            this.idTextBox.TabIndex = 2;
            // 
            // nu_productoLabel
            // 
            nu_productoLabel.AutoSize = true;
            nu_productoLabel.Location = new System.Drawing.Point(193, 97);
            nu_productoLabel.Name = "nu_productoLabel";
            nu_productoLabel.Size = new System.Drawing.Size(88, 17);
            nu_productoLabel.TabIndex = 3;
            nu_productoLabel.Text = "nu producto:";
            // 
            // nu_productoTextBox
            // 
            this.nu_productoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventariosBindingSource, "nu_producto", true));
            this.nu_productoTextBox.Location = new System.Drawing.Point(291, 94);
            this.nu_productoTextBox.Name = "nu_productoTextBox";
            this.nu_productoTextBox.Size = new System.Drawing.Size(100, 22);
            this.nu_productoTextBox.TabIndex = 4;
            // 
            // nu_ubicacionLabel
            // 
            nu_ubicacionLabel.AutoSize = true;
            nu_ubicacionLabel.Location = new System.Drawing.Point(193, 125);
            nu_ubicacionLabel.Name = "nu_ubicacionLabel";
            nu_ubicacionLabel.Size = new System.Drawing.Size(92, 17);
            nu_ubicacionLabel.TabIndex = 5;
            nu_ubicacionLabel.Text = "nu ubicacion:";
            // 
            // nu_ubicacionTextBox
            // 
            this.nu_ubicacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventariosBindingSource, "nu_ubicacion", true));
            this.nu_ubicacionTextBox.Location = new System.Drawing.Point(291, 122);
            this.nu_ubicacionTextBox.Name = "nu_ubicacionTextBox";
            this.nu_ubicacionTextBox.Size = new System.Drawing.Size(100, 22);
            this.nu_ubicacionTextBox.TabIndex = 6;
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(193, 153);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(81, 17);
            cantidadLabel.TabIndex = 7;
            cantidadLabel.Text = "cantidades:";
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventariosBindingSource, "cantidad", true));
            this.cantidadTextBox.Location = new System.Drawing.Point(291, 150);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(100, 22);
            this.cantidadTextBox.TabIndex = 8;
            // 
            // Inventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 253);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nu_productoLabel);
            this.Controls.Add(this.nu_productoTextBox);
            this.Controls.Add(nu_ubicacionLabel);
            this.Controls.Add(this.nu_ubicacionTextBox);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(this.cantidadTextBox);
            this.Controls.Add(this.inventariosBindingNavigator);
            this.Name = "Inventarios";
            this.Text = "Inventarios";
            this.Load += new System.EventHandler(this.Inventarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.postgresDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventariosBindingNavigator)).EndInit();
            this.inventariosBindingNavigator.ResumeLayout(false);
            this.inventariosBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private postgresDataSet postgresDataSet;
        private System.Windows.Forms.BindingSource inventariosBindingSource;
        private postgresDataSetTableAdapters.inventariosTableAdapter inventariosTableAdapter;
        private postgresDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator inventariosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton inventariosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nu_productoTextBox;
        private System.Windows.Forms.TextBox nu_ubicacionTextBox;
        private System.Windows.Forms.TextBox cantidadTextBox;
    }
}