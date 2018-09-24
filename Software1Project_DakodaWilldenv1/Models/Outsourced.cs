using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software1Project_DakodaWilldenv1.Models
{
    public class Outsourced:Part
    {
        private string companyName { get; set; }

        /// <summary>
        /// Main Constructor
        /// </summary>
        public Outsourced()
        {

        }

        /// <summary>
        /// Constructor to set values initially
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Price"></param>
        /// <param name="InStock"></param>
        /// <param name="Min"></param>
        /// <param name="Max"></param>
        /// <param name="CompanyName"></param>
        public Outsourced(string Name, double Price, int InStock, int Min, int Max, string CompanyName)
        {
            //Set Everything but the Part ID, which will take place in the Inventory Class so the parts will be in sequence.
            setName(Name);
            setPrice(Price);
            setInStock(InStock);
            setMin(Min);
            setMax(Max);
            setCompanyName(CompanyName);
        }

        /// <summary>
        /// Sets the Outsourced Company's Name
        /// </summary>
        /// <param name="CompanyName"></param>
        public override void setCompanyName(string CompanyName)
        {
            companyName = CompanyName;
        }

        /// <summary>
        /// Returns the Outsourced Company's Name
        /// </summary>
        /// <returns></returns>
        public override string getCompanyName()
        {
            return companyName;
        }
    }
}
