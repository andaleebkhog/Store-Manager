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
        Category category = new Category();
        Category_Unit categoryunit = new Category_Unit();
        Supplier supplier = new Supplier();
        Customer customer = new Customer();
        public Form1()
        {
            InitializeComponent();
            this.Validate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeEFDBDataSet.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.storeEFDBDataSet.Supplier);
            // TODO: This line of code loads data into the 'storeEFDBDataSet.Category_Unit' table. You can move, or remove it, as needed.
            this.category_UnitTableAdapter.Fill(this.storeEFDBDataSet.Category_Unit);
            // TODO: This line of code loads data into the 'storeEFDBDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.storeEFDBDataSet.Customer);
            // TODO: This line of code loads data into the 'storeEFDBDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.storeEFDBDataSet.Category);
            // TODO: This line of code loads data into the 'storeEFDBDataSet.Store' table. You can move, or remove it, as needed.
            this.storeTableAdapter.Fill(this.storeEFDBDataSet.Store);
            storeGroupBox.Visible = false;
            StoresDataGridView();
            CategoryDataGridView();
            CategoryGroupBox.Visible = false;
            UnitCategoryDataGridView();
            SupplierGroupBox.Visible = false;
            SupplierGridViewer();
            CustomerGroupBox.Visible = false;
            CustomerGridViewer();

        }


        ///////////////////////////////////////////////////// STORE
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
            textBox5.Text = textBox6.Text =textBox7.Text = textBox8.Text = "";
            textBox9.Text = textBox10.Text = textBox11.Text = textBox12.Text = textBox13.Text = textBox14.Text = textBox15.Text = "";
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

        private void StoreDGV_DoubleClick(object sender, EventArgs e) //selection from gridview
        {
            if(StoreDGV.CurrentRow.Index != -1)
            {
                store.s_id = Convert.ToInt32(StoreDGV.CurrentRow.Cells[0].Value);
                using(StoreEFDBEntities storeEFDBEntities = new StoreEFDBEntities())
                {
                    store = storeEFDBEntities.Stores.Where(x => x.s_id == store.s_id).FirstOrDefault();
                    textBox1.Text = store.s_id.ToString();
                    textBox2.Text = store.s_name;
                    textBox3.Text = store.s_address;
                    textBox4.Text = store.s_manager;
                    storeEFDBEntities.SaveChanges();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) //update btn
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

        //////////////////////////////////////////////////////////////////////// CATEGORY ///////////

        void CategoryDataGridView()
        {
            CategoryDGV.AutoGenerateColumns = false;
            using (StoreEFDBEntities db = new StoreEFDBEntities())
            {
                CategoryDGV.DataSource = db.Categories.ToList<Category>();
            }
        }

        void UnitCategoryDataGridView()
        {
            UnitCategoryDGV.AutoGenerateColumns = false;
            using (StoreEFDBEntities db = new StoreEFDBEntities())
            {
                UnitCategoryDGV.DataSource = db.Category_Unit.ToList<Category_Unit>();
            }
        }

        private void categoryToolStripMenuItem1_Click(object sender, EventArgs e) //category visibility
        {
            CategoryGroupBox.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e) //categ insert
        {
            category.c_id = categoryunit.c_id = Convert.ToInt32(textBox5.Text);
            category.c_name = textBox6.Text;
            categoryunit.unit_id = Convert.ToInt32(textBox8.Text);
            categoryunit.unit = textBox7.Text;
            
            using (StoreEFDBEntities db = new StoreEFDBEntities())
            {
                //if (store.s_id == 0)//insert
                db.Categories.Add(category);
                db.Category_Unit.Add(categoryunit);
                //else //update
                //    storeEFDBEntities.Entry(store).State = EntityState.Modified;
                db.SaveChanges();
            }
            Clear();
            CategoryDataGridView();
            UnitCategoryDataGridView();
            MessageBox.Show("Category added successfully!");
        }


        private void CategoryDGV_DoubleClick(object sender, EventArgs e)
        {
            category.c_id = Convert.ToInt32(CategoryDGV.CurrentRow.Cells[0].Value);
            categoryunit.c_id = Convert.ToInt32(CategoryDGV.CurrentRow.Cells[0].Value);

            using (StoreEFDBEntities storeEFDBEntities = new StoreEFDBEntities())
            {
                category = storeEFDBEntities.Categories.Where(x => x.c_id == category.c_id).FirstOrDefault();
                categoryunit = storeEFDBEntities.Category_Unit.Where(x => x.c_id == categoryunit.c_id).FirstOrDefault();
                textBox5.Text = Convert.ToString(category.c_id);
                textBox6.Text = category.c_name;
                //if(categoryunit.unit_id !=)
                //{
                    textBox8.Text = Convert.ToString(categoryunit.unit_id);
                //}
                //else
                //{
                //    textBox8.Text = "";
                //    textBox7.Text = "";
                //}
                
                textBox7.Text = categoryunit.unit;
                
                storeEFDBEntities.SaveChanges();
            }
        }

        private void UnitCategoryDGV_DoubleClick(object sender, EventArgs e)
        {
            categoryunit.c_id = Convert.ToInt32(CategoryDGV.CurrentRow.Cells[0].Value);
            using (StoreEFDBEntities storeEFDBEntities = new StoreEFDBEntities())
            {
                category = storeEFDBEntities.Categories.Where(x => x.c_id == category.c_id).FirstOrDefault();
                categoryunit = storeEFDBEntities.Category_Unit.Where(x => x.c_id == categoryunit.c_id).FirstOrDefault();
                textBox5.Text = Convert.ToString(category.c_id);
                textBox6.Text = category.c_name;
                textBox8.Text = Convert.ToString(categoryunit.unit_id);
                textBox7.Text = categoryunit.unit;
                textBox5.Text = Convert.ToString(categoryunit.c_id);
                storeEFDBEntities.SaveChanges();
            }
        }

        private void button5_Click(object sender, EventArgs e) //update btn
        {
            category.c_id = Convert.ToInt32(textBox5.Text);
            category.c_name = textBox6.Text;
            //categoryunit.unit_id = Convert.ToInt32(textBox8.Text);
            categoryunit.unit = textBox7.Text;
            //categoryunit.c_id = Convert.ToInt32(textBox5.Text);
            using (StoreEFDBEntities db = new StoreEFDBEntities())
            {
                db.Entry(category).State = EntityState.Modified;
                db.Entry(categoryunit).State = EntityState.Modified;
                db.SaveChanges();
            }

            Clear();
            CategoryDataGridView();
            UnitCategoryDataGridView();
            MessageBox.Show("Category updated successfully!");
        }

        private void button6_Click(object sender, EventArgs e) //cancel btn
        {
            Clear();
            
        }

        /////////////////////////////////////////// SUPPLIER /////////////////////

        private void supplierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SupplierGroupBox.Visible = true;
        }

        void SupplierGridViewer()
        {
            SupplierDGV.AutoGenerateColumns = false;
            using (StoreEFDBEntities db = new StoreEFDBEntities())
            {
                SupplierDGV.DataSource = db.Suppliers.ToList<Supplier>();
            }
        }

        private void button7_Click(object sender, EventArgs e) //Supplier insert
        {
            supplier.supp_id = Convert.ToInt32(textBox9.Text);
            supplier.supp_name = textBox10.Text;
            supplier.supp_phone = textBox11.Text;
            supplier.supp_fax = textBox12.Text;
            supplier.supp_mobile = textBox13.Text;
            supplier.supp_mail = textBox14.Text;
            supplier.supp_website = textBox15.Text;

            using (StoreEFDBEntities db = new StoreEFDBEntities())
            {
                db.Suppliers.Add(supplier);
                db.SaveChanges();
            }
            Clear();
            SupplierGridViewer();
            MessageBox.Show("Supplier added successfully!");
        }

        private void SupplierDGV_DoubleClick(object sender, EventArgs e)
        {
            supplier.supp_id = Convert.ToInt32(SupplierDGV.CurrentRow.Cells[0].Value);
            using (StoreEFDBEntities db = new StoreEFDBEntities())
            {
                supplier = db.Suppliers.Where(x => x.supp_id == supplier.supp_id).FirstOrDefault();
                textBox9.Text = supplier.supp_id.ToString();
                textBox10.Text = supplier.supp_name;
                textBox11.Text = supplier.supp_phone;
                textBox12.Text = supplier.supp_fax;
                textBox13.Text = supplier.supp_mobile;
                textBox14.Text = supplier.supp_mail;
                textBox15.Text = supplier.supp_website;
                db.SaveChanges();
            }
        }

        private void button8_Click(object sender, EventArgs e) //supplier update btn
        {
            supplier.supp_id = Convert.ToInt32(textBox9.Text);
            supplier.supp_name = textBox10.Text;
            supplier.supp_phone = textBox11.Text;
            supplier.supp_fax = textBox12.Text;
            supplier.supp_mobile = textBox13.Text;
            supplier.supp_mail = textBox14.Text;
            supplier.supp_website = textBox15.Text;
            using (StoreEFDBEntities db = new StoreEFDBEntities())
            {
                db.Entry(supplier).State = EntityState.Modified;
                db.SaveChanges();
            }

            Clear();
            SupplierGridViewer();
            MessageBox.Show("Supplier updated successfully!");
        }

        ////////////////////////////////// CUSTOMERRRR /////////////////////////

        private void customerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CustomerGroupBox.Visible = true;
        }

        void CustomerGridViewer()
        {
            CustomerDGV.AutoGenerateColumns = false;
            using (StoreEFDBEntities db = new StoreEFDBEntities())
            {
                CustomerDGV.DataSource = db.Customers.ToList<Customer>();
            }
        }

        private void button12_Click(object sender, EventArgs e) //customer insert btn
        {

            customer.cust_id = Convert.ToInt32(textBox22.Text);
            customer.cust_name = textBox21.Text;
            customer.cust_phone = textBox20.Text;
            customer.cust_fax = textBox19.Text;
            customer.cust_mobile = textBox18.Text;
            customer.cust_mail = textBox17.Text;
            customer.cust_website = textBox16.Text;

            using (StoreEFDBEntities db = new StoreEFDBEntities())
            {
                db.Customers.Add(customer);
                db.SaveChanges();
            }
            Clear();
            CustomerGridViewer();
            MessageBox.Show("Customer added successfully!");
        }

        private void CustomerDGV_DoubleClick(object sender, EventArgs e)
        {
            customer.cust_id = Convert.ToInt32(CustomerDGV.CurrentRow.Cells[0].Value);
            using (StoreEFDBEntities db = new StoreEFDBEntities())
            {
                customer = db.Customers.Where(x => x.cust_id == customer.cust_id).FirstOrDefault();
                textBox22.Text = customer.cust_id.ToString();
                textBox21.Text = customer.cust_name;
                textBox20.Text = customer.cust_phone;
                textBox19.Text = customer.cust_fax;
                textBox18.Text = customer.cust_mobile;
                textBox17.Text = customer.cust_mail;
                textBox16.Text = customer.cust_website;
                db.SaveChanges();
            }
        }

        private void button11_Click(object sender, EventArgs e) //customer update
        {
            customer.cust_id = Convert.ToInt32(textBox22.Text);
            customer.cust_name = textBox21.Text;
            customer.cust_phone = textBox20.Text;
            customer.cust_fax = textBox19.Text;
            customer.cust_mobile = textBox18.Text;
            customer.cust_mail = textBox17.Text;
            customer.cust_website = textBox16.Text;
            using (StoreEFDBEntities db = new StoreEFDBEntities())
            {
                db.Entry(customer).State = EntityState.Modified;
                db.SaveChanges();
            }

            Clear();
            SupplierGridViewer();
            MessageBox.Show("Customer updated successfully!");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
