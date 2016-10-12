using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Laba2
{
    public partial class Form1 : Form
    {


        public List<Test> _test_list = new List<Test>();
        public int current_test;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }




        private void button3_Click(object sender, EventArgs e)
        {
                        int idofdel = int.Parse(textBox6.Text.ToString());

                        try
                        {
                            dataGridView1.Rows.RemoveAt(idofdel);
                        }
                        catch (Exception lol)
                        {
                

                        }

                        for (int i = 0; i < dataGridView1.RowCount; i++)
                        {
                            DataGridViewTextBoxCell mycell = (DataGridViewTextBoxCell)dataGridView1[0, i];
                            mycell.Value = i.ToString();
                        }





        }

        private void button2_Click_1(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {

            SD(0);
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _test_list.Clear();
        }

        public void SD(int trigger)
        {
            if (trigger == 0)
            {
                var xml = new XmlSerializer(typeof(List<Test>));
                var stream = new FileStream(Application.CommonAppDataPath + "Savefile.xml", FileMode.OpenOrCreate);
                xml.Serialize(stream, _test_list);
                stream.Close();
            }
            else
            {
                var nxml = new XmlSerializer(typeof(List<Test>));
                var nstream = new FileStream(Application.CommonAppDataPath + "Savefile.xml", FileMode.OpenOrCreate);
                _test_list = (List<Test>)nxml.Deserialize(nstream);
                nstream.Close();


            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            SD(1);
            
            while (_test_list.Count > dataGridView1.Rows.Count)
            {
                dataGridView1.Rows.Add();
            }

            Test []t = _test_list.ToArray();


            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                DataGridViewTextBoxCell mycell = (DataGridViewTextBoxCell)dataGridView1[0, i];
                mycell.Value = t[i].id;
                mycell = (DataGridViewTextBoxCell)dataGridView1[1, i];
                mycell.Value = t[i].Name;
                mycell = (DataGridViewTextBoxCell)dataGridView1[2, i];
                mycell.Value = t[i].group;
                mycell = (DataGridViewTextBoxCell)dataGridView1[3, i];
                mycell.Value = t[i].mark;
                mycell = (DataGridViewTextBoxCell)dataGridView1[4, i];
                mycell.Value = t[i].Date;
            }


        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {   

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {   DataGridViewTextBoxCell mycell = (DataGridViewTextBoxCell)dataGridView1[0,i];
                mycell.Value = i.ToString();
             }
          


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            _test_list.Clear();

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                Test temp = new Test();
           
                 
                    temp.id = int.Parse(dataGridView1[0, i].Value.ToString());
                    temp.Name = dataGridView1[1, i].Value.ToString();
                    temp.group = dataGridView1[2, i].Value.ToString();
                    temp.mark = int.Parse(dataGridView1[3, i].Value.ToString());
                    temp.Date = dataGridView1[4, i].Value.ToString();

                Console.WriteLine(temp.id.ToString());
                Console.WriteLine(temp.Name);
                Console.WriteLine(temp.mark.ToString());
                Console.WriteLine(temp.Date);
                Console.WriteLine(temp.group);
                 _test_list.Add(temp);


            }

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            int markoffind = int.Parse(textBox1.Text.ToString());

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
              

                Test temp = new Test();


                temp.id = int.Parse(dataGridView1[0, i].Value.ToString());
                temp.Name = dataGridView1[1, i].Value.ToString();
                temp.group = dataGridView1[2, i].Value.ToString();
                temp.mark = int.Parse(dataGridView1[3, i].Value.ToString());
                temp.Date = dataGridView1[4, i].Value.ToString();

                if (temp.mark == markoffind)
                {
                    dataGridView2.Rows.Add(temp.id, temp.Name, temp.group, temp.mark, temp.Date);

                }
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }


    [SerializableAttribute]
    public class Test
    {
        
        public int id, mark;
        public string Name, group, Date;
     /*   
        public Test()
        {
            id = 0;
            mark = 0;
            Name = "lol";
            group = "lol";
            Date = "lol";

        }
        
    */

    }


}



