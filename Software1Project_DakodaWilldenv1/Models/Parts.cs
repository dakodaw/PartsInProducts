using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software1Project_DakodaWilldenv1
{
    public abstract class Part 
    {
        //Variables/Properties
        private int partId { get; set; }
        private string name { get; set; }
        private double price { get; set; }
        private int inStock { get; set; }
        private int min { get; set; }
        private int max { get; set; }
        private int machineID { get; set; }
        private string companyName { get; set; }


        //Get and Set Methods
        /// <summary>
        /// Sets object name
        /// </summary>
        /// <param name="Name"></param>
        public void setName(string Name)
        {
            name = Name;
        }
        /// <summary>
        /// Returns object name
        /// </summary>
        /// <returns></returns>
        public string getName()
        {
            return name;
        }

        /// <summary>
        /// Sets price
        /// </summary>
        /// <param name="Price"></param>
        public void setPrice(double Price)
        {
            price = Price;
        }
        /// <summary>
        /// Returns price
        /// </summary>
        /// <returns></returns>
        public double getPrice()
        {
            return price;
        }

        /// <summary>
        /// Sets Inventory Level
        /// </summary>
        /// <param name="InStock"></param>
        public void setInStock(int InStock)
        {
            inStock = InStock;
        }
        /// <summary>
        /// Returns Inventory Level
        /// </summary>
        /// <returns></returns>
        public int getInStock()
        {
            return inStock;
        }

        /// <summary>
        /// Sets Min Inventory Level
        /// </summary>
        /// <param name="Min"></param>
        public void setMin(int Min)
        {
            min = Min;
        }
        /// <summary>
        /// Returns Min Inventory Level
        /// </summary>
        /// <returns></returns>
        public int getMin()
        {
            return min;
        }

        /// <summary>
        /// Sets Max Inventory Level
        /// </summary>
        /// <param name="Max"></param>
        public void setMax(int Max)
        {
            max = Max;
        }
        /// <summary>
        /// Returns Max Inventory Level
        /// </summary>
        /// <returns></returns>
        public int getMax()
        {
            return max;
        }

        /// <summary>
        /// Sets Part ID
        /// </summary>
        /// <param name="PartId"></param>
        public void setPartID(int PartId)
        {
            partId = PartId;
        }
        /// <summary>
        /// Returns Part ID
        /// </summary>
        /// <returns></returns>
        public int getPartId()
        {
            return partId;
        }

        /// <summary>
        /// Sets Machine ID
        /// </summary>
        /// <param name="MachineID"></param>
        public virtual void setMachineID(int MachineID)
        {
            machineID = MachineID;
        }
        /// <summary>
        /// Returns Machine ID
        /// </summary>
        /// <returns></returns>
        public virtual int getMachineID()
        {
            return machineID;
        }

        /// <summary>
        /// Sets Company Name of Outsourced Objects
        /// </summary>
        /// <param name="CompanyName"></param>
        public virtual void setCompanyName(string CompanyName)
        {
            companyName = CompanyName;
        }
        /// <summary>
        /// Returns Company name of Outsourced Objects
        /// </summary>
        /// <returns></returns>
        public virtual string getCompanyName()
        {
            return companyName;
        }
    }
}
