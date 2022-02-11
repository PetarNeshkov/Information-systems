
namespace Дървесина
{
    partial class FMVehicles
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
            System.Windows.Forms.Label рег_НомерLabel;
            System.Windows.Forms.Label маркаLabel;
            System.Windows.Forms.Label моделLabel;
            System.Windows.Forms.Label видLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMVehicles));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.durvesinaDataSet = new Дървесина.DurvesinaDataSet();
            this.превозни_средстваBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.превозни_средстваTableAdapter = new Дървесина.DurvesinaDataSetTableAdapters.Превозни_средстваTableAdapter();
            this.tableAdapterManager = new Дървесина.DurvesinaDataSetTableAdapters.TableAdapterManager();
            this.превозни_средстваBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.превозни_средстваBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.рег_НомерTextBox = new System.Windows.Forms.TextBox();
            this.маркаTextBox = new System.Windows.Forms.TextBox();
            this.моделTextBox = new System.Windows.Forms.TextBox();
            this.видTextBox = new System.Windows.Forms.TextBox();
            this.превозни_средстваMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            рег_НомерLabel = new System.Windows.Forms.Label();
            маркаLabel = new System.Windows.Forms.Label();
            моделLabel = new System.Windows.Forms.Label();
            видLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.durvesinaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.превозни_средстваBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.превозни_средстваBindingNavigator)).BeginInit();
            this.превозни_средстваBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.превозни_средстваMetroGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // рег_НомерLabel
            // 
            рег_НомерLabel.AutoSize = true;
            рег_НомерLabel.Location = new System.Drawing.Point(28, 154);
            рег_НомерLabel.Name = "рег_НомерLabel";
            рег_НомерLabel.Size = new System.Drawing.Size(107, 25);
            рег_НомерLabel.TabIndex = 1;
            рег_НомерLabel.Text = "Рег Номер:";
            // 
            // маркаLabel
            // 
            маркаLabel.AutoSize = true;
            маркаLabel.Location = new System.Drawing.Point(28, 191);
            маркаLabel.Name = "маркаLabel";
            маркаLabel.Size = new System.Drawing.Size(73, 25);
            маркаLabel.TabIndex = 3;
            маркаLabel.Text = "Марка:";
            // 
            // моделLabel
            // 
            моделLabel.AutoSize = true;
            моделLabel.Location = new System.Drawing.Point(28, 228);
            моделLabel.Name = "моделLabel";
            моделLabel.Size = new System.Drawing.Size(74, 25);
            моделLabel.TabIndex = 5;
            моделLabel.Text = "Модел:";
            // 
            // видLabel
            // 
            видLabel.AutoSize = true;
            видLabel.Location = new System.Drawing.Point(28, 265);
            видLabel.Name = "видLabel";
            видLabel.Size = new System.Drawing.Size(48, 25);
            видLabel.TabIndex = 7;
            видLabel.Text = "Вид:";
            // 
            // durvesinaDataSet
            // 
            this.durvesinaDataSet.DataSetName = "DurvesinaDataSet";
            this.durvesinaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // превозни_средстваBindingSource
            // 
            this.превозни_средстваBindingSource.DataMember = "Превозни_средства";
            this.превозни_средстваBindingSource.DataSource = this.durvesinaDataSet;
            // 
            // превозни_средстваTableAdapter
            // 
            this.превозни_средстваTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Превозни_средстваTableAdapter = this.превозни_средстваTableAdapter;
            this.tableAdapterManager.СлужителиTableAdapter = null;
            this.tableAdapterManager.СортиментTableAdapter = null;
            this.tableAdapterManager.ФактураTableAdapter = null;
            this.tableAdapterManager.ФирмиTableAdapter = null;
            // 
            // превозни_средстваBindingNavigator
            // 
            this.превозни_средстваBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.превозни_средстваBindingNavigator.BindingSource = this.превозни_средстваBindingSource;
            this.превозни_средстваBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.превозни_средстваBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.превозни_средстваBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.превозни_средстваBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.превозни_средстваBindingNavigatorSaveItem});
            this.превозни_средстваBindingNavigator.Location = new System.Drawing.Point(25, 94);
            this.превозни_средстваBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.превозни_средстваBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.превозни_средстваBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.превозни_средстваBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.превозни_средстваBindingNavigator.Name = "превозни_средстваBindingNavigator";
            this.превозни_средстваBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.превозни_средстваBindingNavigator.Size = new System.Drawing.Size(927, 31);
            this.превозни_средстваBindingNavigator.TabIndex = 0;
            this.превозни_средстваBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // превозни_средстваBindingNavigatorSaveItem
            // 
            this.превозни_средстваBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.превозни_средстваBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("превозни_средстваBindingNavigatorSaveItem.Image")));
            this.превозни_средстваBindingNavigatorSaveItem.Name = "превозни_средстваBindingNavigatorSaveItem";
            this.превозни_средстваBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.превозни_средстваBindingNavigatorSaveItem.Text = "Save Data";
            this.превозни_средстваBindingNavigatorSaveItem.Click += new System.EventHandler(this.превозни_средстваBindingNavigatorSaveItem_Click);
            // 
            // рег_НомерTextBox
            // 
            this.рег_НомерTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.превозни_средстваBindingSource, "Рег_Номер", true));
            this.рег_НомерTextBox.Location = new System.Drawing.Point(141, 151);
            this.рег_НомерTextBox.Name = "рег_НомерTextBox";
            this.рег_НомерTextBox.Size = new System.Drawing.Size(100, 31);
            this.рег_НомерTextBox.TabIndex = 2;
            // 
            // маркаTextBox
            // 
            this.маркаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.превозни_средстваBindingSource, "Марка", true));
            this.маркаTextBox.Location = new System.Drawing.Point(141, 188);
            this.маркаTextBox.Name = "маркаTextBox";
            this.маркаTextBox.Size = new System.Drawing.Size(100, 31);
            this.маркаTextBox.TabIndex = 4;
            // 
            // моделTextBox
            // 
            this.моделTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.превозни_средстваBindingSource, "Модел", true));
            this.моделTextBox.Location = new System.Drawing.Point(141, 225);
            this.моделTextBox.Name = "моделTextBox";
            this.моделTextBox.Size = new System.Drawing.Size(100, 31);
            this.моделTextBox.TabIndex = 6;
            // 
            // видTextBox
            // 
            this.видTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.превозни_средстваBindingSource, "Вид", true));
            this.видTextBox.Location = new System.Drawing.Point(141, 262);
            this.видTextBox.Name = "видTextBox";
            this.видTextBox.Size = new System.Drawing.Size(100, 31);
            this.видTextBox.TabIndex = 8;
            // 
            // превозни_средстваMetroGrid
            // 
            this.превозни_средстваMetroGrid.AllowUserToResizeRows = false;
            this.превозни_средстваMetroGrid.AutoGenerateColumns = false;
            this.превозни_средстваMetroGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.превозни_средстваMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.превозни_средстваMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.превозни_средстваMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.превозни_средстваMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.превозни_средстваMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.превозни_средстваMetroGrid.ColumnHeadersHeight = 29;
            this.превозни_средстваMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.превозни_средстваMetroGrid.DataSource = this.превозни_средстваBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.превозни_средстваMetroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.превозни_средстваMetroGrid.EnableHeadersVisualStyles = false;
            this.превозни_средстваMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.превозни_средстваMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.превозни_средстваMetroGrid.Location = new System.Drawing.Point(350, 151);
            this.превозни_средстваMetroGrid.Name = "превозни_средстваMetroGrid";
            this.превозни_средстваMetroGrid.ReadOnly = true;
            this.превозни_средстваMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.превозни_средстваMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.превозни_средстваMetroGrid.RowHeadersVisible = false;
            this.превозни_средстваMetroGrid.RowHeadersWidth = 51;
            this.превозни_средстваMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.превозни_средстваMetroGrid.RowTemplate.Height = 24;
            this.превозни_средстваMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.превозни_средстваMetroGrid.Size = new System.Drawing.Size(602, 220);
            this.превозни_средстваMetroGrid.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Марка";
            this.dataGridViewTextBoxColumn2.HeaderText = "Марка";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Модел";
            this.dataGridViewTextBoxColumn3.HeaderText = "Модел";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Вид";
            this.dataGridViewTextBoxColumn4.HeaderText = "Вид";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // FMVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 510);
            this.Controls.Add(this.превозни_средстваMetroGrid);
            this.Controls.Add(рег_НомерLabel);
            this.Controls.Add(this.рег_НомерTextBox);
            this.Controls.Add(маркаLabel);
            this.Controls.Add(this.маркаTextBox);
            this.Controls.Add(моделLabel);
            this.Controls.Add(this.моделTextBox);
            this.Controls.Add(видLabel);
            this.Controls.Add(this.видTextBox);
            this.Controls.Add(this.превозни_средстваBindingNavigator);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FMVehicles";
            this.Padding = new System.Windows.Forms.Padding(25, 94, 25, 31);
            this.Text = "Превозни средства";
            this.Load += new System.EventHandler(this.FMVehicles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.durvesinaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.превозни_средстваBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.превозни_средстваBindingNavigator)).EndInit();
            this.превозни_средстваBindingNavigator.ResumeLayout(false);
            this.превозни_средстваBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.превозни_средстваMetroGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DurvesinaDataSet durvesinaDataSet;
        private System.Windows.Forms.BindingSource превозни_средстваBindingSource;
        private DurvesinaDataSetTableAdapters.Превозни_средстваTableAdapter превозни_средстваTableAdapter;
        private DurvesinaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator превозни_средстваBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton превозни_средстваBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox рег_НомерTextBox;
        private System.Windows.Forms.TextBox маркаTextBox;
        private System.Windows.Forms.TextBox моделTextBox;
        private System.Windows.Forms.TextBox видTextBox;
        private MetroFramework.Controls.MetroGrid превозни_средстваMetroGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}