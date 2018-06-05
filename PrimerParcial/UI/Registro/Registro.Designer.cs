namespace PrimerParcial.UI.Registro
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label integrantesLabel;
            System.Windows.Forms.Label grupoIDLabel;
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label grupoLabel;
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.gruposBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.gruposBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.integrantesTextBox = new System.Windows.Forms.TextBox();
            this.grupoIDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cantidadNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.grupoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.gruposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            fechaLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            integrantesLabel = new System.Windows.Forms.Label();
            grupoIDLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            grupoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingNavigator)).BeginInit();
            this.gruposBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupoIDNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Buscarbutton.Image = global::PrimerParcial.Properties.Resources.buscar2;
            this.Buscarbutton.Location = new System.Drawing.Point(341, 16);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(91, 65);
            this.Buscarbutton.TabIndex = 3;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Buscarbutton.UseVisualStyleBackColor = false;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Eliminarbutton.Image = global::PrimerParcial.Properties.Resources.borrar_32;
            this.Eliminarbutton.Location = new System.Drawing.Point(293, 310);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(91, 65);
            this.Eliminarbutton.TabIndex = 2;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Eliminarbutton.UseVisualStyleBackColor = false;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Guardarbutton.Image = global::PrimerParcial.Properties.Resources.save_32;
            this.Guardarbutton.Location = new System.Drawing.Point(196, 310);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(91, 65);
            this.Guardarbutton.TabIndex = 1;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Guardarbutton.UseVisualStyleBackColor = false;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Nuevobutton.Image = global::PrimerParcial.Properties.Resources.new_32;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(99, 310);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(91, 65);
            this.Nuevobutton.TabIndex = 0;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Nuevobutton.UseVisualStyleBackColor = false;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // gruposBindingNavigator
            // 
            this.gruposBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.gruposBindingNavigator.BindingSource = this.gruposBindingSource;
            this.gruposBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.gruposBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.gruposBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.gruposBindingNavigatorSaveItem});
            this.gruposBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.gruposBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.gruposBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.gruposBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.gruposBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.gruposBindingNavigator.Name = "gruposBindingNavigator";
            this.gruposBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.gruposBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.gruposBindingNavigator.TabIndex = 4;
            this.gruposBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // gruposBindingNavigatorSaveItem
            // 
            this.gruposBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gruposBindingNavigatorSaveItem.Enabled = false;
            this.gruposBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("gruposBindingNavigatorSaveItem.Image")));
            this.gruposBindingNavigatorSaveItem.Name = "gruposBindingNavigatorSaveItem";
            this.gruposBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.gruposBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(58, 81);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 9;
            fechaLabel.Text = "Fecha:";
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.gruposBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(114, 74);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 10;
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(42, 116);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 11;
            descripcionLabel.Text = "Descripcion:";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gruposBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(114, 113);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(164, 75);
            this.descripcionTextBox.TabIndex = 12;
            // 
            // integrantesLabel
            // 
            integrantesLabel.AutoSize = true;
            integrantesLabel.Location = new System.Drawing.Point(60, 287);
            integrantesLabel.Name = "integrantesLabel";
            integrantesLabel.Size = new System.Drawing.Size(62, 13);
            integrantesLabel.TabIndex = 15;
            integrantesLabel.Text = "integrantes:";
            // 
            // integrantesTextBox
            // 
            this.integrantesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gruposBindingSource, "integrantes", true));
            this.integrantesTextBox.Location = new System.Drawing.Point(128, 284);
            this.integrantesTextBox.Name = "integrantesTextBox";
            this.integrantesTextBox.Size = new System.Drawing.Size(100, 20);
            this.integrantesTextBox.TabIndex = 16;
            // 
            // grupoIDLabel
            // 
            grupoIDLabel.AutoSize = true;
            grupoIDLabel.Location = new System.Drawing.Point(55, 28);
            grupoIDLabel.Name = "grupoIDLabel";
            grupoIDLabel.Size = new System.Drawing.Size(53, 13);
            grupoIDLabel.TabIndex = 16;
            grupoIDLabel.Text = "Grupo ID:";
            // 
            // grupoIDNumericUpDown
            // 
            this.grupoIDNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.gruposBindingSource, "GrupoID", true));
            this.grupoIDNumericUpDown.Location = new System.Drawing.Point(114, 28);
            this.grupoIDNumericUpDown.Name = "grupoIDNumericUpDown";
            this.grupoIDNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.grupoIDNumericUpDown.TabIndex = 17;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(56, 213);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(52, 13);
            cantidadLabel.TabIndex = 17;
            cantidadLabel.Text = "Cantidad:";
            // 
            // cantidadNumericUpDown
            // 
            this.cantidadNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.gruposBindingSource, "Cantidad", true));
            this.cantidadNumericUpDown.Location = new System.Drawing.Point(114, 213);
            this.cantidadNumericUpDown.Name = "cantidadNumericUpDown";
            this.cantidadNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.cantidadNumericUpDown.TabIndex = 18;
            // 
            // grupoLabel
            // 
            grupoLabel.AutoSize = true;
            grupoLabel.Location = new System.Drawing.Point(86, 255);
            grupoLabel.Name = "grupoLabel";
            grupoLabel.Size = new System.Drawing.Size(39, 13);
            grupoLabel.TabIndex = 18;
            grupoLabel.Text = "Grupo:";
            // 
            // grupoNumericUpDown
            // 
            this.grupoNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.gruposBindingSource, "Grupo", true));
            this.grupoNumericUpDown.Location = new System.Drawing.Point(131, 255);
            this.grupoNumericUpDown.Name = "grupoNumericUpDown";
            this.grupoNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.grupoNumericUpDown.TabIndex = 19;
       
            // 
            // gruposBindingSource
            // 
            this.gruposBindingSource.DataSource = typeof(PrimerParcial.Entidades.Grupos);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(grupoLabel);
            this.Controls.Add(this.grupoNumericUpDown);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(this.cantidadNumericUpDown);
            this.Controls.Add(grupoIDLabel);
            this.Controls.Add(this.grupoIDNumericUpDown);
            this.Controls.Add(integrantesLabel);
            this.Controls.Add(this.integrantesTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(this.gruposBindingNavigator);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Name = "Registro";
            this.Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingNavigator)).EndInit();
            this.gruposBindingNavigator.ResumeLayout(false);
            this.gruposBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupoIDNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.BindingSource gruposBindingSource;
        private System.Windows.Forms.BindingNavigator gruposBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton gruposBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox integrantesTextBox;
        private System.Windows.Forms.NumericUpDown grupoIDNumericUpDown;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NumericUpDown grupoNumericUpDown;
        private System.Windows.Forms.NumericUpDown cantidadNumericUpDown;
    }
}