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
    public partial class Frm_AddPart : Form
    {
        // Variables for class use
        private Part newPart;
        private bool success = false;
        private string generalExceptionString = "Conversions Failed. One or more types are not correct.\n They should be the following: \n Name = string \ninv = int \nprice = double \nmax = int \nmin = int \nmachine id = int";

        //CONSTRUCTORS

        /// <summary>
        /// Main Constructor
        /// </summary>
        public Frm_AddPart()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor for Modifying old parts
        /// </summary>
        /// <param name="oldPart"></param>
        public Frm_AddPart(Part oldPart)
        {
            InitializeComponent();
            this.Text = "Modify Part";
            
            // Set the Main Label to Modify Part instead of Add Part
            Lbl_AddPartMain.Text = "Modify Part";

            //Populate the form with the values from the Part
            Txt_PartId.Text = oldPart.getPartId().ToString();
            Txt_PartInv.Text = oldPart.getInStock().ToString();
            Txt_PartMax.Text = oldPart.getMax().ToString();
            Txt_PartMin.Text = oldPart.getMin().ToString();
            Txt_PartName.Text = oldPart.getName().ToString();
            Txt_PartPrice.Text = oldPart.getPrice().ToString();
            if(oldPart.GetType().ToString() == "Software1Project_DakodaWilldenv1.Models.Outsourced")
            {
                Txt_PartsCompanyName.Text = oldPart.getCompanyName().ToString();
                RBtn_Outsourced.Checked = true;
                RBtn_InHouse.Checked = false;
            }
            else
            {
                Txt_PartsMachineID.Text = oldPart.getPartId().ToString();
                RBtn_Outsourced.Checked = false;
                RBtn_InHouse.Checked = true;
            }

        }


        //EVENT HANDLERS

        /// <summary>
        /// When Radio Button named outsourced is selected, allow user to enter Company name, and make the Machine ID disappear
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RBtn_Outsourced_CheckedChanged(object sender, EventArgs e)
        {
            //Make Company Textbox Visible
            Txt_PartsCompanyName.Visible = true;
            Txt_PartsCompanyName.Enabled = true;
            Lbl_PartsCompanyName.Visible = true;

            //Make Machine ID Textbox Invible
            Txt_PartsMachineID.Visible = false;
            Txt_PartsMachineID.Enabled = false;
            Lbl_PartsMachineID.Visible = false;
        }

        /// <summary>
        /// Cancel Adding the part
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_PartAddCancel_Click(object sender, EventArgs e)
        {
            //Close Secondary Form
            Frm_AddPart.ActiveForm.Close();
        }

        /// <summary>
        /// Make Company Name Disappear, and the Machine ID appear when the In-House Radio Button is Selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RBtn_InHouse_CheckedChanged(object sender, EventArgs e)
        {
            //Make Company Textbox invisible
            Txt_PartsCompanyName.Visible = false;
            Txt_PartsCompanyName.Enabled = false;
            Lbl_PartsCompanyName.Visible = false;

            //Make Machine ID Textbox Visible
            Txt_PartsMachineID.Visible = true;
            Txt_PartsMachineID.Enabled = true;
            Lbl_PartsMachineID.Visible = true;
        }

        /// <summary>
        /// Saves the part when save button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_AddPartSave_Click(object sender, EventArgs e)
        {
            try
            {
                //Create an object of a Part, whether it be Inhouse our Outsourced
                CreateNewPart();

                //Close Secondary Form
                Close();
            }
            catch(Exception newException)
            {
                MessageBox.Show(newException.ToString());
            }
        }


        //OTHER METHODS

        /// <summary>
        /// Creates the new object to return if successful when the saved button is pressed
        /// </summary>
        /// <returns> Part to add to Inventory</returns>
        private void CreateNewPart()
        {
            //if the inhouse part is selected, create a new Inhouse object. Otherwise, create an outsourced Object
            if (RBtn_InHouse.Checked == true)
            {
                //Create Inhouse Object and fill it with the properties from the textboxes
                newPart = new Inhouse();
                //Try to convert from textboxes to given types.
                try
                {
                    int inStock = Convert.ToInt32(Txt_PartInv.Text);
                    newPart.setInStock(inStock);
                    int machineID = Convert.ToInt32(Txt_PartsMachineID.Text);
                    newPart.setMachineID(machineID);
                    int max = Convert.ToInt32(Txt_PartMax.Text);
                    newPart.setMax(max);
                    int min = Convert.ToInt32(Txt_PartMin.Text);
                    newPart.setMin(min);
                    string name = Txt_PartName.Text.ToString();
                    newPart.setName(name);
                    double price = Convert.ToDouble(Txt_PartPrice.Text);
                    newPart.setPrice(price);

                    //set success = true if it works
                    success = true;

                    //If Max is less than min, then throw an exception
                    if (max < min)
                    {
                        generalExceptionString = "\n\nError. Max value may not be smaller than Min Value\n\n";
                        throw new Exception(generalExceptionString);
                    }
                }
                catch
                {
                    throw new Exception(generalExceptionString);
                }
            }
            else
            {
                newPart = new Outsourced();
                try
                {
                    int inStock = Convert.ToInt32(Txt_PartInv.Text);
                    newPart.setInStock(inStock);
                    string companyName = Txt_PartsMachineID.Text.ToString();
                    newPart.setCompanyName(companyName);
                    int max = Convert.ToInt32(Txt_PartMax.Text);
                    newPart.setMax(max);
                    int min = Convert.ToInt32(Txt_PartMin.Text);
                    newPart.setMin(min);
                    string name = Txt_PartName.Text.ToString();
                    newPart.setName(name);
                    double price = Convert.ToDouble(Txt_PartPrice.Text);
                    newPart.setPrice(price);

                    //set success = true if it works
                    success = true;
                }
                catch
                {
                    throw new Exception("Conversions Failed. One or more types are not correct.\n They should be the following: \n Name = string \ninv = int \nprice = double \nmax = int \nmin = int \ncompany name = string");
                }
            }
        }

        /// <summary>
        /// Returns true if Part is created successfully
        /// </summary>
        /// <returns></returns>
        public bool getSuccess()
        {
            return success;
        }

        /// <summary>
        /// Returns Newly Created Part
        /// </summary>
        /// <returns></returns>
        public Part getNewPart()
        {
            return newPart;
        }
    }
}
