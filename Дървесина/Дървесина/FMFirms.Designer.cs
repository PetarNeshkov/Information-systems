
namespace Дървесина
{
    partial class FMFirms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMFirms));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label iD_ФирмаLabel;
            System.Windows.Forms.Label имеLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label телефонен_номерLabel;
            System.Windows.Forms.Label градLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.durvesinaDataSet = new Дървесина.DurvesinaDataSet();
            this.фирмиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.фирмиTableAdapter = new Дървесина.DurvesinaDataSetTableAdapters.ФирмиTableAdapter();
            this.tableAdapterManager = new Дървесина.DurvesinaDataSetTableAdapters.TableAdapterManager();
            this.фирмиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.фирмиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.фирмиMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.iD_ФирмаTextBox = new System.Windows.Forms.TextBox();
            this.имеTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.телефонен_номерTextBox = new System.Windows.Forms.TextBox();
            this.градTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iD_ФирмаLabel = new System.Windows.Forms.Label();
            имеLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            телефонен_номерLabel = new System.Windows.Forms.Label();
            градLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.durvesinaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фирмиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фирмиBindingNavigator)).BeginInit();
            this.фирмиBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.фирмиMetroGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // durvesinaDataSet
            // 
            this.durvesinaDataSet.DataSetName = "DurvesinaDataSet";
            this.durvesinaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // фирмиBindingSource
            // 
            this.фирмиBindingSource.DataMember = "Фирми";
            this.фирмиBindingSource.DataSource = this.durvesinaDataSet;
            // 
            // фирмиTableAdapter
            // 
            this.фирмиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Дървесина.DurvesinaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВидTableAdapter = null;
            this.tableAdapterManager.ДлъжностиTableAdapter = null;
            this.tableAdapterManager.ДървесинаTableAdapter = null;
            this.tableAdapterManager.Заявка_за_покупка_на_дървесинаTableAdapter = null;
            this.tableAdapterManager.Заявка_за_сеч_на_дървесинаTableAdapter = null;
            this.tableAdapterManager.КатегорияTableAdapter = null;
            this.tableAdapterManager.КлиентиTableAdapter = null;
            this.tableAdapterManager.Обект_и_складовеTableAdapter = null;
            this.tableAdapterManager.Обект_Склад___дървесинаTableAdapter = null;
            this.tableAdapterManager.Превозен_билетTableAdapter = null;
            this.tableAdapterManager.Превозни_средстваTableAdapter = null;
            this.tableAdapterManager.СлужителиTableAdapter = null;
            this.tableAdapterManager.СортиментTableAdapter = null;
            this.tableAdapterManager.ФактураTableAdapter = null;
            this.tableAdapterManager.ФирмиTableAdapter = this.фирмиTableAdapter;
            // 
            // фирмиBindingNavigator
            // 
            this.фирмиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.фирмиBindingNavigator.BindingSource = this.фирмиBindingSource;
            this.фирмиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.фирмиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.фирмиBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.фирмиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.фирмиBindingNavigatorSaveItem});
            this.фирмиBindingNavigator.Location = new System.Drawing.Point(25, 94);
            this.фирмиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.фирмиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.фирмиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.фирмиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.фирмиBindingNavigator.Name = "фирмиBindingNavigator";
            this.фирмиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.фирмиBindingNavigator.Size = new System.Drawing.Size(1144, 27);
            this.фирмиBindingNavigator.TabIndex = 0;
            this.фирмиBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
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
            // фирмиBindingNavigatorSaveItem
            // 
            this.фирмиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.фирмиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("фирмиBindingNavigatorSaveItem.Image")));
            this.фирмиBindingNavigatorSaveItem.Name = "фирмиBindingNavigatorSaveItem";
            this.фирмиBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.фирмиBindingNavigatorSaveItem.Text = "Save Data";
            this.фирмиBindingNavigatorSaveItem.Click += new System.EventHandler(this.фирмиBindingNavigatorSaveItem_Click);
            // 
            // фирмиMetroGrid
            // 
            this.фирмиMetroGrid.AllowUserToResizeRows = false;
            this.фирмиMetroGrid.AutoGenerateColumns = false;
            this.фирмиMetroGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.фирмиMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.фирмиMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.фирмиMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.фирмиMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.фирмиMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.фирмиMetroGrid.ColumnHeadersHeight = 29;
            this.фирмиMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.фирмиMetroGrid.DataSource = this.фирмиBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.фирмиMetroGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.фирмиMetroGrid.EnableHeadersVisualStyles = false;
            this.фирмиMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.фирмиMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.фирмиMetroGrid.Location = new System.Drawing.Point(455, 137);
            this.фирмиMetroGrid.Name = "фирмиMetroGrid";
            this.фирмиMetroGrid.ReadOnly = true;
            this.фирмиMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.фирмиMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.фирмиMetroGrid.RowHeadersVisible = false;
            this.фирмиMetroGrid.RowHeadersWidth = 51;
            this.фирмиMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.фирмиMetroGrid.RowTemplate.Height = 24;
            this.фирмиMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.фирмиMetroGrid.Size = new System.Drawing.Size(714, 357);
            this.фирмиMetroGrid.TabIndex = 1;
            // 
            // iD_ФирмаLabel
            // 
            iD_ФирмаLabel.AutoSize = true;
            iD_ФирмаLabel.Location = new System.Drawing.Point(20, 166);
            iD_ФирмаLabel.Name = "iD_ФирмаLabel";
            iD_ФирмаLabel.Size = new System.Drawing.Size(98, 25);
            iD_ФирмаLabel.TabIndex = 2;
            iD_ФирмаLabel.Text = "ID Фирма:";
            // 
            // iD_ФирмаTextBox
            // 
            this.iD_ФирмаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.фирмиBindingSource, "ID_Фирма", true));
            this.iD_ФирмаTextBox.Location = new System.Drawing.Point(199, 163);
            this.iD_ФирмаTextBox.Name = "iD_ФирмаTextBox";
            this.iD_ФирмаTextBox.Size = new System.Drawing.Size(154, 31);
            this.iD_ФирмаTextBox.TabIndex = 3;
            // 
            // имеLabel
            // 
            имеLabel.AutoSize = true;
            имеLabel.Location = new System.Drawing.Point(20, 203);
            имеLabel.Name = "имеLabel";
            имеLabel.Size = new System.Drawing.Size(53, 25);
            имеLabel.TabIndex = 4;
            имеLabel.Text = "Име:";
            // 
            // имеTextBox
            // 
            this.имеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.фирмиBindingSource, "Име", true));
            this.имеTextBox.Location = new System.Drawing.Point(199, 200);
            this.имеTextBox.Name = "имеTextBox";
            this.имеTextBox.Size = new System.Drawing.Size(154, 31);
            this.имеTextBox.TabIndex = 5;
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(20, 240);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(68, 25);
            адресLabel.TabIndex = 6;
            адресLabel.Text = "Адрес:";
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.фирмиBindingSource, "Адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(199, 237);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(154, 31);
            this.адресTextBox.TabIndex = 7;
            // 
            // телефонен_номерLabel
            // 
            телефонен_номерLabel.AutoSize = true;
            телефонен_номерLabel.Location = new System.Drawing.Point(20, 277);
            телефонен_номерLabel.Name = "телефонен_номерLabel";
            телефонен_номерLabel.Size = new System.Drawing.Size(173, 25);
            телефонен_номерLabel.TabIndex = 8;
            телефонен_номерLabel.Text = "Телефонен номер:";
            // 
            // телефонен_номерTextBox
            // 
            this.телефонен_номерTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.фирмиBindingSource, "Телефонен_номер", true));
            this.телефонен_номерTextBox.Location = new System.Drawing.Point(199, 274);
            this.телефонен_номерTextBox.Name = "телефонен_номерTextBox";
            this.телефонен_номерTextBox.Size = new System.Drawing.Size(154, 31);
            this.телефонен_номерTextBox.TabIndex = 9;
            // 
            // градLabel
            // 
            градLabel.AutoSize = true;
            градLabel.Location = new System.Drawing.Point(20, 314);
            градLabel.Name = "градLabel";
            градLabel.Size = new System.Drawing.Size(56, 25);
            градLabel.TabIndex = 10;
            градLabel.Text = "Град:";
            // 
            // градTextBox
            // 
            this.градTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.фирмиBindingSource, "Град", true));
            this.градTextBox.Location = new System.Drawing.Point(199, 311);
            this.градTextBox.Name = "градTextBox";
            this.градTextBox.Size = new System.Drawing.Size(154, 31);
            this.градTextBox.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Име";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn2.HeaderText = "Име";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Адрес";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn3.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Телефонен_номер";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn4.HeaderText = "Телефонен номер";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Град";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn5.HeaderText = "Град";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // FMFirms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 515);
            this.Controls.Add(iD_ФирмаLabel);
            this.Controls.Add(this.iD_ФирмаTextBox);
            this.Controls.Add(имеLabel);
            this.Controls.Add(this.имеTextBox);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(телефонен_номерLabel);
            this.Controls.Add(this.телефонен_номерTextBox);
            this.Controls.Add(градLabel);
            this.Controls.Add(this.градTextBox);
            this.Controls.Add(this.фирмиMetroGrid);
            this.Controls.Add(this.фирмиBindingNavigator);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FMFirms";
            this.Padding = new System.Windows.Forms.Padding(25, 94, 25, 31);
            this.Text = "Фирми";
            this.Load += new System.EventHandler(this.FMFirms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.durvesinaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фирмиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фирмиBindingNavigator)).EndInit();
            this.фирмиBindingNavigator.ResumeLayout(false);
            this.фирмиBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.фирмиMetroGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DurvesinaDataSet durvesinaDataSet;
        private System.Windows.Forms.BindingSource фирмиBindingSource;
        private DurvesinaDataSetTableAdapters.ФирмиTableAdapter фирмиTableAdapter;
        private DurvesinaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator фирмиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton фирмиBindingNavigatorSaveItem;
        private MetroFramework.Controls.MetroGrid фирмиMetroGrid;
        private System.Windows.Forms.TextBox iD_ФирмаTextBox;
        private System.Windows.Forms.TextBox имеTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.TextBox телефонен_номерTextBox;
        private System.Windows.Forms.TextBox градTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}