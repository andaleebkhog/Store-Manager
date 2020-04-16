using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Manager
{
    public partial class Form1 : Form
    {
        Store store = new Store();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeEFDBDataSet.Store' table. You can move, or remove it, as needed.
            this.storeTableAdapter.Fill(this.storeEFDBDataSet.Store);
            storeGroupBox.Visible = false;
            StoresDataGridView();

        }



        private void storeToolStripMenuItem1_Click(object sender, EventArgs e) //store visibility
        {
            storeGroupBox.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e) //cancel btn
        {
            Clear();
        }
        
        void Clear()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
            
        }
        
        void StoresDataGridView()
        {
            StoreDGV.AutoGenerateColumns = false;
            using(StoreEFDBEntities db = new StoreEFDBEntities())
            {
                StoreDGV.DataSource = db.Stores.ToList<Store>();
            }
        }

        private void button1_Click(object sender, EventArgs e) // save in store
        {
            //string storeid = store.s_id.ToString();
            //storeid = textBox1.Text;
            store.s_id = Convert.ToInt32(textBox1.Text);
            store.s_name = textBox2.Text;
            store.s_address = textBox3.Text;
            store.s_manager = textBox4.Text;
            using (StoreEFDBEntities storeEFDBEntities = new StoreEFDBEntities())
            {
                //if (store.s_id == 0)//insert
                    storeEFDBEntities.Stores.Add(store);
                //else //update
               //    storeEFDBEntities.Entry(store).State = EntityState.Modified;
                storeEFDBEntities.SaveChanges();
            }
            Clear();
            StoresDataGridView();
            MessageBox.Show("Store added successfully!");
        }

        private void StoreDGV_DoubleClick(object sender, EventArgs e)
        {
            if(StoreDGV.CurrentRow.Index != -1)
            {
                store.s_id = Convert.ToInt32(StoreDGV.CurrentRow.Cells[0].Value);
                using(StoreEFDBEntities storeEFDBEntities = new StoreEFDBEntities())
                {
                    store = storeEFDBEntities.Stores.Where(x => x.s_id == store.s_id).FirstOrDefault();
                    textBox2.Text = store.s_name;
                    textBox3.Text = store.s_address;
                    textBox4.Text = store.s_manager;
                    storeEFDBEntities.SaveChanges();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            store.s_id = Convert.ToInt32(textBox1.Text);
            store.s_name = textBox2.Text;
            store.s_address = textBox3.Text;
            store.s_manager = textBox4.Text;
            using (StoreEFDBEntities storeEFDBEntities = new StoreEFDBEntities())
            {
                storeEFDBEntities.Entry(store).State = EntityState.Modified;
                storeEFDBEntities.SaveChanges();
            }

            Clear();
            StoresDataGridView();
            MessageBox.Show("Store updated successfully!");
        }
    }
}
