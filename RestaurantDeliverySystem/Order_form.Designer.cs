
namespace RestaurantDeliverySystem
{
    partial class Order_form
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderlistidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restaurantidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.ordertblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurant_delivery_systemDataSet1 = new RestaurantDeliverySystem.restaurant_delivery_systemDataSet1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.usertblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurant_delivery_systemDataSet = new RestaurantDeliverySystem.restaurant_delivery_systemDataSet();
            this.user_tblTableAdapter = new RestaurantDeliverySystem.restaurant_delivery_systemDataSetTableAdapters.user_tblTableAdapter();
            this.order_tblTableAdapter = new RestaurantDeliverySystem.restaurant_delivery_systemDataSet1TableAdapters.order_tblTableAdapter();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordertblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurant_delivery_systemDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usertblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurant_delivery_systemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.orderlistidDataGridViewTextBoxColumn,
            this.useridDataGridViewTextBoxColumn,
            this.restaurantidDataGridViewTextBoxColumn,
            this.dateDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.ordertblBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 364);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderlistidDataGridViewTextBoxColumn
            // 
            this.orderlistidDataGridViewTextBoxColumn.DataPropertyName = "order_list_id";
            this.orderlistidDataGridViewTextBoxColumn.HeaderText = "order_list_id";
            this.orderlistidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderlistidDataGridViewTextBoxColumn.Name = "orderlistidDataGridViewTextBoxColumn";
            this.orderlistidDataGridViewTextBoxColumn.Width = 125;
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "user_id";
            this.useridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.Width = 125;
            // 
            // restaurantidDataGridViewTextBoxColumn
            // 
            this.restaurantidDataGridViewTextBoxColumn.DataPropertyName = "restaurant_id";
            this.restaurantidDataGridViewTextBoxColumn.HeaderText = "restaurant_id";
            this.restaurantidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.restaurantidDataGridViewTextBoxColumn.Name = "restaurantidDataGridViewTextBoxColumn";
            this.restaurantidDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewImageColumn
            // 
            this.dateDataGridViewImageColumn.DataPropertyName = "date";
            this.dateDataGridViewImageColumn.HeaderText = "date";
            this.dateDataGridViewImageColumn.MinimumWidth = 6;
            this.dateDataGridViewImageColumn.Name = "dateDataGridViewImageColumn";
            this.dateDataGridViewImageColumn.ReadOnly = true;
            this.dateDataGridViewImageColumn.Width = 125;
            // 
            // ordertblBindingSource
            // 
            this.ordertblBindingSource.DataMember = "order_tbl";
            this.ordertblBindingSource.DataSource = this.restaurant_delivery_systemDataSet1;
            this.ordertblBindingSource.CurrentChanged += new System.EventHandler(this.ordertblBindingSource_CurrentChanged);
            // 
            // restaurant_delivery_systemDataSet1
            // 
            this.restaurant_delivery_systemDataSet1.DataSetName = "restaurant_delivery_systemDataSet1";
            this.restaurant_delivery_systemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 86);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(144, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(654, 84);
            this.label1.TabIndex = 2;
            this.label1.Text = "Order History";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // usertblBindingSource
            // 
            this.usertblBindingSource.DataMember = "user_tbl";
            this.usertblBindingSource.DataSource = this.restaurant_delivery_systemDataSet;
            this.usertblBindingSource.CurrentChanged += new System.EventHandler(this.usertblBindingSource_CurrentChanged);
            // 
            // restaurant_delivery_systemDataSet
            // 
            this.restaurant_delivery_systemDataSet.DataSetName = "restaurant_delivery_systemDataSet";
            this.restaurant_delivery_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // user_tblTableAdapter
            // 
            this.user_tblTableAdapter.ClearBeforeFill = true;
            // 
            // order_tblTableAdapter
            // 
            this.order_tblTableAdapter.ClearBeforeFill = true;
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = global::RestaurantDeliverySystem.Properties.Resources.back;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_back.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Location = new System.Drawing.Point(0, 0);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(144, 84);
            this.btn_back.TabIndex = 2;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Order_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Order_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "History_form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordertblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurant_delivery_systemDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usertblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurant_delivery_systemDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderlistidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn restaurantidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn dateDataGridViewImageColumn;
        private System.Windows.Forms.BindingSource ordertblBindingSource;
        private restaurant_delivery_systemDataSet1 restaurant_delivery_systemDataSet1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.BindingSource usertblBindingSource;
        private restaurant_delivery_systemDataSet restaurant_delivery_systemDataSet;
        private restaurant_delivery_systemDataSetTableAdapters.user_tblTableAdapter user_tblTableAdapter;
        private restaurant_delivery_systemDataSet1TableAdapters.order_tblTableAdapter order_tblTableAdapter;
    }
}