using Software1Project_DakodaWilldenv1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software1Project_DakodaWilldenv1
{
    public partial class Frm_Main : Form
    {
        //Datatable and inventory to use in different Methods
        private DataTable dtParts = new DataTable();
        private DataTable dtProducts = new DataTable();
        private Inventory inv = new Inventory();
        private List<Part> parts = new List<Part>();
        private List<Product> products = new List<Product>();

        // Constructors

        /// <summary>
            /// Main Constructor
            /// </summary>
        public Frm_Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form Loader
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_Main_Load(object sender, EventArgs e)
        {
            loadInitialObjects();
        }

        //Methods for class use
        /// <summary>
        /// Loads 4 initial Part objects and 2 Product objects on startup
        /// </summary>
        private void loadInitialObjects()
        {
            //Create a list of Inhouse Objects, Create Objects, and add them to the list to load with the Application


            //Create Parts, and add them to inventory
            var inhousePart1 = new Inhouse("Motors", 33.29, 6, 1, 15, 33);
            inv.addPart(inhousePart1);

            var inhousePart2 = new Inhouse("Gears", 1.22, 5, 1, 33, 11);
            inv.addPart(inhousePart2);

            var inhousePart3 = new Inhouse("Air Freshners", 0.99, 50, 1, 100, 20);
            inv.addPart(inhousePart3);

            var outsourced1 = new Outsourced("Screamers", 30.22, 5, 1, 10, "Monsters Inc");
            inv.addPart(outsourced1);

            //Create Products, then add them to inventory

            //Create list of Parts for Product
            List<Part> productListofParts1 = new List<Part>();
            productListofParts1.Add(outsourced1);
            productListofParts1.Add(inhousePart1);
            var product1 = new Product("Monster Stuff", 200.00, 3, 1, 10, productListofParts1, inv);
            inv.addProduct(product1);

            List<Part> productListofParts2 = new List<Part>();
            productListofParts2.Add(inhousePart1);
            productListofParts2.Add(inhousePart2);
            productListofParts2.Add(inhousePart3);
            var product2 = new Product("Car Stuff", 400.00, 2, 1, 5, productListofParts2, inv);
            inv.addProduct(product2);


            //Create a datatable to hold the table structure in it.
            dtParts.Columns.Add("Part ID", typeof(int));
            dtParts.Columns.Add("Part Name", typeof(string));
            dtParts.Columns.Add("Inventory Level", typeof(int));
            dtParts.Columns.Add(@"Price/Cost Per Unit", typeof(double));

            //Create a datatable to hold the Product table structure in it.
            dtProducts.Columns.Add("Product ID", typeof(int));
            dtProducts.Columns.Add("Product Name", typeof(string));
            dtProducts.Columns.Add("Inventory Level", typeof(int));
            dtProducts.Columns.Add(@"Price Per Unit", typeof(double));

            //Populate Parts Data Table with inventory object
            repopulatePartsDatatable(dtParts, inv);
            repopulateProductsDatatable(dtProducts, inv);

            //Bind the Parts DataTable to the gridView
            dataGridViewParts.Columns.Clear();
            dataGridViewParts.DataSource = dtParts;

            //bind Products DataTable to gridview
            dataGridViewProducts.Columns.Clear();
            dataGridViewProducts.DataSource = dtProducts;
        }

        /// <summary>
        /// Updates the Parts table with the most recent inventory
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="inv"></param>
        private void repopulatePartsDatatable(DataTable dt, Inventory inv)
        {
            dt.Rows.Clear();
            parts = inv.GetParts();
            foreach (var part in parts)
            {
                //Create Row for Data Table with the information from get methods
                DataRow dr = dt.NewRow();
                dr["Part ID"] = part.getPartId();
                dr["Part Name"] = part.getName();
                dr["Inventory Level"] = part.getInStock();
                dr[@"Price/Cost Per Unit"] = part.getPrice();
                dt.Rows.Add(dr);
            }
        }

        private void repopulateProductsDatatable(DataTable dt, Inventory inv)
        {
            dt.Rows.Clear();
            products = inv.GetProducts();
            foreach (var product in products)
            {
                //Create Row for Data Table with the information from get methods
                DataRow dr = dt.NewRow();
                dr["Product ID"] = product.getProductID();
                dr["Product Name"] = product.getName();
                dr["Inventory Level"] = product.getInStock();
                dr[@"Price Per Unit"] = product.getPrice();
                dt.Rows.Add(dr);
            }
        }


        //EVENT HANDLERS

            //Part Functions

        /// <summary>
        /// Open the add parts form when the add parts button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_AddParts_Click(object sender, EventArgs e)
        {
            //Initialize a new form()
            Frm_AddPart frmNew = new Frm_AddPart() ;
            frmNew.ShowDialog();

            //if the object is created, add the object to inventory, then rebind the datatable to it
            if(frmNew.getSuccess() == true)
            {
                inv.addPart(frmNew.getNewPart());
                repopulatePartsDatatable(dtParts, inv);
            }
        }

        /// <summary>
        /// Pulls up a form to modify the selected Part
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_ModifyParts_Click(object sender, EventArgs e)
        {
            //Save the selected ID to a local variable
            int selectedRowID = dataGridViewParts.SelectedCells[0].RowIndex;
            string selectedValue = dataGridViewParts.SelectedCells[0].Value.ToString();
            selectedRowID = Convert.ToInt32(selectedValue);

            //Use ID to look up part in inventory, and save to local variable
            Part oldPart = inv.lookupPart(selectedRowID);

            //Initialize a new form with the part selected
            Frm_ModifyPart frmNew = new Frm_ModifyPart(oldPart);
            frmNew.ShowDialog();

            if (frmNew.getSuccess() == true)
            {
                inv.updatePart(selectedRowID, frmNew.getNewPart());
                repopulatePartsDatatable(dtParts, inv);
            }
        }

        /// <summary>
        /// Deletes a Selected Part from Inventory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_DeleteParts_Click(object sender, EventArgs e)
        {
            //Save the selected ID to a local variable
            int selectedRowID = dataGridViewParts.SelectedCells[0].RowIndex;
            string selectedValue = dataGridViewParts.SelectedCells[0].Value.ToString();
            selectedRowID = Convert.ToInt32(selectedValue);


            Part oldPart = inv.lookupPart(selectedRowID);
            inv.deletePart(oldPart);
            repopulatePartsDatatable(dtParts, inv);
        }

        /// <summary>
        /// Searches for matching names of Parts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_SearchParts_Click(object sender, EventArgs e)
        {
            DataTable searchedTable = new DataTable();
            //Add Column Headers to Datatable with Searched Results
            searchedTable.Columns.Clear();
            searchedTable.Columns.Add("Part ID", typeof(int));
            searchedTable.Columns.Add("Part Name", typeof(string));
            searchedTable.Columns.Add("Inventory Level", typeof(int));
            searchedTable.Columns.Add(@"Price/Cost Per Unit", typeof(double));

            //Get Searched Term
            string searchedTerm = Txt_PartsSearch.Text.ToString();

            searchedTable.Rows.Clear();
            parts = inv.GetParts();
            foreach (var part in parts)
            {
                //Add rows only if the name matches
                string objectTerm = part.getName();
                bool stringCheck = string.Equals(objectTerm, searchedTerm);
                if (stringCheck == true)
                {
                    //Create Row for Data Table with the information from get methods
                    DataRow dr = searchedTable.NewRow();
                    dr["Part ID"] = part.getPartId();
                    dr["Part Name"] = part.getName();
                    dr["Inventory Level"] = part.getInStock();
                    dr[@"Price/Cost Per Unit"] = part.getPrice();
                    searchedTable.Rows.Add(dr);
                }
            }
            dataGridViewParts.DataSource = searchedTable;

            // Reset to all available parts if search field is blank and search is pressed
            if (searchedTerm == "")
            {
                dataGridViewParts.DataSource = dtParts;
            }
        }


            //Product Functions

        /// <summary>
        /// Open Product Form when Add Product is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_AddProduct_Click(object sender, EventArgs e)
        {
            //Get the most recent list of Parts from Inventory, and create a new product form with that Inventory
            Frm_AddProduct addProductForm = new Frm_AddProduct(dtParts, inv);
            addProductForm.ShowDialog();

            if (addProductForm.getSuccess() == true)
            {
                inv.addProduct(addProductForm.GetProduct());
                repopulateProductsDatatable(dtProducts, inv);
            }
 
        }

        /// <summary>
        /// Modifies the values and Parts in a Product when button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_ModifyProduct_Click(object sender, EventArgs e)
        {
            //Save the selected ID to a local variable
            int selectedIndex = dataGridViewProducts.CurrentCell.RowIndex;
            //Get the ID value of the selected value
            string selectedValue = dataGridViewProducts.SelectedCells[0].Value.ToString();
            int selectedRowID = Convert.ToInt32(selectedValue);

            //Lookup Product with the selected ID
            Product currentProduct = inv.lookupProduct(selectedRowID);

            //Open up a new modify product form with the current product information
            Frm_ModifyProduct newForm = new Frm_ModifyProduct(dtParts, inv, currentProduct);
            newForm.ShowDialog();

            // Check if the Updated Product was created, if it was, use it to update the values in the object in Inventory
            if (newForm.getSuccess() == true)
            {
                inv.updateProduct(selectedRowID, newForm.GetProduct());
                repopulateProductsDatatable(dtProducts, inv);
            }
        }

        /// <summary>
        /// Deletes a Product when the Delete button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_DeleteProduct_Click(object sender, EventArgs e)
        {
            //Save the selected ID to a local variable
            int selectedIndex = dataGridViewProducts.CurrentCell.RowIndex;
            //Get the ID value of the selected value
            string selectedValue = dataGridViewProducts.SelectedCells[0].Value.ToString();
            int selectedRowID = Convert.ToInt32(selectedValue);

            // Attempt to remove a Product from Inventory
            bool success = inv.removeProduct(selectedRowID);
            if (success == false)
            {
                //Alerts user of a failure
                MessageBox.Show("Failed to Delete Product");
            }
            // Reset the table with the current values in inventory
            repopulateProductsDatatable(dtProducts, inv);
        }

        /// <summary>
        /// Searches the Names of the Product Table, and presents the products that match
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_ProductSearch_Click(object sender, EventArgs e)
        {
            DataTable searchedTable = new DataTable();
            //Add Column Headers to Datatable with Searched Results
            searchedTable.Columns.Clear();
            searchedTable.Columns.Add("Product ID", typeof(int));
            searchedTable.Columns.Add("Product Name", typeof(string));
            searchedTable.Columns.Add("Inventory Level", typeof(int));
            searchedTable.Columns.Add(@"Price Per Unit", typeof(double));

            //Get Searched Term
            string searchedTerm = Txt_ProductSearch.Text.ToString();

            //Clear DataTable Rows, retreive the products from Inventory, and fill the datatable with the results
            searchedTable.Rows.Clear();
            products = inv.GetProducts();
            foreach (var product in products)
            {
                //Add rows only if the name matches
                string objectTerm = product.getName();
                bool stringCheck = string.Equals(objectTerm, searchedTerm);
                if (stringCheck == true)
                {
                    //Create Row for Data Table with the information from get methods
                    DataRow dr = searchedTable.NewRow();
                    dr["Product ID"] = product.getProductID();
                    dr["Product Name"] = product.getName();
                    dr["Inventory Level"] = product.getInStock();
                    dr[@"Price Per Unit"] = product.getPrice();
                    searchedTable.Rows.Add(dr);
                }
            }
            //By Default, change the datasource to the searched datatable for the data grid view
            dataGridViewProducts.DataSource = searchedTable;

            // Reset to all available parts if search field is blank and search is pressed
            if (searchedTerm == "")
            {
                dataGridViewProducts.DataSource = dtProducts;
            }
        }

        //General Form Handlers
        /// <summary>
        /// Close the Program when pressing the exit button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            //Exit the Program
            Application.Exit();
        }


        /// <summary>
        /// Allow Search Button to be pressed while in the search textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Txt_PartsSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Btn_SearchParts_Click(this, new EventArgs());
            }
        }

        /// <summary>
        /// Allow Search Button to be pressed while in the Products Search Textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Txt_ProductSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_ProductSearch_Click(this, new EventArgs());
            }
        }
    }
}
