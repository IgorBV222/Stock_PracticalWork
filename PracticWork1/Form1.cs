using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Xml.Linq;

namespace PracticWork1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private SQLiteConnection conn;
        private DataTable dtGoods_type;
        private DataTable dtGoods;
        private DataTable dtSuppliers;
        private DataTable dtStock;
        private DataTable dtAllGoods;
        private DataTable dtType_goods;
        private DataTable dtSuppliers_goods;

        private SQLiteDataAdapter adGoods_type;
        private SQLiteDataAdapter adGoods;
        private SQLiteDataAdapter adSuppliers;
        private SQLiteDataAdapter adStock;
        private SQLiteDataAdapter adAllGoods;
        private SQLiteDataAdapter adType_goods;
        private SQLiteDataAdapter adSuppliers_goods;


        private void SelectDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                conn = new SQLiteConnection("DataSource=" + filename);
                conn.Open(); // создаст файл 
                string sqltext = "select name from sqlite_master where type='table';";

                using (SQLiteCommand cmd = new SQLiteCommand(sqltext, conn))
                {
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    CreateTablesToolStripMenuItem.Enabled = !reader.HasRows; // отключаем кнопку создания таблиц
                    if (reader.HasRows)
                    {                        
                        dGVShowGoods_type();
                        dGVShowGoods();
                        dGVShowSuppliers();
                        dGVShowStock();
                        cB_GoodsTypeFillType();
                        cB_SuppliersFillSuppliers();
                    }
                    reader.Close();
                    conn.Close();
                }                             
            }
            else
            {
                //указать что будет если база не откроится база данных
            }
        }

        private void CreateTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sqltext = "create table Goods_type(id INTEGER PRIMARY KEY AUTOINCREMENT, [name] VARCHAR(20));" + 
                "create table Goods(id INTEGER PRIMARY KEY AUTOINCREMENT, id_goods_type INTEGER REFERENCES Goods_type(id), [name] VARCHAR(20));" + 
                "create table Suppliers(id INTEGER PRIMARY KEY AUTOINCREMENT, [name] VARCHAR(20));" +
                "create table Stock(id INTEGER PRIMARY KEY AUTOINCREMENT, id_good INTEGER REFERENCES Goods(id), " +
                "id_supplier INTEGER REFERENCES Suppliers(id), " +
                "amount INTEGER, cost_price REAL, [date] TEXT);";

            using (SQLiteCommand cmd = new SQLiteCommand(sqltext, conn))
            {                
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            CreateTablesToolStripMenuItem.Enabled = false; // отключаем кнопку создания таблиц
        }

        private void dGVShowGoods_type()
        {
            string sqltext = "select * from Goods_type;";
            dtGoods_type = new DataTable();
            adGoods_type = new SQLiteDataAdapter(sqltext, conn);
            adGoods_type.Fill(dtGoods_type);
            dGVGoods_type.DataSource = dtGoods_type;
        }

        private void dGVShowGoods()
        {
            string sqltext = "select * from Goods;";
            dtGoods = new DataTable();
            adGoods = new SQLiteDataAdapter(sqltext, conn);
            adGoods.Fill(dtGoods);
            dGVGoods.DataSource = dtGoods;
        }

        private void dGVShowSuppliers() 
        {
            string sqltext = "select * from Suppliers;";
            dtSuppliers = new DataTable();
            adSuppliers = new SQLiteDataAdapter(sqltext, conn);
            adSuppliers.Fill(dtSuppliers);
            dGVSuppliers.DataSource = dtSuppliers;
        }

        private void dGVShowStock()
        {
            string sqltext = "select * from Stock;";
            dtStock = new DataTable();
            adStock = new SQLiteDataAdapter(sqltext, conn);
            adStock.Fill(dtStock);
            dGVStock.DataSource = dtStock;
        }

        private void allInformationAboutTheGoodToolStripMenuItem_Click(object sender, EventArgs e)
        {        
            string sqltext = "SELECT Goods.name AS 'Good',  Goods_type.name AS ' Goods type', Suppliers.name AS 'Suppliers', " +
                             "Stock.amount AS 'amount', Stock.cost_price AS 'cost_price', Stock.date AS 'date' FROM Goods JOIN Goods_type ON " +
                             "Goods.id_goods_type = Goods_type.id JOIN Stock ON Stock.id_good = Goods.id JOIN Suppliers ON Stock.id_supplier = Suppliers.id;";

            dtAllGoods = new DataTable();
            adAllGoods = new SQLiteDataAdapter(sqltext, conn);
            adAllGoods.Fill(dtAllGoods);            
            dGVShow.DataSource = dtAllGoods;
        }

        private void goodWithMaximumQuantityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sqltext = "SELECT Goods.name AS 'Good', MAX(Stock.amount) AS 'Max amount' FROM Goods JOIN Stock ON Stock.id_good = Goods.id;";
            dtAllGoods = new DataTable();
            adAllGoods = new SQLiteDataAdapter(sqltext, conn);
            adAllGoods.Fill(dtAllGoods);
            dGVShow.DataSource = dtAllGoods;
        }

        private void goodWithMinimalQuantityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sqltext = "SELECT Goods.name AS 'Good', MIN(Stock.amount) AS 'Min amount' FROM Goods JOIN Stock ON Stock.id_good = Goods.id;";
            dtAllGoods = new DataTable();
            adAllGoods = new SQLiteDataAdapter(sqltext, conn);
            adAllGoods.Fill(dtAllGoods);
            dGVShow.DataSource = dtAllGoods;
        }

        private void goodWithMinimalCostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sqltext = "SELECT Goods.name AS 'Good', Suppliers.name AS 'Suppliers', MIN(Stock.cost_price) AS 'Min cost_price' FROM Goods JOIN Stock ON Stock.id_good = Goods.id JOIN Suppliers ON Stock.id_supplier = Suppliers.id;";
            dtAllGoods = new DataTable();
            adAllGoods = new SQLiteDataAdapter(sqltext, conn);
            adAllGoods.Fill(dtAllGoods);
            dGVShow.DataSource = dtAllGoods;
        }

        private void goodWithMaximumCostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sqltext = "SELECT Goods.name AS 'Good', Suppliers.name AS 'Suppliers', MAX(Stock.cost_price) AS 'Max cost_price' FROM Goods JOIN Stock ON Stock.id_good = Goods.id JOIN Suppliers ON Stock.id_supplier = Suppliers.id;";
            dtAllGoods = new DataTable();
            adAllGoods = new SQLiteDataAdapter(sqltext, conn);
            adAllGoods.Fill(dtAllGoods);
            dGVShow.DataSource = dtAllGoods;
        }

        private void oldestGoodsInStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sqltext = "SELECT Goods.name AS 'Good', Suppliers.name AS 'Suppliers', MIN(Stock.date) AS 'Oldest date' FROM Goods JOIN Stock ON Stock.id_good = Goods.id JOIN Suppliers ON Stock.id_supplier = Suppliers.id;";
            dtAllGoods = new DataTable();
            adAllGoods = new SQLiteDataAdapter(sqltext, conn);
            adAllGoods.Fill(dtAllGoods);
            dGVShow.DataSource = dtAllGoods;
        }    

        private void numberOfGoodsForEachGoodsTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sqltext = "SELECT Goods_type.name AS 'Goods_type', SUM(Stock.amount) AS 'amount' FROM Goods JOIN Goods_type ON Goods.id_goods_type = Goods_type.id JOIN Stock ON Stock.id_good = Goods.id GROUP BY Goods_type.name;";
            dtAllGoods = new DataTable();
            adAllGoods = new SQLiteDataAdapter(sqltext, conn);
            adAllGoods.Fill(dtAllGoods);
            dGVShow.DataSource = dtAllGoods;
        }
        private void cB_GoodsTypeFillType()
        {
            string sqltext = "SELECT * FROM Goods_type;";
            SQLiteCommand cmd = new SQLiteCommand(sqltext, conn);
            SQLiteDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cB_GoodsType.Items.Add(dr["name"].ToString());
            }
        }
        private void cB_GoodsType_SelectedValueChanged(object sender, EventArgs e)
        {
            string sqltext = "SELECT Goods.name AS 'Goods' FROM Goods JOIN Goods_type ON Goods_type.id = Goods.id_goods_type";
            sqltext = sqltext + " WHERE Goods_type.name='" + cB_GoodsType.Text + "'";
            adType_goods = new SQLiteDataAdapter(sqltext, conn);

            SQLiteCommandBuilder cbType_goods = new SQLiteCommandBuilder(adType_goods);
            dtType_goods = new DataTable();
            adType_goods.Fill(dtType_goods);
            dGVShow.DataSource = dtType_goods;
        }
        private void cB_SuppliersFillSuppliers()
        {
            string sqltext = "SELECT * FROM Suppliers;";
            SQLiteCommand cmd = new SQLiteCommand(sqltext, conn);
            SQLiteDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cB_Suppliers.Items.Add(dr["name"].ToString());
            }
        }
        private void cB_Suppliers_SelectedValueChanged(object sender, EventArgs e)
        {
            string sqltext = "SELECT Goods.name as 'Goods' FROM Goods JOIN Stock ON Stock.id_good = Goods.id JOIN Suppliers ON Stock.id_supplier = Suppliers.id";
            sqltext = sqltext + " WHERE Suppliers.name='" + cB_Suppliers.Text + "'";
            adSuppliers_goods = new SQLiteDataAdapter(sqltext, conn);

            SQLiteCommandBuilder cb_Suppliers_goods = new SQLiteCommandBuilder(adSuppliers_goods);
            dtSuppliers_goods = new DataTable();
            adSuppliers_goods.Fill(dtSuppliers_goods);
            dGVShow.DataSource = dtSuppliers_goods;
        }
    }
}
