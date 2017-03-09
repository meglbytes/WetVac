using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WetVacClient;
using Globals;

namespace WetVacClient
{
  public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            addHandlers();
            Global.InstantiateBlowerObj();
            InitializeComboboxes();
            blowerObjectUpdate();
        }
     
        #region Private Methods

        #region Updates
        
        public void blowerObjectUpdate ()     
        {
           IsValid();
           for (int i = 1; i < 4; i++) // Replace 4 with array length...dynamic #
           
            { 
                switch (i)
                {
                    case 1:
                        //Global._Blower[i].Model = comboboxBlower1Model.SelectedText.ToString();
                        Global._Blower[i].Series = comboboxBlower1Series.SelectedText.ToString();
                        //Global._Blower[i].Brand = comboboxBlower1Brand.SelectedText.ToString();
                        Global._Blower[i].RPM = Convert.ToInt32(textboxBlower1RPM.Text);          
                        Global._Blower[i].Inlet_Temp = Conversions.convertTempurature(double.Parse(textboxBlower1InletTemp.Text) , comboboxBlower1InletTempUnits.SelectedItem.ToString());  
                        Global._Blower[i].Inlet_Pressure = Conversions.convertPressure(double.Parse(textboxBlower1InletPressure.Text) , comboboxBlower1InletPressureUnits.SelectedItem.ToString());
                        
                        break;

                    case 2:
                        //Global._Blower[i].Model = comboboxBlower2Model.SelectedText.ToString();
                        Global._Blower[i].Series = comboboxBlower2Series.SelectedText.ToString();
                        //Global._Blower[i].Brand = comboboxBlower2Brand.SelectedItem.ToString();
                        Global._Blower[i].RPM = Convert.ToInt32(textboxBlower2RPM.Text);

                        break;

                    case 3:
                        //Global._Blower[i].Model = comboboxBlower3Model.SelectedText.ToString();
                        Global._Blower[i].Series = comboboxBlower3Series.SelectedText.ToString();
                        //Global._Blower[i].Brand = comboboxBlower3Brand.SelectedText.ToString();
                        Global._Blower[i].RPM = Convert.ToInt32(textboxBlower3RPM.Text);
                        
                        break;
                       
                }
               Global._Blower[i].UpdateBlowerFromData();
               //Global._Blower[i].CalculatePerformance();
            }
        }

        #endregion 
        
        #region UI  

        private void IsValid()
        {
            if (groupboxBlower1.Enabled == true)
            {
                Global._Blower[1].Valid = true;
            }
            else
            {
                Global._Blower[1].Valid = false;
            }
            if (groupboxBlower2.Enabled == true)
            {
                Global._Blower[2].Valid = true;
            }
            else
            {
                Global._Blower[2].Valid = false;
            }
            if (groupboxBlower3.Enabled == true)
            {
                Global._Blower[3].Valid = true;
            }
            else
            {
                Global._Blower[3].Valid = false;
            }
            
        }

        private void ShowHideBlower2()
        {
            if (groupboxBlower2.Visible == false)
            {
                groupboxBlower2.Visible = true;
            }
            else if (groupboxBlower2.Visible == true)
            {
                groupboxBlower2.Visible = false;
                groupboxBlower2.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error on ShowHideBlower2 Method");
                throw new NotImplementedException();
            }

        }

        private void ShowHideBlower3()
        {
            if (groupboxBlower3.Visible == false)
            {
                groupboxBlower3.Visible = true;
                buttonAddBlower1.Enabled = false;
            }
            else if (groupboxBlower3.Visible == true)
            {
                groupboxBlower3.Visible = false;
                buttonAddBlower1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error on ShowHideBlower2 Method");
                throw new NotImplementedException();
            }
        }

        #endregion

        #region ComboBoxes

        private void InitializeComboboxes()
        {
            populateBrandCombo(comboboxBlower1Series, comboboxBlower1Brand);
            populateBrandCombo(comboboxBlower2Series, comboboxBlower2Brand);
            populateBrandCombo(comboboxBlower3Series, comboboxBlower3Brand);
        }

        public void populateBrandCombo(ComboBox series, ComboBox brand)
        {
            DataSet blowerData = XmlDataSource.DataSet;

            DataTable blowerTable = blowerData.Tables["blower"];

            var brandBoxValues = (from records
                                  in blowerTable.AsEnumerable()
                                  where records.Field<string>("SERIES") == series.SelectedItem.ToString()
                                  select records.Field<string>("BRAND")
                                  );

            foreach (var brandBoxValue in brandBoxValues)
            {
                brand.Items.Add(brandBoxValue);
            }
            brand.Items.Clear();
        }

        private static void populateModelCombo(ComboBox series, ComboBox model, ComboBox brand)
        {
            DataSet blowerData = XmlDataSource.DataSet;

            DataTable blowerTable = blowerData.Tables["blower"];


            var comboBoxValues = (from records
                                  in blowerTable.AsEnumerable()
                                  where records.Field<string>("SERIES") == series.SelectedItem.ToString()
                                  where records.Field<string>("BRAND") == brand.SelectedItem.ToString()
                                  select records.Field<string>("MODEL")
                                  );
            model.Items.Clear();

            foreach (var comboBoxValue in comboBoxValues)
            {
                model.Items.Add(comboBoxValue);
            }
        }

        #endregion

        #endregion Private Methods

        #region Private Events

        private void buttonAddBlower2_Click(object sender, EventArgs e)
        {
            ShowHideBlower3();
        }

        private void buttonAddBlower1_Click(object sender, EventArgs e)
        {
            ShowHideBlower2();
        }
      
        private void textboxBlower1RPM_TextChanged(object sender, EventArgs e)
        {
            textboxBlower2RPM.Text = textboxBlower1RPM.Text;
            textboxBlower3RPM.Text = textboxBlower1RPM.Text;

        }

        private void textboxBlower1InletPressure_TextChanged(object sender, EventArgs e)
        {
            blowerObjectUpdate();
        }

        private void checkBoxAdditonalConditions_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxAdditonalConditions.Checked)
            { groupboxAdditionalConditions.Enabled = true; }

            else
            { groupboxAdditionalConditions.Enabled = false; }
        }

        private void comboboxBlower1Series_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            populateBrandCombo(comboboxBlower1Series, comboboxBlower1Brand);
        }

        private void comboboxBlower2Series_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            populateBrandCombo(comboboxBlower2Series, comboboxBlower2Brand);
        }

        private void comboboxBlower3Series_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            populateBrandCombo(comboboxBlower3Series, comboboxBlower3Brand);
        }

        private void comboboxBlower1Brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateModelCombo(comboboxBlower1Series, comboboxBlower1Model, comboboxBlower1Brand);
        }

        private void comboboxBlower2Brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateModelCombo(comboboxBlower2Series, comboboxBlower2Model, comboboxBlower2Brand);
        }

        private void comboboxBlower3Brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateModelCombo(comboboxBlower3Series, comboboxBlower3Model, comboboxBlower3Brand);
        }


        #endregion

        private void addHandlers()
        {
            //foreach (TextBox control in Controls.OfType<TextBox>())
            //{
            //    control.TextChanged += new EventHandler(OnContentChanged);
            //}
            //foreach (ComboBox control in Controls.OfType<ComboBox>())
            //{
            //    control.SelectedIndexChanged += new EventHandler(OnContentChanged);
            //}
            //foreach (Button control in Controls.OfType<Button>())
            //{
            //    control.Click += new EventHandler(OnContentChanged);
            //}
        }


        //public event EventHandler ContentChanged;
   

      

     
    }
}
