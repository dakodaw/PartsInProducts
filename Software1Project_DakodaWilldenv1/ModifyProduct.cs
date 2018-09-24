using System;
using System.Collections.Generic;
using System.ComponentModel;
using Software1Project_DakodaWilldenv1.Models;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software1Project_DakodaWilldenv1
{
    public partial class Frm_ModifyProduct : Form
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



        // Constructors

        /// <summary>
        /// Main Constructor
        /// </summary>
        public Frm_ModifyProduct()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor for Modifying a Product
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="inv"></param>
        /// <param name="currentProduct"></param>
        public Frm_ModifyProduct(DataTable dt, Inventory inv, Product currentProduct)
        {
            InitializeComponent();

            //Populate Fields with current Product's fields
            Txt_ProductId.Text = currentProduct.getProductID().ToString();
            Txt_ProductInv.Text = currentProduct.getInStock().ToString();
            Txt_ProductMax.Text = currentProduct.getMax().ToString();
            Txt_ProductMin.Text = currentProduct.getMin().ToString();
            Txt_ProductNameMain.Text = currentProduct.getName().ToString();
            Txt_ProductPrice.Text = currentProduct.getPrice().ToString();

            // Get the available Inventory to use in other methods
            availableInventory = inv;
            partsAvaliable = availableInventory.GetParts();
            newProduct = new Product(inv);
            newProduct.setAssociatedParts(partsInProduct);

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

            //Add Parts from current product to used DataTable
            dtPartsUsed.Rows.Clear();
            partsInProduct = currentProduct.getAssociatedParts();
            foreach(var part in partsInProduct)
            {
                addRowsToUsedParts(part);
            }

            //Clear Columns and bind them to a datasource
            dataGridViewProductIncludedItems.Columns.Clear();
            dataGridViewProductIncludedItems.DataSource = dtPartsUsed;
        }


        //Event Handlers

        /// <summary>
        /// Search for Parts when Search button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_SearchPartsNProduct_Click_1(object sender, EventArgs e)
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
        /// Save the product when Save is pressed, show error if not
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_SaveProduct_Click_1(object sender, EventArgs e)
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
        /// Delete the part from the list of associated parts with the object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_DeletePartFromProduct_Click_1(object sender, EventArgs e)
        {
            //Get the selected index
            int selectedIndex = dataGridViewProductIncludedItems.CurrentCell.RowIndex;
            //Get the ID value of the selected value
            string blah = dataGridViewProductIncludedItems.CurrentCell.Value.ToString();
            string selectedValue = dataGridViewProductIncludedItems.SelectedCells[0].Value.ToString();
            int selectedRowID = Convert.ToInt32(selectedValue);

            // Remove the part from the Product Object with the given Part ID
            newProduct.removeAssociatedPart(selectedRowID);

            //Remove the part from the Datatable at the index it is
            dtPartsUsed.Rows.RemoveAt(selectedIndex);
        }

        /// <summary>
        /// Close the form when cancel is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_CancelProduct_Click_1(object sender, EventArgs e)
        {
            //Close Secondary Form
            Close();
        }

        /// <summary>
        /// Add a part to the product when Add button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_AddPartsToProduct_Click_1(object sender, EventArgs e)
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



        //Functions used to use in multiple event handlers/return to parent Forms

        /// <summary>
        /// Adds a row to the used parts list
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
            newProduct.addAssociatedPart(pt.getPartId());
        }
    
        /// <summary>
        /// Reload the Parts available DataTable
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
       /// Reloads the Used Parts Table
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
        /// Creates a new Product object
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
                foreach (var associatedPart in numOfAssociatedParts)
                {
                    totalCost += associatedPart.getPrice();
                }
                if (totalCost > price)
                {
                    generalExceptionString = "\n\nPrice of Product cannot exceed the total cost of the parts\n\n";
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
        /// Returns true if a variable named success if a Product object creation is successfull
        /// </summary>
        /// <returns></returns>
        public bool getSuccess()
        {
            return success;
        }

        /// <summary>
        /// Returns the updated product
        /// </summary>
        /// <returns></returns>
        public Product GetProduct()
        {
            return newProduct;
        }
    }
}
