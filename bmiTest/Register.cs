using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bmiTest
{
    public partial class MainApp
    {
        private void textboxCM_TextChanged(object sender, EventArgs e)
        {
            if (textboxCM.TextLength >= 3)
            {
                this.ActiveControl = textboxKG;
            }
        }

        private void textboxKG_TextChanged(object sender, EventArgs e)
        {
            if (textboxKG.TextLength >= 3)
            {
                this.ActiveControl = btnCal;
            }
        }
    }    
}
