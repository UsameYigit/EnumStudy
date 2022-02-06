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
    public partial class Case2 : Form
    {
        public Case2()
        {
            InitializeComponent();
        }

        private void Case2_Load(object sender, EventArgs e)
        {
            lbCities.Items.AddRange(Enum.GetNames(typeof(Cities)));
        }

        private void btnControlledEnumValue_Click(object sender, EventArgs e)
        {
            EnumValue(true);
        }
        private void btnEnumValue_Click(object sender, EventArgs e)
        {
            EnumValue(false);
        }

        void EnumValue(bool isControlled)
        {
            try
            {
                if (Enum.IsDefined(typeof(Cities), Convert.ToInt32(txtEntry.Text)))
                {
                    Cities input = (Cities)Enum.Parse(typeof(Cities), txtEntry.Text);
                    
                    if (isControlled)
                    {
                        MessageBox.Show(input.ToString() + " => " + ((int)input));
                        lbCities.SetSelected(lbCities.FindString(input.ToString()), true);
                        ClearTextField();
                    }
                    else
                    {
                        MessageBox.Show(input.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("The index value is not assigned.");
                    ClearTextField();
                }
            }
            catch (ArgumentNullException ane)
            {
                MessageBox.Show(ane.Message);
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                MessageBox.Show(aoore.Message);
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message);
            }
            catch (InvalidOperationException ioe)
            {
                MessageBox.Show(ioe.Message);
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
            catch (OverflowException oe)
            {
                MessageBox.Show(oe.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void ClearTextField()
        {
            txtEntry.Text = "";
        }
    }
}
