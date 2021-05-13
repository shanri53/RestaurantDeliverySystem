
namespace RestaurantDeliverySystem
{
    partial class OrderList_form
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
            this.ordertblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurant_delivery_systemDataSet1 = new RestaurantDeliverySystem.restaurant_delivery_systemDataSet1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.usertblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurant_delivery_systemDataSet = new RestaurantDeliverySystem.restaurant_delivery_systemDataSet();
            this.user_tblTableAdapter = new RestaurantDeliverySystem.restaurant_delivery_systemDataSetTableAdapters.user_tblTableAdapter();
            this.order_tblTableAdapter = new RestaurantDeliverySystem.restaurant_delivery_systemDataSet1TableAdapters.order_tblTableAdapter();
            this.btn_back = new System.Windows.Forms.Button();
            this.ordertblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.orderlistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_listTableAdapter = new RestaurantDeliverySystem.restaurant_delivery_systemDataSet1TableAdapters.order_listTableAdapter();
            this.orderlistBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordertblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurant_delivery_systemDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usertblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurant_delivery_systemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordertblBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderlistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderlistBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderlistBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 364);
            this.dataGridView1.TabIndex = 8;
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
            // ordertblBindingSource
            // 
            this.ordertblBindingSource.DataMember = "order_tbl";
            this.ordertblBindingSource.DataSource = this.restaurant_delivery_systemDataSet1;
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
            this.panel1.TabIndex = 7;
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
            this.label1.Text = "Order List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usertblBindingSource
            // 
            this.usertblBindingSource.DataMember = "user_tbl";
            this.usertblBindingSource.DataSource = this.restaurant_delivery_systemDataSet;
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
            // ordertblBindingSource1
            // 
            this.ordertblBindingSource1.DataMember = "order_tbl";
            this.ordertblBindingSource1.DataSource = this.restaurant_delivery_systemDataSet1;
            // 
            // orderlistBindingSource
            // 
            this.orderlistBindingSource.DataMember = "order_list";
            this.orderlistBindingSource.DataSource = this.restaurant_delivery_systemDataSet1;
            // 
            // order_listTableAdapter
            // 
            this.order_listTableAdapter.ClearBeforeFill = true;
            // 
            // orderlistBindingSource1
            // 
            this.orderlistBindingSource1.DataMember = "order_list";
            this.orderlistBindingSource1.DataSource = this.restaurant_delivery_systemDataSet1;
            // 
            // OrderList_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OrderList_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderList_form";
            this.Load += new System.EventHandler(this.OrderList_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordertblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurant_delivery_systemDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usertblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurant_delivery_systemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordertblBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderlistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderlistBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ordertblBindingSource;
        private restaurant_delivery_systemDataSet1 restaurant_delivery_systemDataSet1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.BindingSource usertblBindingSource;
        private restaurant_delivery_systemDataSet restaurant_delivery_systemDataSet;
        private restaurant_delivery_systemDataSetTableAdapters.user_tblTableAdapter user_tblTableAdapter;
        private restaurant_delivery_systemDataSet1TableAdapters.order_tblTableAdapter order_tblTableAdapter;
        private System.Windows.Forms.BindingSource ordertblBindingSource1;
        private System.Windows.Forms.BindingSource orderlistBindingSource;
        private restaurant_delivery_systemDataSet1TableAdapters.order_listTableAdapter order_listTableAdapter;
        private System.Windows.Forms.BindingSource orderlistBindingSource1;
    }
}