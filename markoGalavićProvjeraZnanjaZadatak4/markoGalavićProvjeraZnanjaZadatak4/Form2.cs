using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace markoGalavićProvjeraZnanjaZadatak4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        { }
             private Student student1;


        
        public Student Student1
        {
            get
            {
                return student1;
            }
            set
            {
                student1 = value;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            student1 = new Student();
           
            student1.Ime = ime.Text;
            student1.Prezime = prezime.Text;
            student1.BrojIndeksa = Broj.Text;
            student1.Smjer = smjer.SelectedItem.ToString();
            student1.DatumRodjenja = Datum.Value;
            DialogResult = DialogResult.OK;

        }
    }
}

