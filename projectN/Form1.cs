using projectN.BranchConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace projectN
{
    public partial class Form1 : Form
    {
        SQL sq = new SQL();
        syl snc = new syl();
        IPCON cn = new IPCON();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(comboBox1.Text.ToString() == "CBD")
            {
                DataTable total_sale = new DataTable();
                DataTable oeSales = new DataTable();

                oeSales = sq.get_rs("select * from OESalesSummery");
                total_sale = sq.get_rs("select sum(INVNETH) as TOTAL from OESalesSummery");


                //textBox2.Text = oeSales.Rows.Count.ToString();

                foreach (DataRow row in total_sale.Rows)
                {


                    //textBox1.Text = row["TOTAL"].ToString();


                }


                DataTable Total_saleSn = new DataTable();
                DataTable oeSalesSn = new DataTable();

                Total_saleSn = snc.get_rs("select sum(INVNETH) as TOTAL from OESalesSummery");
                oeSalesSn = cn.get_rs("select * FROM [BOGCBD].[dbo].[OESalesSummery]","BOGCBD",  "10.168.12.139");

                textBox1.Text = oeSalesSn.Rows.Count.ToString();
                foreach(DataRow row in Total_saleSn.Rows)
                {
                    //textBox4.Text = row["TOTAL"].ToString();
                }
            }

            else if(comboBox1.Text.ToString() == "HND")
            {
                DataTable Total_saleSn = new DataTable();
                DataTable oeSalesSn = new DataTable();

                Total_saleSn = snc.get_rs("select sum(INVNETH) as TOTAL from OESalesSummery");
                oeSalesSn = cn.get_rs("select * FROM [BOGHND].[dbo].[OESalesSummery]", "BOGHND", "10.168.12.139");

                textBox2.Text = oeSalesSn.Rows.Count.ToString();
            }

            

         


       

            


            





        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
