namespace PracticWork1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allInformationAboutTheGoodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodWithMaximumQuantityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodWithMinimalQuantityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodWithMinimalCostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodWithMaximumCostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dGVSuppliers = new System.Windows.Forms.DataGridView();
            this.dGVStock = new System.Windows.Forms.DataGridView();
            this.dGVGoods_type = new System.Windows.Forms.DataGridView();
            this.dGVGoods = new System.Windows.Forms.DataGridView();
            this.dGVShow = new System.Windows.Forms.DataGridView();
            this.lb_Goods_type = new System.Windows.Forms.Label();
            this.lb_Goods = new System.Windows.Forms.Label();
            this.lb_Suppliers = new System.Windows.Forms.Label();
            this.lb_Stock = new System.Windows.Forms.Label();
            this.lb_Show = new System.Windows.Forms.Label();
            this.oldestGoodsInStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numberOfGoodsForEachGoodsTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cB_GoodsType = new System.Windows.Forms.ComboBox();
            this.cB_Suppliers = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVGoods_type)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVGoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVShow)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.showInformationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1259, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectDBToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.файлToolStripMenuItem.Text = "File";
            // 
            // SelectDBToolStripMenuItem
            // 
            this.SelectDBToolStripMenuItem.Name = "SelectDBToolStripMenuItem";
            this.SelectDBToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.SelectDBToolStripMenuItem.Text = "Select database";
            this.SelectDBToolStripMenuItem.Click += new System.EventHandler(this.SelectDBToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateTablesToolStripMenuItem,
            this.SaveChangesToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.EditToolStripMenuItem.Text = "Edit";
            // 
            // CreateTablesToolStripMenuItem
            // 
            this.CreateTablesToolStripMenuItem.Name = "CreateTablesToolStripMenuItem";
            this.CreateTablesToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.CreateTablesToolStripMenuItem.Text = "Create tables";
            this.CreateTablesToolStripMenuItem.Click += new System.EventHandler(this.CreateTablesToolStripMenuItem_Click);
            // 
            // SaveChangesToolStripMenuItem
            // 
            this.SaveChangesToolStripMenuItem.Name = "SaveChangesToolStripMenuItem";
            this.SaveChangesToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.SaveChangesToolStripMenuItem.Text = "Save changes";
            // 
            // showInformationToolStripMenuItem
            // 
            this.showInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allInformationAboutTheGoodToolStripMenuItem,
            this.goodWithMaximumQuantityToolStripMenuItem,
            this.goodWithMinimalQuantityToolStripMenuItem,
            this.goodWithMinimalCostToolStripMenuItem,
            this.goodWithMaximumCostToolStripMenuItem,
            this.oldestGoodsInStockToolStripMenuItem,
            this.numberOfGoodsForEachGoodsTypeToolStripMenuItem});
            this.showInformationToolStripMenuItem.Name = "showInformationToolStripMenuItem";
            this.showInformationToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.showInformationToolStripMenuItem.Text = "Show information";
            // 
            // allInformationAboutTheGoodToolStripMenuItem
            // 
            this.allInformationAboutTheGoodToolStripMenuItem.Name = "allInformationAboutTheGoodToolStripMenuItem";
            this.allInformationAboutTheGoodToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.allInformationAboutTheGoodToolStripMenuItem.Text = "All information about the good";
            this.allInformationAboutTheGoodToolStripMenuItem.Click += new System.EventHandler(this.allInformationAboutTheGoodToolStripMenuItem_Click);
            // 
            // goodWithMaximumQuantityToolStripMenuItem
            // 
            this.goodWithMaximumQuantityToolStripMenuItem.Name = "goodWithMaximumQuantityToolStripMenuItem";
            this.goodWithMaximumQuantityToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.goodWithMaximumQuantityToolStripMenuItem.Text = "Good with maximum quantity";
            this.goodWithMaximumQuantityToolStripMenuItem.Click += new System.EventHandler(this.goodWithMaximumQuantityToolStripMenuItem_Click);
            // 
            // goodWithMinimalQuantityToolStripMenuItem
            // 
            this.goodWithMinimalQuantityToolStripMenuItem.Name = "goodWithMinimalQuantityToolStripMenuItem";
            this.goodWithMinimalQuantityToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.goodWithMinimalQuantityToolStripMenuItem.Text = "Good with minimal quantity";
            this.goodWithMinimalQuantityToolStripMenuItem.Click += new System.EventHandler(this.goodWithMinimalQuantityToolStripMenuItem_Click);
            // 
            // goodWithMinimalCostToolStripMenuItem
            // 
            this.goodWithMinimalCostToolStripMenuItem.Name = "goodWithMinimalCostToolStripMenuItem";
            this.goodWithMinimalCostToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.goodWithMinimalCostToolStripMenuItem.Text = "Good with minimal cost";
            this.goodWithMinimalCostToolStripMenuItem.Click += new System.EventHandler(this.goodWithMinimalCostToolStripMenuItem_Click);
            // 
            // goodWithMaximumCostToolStripMenuItem
            // 
            this.goodWithMaximumCostToolStripMenuItem.Name = "goodWithMaximumCostToolStripMenuItem";
            this.goodWithMaximumCostToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.goodWithMaximumCostToolStripMenuItem.Text = "Good with maximum cost";
            this.goodWithMaximumCostToolStripMenuItem.Click += new System.EventHandler(this.goodWithMaximumCostToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.CheckFileExists = false;
            this.openFileDialog1.CheckPathExists = false;
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dGVSuppliers
            // 
            this.dGVSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVSuppliers.Location = new System.Drawing.Point(267, 54);
            this.dGVSuppliers.Name = "dGVSuppliers";
            this.dGVSuppliers.Size = new System.Drawing.Size(371, 202);
            this.dGVSuppliers.TabIndex = 1;
            // 
            // dGVStock
            // 
            this.dGVStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVStock.Location = new System.Drawing.Point(267, 275);
            this.dGVStock.Name = "dGVStock";
            this.dGVStock.Size = new System.Drawing.Size(371, 360);
            this.dGVStock.TabIndex = 1;
            // 
            // dGVGoods_type
            // 
            this.dGVGoods_type.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVGoods_type.Location = new System.Drawing.Point(12, 54);
            this.dGVGoods_type.Name = "dGVGoods_type";
            this.dGVGoods_type.Size = new System.Drawing.Size(232, 202);
            this.dGVGoods_type.TabIndex = 1;
            // 
            // dGVGoods
            // 
            this.dGVGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVGoods.Location = new System.Drawing.Point(12, 275);
            this.dGVGoods.Name = "dGVGoods";
            this.dGVGoods.Size = new System.Drawing.Size(232, 360);
            this.dGVGoods.TabIndex = 1;
            // 
            // dGVShow
            // 
            this.dGVShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVShow.Location = new System.Drawing.Point(658, 105);
            this.dGVShow.Name = "dGVShow";
            this.dGVShow.Size = new System.Drawing.Size(589, 530);
            this.dGVShow.TabIndex = 2;
            // 
            // lb_Goods_type
            // 
            this.lb_Goods_type.AutoSize = true;
            this.lb_Goods_type.Location = new System.Drawing.Point(12, 38);
            this.lb_Goods_type.Name = "lb_Goods_type";
            this.lb_Goods_type.Size = new System.Drawing.Size(64, 13);
            this.lb_Goods_type.TabIndex = 3;
            this.lb_Goods_type.Text = "Goods_type";
            // 
            // lb_Goods
            // 
            this.lb_Goods.AutoSize = true;
            this.lb_Goods.Location = new System.Drawing.Point(12, 259);
            this.lb_Goods.Name = "lb_Goods";
            this.lb_Goods.Size = new System.Drawing.Size(38, 13);
            this.lb_Goods.TabIndex = 3;
            this.lb_Goods.Text = "Goods";
            // 
            // lb_Suppliers
            // 
            this.lb_Suppliers.AutoSize = true;
            this.lb_Suppliers.Location = new System.Drawing.Point(264, 38);
            this.lb_Suppliers.Name = "lb_Suppliers";
            this.lb_Suppliers.Size = new System.Drawing.Size(50, 13);
            this.lb_Suppliers.TabIndex = 3;
            this.lb_Suppliers.Text = "Suppliers";
            // 
            // lb_Stock
            // 
            this.lb_Stock.AutoSize = true;
            this.lb_Stock.Location = new System.Drawing.Point(264, 259);
            this.lb_Stock.Name = "lb_Stock";
            this.lb_Stock.Size = new System.Drawing.Size(35, 13);
            this.lb_Stock.TabIndex = 3;
            this.lb_Stock.Text = "Stock";
            // 
            // lb_Show
            // 
            this.lb_Show.AutoSize = true;
            this.lb_Show.Location = new System.Drawing.Point(655, 89);
            this.lb_Show.Name = "lb_Show";
            this.lb_Show.Size = new System.Drawing.Size(34, 13);
            this.lb_Show.TabIndex = 3;
            this.lb_Show.Text = "Show";
            // 
            // oldestGoodsInStockToolStripMenuItem
            // 
            this.oldestGoodsInStockToolStripMenuItem.Name = "oldestGoodsInStockToolStripMenuItem";
            this.oldestGoodsInStockToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.oldestGoodsInStockToolStripMenuItem.Text = "Oldest goods in stock";
            this.oldestGoodsInStockToolStripMenuItem.Click += new System.EventHandler(this.oldestGoodsInStockToolStripMenuItem_Click);
            // 
            // numberOfGoodsForEachGoodsTypeToolStripMenuItem
            // 
            this.numberOfGoodsForEachGoodsTypeToolStripMenuItem.Name = "numberOfGoodsForEachGoodsTypeToolStripMenuItem";
            this.numberOfGoodsForEachGoodsTypeToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.numberOfGoodsForEachGoodsTypeToolStripMenuItem.Text = "Number of goods for each goods type";
            this.numberOfGoodsForEachGoodsTypeToolStripMenuItem.Click += new System.EventHandler(this.numberOfGoodsForEachGoodsTypeToolStripMenuItem_Click);
            // 
            // cB_GoodsType
            // 
            this.cB_GoodsType.FormattingEnabled = true;
            this.cB_GoodsType.Location = new System.Drawing.Point(658, 54);
            this.cB_GoodsType.Name = "cB_GoodsType";
            this.cB_GoodsType.Size = new System.Drawing.Size(256, 21);
            this.cB_GoodsType.TabIndex = 4;
            this.cB_GoodsType.Text = "Select goods type";
            this.cB_GoodsType.SelectedValueChanged += new System.EventHandler(this.cB_GoodsType_SelectedValueChanged);
            // 
            // cB_Suppliers
            // 
            this.cB_Suppliers.FormattingEnabled = true;
            this.cB_Suppliers.Location = new System.Drawing.Point(941, 54);
            this.cB_Suppliers.Name = "cB_Suppliers";
            this.cB_Suppliers.Size = new System.Drawing.Size(235, 21);
            this.cB_Suppliers.TabIndex = 4;
            this.cB_Suppliers.Text = "Choose a supplier";
            this.cB_Suppliers.SelectedValueChanged += new System.EventHandler(this.cB_Suppliers_SelectedValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 647);
            this.Controls.Add(this.cB_Suppliers);
            this.Controls.Add(this.cB_GoodsType);
            this.Controls.Add(this.lb_Show);
            this.Controls.Add(this.lb_Goods);
            this.Controls.Add(this.lb_Stock);
            this.Controls.Add(this.lb_Suppliers);
            this.Controls.Add(this.lb_Goods_type);
            this.Controls.Add(this.dGVShow);
            this.Controls.Add(this.dGVGoods);
            this.Controls.Add(this.dGVStock);
            this.Controls.Add(this.dGVGoods_type);
            this.Controls.Add(this.dGVSuppliers);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVGoods_type)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVGoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveChangesToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dGVSuppliers;
        private System.Windows.Forms.DataGridView dGVStock;
        private System.Windows.Forms.DataGridView dGVGoods_type;
        private System.Windows.Forms.DataGridView dGVGoods;
        private System.Windows.Forms.ToolStripMenuItem showInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goodWithMinimalCostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goodWithMaximumCostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goodWithMaximumQuantityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goodWithMinimalQuantityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allInformationAboutTheGoodToolStripMenuItem;
        private System.Windows.Forms.DataGridView dGVShow;
        private System.Windows.Forms.Label lb_Goods_type;
        private System.Windows.Forms.Label lb_Goods;
        private System.Windows.Forms.Label lb_Suppliers;
        private System.Windows.Forms.Label lb_Stock;
        private System.Windows.Forms.Label lb_Show;
        private System.Windows.Forms.ToolStripMenuItem oldestGoodsInStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numberOfGoodsForEachGoodsTypeToolStripMenuItem;
        private System.Windows.Forms.ComboBox cB_GoodsType;
        private System.Windows.Forms.ComboBox cB_Suppliers;
    }
}

