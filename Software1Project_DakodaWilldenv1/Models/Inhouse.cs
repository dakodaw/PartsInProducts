using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software1Project_DakodaWilldenv1.Models
{
    public class Inhouse:Part
    {
        // Private Variables
        private int machineID { get; set; }

        //CONSTRUCTORS

        /// <summary>
        /// Main Constructor
        /// </summary>
        public Inhouse()
        {

        }

        /// <summary>
        /// Constructor to Initialize Object with Given Values
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Price"></param>
        /// <param name="InStock"></param>
        /// <param name="Min"></param>
        /// <param name="Max"></param>
        /// <param name="MachineID"></param>
        public Inhouse(string Name, double Price, int InStock, int Min, int Max, int MachineID)
        {
            //Set Everything but the Part ID, which will take place in the Inventory Class so the parts will be in sequence.
            setName(Name);
            setPrice(Price);
            setInStock(InStock);
            setMin(Min);
            setMax(Max);
            setMachineID(MachineID);
        }
        

        //OTHER METHODS

        /// <summary>
        /// Sets the Machine ID
        /// </summary>
        /// <param name="MachineID"></param>
        public override void setMachineID(int MachineID)
        {
            machineID = MachineID;
        }
        /// <summary>
        /// Returns the MachineID
        /// </summary>
        /// <returns></returns>
        public override int getMachineID()
        {
            return machineID;
        }
    }
}
