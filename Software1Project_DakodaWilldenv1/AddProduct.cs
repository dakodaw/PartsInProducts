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
    public partial class Frm_AddProduct : Form
    {
        //Class Used Variables
        private DataTable dtPartsAvailable = new DataTable();
        private DataTable dtPartsUsed = new DataTable();
        private List<Part> partsAvaliable = new List<Part>();
        private List<Part> partsInProduct = new List<Part>();
        private Inventory availableInventory = new Inventory();
        private Product newProduct;
        private bool success = false;
        private string generalExceptionString = "Conversions Failed. One or more types are not correct.\n They should be the following: \n Name = string \ninv = int \nprice = double \nmax = int \nmin = int";



        //CONSTRUCTORS

        /// <summary>
        /// Main Constructor
        /// </summary>
        public Frm_AddProduct()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Add Product Constructor to include data from Main form
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="inv"></param>
        public Frm_AddProduct(DataTable dt, Inventory inv)
        {
            InitializeComponent();

            // Get the available Inventory to use in other methods
            availableInventory = inv;
            partsAvaliable = availableInventory.GetParts();
            newProduct = new Product(inv);

            //Bind the DataTable to the gridView
            dtPartsAvailable = dt;
            dataGridViewPartsProduct.Columns.Clear();
            dataGridViewPartsProduct.DataSource = dtPartsAvailable;


            //Create DataTable for Parts used in Product
            //Create a datatable to hold the table structure in it.
            dtPartsUsed.Columns.Add("Part ID", typeof(int));
            dtPartsUsed.Columns.Add("Part Name", typeof(string));
            dtPartsUsed.Columns.Add("Inventory Level", typeof(int));
            dtPartsUsed.Columns.Add(@"Price/Cost Per Unit", typeof(double));

            //Clear Columns and bind them to a datasource
            dataGridViewProductIncludedItems.Columns.Clear();
            dataGridViewProductIncludedItems.DataSource = dtPartsUsed;
        }

        public void Frm_AddProduct_Load(object sender, EventArgs e)
        {

        }

        // EVENT HANDLERS

        /// <summary>
        /// Closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_CancelProduct_Click(object sender, EventArgs e)
        {
            //Close Secondary Form
            Close();
        }

        /// <summary>
        /// Adds a Part to the list of Parts in a Product And DataTable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_AddPartsToProduct_Click(object sender, EventArgs e)
        {
            // Get the ID of the selected part
            int selectedIndex = dataGridViewPartsProduct.SelectedCells[0].RowIndex;
            string selectedValue = dataGridViewPartsProduct.SelectedCells[0].Value.ToString();
            int selectedRowID = Convert.ToInt32(selectedValue);

            //Get the part from inventory that matches the ID selected
            var part1 = availableInventory.lookupPart(selectedRowID);

            //Add part to parts in product list
            newProduct.addAssociatedPart(selectedRowID);
            partsInProduct.Add(part1);
            //Add a row to DataTable
            addRowsToUsedParts(part1);           
        }

        /// <summary>
        /// Deletes a Part from the list of parts in a product
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_DeletePartFromProduct_Click(object sender, EventArgs e)
        {
            //Get the selected index
            int selectedIndex = dataGridViewProductIncludedItems.CurrentCell.RowIndex;
            //Get the ID value of the selected value
            string selectedValue = dataGridViewProductIncludedItems.SelectedCells[0].Value.ToString();
            int selectedRowID = Convert.ToInt32(selectedValue);

            // Remove the part from the Product Object with the given Part ID
            newProduct.removeAssociatedPart(selectedRowID);

            //Remove the part from the Datatable at the index it is
            dtPartsUsed.Rows.RemoveAt(selectedIndex);
        }

        /// <summary>
        /// Saves a Product when the save button is pressed, and form closes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_SaveProduct_Click(object sender, EventArgs e)
        {
            try
            {
                //Create an object of a Part, whether it be Inhouse our Outsourced
                CreateNewProduct();

                //Close Secondary Form
                Close();
            }
            catch (Exception newException)
            {
                MessageBox.Show(newException.ToString());
            }
        }

        /// <summary>
        /// Search for the Parts in the Products form when Search button is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_SearchPartsNProduct_Click(object sender, EventArgs e)
        {
            DataTable searchedTable = new DataTable();
            //Add Column Headers to Datatable with Searched Results
            searchedTable.Columns.Add("Part ID", typeof(int));
            searchedTable.Columns.Add("Part Name", typeof(string));
            searchedTable.Columns.Add("Inventory Level", typeof(int));
            searchedTable.Columns.Add(@"Price/Cost Per Unit", typeof(double));

            //Get Searched Term
            string searchedTerm = Txt_PartsNProductSearch.Text.ToString();

            searchedTable.Rows.Clear();
            partsAvaliable = availableInventory.GetParts();
            foreach (var part in partsAvaliable)
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
            dataGridViewPartsProduct.DataSource = searchedTable;

            // Reset to all available parts if search field is blank and search is pressed
            if (searchedTerm == "")
            {
                dataGridViewPartsProduct.DataSource = dtPartsAvailable;
            }
        }

        /// <summary>
        /// Allow Enter in Textbox to press search button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Txt_PartsNProductSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_SearchPartsNProduct_Click(this, new EventArgs());
            }
        }


        //OTHER METHODS

        /// <summary>
        /// Creates a New Product
        /// </summary>
        private void CreateNewProduct()
        {
            try
            {
                int instock = Convert.ToInt32(Txt_ProductInv.Text);
                newProduct.setInStock(instock);
                int max = Convert.ToInt32(Txt_ProductMax.Text);
                newProduct.setMax(max);
                int min = Convert.ToInt32(Txt_ProductMin.Text);
                newProduct.setMin(min);
                string name = Txt_ProductNameMain.Text.ToString();
                newProduct.setName(name);
                double price = Convert.ToDouble(Txt_ProductPrice.Text);
                newProduct.setPrice(price);
                //Parts were already added to object when they were added to the table, and or removed from the object then.
                //Set Success = true
                success = true;

                //If max is less than min, throw an exception
                if (max < min)
                {
                    generalExceptionString = "\n\nMaximum must be greater than Minimum\n\n";
                    throw new Exception(generalExceptionString);
                }
                //Get the number of Parts in a Product. If the number is less than 1, throw an error that there are no parts
                var numOfAssociatedParts = newProduct.getAssociatedParts();
                if (numOfAssociatedParts.Count() < 1)
                {
                    generalExceptionString = "\n\nA product must include at least one part!!\n\n";
                    throw new Exception(generalExceptionString);
                }

                // Check to make sure the cost of the product can't be below the cost of the parts
                double totalCost = 0.0;
                foreach(var associatedPart in numOfAssociatedParts)
                {
                    totalCost += associatedPart.getPrice();
                }
                if (totalCost > price)
                {
                    generalExceptionString = "Price of Product cannot exceed the total cost of the parts";
                    throw new Exception(generalExceptionString);
                }
                
            }
            catch
            {
                //Pass on the thrown exceptions, or catch any conversion errors
                throw new Exception(generalExceptionString);
            }
        }

        /// <summary>
        /// Repopulates Used Parts DataTable
        /// </summary>
        /// <param name="dt"></param>
        private void repopulatePartsUsedDatatable(DataTable dt)
        {
            dt.Rows.Clear();
            foreach (var part in partsInProduct)
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

        /// <summary>
        /// Adds a Row to the parts used DataTable
        /// </summary>
        /// <param name="pt"></param>
        private void addRowsToUsedParts(Part pt)
        {
            //Create Row for Data Table with the information from get methods
            DataRow dr = dtPartsUsed.NewRow();
            dr["Part ID"] = pt.getPartId();
            dr["Part Name"] = pt.getName();
            dr["Inventory Level"] = pt.getInStock();
            dr[@"Price/Cost Per Unit"] = pt.getPrice();
            dtPartsUsed.Rows.Add(dr);
        }

        /// <summary>
        /// Repopulates Parts Available DataTable
        /// </summary>
        /// <param name="dt"></param>
        private void repopulatePartsAvailableDatatable(DataTable dt)
        {
            dt.Rows.Clear();
            partsAvaliable = availableInventory.GetParts();
            foreach (var part in partsAvaliable)
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

        /// <summary>
        /// Returns true if the Product was successfully created
        /// </summary>
        /// <returns></returns>
        public bool getSuccess()
        {
            return success;
        }

        /// <summary>
        /// Returns the Product created in the object
        /// </summary>
        /// <returns></returns>
        public Product GetProduct()
        {
            return newProduct;
        }
    }
}
