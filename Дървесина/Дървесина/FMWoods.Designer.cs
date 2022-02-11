
namespace Дървесина
{
    partial class FMWoods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMWoods));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.durvesinaDataSet = new Дървесина.DurvesinaDataSet();
            this.видBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.видTableAdapter = new Дървесина.DurvesinaDataSetTableAdapters.ВидTableAdapter();
            this.tableAdapterManager = new Дървесина.DurvesinaDataSetTableAdapters.TableAdapterManager();
            this.видBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.видBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.категорияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.категорияTableAdapter = new Дървесина.DurvesinaDataSetTableAdapters.КатегорияTableAdapter();
            this.сортиментBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сортиментTableAdapter = new Дървесина.DurvesinaDataSetTableAdapters.СортиментTableAdapter();
            this.дървесинаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.дървесинаTableAdapter = new Дървесина.DurvesinaDataSetTableAdapters.ДървесинаTableAdapter();
            this.дървесинаMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.видBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.клиентиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентиTableAdapter = new Дървесина.DurvesinaDataSetTableAdapters.КлиентиTableAdapter();
            this.категорияBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.сортиментBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.durvesinaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.видBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.видBindingNavigator)).BeginInit();
            this.видBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.категорияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сортиментBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.дървесинаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.дървесинаMetroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.видBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорияBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сортиментBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // durvesinaDataSet
            // 
            this.durvesinaDataSet.DataSetName = "DurvesinaDataSet";
            this.durvesinaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // видBindingSource
            // 
            this.видBindingSource.DataMember = "Вид";
            this.видBindingSource.DataSource = this.durvesinaDataSet;
            // 
            // видTableAdapter
            // 
            this.видTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Дървесина.DurvesinaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВидTableAdapter = this.видTableAdapter;
            this.tableAdapterManager.ДлъжностиTableAdapter = null;
            this.tableAdapterManager.ДървесинаTableAdapter = this.дървесинаTableAdapter;
            this.tableAdapterManager.Заявка_за_покупка_на_дървесинаTableAdapter = null;
            this.tableAdapterManager.Заявка_за_сеч_на_дървесинаTableAdapter = null;
            this.tableAdapterManager.КатегорияTableAdapter = this.категорияTableAdapter;
            this.tableAdapterManager.КлиентиTableAdapter = this.клиентиTableAdapter;
            this.tableAdapterManager.Обект_и_складовеTableAdapter = null;
            this.tableAdapterManager.Обект_Склад___дървесинаTableAdapter = null;
            this.tableAdapterManager.Превозен_билетTableAdapter = null;
            this.tableAdapterManager.Превозни_средстваTableAdapter = null;
            this.tableAdapterManager.СлужителиTableAdapter = null;
            this.tableAdapterManager.СортиментTableAdapter = this.сортиментTableAdapter;
            this.tableAdapterManager.ФактураTableAdapter = null;
            this.tableAdapterManager.ФирмиTableAdapter = null;
            // 
            // видBindingNavigator
            // 
            this.видBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.видBindingNavigator.BindingSource = this.видBindingSource;
            this.видBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.видBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.видBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.видBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.видBindingNavigatorSaveItem});
            this.видBindingNavigator.Location = new System.Drawing.Point(25, 94);
            this.видBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.видBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.видBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.видBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.видBindingNavigator.Name = "видBindingNavigator";
            this.видBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.видBindingNavigator.Size = new System.Drawing.Size(1009, 27);
            this.видBindingNavigator.TabIndex = 0;
            this.видBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(62, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // видBindingNavigatorSaveItem
            // 
            this.видBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.видBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("видBindingNavigatorSaveItem.Image")));
            this.видBindingNavigatorSaveItem.Name = "видBindingNavigatorSaveItem";
            this.видBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.видBindingNavigatorSaveItem.Text = "Save Data";
            this.видBindingNavigatorSaveItem.Click += new System.EventHandler(this.видBindingNavigatorSaveItem_Click_1);
            // 
            // категорияBindingSource
            // 
            this.категорияBindingSource.DataMember = "Категория";
            this.категорияBindingSource.DataSource = this.durvesinaDataSet;
            // 
            // категорияTableAdapter
            // 
            this.категорияTableAdapter.ClearBeforeFill = true;
            // 
            // сортиментBindingSource
            // 
            this.сортиментBindingSource.DataMember = "Сортимент";
            this.сортиментBindingSource.DataSource = this.durvesinaDataSet;
            // 
            // сортиментTableAdapter
            // 
            this.сортиментTableAdapter.ClearBeforeFill = true;
            // 
            // дървесинаBindingSource
            // 
            this.дървесинаBindingSource.DataMember = "Дървесина";
            this.дървесинаBindingSource.DataSource = this.durvesinaDataSet;
            // 
            // дървесинаTableAdapter
            // 
            this.дървесинаTableAdapter.ClearBeforeFill = true;
            // 
            // дървесинаMetroGrid
            // 
            this.дървесинаMetroGrid.AllowUserToResizeRows = false;
            this.дървесинаMetroGrid.AutoGenerateColumns = false;
            this.дървесинаMetroGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.дървесинаMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.дървесинаMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.дървесинаMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.дървесинаMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.дървесинаMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.дървесинаMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.дървесинаMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.дървесинаMetroGrid.DataSource = this.дървесинаBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.дървесинаMetroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.дървесинаMetroGrid.EnableHeadersVisualStyles = false;
            this.дървесинаMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.дървесинаMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.дървесинаMetroGrid.Location = new System.Drawing.Point(29, 166);
            this.дървесинаMetroGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.дървесинаMetroGrid.Name = "дървесинаMetroGrid";
            this.дървесинаMetroGrid.ReadOnly = true;
            this.дървесинаMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.дървесинаMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.дървесинаMetroGrid.RowHeadersVisible = false;
            this.дървесинаMetroGrid.RowHeadersWidth = 51;
            this.дървесинаMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.дървесинаMetroGrid.RowTemplate.Height = 24;
            this.дървесинаMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.дървесинаMetroGrid.Size = new System.Drawing.Size(1005, 276);
            this.дървесинаMetroGrid.TabIndex = 13;
            // 
            // видBindingSource1
            // 
            this.видBindingSource1.DataMember = "Вид";
            this.видBindingSource1.DataSource = this.durvesinaDataSet;
            // 
            // клиентиBindingSource
            // 
            this.клиентиBindingSource.DataMember = "Клиенти";
            this.клиентиBindingSource.DataSource = this.durvesinaDataSet;
            // 
            // клиентиTableAdapter
            // 
            this.клиентиTableAdapter.ClearBeforeFill = true;
            // 
            // категорияBindingSource1
            // 
            this.категорияBindingSource1.DataMember = "Категория";
            this.категорияBindingSource1.DataSource = this.durvesinaDataSet;
            // 
            // сортиментBindingSource1
            // 
            this.сортиментBindingSource1.DataMember = "Сортимент";
            this.сортиментBindingSource1.DataSource = this.durvesinaDataSet;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_Дървесина";
            this.dataGridViewTextBoxColumn2.FillWeight = 21.39038F;
            this.dataGridViewTextBoxColumn2.HeaderText = "ID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Вид";
            this.dataGridViewTextBoxColumn1.DataSource = this.видBindingSource1;
            this.dataGridViewTextBoxColumn1.DisplayMember = "Име_Вид";
            this.dataGridViewTextBoxColumn1.FillWeight = 126.2032F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Вид";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn1.ValueMember = "ID_Вид";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Категория";
            this.dataGridViewTextBoxColumn3.DataSource = this.категорияBindingSource1;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Име_Категория";
            this.dataGridViewTextBoxColumn3.FillWeight = 126.2032F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Категория";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "ID_Категория";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Сортимент";
            this.dataGridViewTextBoxColumn4.DataSource = this.сортиментBindingSource1;
            this.dataGridViewTextBoxColumn4.DisplayMember = "Име_Сортимент";
            this.dataGridViewTextBoxColumn4.FillWeight = 126.2032F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Сортимент";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "ID_Сортимент";
            // 
            // FMWoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 488);
            this.Controls.Add(this.дървесинаMetroGrid);
            this.Controls.Add(this.видBindingNavigator);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FMWoods";
            this.Padding = new System.Windows.Forms.Padding(25, 94, 25, 31);
            this.Text = "Дървесина";
            this.Load += new System.EventHandler(this.FMWoods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.durvesinaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.видBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.видBindingNavigator)).EndInit();
            this.видBindingNavigator.ResumeLayout(false);
            this.видBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.категорияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сортиментBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.дървесинаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.дървесинаMetroGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.видBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорияBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сортиментBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DurvesinaDataSet durvesinaDataSet;
        private System.Windows.Forms.BindingSource видBindingSource;
        private DurvesinaDataSetTableAdapters.ВидTableAdapter видTableAdapter;
        private DurvesinaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator видBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton видBindingNavigatorSaveItem;
        private DurvesinaDataSetTableAdapters.КатегорияTableAdapter категорияTableAdapter;
        private System.Windows.Forms.BindingSource категорияBindingSource;
        private DurvesinaDataSetTableAdapters.СортиментTableAdapter сортиментTableAdapter;
        private System.Windows.Forms.BindingSource сортиментBindingSource;
        private DurvesinaDataSetTableAdapters.ДървесинаTableAdapter дървесинаTableAdapter;
        private System.Windows.Forms.BindingSource дървесинаBindingSource;
        private MetroFramework.Controls.MetroGrid дървесинаMetroGrid;
        private DurvesinaDataSetTableAdapters.КлиентиTableAdapter клиентиTableAdapter;
        private System.Windows.Forms.BindingSource видBindingSource1;
        private System.Windows.Forms.BindingSource клиентиBindingSource;
        private System.Windows.Forms.BindingSource категорияBindingSource1;
        private System.Windows.Forms.BindingSource сортиментBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
    }
}