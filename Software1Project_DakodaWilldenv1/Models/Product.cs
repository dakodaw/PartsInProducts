using Software1Project_DakodaWilldenv1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software1Project_DakodaWilldenv1.Models
{
    public class Product
    {
        //Set Properties/variables
        List<Part> associatedParts = new List<Part>();
        Inventory inv = new Inventory();

        private int productID { get; set; }
        private string name { get; set; }
        private double price { get; set; }
        private int inStock { get; set; }
        private int min { get; set; }
        private int max { get; set; }

        int nonExistantID = -1;

        
        //Constructors

        /// <summary>
        /// Main class Constructor requiring an inventory object to use in the class
        /// </summary>
        /// <param name="classInventory"></param>
        public Product(Inventory classInventory)
        {
            inv = classInventory;
        }

        /// <summary>
        /// Constructor to create most of the object at once with values
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Price"></param>
        /// <param name="InStock"></param>
        /// <param name="Min"></param>
        /// <param name="Max"></param>
        /// <param name="AssociatedParts"></param>
        /// <param name="classInventory"></param>
        public Product(string Name, double Price, int InStock, int Min, int Max, List<Part> AssociatedParts, Inventory classInventory)
        {
            setName(Name);
            setPrice(Price);
            setInStock(InStock);
            setMin(Min);
            setMax(Max);
            associatedParts = AssociatedParts;
            inv = classInventory;
        }


        //Create Set and Get Functions
        /// <summary>
        /// Sets name
        /// </summary>
        /// <param name="Name"></param>
        public void setName(string Name)
        {
            name = Name;
        }
        /// <summary>
        /// Returns the name
        /// </summary>
        /// <returns></returns>
        public string getName()
        {
            return name;
        }

        /// <summary>
        /// Sets the price
        /// </summary>
        /// <param name="Price"></param>
        public void setPrice(double Price)
        {
            price = Price;
        }
        /// <summary>
        /// Returns the price
        /// </summary>
        /// <returns></returns>
        public double getPrice()
        {
            return price;
        }

        /// <summary>
        /// Sets the inventory level
        /// </summary>
        /// <param name="InStock"></param>
        public void setInStock(int InStock)
        {
            inStock = InStock;
        }
        /// <summary>
        /// returns the inventory level of a product
        /// </summary>
        /// <returns></returns>
        public int getInStock()
        {
            return inStock;
        }

        /// <summary>
        /// Sets the min value
        /// </summary>
        /// <param name="Min"></param>
        public void setMin(int Min)
        {
            min = Min;
        }
        /// <summary>
        /// Returns the min value
        /// </summary>
        /// <returns></returns>
        public int getMin()
        {
            return min;
        }

        /// <summary>
        /// Sets the Max Value
        /// </summary>
        /// <param name="Max"></param>
        public void setMax(int Max)
        {
            max = Max;
        }
        /// <summary>
        /// Returns the max value
        /// </summary>
        /// <returns></returns>
        public int getMax()
        {
            return max;
        }

        /// <summary>
        /// Sets the Product ID
        /// </summary>
        /// <param name="ProductID"></param>
        public void setProductID(int ProductID)
        {
            productID = ProductID;
        }
        /// <summary>
        /// Returns the Product ID
        /// </summary>
        /// <returns></returns>
        public int getProductID()
        {
            return productID;
        }

        /// <summary>
        /// sets the list of Associated Parts
        /// </summary>
        /// <param name="parts"></param>
        public void setAssociatedParts(List<Part> parts)
        {
            associatedParts = parts;
        }
        /// <summary>
        /// Returns the list of Associated Parts
        /// </summary>
        /// <returns></returns>
        public List<Part> getAssociatedParts()
        {
            return associatedParts;
        }



        //Add, remove, and lookup part functions
        /// <summary>
        /// Adds an existing part in Inventory to the associated parts of the product. Shows an error if it fails.
        /// </summary>
        /// <param name="associatedPart"></param>
        public void addAssociatedPart(int associatedPart)
        {
            //Lookup associated part, and add it to the list of associated Parts
            try
            {
                var addingPart = inv.lookupPart(associatedPart);
                associatedParts.Add(addingPart); 
            }
            catch
            {
                MessageBox.Show("Failed to add. Part doesn't exist");
            }
        }

        /// <summary>
        /// Removes an Associated Part
        /// </summary>
        /// <param name="associatedPart"></param>
        /// <returns></returns>
        public bool removeAssociatedPart(int associatedPart)
        {
            // look up the associated part
            var p = lookupAssociatedPart(associatedPart);
            //Try removing the associated part. Return true if it's successful. Return false if it doesn't return successfull
            try
            {
                associatedParts.Remove(p);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Returns the Part that matches the Part ID entered as a parameter. If the function returns a Part with PartID = -1, there is no match
        /// </summary>
        /// <param name="associatedPart"></param>
        /// <returns></returns>
        public Part lookupAssociatedPart(int associatedPart)
        {
            //Cycle through list of Associated Parts to see if the int given matches the ID of a part in the list
            foreach(var part in associatedParts)
            {
                if (part.getPartId() == associatedPart)
                {
                    return part;
                }
            }
            //Create a dummy Variable with the partID as -1 to use as an error check. Developer can check for -1 to notify user that part doesn't exist.
            Part dummyPart = new Inhouse();
            dummyPart.setPartID(nonExistantID);
            return dummyPart;
        }
    }
}
