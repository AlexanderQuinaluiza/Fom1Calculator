using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFconsumiendoWEBserviceNube
{

   
    public partial class Form1 : Form
    {
        /// <summary>
        /// solo se toma en cuenta la referencia al webservice
        /// </summary>
        dniCal.Calculator cal = new dniCal.Calculator();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            label1.Text= "Add "+ cal.Add(100,5)+"mutiplicaccion "+ cal.Multiply(7, 9)
                
                + " division " + cal.Divide(100, 5) + "Subtract " + cal.Subtract(7, 9);





        }
    }
}
