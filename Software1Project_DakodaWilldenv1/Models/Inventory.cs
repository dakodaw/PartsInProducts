using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software1Project_DakodaWilldenv1.Models
{
    public class Inventory
    {
        // Create Lists of Products and Parts to keep track of them 
        private List<Product> Products = new List<Product>();
        private List<Part> allParts = new List<Part>();
        private int nonExistantID = -1;

        //Create Functions to add, remove, update, and lookup parts and products

            //PRODUCT METHODS
        /// <summary>
        /// Adds a product to the inventory of Products
        /// </summary>
        /// <param name="newProduct"></param>
        public void addProduct(Product newProduct)
        {
            //Get the number of Parts already in the List of Parts. 
            //Because the index starts at 0, and the count begins with one, we will use the count as the new highest index for the new Part
            int numProducts = Products.Count();

            //set the PartID for the new Part
            newProduct.setProductID(numProducts);

            //Add the part to the List of Parts in Inventory
            Products.Add(newProduct);
        }

        /// <summary>
        /// Returns true if a Product is successfully removed from Inventory
        /// </summary>
        /// <param name="ProductID"></param>
        /// <returns></returns>
        public bool removeProduct(int ProductID)
        {
            try
            {
                Product oldProduct = lookupProduct(ProductID);
                Products.Remove(oldProduct);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Looks up a Product by product ID, and returns the product
        /// </summary>
        /// <param name="ProductID"></param>
        /// <returns></returns>
        public Product lookupProduct(int ProductID)
        {
            foreach (Product aProduct in Products)
            {
                if (ProductID == aProduct.getProductID())
                {
                    return aProduct;
                }
            }
            //Create a dummy Variable with the partID as -1 to use as an error check. Developer can check for -1 to notify user that part doesn't exist.
            Product dummyProduct = new Product(this);
            dummyProduct.setProductID(nonExistantID);
            return dummyProduct;
        }

        /// <summary>
        /// Updates a Given Product in Inventory
        /// </summary>
        /// <param name="ProductID"></param>
        /// <param name="updatedProduct"></param>
        public void updateProduct(int ProductID, Product updatedProduct)
        {
            var currentProduct = lookupProduct(ProductID);
            //Check if the ID isn't negative one to make sure it's a real ID
            if (currentProduct.getProductID() != nonExistantID)
            {
                //Find the index of the product with the ID looked up since it won't always be the same
                int currentIndex = Products.IndexOf(currentProduct);

                //Set the values of the product with the updated product
                currentProduct.setInStock(updatedProduct.getInStock());
                currentProduct.setMax(updatedProduct.getMax());
                currentProduct.setMin(updatedProduct.getMin());
                currentProduct.setName(updatedProduct.getName());
                currentProduct.setPrice(updatedProduct.getPrice());
                currentProduct.setAssociatedParts(updatedProduct.getAssociatedParts());
            }
        }

        /// <summary>
        /// Returns the Number of Products in Inventory
        /// </summary>
        /// <returns></returns>
        public int getProductsCount()
        {
            return Products.Count();
        }

        /// <summary>
        /// Returns list of Products from Inventory
        /// </summary>
        /// <returns></returns>
        public List<Product> GetProducts()
        {
            return Products;
        }

            //PART METHODS

        /// <summary>
        /// Adds a Part to Inventory
        /// </summary>
        /// <param name="newPart"></param>
        public void addPart(Part newPart)
        {
            //Get the number of Parts already in the List of Parts. 
            //Because the index starts at 0, and the count begins with one, we will use the count as the new highest index for the new Part
            int numParts = allParts.Count();
            
            //set the PartID for the new Part
            newPart.setPartID(numParts);

            //Add the part to the List of Parts in Inventory
            allParts.Add(newPart);
        }

        /// <summary>
        /// Deletes a Parts Object. Returns True if it's successful, and False if it fails
        /// </summary>
        /// <param name="oldPart"></param>
        /// <returns>True if successful, false if it fails</returns>
        public bool deletePart(Part oldPart)
        {
            try
            {
                allParts.Remove(oldPart);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Search for a Part in Inventory. If the PartID is nonexistant, it returns a dummy object with the ID -1
        /// </summary>
        /// <param name="PartID"></param>
        /// <returns>A Part Object</returns>
        public Part lookupPart(int PartID)
        {
            foreach(Part aPart in allParts)
            {
                if (PartID == aPart.getPartId())
                {
                    return aPart;
                }
            }
            //Create a dummy Variable with the partID as -1 to use as an error check. Developer can check for -1 to notify user that part doesn't exist.
            Part dummyPart = new Inhouse();
            dummyPart.setPartID(nonExistantID);
            return dummyPart;
        }

        /// <summary>
        /// Update Parts with Given ID and object
        /// </summary>
        /// <param name="PartID"></param>
        /// <param name="updatedPart"></param>
        public void updatePart(int PartID, Part updatedPart)
        {
            //lookup the part in Inventory with the Part ID so we can ensure that the part is in Inventory
            var currentPart = lookupPart(PartID);
            if(currentPart.getPartId() != nonExistantID)
            { 
                int currentIndex = allParts.IndexOf(currentPart);
                //Set the Object in Inventory's values to the values in the Part Object
                allParts.ElementAt(currentIndex).setInStock(updatedPart.getInStock());
                allParts.ElementAt(currentIndex).setMax(updatedPart.getMax());
                allParts.ElementAt(currentIndex).setMin(updatedPart.getMin());
                allParts.ElementAt(currentIndex).setName(updatedPart.getName());
                allParts.ElementAt(currentIndex).setPrice(updatedPart.getPrice());


                //Check if the part is an Inhouse or Outsourced Part
                var inCheck = allParts.ElementAt(currentIndex).GetType();

                //Check the type of Object to determine whether to update the machineID or the companyName
                if (inCheck.ToString() == "Software1Project_DakodaWilldenv1.Models.Inhouse")
                {
                    allParts.ElementAt(currentIndex).setMachineID(updatedPart.getMachineID());
                }
                else if(inCheck.ToString() == "Software1Project_DakodaWilldenv1.Models.Outsourced")
                {
                    allParts.ElementAt(currentIndex).setCompanyName(updatedPart.getCompanyName());
                }
                else
                {
                    MessageBox.Show("Update Failed! Unable to Cast Part to Inhouse or Outsourced.");
                }
            }
        }

        /// <summary>
        /// Returns the Number of Parts in Inventory
        /// </summary>
        /// <returns></returns>
        public int getPartsCount()
        {
            return allParts.Count();
        }

        /// <summary>
        /// Returns list of Parts in Inventory
        /// </summary>
        /// <returns></returns>
        public List<Part> GetParts()
        {
            return allParts;
        }
    }
}
