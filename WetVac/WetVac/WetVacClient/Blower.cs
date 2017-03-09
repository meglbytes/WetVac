using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogFile;
using System.Threading;
using System.IO;
using System.Data;
using System.Xml;
using WetVacClient;

namespace WetVacClient
{
    public class Blower
    {
        public bool Valid;
        public string Model ;
        public string Series ;
        public string Brand ;
        public double CFR;
        public double Slip_RPM;
        public double FHP;
        public int Max_RPM;
        public double Pmax;
        public int RPM;
        public double Inlet_Temp;
        public double Inlet_Pressure;
        public double Discharge_Temp;
        public double Discharge_Pressure;
        public double HP;
        public double Torque;



        #region Public Methods
        public void UpdateBlowerFromData()
        {
            if (this.Model != ""  && this.Series !="" && this.Brand !="" && this.Valid == true)
            {
                DataSet blowerData = XmlDataSource.DataSet;

                DataTable blowerTable = blowerData.Tables["blower"];

                CFR = (from records 
                       in blowerTable.AsEnumerable()
                       where records.Field<string>("MODEL") == this.Model
                       && records.Field<string>("SERIES") == this.Series
                       && records.Field<string>("BRAND") == this.Brand
                       select records.Field<double>("CFR")).FirstOrDefault();

                Slip_RPM = (from records
                       in blowerTable.AsEnumerable()
                       where records.Field<string>("MODEL") == this.Model
                       && records.Field<string>("SERIES") == this.Series
                       && records.Field<string>("BRAND") == this.Brand
                       select records.Field<double>("SLIP_RPM")).FirstOrDefault();

                FHP = (from records
                       in blowerTable.AsEnumerable()
                       where records.Field<string>("MODEL") == this.Model
                       && records.Field<string>("SERIES") == this.Series
                       && records.Field<string>("BRAND") == this.Brand
                       select records.Field<double>("FHP")).FirstOrDefault();

                Max_RPM = (from records
                       in blowerTable.AsEnumerable()
                       where records.Field<string>("MODEL") == this.Model
                       && records.Field<string>("SERIES") == this.Series
                       && records.Field<string>("BRAND") == this.Brand
                       select records.Field<int>("MAX_RPM")).FirstOrDefault();

                Pmax = (from records
                       in blowerTable.AsEnumerable()
                       where records.Field<string>("MODEL") == this.Model
                       && records.Field<string>("SERIES") == this.Series
                       && records.Field<string>("BRAND") == this.Brand
                       select records.Field<double>("PMAX")).FirstOrDefault();

            }
        }

   
        //Updateblowerfromdata
        //    use model and series to finde CFR Slip_RPM Max_RPM PMax

        //public void UpdateBlower()
        //{
        //    var 
        //}


        //var comboBoxValues = (from records
        //                         in blowerTable.AsEnumerable()
        //                      where records.Field<string>("SERIES") == series.SelectedItem.ToString()
        //                      where records.Field<string>("BRAND") == brand.SelectedItem.ToString()
        //                      select records.Field<string>("MODEL")
        //                         );

        #endregion

        #region Private Methods

        #endregion
              
    }
    }

