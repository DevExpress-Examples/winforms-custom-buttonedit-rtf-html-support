using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DevExpress.XtraEditors.Repository;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        string HtmlString = @"<html>
<body>

<h1>My First Heading</h1>

<p>My first paragraph.</p>

</body>
</html>
";

        public Form1()
        {
            InitializeComponent();
            myButtonEdit1.EditValue = HtmlString;
        }
    }
}
