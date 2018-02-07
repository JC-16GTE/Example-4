using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GetAndSet
{
    public partial class WebForm1 : System.Web.UI.Page
    {       
        Ibanez    guitar1 = new Ibanez();
        Martin    guitar2 = new Martin();
        ErnieBall guitar3 = new ErnieBall();

        protected void Page_Load(object sender, EventArgs e)
        {
            // Store details for an Ibanez.
            guitar1.Type = "Bass";
            guitar1.FretType = "Fretless - marked";
            guitar1.StringAmount = 5;
            guitar1.Colour = "Sunburst";
            guitar1.Model = "SDGR";
            guitar1.Pickups = 2;

            // Store details for a Martin
            guitar2.Type = "Acoustic";
            guitar2.FretType = "Fretted";
            guitar2.StringAmount = 6;
            guitar2.Colour = "Natural";
            guitar2.Model = "JC16";
            guitar2.Pickups = 1;

            // Store details for an Ernieball
            guitar3.Type = "Electric";
            guitar3.FretType = "Fretted";
            guitar3.StringAmount = 6;
            guitar3.Colour = "Purple";
            guitar3.Model = "silhouette Special";
            guitar3.Pickups = 2;
        }       

        public class Guitar
        {
            // Set properties

            public string Type { get; set; } // Acoustic,Electric,Classical etc
            public string FretType { get; set; } // Fretted, Fretless etc
            public int StringAmount { get; set; } // 4,6,12,16  etc
            public string Colour { get; set; }           
        }

        public class Ibanez : Guitar  
        {
            /*
             * Yamaha will now inherit the properties
             * and methods of Guitar
             */

            // Set properties
            public string Make = "Ibanez";
            public string Model { get; set; }
            public int Pickups { get; set; }
            public double Price { get; set; }


            // Add a public method
            public double PricePlusVat(double Price, double Vat)
            {
              double result;
              result = Vat * Price / 100.0;
              return Price + result;
            }
        }

        public class Martin : Guitar
        {

            /*
             * Martin will now inherit the properties
             * and methods of Guitar
             */

            // Set properties

            public string Make = "Martin";
            public string Model { get; set; }
            public int Pickups { get; set; }
            public double Price { get; set; }
            
            // Add a public method
            public double PricePlusVat(double Price, double Vat)
            {
                double result;
                result = Vat * Price / 100.0;
                return Price + result;
            }
        }

        public class ErnieBall : Guitar
        {

            /*
             * ErnieBall will now inherit the properties
             * and methods of Guitar
             */

            // Set properties

            public string Make = "ErnieBall";
            public string Model { get; set; }
            public int Pickups { get; set; }
            public double Price { get; set; }

            // Add a public method
            public double PricePlusVat(double Price, double Vat)
            {
                double result;
                result = Vat * Price / 100.0;
                return Price + result;
            }
        }

        protected void DisplayGuitarButton_Click(object sender, EventArgs e)
        {
            // Display details for the Ibanez,Martin and Ernieball guitars

            DisplayGuitarLabel1.Font.Name = "Calibri";
            DisplayGuitarLabel1.Font.Size = 12;           
            DisplayGuitarLabel1.Text = guitar1.Make + "<br/>" + guitar1.Type + "<br/>" + string.Format("{0:C2}",guitar1.PricePlusVat(300,20));

            DisplayGuitarLabel2.Font.Name = "Calibri";
            DisplayGuitarLabel2.Font.Size = 12;
            DisplayGuitarLabel2.Text = guitar2.Make + "<br/>" + guitar2.Type + "<br/>" + string.Format("{0:C2}", guitar2.PricePlusVat(1600, 20));

            DisplayGuitarLabel3.Font.Name = "Calibri";
            DisplayGuitarLabel3.Font.Size = 12;
            DisplayGuitarLabel3.Text = guitar3.Make + "<br/>" + guitar3.Type + "<br/>" + string.Format("{0:C2}", guitar3.PricePlusVat(1400, 20));
        }
    }    
}