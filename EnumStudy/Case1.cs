using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnumStudy
{
    public partial class Case1 : Form
    {
        public Case1()
        {
            InitializeComponent();
        }

        private void btnIslemYap_Click(object sender, EventArgs e)
        {
            DoOperation();
        }

        void DoOperation()
        {
            try
            {
                if (lbCitiesList.SelectedItem != null)
                {
                    foreach (Cities city in Enum.GetValues(typeof(Cities)))
                    {
                        if (lbCitiesList.SelectedItem.ToString() == city.ToString())
                        {
                            MessageBox.Show(((int)city) + " is the index number of " + city + " city.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("You need to select a city to see its index value");
                }
            }
            catch (NullReferenceException nre)
            {
                MessageBox.Show(nre.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("A problem occured");
            }
        }

        private void Case1_Load(object sender, EventArgs e)
        {
            lbCitiesList.Items.AddRange(Enum.GetNames(typeof(Cities)));
        }
    }
}
