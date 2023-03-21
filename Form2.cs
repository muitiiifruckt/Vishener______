using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Первая_пара_тимп
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox1.Text = Convert.ToString(key_class.index_of_repeat);
            textBox2.Text = Convert.ToString(key_class.len);
        }
        
        
    }
}
