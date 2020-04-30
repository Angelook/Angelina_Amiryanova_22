namespace laba_9
{
    partial class Form5
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
            System.Windows.Forms.Label count_salesLabel;
            System.Windows.Forms.Label priceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label1 = new System.Windows.Forms.Label();
            this.bookssDataSet = new laba_9.bookssDataSet();
            this.composition_salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.composition_salesTableAdapter = new laba_9.bookssDataSetTableAdapters.composition_salesTableAdapter();
            this.tableAdapterManager = new laba_9.bookssDataSetTableAdapters.TableAdapterManager();
            this.composition_salesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.composition_salesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.count_salesTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            count_salesLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookssDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.composition_salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.composition_salesBindingNavigator)).BeginInit();
            this.composition_salesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // count_salesLabel
            // 
            count_salesLabel.AutoSize = true;
            count_salesLabel.Location = new System.Drawing.Point(122, 162);
            count_salesLabel.Name = "count_salesLabel";
            count_salesLabel.Size = new System.Drawing.Size(84, 17);
            count_salesLabel.TabIndex = 4;
            count_salesLabel.Text = "count sales:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(163, 204);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(43, 17);
            priceLabel.TabIndex = 5;
            priceLabel.Text = "price:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(99, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 81);
            this.label1.TabIndex = 3;
            this.label1.Text = "Таблица \"Заказы\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bookssDataSet
            // 
            this.bookssDataSet.DataSetName = "bookssDataSet";
            this.bookssDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // composition_salesBindingSource
            // 
            this.composition_salesBindingSource.DataMember = "composition_sales";
            this.composition_salesBindingSource.DataSource = this.bookssDataSet;
            // 
            // composition_salesTableAdapter
            // 
            this.composition_salesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.authorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.booksTableAdapter = null;
            this.tableAdapterManager.composition_salesTableAdapter = this.composition_salesTableAdapter;
            this.tableAdapterManager.publisherTableAdapter = null;
            this.tableAdapterManager.publishTableAdapter = null;
            this.tableAdapterManager.salesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = laba_9.bookssDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // composition_salesBindingNavigator
            // 
            this.composition_salesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.composition_salesBindingNavigator.BindingSource = this.composition_salesBindingSource;
            this.composition_salesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.composition_salesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.composition_salesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.composition_salesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.composition_salesBindingNavigatorSaveItem});
            this.composition_salesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.composition_salesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.composition_salesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.composition_salesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.composition_salesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.composition_salesBindingNavigator.Name = "composition_salesBindingNavigator";
            this.composition_salesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.composition_salesBindingNavigator.Size = new System.Drawing.Size(434, 27);
            this.composition_salesBindingNavigator.TabIndex = 4;
            this.composition_salesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // composition_salesBindingNavigatorSaveItem
            // 
            this.composition_salesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.composition_salesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("composition_salesBindingNavigatorSaveItem.Image")));
            this.composition_salesBindingNavigatorSaveItem.Name = "composition_salesBindingNavigatorSaveItem";
            this.composition_salesBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.composition_salesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.composition_salesBindingNavigatorSaveItem.Click += new System.EventHandler(this.composition_salesBindingNavigatorSaveItem_Click);
            // 
            // count_salesTextBox
            // 
            this.count_salesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.composition_salesBindingSource, "count_sales", true));
            this.count_salesTextBox.Location = new System.Drawing.Point(212, 159);
            this.count_salesTextBox.Name = "count_salesTextBox";
            this.count_salesTextBox.Size = new System.Drawing.Size(100, 22);
            this.count_salesTextBox.TabIndex = 5;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.composition_salesBindingSource, "price", true));
            this.priceTextBox.Location = new System.Drawing.Point(212, 201);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 22);
            this.priceTextBox.TabIndex = 6;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 307);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(count_salesLabel);
            this.Controls.Add(this.count_salesTextBox);
            this.Controls.Add(this.composition_salesBindingNavigator);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form5";
            this.Text = "Таблица Заказы";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookssDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.composition_salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.composition_salesBindingNavigator)).EndInit();
            this.composition_salesBindingNavigator.ResumeLayout(false);
            this.composition_salesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private bookssDataSet bookssDataSet;
        private System.Windows.Forms.BindingSource composition_salesBindingSource;
        private bookssDataSetTableAdapters.composition_salesTableAdapter composition_salesTableAdapter;
        private bookssDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator composition_salesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton composition_salesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox count_salesTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
    }
}