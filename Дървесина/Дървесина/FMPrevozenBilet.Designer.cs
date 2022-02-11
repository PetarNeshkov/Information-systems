
namespace Дървесина
{
    partial class FMPrevozenBilet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMPrevozenBilet));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label iD_Превозен_билетLabel;
            System.Windows.Forms.Label дата_на_превозен_билетLabel;
            System.Windows.Forms.Label рег_НомерLabel;
            System.Windows.Forms.Label шофьорLabel;
            System.Windows.Forms.Label ценаLabel;
            System.Windows.Forms.Label iD_ФактураLabel;
            this.durvesinaDataSet = new Дървесина.DurvesinaDataSet();
            this.превозен_билетBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.превозен_билетTableAdapter = new Дървесина.DurvesinaDataSetTableAdapters.Превозен_билетTableAdapter();
            this.tableAdapterManager = new Дървесина.DurvesinaDataSetTableAdapters.TableAdapterManager();
            this.превозен_билетBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.превозен_билетBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.превозен_билетMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.служителиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.служителиTableAdapter = new Дървесина.DurvesinaDataSetTableAdapters.СлужителиTableAdapter();
            this.клиентиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентиTableAdapter = new Дървесина.DurvesinaDataSetTableAdapters.КлиентиTableAdapter();
            this.фактураBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.фактураTableAdapter = new Дървесина.DurvesinaDataSetTableAdapters.ФактураTableAdapter();
            this.клиентиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iD_Превозен_билетTextBox = new System.Windows.Forms.TextBox();
            this.дата_на_превозен_билетDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.рег_НомерTextBox = new System.Windows.Forms.TextBox();
            this.шофьорTextBox = new System.Windows.Forms.TextBox();
            this.ценаTextBox = new System.Windows.Forms.TextBox();
            this.iD_ФактураTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            iD_Превозен_билетLabel = new System.Windows.Forms.Label();
            дата_на_превозен_билетLabel = new System.Windows.Forms.Label();
            рег_НомерLabel = new System.Windows.Forms.Label();
            шофьорLabel = new System.Windows.Forms.Label();
            ценаLabel = new System.Windows.Forms.Label();
            iD_ФактураLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.durvesinaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.превозен_билетBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.превозен_билетBindingNavigator)).BeginInit();
            this.превозен_билетBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.превозен_билетMetroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.служителиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фактураBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентиBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // durvesinaDataSet
            // 
            this.durvesinaDataSet.DataSetName = "DurvesinaDataSet";
            this.durvesinaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // превозен_билетBindingSource
            // 
            this.превозен_билетBindingSource.DataMember = "Превозен_билет";
            this.превозен_билетBindingSource.DataSource = this.durvesinaDataSet;
            // 
            // превозен_билетTableAdapter
            // 
            this.превозен_билетTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.КлиентиTableAdapter = this.клиентиTableAdapter;
            this.tableAdapterManager.Обект_и_складовеTableAdapter = null;
            this.tableAdapterManager.Обект_Склад___дървесинаTableAdapter = null;
            this.tableAdapterManager.Превозен_билетTableAdapter = this.превозен_билетTableAdapter;
            this.tableAdapterManager.Превозни_средстваTableAdapter = null;
            this.tableAdapterManager.СлужителиTableAdapter = this.служителиTableAdapter;
            this.tableAdapterManager.СортиментTableAdapter = null;
            this.tableAdapterManager.ФактураTableAdapter = this.фактураTableAdapter;
            this.tableAdapterManager.ФирмиTableAdapter = null;
            // 
            // превозен_билетBindingNavigator
            // 
            this.превозен_билетBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.превозен_билетBindingNavigator.BindingSource = this.превозен_билетBindingSource;
            this.превозен_билетBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.превозен_билетBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.превозен_билетBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.превозен_билетBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.превозен_билетBindingNavigatorSaveItem});
            this.превозен_билетBindingNavigator.Location = new System.Drawing.Point(25, 94);
            this.превозен_билетBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.превозен_билетBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.превозен_билетBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.превозен_билетBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.превозен_билетBindingNavigator.Name = "превозен_билетBindingNavigator";
            this.превозен_билетBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.превозен_билетBindingNavigator.Size = new System.Drawing.Size(1158, 27);
            this.превозен_билетBindingNavigator.TabIndex = 0;
            this.превозен_билетBindingNavigator.Text = "bindingNavigator1";
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
            // превозен_билетBindingNavigatorSaveItem
            // 
            this.превозен_билетBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.превозен_билетBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("превозен_билетBindingNavigatorSaveItem.Image")));
            this.превозен_билетBindingNavigatorSaveItem.Name = "превозен_билетBindingNavigatorSaveItem";
            this.превозен_билетBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.превозен_билетBindingNavigatorSaveItem.Text = "Save Data";
            this.превозен_билетBindingNavigatorSaveItem.Click += new System.EventHandler(this.превозен_билетBindingNavigatorSaveItem_Click_1);
            // 
            // превозен_билетMetroGrid
            // 
            this.превозен_билетMetroGrid.AllowUserToResizeRows = false;
            this.превозен_билетMetroGrid.AutoGenerateColumns = false;
            this.превозен_билетMetroGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.превозен_билетMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.превозен_билетMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.превозен_билетMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.превозен_билетMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.превозен_билетMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.превозен_билетMetroGrid.ColumnHeadersHeight = 29;
            this.превозен_билетMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.превозен_билетMetroGrid.DataSource = this.превозен_билетBindingSource;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.превозен_билетMetroGrid.DefaultCellStyle = dataGridViewCellStyle17;
            this.превозен_билетMetroGrid.EnableHeadersVisualStyles = false;
            this.превозен_билетMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.превозен_билетMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.превозен_билетMetroGrid.Location = new System.Drawing.Point(487, 141);
            this.превозен_билетMetroGrid.Name = "превозен_билетMetroGrid";
            this.превозен_билетMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.превозен_билетMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.превозен_билетMetroGrid.RowHeadersVisible = false;
            this.превозен_билетMetroGrid.RowHeadersWidth = 51;
            this.превозен_билетMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.превозен_билетMetroGrid.RowTemplate.Height = 24;
            this.превозен_билетMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.превозен_билетMetroGrid.Size = new System.Drawing.Size(693, 337);
            this.превозен_билетMetroGrid.TabIndex = 1;
            // 
            // служителиBindingSource
            // 
            this.служителиBindingSource.DataMember = "Служители";
            this.служителиBindingSource.DataSource = this.durvesinaDataSet;
            // 
            // служителиTableAdapter
            // 
            this.служителиTableAdapter.ClearBeforeFill = true;
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
            // фактураBindingSource
            // 
            this.фактураBindingSource.DataMember = "Фактура";
            this.фактураBindingSource.DataSource = this.durvesinaDataSet;
            // 
            // фактураTableAdapter
            // 
            this.фактураTableAdapter.ClearBeforeFill = true;
            // 
            // клиентиBindingSource1
            // 
            this.клиентиBindingSource1.DataMember = "Клиенти";
            this.клиентиBindingSource1.DataSource = this.durvesinaDataSet;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Превозен_билет";
            this.dataGridViewTextBoxColumn1.FillWeight = 32.08556F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ID_Фактура";
            this.dataGridViewTextBoxColumn6.DataSource = this.клиентиBindingSource1;
            this.dataGridViewTextBoxColumn6.DisplayMember = "Име_и_Фамилия";
            this.dataGridViewTextBoxColumn6.FillWeight = 113.5829F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Фактура на:";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.ValueMember = "ID_Клиент";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Дата_на_превозен_билет";
            this.dataGridViewTextBoxColumn2.FillWeight = 113.5829F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата на превозен билет";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Рег_Номер";
            this.dataGridViewTextBoxColumn3.FillWeight = 113.5829F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Рег. Номер";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Шофьор";
            this.dataGridViewTextBoxColumn4.DataSource = this.служителиBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "Име_и_Фамилия";
            this.dataGridViewTextBoxColumn4.FillWeight = 113.5829F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Шофьор";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "ID_Служител";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Цена";
            this.dataGridViewTextBoxColumn5.FillWeight = 113.5829F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // iD_Превозен_билетLabel
            // 
            iD_Превозен_билетLabel.AutoSize = true;
            iD_Превозен_билетLabel.Location = new System.Drawing.Point(25, 192);
            iD_Превозен_билетLabel.Name = "iD_Превозен_билетLabel";
            iD_Превозен_билетLabel.Size = new System.Drawing.Size(179, 25);
            iD_Превозен_билетLabel.TabIndex = 2;
            iD_Превозен_билетLabel.Text = "ID Превозен билет:";
            // 
            // iD_Превозен_билетTextBox
            // 
            this.iD_Превозен_билетTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.превозен_билетBindingSource, "ID_Превозен_билет", true));
            this.iD_Превозен_билетTextBox.Location = new System.Drawing.Point(259, 186);
            this.iD_Превозен_билетTextBox.Name = "iD_Превозен_билетTextBox";
            this.iD_Превозен_билетTextBox.Size = new System.Drawing.Size(200, 31);
            this.iD_Превозен_билетTextBox.TabIndex = 3;
            // 
            // дата_на_превозен_билетLabel
            // 
            дата_на_превозен_билетLabel.AutoSize = true;
            дата_на_превозен_билетLabel.Location = new System.Drawing.Point(28, 275);
            дата_на_превозен_билетLabel.Name = "дата_на_превозен_билетLabel";
            дата_на_превозен_билетLabel.Size = new System.Drawing.Size(225, 25);
            дата_на_превозен_билетLabel.TabIndex = 4;
            дата_на_превозен_билетLabel.Text = "Дата на превозен билет:";
            // 
            // дата_на_превозен_билетDateTimePicker
            // 
            this.дата_на_превозен_билетDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.превозен_билетBindingSource, "Дата_на_превозен_билет", true));
            this.дата_на_превозен_билетDateTimePicker.Location = new System.Drawing.Point(259, 269);
            this.дата_на_превозен_билетDateTimePicker.Name = "дата_на_превозен_билетDateTimePicker";
            this.дата_на_превозен_билетDateTimePicker.Size = new System.Drawing.Size(200, 31);
            this.дата_на_превозен_билетDateTimePicker.TabIndex = 5;
            // 
            // рег_НомерLabel
            // 
            рег_НомерLabel.AutoSize = true;
            рег_НомерLabel.Location = new System.Drawing.Point(28, 312);
            рег_НомерLabel.Name = "рег_НомерLabel";
            рег_НомерLabel.Size = new System.Drawing.Size(107, 25);
            рег_НомерLabel.TabIndex = 6;
            рег_НомерLabel.Text = "Рег Номер:";
            // 
            // рег_НомерTextBox
            // 
            this.рег_НомерTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.превозен_билетBindingSource, "Рег_Номер", true));
            this.рег_НомерTextBox.Location = new System.Drawing.Point(259, 306);
            this.рег_НомерTextBox.Name = "рег_НомерTextBox";
            this.рег_НомерTextBox.Size = new System.Drawing.Size(200, 31);
            this.рег_НомерTextBox.TabIndex = 7;
            // 
            // шофьорLabel
            // 
            шофьорLabel.AutoSize = true;
            шофьорLabel.Location = new System.Drawing.Point(28, 349);
            шофьорLabel.Name = "шофьорLabel";
            шофьорLabel.Size = new System.Drawing.Size(90, 25);
            шофьорLabel.TabIndex = 8;
            шофьорLabel.Text = "Шофьор:";
            // 
            // шофьорTextBox
            // 
            this.шофьорTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.превозен_билетBindingSource, "Шофьор", true));
            this.шофьорTextBox.Location = new System.Drawing.Point(259, 343);
            this.шофьорTextBox.Name = "шофьорTextBox";
            this.шофьорTextBox.Size = new System.Drawing.Size(200, 31);
            this.шофьорTextBox.TabIndex = 9;
            // 
            // ценаLabel
            // 
            ценаLabel.AutoSize = true;
            ценаLabel.Location = new System.Drawing.Point(25, 386);
            ценаLabel.Name = "ценаLabel";
            ценаLabel.Size = new System.Drawing.Size(61, 25);
            ценаLabel.TabIndex = 10;
            ценаLabel.Text = "Цена:";
            // 
            // ценаTextBox
            // 
            this.ценаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.превозен_билетBindingSource, "Цена", true));
            this.ценаTextBox.Location = new System.Drawing.Point(259, 380);
            this.ценаTextBox.Name = "ценаTextBox";
            this.ценаTextBox.Size = new System.Drawing.Size(200, 31);
            this.ценаTextBox.TabIndex = 11;
            // 
            // iD_ФактураLabel
            // 
            iD_ФактураLabel.AutoSize = true;
            iD_ФактураLabel.Location = new System.Drawing.Point(25, 238);
            iD_ФактураLabel.Name = "iD_ФактураLabel";
            iD_ФактураLabel.Size = new System.Drawing.Size(110, 25);
            iD_ФактураLabel.TabIndex = 12;
            iD_ФактураLabel.Text = "ID Фактура:";
            // 
            // iD_ФактураTextBox
            // 
            this.iD_ФактураTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.превозен_билетBindingSource, "ID_Фактура", true));
            this.iD_ФактураTextBox.Location = new System.Drawing.Point(259, 232);
            this.iD_ФактураTextBox.Name = "iD_ФактураTextBox";
            this.iD_ФактураTextBox.Size = new System.Drawing.Size(200, 31);
            this.iD_ФактураTextBox.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 430);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(329, 31);
            this.textBox1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Доставка:";
            // 
            // FMPrevozenBilet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 652);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(iD_Превозен_билетLabel);
            this.Controls.Add(this.iD_Превозен_билетTextBox);
            this.Controls.Add(дата_на_превозен_билетLabel);
            this.Controls.Add(this.дата_на_превозен_билетDateTimePicker);
            this.Controls.Add(рег_НомерLabel);
            this.Controls.Add(this.рег_НомерTextBox);
            this.Controls.Add(шофьорLabel);
            this.Controls.Add(this.шофьорTextBox);
            this.Controls.Add(ценаLabel);
            this.Controls.Add(this.ценаTextBox);
            this.Controls.Add(iD_ФактураLabel);
            this.Controls.Add(this.iD_ФактураTextBox);
            this.Controls.Add(this.превозен_билетMetroGrid);
            this.Controls.Add(this.превозен_билетBindingNavigator);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FMPrevozenBilet";
            this.Padding = new System.Windows.Forms.Padding(25, 94, 25, 31);
            this.Text = "Превозен билет";
            this.Load += new System.EventHandler(this.FMPrevozenBilet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.durvesinaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.превозен_билетBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.превозен_билетBindingNavigator)).EndInit();
            this.превозен_билетBindingNavigator.ResumeLayout(false);
            this.превозен_билетBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.превозен_билетMetroGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.служителиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фактураBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентиBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DurvesinaDataSet durvesinaDataSet;
        private System.Windows.Forms.BindingSource превозен_билетBindingSource;
        private DurvesinaDataSetTableAdapters.Превозен_билетTableAdapter превозен_билетTableAdapter;
        private DurvesinaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator превозен_билетBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton превозен_билетBindingNavigatorSaveItem;
        private DurvesinaDataSetTableAdapters.СлужителиTableAdapter служителиTableAdapter;
        private MetroFramework.Controls.MetroGrid превозен_билетMetroGrid;
        private System.Windows.Forms.BindingSource служителиBindingSource;
        private DurvesinaDataSetTableAdapters.КлиентиTableAdapter клиентиTableAdapter;
        private System.Windows.Forms.BindingSource клиентиBindingSource;
        private DurvesinaDataSetTableAdapters.ФактураTableAdapter фактураTableAdapter;
        private System.Windows.Forms.BindingSource фактураBindingSource;
        private System.Windows.Forms.BindingSource клиентиBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox iD_Превозен_билетTextBox;
        private System.Windows.Forms.DateTimePicker дата_на_превозен_билетDateTimePicker;
        private System.Windows.Forms.TextBox рег_НомерTextBox;
        private System.Windows.Forms.TextBox шофьорTextBox;
        private System.Windows.Forms.TextBox ценаTextBox;
        private System.Windows.Forms.TextBox iD_ФактураTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}